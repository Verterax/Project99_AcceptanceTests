using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Project99_AcceptanceTests.POMs
{
    public class POMPage
    {

        private readonly IWebDriver _driver;
        public IWebDriver Driver { get { return _driver; } }

        private readonly string _baseURL;
        public string BaseURL { get { return _baseURL; } }

        public POMPage(IWebDriver driver, string baseURL = "")
        {
            _driver = driver;
            _baseURL = baseURL;
        }

        /// <summary>
        /// Tries to send the driver to this page's BaseURL.
        /// </summary>
        public void NavigateToBaseURL()
        {
            if (BaseURL != String.Empty)
                this.Driver.Navigate().GoToUrl(this.BaseURL);
        }
    }
}
