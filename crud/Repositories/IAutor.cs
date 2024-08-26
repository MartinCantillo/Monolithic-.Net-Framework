using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud.Models;

namespace crud.Repositories
{
    public interface IAutor
    {
        public void SaveAutor(Autor autor);
        public ICollection<Autor> GetAll();
        public void DeleteAutor(int id);

        public void Update( Autor autor);

        public Autor GetAutorById(int id);
    }
}