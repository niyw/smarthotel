using SmartHotel.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHotel.Web.Data
{
    public partial class SmartHotelWebContextSeed
    {
        private static void GenerateCity(SmartHotelWebContext db)
        {
            db.Cities.Add(new City()
            {
                Id = 1,
                Name = "Beijing",
                Country = "China"
            });
            db.Cities.Add(new City()
            {
                Id = 2,
                Name = "Shanghai",
                Country = "China"
            }); db.Cities.Add(new City()
            {
                Id = 3,
                Name = "Guangzhou",
                Country = "China"
            }); db.Cities.Add(new City()
            {
                Id = 4,
                Name = "Shenzhen",
                Country = "China"
            });
            db.SaveChanges();
        }
    }
}
