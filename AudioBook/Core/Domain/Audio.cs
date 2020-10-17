using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AudioBook.Core.Domain
{
    public class Audio
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        public Book Book { get; set; }

    }
}