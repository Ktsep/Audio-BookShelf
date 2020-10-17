using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using AudioBook.Core.Domain;
using AudioBook.Core.IRepositories;

namespace AudioBook.Persistence.Repositories
{
    public class BookRepository : Repository<Book>, IBookAuthorRepository
    {
        public BookRepository(ApplicationDbContext context) : base(context)
        {

        }
        public IEnumerable<Book> GetBooksWithAuthors()
        {
            return context.Books.Include(b => b.Author).ToList();
        }
    }
}