using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_driven_testing.support
{
    class User
    {
        private string firstname;
        private string lastname;
        private string email;
        private string password;
        private string confirmpassword;

        //company
        private string company;
        private string companyOIB;
        private string companyemail;
        private string companyphone;
        private string companycontact;
        private string companyaddress;
        private string companyzipcode;
        private string companycity;
        private string companycountry;

        //private user
        public User(String firstname, String lastname, String email, String password, String confirmpassword)
        {
            SetFirstname(firstname);
            SetLastname(lastname);
            SetEmail(email);
            SetPassword(password);
            SetConfirmpassword(confirmpassword);
        }

        //company user
        public User(String firstname, String lastname, String email, String password, String confirmpassword, String company, String companyOIB, String companyemail, String companyphone, String companycontact, String companyaddress, String companyzipcode, String companycity, String companycountry)
        {
            SetCompany(company);
            SetCompanyOIB(companyOIB);
            SetCompanyEmail(companyemail);
            SetCompanyPhone(companyphone);
            SetCompanyContact(companycontact);
            SetCompanyAddress(companyaddress);
            SetCompanyZipcode(companyzipcode);
            SetCompanyCity(companycity);
            SetCompanyCountry(companycountry);
            SetFirstname(firstname);
            SetLastname(lastname);
            SetEmail(email);
            SetPassword(password);
            SetConfirmpassword(confirmpassword);
        }
        
        public string GetFirstname()
        {
            return firstname;
        }
        public void SetFirstname(string firstname)
        {
            this.firstname = firstname;
        }

        public string GetLastname()
        {
            return lastname;
        }
        public void SetLastname(string lastname)
        {
            this.lastname = lastname;
        }

        public string GetEmail()
        {
            return email;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetPassword()
        {
            return password;
        }
        public void SetPassword(string password)
        {
            this.password = password;
        }

        public string GetConfirmpassword()
        {
            return confirmpassword;
        }
        public void SetConfirmpassword(string confirmpassword)
        {
            this.confirmpassword = confirmpassword;
        }

        public string GetCompany()
        {
            return company;
        }
        public void SetCompany(string company)
        {
            this.company = company;
        }

        public string GetCompanyOIB()
        {
            return companyOIB;
        }
        public void SetCompanyOIB(string companyOIB)
        {
            this.companyOIB = companyOIB;
        }

        public string GetCompanyEmail()
        {
            return companyemail;
        }
        public void SetCompanyEmail(string companyemail)
        {
            this.companyemail = companyemail;
        }

        public string GetCompanyPhone()
        {
            return companyphone;
        }
        public void SetCompanyPhone(string companyphone)
        {
            this.companyphone = companyphone;
        }

        public string GetCompanyContact()
        {
            return companycontact;
        }

        public void SetCompanyContact(string companycontact)
        {
            this.companycontact = companycontact;
        }

        public string GetCompanyAddress()
        {
            return companyaddress;
        }

        public void SetCompanyAddress(string companyaddress)
        {
            this.companyaddress = companyaddress;
        }

        public string GetCompanyZipcode()
        {
            return companyzipcode;
        }
        public void SetCompanyZipcode(string companyzipcode)
        {
            this.companyzipcode = companyzipcode;
        }

        public string GetCompanyCity()
        {
            return companycity;
        }
        public void SetCompanyCity(string companycity)
        {
            this.companycity = companycity;
        }

        public string GetCompanyCountry()
        {
            return companycountry;
        }
        public void SetCompanyCountry(string companycity)
        {
            this.companycountry = companycountry;
        }


        //{
        //    return companycity;
        //}

        //public void SetCompanycity(string companycity)
        //{
        //    this.companycity = companycity;
        //}
    }
}

