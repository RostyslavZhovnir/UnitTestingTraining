using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UnitTestingStudy.Controllers;

namespace UnitTestingStudy.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            var x = controller.ViewBag.Test;

            // Assert
            Assert.AreEqual(21, x.ArtistId);
            //Assert.Equals(result, 22);
        }

        [TestMethod]
        public void About()   
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            
            
            // Assert
            Assert.AreEqual(result.ViewName, "About");
            // Assert
            //Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            IWebDriver Dsa = new ChromeDriver();

           
                Dsa.Url = "http://yahoo.com";
                Dsa.Navigate();
                var actualResult = Dsa.FindElement(By.Id("uh-search-box"));
                actualResult.SendKeys("testAut");
                actualResult.Submit();
            var expected = Dsa.FindElement(By.Id("yschsp")).GetAttribute("value");
            Assert.AreEqual(expected, "testAut");
            Dsa.Dispose();

        }
    }
}
