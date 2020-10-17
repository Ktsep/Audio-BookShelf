using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AudioBook.Core;
using AudioBook.Core.Domain;
using AudioBook.Persistence.Repositories;

namespace AudioBook.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public BookRepository Books { get; private set; }
        public AudioRepository Audio { get; private set; }
        public AuthorRepository Authors { get; private set; }
        public OrderRepository Orders { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Books = new BookRepository(_context);
            Audio = new AudioRepository(_context);
            Authors = new AuthorRepository(_context);
            Orders = new OrderRepository(_context);
        }



        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}