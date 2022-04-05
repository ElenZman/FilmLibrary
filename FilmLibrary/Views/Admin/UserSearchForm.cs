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
    public partial class UserSearchForm : Form
    {
        Table table;
        public UserSearchForm(Table table)
        {
            this.table = table;
            InitializeComponent();
            comboBoxSearchOption.Items.Add("User ID");
            comboBoxSearchOption.Items.Add("User Login");
            comboBoxSearchOption.Items.Add("Access mode");
            lbName.Text = table.TableName;
        }

        private void btShawAll_Click(object sender, EventArgs e)
        {
            lbInfo.Text = string.Empty;
            grid.DataSource = null;
            grid.Columns.Clear();
            grid.DataSource = table.ShowTableAsync();
        }

        private async void btnFinfId_Click(object sender, EventArgs e)
        {
            lbInfo.Text = string.Empty;
            grid.DataSource = null;
            grid.Columns.Clear();
            grid.Columns.Add("id", "Id");
            grid.Columns.Add("value", "User Login");
            grid.Columns.Add("value", "Access Mode");

            string enteredValue = textBoxEnterValue.Text;
            string searchOption = comboBoxSearchOption.Text;

            if (searchOption == string.Empty)
            {
                lbInfo.Text = "Please choose a search option.";
                return;
            }
            if (enteredValue == string.Empty)
            {
                lbInfo.Text = "Please enter a value.";
                return;
            }

            var obj = (UsersTable)table;
            if (searchOption == "User ID")
            {
                int index;
                if (int.TryParse(enteredValue, out index))
                {
                    var model = await obj .FindById(index);
                    if (model != null) grid.Rows.Add(new object[] { model.Id, model.Name, model.Access });
                    else
                    {
                        lbInfo.Text = "ID was not found.";
                        return;
                    }
                }
                else
                {
                    lbInfo.Text = "ID must be a number.";
                    return;
                }
            }
            if (searchOption == "User Login")
            {
                var list = await obj.FindByValue(enteredValue);
                if (list.Count != 0)
                {
                    foreach (var item in list)
                    {
                        grid.Rows.Add(new object[] { item.Id, item.Name, item.Access });
                    }
                }

                else
                {
                    lbInfo.Text = "User not found.";
                    return;
                }
            }
        }

    }
}
