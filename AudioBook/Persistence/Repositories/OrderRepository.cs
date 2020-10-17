using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AudioBook.Core.Domain;

namespace AudioBook.Persistence.Repositories
{
    public class OrderRepository : Repository<Order>
    {
        public OrderRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}