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

        public ViewResult Create(int id)
        {
            var albums = reviewRepo.PopulateAlbumList();

            ViewBag.Albums = new SelectList(albums, "Id", "Name");

            int[] Ratings = { 1, 2, 3, 4, 5 };
            ViewBag.Ratings = new SelectList(Ratings);

            return View(new Review(){ AlbumId = id });
        }

        [HttpPost]
        public ViewResult Create(Review model)
        {
            var albums = reviewRepo.PopulateAlbumList();
            ViewBag.Albums = new SelectList(albums, "Id", "Name");

            int[] Ratings = { 1, 2, 3, 4, 5};
            ViewBag.Ratings = new SelectList(Ratings);

            reviewRepo.Create(model);
            ViewBag.Result = "Thanks for your review!";
            return View(model);
        }

       

        public ViewResult CreateByAlbumId(int albumId)
        {
            var albums = reviewRepo.PopulateAlbumList();

            ViewBag.Albums = new SelectList(albums, "Id", "Name");

            int[] Ratings = { 1, 2, 3, 4, 5 };
            ViewBag.Ratings = new SelectList(Ratings);

            return View(new Review() { AlbumId = albumId }) ;
        }


        public ActionResult Delete(int id)
        {
            var review = reviewRepo.GetById(id);
            reviewRepo.Delete(review);
            return RedirectToAction("Detail", "Album", new { id = review.AlbumId });     // Action, Controller, Variables
        }


        public ViewResult Update(int id)
        {
            //var reviews = reviewRepo.PopulateAlbumList();

            //ViewBag.Reviews = reviews;


            var albums = reviewRepo.PopulateAlbumList();

            ViewBag.Albums = new SelectList(albums, "Id", "Name");

            int[] Ratings = { 1, 2, 3, 4, 5 };
            ViewBag.Ratings = new SelectList(Ratings);


            var review = reviewRepo.GetById(id);

            return View(review);
        }

        [HttpPost]
        public ViewResult Update(Review model)
        {

            var albums = reviewRepo.PopulateAlbumList();

            ViewBag.Albums = new SelectList(albums, "Id", "Name");

            int[] Ratings = { 1, 2, 3, 4, 5 };
            ViewBag.Ratings = new SelectList(Ratings);

            reviewRepo.Update(model);
            ViewBag.Result = "You have successfuly upodated this review";
            return View(model);
        }

    }
}
