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
            try
            {
                return this._DataContext.Autors.ToList();
            }
            catch (System.Exception)
            {

                throw new Exception("Error Getting all Autores");
            }

        }

        public Autor GetAutorById(int id)
        {
            if (id == 0)
            {
                throw new Exception("Please enter a id");
            }
            return this._DataContext.Autors.FirstOrDefault(p => p.Id == id);
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

        public void Update(Autor autor)
        {
            try
            {
                var _autor = GetAutorById(autor.Id);
                _autor.Name = autor.Name;
                _autor.Nationality = autor.Nationality;
                this._DataContext.SaveChanges();
            }
            catch (System.Exception ex)
            {
                // TODO
                throw new Exception("Autor not found");
            }
        }
    }
}