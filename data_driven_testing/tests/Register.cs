using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_driven_testing.support;
using data_driven_testing.pageobjects;
using data_driven_testing.testdata;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;



namespace data_driven_testing.tests
{
    [TestFixture]
    public class Register
    {
        private static IWebDriver driver = new ChromeDriver();

        private RegisterPageObject registerPage = new RegisterPageObject(driver);

        private CommonPageObjects common = new CommonPageObjects(driver);

        [SetUp]
        public void Setup()
        {
            common.OpenApplication();
        }

        [TearDown]
        public void TearDown()
        {
            common.CloseApplication();
        }

        [Test]
        public void TcRegisterPrivateUser()
        {
            RegisterTestData.FillPrivateUsers();
          
            foreach (User user in RegisterTestData.PrivateUsers)
            {
                // main test script
                registerPage.Open();
                registerPage.PopulateFirstname(user.GetFirstname());
                registerPage.PopulateLastname(user.GetLastname());
                registerPage.PopulateEmail(user.GetEmail());
                registerPage.PopulatePassword(user.GetPassword());
                registerPage.PopulateConfirmPassword(user.GetConfirmpassword());
                registerPage.Register();

                Assert.IsTrue(driver.FindElement(By.ClassName("result")).Text.Contains("Poslan vam je e-mail koji sadrži upute za aktivaciju članstva"), "REGISTER NOT OK");
                // Utils.IsPresent(driver, common.MenuLogout);
                // common.Logout();

            }
        }



        [Test]
        public void TcRegisterCompanyUser()
        {
            RegisterTestData.FillCompanyUsers();

            foreach (User user in RegisterTestData.CompanyUsers)
            {
                // main test script
             
                registerPage.Open();
                registerPage.AsCompany();
                registerPage.PopulateCompany(user.GetCompany());
                registerPage.PopulateCompanyOIB(user.GetCompanyOIB());
                registerPage.PopulateCompanyAddress(user.GetCompanyAddress());
                registerPage.PopulateCompanyZipcode(user.GetCompanyZipcode());
                //registerPage.PopulateCompanyCountry(user.GetCompanyCountry());
                registerPage.PopulateCompanyCity(user.GetCompanyCity());
                registerPage.PopulateFirstname(user.GetFirstname());
                registerPage.PopulateLastname(user.GetLastname());
                registerPage.PopulateEmail(user.GetEmail());
                registerPage.PopulatePassword(user.GetPassword());
                registerPage.PopulateConfirmPassword(user.GetConfirmpassword());
                registerPage.Register();

                Assert.IsTrue(driver.FindElement(By.ClassName("result")).Text.Contains("Poslan vam je e-mail koji sadrži upute za aktivaciju članstva"), "REGISTER NOT OK");
             
            }
        }

       
    }
}

