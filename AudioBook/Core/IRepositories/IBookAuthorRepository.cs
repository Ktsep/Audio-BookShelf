using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioBook.Core.Domain;

namespace AudioBook.Core.IRepositories
{
    interface IBookAuthorRepository
    {
        IEnumerable<Book> GetBooksWithAuthors();
    }
}
