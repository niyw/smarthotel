using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartHotel.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelpController : ControllerBase
    {

        [HttpGet("MemberPhone")]
        public ActionResult<string> GetMemberPhone()
        {

            return "400 820 0128";
        }
    }
}
