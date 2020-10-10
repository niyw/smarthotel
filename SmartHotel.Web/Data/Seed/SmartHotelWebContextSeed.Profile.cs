using SmartHotel.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHotel.Web.Data
{
    public partial class SmartHotelWebContextSeed
    {
        private static void GenerateProfile(SmartHotelWebContext db)
        {
            db.Profiles.Add(new Profile()
            {
                UserId = "sunwukong@outlook.com",
                Alias = "sunwukong",
                Loyalty = Loyalty.Platnum
            });

            db.Profiles.Add(new Profile()
            {
                UserId = "tangsheng@outlook.com",
                Alias = "tangsheng",
                Loyalty = Loyalty.Platnum
            });

            db.Profiles.Add(new Profile()
            {
                UserId = "zhubajie@outlook.com",
                Alias = "zhubajie",
                Loyalty = Loyalty.Platnum
            });

            db.Profiles.Add(new Profile()
            {
                UserId = "shawujing@outlook.com",
                Alias = "shawujing",
                Loyalty = Loyalty.Platnum
            });

            db.SaveChanges();
        }
    }
}
