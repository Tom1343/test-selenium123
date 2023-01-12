using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Configuration;
using System.IO;
using System.Linq;
using TechTalk.SpecFlow;

namespace CGI_OUTBOUND_BC_Scenarios.Utilities
{

    [Binding]
    public class PropertiesCollection
    {
        public IWebDriver Driver { get; set; }
        public static IWebDriver driver { get; set; }
        public const string UITestDriverURL = "UITestDriverURL";
        private IObjectContainer _objectContainer;

        public PropertiesCollection(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void DriverSetupChrome()
        {
            var driverUrl = new Uri(ConfigurationManager.AppSettings.Get("UITestDriverURL"));
            string currentDirectory = Directory.GetCurrentDirectory();
            string[] filePath = Directory.GetFiles(currentDirectory, "Extensions.crx", SearchOption.AllDirectories);

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-popup-blocking");
            options.AddExtensions(filePath.FirstOrDefault());

            options.AddArguments("no-sandbox");
            //options.AddArguments("-incognito");
            Driver = GetRemoteDriver(options, driverUrl);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Maximize();
            _objectContainer.RegisterInstanceAs(Driver);
        }

        private IWebDriver GetRemoteDriver(DriverOptions options, Uri driverUrl)
        {
            return new RemoteWebDriver(driverUrl, options);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //((ITakesScreenshot)Driver).GetScreenshot().SaveAsFile("\\\\S-be-ki-abrain2\\EDIFILES_TEST\\SkatePro\\In\\old\\TestTeam\\screenshots\\" + DateTime.Now.ToString("dd-MM HH-mm ") + ".png", ScreenshotImageFormat.Png);
            Driver.Dispose();
        }
    }
}
