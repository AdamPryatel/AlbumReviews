﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Review     // for a specific album
    {

 

        public int Id { get; set; }
        [Display(Name = "Review")]
        public string Content { get; set; }     // comment box?
        public string ReviewerName { get; set; }
        public int Rating { get; set; }


        [Display(Name = "Album")]
        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }

        //public virtual ICollection<Album> Albums { get; set; }



        

    }
}
