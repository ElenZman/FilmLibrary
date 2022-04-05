using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilmLibrary.DataAcess.Interfaces;
using FilmLibrary.Models;

namespace FilmLibrary.DataAcess
{
    class CommentTable : Table
    {

        public CommentTable(string name) : base(name)
        {

        }

        public bool Add(User user, int filmId, string comment)
        {

            string querry = "INSERT INTO Comments VALUES (@filmId, @userId, @commentText);";
            {
                using (SqlCommand command = new SqlCommand(querry, connection))

                {
                    command.Parameters.Add("@filmId", SqlDbType.Int).Value = filmId;
                    command.Parameters.Add("@userId", SqlDbType.Int).Value = user.Id;
                    command.Parameters.Add("@commentText", SqlDbType.NVarChar, 1000).Value = comment;
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

        public List<Comment> FindAll()
        {
            List<Comment> list = new List<Comment>();
            string select = @"select * from Comments;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Comment()
                        {
                            Id = reader.GetInt32(0),
                            FilmId=reader.GetInt32(1),
                            UserId = reader.GetInt32(2),
                            CommentText = reader.GetString(3),
                        });
                    }
                }
            }
            return list;
        }

        public List<Comment> FindByUserId(int userId)
        {
            List<Comment> list = new List<Comment>();
            string select = @"select * from Comments where fk_user=@id;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = userId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add( new Comment()
                        {
                            Id = reader.GetInt32(0),
                            FilmId = reader.GetInt32(1),
                            UserId=reader.GetInt32(2),
                            CommentText = reader.GetString(3)
                        });
                       
                    }

                }
            }
            return list;
        }

        public List<Comment> FindByFilmID(int filmId)
        {
            List<Comment> list = new List<Comment>();
            string select = @"select * from Comments where fk_film=@id;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = filmId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Comment()
                        {
                            Id = reader.GetInt32(0),
                            FilmId = reader.GetInt32(1),
                            UserId = reader.GetInt32(2),
                            CommentText = reader.GetString(3)
                        });
                        
                    }

                }
            }
            return list;
        }

    }
    
}
