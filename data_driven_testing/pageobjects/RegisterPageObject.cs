using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;




namespace data_driven_testing.pageobjects
{
    class RegisterPageObject
    {
        private IWebDriver driver;
        private CommonPageObjects common;

        public RegisterPageObject(IWebDriver driver)
        {
            this.driver = driver;
            this.common = new CommonPageObjects(this.driver);
        }
                

        /* list of page components */

        public string RegisterPageURL = "/hr/register";

        //company data

        public By TxtCompany = By.Id("Company");

        public By TxtCompanyOIB = By.Id("CompanyOIB");

        public By TxtCompanyEmail = By.Id("CompanyEmail");

        public By TxtCompanyPhone = By.Id("CompanyTelephone");

        public By TxtCompanyContact = By.Id("CompanyContactPerson");

        public By TxtCompanyAddress = By.Id("CompanyAddress");

        public By TxtCompanyZipcode = By.XPath("/html/body/div[5]/div[8]/div[4]/div[1]/form/div/div[3]/div[2]/div[2]/div[2]/div[7]/input[1]");

        public By TxtCompanyCity = By.XPath("/html/body/div[5]/div[8]/div[4]/div[1]/form/div/div[3]/div[2]/div[2]/div[2]/div[8]/input[1]");

        //personal data

        public By CheckboxCompany = By.Id("RegisterAsCompany");

        public By RadiobuttonMale = By.Id("gender-male");

        public By RadiobuttonFemale = By.Id("gender-female");

        public By TxtFirstName = By.Id("FirstName");

        public By TxtLastName = By.Id("LastName");

        public By TxtEmail = By.Id("Email");

        public By TxtStreet = By.Id("StreetAdress");

        public By TxtZipCode = By.XPath("/html/body/div[5]/div[8]/div[4]/div[1]/form/div/div[3]/div[4]/div[2]/div[2]/input[1]");

        public By TxtCity = By.XPath("/html/body/div[5]/div[8]/div[4]/div[1]/form/div/div[3]/div[4]/div[2]/div[3]/input[1]");

        public By TxtCountry= By.Id("CountryId_dropdown");

        public By TxtPhone = By.Id("Phone");

        public By TxtPassword = By.Id("Password");

        public By TxtConfirmPassword = By.Id("ConfirmPassword");

        public By BtnRegister = By.Id("register-button");


        /* list of page actions */

        public void Open()
        {
            driver.Navigate().GoToUrl(common.ApplicationURL + RegisterPageURL);
        }

        public void PopulateFirstname(String firstname)
        {
            driver.FindElement(TxtFirstName).SendKeys(firstname);

        }

        public void PopulateLastname(String lastname)
        {
            driver.FindElement(TxtLastName).SendKeys(lastname);

        }
        public void PopulateEmail(String email)
        {
            driver.FindElement(TxtEmail).SendKeys(email);

        }

        public void PopulatePassword(String pwd)
        {
            driver.FindElement(TxtPassword).SendKeys(pwd);
        }

        public void PopulateConfirmPassword(String confirmpwd)
        {
            driver.FindElement(TxtConfirmPassword).SendKeys(confirmpwd);
        }

        //actions for company user

        public void AsCompany()
        {
            driver.FindElement(CheckboxCompany).Click();
        }
        public void PopulateCompany(String company)
        {
            driver.FindElement(TxtCompany).SendKeys(company);
        }
        public void PopulateCompanyCountry(String country)
        {
            driver.FindElement(TxtCountry).SendKeys(country);
        }

        public void PopulateCompanyOIB(String companyOIB)
        {
            driver.FindElement(TxtCompanyOIB).SendKeys(companyOIB);
        }

        public void PopulateCompanyAddress(String companyaddress)
        {
            driver.FindElement(TxtCompanyAddress).SendKeys(companyaddress);
        }

        public void PopulateCompanyZipcode(String companyzipcode)
        {
            driver.FindElement(TxtCompanyZipcode).SendKeys(companyzipcode);
        }

        public void PopulateCompanyCity(String companycity)
        {
            driver.FindElement(TxtCompanyCity).SendKeys(companycity);
        }
        public void Register()
        {
            driver.FindElement(BtnRegister).Click();
        }
    }
}
