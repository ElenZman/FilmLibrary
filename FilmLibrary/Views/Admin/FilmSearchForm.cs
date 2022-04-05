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
    public partial class FilmSearchForm : Form
    {
        Table table;
        public FilmSearchForm(Table table)
        {
            this.table = table;
            InitializeComponent();
            comboBoxSearchOption.Items.Add("Film ID");
            comboBoxSearchOption.Items.Add("Film Name");
            comboBoxSearchOption.Items.Add("Actor's Name");
            comboBoxSearchOption.Items.Add("Genre ID");
            comboBoxSearchOption.Items.Add("Director");
            comboBoxSearchOption.Items.Add("Year");
            lbName.Text = table.TableName;
        }

        private void btShawAll_Click(object sender, EventArgs e)
        {
            grid.DataSource = null;
            grid.Columns.Clear();
            grid.DataSource = table.ShowTableAsync();
        }

        private async void btnFinfId_Click(object sender, EventArgs e)
        {
            grid.DataSource = null;
            grid.Columns.Clear();
            grid.Columns.Add("id", "Id");
            grid.Columns.Add("filmName", "Film Name");
            grid.Columns.Add("genre", "Genre ID");
            grid.Columns.Add("country", "CountryID");
            grid.Columns.Add("year", "Year");
            grid.Columns.Add("director", "Director");

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

            var obj = (FilmTable)table;
            if (searchOption == "Film ID")
            {
                int index;
                if (int.TryParse(enteredValue, out index))
                {
                    var model = await obj.FindById(index);
                    if (model != null) grid.Rows.Add(new object[] { model.Id, model.Name, model.GenreId, model.CountryId, model.Year, model.DirectorId});
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
            if (searchOption == "Film Name")
            {
                var list = await obj.FindByValue(enteredValue);
                if (list.Count != 0)
                {
                    foreach (var item in list)
                    {
                        grid.Rows.Add(new object[] { item.Id, item.Name, item.GenreId,item.CountryId, item.Year, item.DirectorId });
                    }
                }

                else
                {
                    lbInfo.Text = "Film not found.";
                    return;
                }
            }
        }       
    }
}
