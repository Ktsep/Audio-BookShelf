using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AudioBook.Core.Domain;

namespace AudioBook.Core.ViewModels
{
    public class AudioBookViewModel
    {
        public Book Book { get; set; }
        public List<string> Url { get; set; }
        public List<string> Name { get; set; }

    }
}