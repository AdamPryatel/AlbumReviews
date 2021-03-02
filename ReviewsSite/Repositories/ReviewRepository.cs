using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class ReviewRepository : Repository<Review>
    {

        public ReviewRepository(RecordStoreContext db) : base(db)
        {
        }

    }
}
