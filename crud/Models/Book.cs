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

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        [Required(ErrorMessage = "Please enter a Name")]
        public string Name { set; get; }

        [Required(ErrorMessage = "Please enter a Title")]
        public string Title { set; get; }

        [Required(ErrorMessage = "Please enter a YearOfPublication")]
        public int YearOfPublication { set; get; }

        public int AutorId{set;get;}
        [ForeignKey("AutorId")]
        public Autor Autor{set;get;}
    }
}