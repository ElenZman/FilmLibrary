using FilmLibrary.DataAcess;
using FilmLibrary.Forms;
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

namespace FilmLibrary
{
    public partial class AuthorizationForm : Form
    {
        RegistrationForm registrationForm;
        public AuthorizationForm()
        {
            InitializeComponent();
            tbLogin.AutoSize = true;
            tbPassword.AutoSize = false;
            tbPassword.Size = new Size(tbPassword.Width, 27);
            registrationForm = new RegistrationForm(this);
        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {        
            registrationForm = new RegistrationForm(this);
            registrationForm.ShowDialog();
            
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            lbPassEmpty.Text = string.Empty;
            lbLoginEmpty.Text = string.Empty;
            lbInfo.Text = string.Empty;

            if (tbPassword.Text == string.Empty && tbLogin.Text == string.Empty)
            {
                lbPassEmpty.Text = "Empty";
                lbLoginEmpty.Text = "Empty";
                return;
            }
            else if (tbLogin.Text== string.Empty)
            {
                lbLoginEmpty.Text = "Empty";
                return;
            }
            else if (tbPassword.Text == string.Empty)
            {
                lbPassEmpty.Text = "Empty";
                return;
            }

           

            RegistrationAndEntry access = new RegistrationAndEntry();
            User user = access.Entry(tbLogin.Text, tbPassword.Text);
            if (user != null)
            {
                if (user.Access == 1)
                {
                    UserWelcomeForm userWelcomeForm = new UserWelcomeForm(user, this, registrationForm);
                    userWelcomeForm.Show();
                   
                }

                else
                {
                    AdminForm form = new AdminForm(user, this);
                    form.Show();
                    this.Visible = false; ;
                }
            }
            else
                lbInfo.Text = "Wrong user name or password.";
                return;
                
        }
    }
}
