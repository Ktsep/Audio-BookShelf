using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AudioBook.Core.Domain;
using AudioBook.Core.IRepositories;

namespace AudioBook.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationDbContext context;

        public Repository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public TEntity Get(int? id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }
    }
}