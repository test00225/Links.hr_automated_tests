using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace data_driven_testing.pageobjects
{
    public class CommonPageObjects
    {
        private IWebDriver driver;

        public CommonPageObjects(IWebDriver driver)
        {
            this.driver=driver;
        }

        //list of page components

        public string ApplicationURL = "https://www.links.hr";

        public By PageTitle = By.CssSelector("h1");
        // logout page component
        public By BtnLogout = By.XPath("//a[@href='/hr/logout']");


        // list of page actions 
        public void OpenApplication()
        {
            driver.Navigate().GoToUrl(ApplicationURL);
        }

        public void CloseApplication()
        {
            driver.Close();
        }  
    }
}
