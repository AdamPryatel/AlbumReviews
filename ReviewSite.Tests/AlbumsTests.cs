using ReviewsSite.Controllers;
using System;
using Xunit;

namespace ReviewSite.Tests
{
    public class AlbumsTests
    {
        [Fact]
        public void Index_Returns_Hello_World()
        {
            var underTest = new AlbumController();
            var result = underTest.Index();
            Assert.Equal("Hello World!", result);
        }
    }
}
