using FilmLibrary.DataAcess;
using FilmLibrary.DataAcess.Interfaces;
using FilmLibrary.Models;
using FilmLibrary.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLibrary.Forms
{
    public partial class SearchOptionForm : Form
    {
        Manager manager;
        Table table;

        public SearchOptionForm()
        {
            InitializeComponent();
            manager = Manager.GetManager();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbCoutnries.Checked)
            {
                table = manager.countryTable;
                CountrySearchForm form = new CountrySearchForm(table);
                form.Show();
                this.Close();
            }

            if (rbActors.Checked)
            {
                table = manager.actorTable;
                ActorSearchForm form = new ActorSearchForm(table);
                form.Show();
                this.Close();
            }
            if (rbFilms.Checked)
            {
                table = manager.filmTable;
                FilmSearchForm form = new FilmSearchForm(table);
                form.Show();
                this.Close();
            }

            if (rbGenres.Checked)
            {
                table = manager.genreTable;
                GenreSearchForm form = new GenreSearchForm(table);
                form.Show();
                this.Close();
            }

            if (rbUsers.Checked)
            {
                table = manager.userTable;
                UserSearchForm form = new UserSearchForm(table);
                form.Show();
                this.Close();
            }
            if (rbFilms_Actors.Checked)
            {
                table = manager.filmsActorsTable;
                FilmsActorsSearchForm form = new FilmsActorsSearchForm(table);
                form.Show();
                this.Close();
            }
            if (rbComments.Checked)
            {
                table = manager.commentTable;
                CommentSearchForm form = new CommentSearchForm(table);
                form.Show();
                this.Close();
            }
            if (rbDirectors.Checked)
            {
                table = manager.directorTable;
                DirectorSearchForm form = new DirectorSearchForm(table);
                form.Show();
                this.Close();
            }
        }
      
    }
}


