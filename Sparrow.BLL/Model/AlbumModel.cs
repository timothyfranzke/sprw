using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparrow.BLL.Model
{
    public class AlbumModel
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public List<TrackModel> Tracks { get; set; }
    }

    public class ModifyAlbumModel
    {
        public string UserEmail { get; set; }
        public string Token { get; set; }
        public int ArtistId { get; set; }
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}
