using System.ComponentModel.DataAnnotations;

namespace TamrinRaz.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        public string Author { get; set; }


        public DateTime CreatBoks { get; set; } = DateTime.Now;
    }
}
