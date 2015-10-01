using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sparrow.Data.Repository;

namespace Sparrow.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var something = new AlbumRepository();
            var another = something.GetAlbums(7);

            var som = another[0];
        }
    }
}
