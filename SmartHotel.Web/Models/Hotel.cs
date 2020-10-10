using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHotel.Web.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public City City { get; set; }
        public int Rating { get; set; }
        public int StarterPricePerNight => RoomTypes.Min(room => room.Price);
        public IEnumerable<RoomType> RoomTypes { get; set; } = new List<RoomType> { new RoomType
                    {
                        Name = "Single room",
                        Capacity = 1,
                        Description = "Our single rooms have an area of 26m² with a 1.60m Queen size bed.",
                        Price = 180,
                        NumPhotos = 3,
                        SingleBeds = 1
                    },
                    new RoomType
                    {
                        Name = "Double room",
                        Capacity = 2,
                        Description = "The doubles are 32m² with French Size twin beds of 1.40m",
                        Price = 300,
                        NumPhotos = 4,
                        TwinBeds = 2
                    },new RoomType
                    {
                        Name = "Luxury room",
                        Capacity = 2,
                        Description = "Luxury room is 42m² with a 3.20m double Queen size bed.",
                        Price = 500,
                        NumPhotos = 3,
                        DoubleBeds = 1,
                    }};
        public Byte CheckinTime { get; set; }
        public Byte CheckoutTime { get; set; }
        public string PhoneNumber { get; set; }
    }
}
