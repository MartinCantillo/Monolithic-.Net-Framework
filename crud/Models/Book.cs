using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Models
{
    public class Book
    {
        public Book()
        {
        }
        public Book(int id, string name, string title, int yearOfPublication, int autorId, Autor autor)
        {
            this.Id = id;
            this.Name = name;
            this.Title = title;
            this.YearOfPublication = yearOfPublication;
            this.AutorId = autorId;
            this.Autor = autor;
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        [Required(ErrorMessage = "Please enter a Name")]
        public string Name { set; get; }

        [Required(ErrorMessage = "Please enter a Title")]
        public string Title { set; get; }

        [Required(ErrorMessage = "Please enter a YearOfPublication")]
        public int YearOfPublication { set; get; }

        public int AutorId { set; get; }
        [ForeignKey("AutorId")]
        public Autor Autor { set; get; }
    }
}