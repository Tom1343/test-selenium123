using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using Xunit;
using TechTalk.SpecFlow;
using System.Diagnostics;

namespace CGI_OUTBOUND_BC_Scenarios.Utilities
{
    [Binding]
    public class WaitMethods
    {
        public IWebDriver Driver;

        public WaitMethods(IWebDriver driver) => Driver = driver;

        public WaitMethods WaitForPageToBeReady(int waitTime = 0)
        {
            int overrideWaitTime;
            bool hasElementDisappeared = false;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(100);

            overrideWaitTime = waitTime.Equals(0) ? SetMethods.DefaultTimeOut : waitTime;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (!hasElementDisappeared && stopwatch.Elapsed.TotalSeconds < overrideWaitTime)
            {
                try
                {
                    Driver.FindElement(By.XPath(Page.ProgressBarXPath));
                    hasElementDisappeared = false;
                }
                catch (Exception)
                {
                    hasElementDisappeared = true;
                }
            }
            return this;
        }

        public WaitMethods WaitForPageToBeReadyRUNEDI(int waitTime = 0)
        {
            int overrideWaitTime;
            bool hasElementDisappeared = false;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(100);

            overrideWaitTime = waitTime.Equals(0) ? SetMethods.DefaultTimeOut : waitTime;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (!hasElementDisappeared && stopwatch.Elapsed.TotalSeconds < overrideWaitTime)
            {
                try
                {
                    Driver.FindElement(By.XPath(Page.ProgressBarEDIXPath));
                    hasElementDisappeared = false;
                }
                catch (Exception)
                {
                    hasElementDisappeared = true;
                }
            }
            return this;
        }

        public WaitMethods WaitForMainPageToBeReady(int waitTime = 0)
        {
            int overrideWaitTime;
            bool hasElementDisappeared = false;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(100);

            overrideWaitTime = waitTime.Equals(0) ? SetMethods.DefaultTimeOut : waitTime;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (!hasElementDisappeared && stopwatch.Elapsed.TotalSeconds < overrideWaitTime)
            {
                try
                {
                    Driver.FindElement(By.XPath(Page.ProgressBarMainXPath));
                    hasElementDisappeared = false;
                }
                catch (Exception)
                {
                    hasElementDisappeared = true;
                }
            }
            return this;
        }

        public WaitMethods WaitForElementToBeGone(By elementBy, int waitTime = 0)
        {
            int overrideWaitTime;
            bool hasElementDisappeared = false;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(100);

            overrideWaitTime = waitTime.Equals(0) ? SetMethods.DefaultTimeOut : waitTime;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (!hasElementDisappeared && stopwatch.Elapsed.TotalSeconds < overrideWaitTime)
            {
                try
                {
                    Driver.FindElement(elementBy);
                    hasElementDisappeared = false;
                }
                catch (Exception)
                {
                    hasElementDisappeared = true;
                }
            }

            return this;
        }

        public WaitMethods WaitForPageToBeReadyValidation(int waitTime = 0)
        {
            int overrideWaitTime;
            bool hasElementDisappeared = false;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(100);

            overrideWaitTime = waitTime.Equals(0) ? SetMethods.DefaultTimeOut : waitTime;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (!hasElementDisappeared && stopwatch.Elapsed.TotalSeconds < overrideWaitTime)
            {
                try
                {
                    Driver.FindElement(By.XPath(Page.ProgressBarValidatingXPath));
                    hasElementDisappeared = false;
                }
                catch (Exception)
                {
                    hasElementDisappeared = true;
                }
            }
            return this;
        }

        public WaitMethods WaitForElementToAppear(By elementBy, int waitTime = 0)
        {
            bool hasElementAppeared = false;
            int overrideWaitTime = waitTime.Equals(0) ? SetMethods.DefaultTimeOut : waitTime;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (!hasElementAppeared && stopwatch.Elapsed.TotalSeconds < overrideWaitTime)
            {
                try
                {
                    Assert.True(Driver.FindElement(elementBy).Displayed);
                    hasElementAppeared = true;
                }
                catch (Exception)
                {
                    hasElementAppeared = false;
                }
            }

            return this;
        }

        public WaitMethods WaitForElementToBePresent(By elementBy)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(SetMethods.DefaultTimeOut));
            wait.Until(d => d.FindElement(elementBy));

            return this;
        }

        public WaitMethods WaitForElementToBeClickable(By elementBy)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(SetMethods.DefaultTimeOut));
            wait.Until(c => c.FindElement(elementBy).Displayed && c.FindElement(elementBy).Enabled);

            return this;
        }

        public WaitMethods WaitForAllElementsToBeVisible(By elementBy)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(SetMethods.DefaultTimeOut));
            wait.Until(c => c.FindElement(elementBy).Displayed);

            return this;
        }

        public WaitMethods WaitForFieldToBePopulated(IWebElement element)
        {
            bool isFieldPopulated = false;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (!isFieldPopulated && stopwatch.Elapsed.TotalSeconds < 3)
            {
                try
                {
                    Assert.False(string.IsNullOrEmpty(element.GetAttribute("value")));
                    isFieldPopulated = true;
                }
                catch (Exception)
                {
                    isFieldPopulated = false;
                }
            }
            return this;
        }

        public bool RepeatUntil(Action action, Predicate<IWebDriver> predicate,
            TimeSpan? timeout = null,
            int attemps = 3,
            Action successCallback = null, Action failureCallback = null)
        {
            timeout = timeout ?? new TimeSpan(0, 0, 30);
            var waittime = new TimeSpan(timeout.Value.Ticks / attemps);

            WebDriverWait wait = new WebDriverWait(Driver, waittime);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException), typeof(ElementClickInterceptedException));

            bool success = predicate(Driver);
            while (!success && attemps > 0)
            {
                try
                {
                    attemps--;
                    action();
                    success = wait.Until(d => predicate(d));
                }
                catch (Exception ex) when (ex is WebDriverTimeoutException || ex is ElementClickInterceptedException)
                {
                }
            }

            if (success)
                successCallback?.Invoke();
            else
                failureCallback?.Invoke();

            return success;
        }

        public WaitMethods WaitForElementAttributeValue(IWebElement element, string elementAttribute, string attributeValue)
        {
            bool isElementAttributeValueChanged = false;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (!isElementAttributeValueChanged && stopwatch.Elapsed.TotalSeconds < 5)
            {
                try
                {
                    Assert.Equal(element.GetAttribute(elementAttribute), attributeValue);
                    isElementAttributeValueChanged = true;
                }
                catch (Exception)
                {
                    isElementAttributeValueChanged = false;
                }
            }

            return this;
        }

        public WaitMethods WaitUntilElementExists(By elementLocator, int timeout = 10)
        {
            try
            {
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeout));
                var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((elementLocator)));
                return this;
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
                throw;
            }
        }
    }
}
