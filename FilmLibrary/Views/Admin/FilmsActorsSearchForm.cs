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
    public partial class FilmsActorsSearchForm : Form
    {
        Table table;
        public FilmsActorsSearchForm(Table table)
        {
            this.table = table;
            InitializeComponent();
            comboBoxSearchOption.Items.Add("Film ID");
            comboBoxSearchOption.Items.Add("Actor ID");
            lbName.Text = table.TableName;
        }

        private void btShawAll_Click(object sender, EventArgs e)
        {
            lbInfo.Text = string.Empty;
            grid.DataSource = null;
            grid.Columns.Clear();
            grid.DataSource = table.ShowTableAsync();
        }

        private void btnFinfId_Click(object sender, EventArgs e)
        {
            lbInfo.Text = string.Empty;
            grid.DataSource = null;
            grid.Columns.Clear();
           
            grid.Columns.Add("id", "Id");
            grid.Columns.Add("filmId", "Film ID");
            grid.Columns.Add("actorId", "Actor ID");

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

            var obj = (Films_ActorsTable)table;
            //cann not find by Actor ID
            if (searchOption == "Actor ID")
            {
                int index;
                if (int.TryParse(enteredValue, out index))
                {
                    var list = obj.FindByActorId(index);
                    if (list.Count != 0)
                    {
                        foreach (var item in list)
                        {
                            grid.Rows.Add(new object[] { item.Id, item.FilmId, item.ActorId });
                        }
                    }
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
            if (searchOption == "Film ID")
            {
                int index;
                if (int.TryParse(enteredValue, out index))
                {
                    var list = obj.FindByFilmId(index);
                    if (list.Count != 0)
                    {
                        foreach (var item in list)
                        {
                            grid.Rows.Add(new object[] { item.Id, item.FilmId, item.ActorId });
                        }
                    }
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
        }
    }
}
