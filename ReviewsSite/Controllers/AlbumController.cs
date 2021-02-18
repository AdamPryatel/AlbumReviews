
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
            Album album = new Album(37, $"{}The Black - Metallica", " is the fifth studio album by American heavy metal band Metallica, released on August 12, 1991 through Elektra Records. It was recorded in an eight-month span at One on One Recording Studios in Los Angeles.");
            return View(album);
        }

    }
}
