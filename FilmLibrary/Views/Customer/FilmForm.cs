using FilmLibrary.DataAcess;
using FilmLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLibrary.Views
{
    public partial class FilmForm : Form
    {
        readonly string filmName;
        SearchResultForm searchResult;
        Film film;
        Manager manager;
        User user;

        public FilmForm(string filmName, SearchResultForm searchResult, User user)
        {
            InitializeComponent();
            this.filmName = filmName;
            manager = Manager.GetManager();
            film = new Film();
            this.searchResult = searchResult;
            this.user = user;
        }

        private async void FilmForm_Load(object sender, EventArgs e)
        {
            var listOfFilms = await manager.filmTable.FindByValue(filmName);
            film = listOfFilms.Where(movie => movie.Name == filmName).SingleOrDefault();
            FillForm(film);

        }

        private async void FillForm(Film film)
        {
            if (film != null)
            {
                movieName.Text = film.Name;
                var genreTemp = await manager.genreTable.FindById(film.GenreId);
                genre.Text = genreTemp.Name;
                year.Text = film.Year.ToString();
                var directorTemp = await manager.directorTable.FindById(film.DirectorId);
                director.Text = directorTemp.Name; 
                var actors = await manager.actorTable.FindByFilmId(film.Id);
                for (int i = 0; i <actors.Count; i++)
                {
                     cast.Text += actors[i].Name + ", ";
                    if(i==actors.Count-1)
                    {
                        cast.Text += actors[actors.Count - 1].Name;
                    }
                }

                //country.Text 
                var countryTemp  = await manager.countryTable.FindById(film.CountryId);
                country.Text = countryTemp.Name;
                summary.Text = film.Summary;
                ImageConverter converter = new ImageConverter();
                pBoxPoster.Image = (Image)converter.ConvertFrom(film.Poster);

                  
                if (film.Rate!=0) rate.Text = film.Rate.ToString();
                else
                    rate.Text = "Not rated yet.";

                if (manager.commentTable.FindByFilmID(film.Id).Count == 0)
                {
                    comments.Text = "No comments yet.";
                }
                else
                {
                    List<string> commentsList = manager.commentTable.FindByFilmID(film.Id).
                        Select(x => x.CommentText).ToList();
                    int index = 1;
                    foreach (var item in commentsList)
                    {
                        comments.Text += index.ToString() + ". " + item + ".\n";
                    }
                } 
            }
        }
       

        private void btnRate_Click(object sender, EventArgs e)
        {
            if (cBoxRate.SelectedItem == null) return;
            int userRate = int.Parse(cBoxRate.SelectedItem.ToString());
            decimal currentRating = film.Rate;

            int peopleRatedNumber = film.PeopleRatedNumber;
           
            double updatedRating;
           
                updatedRating = ((double)currentRating + userRate) / (peopleRatedNumber+1);
                if (manager.filmTable.UpdateRating(film.Id, updatedRating, peopleRatedNumber+1))
                {
                    MessageBox.Show("Film rated successfully.");
                }
                else
                {
                    MessageBox.Show("Ooops! Something went wrong.");
                }
  
        }

        private void FilmForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            searchResult.Visible = true; 
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            CommentForm commentForm = new CommentForm(user, film.Id);
            commentForm.ShowDialog();
         
        }
    }
}
