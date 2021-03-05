using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using ReviewsSite;
using ReviewsSite.Controllers;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewSite.Tests
{
    public class AlbumControllerTest
    {
        AlbumController sut;
        IRepository<Album> albumRepo;


        public AlbumControllerTest()
        {
            albumRepo = Substitute.For<IRepository<Album>>();
            sut = new AlbumController(albumRepo);
        }
        [Fact]
        public void Index_Returns_A_View()
        {
            var result = sut.Index();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Returns_AlbumModel_To_View()
        {
            List<Album> expectedAlbums = null;
            albumRepo.GetAll().Returns(expectedAlbums);
            var result = sut.Index();
            Assert.Equal(expectedAlbums, result.Model);
        }

        [Fact]
        public void Detail_Returns_A_View()
        {
            var result = sut.Detail(1);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Detail_Passes_Course_To_View()
        {
            var expectedAlbum = new Album();
            albumRepo.GetById(1).Returns(expectedAlbum);
            var result = sut.Detail(1);
            Assert.Equal(expectedAlbum, result.Model);
        }

    }
}
