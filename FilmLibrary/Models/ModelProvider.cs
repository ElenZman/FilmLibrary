using FilmLibrary.DataAcess;
using FilmLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLibrary
{
   //предоставляет объект, собирая информацию из DataGridView
   //если поле id не пустое, то этот объект для внесения в базу данных
   //если поле id заполнено, то объект должен обновиться
    class ModelProvider
    {
        
        public object GetModel(int index, DataGridView grid, string tableName)
        {
            
            if (tableName == "Countries")
            {
                
                if (grid.Rows[index].Cells["id"].Value == DBNull.Value)

                {
                    Country country = new Country()
                    {
                        Name = (string)grid.Rows[index].Cells["country"].Value,
                    };
                    return country;

                }
                else
                {
                    Country country = new Country()
                    {
                        Id = (int)grid.Rows[index].Cells["id"].Value,
                        Name = (string)grid.Rows[index].Cells["country"].Value,
                    };
                    return country;
                }

            }

            if (tableName == "Actors")
            {
                if (grid.Rows[index].Cells["id"].Value == DBNull.Value)
                {
                    Actor actor = new Actor()
                    {
                        Name = (string)grid.Rows[index].Cells["Name"].Value,
                    };
                    return actor;
                }
                else
                {
                    Actor actor = new Actor()
                    {
                        Id = (int)grid.Rows[index].Cells["id"].Value,
                        Name = (string)grid.Rows[index].Cells["Name"].Value,
                    };
                    return actor;
                }
            }

           ///!!!!!!!!
            if (tableName == "Genres")
            {
                if (grid.Rows[index].Cells["id"].Value == DBNull.Value)
                {
                    Genre genre = new Genre()
                    {

                        Name = (string)grid.Rows[index].Cells["genre"].Value,
                    };
                    return genre;
                }
                else
                {
                    Genre genre = new Genre()
                    {
                        Id = (int)grid.Rows[index].Cells["id"].Value,
                        Name = (string)grid.Rows[index].Cells["genre"].Value,
                    };
                    return genre;
                }
            }
            if (tableName == "Users")
            {
                if (grid.Rows[index].Cells["id"].Value == DBNull.Value)
                {
                    Genre genre = new Genre()
                    {
                        Name = (string)grid.Rows[index].Cells["genre"].Value,
                    };
                    return genre;
                }

                else
                {
                    Genre genre = new Genre()
                    {
                        Id = (int)grid.Rows[index].Cells["id"].Value,
                        Name = (string)grid.Rows[index].Cells["genre"].Value,
                    };
                    return genre;
                }
            }

            if (tableName == "Users")
            {
                if (grid.Rows[index].Cells["id"].Value == DBNull.Value)
                {
                    User user = new User()
                    {
                        Name = (string)grid.Rows[index].Cells["login"].Value,
                        Password = (string)grid.Rows[index].Cells["login"].Value,
                        Access = (int)grid.Rows[index].Cells["access"].Value,
                    };
                    return user;
                }
                else
                {
                    User user = new User()
                    {
                        Id = (int)grid.Rows[index].Cells["id"].Value,
                        Name = (string)grid.Rows[index].Cells["login"].Value,
                        Password = (string)grid.Rows[index].Cells["login"].Value,
                        Access = (int)grid.Rows[index].Cells["access"].Value,
                    };
                    return user;
                }
            }

            if (tableName == "Films")
            {
                if (grid.Rows[index].Cells["id"].Value == DBNull.Value)
                {
                    Film film = new Film()
                    {
                        Name = (string)grid.Rows[index].Cells["filmName"].Value,
                        GenreId = (int)grid.Rows[index].Cells["fk_genre"].Value,
                        Year = (int)grid.Rows[index].Cells["year"].Value,
                        CountryId = (int)grid.Rows[index].Cells["fk_country"].Value,
                        DirectorId = (int)grid.Rows[index].Cells["directorId"].Value,
                        Summary = (string)grid.Rows[index].Cells["summary"].Value,
                    };
                    return film;
                }
                else
                {
                    Film film = new Film()
                    {
                        Id = (int)grid.Rows[index].Cells["id"].Value,
                        Name = (string)grid.Rows[index].Cells["filmName"].Value,
                        GenreId = (int)grid.Rows[index].Cells["fk_genre"].Value,
                        Year = (int)grid.Rows[index].Cells["year"].Value,
                        CountryId = (int)grid.Rows[index].Cells["fk_country"].Value,
                        DirectorId = (int)grid.Rows[index].Cells["directorId"].Value,
                        Summary = (string)grid.Rows[index].Cells["summary"].Value,
                    };
                    return film;
                }
            }
            if (tableName == "Films_Actors")
            {
                if (grid.Rows[index].Cells["id"].Value == DBNull.Value)
                {
                    Films_Actors films_actors = new Films_Actors()
                    {
                        FilmId = (int)grid.Rows[index].Cells["films_id"].Value,
                        ActorId = (int)grid.Rows[index].Cells["actors_id"].Value,
                    };
                    return films_actors;
                }
                else
                {
                    Films_Actors films_actors = new Films_Actors()
                    {
                        Id = (int)grid.Rows[index].Cells["id"].Value,
                        FilmId = (int)grid.Rows[index].Cells["films_id"].Value,
                        ActorId = (int)grid.Rows[index].Cells["actors_id"].Value,
                    };
                    return films_actors;
                }
            }
            if (tableName == "Comments")
            {
                if (grid.Rows[index].Cells["id"].Value == DBNull.Value)
                {
                    Comment comment = new Comment()
                    {
                        FilmId = (int)grid.Rows[index].Cells["fk_film"].Value,
                        UserId = (int)grid.Rows[index].Cells["fk_user"].Value,
                        CommentText = (string)grid.Rows[index].Cells["comment"].Value,
                    };
                    return comment;
                }
                else
                {
                    Comment comment = new Comment()
                    {
                        Id = (int)grid.Rows[index].Cells["id"].Value,
                        FilmId = (int)grid.Rows[index].Cells["fk_film"].Value,
                        UserId = (int)grid.Rows[index].Cells["fk_user"].Value,
                        CommentText = (string)grid.Rows[index].Cells["comment"].Value,
                    };
                    return comment;
                }
            }

            else return null;
        }
    }
}
