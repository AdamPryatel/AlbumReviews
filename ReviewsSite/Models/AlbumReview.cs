using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class AlbumReview
    {
        public int Id { get; set; }
   
        [Display(Name = "Album")]
        public int AlbumId { get; set; }

        public virtual Album Album { get; set; }

        [Display(Name = "Review")]
        public int ReviewId { get; set; }
        public virtual Review Review { get; set; }

        //public virtual List<AlbumReview> AlbumReviews { get; set; }

    }

}
