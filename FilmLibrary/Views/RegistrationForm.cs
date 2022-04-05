using FilmLibrary.DataAcess;
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
    public partial class RegistrationForm : Form
    {
        Manager manager;
        AuthorizationForm authorizationForm;

        public RegistrationForm(AuthorizationForm form)
        {
            InitializeComponent();
            authorizationForm = form;
            manager = Manager.GetManager();
        }

        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == string.Empty && tbLogin.Text == string.Empty)
            {
                lbPassEmpty.Text = "Empty";
                lbLoginEmpty.Text = "Empty";
                return;
            }
            else if (tbLogin.Text == string.Empty)
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
            if (access.AddNewUsers(tbLogin.Text, tbPassword.Text))
            {
                lbInfo.Text = "User added successfully!";
                btnSignUp.Enabled = false;
                var userList = await manager.userTable.FindAll();
                var user = (from users in userList
                           where users.Name == tbLogin.Text
                           select users).FirstOrDefault();
                UserWelcomeForm userWelcomeForm = new UserWelcomeForm(user, authorizationForm, this);
                userWelcomeForm.ShowDialog();
                this.Close();
            }
            else
                lbInfo.Text = "User already exists"+
                    Environment.NewLine + "or login is less than 4 characters.";
            //this.Close();

        }

    }
}
