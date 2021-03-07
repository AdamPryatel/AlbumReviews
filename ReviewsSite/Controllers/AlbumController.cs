
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
