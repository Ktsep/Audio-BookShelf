using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AudioBook.Core.Domain;

namespace AudioBook.Persistence.Repositories
{
    public class AuthorRepository : Repository<Author>
    {
        public AuthorRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}