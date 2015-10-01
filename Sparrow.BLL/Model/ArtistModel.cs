using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparrow.BLL.Model
{
    public class ArtistModel
    {
        public int ArtistId { get; set; }
        public string AristName { get; set; }
        public string Description { get; set; }
        public List<AlbumModel> Albums { get; set; }
        public List<EventModel> Events { get; set; }
        public string Bulliten { get; set; }

    }
}
