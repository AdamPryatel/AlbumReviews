using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ReviewsSite.Models
{
    public class Album
    {

        public string SongsString { get; set; }        

        public List<string> ListofSongs { get { return SongsString.Split(',').ToList(); } }


        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string BandName { get; set; }
        
        public string Category { get; set; }

        public string Image { get; set; }

        public virtual ICollection<Review> Review { get; set; }

        public Album()
        {
        }

        public Album(int id, string name, string description, string bandName, string songsString, string image)
        {
            Id = id;
            Name = name;
            Description = description;
            BandName = bandName;
            SongsString = songsString;
            Image = image;
        }



    }


}
