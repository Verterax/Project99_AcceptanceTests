using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace Project99_AcceptanceTests.SeleniumFramework
{
    public static class SSet
    {
        /// <summary>
        /// Sets the text of a given element and element type.
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static void SetText(string tag, ElemType type, string value)
        {
            By by = SHelpers.FindBy(tag, type);
            WebDrivers.Current.FindElement(by).SendKeys(value);
        }

        public static void SelectDropdown(string tag, ElemType type, string value)
        {
            By by = SHelpers.FindBy(tag, type);
            new SelectElement(WebDrivers.Current.FindElement(by)).SelectByText(value);
        }

        public static void SelectDropdownItem(this IWebElement element, int index)
        {
            new SelectElement(element).SelectByIndex(index);
        }



    }
}
