
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace crud.Models
{
    public class Autor
    {
        public Autor(int Id, string Name, string Nationality)
        {
            this.Id = Id;
            this.Name = Name;
            this.Nationality = Nationality;

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        [Required(ErrorMessage = "please enter a name")]
        public string Name { set; get; }

        [Required(ErrorMessage = "please enter a nationality")]
        public string Nationality { set; get; }
    }
}