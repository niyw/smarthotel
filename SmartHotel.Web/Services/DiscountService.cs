using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHotel.Web.Services
{
    public class DiscountService
    {
        private readonly ILogger _logger;
        public DiscountService(ILogger<DiscountService> logger)
        {
            _logger = logger;
        }
        public async Task<double> GetDiscountByCustomer(string customerid) {
            customerid = "aa";
            return customerid.Length;
        }
    }
}
