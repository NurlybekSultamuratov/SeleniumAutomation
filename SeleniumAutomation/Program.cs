using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Diagnostics;

namespace SeleniumAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new ChromeOptions();
            options.BinaryLocation = "C:\\Program Files\\BraveSoftware\\Brave-Browser\\Application\\brave.exe";
            
            //initiate WebDriver with my Brave
            IWebDriver driver = new ChromeDriver(options);

            //var tabs = driver.WindowHandles;

            try
            {
                Stopwatch stopwatch = Stopwatch.StartNew();

                //open link
                driver.Navigate().GoToUrl("https://profile-store-gamma.vercel.app/");
                stopwatch.Stop();
           
                Console.WriteLine("Page title: " + driver.Title);
                Console.WriteLine("Page loaded in : " + stopwatch.ElapsedMilliseconds + " ms");
             
                stopwatch.Restart();
                driver.Navigate().Refresh();
                stopwatch.Stop();
                Console.WriteLine("Page refreshed in : "+ stopwatch.ElapsedMilliseconds + " ms");
              
                //actions here

                // IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                // js.ExecuteScript("window.open('');");



                stopwatch.Restart();
                driver.Navigate().GoToUrl("https://www.google.com/");
                Console.WriteLine("Page title: " + driver.Title);
                driver.Navigate().Refresh();
                Console.WriteLine("Page visited and refreshed in : " + stopwatch.ElapsedMilliseconds + " ms");
           
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
            finally
            {
                //close current window
            //    driver.Close();
            }
        }
    }
}
