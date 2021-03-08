using ReviewsSite.Controllers;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite
{
    public class AlbumRepository : Repository<Album>
    {
        //public List<Album> ListofAlbums = new List<Album>();

        //public void AddAlbum(Album album)
        //{
        //    ListofAlbums.Add(album);
        //}

        ////public void SelectAlbum()       // public Album SelectAlbum()
        ////{
        ////    int id = 1;

        ////    Console.WriteLine("Please select a Album ID: ");
        ////}


        //public void Create(Album obj)
        //{
        //}

        //private RecordStoreContext _db;



        public AlbumRepository(RecordStoreContext db) : base(db)
        {
            //this._db = db;
        }





        //    public void Create(Album obj)
        //    {
        //        _db.Albums.Add(obj);
        //        _db.SaveChanges();
        //    }

        //    public void Delete(Album obj)
        //    {
        //        _db.Albums.Remove(obj);
        //        _db.SaveChanges();
        //    }

        //    public IEnumerable<Album> GetAll()
        //    {
        //        return _db.Albums.ToList();
        //    }

        //    public Album GetById(int id)
        //    {
        //        var album = _db.Albums.Find(id);
        //        return album;
        //    }

        //    public void Update(Album obj)
        //    {
        //        _db.Albums.Update(obj);
        //        _db.SaveChanges();
        //    }
    }
}
