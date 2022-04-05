  using FilmLibrary.DataAcess.Interfaces;
using FilmLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary.DataAcess
{
    class Manager
    {
        public CountryTable countryTable { get; }
        public ActorTable actorTable { get; }
        public DirectorTable directorTable { get; }
        public CommentTable commentTable { get; }
        public FilmTable filmTable { get; }
        public Films_ActorsTable filmsActorsTable { get; }
        public GenreTable genreTable { get; }
        public UsersTable userTable { get; }
        public AccessTable accessTable { get; }
        public ModelProvider modelProvider{ get; }
        private Manager()
        {
            countryTable = new CountryTable("Countries");
            actorTable = new ActorTable("Actors");
            commentTable = new CommentTable("Comments");
            filmTable = new FilmTable("Films");
            filmsActorsTable = new Films_ActorsTable("Films_Actors");
            genreTable = new GenreTable("Generes");
            userTable = new UsersTable("Users");
            accessTable = new AccessTable("Access");
            directorTable = new DirectorTable("Directors");
            modelProvider = new ModelProvider();

        }

        private static Manager obj;
        public static Manager GetManager()
        {
            if (obj == null) obj = new Manager();
            return obj;
        }
    }
}
