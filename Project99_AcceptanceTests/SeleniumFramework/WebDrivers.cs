using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Project99_AcceptanceTests.SeleniumFramework
{
    public static class WebDrivers
    {
        private const DriverType _defaultDriverType = DriverType.Chrome;

        private static IWebDriver _chromeDriver;
        public static IWebDriver ChromeDriver {
            get {
                if (_chromeDriver == null)
                {
                    _chromeDriver = new ChromeDriver();
                    _chromeDriver.Manage().Window.Maximize();
                }
                    
                return _chromeDriver;
            }
        }


        private static DriverType _currentDriverType = _defaultDriverType;
        public static DriverType CurrentDriverType {
            get { return _currentDriverType; }
            set { _currentDriverType = value; }
        }

        /// <summary>
        /// Gets the current web driver.
        /// Set the CurrentDriverType property to modify the current driver.
        /// </summary>
        public static IWebDriver Current
        {
            get
            {
                switch (_currentDriverType)
                {
                    case DriverType.Chrome:
                        return ChromeDriver;
                    default:
                        return null;
                }
            }
        }

        public static void ResetCurrentDriver()
        {
            CleanUp();
            switch (_currentDriverType)
            {
                case DriverType.Chrome:
                    _chromeDriver = null;
                    break;
                default:
                    break;
            }

        }

        public static void CleanUp()
        {
            Current.Quit();
            Current.Dispose();
        }
    }
}
