using OpenQA.Selenium;
using System;
using System.Configuration;

namespace CGI_OUTBOUND_BC_Scenarios.Utilities
{
    public static class SetMethods
    {
        public static int DefaultTimeOut = Convert.ToInt32(ConfigurationManager.AppSettings.Get("DefaultTimeOut"));

        public static bool IsAlertShown(IWebDriver driver)
        {
            try
            {
                driver.SwitchTo().Alert();
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
            return true;
        }

        public static bool IsElementPresent(IWebDriver driver, By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}