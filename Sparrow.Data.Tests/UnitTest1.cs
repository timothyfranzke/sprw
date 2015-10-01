using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sparrow.Data.Repository;

namespace Sparrow.Data.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AlbumRepository_GetAlbums_ValidID()
        {
            var repo = new AlbumRepository();
            var something = repo.GetAlbums(7);
            var track = something[0];
        }
    }
}
