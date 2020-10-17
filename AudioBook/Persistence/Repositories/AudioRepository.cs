using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AudioBook.Core.Domain;

namespace AudioBook.Persistence.Repositories
{
    public class AudioRepository : Repository<Audio>
    {
        public AudioRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}