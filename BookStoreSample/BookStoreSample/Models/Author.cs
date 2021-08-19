using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSample.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }

        public byte[] Image { get; set; }
        public string ImageType { get; set; }

        [Required]
        [DisplayName("Born")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Biography { get; set; }

        [Url]
        [MaxLength(500)]
        public string Website { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public Author()
        {
            Books = new HashSet<Book>();
        }
    }
}
