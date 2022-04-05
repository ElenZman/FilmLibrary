using FilmLibrary.DataAcess.Interfaces;
using FilmLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLibrary.DataAcess
{
    class FilmTable : Table, IDataAccessAdmin<Film>
    {

        public FilmTable(string name) : base(name)
        {

        }
        public bool Add(Film obj)
        {
            string querry = "INSERT INTO Films (filmName, fk_genre, year, fk_country, directorId, summary) " +
                    "VALUES (@filmName, @genreId, @year, @countryId, @director, @summary) ;";

            using (SqlCommand command = new SqlCommand(querry, connection))

            {
                command.Parameters.Add("@filmName", SqlDbType.NVarChar, 50).Value = obj.Name;
                command.Parameters.Add("@genreId", SqlDbType.Int).Value = obj.GenreId;
                command.Parameters.Add("@year", SqlDbType.Int).Value = obj.Year;
                command.Parameters.Add("@countryId", SqlDbType.Int).Value = obj.CountryId;
                command.Parameters.Add("@director", SqlDbType.Int).Value = obj.DirectorId;
                command.Parameters.Add("@summary", SqlDbType.NVarChar, 2000).Value = obj.Summary;

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    command.Cancel();
                    return false;
                }
            }
            return true;
        }          

        public async Task<List<Film>> FindAll()
        {
            List<Film> list= new List<Film>(); 
            string querry = "SELECT * from Films;";

            using (SqlCommand command = new SqlCommand(querry, connection))

            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            list.Add(new Film()
                            {
                                Id = (int)reader["id"],
                                Name = (string)reader["filmName"],
                                GenreId = (int)reader["fk_genre"],
                                Year = (int)reader["year"],
                                Poster = (byte[])reader["poster"],
                                CountryId = (int)reader["fk_country"],
                                Rate =(decimal)reader["rating"],
                                Summary = (string)reader["summary"],
                                DirectorId = (int)reader["directorId"],
                                PeopleRatedNumber = (int)reader["peopleRatedNumber"],
                            });
                        }
                        return list;
                    }
                }
            }
            return null;
        }

        public async Task<Film> FindById(int id)
        {
            Film film;
            string select = @"select * from Films where id=@id;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        film = new Film() { Id = (int)reader["id"], Name = (string)reader["filmName"], GenreId = (int)reader["fk_genre"], Year = (int)reader["year"], Poster = (byte[])reader["poster"], CountryId = (int)reader["fk_country"], Rate = (decimal)reader["rating"], Summary = (string)reader["summary"], DirectorId = (int)reader["drectorId"], PeopleRatedNumber = (int)reader["peopleRatedNumber"] };
                        return film;
                    }
                } 
            }
            return null;
        }

        public async Task<List<Film>> FindByValue(string name)
        {
           List<Film> list = new List<Film>();
            
            string querry = "select * from Films;";

            using (SqlCommand command = new SqlCommand(querry, connection))
            {
                using (var reader = await command .ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            list.Add(new Film()
                            {
                                Id = (int)reader["id"],
                                Name = (string)reader["filmName"],
                                GenreId = (int)reader["fk_genre"],
                                Year = (int)reader["year"],
                                Poster = (byte[])reader["poster"],
                                CountryId = (int)reader["fk_country"],
                                Rate = (decimal)reader["rating"],
                                Summary = (string)reader["summary"],
                                DirectorId = (int)reader["directorId"],
                                PeopleRatedNumber = (int)reader["peopleRatedNumber"],


                            }) ;
                            
                        }
                    }
                }
            }
            var listOfFilms = list.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
            return listOfFilms;
        }

        public bool Update(Film obj)
        {
            string querry = $"UPDATE Films set filmName=@filmName, fk_genre=@genreId," +
                $"year=@year, fk_country=@countryId, directorId=@directorId, summary=@summary WHERE id=@id;";
            using (SqlCommand command = new SqlCommand(querry, connection))

            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = obj.Id;
                command.Parameters.Add("@filmName", SqlDbType.NVarChar, 50).Value = obj.Name;
                command.Parameters.Add("@genreId", SqlDbType.Int).Value = obj.GenreId;
                command.Parameters.Add("@year", SqlDbType.Int).Value = obj.Year;
                command.Parameters.Add("@countryId", SqlDbType.Int).Value = obj.CountryId;
                command.Parameters.Add("@directorId", SqlDbType.Int).Value = obj.DirectorId;
                command.Parameters.Add("@summary", SqlDbType.NVarChar, 2000).Value = obj.Summary;
                try
                {
                    command.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    command.Cancel();
                    return false;

                }
            }
            return true; 
        }
        public List<Film> FindByActorName(string name)
        {
            List<Film> list = new List<Film>();

            string querry = $"select Films.id, Films.filmName, Films.fk_genre, Films.year, Films.rating, Films.summary, Films.directorId" +
                $" from Films join Films_Actors on Films.id = Films_Actors.films_id join Actors on Films_Actors.actors_id = Actors.id " +
                $"where Actors.Name = @actorName;";

            using (SqlCommand command = new SqlCommand(querry, connection))
            {
                command.Parameters.Add("@actorName", SqlDbType.NVarChar).Value = name;
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            list.Add(new Film()
                            {
                                Id = (int)reader["id"],
                                Name = (string)reader["filmName"],
                                GenreId = (int)reader["fk_genre"],
                                Year = (int)reader["year"],
                                //Poster = (byte[])reader["poster"],
                                //CountryId = (int)reader["fk_country"],
                                Rate = (decimal)reader["rating"],
                                Summary = (string)reader["summary"],
                                DirectorId = (int)reader["directorId"],
                                //PeopleRatedNumber = (int)reader["peopleRatedNumber"],

                            });
                           
                        }
                        return list;
                    }
                }
            }
            return null;
        }

      

        public bool UpdateRating(int filmId, double rating, int peopleRatedNumber)
        {
            string querry = @"update Films set rating=@rating, peopleRatedNumber 
                              = @peopleRatedNumber where id=@filmId";
            using (SqlCommand command = new SqlCommand(querry, connection))
            {
                command.Parameters.Add("@filmId", SqlDbType.Int).Value = filmId;
                command.Parameters.Add("@rating", SqlDbType.Decimal).Value = rating;
                command.Parameters.Add("@peopleRatedNumber", SqlDbType.Int).Value = peopleRatedNumber;
                try
                {
                    command.ExecuteNonQuery();
                }

                catch (Exception ex)
                {

                    command.Cancel();
                    return false;

                }
            }
            return true;
        }



    }   
}

