using CGI_OUTBOUND_BC_Scenarios.Utilities;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Xunit;
using static System.Net.Mime.MediaTypeNames;


namespace CGI_OUTBOUND_BC_Scenarios.OUTBOUND.Pages
{
    [Binding]
    public class BCOutboundPage1 : Page
    {
        private WaitMethods WaitMethods => new WaitMethods(Driver);
        public BCOutboundPage1(IWebDriver driver) : base(driver) { }

        #region Variables
        public string IShouldGetPOWERPACKINGMODULEsERROROutbound => IShouldGetPOWERPACKINGMODULEERROROutbound.Text;

        public string IShouldGetErrorMessagePACKING => IShouldGetErrorsMessagePACKING.Text;

        public string IShouldGetPOWERPACKINGMODULEsComment => IShouldGetPOWERPACKINGMODULEComment.Text;
        public string IShouldGetErrorMessagePackingNotifications => IShouldGetErrorMessagePackingNotification.Text;
        public string IShouldGetPOWERErrorMessagePOWERPackingNotifications => IShouldGetPOWERErrorMessagePOWERPackingNotification.Text;
        public string IShouldGetErrorMessagesLabel => IShouldGetErrorMessageLabel.Text;
        public string IGetNotificationInPackingCard => IGetNotificationInPacking.Text;
        public string IShouldGetPOWERPACKINGMODULEsERROR => IShouldGetPOWERPACKINGMODULEERROR.Text;
        public string IShouldGetPOWERPACKINGMODULEsERRORUnknown => IShouldGetPOWERPACKINGMODULEERRORUnknown.Text;
        public string IShouldSeePopupMessageErrorAfterCLOSEINGTRO => IShouldSeePopupMessageErrorAfterCLOSETRO.Text;
        public string IShouldSeePopupMessageErrorsAfterCutoff => IShouldSeePopupMessageErrorAfterCutoff.Text;
        public string IShouldSeePopupMessageErrorAfterCLOSEINGTRONotFullyBooked => IShouldSeePopupMessageErrorAfterCLOSETRONotFullyBooked.Text;
        public string IShouldSeePopupErrorMessageAfterChoosingDestinationGroup => IShouldSeePopupErrorMessageAfterChoosingDestinationGroupInTRO.Text;
        public string IShouldSeePopupErrorMessageAfterChoosingDestinationGroupInTROQGs => IShouldSeePopupErrorMessageAfterChoosingDestinationGroupInTROQG.Text;
        public string IShouldSeePopupMessageErrorAfterCLOSEINGTRONoStatusLoadeed => IShouldSeePopupMessageErrorAfterCLOSETROHasNoStatusLoaded.Text;
        public string IShouldGetDateErrorTRONotifications => IShouldGetDateErrorTRONotification.Text;
        public string IShouldGetErrorForUnlinkingTRONotifications => IShouldGetErrorForUnlinkingTRONotification.Text;
        public string IShouldGetCancelNotificationMessage => IShouldGetCancelNotificationMessages.Text;
        public string IShouldGetErrorOnPalletPoolTROCard => IShouldGetErrorOnPalletPoolTRO.Text;
        public string IShouldSeePopupMessageAfterLinkWithWrongTROsDestinationGroup => IShouldSeePopupMessageAfterLinkWithWrongTRODestinationGroup.Text;
        public string IShouldGetBATCHWAVES => IShouldGetBATCHWAVE.Text;
        public string IShouldGetNotificationOutboundCancelOrderlines => IShouldGetNotificationOutboundCancelOrderline.Text;
        public string IShouldGetNotificationTROPrintMessages => IShouldGetNotificationTROPrintMessage.Text;
        public string IShouldGetNotificationOutboundHolderUnpacked => IGetNotificationHolderHasBeenUnpacked.Text;
        public string IGetPowerbatchCardStatuses => IGetPowerbatchCardStatus.Text;
        public string IGetBatchNotifications => IGetBatchNotification.Text;
        public string IGetCreatedBatchNotifications => IGetCreatedBatchNotification.Text;
        public string IGetQueuesGroupBatchNotification => IGetQueueGroupBatchNotification.Text;
        //public string IShouldGetDestinationNotificationsOutboundCancelOrderline => IShouldGetDestinationNotificationOutboundCancelOrderline.Text;
        public string IShouldGetStatusOutboundOrdersReserved => IShouldGetStatusOutboundOrderReserved.Text;

        public string IShouldGetStatusOutboundOrderInOrderCard => IShouldGetStatusOutboundOrderInOrder.Text;
        public string IShouldGetNotificationOnDeleteLinkedTransportsPicking_TROQueueGroupList => IShouldGetNotificationOnDeleteLinkedTransportPicking_TROQueueGroupList.Text;
        public string IShouldGetErrorsOutboundDifference => IShouldGetErrorOutboundDifference.Text;
        public string IShouldGetErrorBookBackPartOfSelectedLines => IShouldGetErrorBookBackPartOfSelectedLine.Text;
        public string IGetErrorOutboundCard => IGetErrorOutbound.Text;

        #endregion
        private BCOutboundPage2 BCOutboundPage2 => new BCOutboundPage2(Driver);
        private BCOutboundPage3 BCOutboundPage3 => new BCOutboundPage3(Driver);
        private BCOutboundPage4 BCOutboundPage4 => new BCOutboundPage4(Driver);
        private BCOutboundPage5 BCOutboundPage5 => new BCOutboundPage5(Driver);
        private BCOutboundPage6 BCOutboundPage6 => new BCOutboundPage6(Driver);
        private BCOutboundPage7 BCOutboundPage7 => new BCOutboundPage7(Driver);

        public BCOutboundPage1 NavigateToNavNext()
        {
            var applicationUrl = new Uri(ConfigurationManager.AppSettings.Get("UITestBaseURL"));

            Driver.Navigate().GoToUrl(applicationUrl);
            Driver.Navigate().Refresh();

            return this;
        }
        public BCOutboundPage1 NavigateToNavNextBaselineTwo()
        {
            var applicationUrl = new Uri(ConfigurationManager.AppSettings.Get("UITestBaseURLBaselineTwo"));

            Driver.Navigate().GoToUrl(applicationUrl);
            //Driver.Navigate().Refresh();

            return this;
        }

        public BCOutboundPage1 NavigateToNavNextMadefur()
        {
            var applicationUrl = new Uri(ConfigurationManager.AppSettings.Get("UITestMadefur"));

            Driver.Navigate().GoToUrl(applicationUrl);

            WaitMethods.WaitForMainPageToBeReady()
                    .WaitForElementToAppear(By.XPath(MainContentFrameXPath));

            return this;
        }

        public BCOutboundPage1 NavigateToNavNextAdeo()
        {
            var applicationUrl = new Uri(ConfigurationManager.AppSettings.Get("UITestAdeo"));

            Driver.Navigate().GoToUrl(applicationUrl);

            WaitMethods.WaitForMainPageToBeReady()
                    .WaitForElementToAppear(By.XPath(MainContentFrameXPath));

            return this;
        }

        public BCOutboundPage1 NavigateToNavNextKitchenAid()
        {
            var applicationUrl = new Uri(ConfigurationManager.AppSettings.Get("UITestKitchenAidTest"));

            Driver.Navigate().GoToUrl(applicationUrl);
            return this;
        }

        public BCOutboundPage1 NavigateToNavNextSTST()
        {
            var applicationUrl = new Uri(ConfigurationManager.AppSettings.Get("UITestSTST"));

            Driver.Navigate().GoToUrl(applicationUrl);

            return this;
        }
        public BCOutboundPage1 NavigateToNavNextBaselinethree()
        {
            var applicationUrl = new Uri(ConfigurationManager.AppSettings.Get("UITestBaseURLBaselineThree"));

            Driver.Navigate().GoToUrl(applicationUrl);

            return this;
        }
        public BCOutboundPage1 NavigatetoNavNextNilfisk()
        {
            var applicationUrl = new Uri(ConfigurationManager.AppSettings.Get("UITestNilfisk"));

            Driver.Navigate().GoToUrl(applicationUrl);
            

            return this;
        }
        public BCOutboundPage1 SwitchToMainContentFrame()
        {
            Driver.SwitchTo().DefaultContent();
            WaitMethods.WaitForElementToBePresent(By.XPath(MainContentFrameXPath));
            Driver.SwitchTo().Frame(MainContentFrame);

            return this;
        }

        public BCOutboundPage1 ClickOutboundWithoutSwitchingFrames()
        {

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(ClickOutboundFromMainMenuXpath)).Displayed);
            ClickOutboundFromMainMenu.Click();

