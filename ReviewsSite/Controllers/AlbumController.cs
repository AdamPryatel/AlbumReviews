﻿
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
            Album album = new Album(1, "The Black", "Is the fifth studio album by American heavy metal band Metallica, released on August 12, 1991 through Elektra Records. It was recorded in an eight-month span at One on One Recording Studios in Los Angeles.", "Metallica");

            Album album2 = new Album(2, "Man on the Moon 3", "Is the seventh studio album by American rapper Kid Cudi. It was released on December 11, 2020 by Republic Records. It is the final installment of Cudi's Man on the Moon trilogy of albums.", "Kid Cudi");
;

            return View();


        }

        //public ViewResult Index()
        //{

        //}

    }
}
