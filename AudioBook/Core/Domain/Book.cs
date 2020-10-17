using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AudioBook.Core.Domain
{
    public class Book
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(20)]
        public string Language { get; set; }

        [Required]
        public int CopyrightYear { get; set; }

        [Required]
        public byte NumSections { get; set; }

        [Required]
        public string TotalTime { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Range(minimum: 0, maximum: 5)]
        public float Rating { get; set; }

        [Required]
        public string Photo { get; set; }

        [Required]
        public Author Author { get; set; }

        public ICollection<Audio> Audio { get; set; }

        [NotMapped]
        public TimeSpan TotalTimeTimeSpan
        {
            get { return TimeSpan.Parse(TotalTime); }
            set { TotalTime = value.ToString("HH:mm:ss"); }
        }
    }
}