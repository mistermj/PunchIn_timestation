using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolarisSolutions
{
    class Employees
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        IDictionary<string, string> employees;

        public Employees() {
            employees = new Dictionary<string, string>();
        }
        public void RetrieveSavedEmployees() {
            //load all the saved employee data into dictionary and send it over to userDatControl Class.

        }
    }
}
