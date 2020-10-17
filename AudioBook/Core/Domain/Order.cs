using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AudioBook.Core.Domain
{
    public class Order
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        public ApplicationUser Customer { get; set; }
        public int CustomerId { get; set; }

        public DateTime Date { get; set; }

        public byte Quantity { get; set; }

        public decimal Price { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}