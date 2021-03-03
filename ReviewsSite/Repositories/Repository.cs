using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewsSite.Models;

namespace ReviewsSite.Repositories
{
    public class Repository<T> : IRepository<T> where T : class             // T is generic
    {

        private RecordStoreContext _db;

        public Repository(RecordStoreContext db)
        {
            this._db = db;
        }

        public void Create(T obj)
        {
            _db.Set<T>().Add(obj);
            _db.SaveChanges();
        }

        public void Delete(T obj)
        {
            _db.Set<T>().Remove(obj);
            _db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public List<Review> PopulateReviewList()
        {
            return _db.Set<Review>().ToList();
        }

        public List<Review> GetReviewsByAlbumId(int albumId)
        {
            return _db.Set<Review>().Where(f => f.AlbumId == albumId).ToList();
        }

        public void Update(T obj)
        {
            _db.Set<T>().Update(obj);
            _db.SaveChanges();
        }
    }
}
