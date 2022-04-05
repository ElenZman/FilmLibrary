using FilmLibrary.DataAcess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary.Models
{
    class Films_Actors
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public int ActorId { get; set; }

    }
}
