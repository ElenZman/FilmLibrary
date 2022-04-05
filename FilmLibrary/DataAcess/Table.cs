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
    //класс отвечате за вывод таблицы в GridTable
    public abstract class Table: DBConnection
    {

        public string TableName { get; set; }

        protected DataTable dataTable;
       
        SqlDataAdapter adapter;


        public Table(string tableName)
        { 

            TableName = tableName;
            dataTable = new DataTable();

        }


        public Task<DataTable> ShowTableAsync()
        {
            dataTable.Clear();
            return Task.Run(() =>
          {
              adapter = new SqlDataAdapter($"select * from {TableName};", connection);
             
              adapter.Fill(dataTable);
              return dataTable;
          }
          );
        
        }


        public bool Delete(int id)
        {
            string querry = $"DELETE FROM {TableName} WHERE id=@id;";
            using (SqlCommand command = new SqlCommand(querry, connection))

            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
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


