using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioBook.Persistence.Repositories;

namespace AudioBook.Core
{
    interface IUnitOfWork : IDisposable
    {
        BookRepository Books { get; }
        AuthorRepository Authors { get; }
        AudioRepository Audio { get; }
        OrderRepository Orders { get; }
        int Complete();
    }
}
