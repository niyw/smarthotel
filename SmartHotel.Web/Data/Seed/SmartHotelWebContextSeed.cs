using Microsoft.EntityFrameworkCore.Internal;
using SmartHotel.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHotel.Web.Data
{
    public partial class SmartHotelWebContextSeed
    {
        public static void Seed(SmartHotelWebContext db)
        {
            if (db.Cities.Any())
                return;

            GenerateCity(db);
            GenerateHotel(db);
            GenerateProfile(db);

        }
    }
}
