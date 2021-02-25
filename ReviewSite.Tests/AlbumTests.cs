using Microsoft.AspNetCore.Mvc;
using ReviewsSite;
using ReviewsSite.Controllers;
using ReviewsSite.Models;
using System;
using Xunit;

namespace ReviewSite.Tests
{
    public class AlbumTests
    {
        Album sut;

        public AlbumTests()
        {
            //sut = new Album(37, "The Black - Metallica", "The Black is Great!");
        }
        
        [Fact]
        public void AlbumConstructor_Sets_Id_on_AlbumModel()
        {
            int result = sut.Id;
            Assert.Equal(37, result);
        }

        [Fact]
        public void AlbumConstructor_Sets_Name_on_AlbumModel()
        {
            string result = sut.Name;
            Assert.Equal("The Black - Metallica", result);

        }

        [Fact]
        public void AlbumConstructor_Sets_Description_on_AlbumModel()
        {
            string result = sut.Description;
            Assert.Equal("The Black is Great!", result);
        }

    }
}
