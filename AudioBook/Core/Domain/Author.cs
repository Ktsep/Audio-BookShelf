using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AudioBook.Core.Domain
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        public int DateOfBirth { get; set; }

        [Required]
        public int DateOfDeath { get; set; }

        [Required]
        public ICollection<Book> Books { get; set; }
    }
}