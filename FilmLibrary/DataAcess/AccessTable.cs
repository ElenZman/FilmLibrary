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
    //наследует только от Table
    class AccessTable : Table
    {

        public AccessTable(string name) : base(name)
        {

        }
    }

}
