using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using NSubstitute;
using ReviewsSite.Controllers;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ReviewSite.Tests
{
    public class ReviewControllerTests
    {

        ReviewController sut;
        IRepository<Review> reviewRepo;


        public ReviewControllerTests()
        {
            reviewRepo = Substitute.For<IRepository<Review>>();
            sut = new ReviewController(reviewRepo);
        }
        [Fact]
        public void Index_Returns_A_View()
        {
            var result = sut.Index(1);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Returns_ReviewModel_To_View()
        {
            List<Review> expectedAlbums = null;
            reviewRepo.GetAll().Returns(expectedAlbums);
            var result = sut.Index(1);
            Assert.Equal(expectedAlbums, result.Model);
        }

        [Fact]
        public void Create_Returns_A_View()
        {
            
            Review Model = new Review()
            {
                Content = "test",
                ReviewerName = "test",
                Rating = 3,
                AlbumId = 1
            };
            var result = sut.Create(Model);
            Assert.IsType<ViewResult>(result);
        }


    }
}
