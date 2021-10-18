using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_driven_testing.support;
using data_driven_testing.pageobjects;
using data_driven_testing.testdata;


namespace data_driven_testing.testdata
{
    class RegisterTestData
    {
        public static List<User> PrivateUsers = new List<User>();

        public static List<User> CompanyUsers = new List<User>();

        public static void FillPrivateUsers()
        {
            PrivateUsers.Add(new User("Petar", "Petrovic", "petarpetrovic141@yopmail.com", "petar011", "petar011"));
          //  PrivateUsers.Add(new User("Milos", "Milosevic", "milosmilosevic1@yopmail.com", "milos02", "milos02"));
          //  PrivateUsers.Add(new User("Marko", "Markovic", "markomarkovic1@yopmail.com", "marko03", "marko03"));
          
        }

        public static void FillCompanyUsers()
        {
            CompanyUsers.Add(new User("Milan", "Milanovic", "mmilanovic1@yopmail.com", "milan01", "milan01", "milan doo", "12345678912", "mmilanovic@yopmail.com", "0646363631", "Milan Milanovic", "Milutina  ilankovica 6", "11000", "Beograd", "Srbija"));


        }
    }
}
