using SmartHotel.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHotel.Web.Data
{
    public partial class SmartHotelWebContextSeed
    {
        private static void GenerateHotel(SmartHotelWebContext db)
        {
            db.Hotels.Add(new Hotel()
            {
                Id = 1,
                Name = "Beijing Marriott Executive Apartments",
                Description = "Comfortable apartment hotel in Wangfujing district with a pool, a gym and a Resident's Lounge.",
                Address = "North Gate, No 1 Xiagongfu Street, Dongcheng District Beijing",
                City = db.Cities.First(c => c.Id == 1),
                Rating = 4,
                RoomTypes = new List<RoomType> {
                    new RoomType
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
                    }
                },
                CheckinTime = 15,
                CheckoutTime = 12,
                PhoneNumber = "+86 10 6564 9999"
            });
            db.Hotels.Add(new Hotel()
            {
                Id = 2,
                Name = "Renaissance Beijing Wangfujing Hotel",
                Description = "Renaissance Beijing Wangfujing Hotel, just moments away from The Forbidden City.",
                Address = "57 Wangfujing Street, Dongcheng District Beijing",
                City = db.Cities.First(c => c.Id == 1),
                Rating = 4,
                RoomTypes = new List<RoomType> { new RoomType
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
                    }},
                CheckinTime = 15,
                CheckoutTime = 12,
                PhoneNumber = "+86 10 6520 8888"
            });

            db.Hotels.Add(new Hotel()
            {
                Id = 3,
                Name = "JW Marriott Hotel Shanghai at Tomorrow Square",
                Description = "Authentically reflects the surroundings, imparts a sense of harmony and well-being,delivers memories",
                Address = "399 Nanjing West Road, Huangpu District Shanghai",
                City = db.Cities.First(c => c.Id == 2),
                Rating = 5,
                RoomTypes = new List<RoomType>
                {
                    new RoomType
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
                    }
                },
                CheckinTime = 15,
                CheckoutTime = 12,
                PhoneNumber = "+86 21 5359 4969"
            });

            db.Hotels.Add(new Hotel()
            {
                Id = 4,
                Name = "The Westin Bund Center, Shanghai",
                Description = "The Westin is located in the heart of downtown Shanghai and is near the bund waterfront.",
                Address = "Bund Center, 88 Henan Central Road Shanghai",
                City = db.Cities.First(c => c.Id == 2),
                Rating = 4,
                RoomTypes = new List<RoomType> {
                    new RoomType
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
                    }
                },
                CheckinTime = 15,
                CheckoutTime = 12,
                PhoneNumber = "+86 21 6335 1888"
            });

            db.Hotels.Add(new Hotel()
            {
                Id = 5,
                Name = "Sheraton Guangzhou Hotel",
                Description = "Modern Guangzhou, China hotel with event venues, a spa, an outdoor pool, fitness center and dining",
                Address = "208 Tianhe Rd Junction of Tiyu Xi Rd & Tianhe Rd, Tianhe District Guangzhou",
                City = db.Cities.First(c => c.Id == 3),
                Rating = 5,
                RoomTypes = new List<RoomType> {
                new RoomType
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
                    }
                },
                CheckinTime = 15,
                CheckoutTime = 12,
                PhoneNumber = "+86 20 6668 8888"
            });

            db.Hotels.Add(new Hotel()
            {
                Id = 6,
                Name = "The Westin Guangzhou",
                Description = "The Westin Guangzhou is Located in the heart of the Tian He business district, Guangzhou CBD area.",
                Address = "6 Lin He Zhong Road, Tian He District Guangzhou",
                City = db.Cities.First(c => c.Id == 3),
                Rating = 4,
                RoomTypes = new List<RoomType> {
                new RoomType
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
                    }
                },
                CheckinTime = 15,
                CheckoutTime = 12,
                PhoneNumber = "+86 20 2886 6868"
            });

            db.Hotels.Add(new Hotel()
            {
                Id = 7,
                Name = "The Ritz-Carlton, Shenzhen",
                Description = "Oasis in the center of Shenzhen",
                Address = "116 Fuhua San Road, Futian District",
                City = db.Cities.First(c => c.Id == 4),
                Rating = 5,
                RoomTypes = new List<RoomType> {
                    new RoomType
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
                    }
                },
                CheckinTime = 15,
                CheckoutTime = 12,
                PhoneNumber = "+8675522222222"
            });

            db.Hotels.Add(new Hotel()
            {
                Id = 8,
                Name = "JW Marriott Hotel Shenzhen",
                Description = "A luxury city centre hotel in Shenzhen, with amazing golf views, free Wi-Fi and exceptional service.",
                Address = "Shennan Boulevard, Futian District Shenzhen",
                City = db.Cities.First(c => c.Id == 4),
                Rating = 4,
                RoomTypes = new List<RoomType> {
                new RoomType
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
                    }
                },
                CheckinTime = 15,
                CheckoutTime = 12,
                PhoneNumber = "+86 755 2269 8888"
            });

            db.SaveChanges();
        }
    }
}
