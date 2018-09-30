using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PolarisSolutions
{
    class UserDataControl
    {
        private string databaseFile = AppDomain.CurrentDomain.BaseDirectory + "/Credentials.json";
        public void CreateDatabase() {

            if (!File.Exists(databaseFile)) {
                var file = File.CreateText(databaseFile);
            }
        }
        
        public void StoreCredentials()
        {
            
        }
        public string RetrieveCredentials() {
            //open the json file and return the username and password object
            return "";
        }

    }
}
