using FilmLibrary.DataAcess;
using FilmLibrary.Models;
using FilmLibrary.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLibrary.Forms
{
    public partial class UserWelcomeForm : Form
    {

        AuthorizationForm authorizationForm;
        RegistrationForm registrationForm;
        List<string> actorsList;
        List<string> directorsList;
        List<string> genresList;
        Manager manager;
        SearchResultForm userSearchResultform;
        User user;
        public UserWelcomeForm(User user, AuthorizationForm formAuth, RegistrationForm formReg)
        {
            InitializeComponent();
            authorizationForm = formAuth;
            registrationForm = formReg;
            manager = Manager.GetManager();
            this.user = user;

        }

        private async void UserWelcomeForm_Load(object sender, EventArgs e)
        {
            authorizationForm.Visible = false;
            registrationForm.Close();
            lbWelcome.Text = "Hi, " + user.Name + "!";
            lbWelocmeText.Text = "Welcome to our Film Library." + "\n" + "Choose a movie to your taste and enjoy your time!";

            //для автозаполнения комбобоксов
            List<Actor> actors = await manager.actorTable.FindAll();
            actorsList = (from actor in actors
                          select actor.Name).ToList();
            List<Director> directors = await manager.directorTable.FindAll();
            directorsList = (from director in directors
                             select director.Name).ToList();
            List<Genre> genres = await manager.genreTable.FindAll();
            genresList = (from genre in genres
                          select genre.Name).ToList();
            var autoCompleteActors = new AutoCompleteStringCollection();
            autoCompleteActors.AddRange(actorsList.ToArray());
            cBoxActor.AutoCompleteCustomSource = autoCompleteActors;
            cBoxActor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cBoxActor.AutoCompleteMode = AutoCompleteMode.Suggest;

            cBoxActor.DisplayMember = "Name";
            cBoxActor.ValueMember = "Id";

            var autoCompleteDirectors = new AutoCompleteStringCollection();
            autoCompleteDirectors.AddRange(directorsList.ToArray());
            cBoxDirectors.AutoCompleteCustomSource = autoCompleteDirectors;
            cBoxDirectors.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cBoxDirectors.AutoCompleteMode = AutoCompleteMode.Suggest;

            cBoxDirectors.DisplayMember = "Name";
            cBoxDirectors.ValueMember = "Id";

            var autoCompleteGenres = new AutoCompleteStringCollection();
            autoCompleteGenres.AddRange(genresList.ToArray());
            cBoxGenre.AutoCompleteCustomSource = autoCompleteGenres;
            cBoxGenre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cBoxGenre.AutoCompleteMode = AutoCompleteMode.Suggest;

            cBoxGenre.DisplayMember = "Name";
            cBoxGenre.ValueMember = "Id";

        }

        private async void btnFindFilmByName_Click(object sender, EventArgs e)
        {
            tbFilmName.ForeColor = Color.Black;
            string film = tbFilmName.Text;
            if (film != string.Empty)
            {
                var list = await manager.filmTable.FindByValue(tbFilmName.Text);
                if (list == null || list.Count > 0)
                {
                    userSearchResultform = new SearchResultForm(list, this, user);
                    userSearchResultform.Show();
                    this.Visible = false;
                }
                else
                {
                    NotFoundForm notFound = new NotFoundForm();
                    notFound.ShowDialog();
                }
            }
            else
            {
                tbFilmName.Text = "Please enter any film name...";
                tbFilmName.ForeColor = Color.White;

                return;
            }

        }

        private void UserWelcomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            authorizationForm.Visible = true;
        }


        private async void btnFindFilmByActor_Click(object sender, EventArgs e)
        {

            List<Film> selectedFilms;
            string actorName = cBoxActor.Text;
            if (actorName == string.Empty) return;

            if (actorName == "All")

            {
                selectedFilms = await manager.filmTable.FindAll();
                if (selectedFilms != null || selectedFilms.Count > 0)
                {
                    userSearchResultform = new SearchResultForm(selectedFilms, this, user);
                    userSearchResultform.Show();
                    this.Visible = false;
                }
                else
                {
                    NotFoundForm notFound = new NotFoundForm();
                    notFound.ShowDialog();
                }
            }
            else
            {
                selectedFilms = manager.filmTable.FindByActorName(actorName);
                if (selectedFilms == null || selectedFilms.Count == 0)
                {
                    NotFoundForm notFound = new NotFoundForm();
                    notFound.ShowDialog();
                }
                else
                {
                    userSearchResultform = new SearchResultForm(selectedFilms, this, user);
                    userSearchResultform.Show();
                    this.Visible = false;
                }

            }
        }

        private async void btnOtherSearchOptions_Click(object sender, EventArgs e)
        {


            if (cBoxGenre.Text == string.Empty || cBoxRate.SelectedItem == null || cBoxDirectors.Text == string.Empty) return;
            string genre = cBoxGenre.Text;
            string rate = cBoxRate.SelectedItem.ToString();
            string directorName = cBoxDirectors.Text;

            //выгружаются все фильмы
            List<Film> allFillms = await manager.filmTable.FindAll();

            //если пользователь выбирает Все в каждой из категорий поиска
            if (allFillms.Count > 0 && allFillms != null)
            {
                //1
                if (genre == "All" && rate == "All" && directorName == "All")
                {



                    //передаются на форму с результатами поиска
                    userSearchResultform = new SearchResultForm(allFillms, this, user);
                    userSearchResultform.Show();
                    this.Visible = false;
                }
                else
                {
                    NotFoundForm notFound = new NotFoundForm();
                    notFound.ShowDialog();
                }

            }
            //фильмы, в которых выбран жанр,с любым рейтингом, и задан режисер
            //2
            if (genre != "All" && rate == "All" && directorName != "All")
            {
                //находим Id режиссера
                var directorId = (from director in await manager.directorTable.FindByValue(directorName)
                                  where director.Name == directorName
                                  select director.Id).SingleOrDefault();
                // находим Id жанра
                var genreId = (from gen in await manager.genreTable.FindByValue(genre)
                               where gen.Name == genre
                               select gen.Id).SingleOrDefault();
                //находим фильм по жанру и режиссеру
                var filmList = (from film in allFillms
                                where film.GenreId == genreId && film.DirectorId == directorId
                                select film).ToList();
                if (filmList.Count > 0)
                {
                    userSearchResultform = new SearchResultForm(filmList, this, user);
                    userSearchResultform.Show();
                    this.Visible = false;
                }

                else
                {
                    NotFoundForm notFound = new NotFoundForm();
                    notFound.ShowDialog();
                }

            }
            //если выбран только жанр
            //3
            if (genre != "All" && rate == "All" && directorName == "All")
            {

                var genreId = (from gen in await manager.genreTable.FindByValue(genre)
                               where gen.Name == genre
                               select gen.Id).SingleOrDefault();

                var filmList = (from film in allFillms
                                where film.GenreId == genreId
                                select film).ToList();
                if (filmList.Count > 0)
                {
                    userSearchResultform = new SearchResultForm(filmList, this, user);
                    userSearchResultform.Show();
                    this.Visible = false;
                }

                else
                {
                    NotFoundForm notFound = new NotFoundForm();
                    notFound.ShowDialog();
                }
            }

            //если выбран только режжисер
            //4
            if (genre == "All" && rate == "All" && directorName != "All")
            {
                var directorId = (from director in await manager.directorTable.FindByValue(directorName)
                                  where director.Name == directorName
                                  select director.Id).SingleOrDefault();
                if (directorId != 0)
                {
                    var filmList = (from film in allFillms
                                    where film.DirectorId == directorId
                                    select film).ToList();

                    if (filmList.Count > 0)
                    {
                        userSearchResultform = new SearchResultForm(filmList, this, user);
                        userSearchResultform.Show();
                        this.Visible = false;
                    }

                    else
                    {
                        NotFoundForm notFound = new NotFoundForm();
                        notFound.ShowDialog();
                    }
                }
                else
                {
                    NotFoundForm notFound = new NotFoundForm();
                    notFound.ShowDialog();
                }
            }

            //если выбран только рейтинг
            //5
            if (genre == "All" && rate != "All" && directorName == "All")
            {


                List<Film> filmList = new List<Film>();

                double rating;
                if (double.TryParse(rate, out rating))
                {

                    if (rating <= 5.0 && rating > 4.0)
                    {
                        filmList = allFillms.Where(filmRating => filmRating.Rate <= 5 && filmRating.Rate >= 4).ToList();
                    }
                    if (rating <= 4.0 && rating > 3.0)
                    {
                        filmList = allFillms.Where(filmRating => filmRating.Rate <= 4 && filmRating.Rate > 3).ToList();
                    }
                    if (rating <= 3.0 && rating > 2.0)
                    {
                        filmList = allFillms.Where(filmRating => filmRating.Rate <= 3 && filmRating.Rate > 2).ToList();
                    }
                    if (rating <= 2.0 && rating > 1.0)
                    {
                        filmList = allFillms.Where(filmRating => filmRating.Rate <= 2 && filmRating.Rate > 1).ToList();
                    }
                    if (rating <= 1.0)
                    {
                        filmList = allFillms.Where(filmRating => filmRating.Rate <= 1).ToList();
                    }


                    if (filmList.Count > 0)
                    {
                        userSearchResultform = new SearchResultForm(filmList, this, user);
                        userSearchResultform.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        NotFoundForm notFound = new NotFoundForm();
                        notFound.ShowDialog();
                    }
                }
            }
            //выбран жанр и рейтинг, режиссер не задан, не Ищет
            //6

            if (genre != "All" && rate != "All" && directorName == "All")
            {

                var genreId = (from gen in await manager.genreTable.FindByValue(genre)
                               where gen.Name == genre
                               select gen.Id).SingleOrDefault();
                if (genreId != 0)
                {
                    double rating;
                    var filmList = new List<Film>();
                    if (double.TryParse(rate, out rating))
                    {
                        if (rating <= 5.0 && rating > 4.0)
                        {
                            filmList = allFillms.Where(filmRating => filmRating.Rate <= 5
                            && filmRating.Rate >= 4 && filmRating.GenreId == genreId).ToList();
                        }
                        if (rating <= 4.0 && rating > 3.0)
                        {

                            filmList = allFillms.Where(filmRating => filmRating.Rate <= 4
                            && filmRating.Rate > 3 && filmRating.GenreId == genreId).ToList();
                        }
                        if (rating <= 3.0 && rating > 2.0)
                        {

                            filmList = allFillms.Where(filmRating => filmRating.Rate <= 3
                            && filmRating.Rate > 2 && filmRating.GenreId == genreId).ToList();
                        }
                        if (rating <= 2.0 && rating > 1.0)
                        {

                            filmList = filmList.Where(filmRating => filmRating.Rate <= 2
                            && filmRating.Rate > 1 && filmRating.GenreId == genreId).ToList();
                        }
                        if (rating <= 1.0)
                        {

                            filmList = allFillms.Where(filmRating => filmRating.Rate <= 1 && filmRating.GenreId == genreId).ToList();
                        }

                        if (filmList.Count > 0)
                        {

                            userSearchResultform = new SearchResultForm(filmList, this, user);
                            userSearchResultform.Show();
                            this.Visible = false;
                        }
                        else
                        {
                            NotFoundForm notFound = new NotFoundForm();
                            notFound.ShowDialog();
                        }
                    }
                }
                else
                {
                    NotFoundForm notFound = new NotFoundForm();
                    notFound.ShowDialog();
                }

            }
            //если выбран рейтинг и режиссер, жанр все.. Баг
            //7
            if (genre == "All" && rate != "All" && directorName != "All")
            {

                var directorId = (from director in await manager.directorTable.FindByValue(directorName)
                                  where director.Name == directorName
                                  select director.Id).SingleOrDefault();
                if (directorId != 0)
                {
                    List<Film> filmList = new List<Film>();

                    double rating;
                    if (double.TryParse(rate, out rating))
                    {
                        if (rating <= 5.0 && rating > 4.0)
                        {
                            filmList = allFillms.Where(filmRating => filmRating.Rate <= 5
                            && filmRating.Rate >= 4 && filmRating.DirectorId == directorId).ToList();
                        }
                        if (rating <= 4.0 && rating > 3.0)
                        {
                            filmList = allFillms.Where(filmRating => filmRating.Rate <= 4
                            && filmRating.Rate > 3 && filmRating.DirectorId == directorId).ToList();
                        }
                        if (rating <= 3.0 && rating > 2.0)
                        {

                            filmList = allFillms.Where(filmRating => filmRating.Rate <= 3
                            && filmRating.Rate > 2 && filmRating.DirectorId == directorId).ToList();
                        }
                        if (rating <= 2.0 && rating > 1.0)
                        {
                            filmList = allFillms.Where(filmRating => filmRating.Rate <= 2
                            && filmRating.Rate > 1 && filmRating.DirectorId == directorId).ToList();
                        }
                        if (rating <= 1.0)
                        {
                            filmList = allFillms.Where(filmRating => filmRating.Rate <= 1
                            && filmRating.DirectorId == directorId).ToList();
                        }

                        if (filmList.Count > 0)
                        {

                            userSearchResultform = new SearchResultForm(filmList, this, user);
                            userSearchResultform.Show();
                            this.Visible = false;
                        }
                        else
                        {
                            NotFoundForm notFound = new NotFoundForm();
                            notFound.ShowDialog();
                        }
                    }
                }

                else
                {
                    NotFoundForm notFound = new NotFoundForm();
                    notFound.ShowDialog();
                }

                }
            }

        }
    }

    

    
