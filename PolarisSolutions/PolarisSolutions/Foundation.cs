using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace PolarisSolutions
{
    public static class Foundation
    {
        
        private static string databaseFile = AppDomain.CurrentDomain.BaseDirectory + "/Credentials.json";

        private const string defaultUrl = "https://www.mytimestation.com/Login.asp";
        private static string Username { get; set; }
        private static string Password { get; set; }
        private static bool IsPunchedIn { get; set; }
        private static bool IsPunchedOut { get; set; }
        private static bool IsRedirected { get; set; }
        /*public Foundation( string username, string password ) {
            driver = new ChromeDriver();           
            Username = username;
            Password = password;
        }*/
        public static void ShowStatusMessage ( string message ) {
            MessageBox.Show(message, "Confirm", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public static void CustomPunchIn( string username, string password)
        {
            Username = username;
            Password = password;
            PunchInAndOut();
        }
        public static bool IsEmpty( string username, string password) {
            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                return true;
            }
            return false;
        }
        public static void PunchInAndOut() {
            
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(defaultUrl);

            var _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            _wait.Until(driver1 => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
            // lambda expression
            var email = driver.FindElementByName("eMail");
            var password = driver.FindElementByName("Password");
            var submit = driver.FindElementByName("submit");

            email.Clear();
            email.SendKeys(Username);

            password.Clear();
            password.SendKeys(Password);

            submit.Click();

            if (driver.Url != defaultUrl) {
                IsRedirected = true;

                var punchIn = driver.FindElementByName("submitButton");
                punchIn.Click();

                IsPunchedIn = true;
            }

            //check if text on button changed
            if (IsPunchedIn) {
                DestroyBrowser(ref driver);
            }
        }
        public static void DestroyBrowser(ref ChromeDriver driver)
        {
            driver.Quit();
        }
        public static void LoadCredentials()
        {
            if (File.Exists(databaseFile))
            {
                var data = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(databaseFile));
                Username =  data["username"];
                Password = data["password"];
                if (!IsEmpty(Username, Password))
                {
                    PunchInAndOut();
                }
                else
                {
                    ShowStatusMessage("ERROR: Cannot Load Credentials!");
                }
                ShowStatusMessage("Action Performed!");
            }
        }
    }
}
