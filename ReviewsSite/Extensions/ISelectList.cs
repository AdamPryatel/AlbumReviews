using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewsSite.Models;

namespace ReviewsSite.Extensions
{
    public interface ISelectList
    {
        List<Review> GetReviewsByAlbumId(int albumId);

        List<Review> PopulateReviewList();


    }
}
