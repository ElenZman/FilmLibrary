using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary.DataAcess.Interfaces
{
    //Интерфейс для основных CRUD операций, кроме Delete
    public interface IDataAccessAdmin<T> where T: class
    {
        bool Add(T obj);
        bool Update(T obj);
        Task<T> FindById(int id);
        Task<List<T>> FindByValue(string name);
        Task<List<T>> FindAll();

    }
}
