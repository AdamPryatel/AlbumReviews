﻿using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite
{
    public class AlbumRepository
    {
        public List<Album> ListofAlbums = new List<Album>();

        public void AddAlbum(Album album)
        {
            ListofAlbums.Add(album);
        }

        public Album SelectAlbum()
        {
            int id = 1;

            Console.WriteLine("Please select a Album ID: ");
        }

    }
}
