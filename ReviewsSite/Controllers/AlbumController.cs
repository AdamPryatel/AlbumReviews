
using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace ReviewsSite.Controllers
{
    public class AlbumController : Controller
    {

        //public ViewResult Index()
        //{
        //    Album album = new Album(1, "The Black", "Is the fifth studio album by American heavy metal band Metallica, released on August 12, 1991 through Elektra Records. It was recorded in an eight-month span at One on One Recording Studios in Los Angeles.", "Metallica");
        //    return View();
        //}

        //public ViewResult Index()
        //{

        //}

        //Album album2 = new Album(2, "Man on the Moon 3", "Is the seventh studio album by American rapper Kid Cudi. It was released on December 11, 2020 by Republic Records. It is the final installment of Cudi's Man on the Moon trilogy of albums.", "Kid Cudi");


        IRepository<Album> albumRepo;
        
        public AlbumController(IRepository<Album> albumRepo)
        {
            this.albumRepo = albumRepo;
        }

        public ViewResult Index()
        {
            var albumList = albumRepo.GetAll();
            return View(albumList);
        }

        public ViewResult Detail(int id)
        {
            var album = albumRepo.GetById(id);
            return View(album);
        }

        public ViewResult Create()
        {
            return View(new Album());
        }

        [HttpPost]
        public ViewResult Create(Album model)
        {
            albumRepo.Create(model);
            return View(model);
        }


     

    }
}
