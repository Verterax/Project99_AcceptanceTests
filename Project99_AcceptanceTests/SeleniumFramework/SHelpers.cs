using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Threading;

namespace Project99_AcceptanceTests.SeleniumFramework
{
    public static class SHelpers
    {
        public static string GetValue(this IWebElement element)
        {
            return element.GetAttribute("value");
        }

        public static bool IsInteractive(this IWebElement element)
        {
            return element.Displayed && element.Enabled;
        }

        public static void ScrollToElement(this IWebElement element, IWebDriver driver)
        {
            IJavaScriptExecutor je = ((IJavaScriptExecutor)driver);

            Console.WriteLine("Scrolling to link...");
            je.ExecuteScript("arguments[0].scrollIntoView();", element);
            Thread.Sleep(500); // Give the window time to scroll.
        }


        public static By FindBy(string tag, ElemType type)
        {
            By by; // How to find the element.

            switch (type)
            {
                case ElemType.Id:
                    by = By.Id(tag);
                    break;
                case ElemType.Name:
                    by = By.Name(tag);
                    break;
                default:
                    by = null;
                    break;
            }

            return by;
        }
    }
}
