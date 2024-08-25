
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace crud.Models
{
    public class Autor
    {
        public Autor(int Id, string name, string nationality)
        {
            this.Id = Id;
            this.name = name;
            this.nationality = nationality;

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        [Required(ErrorMessage = "please enter a name")]
        public string name { set; get; }

        [Required(ErrorMessage = "please enter a nationality")]
        public string nationality { set; get; }
    }
}