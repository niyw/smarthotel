using SmartHotel.Web.Pages;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
    
namespace SmartHotel.Web.MUnitTests
{
    [TestClass]
    public class HomePageUnitTests
    {
        [TestMethod]
        public void IndexPageTest()
        {
            AppConfig appconfig = new AppConfig(null);
            IndexModel model = new IndexModel(appconfig);
            Assert.AreEqual("Index", actual: model.DoTest());
        }

    }
}
