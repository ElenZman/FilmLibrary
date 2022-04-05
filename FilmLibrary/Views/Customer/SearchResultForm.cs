using FilmLibrary.DataAcess;
using FilmLibrary.Forms;
using FilmLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLibrary.Views
{
    public partial class SearchResultForm : Form
    {
        List<Film> listOfFilms;
        UserWelcomeForm userWelcomeForm;
        Manager manager;
        User user;
        public SearchResultForm(List<Film> list, UserWelcomeForm form, User user)
        {
            InitializeComponent();
            listOfFilms = list;
            userWelcomeForm = form;
            manager = Manager.GetManager();
            this.user = user;

        }

        private void UserSearchResultForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            userWelcomeForm.Visible = true;
        }

        private void UserSearchResultForm_Load(object sender, EventArgs e)
        {
            if (listOfFilms != null && listOfFilms.Count > 0)
            {
                viewSearchResult.Columns.Clear();
                viewSearchResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                viewSearchResult.Columns.Add("No", "No");
                viewSearchResult.Columns[0].Width = 30;
                viewSearchResult.Columns.Add("film", "Film");
                viewSearchResult.Columns[1].Width = 200;
                viewSearchResult.Columns.Add("genre", "Genre");
                viewSearchResult.Columns[2].Width = 100;
                viewSearchResult.Columns.Add("director", "Director");
                viewSearchResult.Columns[3].Width = 100;
                viewSearchResult.Columns.Add("rate", "Rate");
                viewSearchResult.Columns[4].Width = 100;
                viewSearchResult.Columns.Add("cast", "Cast");
                viewSearchResult.Columns[5].Width = 180;
                viewSearchResult.Columns.Add("summary", "Summary");
                viewSearchResult.Columns[6].Width = 250;

                FillListView(listOfFilms);
            }
        }
     
        private async void FillListView(List<Film> list)
        {
            if (list != null)
            {
                int index = 1;

                foreach (var item in list)
                {
                    ListViewItem row = new ListViewItem(index.ToString());
                    row.SubItems.Add(item.Name);
                    var genreTemp = await manager.genreTable.FindById(item.GenreId);
                    row.SubItems.Add(genreTemp.Name);
                    var directorTemp = await manager.directorTable.FindById(item.DirectorId);
                    row.SubItems.Add(directorTemp.Name);
                  
                    if (item.Rate != 0)
                    {
                        row.SubItems.Add(item.Rate.ToString());
                    }
                    else
                    {
                        row.SubItems.Add("Not rated yet");
                    }

                    List<Actor> temp = await manager.actorTable.FindByFilmId(item.Id);
                    List<string> actorsNames = temp.Select(x => x.Name).ToList();
                    string actors = string.Empty;
                    for (int i = 0;  i< actorsNames.Count; i++)
                    {
                        actors += actorsNames[i] + ",";
                        if (i == actorsNames.Count - 1)
                        {
                            actors += actors[actorsNames.Count - 1];
                        }
                    }

                    row.SubItems.Add(actors);    
                    row.SubItems.Add(item.Summary);

                    viewSearchResult.Items.Add(row);
                    index++;

                }
            }

        }

        private void viewSearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {

            var selectedFilm = viewSearchResult.SelectedItems;
            if (selectedFilm[0].SubItems[1].Text != null)
            {
                string filmName = selectedFilm[0].SubItems[1].Text;
                FilmForm filmForm = new FilmForm(filmName, this, user);
                this.Visible = false;
                filmForm.Show();
            }
            return;
        }
    }
    
}    
       

