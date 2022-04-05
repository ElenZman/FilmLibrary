using FilmLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLibrary.DataAcess
{
    class RegistrationAndEntry
    {

        SqlConnection connection;
        public RegistrationAndEntry()
        {
            connection = new SqlConnection(@"Data Source= DESKTOP-NPSC8CE\SQLEXPRESS;
                                            Initial Catalog = FilmLibrary; 
                                            Integrated Security=SSPI;");
            connection.Open();
        }

        public bool AddNewUsers(string login, string password)
        {
            
            string querry1 = $"select * from [Users] where [login] ='{login}';";
            using (SqlCommand sqlCommand = new SqlCommand(querry1, connection))
            {
                using (var r = sqlCommand.ExecuteReader())
                {
                    while (r.Read())
                    {
                        return false;
                    }
                }
            }

           if (login.Length < 30 && login.Length > 4)
                {
                    string querry = $"insert into [Users] values ('{login}', '{password}', 1)";//третий параметер
                //всегда стоит по умолчанию при регистрации из формы, таким образом, не возможно получить 
                //уровень доступа админа
                    using (SqlCommand command = new SqlCommand(querry, connection))
                    {
                        if (command.ExecuteNonQuery() == 1) return true;
                        else return false;
                    }
                }
            
            else return false;
        }

        public User Entry (string login, string password)
        {
            User user = null;
            string querry = $"select* from Users where [login] = '{login}' and [password] ='{password}'";
            using (SqlCommand command = new SqlCommand(querry, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            user = new User()
                            {
                                Id = (int)reader[0],
                                Name = (string)reader[1],
                                Password = (string)reader[2],
                                Access = (int)reader[3]
                            };
                        }
                        return user;
                    }
                    else
                    {
                        return null;
                    }
                }

            }
        }
    }

}

