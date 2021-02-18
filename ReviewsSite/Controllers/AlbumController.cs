
using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace ReviewsSite.Controllers
{
    public class AlbumController : Controller
    {
        //public Index()
        //{
        //    //return "Hello World!";

        //    return View();

        //}


        public ViewResult Index()
        {
            Album album = new Album(37, "The Black - Metallica", "The Black is Great!");
            return View(album);
        }

    }
}
