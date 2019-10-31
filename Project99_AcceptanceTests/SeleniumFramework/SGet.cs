using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OpenQA.Selenium;
using System.Threading;
using Project99_AcceptanceTests;
using Project99_AcceptanceTests.POMs;
using OpenQA.Selenium.Support.UI;

namespace Project99_AcceptanceTests.SeleniumFramework
{
    public static class SGet
    {
        /// <summary>
        /// Returns the selected index of a select input element.
        /// </summary>
        /// <param name="selectElement"></param>
        /// <returns></returns>
        public static int GetSelectedIndex(this IWebElement selectElement)
        {
            return int.Parse(selectElement.GetAttribute("selectedIndex"));
        }

    }
}
