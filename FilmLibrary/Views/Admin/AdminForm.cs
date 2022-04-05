using FilmLibrary.DataAcess;
using FilmLibrary.DataAcess.Interfaces;
using FilmLibrary.Models;
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
    public partial class AdminForm : Form
    {

        AuthorizationForm authForm;
        Table table;
        Manager manager;


        public AdminForm(User user, AuthorizationForm form)
        {
            InitializeComponent();
            manager = Manager.GetManager();
            authForm = form;
            lbUserName.Text = user.Name + "!";

            comboBoxTableNames.Items.Add("Users");
            comboBoxTableNames.Items.Add("Access");
            comboBoxTableNames.Items.Add("Comments");
            comboBoxTableNames.Items.Add("Films");
            comboBoxTableNames.Items.Add("Films_Actors");
            comboBoxTableNames.Items.Add("Genres");
            comboBoxTableNames.Items.Add("Actors");
            comboBoxTableNames.Items.Add("Countries");
            comboBoxTableNames.Items.Add("Directors");
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            authForm.Visible = true;
        }

        private async void comboBoxTableNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbName.Text = string.Empty;
            lbInfo.Text = string.Empty;
            string tableName = comboBoxTableNames.SelectedItem.ToString();

            table = GetTable(tableName);
            grid.DataSource = await table.ShowTableAsync();
            lbName.Text = table.TableName;
            if (table.TableName == "Films") btnAddPoster.Visible = true;
            else
                btnAddPoster.Visible = false;

        }

        //получаем нужную таблицу
        private Table GetTable(string tableName)
        {

            switch (tableName)
            {
                case "Countries":
                    return manager.countryTable;
           
                case "Actors":
                    return manager.actorTable;
                    
                case "Genres":
                    return manager.genreTable;
                    
                case "Users":
                     return manager.userTable;
                   
                case "Access":
                    return manager.accessTable;
                   
                case "Films":
                    return manager.filmTable;
                    
                case "Comments":
                    return manager .commentTable;
                    
                case "Films_Actors":
                    return manager.filmsActorsTable;
                    
                case "Directors":
                    return manager .directorTable;
                default:
                    return null;
            }
        }

        //добавление в таблицу
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            lbInfo.Text = string.Empty;
            int index = grid.CurrentRow.Index;
          
            if (grid.Rows[index].Cells["id"].Value == DBNull.Value)
            {
                if (table is CountryTable)
                {
                    
                    var obj = (CountryTable)table;
                    //воспользуемся методом класса ModelProvider, объект класса инициализируется в manager
                    if (obj.Add((Country)manager.modelProvider.GetModel(index, grid, table.TableName)))
                        lbInfo.Text = "Item addedd successfully!";
                    else
                        lbInfo.Text = "Ooops! Something went wrong.Try one more time";
                }
                if (table is ActorTable)
                {
                    var obj = (ActorTable)table;
                    if (obj.Add((Actor)manager.modelProvider.GetModel(index, grid, table.TableName)))
                        lbInfo.Text ="Item added successfully!";
                    else
                        lbInfo.Text = "Ooops! Something went wrong.Try one more time";
                }
                if (table is DirectorTable)
                {
                    var obj = (DirectorTable)table;
                    if (obj.Add((Director)manager.modelProvider.GetModel(index, grid, table.TableName)))
                        lbInfo.Text = "Item added successfully!";
                    else
                        lbInfo.Text = "Ooops! Something went wrong.Try one more time";
                }

                if (table is GenreTable)
                {
                    var obj = (GenreTable)table;
                    if (obj.Add((Genre)manager.modelProvider.GetModel(index, grid, table.TableName)))
                        lbInfo.Text ="Item added successfully!";
                    else
                        lbInfo.Text = "Ooops! Something went wrong.Try one more time";
                }
                if (table is UsersTable)
                {
                    var obj = (UsersTable)table;
                    if (obj.Add((User)manager.modelProvider.GetModel(index, grid, table.TableName)))
                        lbInfo.Text = "Item added successfully!";
                    else
                        lbInfo.Text = "Ooops! Something went wrong.Try one more time";
                }

                if (table is FilmTable)
                {
                    var obj = (FilmTable)table;
                    if (obj.Add((Film)manager.modelProvider.GetModel(index, grid, table.TableName)))
                        lbInfo.Text = "Item added successfully!";
                    else
                        lbInfo.Text = "Ooops! Something went wrong.Try one more time";
                }
                
                //Check here, inserts two at a time
                if (table is Films_ActorsTable)
                {
                    var obj = (Films_ActorsTable)table;
                    if (obj.Add((Films_Actors)manager.modelProvider.GetModel(index, grid, table.TableName)))
                        lbInfo.Text = "Item added successfully!";
                    else
                        lbInfo.Text = "Ooops! Something went wrong.Try one more time";
                }
                if (table is CommentTable)
                {
                    lbInfo.Text = "This table is filled by users.";
                    return;
                }
                if (table is AccessTable)
                {
                    lbInfo.Text = "This table can not be altered.";
                    return;
                }
            
            }

            grid.DataSource = table.ShowTableAsync();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lbInfo.Text = string.Empty;
            int index = grid.CurrentRow.Index;
           
            if (table is CountryTable)
            {
                var obj = (CountryTable)table;
                if (obj.Update((Country)manager.modelProvider.GetModel(index, grid, table.TableName)))
                    lbInfo.Text = "Item updated successfully!";
                else
                    lbInfo.Text = "Ooops! Something went wrong.Try one more time";

            }
            if (table is ActorTable)
            {
                var obj = (ActorTable)table;
                if (obj.Update((Actor)manager.modelProvider.GetModel(index, grid, table.TableName)))
                    lbInfo.Text ="Item updated successfully!";
                else
                    lbInfo.Text = "Ooops! Something went wrong.Try one more time";
            }
            if (table is DirectorTable)
            {
                var obj = (DirectorTable)table;
                if (obj.Update((Director)manager.modelProvider.GetModel(index, grid, table.TableName)))
                    lbInfo.Text = "Item updated successfully!";
                else
                    lbInfo.Text = "Ooops! Something went wrong.Try one more time";
            }

            if (table is GenreTable)
            {
                var obj = (GenreTable)table;
                if (obj.Update((Genre)manager.modelProvider.GetModel(index, grid, table.TableName)))
                    lbInfo.Text = "Item updated successfully!";
                else
                    lbInfo.Text = "Ooops! Something went wrong.Try one more time";
            }
            if (table is UsersTable)
            {
                var obj = (UsersTable)table;
                if (obj.Update((User)manager.modelProvider.GetModel(index, grid, table.TableName)))
                    lbInfo.Text = "Item updated successfully!";
                else
                    lbInfo.Text = "Ooops! Something went wrong.Try one more time";
            }

            if (table is FilmTable)
            {
                var obj =(FilmTable)table;
                if (obj.Update((Film)manager.modelProvider.GetModel(index, grid, table.TableName)))
                    lbInfo.Text ="Item updated successfully!";
                else
                    lbInfo.Text = "Ooops! Something went wrong.Try one more time";
            }
            if (table is Films_ActorsTable)
            {
                var obj = (Films_ActorsTable)table;
                if (obj.Update((Films_Actors)manager.modelProvider.GetModel(index, grid, table.TableName)))
                    lbInfo.Text = "Item updated successfully!";
                else
                    lbInfo.Text = "Ooops! Something went wrong.Try one more time";
            }
            if (table is CommentTable)
            {
                lbInfo.Text = "This table is filled by users.";
                return;
            }
            if (table is AccessTable)
            {
                lbInfo.Text = "This table can not be altered.";
                return;
            }

            grid.DataSource = table.ShowTableAsync();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //получаем id элемента, который нужно удалить
            lbInfo.Text = string.Empty;
            int index = (int)grid.Rows[grid.CurrentRow.Index].Cells["id"].Value;
            string tableName = comboBoxTableNames.SelectedItem.ToString();
            table = GetTable(tableName);

            if (table != null)
            {
                if (table.Delete(index)) lbInfo.Text = "Item was deleted successfully!";
                else
                    lbInfo.Text = "Ooops! Something went wrong.Try one more time";

                grid.DataSource = table.ShowTableAsync();
            }

            return;
        }

        //добавление постера к фильму
        string fileName = string.Empty;
        private void btnaAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif";
            if (openDialog.ShowDialog() == DialogResult.OK)

            {
                fileName = openDialog.FileName;
                byte[] image = File.ReadAllBytes(openDialog.FileName);
                int index = grid.CurrentRow.Index;
                string insert = @"update Films set poster=@image where id=@id;";
                using (SqlConnection connection = new SqlConnection(@"Data Source= DESKTOP-NPSC8CE\SQLEXPRESS;
                                            Initial Catalog = FilmLibrary; 
                                            Integrated Security=SSPI;"))
                {

                    using (SqlCommand command = new SqlCommand(insert, connection))
                    {
                        command.Parameters.Add("@id", SqlDbType.Int).Value
                            = grid.Rows[index].Cells["id"].Value;
                        command.Parameters.Add("@image", SqlDbType.Image, image.Length).Value = image;
                        connection.Open();
                        try
                        {
                            command.ExecuteNonQuery();                            
                            lbInfo.Text = "Image was added successfully.";
                            grid.DataSource = table.ShowTableAsync();
                        }
                        catch(Exception ex)
                        {
                            lbInfo.Text = "Ooops! Something went wrong! Try one more time";
                            return;
                        }
                    }

                }
            }        
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchOptionForm form = new SearchOptionForm();
            form.Show();
        }  
    }
}
    
    




