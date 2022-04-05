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
    public partial class CommentForm : Form
    {
        readonly User user;
        readonly int filmId;
        readonly Manager manager;
        public CommentForm(User user, int filmId)
        {
            InitializeComponent();
            manager = Manager.GetManager();
            this.user = user;
            this.filmId = filmId;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string commentText = tBoxComment.Text;
            if (manager.commentTable.Add(user, filmId, commentText))
            {
                btnSend.Enabled = false;
                this.Close();

            }

        }
    }
}
