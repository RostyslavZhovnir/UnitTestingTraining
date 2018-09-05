using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace Selenium
{
   

    public class Class1
    {
        IWebDriver Dsa = new ChromeDriver();
       
        public  void Ts ()
        {
            Dsa.Url = "http://toolsqa.com/selenium-webdriver/c-sharp/iwebdriver-browser-commands-in-c-sharp/";

            Dsa.Navigate();
           
        }
        
    }
}
