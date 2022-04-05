
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
    class CountryTable : Table, IDataAccessAdmin<Country>
    {
        public CountryTable(string name) : base(name)
        {

        }

        public bool Add(Country obj)
        {
            string querry = "INSERT INTO Countries VALUES (@countryName);";
            {
                using (SqlCommand command = new SqlCommand(querry, connection))

                {
                    command.Parameters.Add("@countryName", SqlDbType.NVarChar, 20).Value = obj.Name;
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
           
        public async Task<List<Country>> FindAll()
        {
            List<Country> list = new List<Country>();
            string select = @"select * from Countries;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader .ReadAsync())
                    {
                        list.Add(new Country()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                           
                        });
                    }
                }
            }
            return list;
        }

        public bool Update(Country obj)
        {
            string querry = $"UPDATE Countries set country=@countryName where id=@id;";
            
            using (SqlCommand command = new SqlCommand(querry, connection))

            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = obj.Id;
                command.Parameters.Add("@countryName", SqlDbType.NVarChar, 50).Value = obj.Name;
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
        public async Task<Country> FindById(int id)
        {
            Country country;
            string select = @"select * from Countries where id=@id;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        country = new Country()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),

                        };
                        return country;
                    }

                }
            }
            return null;
        }
        public async Task<List<Country>> FindByValue(string name)
        {

            List<Country> list = new List<Country>();
            string select = @"select * from Countries;";
            using (SqlCommand command = new SqlCommand(select, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        list.Add(new Country()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),

                        });
                    }
                }
            }
            var listOfCountries = list.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
            return listOfCountries;
        }



    }
}