            return this;
        }
        public BCOutboundPage1 GoBackOneWindowWithESC()
        {
            new Actions(Driver)
            .SendKeys(Keys.Escape)
            .Perform();

            return this;
        }


        public BCOutboundPage1 ClickExpectedInboundDelivery()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ExpectedInboundDeliveryXpath))
               .WaitForElementToBeClickable(By.XPath(ExpectedInboundDeliveryXpath));

            ExpectedInboundDelivery.Click();


            return this;
        }

        public BCOutboundPage1 TypeSupplierCodeOnInboundsDelivery(string supplierCode)
        {
            WaitMethods.WaitForAllElementsToBeVisible(By.XPath(TypeSupplierCodeOnInboundDeliveryXpath));
            TypeSupplierCodeOnInboundDelivery.Clear();
            TypeSupplierCodeOnInboundDelivery.SendKeys(supplierCode);

            return this;
        }
        public BCOutboundPage1 ClickManagesFromExpected()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ClickManageFromExpectedXpath));

            WaitMethods.WaitForElementToAppear(By.XPath(ClickManageFromExpectedXpath))
                        .WaitForElementToBeClickable(By.XPath(ClickManageFromExpectedXpath));
            ClickManageFromExpected.Click();


            return this;
        }

        public BCOutboundPage1 ClickGeneralOfTheSetupNavMenu()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("(//div[contains(@class,'ContextualMenu')])[1]"));
            WaitMethods.WaitForElementToAppear(By.XPath("//div[text()='General']"));
            IWebElement elem = Driver.FindElement(By.XPath("//div[text()='General']"));
            Actions action = new Actions(Driver);
            action
                .MoveToElement(elem)
                .Click();
            action
                .Build()
                .Perform();
            return this;
        }

        public BCOutboundPage1 BookAllFromExpectedTRI()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(BookAllInExpectedTRIXpath))
                .WaitForElementToBeClickable(By.XPath(BookAllInExpectedTRIXpath));

            BookAllInExpectedTRI.Click();
            WaitMethods.WaitForElementToBeGone(By.XPath("//body[@class='chrome mouse has-product-menu-bar']//following::div[@class='ms-nav-exceptiondialogframe progress-dialog']//following::span[text()='Working on it...']"));
            System.Threading.Thread.Sleep(3000);

            return this;
        }
        public BCOutboundPage1 ClickBookAllInInStockMasters()
        {
            string booked = "Booked";
            IWebElement statusField = Driver.FindElement(By.XPath("/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[5]/div[3]/div/div/div/div[2]/table/tbody/tr[1]/td[7]/span"));

            WaitMethods.RepeatUntil(
            () =>
            {
                IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
                executor.ExecuteScript("arguments[0].click();", ClickInStockFromInStockMaster);
                WaitMethods.WaitForElementToAppear(By.XPath(ClickBookAllInInStockMasterXpath))
                            .WaitForElementToBeClickable(By.XPath(ClickBookAllInInStockMasterXpath));
                ClickBookAllInInStockMaster.Click();
                WaitMethods.WaitForElementToBeGone(By.XPath("//body[@class='chrome mouse has-product-menu-bar']//following::div[@class='ms-nav-exceptiondialogframe progress-dialog']//following::span[text()='Working on it...']"));
            },
            _ => statusField.GetAttribute("title").Equals(booked),
            TimeSpan.FromSeconds(2), 5
            );

            //ClickBookAllInInStockMaster.Click();
            WaitMethods.WaitForElementToBeGone(By.XPath("//span[text()='Working on it...']"));

            return this;

            
        }
        public BCOutboundPage1 BookBackInInStockMaster()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(BookBackAllInStockMasterXpath))
                .WaitForElementToBeClickable(By.XPath(BookBackAllInStockMasterXpath));
            BookBackAllInStockMaster.Click();

            return this;
        }
        public BCOutboundPage1 ClickInStockFromInStockMasters()
        {
            //IWebElement grid = Driver.FindElements(By.XPath("//table[contains(@id,'BusinessGrid')]")).Last();

            //WaitMethods.WaitForElementAttributeValue(grid, "aria-rowcount", "25");
            WaitMethods.WaitForElementToAppear(By.XPath(ClickInStockFromInStockMasterXpath))
                         .WaitForElementToBeClickable(By.XPath(ClickInStockFromInStockMasterXpath));

            //ClickInStockFromInStockMaster.Click();

            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click();", ClickInStockFromInStockMaster);
            IWebElement InStockAtt = Driver.FindElement(By.XPath("//span[text()='In stock']//ancestor::a[@aria-expanded='true']"));
            WaitMethods.WaitForElementAttributeValue(InStockAtt, "aria-expanded", "true");

            return this;
        }
        public BCOutboundPage1 SwitchToPowerModuleError()
        {

            Driver.SwitchTo().DefaultContent();
            WaitMethods.WaitForElementToAppear(By.XPath(MainContentFrameXPath), 10);
            Driver.SwitchTo().Frame(MainContentFrame);

            WaitMethods.WaitForElementToAppear(By.XPath("(//div[@class='task-dialog-content-container thm-cont-g0-bgcolor-1'])[2]//div//div//div[4]//div//iframe"), 10);
            IWebElement iframe = Driver.FindElement(By.XPath("(//div[@class='task-dialog-content-container thm-cont-g0-bgcolor-1'])[2]//div//div//div[4]//div//iframe"));

            Driver.SwitchTo().Frame(iframe);

            WaitMethods.WaitForElementToAppear(By.XPath(IShouldGetPOWERPACKINGMODULEERROROutboundXpath), 10);

            return this;
        }

        public BCOutboundPage1 SwitchToPOWRFLogPickingErrorFrame()
        {
            WaitMethods.WaitForPageToBeReady();

            WaitMethods.WaitForElementToBePresent(By.XPath(SwitchToPOWRFLogPickingErrorFramesXpath));

            Driver.SwitchTo().Frame(SwitchToPOWRFLogPickingErrorFrames);

            WaitMethods.WaitForPageToBeReady();

            return this;
        }

        public BCOutboundPage1 IShouldGetDestinationNotificationsOutboundCancelOrderline(string DestinationNotification_OutboundOrderline)
        {

            WaitMethods.WaitForElementToBePresent(By.XPath(IShouldGetDestinationNotificationOutboundCancelOrderlineXpath));
            //Assert.Contains(DestinationNotification_OutboundOrderline, IShouldGetDestinationNotificationsOutboundCancelOrderline);
            string p0 = Driver.FindElement(By.XPath(IShouldGetDestinationNotificationOutboundCancelOrderlineXpath)).Text;
            Assert.Contains(DestinationNotification_OutboundOrderline, p0);
            return this;
        }
        public BCOutboundPage1 ClickYesPack()
        {
            Driver.SwitchTo().DefaultContent();
            WaitMethods.WaitForElementToAppear(By.XPath(MainContentFrameXPath));
            Driver.SwitchTo().Frame(MainContentFrame);

            Driver.FindElement(By.XPath("/html/body/div[1]/div[5]/form/div/div/div[3]/div/button[1]")).Click();

            return this;
        }
        public BCOutboundPage1 WriteWeight(string p0)
        {

               
            //IWebElement iframe = Driver.FindElement(By.XPath("//iframe[@title='POWERPackingModule']"));
            //Driver.SwitchTo().Frame(iframe);
            //WaitMethods.WaitForElementToAppear(By.XPath("//input[@id='ctrlWeight']"))
            //           .WaitForElementToBeClickable(By.XPath("//input[@id='ctrlWeight']"));
            //Driver.FindElement(By.XPath("//input[@id='ctrlWeight']")).Click();
            //Driver.SwitchTo().Frame(PowerPackingModuleFrame);
            WaitMethods.WaitForElementToAppear(By.XPath(WriteWeightLocationXpath), 10)
                .WaitForElementToBeClickable(By.XPath(WriteWeightLocationXpath));



            IWebElement itemATTRIBUTE = Driver.FindElement(By.XPath("//input[@id='ctrlWeight']"));
            WaitMethods.WaitForElementAttributeValue(itemATTRIBUTE, "pointer-events", "auto");

            //WriteWeightLocation.SendKeys(p0);
            //WriteWeightLocation.SendKeys(Keys.Return);


            //WaitMethods.RepeatUntil(
            //    () =>
            //    {
            WriteWeightLocation.Click();
                    WriteWeightLocation.SendKeys(p0);
                //},
                //_ => WriteWeightLocation.GetAttribute("value").Equals(p0),
                //TimeSpan.FromSeconds(2), 5
                //);

            WriteWeightLocation.SendKeys(Keys.Tab);

            Driver.SwitchTo().DefaultContent();
 
            return this;
        }

        public BCOutboundPage1 ClickYesInPacking()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(MainContentFrameXPath));
            Driver.SwitchTo().Frame(MainContentFrame);


            Actions action = new Actions(Driver);
            WaitMethods.WaitForElementToBePresent(By.XPath("//div[contains(@class, 'icon-QuestionMark')]"))
                       .WaitForElementToAppear(By.XPath("//div[contains(@class, 'icon-QuestionMark')]"))
                       .WaitForElementToBeClickable(By.XPath("//button[@type='button']/span[text()='Yes']"));
            IWebElement RPEM2 = Driver.FindElement(By.XPath("//button[@type='button']/span[text()='Yes']"));
            action
            .MoveToElement(RPEM2)
            .Perform();
            action
            .Click()
            .Build()
            .Perform();
            WaitMethods.WaitForElementToBeGone(By.XPath("//div[contains(@class, 'icon-QuestionMark')]"));
            return this;
        }

        public BCOutboundPage1 EnterHolderUnit(string p0)
        {
            //AssertMethods.WaitForElementToBePresent(_driver, _PowerPackingMeasurementsWaitingItemXpath, PropertyType.XPath);
            WaitMethods.WaitForElementToAppear(By.XPath("//input[@id='ctrlUnit']"))
                .WaitForElementToBeClickable(By.XPath("//input[@id='ctrlUnit']"));

            Driver.FindElement(By.XPath("//input[@id='ctrlUnit']")).Click();

            Driver.FindElement(By.XPath("//input[@id='ctrlUnit']")).SendKeys(p0);
            Driver.FindElement(By.XPath("//input[@id='ctrlUnit']")).SendKeys(Keys.Tab);
            return this;
        }

        public BCOutboundPage1 ChangeDimensionsOkButton()
        {

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath("//button[@id='btnOk']")).Displayed);
            Driver.FindElement(By.XPath("//button[@id='btnOk']")).Click();
            return this;

        }
        public BCOutboundPage1 ClickOutboundMainMenu()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(ClickOutboundFromMainMenuXpath)).Displayed);

            WaitMethods.RepeatUntil(
            () => ClickOutboundFromMainMenu.Click(),
            _ => Driver.FindElements(By.XPath(ClickSearchOutboundXpath)).Count > 0,
            TimeSpan.FromSeconds(2), 5
            );

            //ClickOutboundFromMainMenu.Click();

            return this;
        }

        public BCOutboundPage1 ClickOutboundMainMenuInAdeoZC()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(ClickOutboundFromMainMenuXpath)).Displayed);

            ClickOutboundFromMainMenu.Click();

            WebDriverWait waiting = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            waiting.Until(c => c.FindElement(By.XPath(ClickSearchOutboundXpath)).Displayed);

            return this;
        }

        public BCOutboundPage1 ClickInterfaceButtonMainMenu()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(ClickInterfaceFromMainMenuXpath)).Displayed);


            ClickInterfaceFromMainMenu.Click();
            return this;
        }

        public BCOutboundPage1 ClickOutboundMainMenuinBC()
        {
           

            WaitMethods.WaitForElementToAppear(By.XPath("//a[@title = 'Outbounds where Status <> Cancelled & <> Loaded.']"))
                .WaitForElementToBeClickable(By.XPath("//a[@title = 'Outbounds where Status <> Cancelled & <> Loaded.']"));
            Driver.FindElement(By.XPath("//a[@title = 'Outbounds where Status <> Cancelled & <> Loaded.']")).Click();

            return this;    
        }

        public BCOutboundPage1 IClickBatchWavesNeed()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(IClickBatchWaveNeedXpath)).Displayed);
            IClickBatchWaveNeed.Click();
            return this;
        }

        public BCOutboundPage1 IClickShowFilterPanels()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(IClickShowFilterPaneXpath)).Displayed);
            Actions action = new Actions(Driver);
            action
                .MoveToElement(IClickShowFilterPane)
                .Perform();

            action
                .Click()
                .Build()
                .Perform();


            return this;
        }

        public BCOutboundPage1 FilterForEdiMessageLogSeinding(string p0)
        {

            WaitMethods.WaitForElementToAppear(By.XPath(AddRefernceFilterXpath))
                .WaitForElementToBePresent(By.XPath(AddRefernceFilterXpath));
            AddRefernceFilter.SendKeys(p0 + Keys.Tab);
            IWebElement OutboundReference = Driver.FindElement(By.XPath("//div[@controlname= 'Reference']//input"));
           
            WaitMethods.WaitForFieldToBePopulated(OutboundReference);
            ClickonTitleEDISending.Click();


            return this;
        }

        public BCOutboundPage1 AddFilterOutboundCard()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(AddRefernceFilterXpath))
               .WaitForElementToBePresent(By.XPath(AddRefernceFilterXpath));
            AddRefernceFilter.SendKeys("*" + DataCollection.OutboundCodeFromNewOutbound + "*" + Keys.Tab);

            return this;
        }

        public BCOutboundPage1 IClickOnErrorDropdownToChange()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(IClickOnErrorDropdownToXpath)).Displayed);
            IClickOnErrorDropdownTo.Click();
            return this;
        }

        public BCOutboundPage1 IClickOnErrorsLi()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(IClickOnErrorLiXpath)).Displayed);
            IClickOnErrorLi.Click();
            return this;
        }

        public BCOutboundPage1 IClickOnNotProcessedsLi()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(IClickOnNotProcessedLiXpath)).Displayed);
            IClickOnNotProcessedLi.Click();
            return this;
        }


        public BCOutboundPage1 ClickPackingFromMainPage()
        {

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(ClickPackingFromMainMenuXpath)).Displayed);

            ClickPackingFromMainMenu.Click();
            return this;
        }

        public BCOutboundPage1 SwitchToPowerModuleFrame()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(PowerModuleFrameXPath));
            Driver.SwitchTo().Frame(PowerModuleFrame);
            return this;
        }

        public BCOutboundPage1 IClickFullScreenQueueGroup()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(FullScreenQueueGroupXpath), 10)
                .WaitForElementToBeClickable(By.XPath(FullScreenQueueGroupXpath));

            FullScreenQueueGroup.Click();
            return this;
        }

        public BCOutboundPage1 ClickFullScreenButtonInPacking()
        {
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(MainContentFrame);
            WaitMethods.WaitForElementToBePresent(By.XPath(FullScreenButtonPackingXpath));
            FullScreenButtonPacking.Click();
            return this;
        }

        internal BCOutboundPage1 VerifyIGetStatusOutboundOrder(string ExpectedStatusOutboundOrder)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(IShouldGetStatusOutboundOrderInOutboundDetailsXpath));
            //.WaitForElementToAppear(By.XPath(IShouldGetStatusOutboundOrderInOutboundDetailsXpath));

            Assert.Contains(ExpectedStatusOutboundOrder, IShouldGetStatusOutboundOrderInOutboundDetails.Text);

            return this;
        }

        public BCOutboundPage1 IScanPackTableID(string p0)
        {
            WaitMethods.WaitForPageToBeReady();

            WaitMethods.WaitForElementToAppear(By.XPath("//div[@class='ms-nav-cardform ms-nav-noCommandBar control-addin-form vertical-shrink vertical-stretch']//div//iframe"));

            IWebElement iframe = Driver.FindElement(By.XPath("//div[@class='ms-nav-cardform ms-nav-noCommandBar control-addin-form vertical-shrink vertical-stretch']//div//iframe"));
            Driver.SwitchTo().Frame(iframe);

            WaitMethods.WaitForElementToAppear(By.XPath(IDPasswordInPackingXpath));

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(IDPasswordInPackingXpath)).Displayed);

            WaitMethods.RepeatUntil(
            () =>
            {
                Driver.FindElement(By.XPath(IDPasswordInPackingXpath)).Click();
                IDPasswordInPacking.SendKeys(p0 + Keys.Enter);
            },
            _ => IDPasswordInPacking.GetAttribute("value").Equals(p0),
            TimeSpan.FromSeconds(2), 5
            );

            Driver.SwitchTo().DefaultContent();

            return this;
        }

        public BCOutboundPage1 SwitchToPowerPackingModuleFrame()
        {
            Driver.SwitchTo().ParentFrame().ToString();
            WaitMethods.WaitForElementToBePresent(By.XPath(PowerPackingModuleFrameXPath));
            Driver.SwitchTo().Frame(PowerPackingModuleFrame);
            return this;
        }

        public BCOutboundPage1 SwitchToPowerModuleErrorFrames()
        {
            Driver.SwitchTo().ParentFrame().ToString();
            WaitMethods.WaitForElementToBePresent(By.XPath(SwitchToPowerModuleErrorFrameXPath));
            Driver.SwitchTo().Frame(SwitchToPowerModuleErrorFrame);
            return this;
        }

        public BCOutboundPage1 ClickCloseBtnOutboundsBtn()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ClickCloseBtnOutboundBtnXpath));
            ClickCloseBtnOutboundBtn.Click();

            return this;
        }

        public BCOutboundPage1 WriteHolderLocation(string p0)
        {

            WaitMethods.WaitForElementToBePresent(By.XPath("//div[@class='task-dialog-content-container thm-cont-g0-bgcolor-1']//div//div[4]//div//iframe"));
            WaitMethods.WaitForElementToBeClickable(By.XPath("//div[@class='task-dialog-content-container thm-cont-g0-bgcolor-1']//div//div[4]//div//iframe"));
            IWebElement iframe = Driver.FindElement(By.XPath("//div[@class='task-dialog-content-container thm-cont-g0-bgcolor-1']//div//div[4]//div//iframe"));
            Driver.SwitchTo().Frame(iframe);

            WaitMethods.RepeatUntil(
            () =>
            {
                Driver.FindElement(By.XPath(HolderLocationIDInputXpath)).Click();
                HolderLocationIDInput.SendKeys(p0 + Keys.Enter);
            },
            _ => HolderLocationIDInput.GetAttribute("value").Equals(p0),
            TimeSpan.FromSeconds(2), 5
            );

            Driver.SwitchTo().DefaultContent();

            return this;
        }

        public BCOutboundPage1 WriteQtyOfTheItem(string p0)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath("//div[@class='single-column-group']//div//iframe"));
            IWebElement iframe = Driver.FindElement(By.XPath("//div[@class='single-column-group']//div//iframe"));
            Driver.SwitchTo().Frame(iframe);

            WaitMethods.RepeatUntil(
            () =>
            {
                QtyOfTheItemInput.SendKeys(p0 + Keys.Tab);
            },
            _ => QtyOfTheItemInput.GetAttribute("value").Equals(p0),
            TimeSpan.FromSeconds(2), 5
            );

            Driver.SwitchTo().DefaultContent();

            return this;
        }

        public BCOutboundPage1 ClickYesButtonInPacking()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath("//div[@class='single-column-group']//div//iframe"));
            IWebElement iframe = Driver.FindElement(By.XPath("//div[@class='single-column-group']//div//iframe"));
            Driver.SwitchTo().Frame(iframe);

            WaitMethods.WaitForElementToBePresent(By.XPath(YesButtonInPackingXpath));
            YesButtonInPacking.Click();

            Driver.SwitchTo().DefaultContent();

            return this;
        }

        public BCOutboundPage1 ClickErrorPickButton()
        {
            //WaitMethods.WaitForElementToAppear(By.XPath(PowerPackingModuleFrameXPath), 5);

            //Driver.SwitchTo().Frame(PowerPackingModuleFrame);

            WaitMethods.WaitForElementToAppear(By.XPath(ErrorPickButtonXpath));

            ErrorPickButton.Click();

            Driver.SwitchTo().DefaultContent();

            //Driver.SwitchTo().DefaultContent();

            return this;
        }

        public BCOutboundPage1 ClickOKButton()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(OkButtonInPackingXpath));

            OkButtonInPacking.Click();

            WaitMethods.WaitForElementToBeGone(By.XPath(OkButtonInPackingXpath));


            return this;
        }

        public BCOutboundPage1 ClickSetupFromMainPage()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(SetupFromMainPageXpath))
                .WaitForElementToBeClickable(By.XPath(SetupFromMainPageXpath));

            SetupFromMainPage.Click();


            return this;
        }

        public BCOutboundPage1 ClickLogging()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(LoggingInSetupXpath))
                .WaitForElementToBeClickable(By.XPath(LoggingInSetupXpath));

            LoggingInSetup.Click();


            return this;
        }

        public BCOutboundPage1 ClickPickingErrorLog()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(PickingErrorLogInLoggingXpath))
                .WaitForElementToBeClickable(By.XPath(PickingErrorLogInLoggingXpath));

            PickingErrorLogInLogging.Click();


            return this;
        }

        public BCOutboundPage1 DeleteThePickingLogError()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(UserPickedXpath))
                .WaitForElementToBeClickable(By.XPath(UserPickedXpath));

            UserPicked.Click();

            UserPicked.SendKeys(Keys.Tab);

            WaitMethods.WaitForElementToAppear(By.XPath(DeleteErrorLogXpath))
                .WaitForElementToBeClickable(By.XPath(DeleteErrorLogXpath));

            DeleteErrorLog.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(YesButtonOnDeletePopUpXpath), 5)
                .WaitForElementToBeClickable(By.XPath(YesButtonOnDeletePopUpXpath));

            YesButtonOnDeletePopUp.Click();

            return this;
        }

        public BCOutboundPage1 CloseThePackingPage()
        {
            Driver.Navigate().Refresh();

            Driver.SwitchTo().Alert().Accept();

            WaitMethods.WaitForElementToAppear(By.XPath(ClosePackingPageXpath));

            ClosePackingPage.Click();


            return this;
        }

        public BCOutboundPage1 SwitchToDefaultFrame()
        {
            Driver.SwitchTo().DefaultContent();
            return this;
        }

        public BCOutboundPage1 SwitchToCutOffManageIFrame()
        {
            Driver.SwitchTo().DefaultContent();
            WaitMethods.WaitForElementToBePresent(By.XPath(MainContentFrameXPath));
            Driver.SwitchTo().Frame(MainContentFrame);

            WaitMethods.WaitForElementToBePresent(By.XPath(ManageCutOffIFrameXpath));
            Driver.SwitchTo().Frame(ManageCutOffIFrame);

            return this;
        }

        public BCOutboundPage1 WriteHoldersEANSSCCGS(string p0)
        {
            IWebElement iframe = Driver.FindElement(By.XPath("//div[@class='task-dialog-content-container thm-cont-g0-bgcolor-1']//div//div[4]//div//iframe"));
            Driver.SwitchTo().Frame(iframe);

            WaitMethods.WaitForElementToAppear(By.XPath(WriteHolderEANSSCCGSXpath), 10)
            .WaitForElementToBeClickable(By.XPath(WriteHolderEANSSCCGSXpath));

         IWebElement itemATTRIBUTE = Driver.FindElement(By.XPath("//div[@class='row']/div[3]/div/div[2]/div/div/input[1]"));
            WaitMethods.WaitForElementAttributeValue(itemATTRIBUTE, "pointer-events", "auto");

            WaitMethods.RepeatUntil(
                () =>
                {

                    WriteHolderEANSSCCGS.SendKeys(p0);
                },
                _ => WriteHolderEANSSCCGS.GetAttribute("value").Equals(p0),
                TimeSpan.FromSeconds(2), 5
                );

            WriteHolderEANSSCCGS.SendKeys(Keys.Tab + Keys.Tab);
          
            return this;
        }
        public BCOutboundPage1 ExpandPackingForm()
        {


            WaitMethods.WaitForElementToAppear(By.XPath(MaximiseButtonPackingFromXpath), 10)
            .WaitForElementToBeClickable(By.XPath(MaximiseButtonPackingFromXpath));

            MaximiseButtonPackingFrom.Click();

            
            return this;

        }
        public BCOutboundPage1 WriteHoldersEANSSCCGS2(string p0)
        {
           // Driver.SwitchTo().Frame(PowerPackingModuleFrame);

            WaitMethods.WaitForElementToAppear(By.XPath(WriteHolderEANSSCCGSXpath), 10)
            .WaitForElementToBeClickable(By.XPath(WriteHolderEANSSCCGSXpath));

            IWebElement itemATTRIBUTE = Driver.FindElement(By.XPath("//div[@class='row']/div[3]/div/div[2]/div/div/input[1]"));
            WaitMethods.WaitForElementAttributeValue(itemATTRIBUTE, "pointer-events", "auto");

            WaitMethods.RepeatUntil(
                () =>
                {

                    WriteHolderEANSSCCGS.SendKeys(p0);
                },
                _ => WriteHolderEANSSCCGS.GetAttribute("value").Equals(p0),
                TimeSpan.FromSeconds(2), 5
                );

            WriteHolderEANSSCCGS.SendKeys(Keys.Tab);
            
            return this;
        }

        public BCOutboundPage1 ClosePickHolderPacking()
        {

            WaitMethods.WaitForElementToAppear(By.XPath(ClosePickHolderPackingXpath), 10)
            .WaitForElementToBeClickable(By.XPath(ClosePickHolderPackingXpath));


            Driver.FindElement(By.XPath(ClosePickHolderPackingXpath)).Click();

            return this;
        }

        public BCOutboundPage1 ClickItemDetailButton()
        {

            WaitMethods.WaitForElementToAppear(By.XPath(ClickItemDetailPackingXpath), 10)
            .WaitForElementToBeClickable(By.XPath(ClickItemDetailPackingXpath));


            ClickItemDetailPacking.Click();

            return this;
        }

        public BCOutboundPage1 ClickSelectButtonPacking()
        {

            WaitMethods.WaitForElementToAppear(By.XPath(ClickSelectButtonXpath), 10)
            .WaitForElementToBeClickable(By.XPath(ClickSelectButtonXpath));


            ClickSelectButton.Click();

            Driver.SwitchTo().DefaultContent();

            return this;
        }


        public BCOutboundPage1 WriteQty(string p0)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(WriteInQtyXpath), 5);

            WriteInQty.SendKeys(p0);
            WriteInQty.SendKeys(Keys.Tab);

            return this;
        }

        public BCOutboundPage1 IWriteItemForBarcode(string item)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(WriteItemBarcodeXpath), 5);

            WriteItemBarcode.SendKeys(item);
            WriteItemBarcode.SendKeys(Keys.Tab);

            return this;
        }

        public BCOutboundPage1 ISelectFromTheDropdown(string p0)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(DropdownTypeErrorXpath), 10)
                .WaitForElementToBeClickable(By.XPath(DropdownTypeErrorXpath));

            WaitMethods.WaitForPageToBeReady();

            SelectElement selectTypeError = new SelectElement(Driver.FindElement(By.XPath(DropdownTypeErrorXpath)));
            selectTypeError.SelectByValue(p0);

            WaitMethods.RepeatUntil(
            () =>
            {
                DropdownTypeError.Click();
                selectTypeError.SelectByValue(p0);
                DropdownTypeError.SendKeys(Keys.Tab);
            },
            _ => DropdownTypeError.GetAttribute("value").Equals(p0),
            TimeSpan.FromSeconds(2), 5
            );

            return this;
        }

        public BCOutboundPage1 IValidateTheUserPickedIsCorrect(string userPicked)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(UserPickedXpath));

            UserPicked.Click();

            Assert.Contains(UserPicked.Text, userPicked);

            return this;
        }

        public BCOutboundPage1 IValidateTheStatusOfTheBatch(string statusOfBatch)
        {
            WaitMethods.WaitForPageToBeReady()
                .WaitForElementToAppear(By.XPath(StatusOfTheBatchXpath));

            WaitMethods.ReferenceEquals((StatusOfTheBatch.Text, statusOfBatch), 10);


            Assert.Contains(StatusOfTheBatch.Text, statusOfBatch);

            return this;
        }

        public BCOutboundPage1 IVerifyHolderRetrievalIsCreated(string holderRetrieval)
        {
            WaitMethods.WaitForPageToBeReady()
                .WaitForElementToAppear(By.XPath(HolderRetrievalTypeXpath));

            WaitMethods.ReferenceEquals((HolderRetrievalType.Text, holderRetrieval), 10);


            Assert.Contains(HolderRetrievalType.Text, holderRetrieval);

            return this;
        }

        public BCOutboundPage1 IVerifyPickzoneDoesntDisappear(string pickzone)
        {
            WaitMethods.WaitForPageToBeReady()
                .WaitForElementToAppear(By.XPath(PickzoneQGXpath));

            WaitMethods.ReferenceEquals((PickzoneQG.Text, pickzone), 10);


            Assert.Contains(PickzoneQG.Text, pickzone);

            return this;
        }

        public BCOutboundPage1 IVerifyBatchNumber(string batchNumber)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ProgressBarXPath), 5)
               .WaitForElementToBeGone(By.XPath(ProgressBarXPath));

            WaitMethods.WaitForPageToBeReady()
                .WaitForElementToAppear(By.XPath(batchNumberQGXpath));

            WaitMethods.ReferenceEquals((batchNumberQG.Text, batchNumber), 10);


            Assert.Contains(batchNumberQG.Text, batchNumber);

            return this;
        }

        public BCOutboundPage1 IValidateThePriorityOfTheFBRetrievalQueue(string priority)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ProgressBarXPath), 5)
                .WaitForElementToBeGone(By.XPath(ProgressBarXPath));

            //WaitMethods.WaitForPageToBeReady()
            //    .WaitForElementToAppear(By.XPath(FBRetrievalQueueXpath));

            //FBRetrievalQueue.Click();

            //FBRetrievalQueue.SendKeys(Keys.Tab + Keys.Tab + Keys.Tab + Keys.Tab + Keys.Tab + Keys.Tab);

            WaitMethods.WaitForPageToBeReady()
                .WaitForElementToAppear(By.XPath(PriorityBatchXpath));

            WaitMethods.ReferenceEquals((PriorityBatch.Text, priority), 10);


            Assert.Contains(PriorityBatch.Text, priority);

            return this;
        }

        public BCOutboundPage1 IVerifyThatTheStatusOfTheLaunchedQueueAndQueueCreated(string status, string queue)
        {
            WaitMethods.WaitForPageToBeReady()
                .WaitForElementToAppear(By.XPath(HolderRetrievalQueueCreatedXpath));

            WaitMethods.ReferenceEquals((HolderRetrievalQueueCreated.Text, queue), 10);


            Assert.Contains(HolderRetrievalQueueCreated.Text, queue);

            WaitMethods.WaitForPageToBeReady()
                .WaitForElementToAppear(By.XPath(StatusOfTheQueueToDoneXpath));

            WaitMethods.ReferenceEquals((StatusOfTheQueueToDone.Text, status), 10);


            Assert.Contains(StatusOfTheQueueToDone.Text, status);

            return this;
        }

        public BCOutboundPage1 WriteHoldersEANSSCCGSSecondtime(string p0)
        {
            //Driver.SwitchTo().Frame(PowerPackingModuleFrame);
            WaitMethods.WaitForElementToAppear(By.XPath(WriteHolderEANSSCCGSXpath), 10)
          .WaitForElementToBeClickable(By.XPath(WriteHolderEANSSCCGSXpath));
            //IWebElement iframe = Driver.FindElement(By.XPath("//iframe[@title='POWERPackingModule']"));
            //Driver.SwitchTo().Frame(iframe);
            //Driver.FindElement(By.XPath("//div[@class='row']/div[3]/div/div[2]/div/div/input[1]")).Click();

            WriteHolderEANSSCCGS.SendKeys(p0);
            WriteHolderEANSSCCGS.SendKeys(Keys.Tab);

            Driver.SwitchTo().DefaultContent();
            return this;
        }

        public BCOutboundPage1 SearchLocationAndSearchOutbound()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ClickSearchOutboundXpath));
            ClickSearchOutbound.Click();

            InsertDefaultLocation.SendKeys(DataCollection.OutboundCodeFromNewOutbound);

            return this;
        }

        public BCOutboundPage1 SearchOutboundCard(string p0)
        {
            WaitMethods.WaitUntilElementExists(By.XPath("//div[contains(@class,'search-box-container')]"));
            WaitMethods.WaitForElementToAppear(By.XPath("//div[contains(@class,'search-box-container')]"), 5)
                .WaitForElementToBeClickable(By.XPath("//div[contains(@class,'search-box-container')]"));
            Driver.FindElement(By.XPath("//div[contains(@class,'search-box-container')]")).Click();


            //WaitMethods.WaitForElementToBePresent(By.XPath(ClickSearchOutboundXpath));
            //ClickSearchOutbound.Click();
            //WaitMethods.WaitForElementToBePresent(By.XPath(InsertDefaultLocationXpath));
            InsertDefaultLocation.SendKeys(p0);
            InsertDefaultLocation.SendKeys(Keys.Tab);

            return this;
        }

        public BCOutboundPage1 ClickButtonCloseOutbound()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ButtonCloseOutboundXpath));
            ButtonCloseOutbound.Click();

            return this;
        }

        public BCOutboundPage1 ClickButtonSplitBox()
        {
            Driver.SwitchTo().Frame(PowerPackingModuleFrame);
            WaitMethods.WaitForElementToBePresent(By.XPath(ButtonSplitBoxXpath));
            ButtonSplitBox.Click();

            return this;
        }

        public BCOutboundPage1 SwitchFramePowerPackingModule()
        {
            WaitMethods.WaitForPageToBeReady();

            Driver.SwitchTo().Frame(PowerPackingModuleFrame);
            WaitMethods.WaitForPageToBeReady();

            return this;
        }

        public BCOutboundPage1 SwitchFramePowerPackingModuleTempPacking()
        {
            WaitMethods.WaitForPageToBeReady();

            Driver.SwitchTo().Frame(PowerPackingModuleTempSelectFrame);
            WaitMethods.WaitForPageToBeReady();

            return this;
        }

        public BCOutboundPage1 ClickOKButtonSplitHolderOutbound()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(OKButtonSplitHolderOutboundXpath));
            OKButtonSplitHolderOutbound.Click();

            return this;
        }

        public BCOutboundPage1 ClickButtonCancelOutbound()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ButtonCancelOutboundXpath));
            ButtonCancelOutbound.Click();

            return this;
        }
        public BCOutboundPage1 SavePickHolderFromCreatedOutbound()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(OutboundLineCodeXpath));
            PickHoldersTab.Click();

            DataCollection.CopiedRFPickHolderCode = Driver.FindElement(By.XPath("//div[6]//div[2]//div[1]//div[1]//div[2]//div[1]//div[1]//div[1]//div[2]//table[1]//tbody[1]//tr[1]//td[7]")).Text;

            return this;
        }

        public BCOutboundPage1 ClickPackingFromActions()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(PackingFromActionsXpath));
            PackingFromActions.Click();

            return this;
        }

        public BCOutboundPage1 ScanPacktableId(string PacktableId)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(PacktableIdInputXpath));

            PacktableIdInput.SendKeys(PacktableId);

            return this;
        }

        public BCOutboundPage1 ScanSavedPickHolderFromOutboundOnHolderLocation()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(HolderLocationInputXpath));
            HolderLocationInput.Click();

            HolderLocationInput.SendKeys(DataCollection.CopiedRFPickHolderCode + Keys.Enter);

            return this;
        }

        public BCOutboundPage1 ClickNewInOutbounds()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ClickNewInOutboundXpath))
                        .WaitForElementToAppear(By.XPath(ClickNewInOutboundXpath), 10)
                         .WaitForElementToBeClickable(By.XPath(ClickNewInOutboundXpath));

            WaitMethods.RepeatUntil(
            () => ClickNewInOutbound.Click(),
            _ => Driver.FindElements(By.XPath(OutboundCodeFieldXpath)).Count > 0,
            TimeSpan.FromSeconds(2), 5
            );

            //ClickNewInOutbound.Click();

            return this;

        }

        public BCOutboundPage1 ClickShowMoreInOutbound()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ShowMoreInOutboundXpath))
                        .WaitForElementToAppear(By.XPath(ShowMoreInOutboundXpath))
                         .WaitForElementToBeClickable(By.XPath(ShowMoreInOutboundXpath));

            ShowMoreInOutbound.Click();
            return this;

        }

        public BCOutboundPage1 EnterCarrierBooked(string CarrierBooked)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(InsertCarrierBookedTROXpath));
            InsertCarrierBookedTRO.SendKeys(CarrierBooked);
            InsertCarrierBookedTRO.SendKeys(Keys.Tab);

            return this;
        }

        public BCOutboundPage1 EnterTypeOutbound(string p0)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(EnterTypeOutboundTROXpath));
            EnterTypeOutboundTRO.SendKeys(p0);
            EnterTypeOutboundTRO.SendKeys(Keys.Tab);

            return this;
        }

        public BCOutboundPage1 IEnterTrailerPlateNo(string trailerPlateNo)
        {
            DataCollection.UniqueTrailerNoTRO = DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString();
            WaitMethods.WaitForElementToBePresent(By.XPath(EnterTrailerPlateNoXpath));

            EnterTrailerPlateNo.Click();
            EnterTrailerPlateNo.SendKeys(DataCollection.UniqueTrailerNoTRO);

            return this;
        }

        public BCOutboundPage1 EnterTypeCode(string TypeCode)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(InsertTypeCodeTROXpath));
            InsertTypeCodeTRO.Clear();
            InsertTypeCodeTRO.SendKeys(TypeCode);
            InsertTypeCodeTRO.SendKeys(Keys.Tab);

            return this;
        }
        public BCOutboundPage1 EnterTypeCodeOutbound(string TypeCode)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(InsertTypeCodeOutboundTROXpath));
            InsertTypeCodeOutboundTRO.SendKeys(TypeCode);
            InsertTypeCodeOutboundTRO.SendKeys(Keys.Tab);

            return this;
        }
        public BCOutboundPage1 EnterExpectedArrivalTRO()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(EnterDateExpectedArrivalXpath));
            EnterDateExpectedArrival.Click();
            EnterDateExpectedArrival.SendKeys("t");
            EnterDateExpectedArrival.SendKeys(Keys.Tab);
            EnterTimeExpectedArrival.SendKeys("t");

            return this;
        }

        public BCOutboundPage1 EnterExpectedDeliveryTRO()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(EnterDateExpectedDeliveryXpath));
            EnterDateExpectedDelivery.Click();
            EnterDateExpectedDelivery.SendKeys("t");
            EnterDateExpectedDelivery.SendKeys(Keys.Tab);
            EnterTimeExpectedDelivery.SendKeys("t");
            EnterTimeExpectedDelivery.SendKeys(Keys.Tab);

            return this;
        }

        public BCOutboundPage1 ClickMoreOptionsTRO()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(MoreOptionsTabTROXpath), 10);
            WaitMethods.WaitForElementToBeClickable(By.XPath(MoreOptionsTabTROXpath));
            WaitMethods.WaitForElementToBePresent(By.XPath(MoreOptionsTabTROXpath));

            MoreOptionsTabTRO.Click();

            return this;
        }

        public BCOutboundPage1 ClickMoreOptionsTROMain()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(MoreOptionsTROMainTabXpath));
            MoreOptionsTROMainTab.Click();

            return this;
        }

        public BCOutboundPage1 ClickMoreOptionsBasicTRO()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(MoreOptionsBasicTROXpath));

            MoreOptionsBasicTRO.Click();
            return this;
        }

        public BCOutboundPage1 ClosePalletPoolTROs()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ClosePalletPoolTROXpath));

            ClosePalletPoolTRO.Click();
            return this;
        }

        public BCOutboundPage1 ClickKPITROTransport()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(KPITROTransportXpath));

            KPITROTransport.Click();
            return this;
        }

        public BCOutboundPage1 ClickMoreOptionsTROQueueGroup()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(MoreOptionsTROQueueGroupXpath));

            MoreOptionsTROQueueGroup.Click();
            return this;
        }

        public BCOutboundPage1 EnterTransportSentTimeTROs()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(EnterTransportSentTimeTROXpath));

            EnterTransportSentTimeTRO.Click();

            EnterTransportSentTimeTRO.SendKeys("t");

            EnterTransportSentTimeTRO.SendKeys(Keys.Tab + "t");
            return this;
        }

        public BCOutboundPage1 IEnterConfirmedTimeTRO()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(EnterConfirmedTimeTROXpath));

            EnterConfirmedTimeTRO.Click();

            EnterConfirmedTimeTRO.SendKeys("t");

            EnterConfirmedTimeTRO.SendKeys(Keys.Tab + "t");
            return this;
        }

        public BCOutboundPage1 EnterExpectedArrivedDateTRO()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(EnterExpectedArrivedDateXpath));
            EnterExpectedArrivedDate.Click();
            EnterExpectedArrivedDate.SendKeys("t");
            EnterExpectedArrivedDate.SendKeys(Keys.Tab + "t");

            return this;
        }

        public BCOutboundPage1 EnterStartLoadingDateTimeTROs()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(EnterStartLoadingDateTimeTROXpath));
            EnterStartLoadingDateTimeTRO.Click();
            EnterStartLoadingDateTimeTRO.SendKeys("t");
            EnterStartLoadingDateTimeTRO.SendKeys(Keys.Tab + "t");

            return this;
        }

        public BCOutboundPage1 EnterEndLoadingDateTimeTROs()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(EnterEndLoadingDateTimeTROXpath));
            EnterEndLoadingDateTimeTRO.Click();
            EnterEndLoadingDateTimeTRO.SendKeys("t");
            EnterEndLoadingDateTimeTRO.SendKeys(Keys.Tab + "t");

            return this;
        }

        public BCOutboundPage1 ClickCloseBtnOutboundsBtnTwoTImes()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickCloseBtnOutboundBtnXpath))
                .WaitForElementToBePresent(By.XPath(ClickCloseBtnOutboundBtnXpath));

            WaitMethods.WaitForElementToAppear(By.XPath("(//div[contains(text(),'POWER Packing Module')])"));
            Driver.FindElements(By.XPath(ClickCloseBtnOutboundBtnXpath)).Last().Click();

            WaitMethods.WaitForElementToBeGone(By.XPath("(//div[contains(text(),'POWER Packing Module')])"));
            Driver.FindElements(By.XPath(ClickCloseBtnOutboundBtnXpath)).Last().Click();


            WaitMethods.WaitForElementToBeGone(By.XPath("(//div[contains(text(),'POWER Packing Module')])"), 10);


            WaitMethods.WaitForPageToBeReady();


            return this;
        }

        public BCOutboundPage1 WritePackingLocation(string p0)
        {
            WaitMethods.WaitForElementToAppear(By.XPath("//div[contains(text(),'POWER Packing Location')]"));



            return this;
        }

        public BCOutboundPage1 ClickCloseButtonOncePacking()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickCloseBtnOutboundBtnXpath))
                .WaitForElementToBePresent(By.XPath(ClickCloseBtnOutboundBtnXpath));

            WaitMethods.WaitForElementToAppear(By.XPath("(//div[contains(text(),'POWER Packing Module')])"));
            Driver.FindElements(By.XPath(ClickCloseBtnOutboundBtnXpath)).Last().Click();


            WaitMethods.WaitForElementToBeGone(By.XPath("(//div[contains(text(),'POWER Packing Module')])"), 10);


            WaitMethods.WaitForPageToBeReady();


            return this;
        }
        public BCOutboundPage1 ClickClosePackingModule()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("/html/body/div[1]/div[4]/form/div[2]/div/div[4]/button[1]"));


            Driver.FindElement(By.XPath("/html/body/div[1]/div[4]/form/div[2]/div/div[4]/button[1]")).Click();

            
            return this;
        }

        public BCOutboundPage1 VerifyControlQualityScan(int p0)
        {
            Driver.SwitchTo().Frame(PowerPackingModuleFrame);
            WaitMethods.WaitForElementToAppear(By.Id("ctrlQtyScans"));
            string actualValue = Driver.FindElement(By.Id("ctrlQtyScans")).GetAttribute("value");

            WaitMethods.RepeatUntil(
            () => actualValue = Driver.FindElement(By.Id("ctrlQtyScans")).GetAttribute("value"),
            _ => Driver.FindElement(By.Id("ctrlQtyScans")).GetAttribute("value").Equals(p0.ToString()),
            TimeSpan.FromSeconds(2), 5
            );

            Assert.Equal(p0.ToString(), actualValue);

            return this;
        }

        //TODO Use method for scrolling for an element in a table, some locators may need to be changed
        public void SearchForCODEAndUpdateSecondFieldVALUETEXTToWithoutRandomNumberInEDIMessageTable(string p0, string p1)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int row = 1;

            while (Driver.FindElements(By.XPath($"//span[contains(text(),'{p0}')]")).Count == 0 && stopwatch.Elapsed.TotalSeconds < 60)
            {
                Driver.FindElement(By.XPath($"//tr[@aria-rowindex={row} and @aria-selected='false' and not(@tabstopsuspended)]//td[5]")).Click();
                Driver.FindElement(By.XPath($"//tr[@aria-rowindex={row} and @aria-selected='true' and not(@tabstopsuspended)]//td[5]/input")).SendKeys(Keys.PageDown);
                row += 5;
            }

            WaitMethods.WaitForElementToBePresent(By.XPath($"//span[contains(text(),'{p0}')]"));
            Actions action = new Actions(Driver);
            IWebElement codeField = Driver.FindElement(By.XPath($"//span[contains(text(),'{p0}')]"));
            action.MoveToElement(codeField).Perform();
            action.Click().SendKeys(Keys.Return + Keys.Return + Keys.Return);
            action.KeyDown(Keys.Shift);
            action.SendKeys(Keys.Tab);
            action.KeyUp(Keys.Shift);
            action.SendKeys(p1).Build().Perform();

            WaitMethods.WaitForElementToAppear(By.XPath(ClickOnMessageCodeEDIXpath))
                .WaitForElementToBeClickable(By.XPath(ClickOnMessageCodeEDIXpath));
            ClickOnMessageCodeEDI.Click();
        }

        public BCOutboundPage1 PressEscFormKeyboardOnBC()
        {
            IWebElement iframe = Driver.FindElement(By.XPath("//div[@class='task-dialog-content-container thm-cont-g0-bgcolor-1']//div//div[4]//div//iframe"));
            Driver.SwitchTo().Frame(iframe);
            Driver.FindElement(By.XPath("//div[@class='row']/div[3]/div/div[2]/div/div/input[1]"));
            WriteHolderEANSSCCGS.SendKeys(Keys.Escape);
            Driver.SwitchTo().DefaultContent();

            return this;
        }

        public BCOutboundPage1 PressBackspaceOnKeyboardOnBC()
        {
            IWebElement iframe = Driver.FindElement(By.XPath("//div[@class='task-dialog-content-container thm-cont-g0-bgcolor-1']//div//div[4]//div//iframe"));
            Driver.SwitchTo().Frame(iframe);

            HolderLocationIDInput.SendKeys(Keys.Backspace);

            Driver.SwitchTo().DefaultContent();

            return this;
        }

        public BCOutboundPage1 ValidateThePicture_PackingPage()
        {
            IWebElement iframe = Driver.FindElement(By.XPath("//div[@class='task-dialog-content ms-nav-scrollable']//div//div[4]//div//iframe"));
            Driver.SwitchTo().Frame(iframe);
            bool ImagePresent = Driver.FindElement(By.XPath("//img[@id='imgPicture']")).Displayed;
            Assert.True(ImagePresent);
            Driver.SwitchTo().DefaultContent();


            return this;
        }

        public BCOutboundPage1 ValidateWhenGSBarcodeIsScanned(string p0)
        {
            IWebElement iframe = Driver.FindElement(By.XPath("//div[@class='task-dialog-content-container thm-cont-g0-bgcolor-1']//div//div[4]//div//iframe"));
            Driver.SwitchTo().Frame(iframe);
            Driver.FindElement(By.XPath(ScannedGSBarcodeXpath));

            Assert.Contains(ScannedGSBarcode.Text, p0);


            //WaitMethods.WaitForElementToBePresent(By.XPath());
            //WaitMethods.WaitForElementToAppear(By.XPath());


            Driver.SwitchTo().DefaultContent();


            return this;
        }

        public BCOutboundPage1 ClickBackButtonGenerals()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ProgressBarXPath), 3)
                .WaitForElementToBeGone(By.XPath(ProgressBarXPath))
                .WaitForElementToAppear(By.XPath("//button[@data-is-focusable='true'][@title='Back']"))
                .WaitForElementToBeClickable(By.XPath("//button[@data-is-focusable='true'][@title='Back']"));

            Driver.FindElement(By.XPath("//button[@data-is-focusable='true'][@title='Back']")).Click();
            WaitMethods.WaitForElementToBeGone(By.XPath("//button[@data-is-focusable='true'][@title='Back']"), 4);

            return this;
        }

        public BCOutboundPage1 ClickTRIMainPage()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("//a[contains(@title,'Transport Inbounds')]"))
                .WaitForElementToBeClickable(By.XPath("//a[contains(@title,'Transport Inbounds')]"));
            Driver.FindElement(By.XPath("//a[contains(@title,'Transport Inbounds')]")).Click();

            return this;
        }

        public BCOutboundPage1 ClickYesInThePopUpMessages()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickYesInThePopUpMessageXpath))
                .WaitForElementToBePresent(By.XPath(ClickYesInThePopUpMessageXpath));

            if (SetMethods.IsElementPresent(Driver, By.XPath(ClickYesInThePopUpMessageXpath)))
            {
                WaitMethods.WaitForElementToBeClickable(By.XPath(ClickYesInThePopUpMessageXpath));
                ClickYesInThePopUpMessage.Click();
            }
            WaitMethods.WaitForElementToBeGone(By.XPath(ClickYesInThePopUpMessageXpath));
            return this;
        }

        public BCOutboundPage1 WaitandValidateDatePPLCON()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(TIMENOWXpath));
            Assert.Equal(TIMENOW.Text, DateTime.Now.ToString("d/MM/yyyy"));
            return this;
        }

        public BCOutboundPage1 WaitandValidateDatePPLCONLOAD()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(TIMENOWXpath));
            Assert.Equal(TIMENOW.Text, DateTime.Now.ToString("d/MM/yyyy"));
            return this;
        }
        public BCOutboundPage1 CopyFileLocationPathOfLatestEDIMESSAGELOGSEND()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(LocationPathOfLatestEDIMESSAGELOGSENDXpath))
                .WaitForElementToBePresent(By.XPath(LocationPathOfLatestEDIMESSAGELOGSENDXpath));
            DataCollection.LocationPathOfLatestEDIMESSAGELOGSEND = LocationPathOfLatestEDIMESSAGELOGSEND.Text;
            DataCollection.filename1 = DataCollection.LocationPathOfLatestEDIMESSAGELOGSEND;

            return this;
        }
        public BCOutboundPage1 VerifyValueOneAndValueTwoExitsInFileLocation(string value1, string value2)
        {
            string path = DataCollection.filename1.Substring(0,76);
            string text = File.ReadAllText(path, Encoding.UTF8);
            Assert.Contains(value1, text);
            Assert.Contains(value2, text);
            return this;
        }
        public string CopyPPLCONPath()
        {
            DataCollection.PPLCONFilePath = Driver.FindElement(By.XPath("(//td[contains(@controlname,'File location')]//span)[1]")).Text;
            Console.WriteLine(DataCollection.PPLCONFilePath);
            return DataCollection.PPLCONFilePath;

        }

        public BCOutboundPage1 CheckIfPacked()
        {
            string path = DataCollection.PPLCONFilePath;
            Console.WriteLine(DataCollection.PPLCONFilePath);
            string text = File.ReadAllText(path, Encoding.UTF8);
            string Validate1 = "008";
            string Validate2 = "PACPCS";
            Assert.Contains(Validate1, text);
            Assert.Contains(Validate2, text);
            return this;
        }
        public BCOutboundPage1 CheckItemAndQTYPack()
        {
            string path = DataCollection.PPLCONFilePath;
            Console.WriteLine(DataCollection.PPLCONFilePath);
            string text = File.ReadAllText(path, Encoding.UTF8);
            string Validate1 = "0099";
            string Validate2 = "QTYTMC000000000000001";
            Assert.Contains(Validate1, text);
            Assert.Contains(Validate2, text);

            return this;
        }
        public BCOutboundPage1 ValidateItemandQTY()
        {
            string path = DataCollection.PPLCONFilePath;
            path = path.Replace("S-BE-KI-ABRAIN2", ConfigurationManager.AppSettings.Get("Path"));
            //throw new InvalidOperationException(path);
            //if (path.Length == 0 || path == null) throw new InvalidOperationException("Empty file path");
            Console.WriteLine(DataCollection.PPLCONFilePath);
            string text1 = File.ReadAllText(path, Encoding.UTF8);

            //  \\S-BE-KI-ABRAIN2\EDIFILES_TEST\SKATEPRO\OUT\PPLCON\2022-02\PPLCON0000484207.
            //  \\S-BE-KI-ABRAIN2.ktn.group\EDIFILES_TEST\SKATEPRO\OUT\PPLCON\**************


            string Validate1 = "LIN1                             008";
            string Validate2 = "QTYTMC000000000000002 ";
            Assert.Contains(Validate1, text1);
            Assert.Contains(Validate2, text1);

            return this;
        }

        public BCOutboundPage1 CheckItemAndCanceledQTYminus1()
        {
            string path = DataCollection.PPLCONFilePath;
            Console.WriteLine(DataCollection.PPLCONFilePath);
            string text1 = File.ReadAllText(path, Encoding.UTF8);
            string Validate1 = "008";
            string Validate2 = "QTYTMC000000000000003";
            Assert.Contains(Validate1, text1);
            Assert.Contains(Validate2, text1);

            return this;
        }

        public BCOutboundPage1 CheckPakConMessage()
        {
            string path = DataCollection.PPLCONFilePath;
            Console.WriteLine(DataCollection.PPLCONFilePath);
            string text1 = File.ReadAllText(path, Encoding.UTF8);
            string Validate1 = "PAKCON";
            string Validate2 = "000014LIN1";
            Assert.Contains(Validate1, text1);
            Assert.Contains(Validate2, text1);

            return this;

        }


        public BCOutboundPage1 CheckIncorretFormatMessage()
        {
            string path = DataCollection.PPLCONFilePath;
            Console.WriteLine(DataCollection.PPLCONFilePath);
            string text1 = File.ReadAllText(path, Encoding.UTF8);
            string Validate1 = "PPLCON";
            string Validate2 = "�����";
            Assert.Contains(Validate1, text1);
            Assert.Contains(Validate2, text1);




            return this;
        }
        public BCOutboundPage1 CheckItemAndQTY()
        {
            string path = DataCollection.PPLCONFilePath;
            Console.WriteLine(DataCollection.PPLCONFilePath);
            string text1 = File.ReadAllText(path, Encoding.UTF8);
            string Validate1 = "LIN1                             008";
            string Validate2 = "QTYTMC000000000000002";
            Assert.Contains(Validate1, text1);
            Assert.Contains(Validate2, text1);

            return this;
        }
        public BCOutboundPage1 VerifyThatOrderIsDeleted()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(OrderNoInOutboundXpath))
            .WaitForPageToBeReady();

            Assert.Contains(OrderNoInOutbound.Text, "0");

            return this;
        }
        public BCOutboundPage1 INavigateToTablePageOfPOWERQueueDetail()
        {
            WaitMethods.WaitForPageToBeReady();

            Driver.Navigate().GoToUrl("https://power-baseline.emea.tst.itglo.net/CGI/?tenant=baseline&company=BASELINE&dc=0&table=73250");

            WaitMethods.WaitForPageToBeReady();

            WaitMethods.WaitForElementToAppear(By.XPath(FilterInPOWERQueueDetailTableXpath), 10);

            return this;
        }
        public BCOutboundPage1 ClickSetupInMainMenu()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(SetupXpath))
                    .WaitForElementToBeClickable(By.XPath(SetupXpath));

            Setup.Click();
            return this;
        }
        public BCOutboundPage1 DeleteFilesFromFolder()
        {

            System.IO.DirectoryInfo di = new DirectoryInfo("\\\\Itglo.net\\public\\EMEA\\BE-KI\\Temp\\BaselineTwo\\");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
            return this;
        }

        public BCOutboundPage1 DeleteFilesFromFolder4Ward()
        {
            System.IO.DirectoryInfo di = new DirectoryInfo("\\\\itglo.net\\public\\EMEA\\BE-KI\\Temp\\Logging\\4WARD");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
            return this;
        }

        public BCOutboundPage1 DeleteFilesFromFolderBaselinethree()
        {
            System.IO.DirectoryInfo di = new DirectoryInfo("\\\\Itglo.net\\public\\EMEA\\BE-KI\\Temp\\STYRA\\Baselinethree\\");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
            return this;
        }

        public BCOutboundPage1 DeleteFilesFromFolderNilfisk()
        {
            System.IO.DirectoryInfo di = new DirectoryInfo("\\\\itglo.net\\public\\EMEA\\BE-KI\\Temp\\Styra\\NilfiskBE\\");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
            return this;
        }
        public BCOutboundPage1 DeleteFilesFromFolderSTST()
        {
            System.IO.DirectoryInfo di = new DirectoryInfo("\\\\itglo.net\\public\\EMEA\\BE-KI\\Temp\\Styra\\STST Automation\\");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);

               
            }
            return this;
        }

            public BCOutboundPage1 SelectGeneralInSetup()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(SetupGeneralXpath))
                
               .WaitForElementToBeClickable(By.XPath(SetupGeneralXpath));

            SetupGeneral.Click();

            return this;
        }
        public BCOutboundPage1 SelectItem()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ItemFromGeneralXpath))
                 .WaitForElementToBeClickable(By.XPath(ItemFromGeneralXpath));

            ItemFromGeneral.Click();

            return this;
        }
        public BCOutboundPage1 ClickFilterbuttonOnItemList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(FilterButtonitemListXpath))
                   .WaitForElementToBeClickable(By.XPath(FilterButtonitemListXpath));

            FilterButtonitemList.Click();

            return this;
        }
        public BCOutboundPage1 ClickAddFilterbuttonOnItemList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickFilterListByXpath))
                    .WaitForElementToBePresent(By.XPath(ClickFilterListByXpath))
                  .WaitForElementToBeClickable(By.XPath(ClickFilterListByXpath));

            ClickFilterListBy.Click();


            return this;
        }
        public BCOutboundPage1 ClickIteminFilter()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickItemFilterXpath))
                     .WaitForElementToBeClickable(By.XPath(ClickItemFilterXpath));

            ClickItemFilter.Click();


            return this;
        }

        public BCOutboundPage1 ItemFilterIteamCard(string p0)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(AddItemCodeFilterXpath))
                .WaitForElementToBePresent(By.XPath(AddItemCodeFilterXpath));

            AddItemCodeFilter.SendKeys(p0 + Keys.Tab);
            //AddRefernceFilter.SendKeys(p0 + Keys.Tab);

            return this;
        }
        public BCOutboundPage1 ItemFilter(string p0)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(AddRefernceFilterXpath))
                .WaitForElementToBePresent(By.XPath(AddRefernceFilterXpath));

            
            AddRefernceFilter.SendKeys(p0 + Keys.Tab);

            WaitMethods.WaitForElementToAppear(By.XPath($"(//span[contains(text(),'{p0}')])[1]"), 5);
            ClickonTitleEDISending.Click();



            return this;
        }

        public BCOutboundPage1 ClickOnEDITITEM()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EditInItemListXpath))
                .WaitForElementToBePresent(By.XPath(EditInItemListXpath));

            EditInItemList.Click();

            return this;
        }
        public BCOutboundPage1 ClickConfigurationofItem()
        {
            //WaitMethods.WaitForElementToAppear(By.XPath(ConfigurationXpath))
            //    .WaitForElementToBePresent(By.XPath(ConfigurationXpath));

            //Configuration.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(ConfigurationSecondXpath))
               .WaitForElementToBePresent(By.XPath(ConfigurationSecondXpath));

            ConfigurationSecond.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(ConfigurationDetailXpath))
               .WaitForElementToBePresent(By.XPath(ConfigurationDetailXpath));

            ConfigurationDetail.Click();


            return this;
        }

        public BCOutboundPage1 ClickMoreoptionsinItemConfigurationDetail()
        {
            
            WaitMethods.WaitForElementToAppear(By.XPath("//div[text() = 'Edit - 73313 POWER Item Config Main - BASELINETWO ∙ EDSNOUTBOUND ∙ CONFIG1']"))
               .WaitForElementToBePresent(By.XPath("//div[text() = 'Edit - 73313 POWER Item Config Main - BASELINETWO ∙ EDSNOUTBOUND ∙ CONFIG1']"));

            WaitMethods.WaitForElementToAppear(By.XPath(ClickOnMoreOptionsConfigurationXpath))
               .WaitForElementToBePresent(By.XPath(ClickOnMoreOptionsConfigurationXpath));

            ClickOnMoreOptionsConfiguration.Click();


            WaitMethods.WaitForElementToAppear(By.XPath(DetailItemConfigDetailXpath))
               .WaitForElementToBePresent(By.XPath(DetailItemConfigDetailXpath));

            DetailItemConfigDetail.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(BarcodeRelatedQuantitiesXpath))
               .WaitForElementToBePresent(By.XPath(BarcodeRelatedQuantitiesXpath));

            BarcodeRelatedQuantities.Click();

            

            return this;
        }

        public BCOutboundPage1 AddBarcodeConfigDet()
        {

            WaitMethods.WaitForElementToAppear(By.XPath(barcodeConfigDetailXpath))
               .WaitForElementToBePresent(By.XPath(barcodeConfigDetailXpath));
            //barcodeConfigDetail.SendKeys("Test1" + Keys.Tab);



            string value = Driver.FindElement(By.XPath(barcodeConfigDetailXpath)).GetAttribute("value");
            if (value == "TEST1")
            {


                IWebElement codeField = Driver.FindElement(By.XPath(barcodeConfigDetailXpath));

                WaitMethods.RepeatUntil(
                () =>
                {

                    codeField.Click();
                    codeField.Clear();
                    codeField.SendKeys("TEST2" + Keys.Tab);
                    DataCollection.XMLValue2 = "<ext:Barcode>TEST2</ext:Barcode>";
                    ClickYesInThePopUpMessages();
                },
                _ => codeField.GetAttribute("value").Equals("TEST2"),
                TimeSpan.FromSeconds(2), 5
                );

            }
            else
            {
                IWebElement codeField = Driver.FindElement(By.XPath(barcodeConfigDetailXpath));

                WaitMethods.RepeatUntil(
                () =>
                {

                    codeField.Click();
                    codeField.Clear();
                    codeField.SendKeys("TEST1" + Keys.Tab);
                    DataCollection.XMLValue2 = "<ext:Barcode>TEST1</ext:Barcode>";
                    ClickYesInThePopUpMessages();
                },
                _ => codeField.GetAttribute("value").Equals("TEST1"),
                TimeSpan.FromSeconds(2), 5
                );

            }

            return this;
        }

        public BCOutboundPage1 ClickCloseOnItemConfigDetail()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("//div[text() = 'Edit - 73326 POWER Item Config Det Main - BASELINETWO ∙ EDSNOUTBOUND ∙ CONFIG1 ∙ SKU']"))
             .WaitForElementToBePresent(By.XPath("//div[text() = 'Edit - 73326 POWER Item Config Det Main - BASELINETWO ∙ EDSNOUTBOUND ∙ CONFIG1 ∙ SKU']"));


            Driver.FindElement(By.XPath("//span[text()='Close']")).SendKeys(Keys.Escape + Keys.Escape);
            

            

            return this;
        }

        public BCOutboundPage1 ClickManipulationOnItemCard()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickManipulationInItemCardXpath))
                .WaitForElementToBePresent(By.XPath(ClickManipulationInItemCardXpath));

            ClickManipulationInItemCard.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(ClickShowMoreinManipulationItemCardXpath))
                .WaitForElementToBePresent(By.XPath(ClickShowMoreinManipulationItemCardXpath));

            ClickShowMoreinManipulationItemCard.Click();

            return this;
        }

        public BCOutboundPage1 CheckValueofMeasurmentAndRepleaceit()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("/html/body/div[1]/div[4]/form/main/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[9]/div[2]/div/div/div[3]/div[2]/div[1]/div/input"))
                .WaitForElementToBePresent(By.XPath("/html/body/div[1]/div[4]/form/main/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[9]/div[2]/div/div/div[3]/div[2]/div[1]/div/input"));

            string value = Driver.FindElement(By.XPath("/html/body/div[1]/div[4]/form/main/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[9]/div[2]/div/div/div[3]/div[2]/div[1]/div/input")).GetAttribute("value");
            if (value == "1,00")
            {


                IWebElement codeField = Driver.FindElement(By.XPath(CheckWidthInItemCardXpath));

                WaitMethods.RepeatUntil(
                () =>
                {

                    codeField.Click();
                    codeField.Clear();
                    codeField.SendKeys("2,00" + Keys.Tab);
                    DataCollection.XMLValue = "<ext:Width>2</ext:Width>";
                },
                _ => codeField.GetAttribute("value").Equals("2,00"),
                TimeSpan.FromSeconds(2), 5
                );

            }
            else
            {
                IWebElement codeField = Driver.FindElement(By.XPath(CheckWidthInItemCardXpath));

                WaitMethods.RepeatUntil(
                () =>
                {

                    codeField.Click();
                    codeField.Clear();
                    codeField.SendKeys("1,00" + Keys.Tab);
                    DataCollection.XMLValue = "<ext:Width>1</ext:Width>";
                },
                _ => codeField.GetAttribute("value").Equals("1,00"),
                TimeSpan.FromSeconds(2), 5
                );

            }

            return this;
        }

        public BCOutboundPage1 CheckValueofItemGroupAndRepleaceit()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("//div[@controlname = 'Item Group']//div//input"))
                .WaitForElementToBePresent(By.XPath("//div[@controlname = 'Item Group']//div//input"));

            string value = Driver.FindElement(By.XPath("//div[@controlname = 'Item Group']//div//input")).GetAttribute("value");
            if (value == "SCOOTERS")
            {
                IWebElement codeField = Driver.FindElement(By.XPath(CheckItemGroupXpath));

                WaitMethods.RepeatUntil(
                () =>
                {

                    codeField.Click();
                    codeField.Clear();
                    codeField.SendKeys("TESTSANI" + Keys.Tab);
                    codeField.SendKeys(Keys.Return);
                    DataCollection.XMLValue = "<ext:ItemGroup>TESTSANI</ext:ItemGroup>";
                },
                _ => codeField.GetAttribute("value").Equals("TESTSANI"),
                TimeSpan.FromSeconds(2), 5
                );


            }
            else
            {
                IWebElement codeField = Driver.FindElement(By.XPath(CheckItemGroupXpath));

                WaitMethods.RepeatUntil(
                () =>
                {

                    codeField.Click();
                    codeField.Clear();
                    codeField.SendKeys("SCOOTERS" + Keys.Tab);
                    DataCollection.XMLValue = "<ext:ItemGroup>SCOOTERS</ext:ItemGroup>";
                },
                _ => codeField.GetAttribute("value").Equals("SCOOTERS"),
                TimeSpan.FromSeconds(2), 5
                );

            }

            return this;
        }


            public BCOutboundPage1 ClickOKonItemCard()
        {
            Actions action = new Actions(Driver);

            WaitMethods.WaitForElementToBePresent(By.XPath("//div[contains(@class, 'icon-QuestionMark')]"))
            .WaitForElementToAppear(By.XPath("//div[contains(@class, 'icon-QuestionMark')]"))
            .WaitForElementToBeClickable(By.XPath("//button[@type='button']/span[text()='Yes']"));
            IWebElement RPEM2 = Driver.FindElement(By.XPath("//button[@type='button']/span[text()='Yes']"));
            action
            .MoveToElement(RPEM2)
            .Perform();
            action
            .Click()
            .Build()
            .Perform();
            WaitMethods.WaitForElementToBeGone(By.XPath("//div[contains(@class, 'icon-QuestionMark')]"));


            return this;
        }
        public BCOutboundPage1 ReadMessagefromWCSTempFolder()
        {
            System.Threading.Thread.Sleep(3000);
            string[] array2 = Directory.GetFiles(@"\\itglo.net\public\EMEA\BE-KI\Temp\BaselineTwo\", "*Request.XML");
            string finalName = string.Empty;
            foreach (string name in array2)
            {

                finalName += name;

            }


            Debug.WriteLine("--- xml files Files: ---");
            string text = File.ReadAllText(finalName);
            Debug.WriteLine(text);


            Assert.Contains(DataCollection.XMLValue, text);
            return this;
        }
        public BCOutboundPage1 ReadMessageandValidatefromWCSTempFolder()
        {
            System.Threading.Thread.Sleep(3000);
            string[] array2 = Directory.GetFiles(@"\\itglo.net\public\EMEA\BE-KI\Temp\BaselineTwo\", "*Request.XML");
            string finalName = string.Empty;
            foreach (string name in array2)
            {

                finalName += name;

            }


            Debug.WriteLine("--- xml files Files: ---");
            string text = File.ReadAllText(finalName);
            Debug.WriteLine(text);


            Assert.Contains(DataCollection.XMLValue2, text);
            return this;

            
        }


        public BCOutboundPage1 ReadMessageandValidatefromWCSTempFolderKitchenAid()
        {
            System.Threading.Thread.Sleep(3000);
            string[] array2 = Directory.GetFiles(@"\\itglo.net\public\EMEA\BE-KI\Temp\Logging\4WARD", "*Request.xml");
            string finalName = string.Empty;
            foreach (string name in array2)
            {

                finalName += name;

            }


            Debug.WriteLine("--- xml files Files: ---");
            string text = File.ReadAllText(finalName);
            Debug.WriteLine(text);


            Assert.Contains(" <cms:ForwardReference>I21K10576</cms:ForwardReference>", text);
            Assert.Contains(" <cms:Application>4WARD</cms:Application>", text);
            Assert.Contains("4WARD receive - POWER IFTMIN(Insert)", text);
            

            return this;
        }

        public BCOutboundPage1 ReadMessageandValidatefromWCSTempFolderBaselinethree()
        {
            System.Threading.Thread.Sleep(3000);
            string[] array2 = Directory.GetFiles(@"\\itglo.net\public\EMEA\BE-KI\Temp\STYRA\Baselinethree\", "*Request.XML");
            string finalName = string.Empty;
            foreach (string name in array2)
            {

                finalName += name;

            }


            Debug.WriteLine("--- xml files Files: ---");
            string text = File.ReadAllText(finalName);
            Debug.WriteLine(text);


            Assert.Contains("<tem:ProcessPICKQUEUEINFO>", text);
            Assert.Contains("<tem:PICKQUEUEINFO_V004>", text);
            Assert.Contains("<ext:QueueGroupId>225261557339253831JOVANOVS</ext:QueueGroupId>", text);
            Assert.Contains("<ext:Item>TESTSANIPICKINFO</ext:Item>", text);

            return this;
        }


        public BCOutboundPage1 ReadMessageandValidatefromWCSTempFolderNilfisk()
        {
            System.Threading.Thread.Sleep(3000);
            string[] array2 = Directory.GetFiles(@"\\itglo.net\public\EMEA\BE-KI\Temp\Styra\NilfiskBE\", "*Request.XML");
            string finalName = string.Empty;
            foreach (string name in array2)
            {

                finalName += name;

            }


            Debug.WriteLine("--- xml files Files: ---");
            string text = File.ReadAllText(finalName);
            Debug.WriteLine(text);


            Assert.Contains("<tem:WCS041_V002>", text);
            Assert.Contains("<ext:QueueGroupId>OUT-855745-ORDER-PP-SE-2291514584684499040BEKTESHI</ext:QueueGroupId>", text);
            Assert.Contains("<ext:Value>TESTDESTITEM</ext:Value>", text);
            Assert.Contains("<ext:PickedItemLabel>", text);

            return this;
        }
        public BCOutboundPage1 ReadMessageandValidatefromWCSTempFolderSTST()
        {
            System.Threading.Thread.Sleep(3000);
            string[] array2 = Directory.GetFiles(@"\\itglo.net\public\EMEA\BE-KI\Temp\Styra\STST Automation\", "*Request.XML");
            string finalName = string.Empty;
            foreach (string name in array2)
            {

                finalName += name;

            }


            Debug.WriteLine("--- xml files Files: ---");
            string text = File.ReadAllText(finalName);
            Debug.WriteLine(text);

            Assert.Contains("<tem:HOLDERTRANSFER_V003>", text);
            Assert.Contains("<ext:Comment>Test comment 1 item level</ext:Comment>", text);
            Assert.Contains("<ext:Comment>Test comment 2 item level</ext:Comment>", text);
            Assert.Contains("<ext:Comment>Test comment 3 item level</ext:Comment>", text);
            Assert.Contains("<ext:ItemCode>STTU755C2311M</ext:ItemCode>", text);

            return this;
        }

        public BCOutboundPage1 ReadMessageandValidatefromWCSTempFolderBaselinethreeHolderInfomrationv004()
        {
            System.Threading.Thread.Sleep(3000);
            string[] array2 = Directory.GetFiles(@"\\itglo.net\public\EMEA\BE-KI\Temp\STYRA\Baselinethree\", "*Request.XML");
            string finalName = string.Empty;
            foreach (string name in array2)
            {

                finalName += name;

            }


            Debug.WriteLine("--- xml files Files: ---");
            string text = File.ReadAllText(finalName);
            Debug.WriteLine(text);
            Assert.Contains("<tem:ProcessPICKQUEUEINFO>", text);
            Assert.Contains("<tem:PICKQUEUEINFO_V005>", text);
            Assert.Contains("<ext:QueueGroupId>225261557339253831JOVANOVS</ext:QueueGroupId>", text);
            Assert.Contains("<ext:Item>TESTSANIPICKINFO</ext:Item>", text);


            return this;
        }


            
        
        public BCOutboundPage1 ReadMessageandValidatefromWCSTempFolderBaselinethreeV005()
        {
            System.Threading.Thread.Sleep(3000);
            string[] array2 = Directory.GetFiles(@"\\itglo.net\public\EMEA\BE-KI\Temp\STYRA\Baselinethree\", "*Request.XML");
            string finalName = string.Empty;
            foreach (string name in array2)
            {

                finalName += name;

            }


            Debug.WriteLine("--- xml files Files: ---");
            string text = File.ReadAllText(finalName);
            Debug.WriteLine(text);


            Assert.Contains("<tem:ProcessPICKQUEUEINFO>", text);
            Assert.Contains("<tem:PICKQUEUEINFO_V005>", text);
            Assert.Contains("<ext:QueueGroupId>225261557339253831JOVANOVS</ext:QueueGroupId>", text);
            Assert.Contains("<ext:Item>TESTSANIPICKINFO</ext:Item>", text);
            Assert.Contains("<ext:Priority>2205261558</ext:Priority>", text);
            Assert.Contains(" <ext:Comment>Test picking comment item level 1</ext:Comment>", text);
            Assert.Contains(" <ext:Comment>Test picking comment item level 2</ext:Comment>", text);
            Assert.Contains(" <ext:Comment>Test picking comment item level 3</ext:Comment>", text);
            Assert.Contains("<ext:Comment>test sani</ext:Comment>", text);
            return this;
        }
        public BCOutboundPage1 ClickCutOff_MainPage()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(CutOffFromMainMenuXpath)).Displayed);
            CutOffFromMainMenu.Click();
            
            return this;
        }

        public BCOutboundPage1 OKButtonInPOWERPackingModuleTable() 
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(OKInPOWERPackingModuleQGXpath));

            Driver.FindElement(By.XPath(OKInPOWERPackingModuleQGXpath));

            OKInPOWERPackingModule.Click();

            WaitMethods.WaitForElementToBeGone(By.XPath(OKInPOWERPackingModuleQGXpath));


            return this;
        }

        public BCOutboundPage1 OKButtonInPOWERPackingModuleERROR()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(OKButtonERRORXpath));

            Driver.FindElement(By.XPath(OKButtonERRORXpath));

            OKButtonERROR.Click();

            WaitMethods.WaitForElementToBeGone(By.XPath(OKButtonERRORXpath));


            return this;
        }

        public BCOutboundPage1 OKButtonInPackingmoduleSecondOpening()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(OKButtonSecondPackingXpath));

            Driver.FindElement(By.XPath(OKButtonSecondPackingXpath));

            OKButtonSecondPacking.Click();

            WaitMethods.WaitForElementToBeGone(By.XPath(OKButtonSecondPackingXpath));


            return this;
        }

        public BCOutboundPage1 ClickCloseButtonInPOWERPackingErrorScreen()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(CloseBtnPowerPackingVASmoduleXpath));

            Driver.FindElement(By.XPath(CloseBtnPowerPackingVASmoduleXpath));

            CloseBtnPowerPackingVASmodule.Click();

            WaitMethods.WaitForElementToBeGone(By.XPath(CloseBtnPowerPackingVASmoduleXpath));

            Driver.SwitchTo().DefaultContent();

            return this;
        }

        public BCOutboundPage1 ValidateInPOWERVASModule(string vas)
        {

            WaitMethods.WaitForPageToBeReady();
            IWebElement iframe = Driver.FindElement(By.XPath("(//div[@class='task-dialog-content-container thm-cont-g0-bgcolor-1'])[2]//div//div//div[4]//div//iframe"));
            Driver.SwitchTo().Frame(iframe);

            WaitMethods.WaitForElementToBePresent(By.XPath(VasPowerModuleXpath));


            Driver.FindElement(By.XPath(VasPowerModuleXpath));
            Assert.Contains(vas, VasPowerModule.Text);

            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame(MainContentFrame);
            WaitMethods.WaitForElementToBePresent(By.XPath(CloseBtnPowerPackingVASmoduleXpath));
            WaitMethods.WaitForElementToBeClickable(By.XPath(CloseBtnPowerPackingVASmoduleXpath));
            

            CloseBtnPowerPackingVASmodule.Click();

            WaitMethods.WaitForElementToBeGone(By.XPath(CloseBtnPowerPackingVASmoduleXpath));

           
            return this;
        }

        public BCOutboundPage1 SwitchFrame_POWERPackingVASModule()
        {
           

            WaitMethods.WaitForPageToBeReady();

            Driver.SwitchTo().Frame(SwitchToVASPackingFrameXpath);
            WaitMethods.WaitForPageToBeReady();

            return this;
        }
    }
}
