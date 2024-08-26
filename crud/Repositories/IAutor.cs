using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud.Models;

namespace crud.Repositories
{
    public interface IAutor
    {
        public void SaveAutor();
        public ICollection<Autor> GetAll();
        public void DeleteAutor(int id);

        public void Update(int id, Autor autor);

        public void GetAutor(int id);
    }
}