using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

namespace SmartHotel.Web.Pages
{
    public class IndexModel : PageModel
    {
        public string sqlCS;
        public string HitCount="100";
        public string LastAccessDate=DateTime.Now.ToString(@"MM\/dd\/yyyy HH:mm:ss");
        
        public IndexModel(AppConfig appconfig)
        {
            sqlCS = appconfig.sqlCS;
        }

        public void OnGet()
        {
        }

        public string DoTest()
        {
            return "Index";
        }
    }
}