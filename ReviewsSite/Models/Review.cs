using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Review     // for a specific album
    {

        public int Id { get; set; }
        public string Content { get; set; }     // comment box?
        public string ReviewerName { get; set; }
        public int Rating { get; set; }
        public int ReviewDate { get; set; }
        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }

        public virtual ICollection<Album> Albums { get; set; }


    }
}
