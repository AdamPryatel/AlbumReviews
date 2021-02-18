using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Controllers;
using System;
using Xunit;

namespace ReviewSite.Tests
{
    public class AlbumsTests
    {
        //[Fact]
        //public void Index_Returns_Hello_World()
        //{
        //    var underTest = new AlbumController();
        //    var result = underTest.Index();
        //    Assert.Equal("Hello World!", result);
        //}

        [Fact]
        public void Index_Returns_A_View()
        {
            var underTest = new AlbumController();
            var result = underTest.Index();
            Assert.IsType<ViewResult>(result);
        }

    }
}
