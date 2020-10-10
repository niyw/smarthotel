using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHotel.Web.Models
{
    public class RoomType
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public int Price { get; set; }

        public int DoubleBeds { get; set; }
        public int SingleBeds { get; set; }
        public int TwinBeds { get; set; }

        public int NumPhotos { get; set; }
    }
}
