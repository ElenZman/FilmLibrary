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
    class ActorTable : Table, IDataAccessAdmin<Actor>
    {

        public ActorTable(string name) : base(name)
        {

        }
        public bool Add(Actor obj)
        {

            string querry = "INSERT INTO Actors VALUES (@actorName);";
            {
                using (SqlCommand command = new SqlCommand(querry, connection))

                {
                    command.Parameters.Add("@actorName", SqlDbType.NVarChar, 20).Value = obj.Name;
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
            }

            return true;
        }

        public async Task<List<Actor>> FindByValue(string name)
        {

            List<Actor> list = new List<Actor>();
            string select = "select * from Actors;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            list.Add(new Actor()
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),

                            });
                        }
                        var listOfActors = list.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
                        return listOfActors;
                    }
                }
            }
            return null;
        }

        public async Task<Actor> FindById(int id)
        {
            Actor actor;
            string select = @"select * from Actors where id=@id;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        actor = new Actor ()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),

                        };
                        return actor;
                    }
                   
                }
            }
            return null;
        }

        public async Task<List<Actor>> FindAll()
        {
            List<Actor> list = new List<Actor>();
            string select = @"select * from Actors;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                using (var reader = await command .ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        list.Add(new Actor()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),

                        });
                    }
                }
            }
            return list;
        }

        public bool Update(Actor obj)
        {
            string querry = $"UPDATE Actors set Name=@actorName WHERE id=@id;";
            using (SqlCommand command = new SqlCommand(querry, connection))

            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = obj.Id;
                command.Parameters.Add("@actorName", SqlDbType.NVarChar, 50).Value = obj.Name;
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
        public async Task<List<Actor>> FindByFilmId(int filmId)
        {
            List<Actor> list = new List<Actor>();
            string select = @"select *
                            from Actors
                            join Films_Actors on Actors.id = Films_Actors.actors_id
                            join Films on Films_Actors.films_id = Films.id
                            where Films.id =@filmId; ";

            using (SqlCommand command = new SqlCommand(select, connection))
            {
                command.Parameters.Add("@filmId", SqlDbType.Int).Value = filmId;
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        list.Add(new Actor()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),

                        });
                    }
                }
            }
            return list;
        }


    }
}

