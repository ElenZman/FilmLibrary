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
    public partial class GenreSearchForm : Form
    {
        Table table;
        public GenreSearchForm(Table table)
        {
            this.table = table;
            InitializeComponent();
            comboBoxSearchOption.Items.Add("Genre Name");
            comboBoxSearchOption.Items.Add("Genre ID");
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
            grid.Columns.Add("value", "Genre");

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

            var obj = (GenreTable)table;
            if (searchOption == "Genre ID")
            {
                int index;
                if (int.TryParse(enteredValue, out index))
                {
                    var model = await obj.FindById(index);
                    if (model != null) grid.Rows.Add(new object[] { model.Id, model.Name });
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
            if (searchOption == "Genre Name")
            {
                var list = await obj.FindByValue(enteredValue);
                if (list.Count != 0)
                {
                    foreach (var item in list)
                    {
                        grid.Rows.Add(new object[] { item.Id, item.Name });
                    }
                }

                else
                {
                    lbInfo.Text = "Genre not found.";
                    return;
                }
            }
        }
    }
}
