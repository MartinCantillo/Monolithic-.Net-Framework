using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud.Data;
using crud.Models;
using crud.Repositories;

namespace crud.Services
{
    public class SAutor : IAutor
    {
        private readonly DataContext _DataContext;

        public SAutor(DataContext _DataContext)
        {
            this._DataContext = _DataContext;
        }

        public void DeleteAutor(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Autor> GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetAutor(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveAutor(Autor autor)
        {
            try
            {
                this._DataContext.Autors.Add(autor);
                this._DataContext.SaveChanges();
            }
            catch (System.Exception)
            {

                throw new Exception("Error saving autor");
            }
        }

        public void Update(int id, Autor autor)
        {
            throw new NotImplementedException();
        }
    }
}