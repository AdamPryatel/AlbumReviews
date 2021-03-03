using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Controllers
{
    public class ReviewController : Controller
    {
        IRepository<Review> reviewRepo;

        public ReviewController(IRepository<Review> reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }

        public ViewResult Index(int albumId)
        {
            
            return View(reviewRepo.GetReviewsByAlbumId(albumId));
        }

        public ViewResult Create()
        {
            var albums = reviewRepo.PopulateReviewList();

            ViewBag.Albums = new SelectList(albums, "Id", "Name");

            return View(new Review());
        }

        [HttpPost]
        public ViewResult Create(Review model)
        {
            var albums = reviewRepo.PopulateReviewList();
            ViewBag.Albums = new SelectList(albums, "Id", "Name");

            reviewRepo.Create(model);
            ViewBag.Result = "Thanks for your review!";
            return View(model);
        }



    

    }
}
