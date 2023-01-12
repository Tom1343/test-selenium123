using CGI_OUTBOUND_BC_Scenarios.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using TechTalk.SpecFlow;
using Xunit;

namespace CGI_OUTBOUND_BC_Scenarios.OUTBOUND.Pages
{
    [Binding]
    public class BCOutboundPage3 : Page
    {
        private WaitMethods WaitMethods => new WaitMethods(Driver);
        public BCOutboundPage3(IWebDriver driver) : base(driver) { }

        public BCOutboundPage3 IClickUser(string p0)
        {
            WaitMethods.WaitForElementToAppear(By.XPath($"//span[contains(text(),'{p0}')]"))
                .WaitForElementToBePresent(By.XPath($"//span[contains(text(),'{p0}')]"));

            Driver.FindElement(By.XPath($"//span[contains(text(),'{p0}')]")).Click();

            return this;
        }

        public BCOutboundPage3 IWriteBatchNumbers(string p0)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(IWriteBatchNumberXpath))
                 .WaitForElementToBeClickable(By.XPath(IWriteBatchNumberXpath));

            IWriteBatchNumber.Click();
            IWriteBatchNumber.Clear();
            IWriteBatchNumber.SendKeys(p0);

            return this;
        }

        public BCOutboundPage3 IClickBatchOverviews()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(IClickBatchOverviewXpath))
                 .WaitForElementToBeClickable(By.XPath(IClickBatchOverviewXpath));
            IClickBatchOverview.Click();

            return this;
        }

        public BCOutboundPage3 SelectDateCreateds()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(SelectDateCreatedXpath))
                 .WaitForElementToBeClickable(By.XPath(SelectDateCreatedXpath));

            SelectDateCreated.SendKeys("t" + Keys.Enter);

            return this;
        }

        public BCOutboundPage3 EnterDateToLoadOutbounds(string DateToLoad)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EnterDateToLoadOutboundXpath))
                 .WaitForElementToBeClickable(By.XPath(EnterDateToLoadOutboundXpath));

            EnterDateToLoadOutbound.Click();
            EnterDateToLoadOutbound.SendKeys(DateToLoad);

            return this;
        }

        public BCOutboundPage3 ShouldGet_BATCHWAVE()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(IShouldGetBATCHWAVEXpath))
                 .WaitForElementToBeClickable(By.XPath(IShouldGetBATCHWAVEXpath));

            IShouldGetBATCHWAVE.Click();

            return this;
        }

        public BCOutboundPage3 IWaitForTheNotificationToAppear()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(IGetNotificationHolderHasBeenUnpackedXpath))
                 .WaitForPageToBeReady();

            return this;
        }

        public BCOutboundPage3 OperationOverviews_OpenTransportInbounds_List_SelectDocument_NewDocument_FillRefrence(string value)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(FillReferenceXpath))
                 .WaitForElementToBeClickable(By.XPath(FillReferenceXpath));

            FillReference.Click();
            FillReference.SendKeys(value);

            return this;
        }

        public BCOutboundPage3 SetIEnterDestinationOrderNrWithRandom(string value)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(DestinationOrderNrXpath))
                 .WaitForElementToBeClickable(By.XPath(DestinationOrderNrXpath));

            DestinationOrderNr.Click();
            DestinationOrderNr.SendKeys(value);

            return this;
        }

        public BCOutboundPage3 SetIEnterClientShipmentNrWithRandom(string value)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClientShipmentNrXpath))
                 .WaitForElementToBeClickable(By.XPath(ClientShipmentNrXpath));

            ClientShipmentNr.Click();
            ClientShipmentNr.SendKeys(value);

            return this;
        }

        public BCOutboundPage3 DateToFinishPickingQueue(string Date)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(DateToFinishPickingXpath))
                 .WaitForElementToBeClickable(By.XPath(DateToFinishPickingXpath));

            DateToFinishPicking.Click();
            DateToFinishPicking.SendKeys(Date + Keys.Tab);

            return this;
        }

        public BCOutboundPage3 FillTimeToFinishPickingQueue(string Time)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(FillTimeToFinishPickingXpath))
                 .WaitForElementToBeClickable(By.XPath(FillTimeToFinishPickingXpath));

            FillTimeToFinishPicking.Click();
            FillTimeToFinishPicking.SendKeys(Time);
            FillTimeToFinishPicking.SendKeys(Keys.Tab);


            return this;
        }

        public BCOutboundPage3 FillFinishPickingFieldOnOutbound(string Time)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(FillTimeToFinishPickingXpath))
                 .WaitForElementToBeClickable(By.XPath(FillTimeToFinishPickingXpath));

            FillTimeToFinishPicking.Click();
            FillTimeToFinishPicking.SendKeys(Time);

            return this;
        }

        public BCOutboundPage3 EnterDatesDeliveredOutbound()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(EnterDateDeliveredOutboundXpath)).Displayed);
            EnterDateDeliveredOutbound.Click();
            EnterDateDeliveredOutbound.SendKeys("t");
            EnterDateDeliveredOutbound.SendKeys(Keys.Tab);

            return this;
        }

        public BCOutboundPage3 EnterCodesOutbound(string OutboundCode)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EnterCodeOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(EnterCodeOutboundXpath));

            WaitMethods.RepeatUntil(
            () =>
            {
                EnterCodeOutbound.Click();
                EnterCodeOutbound.SendKeys(OutboundCode + Keys.Escape + Keys.Tab);
            },
            _ => EnterCodeOutbound.GetAttribute("value").Equals(OutboundCode),
            TimeSpan.FromSeconds(2), 5
            );

            WaitMethods.WaitForPageToBeReady();

            return this;
        }

        public BCOutboundPage3 FillTypeOnOutobun(string p0)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EnterTypeOnOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(EnterTypeOnOutboundXpath));

            EnterTypeOnOutbound.Clear();
            EnterTypeOnOutbound.Click();
            EnterTypeOnOutbound.SendKeys(p0 + Keys.Escape + Keys.Tab);

            //WaitMethods.RepeatUntil(
            //() =>
            //{
                
            //    EnterTypeOnOutbound.Click();               
            //    EnterTypeOnOutbound.SendKeys(p0 + Keys.Escape + Keys.Tab);
            //},
            //_ => EnterCodeOutbound.GetAttribute("value").Equals(p0),
            //TimeSpan.FromSeconds(2), 5
            //);

            WaitMethods.WaitForPageToBeReady();

            return this;
        }

        public BCOutboundPage3 EnterCodeInQueueForOutbound(string OutboundCode)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EnterCodeOutboundInQueueGroupXpath))
                .WaitForElementToBeClickable(By.XPath(EnterCodeOutboundInQueueGroupXpath));


            EnterCodeOutboundInQueueGroup.Click();
            EnterCodeOutboundInQueueGroup.SendKeys(OutboundCode + Keys.Enter);

            WaitMethods.WaitForPageToBeReady();

            return this;
        }

        public BCOutboundPage3 EnterGroupOnOutbound(string GroupOnOutbound)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EnterGroupOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(EnterGroupOutboundXpath));

            EnterGroupOutbound.Clear();

            EnterGroupOutbound.Click();
            EnterGroupOutbound.SendKeys(GroupOnOutbound + Keys.Enter);
            EnterGroupOutbound.SendKeys(Keys.Tab);

            WaitMethods.RepeatUntil(
            () =>
            {
                EnterGroupOutbound.Click();
                EnterGroupOutbound.SendKeys(GroupOnOutbound + Keys.Enter);
                EnterGroupOutbound.SendKeys(Keys.Tab);
            },
            _ => EnterGroupOutbound.GetAttribute("value").Equals(GroupOnOutbound),
            TimeSpan.FromSeconds(2), 5
            );

            return this;
        }

        public BCOutboundPage3 IEnterPickingRoutes(string p0)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(IEnterPickingRouteXpath)).Displayed);
            IEnterPickingRoute.Click();

            IEnterPickingRoute.SendKeys(p0);

            return this;
        }

        public BCOutboundPage3 ICutOffInManageOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(MoreOptionsCutOffXpath))
                .WaitForElementToBeClickable(By.XPath(MoreOptionsCutOffXpath));
            MoreOptionsCutOff.Click();

            //IWebElement element = Driver.FindElement(By.XPath(ManageOrderCutOffOutboundXpath));
            //Actions actions = new Actions(Driver);
            //actions.MoveToElement(element).Click().Build().Perform();

            WaitMethods.WaitForElementToAppear(By.XPath(ManageOrderCutOffOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(ManageOrderCutOffOutboundXpath));
            ManageOrderCutOffOutbound.Click();

            WaitMethods.RepeatUntil(
            () => ManageOrderCutOffOutbound.Click(),
            _ => Driver.FindElements(By.XPath(CuttOffOutboundXpath)).Count > 0,
            TimeSpan.FromSeconds(2), 5
            );

            WaitMethods.WaitForElementToAppear(By.XPath(CuttOffOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(CuttOffOutboundXpath));
            CuttOffOutbound.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(ProgressBarXPath), 15)
                .WaitForElementToBeGone(By.XPath(ProgressBarXPath));

            WaitMethods.WaitForPageToBeReady(5);


            return this;
        }

        public BCOutboundPage3 ICutOffInManageAfterBookBack()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(FewerOptionsCutOffXpath))
                .WaitForElementToBeClickable(By.XPath(FewerOptionsCutOffXpath));
            FewerOptionsCutOff.Click();

            //IWebElement element = Driver.FindElement(By.XPath(ManageOrderCutOffOutboundXpath));
            //Actions actions = new Actions(Driver);
            //actions.MoveToElement(element).Click().Build().Perform();

            WaitMethods.WaitForElementToAppear(By.XPath(ManageOrderCutOffOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(ManageOrderCutOffOutboundXpath));
            ManageOrderCutOffOutbound.Click();

            WaitMethods.RepeatUntil(
            () => ManageOrderCutOffOutbound.Click(),
            _ => Driver.FindElements(By.XPath(CuttOffOutboundXpath)).Count > 0,
            TimeSpan.FromSeconds(2), 5
            );

            WaitMethods.WaitForElementToAppear(By.XPath(CuttOffOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(CuttOffOutboundXpath));
            CuttOffOutbound.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(ProgressBarXPath), 15)
                .WaitForElementToBeGone(By.XPath(ProgressBarXPath));

            WaitMethods.WaitForPageToBeReady(5);


            return this;
        }

        public BCOutboundPage3 IBookAllInManageOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ManageOrderOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(ManageOrderOutboundXpath));

            WaitMethods.RepeatUntil(
            () => ManageOrderOutbound.Click(),
            _ => Driver.FindElements(By.XPath(BookAllRecordsOutboundXpath)).Count > 0,
            TimeSpan.FromSeconds(2), 5
            );

            WaitMethods.WaitForElementToAppear(By.XPath(BookAllRecordsOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(BookAllRecordsOutboundXpath));
            BookAllRecordsOutbound.Click();
            WaitMethods.WaitForElementToBeGone(By.XPath(ProgressBarXPath), 15);
            return this;
        }

        public BCOutboundPage3 IClickManageOrderInOutboundCard()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ManageOrderOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(ManageOrderOutboundXpath));

            ManageOrderOutbound.Click();

            return this;
        }

        public BCOutboundPage3 IClickDeleteLineInManageOrderInOutboundCard()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickDeleteLineInEDIMessageTableXpath))
                .WaitForElementToBeClickable(By.XPath(ClickDeleteLineInEDIMessageTableXpath));

            ClickDeleteLineInEDIMessageTable.Click();

            return this;
        }

        public BCOutboundPage3 ISelectChangePickingRouteOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ManageOrderOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(ManageOrderOutboundXpath));
            ManageOrderOutbound.Click();


            WaitMethods.WaitForElementToAppear(By.XPath(ChangePickingRouteOutboundXpath))
            .WaitForElementToBeClickable(By.XPath(ChangePickingRouteOutboundXpath));
            ChangePickingRouteOutbound.Click();

            return this;
        }

        public BCOutboundPage3 EnterTimeDeliveredOutbounds()
        {

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(EnterTimeDeliveredOutboundXpath)).Displayed);
            EnterTimeDeliveredOutbound.Click();

            EnterTimeDeliveredOutbound.SendKeys("t");
            EnterTimeDeliveredOutbound.SendKeys(Keys.Tab);
            return this;
        }

        public BCOutboundPage3 EnterDateToLoad()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EnterDateToLoadOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(EnterDateToLoadOutboundXpath));

            string DateToLoad = DateTime.Now.Date.ToString("dd/MM/yyyy");
            WaitMethods.RepeatUntil(
                () =>
                {
                    EnterDateToLoadOutbound.Click();
                    EnterDateToLoadOutbound.SendKeys(DateToLoad);
                    EnterDateToLoadOutbound.SendKeys(Keys.Tab);
                },
                _ => EnterDateToLoadOutbound.GetAttribute("value").Equals(DateToLoad),
                TimeSpan.FromSeconds(2), 5
                );

            return this;
        }

        public BCOutboundPage3 NasSimulatorClicks()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(SchedulerFromSetupXpath))
                .WaitForElementToBeClickable(By.XPath(SchedulerFromSetupXpath));
            SchedulerFromSetup.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(NasSimulatorClickXpath))
                .WaitForElementToBeClickable(By.XPath(NasSimulatorClickXpath));
            NasSimulatorClick.Click();

            return this;
        }

        public BCOutboundPage3 NasSimulatorClicksADEO()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(SchedulerFromSetupADEOXpath))
                .WaitForElementToBeClickable(By.XPath(SchedulerFromSetupADEOXpath));
            SchedulerFromSetupADEO.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(NasSimulatorClickADEOXpath))
                .WaitForElementToBeClickable(By.XPath(NasSimulatorClickADEOXpath));
            NasSimulatorClickADEO.Click();

            return this;
        }

        public BCOutboundPage3 ShowFilterPaneForOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ShowFilterPaneXpath))
                .WaitForElementToBeClickable(By.XPath(ShowFilterPaneXpath));

            ShowFilterPane.Click();
            FilterInNAS.Click();

            return this;
        }

        public BCOutboundPage3 SaveOutboundCodeForOutboundInNasSimulator()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(MySavedCustomerIrregularityCodeXpath))
                .WaitForElementToBeClickable(By.XPath(MySavedCustomerIrregularityCodeXpath));

            MySavedCustomerIrregularityCode.SendKeys("*" + DataCollection.OutboundCodeFromNewOutbound + "*");
            MySavedCustomerIrregularityCode.SendKeys(Keys.Enter);

            return this;
        }

        public BCOutboundPage3 InNASSimulatorSelectMyLineAndClickRuun()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(RunSelectedTasksNASButtonXpath))
                .WaitForElementToBeClickable(By.XPath(RunSelectedTasksNASButtonXpath));

            RunSelectedTasksNASButton.Click();

            return this;
        }

        public BCOutboundPage3 WriteOnFilter(string inputFilter)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(WriteOnFilterInputXpath))
                .WaitForElementToBeClickable(By.XPath(WriteOnFilterInputXpath));

            WriteOnFilterInput.SendKeys(inputFilter + Keys.Enter);

            return this;
        }

        public BCOutboundPage3 SetupMenu1()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(SetupXpath))
                .WaitForElementToBeClickable(By.XPath(SetupXpath));

            Setup.Click();

            return this;
        }

        public BCOutboundPage3 EnterCodeOutbounds()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EnterCodeOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(EnterCodeOutboundXpath));

            EnterCodeOutbound.Click();
            EnterCodeOutbound.SendKeys("10");

            return this;
        }

        public BCOutboundPage3 EnterGroupOutbounds()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EnterGroupOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(EnterGroupOutboundXpath));

            EnterGroupOutbound.Click();
            EnterGroupOutbound.SendKeys("DPD");

            return this;
        }

        public BCOutboundPage3 ClickORDEROutbounds()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickORDEROutboundXpath))
                .WaitForElementToBeClickable(By.XPath(ClickORDEROutboundXpath));

            ClickORDEROutbound.Click();
            return this;
        }

        public BCOutboundPage3 EnterOrderLineOutbounds()
        {
            {
                WaitMethods.WaitForElementToAppear(By.XPath(EnterOrderLineOutboundXpath))
                    .WaitForElementToBeClickable(By.XPath(EnterOrderLineOutboundXpath));

                EnterOrderLineOutbound.Click();
                EnterOrderLineOutbound.SendKeys("1");
                EnterOrderLineOutbound.SendKeys(Keys.Tab);

                WaitMethods.RepeatUntil(
                () =>
                {
                    EnterOrderLineOutbound.Click();
                    EnterOrderLineOutbound.SendKeys("1");
                },
                _ => EnterOrderLineOutbound.GetAttribute("value").Equals("1"),
                TimeSpan.FromSeconds(2), 5
                );

                return this;
            }
        }

        public BCOutboundPage3 EnterOrderLineOutbounds2()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EnterOrderLineOutbound2Xpath))
                .WaitForElementToBeClickable(By.XPath(EnterOrderLineOutbound2Xpath));

            WaitMethods.RepeatUntil(
                () =>
                {
                    EnterOrderLineOutbound2.Click();
                    EnterOrderLineOutbound2.SendKeys("2");
                },
                _ => EnterOrderLineOutbound2.GetAttribute("value").Equals("2"),
                TimeSpan.FromSeconds(2), 5
                );

            return this;
        }
        public BCOutboundPage3 EnterOrderLineTwoOutbounds()
        {

            WaitMethods.WaitForElementToAppear(By.XPath(EnterOrderLineTwoOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(EnterOrderLineTwoOutboundXpath));

            EnterOrderLineTwoOutbound.Click();
            EnterOrderLineTwoOutbound.SendKeys("2");

            WaitMethods.RepeatUntil(
            () =>
            {
                EnterOrderLineTwoOutbound.Click();
                EnterOrderLineTwoOutbound.SendKeys("2");
            },
            _ => EnterOrderLineTwoOutbound.GetAttribute("value").Equals("2"),
            TimeSpan.FromSeconds(2), 5
            );

            return this;
        }

        public BCOutboundPage3 EnterItemInOutbounds(string Item)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EnterItemInOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(EnterItemInOutboundXpath));

            WaitMethods.RepeatUntil(
            () =>
            {
                EnterItemInOutbound.Click();
                EnterItemInOutbound.Clear();
                EnterItemInOutbound.SendKeys(Item);
            },
            _ => EnterItemInOutbound.GetAttribute("value").Equals(Item),
            TimeSpan.FromSeconds(2), 5
            );

            return this;
        }

        public BCOutboundPage3 EnterItemInOutboundsSecond(string Item)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EnterItem2InOutboundXpath))
               .WaitForElementToBeClickable(By.XPath(EnterItem2InOutboundXpath));

            WaitMethods.RepeatUntil(
            () =>
            {
                EnterItem2InOutbound.Click();
                EnterItem2InOutbound.Clear();
                EnterItem2InOutbound.SendKeys(Item + Keys.Tab + Keys.Tab);
            },
            _ => EnterItemInOutbound.GetAttribute("value").Equals(Item),
            TimeSpan.FromSeconds(2), 5
            );
            return this;
        }

        public BCOutboundPage3 EnterItemInOrderLineTwoOutbound(string Item)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EnterItemInOutboundXpath))
                    .WaitForElementToBeClickable(By.XPath(EnterItemInOutboundXpath));

            WaitMethods.RepeatUntil(
            () =>
            {
                EnterItemInOutbound.Click();
                EnterItemInOutbound.Clear();
                EnterItemInOutbound.SendKeys(Item);
            },
            _ => EnterItemInOutbound.GetAttribute("value").Equals(Item),
            TimeSpan.FromSeconds(2), 5
            );

            return this;
        }



        public BCOutboundPage3 EnterBookingQtyOutbound(string BookingQty)
        {
            Actions action = new Actions(Driver);
            action
                .MoveToElement(BookingQtyOutbound)
                .Perform();
            action
                .Click()
                .Build()
                .Perform();

            WaitMethods.RepeatUntil(
            () =>
            {
                BookingQtyOutbound.Click();
                BookingQtyOutbound.SendKeys(BookingQty);
            },
            _ => BookingQtyOutbound.GetAttribute("value").Equals(BookingQty),
            TimeSpan.FromSeconds(2), 5
            );

            return this;
        }

        public BCOutboundPage3 EnterBookingQtyOutboundZC(string BookingQty)
        {
            EnterItemInOutbound.SendKeys(Keys.Tab);

            Actions action = new Actions(Driver);
            action
                .MoveToElement(BookingQtyOutbound)
                .Perform();
            action
                .Click()
                .Build()
                .Perform();

            WaitMethods.RepeatUntil(
            () =>
            {
                BookingQtyOutbound.Click();
                BookingQtyOutbound.SendKeys(BookingQty);
            },
            _ => BookingQtyOutbound.GetAttribute("value").Equals(BookingQty),
            TimeSpan.FromSeconds(2), 5
            );

            return this;
        }

        public BCOutboundPage3 EnterConfigInConfiguration(string Config)
        {
            BookingQtyOutbound.SendKeys(Keys.Tab + Keys.Tab + Keys.Tab + Keys.Tab + Keys.Tab);

            Actions action = new Actions(Driver);
            action
                .MoveToElement(ConfigurationInOutbound)
                .Perform();
            action
                .Click()
                .Build()
                .Perform();

            //WaitMethods.RepeatUntil(
            //() =>
            //{
            //    ConfigurationInOutbound.Click();
            //    ConfigurationInOutbound.SendKeys(Config + Keys.Enter);
            //    ConfigurationInOutbound.SendKeys(Keys.Tab + Keys.Tab);
            //},
            //_ => BookingQtyOutbound.GetAttribute("value").Equals(Config),
            //TimeSpan.FromSeconds(4), 5
            //);

            ConfigurationInOutbound.Click();
            ConfigurationInOutbound.SendKeys(Config + Keys.Enter);
            ConfigurationInOutbound.SendKeys(Keys.Tab + Keys.Tab);



            return this;
        }

        public BCOutboundPage3 EnterBookingQtyOutbound2(string BookingQty)
        {
            Actions action = new Actions(Driver);
            action
                .MoveToElement(BookingQtyOutbound)
                .Perform();
            action
                .Click()
                .Build()
                .Perform();

            WaitMethods.RepeatUntil(
            () =>
            {
                BookingQtyOutbound.Click();
                BookingQtyOutbound.SendKeys(BookingQty);
            },
            _ => BookingQtyOutbound.GetAttribute("value").Equals(BookingQty),
            TimeSpan.FromSeconds(2), 5
            );

            return this;
        }

        public BCOutboundPage3 EnterBookingQtyOutboundDown(string BookingQty)
        {
            Actions action = new Actions(Driver);
            action
                .MoveToElement(BookingQtyOutbound)
                .Perform();
            action
                .Click()
                .Build()
                .Perform();

            WaitMethods.RepeatUntil(
            () =>
            {
                BookingQtyOutbound.Click();
                BookingQtyOutbound.SendKeys(BookingQty);
                EnterOrderLineOutbound.Click();
                BookingQtyOutbound.SendKeys(Keys.Down);
            },
            _ => BookingQtyOutbound.GetAttribute("value").Equals(BookingQty),
            TimeSpan.FromSeconds(2), 5
            );

            return this;
        }

        public BCOutboundPage3 EnterLOTNOOutboundOrderLine(string enterLOTNOOutboundOrderLine)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(LOTNOOutboundOrderLineOutboundXpath))
                    .WaitForElementToBeClickable(By.XPath(LOTNOOutboundOrderLineOutboundXpath));

            LOTNOOutboundOrderLineOutbound.Click();
            LOTNOOutboundOrderLineOutbound.SendKeys(enterLOTNOOutboundOrderLine);
            LOTNOOutboundOrderLineOutbound.SendKeys(Keys.Tab);

            return this;
        }

        public BCOutboundPage3 WriteBlockedReasonFieldOutbound(string BlockedReasonFieldOutbound1)
        {


            Actions action = new Actions(Driver);
            action
                .MoveToElement(BlockedReasonFieldOutbound)
                .Perform();
            action
                .Click()
                .Build()
                .Perform();

            BlockedReasonFieldOutbound.SendKeys(BlockedReasonFieldOutbound1);

            WaitMethods.RepeatUntil(
           () =>
           {
               BlockedReasonFieldOutbound.Click();
               BlockedReasonFieldOutbound.SendKeys(BlockedReasonFieldOutbound1);
           },
           _ => BlockedReasonFieldOutbound.GetAttribute("value").Equals(BlockedReasonFieldOutbound1),
           TimeSpan.FromSeconds(2), 5
           );

            return this;
        }

        public BCOutboundPage3 EnterOutboundCodeOnSearchOptionOutboundList(string p0)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(InsertSearchOptionOutboundListXpath));

            InsertSearchOptionOutboundList.SendKeys(p0);

            WaitMethods.WaitForPageToBeReady();

            InsertSearchOptionOutboundList.Click();

            WaitMethods.WaitForPageToBeReady();

            return this;
        }

        public BCOutboundPage3 EnterOutboundCodeOnLinkedTransportFieldInput(string p0)
        {
            WaitMethods.WaitForPageToBeReady();
            WaitMethods.WaitForElementToAppear(By.XPath(LinkedTransportInputFieldXpath), 5);

            WaitMethods.RepeatUntil(
                () =>
                {
                    LinkedTransportInputField.Click();
                    LinkedTransportInputField.SendKeys(p0 + Keys.Tab + Keys.Tab);
                },
                _ => LinkedTransportInputField.GetAttribute("value").Equals(p0),
                TimeSpan.FromSeconds(2), 5
                );

            return this;
        }

        public BCOutboundPage3 SearchMyStaticLinkedTROWithOutbound(string p0)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(InsertSearchOptionTROListXpath))
                    .WaitForElementToBeClickable(By.XPath(InsertSearchOptionTROListXpath));

            InsertSearchOptionTROList.SendKeys(p0);
            InsertSearchOptionTROList.SendKeys(Keys.Enter);

            WaitMethods.WaitForPageToBeReady();
            return this;
        }

        public BCOutboundPage3 SelectViewLinkedOutboundsTRO()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ViewLinkedOutboundsTROXpath))
                    .WaitForElementToBeClickable(By.XPath(ViewLinkedOutboundsTROXpath));

            ViewLinkedOutboundsTRO.Click();

            return this;
        }

        public BCOutboundPage3 ClickViewLinkedOutboundsTROCard()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ViewLinkedOutboundsINTROXpath))
                    .WaitForElementToBeClickable(By.XPath(ViewLinkedOutboundsINTROXpath));

            ViewLinkedOutboundsINTRO.Click();

            return this;
        }

        public BCOutboundPage3 SelectViewLinkedQueueGroupsTRO()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ViewLinkedQueueGroupsTROXpath))
                    .WaitForElementToBeClickable(By.XPath(ViewLinkedQueueGroupsTROXpath));

            ViewLinkedQueueGroupsTRO.Click();

            return this;
        }

        public BCOutboundPage3 SelectMoreOptionsINQGActions()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ShowTheRestInQGXpath))
                    .WaitForElementToBeClickable(By.XPath(ShowTheRestInQGXpath));

            ShowTheRestInQG.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(MoreOptionsAfterShowTheRestXpath))
                    .WaitForElementToBeClickable(By.XPath(MoreOptionsAfterShowTheRestXpath));

            MoreOptionsAfterShowTheRest.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(ActionsAfterMoreOptionsXpath))
                    .WaitForElementToBeClickable(By.XPath(ActionsAfterMoreOptionsXpath));

            ActionsAfterMoreOptions.Click();

            return this;
        }

        public BCOutboundPage3 SelectQueueGroupDeleteLinkedTransport()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(QueueGroupAfterActionXpath))
                    .WaitForElementToBeClickable(By.XPath(QueueGroupAfterActionXpath));

            QueueGroupAfterAction.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(DeleteLinkedTransportXpath))
                    .WaitForElementToBeClickable(By.XPath(DeleteLinkedTransportXpath));

            DeleteLinkedTransport.Click();

            return this;
        }

        public BCOutboundPage3 SelectMultipleOutboundsToUnlink()
        {
            //WaitMethods.WaitForElementToAppear(By.XPath(ShowMoreOptionsInUnlinkOutboundsXpath))
            //        .WaitForElementToBeClickable(By.XPath(ShowMoreOptionsInUnlinkOutboundsXpath));

            //ShowMoreOptionsInUnlinkOutbounds.Click();

            //WaitMethods.WaitForElementToAppear(By.XPath(SelectMoreOptionsInUnlinkOutboundsXpath))
            //        .WaitForElementToBeClickable(By.XPath(SelectMoreOptionsInUnlinkOutboundsXpath));

            //SelectMoreOptionsInUnlinkOutbounds.Click();

            //WaitMethods.WaitForElementToAppear(By.XPath(SelectTheSecondQueueToUnlinkOutboundsXpath))
            //        .WaitForElementToBeClickable(By.XPath(SelectTheSecondQueueToUnlinkOutboundsXpath));

            //SelectTheSecondQueueToUnlinkOutbounds.Click();

            WaitMethods.WaitForElementToBePresent(By.XPath(ShowMoreOptionsInUnlinkOutboundsXpath))
                .WaitForElementToAppear(By.XPath(ShowMoreOptionsInUnlinkOutboundsXpath), 5);

            IWebElement checkbox1 = Driver.FindElement(By.XPath(SelectTheFirstQueueToUnlinkOutboundsXpath));
            IWebElement checkbox2 = Driver.FindElement(By.XPath(SelectTheSecondQueueToUnlinkOutboundsXpath));
            Actions aBuilder = new Actions(Driver);
            aBuilder.KeyDown(Keys.Shift).Click(checkbox1).Click(checkbox2).KeyUp(Keys.Shift).Perform();

            return this;
        }


        public BCOutboundPage3 ChangeStatusOfOutboundFilterToDone()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(SelectStatusFromFilterXpath))
                    .WaitForElementToBeClickable(By.XPath(SelectStatusFromFilterXpath));

            SelectStatusFromFilter.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(StatusCheckBoxDoneXpath));

            StatusCheckBoxDone.Click();

            return this;
        }

        public BCOutboundPage3 SelectLoadedCheckBoxInStatusOutboundOrderFilter()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(SelectStatusFromFilterXpath))
                    .WaitForElementToBeClickable(By.XPath(SelectStatusFromFilterXpath));

            SelectStatusFromFilter.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(StatusCheckBoxLoadedXpath))
                .WaitForElementToBePresent(By.XPath(StatusCheckBoxLoadedXpath))
                .WaitForElementToBeClickable(By.XPath(StatusCheckBoxLoadedXpath));

            StatusCheckBoxLoaded.Click();


            return this;
        }

        public BCOutboundPage3 MoreOptionsOnPowerOutboundList_TROs()
        {
            //WaitMethods.WaitForElementToAppear(By.XPath(ShowTheRestXpath))
            //    .WaitForElementToAppear(By.XPath(ShowTheRestXpath))
            //        .WaitForElementToBeClickable(By.XPath(ShowTheRestXpath));

            //ShowTheRest.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(MoreOptionsOnPowerOutboundList_TROXpath))
                .WaitForElementToAppear(By.XPath(MoreOptionsOnPowerOutboundList_TROXpath))
                    .WaitForElementToBeClickable(By.XPath(MoreOptionsOnPowerOutboundList_TROXpath));


            MoreOptionsOnPowerOutboundList_TRO.Click();


            return this;
        }

        public BCOutboundPage3 ClickMoreOptionsOnPOWERQUEUEGROUPLIST_TRO()
        {

            Actions action = new Actions(Driver);
            action
                .MoveToElement(MoreOptionsOnPOWERQUEUEGROUPLIST_TRO)
                .Perform();
            action
                .Click()
                .Build()
                .Perform();

            MoreOptionsOnPoWerQueueGroupList_TRO_Written.Click();

            MoreOptionsOnPOWERQUEUEGROUPLIST_TRO.Click();

            return this;
        }

        public BCOutboundPage3 ClickMoreOptionsOnPOWERQUEUEGROUPLIST_Outbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(MoreOptionsOnPOWERQUEUEGROUPLIST_TROXpath))
                .WaitForElementToBeClickable(By.XPath(MoreOptionsOnPOWERQUEUEGROUPLIST_TROXpath));
            MoreOptionsOnPOWERQUEUEGROUPLIST_TRO.Click();

            //WaitMethods.WaitForElementToAppear(By.XPath(MoreOptionsOnPoWerQueueGroupList_TRO_WrittenXpath))
            //    .WaitForElementToBeClickable(By.XPath(MoreOptionsOnPoWerQueueGroupList_TRO_WrittenXpath));
            //MoreOptionsOnPoWerQueueGroupList_TRO_Written.Click();

            //WaitMethods.WaitForElementToAppear(By.XPath(MoreOptionsOnPOWERQUEUEGROUPLIST_TROXpath))
            //    .WaitForElementToBeClickable(By.XPath(MoreOptionsOnPOWERQUEUEGROUPLIST_TROXpath));
            //MoreOptionsOnPOWERQUEUEGROUPLIST_TRO.Click();

            return this;
        }

        public BCOutboundPage3 ClickMoreOptionsWithoudInsideMoreOptionsPOWERQUEUEGROUPLIST_TRO()
        {
            Actions action = new Actions(Driver);
            action
                .MoveToElement(MoreOptionsOnPOWERQUEUEGROUPLIST_TRO)
                .Perform();
            action
                .Click()
                .Build()
                .Perform();

            return this;
        }

        public BCOutboundPage3 EnterDateToLoadOnOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EnterDateToLoadOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(EnterDateToLoadOutboundXpath));

            string DateToLoad = DateTime.Now.Date.ToString("dd/MM/yyyy");
            WaitMethods.RepeatUntil(
                () =>
                {
                    EnterDateToLoadOutbound.Click();
                    EnterDateToLoadOutbound.SendKeys(DateToLoad);
                },
                _ => EnterDateToLoadOutbound.GetAttribute("value").Equals(DateToLoad),
                TimeSpan.FromSeconds(2), 5
                );

            return this;

        }

        public BCOutboundPage3 FilterListByThenClickFilter()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("//button[@aria-label='Add a new filter on a field']"))
                    .WaitForElementToBeClickable(By.XPath("//button[@aria-label='Add a new filter on a field']"));


            WaitMethods.RepeatUntil(
            () =>
            {
                ClickFilterListBy.Click();
                AddFilterForEDIMessageLogList.SendKeys("Reference" + Keys.Enter);
            },
            _ => Driver.FindElements(By.XPath(AddFilterForEDIMessageLogListXpath)).Count > 0,
            TimeSpan.FromSeconds(2), 5
            );

            return this;
        }

        public BCOutboundPage3 FilterInNASsim()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickFilterButtonOnNasSimulatorXpath))
                   .WaitForElementToBeClickable(By.XPath(ClickFilterButtonOnNasSimulatorXpath));

            ClickFilterButtonOnNasSimulator.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(FilterInNASXpath))
                   .WaitForElementToBeClickable(By.XPath(FilterInNASXpath));

            FilterInNAS.Click();
            return this;
        }
        public BCOutboundPage3 ClickStartupParameter()
        {

            WaitMethods.WaitForElementToAppear(By.XPath(StartupParameterXpath))
                          .WaitForElementToBeClickable(By.XPath(StartupParameterXpath));


            StartupParameter.Click();

            return this;
        }
        public BCOutboundPage3 EnterCopiedOutboundCodeNasSimulatorFilter()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(EnterNasSimulatorFilterFieldXpath));

            EnterNasSimulatorFilterField.SendKeys("*" + DataCollection.OutboundCodeFromNewOutbound + "*");

            EnterNasSimulatorFilterField.SendKeys(Keys.Enter);

            return this;
        }
        public BCOutboundPage3 EnterTRIToSearchLabel(string TRIno)
        {

            //WaitMethods.WaitForElementToAppear(By.XPath(PasteTRIvarFromTRITableXpath))
            //             .WaitForElementToBeClickable(By.XPath(PasteTRIvarFromTRITableXpath));

            WaitMethods.WaitForElementToAppear(By.XPath(PasteTRIvarFromTRITableXpath))
                        .WaitForElementToBeClickable(By.XPath(PasteTRIvarFromTRITableXpath));
            Driver.FindElement(By.XPath(ClickSearchFromTheNavigationBarXpath)).SendKeys(TRIno + Keys.Return);

            WaitMethods.WaitUntilElementExists(By.XPath($"//span[text() = '{TRIno}']"));

            //PasteTRIvarFromTRITable.SendKeys(DataCollection.TRIvar + Keys.Return + Keys.Return);

            return this;
        }
        public BCOutboundPage3 ClickSearchFromTheNavigationBars()
        {
            //IWebElement ExpectedAttEdit = Driver.FindElement(By.XPath("//a[@aria-label ='Edit']"));
            WaitMethods.WaitForElementToBeGone(By.XPath("//button[@aria-label ='Edit']"));

            WaitMethods.WaitUntilElementExists(By.XPath("//div[contains(@class,'search-box-container')]"));
            WaitMethods.WaitForElementToAppear(By.XPath("//div[contains(@class,'search-box-container')]"), 5)
                .WaitForElementToBeClickable(By.XPath("//div[contains(@class,'search-box-container')]"));
            Driver.FindElement(By.XPath("//div[contains(@class,'search-box-container')]")).Click();
            return this;
        }

        public BCOutboundPage3 ClickEditFromTheNavigationBarInTransportInbounds()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ClickEditFromTheNavigationBarInTransportInboundXpath));
            ClickEditFromTheNavigationBarInTransportInbound.Click();

            return this;
        }
        public BCOutboundPage3 ClickValidateAndCloseTransportFromTheNavigationBars()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickValidateAndCloseTransportFromTheNavigationBarXpath))
                .WaitForElementToBePresent(By.XPath(ClickValidateAndCloseTransportFromTheNavigationBarXpath))
                .WaitForElementToBeClickable(By.XPath(ClickValidateAndCloseTransportFromTheNavigationBarXpath));
            ClickValidateAndCloseTransportFromTheNavigationBar.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(ProgressBarXPath), 5)
                .WaitForElementToBeGone(By.XPath(ProgressBarXPath));

            return this;
        }
        public BCOutboundPage3 OKBUTTONFROMPOPUPs()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(OKBUTTONFROMPOPUPXpath))
            .WaitForAllElementsToBeVisible(By.XPath(OKBUTTONFROMPOPUPXpath))
            .WaitForElementToBeClickable(By.XPath(OKBUTTONFROMPOPUPXpath));
            OKBUTTONFROMPOPUP.Click();
            //WaitMethods.WaitForMainPageToBeReady()
            //WaitMethods.WaitForElementToBeGone(By.XPath(Page.ProgressBarMainXPath), 2);
            WaitMethods.WaitForElementToBeGone(By.XPath(OKBUTTONFROMPOPUPXpath), 4);

            return this;
        }

        public BCOutboundPage3 ClickMoreOptionsTRIMenu()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("(//span[@aria-label ='More options'])[2]"))
               .WaitForElementToBeClickable(By.XPath("(//span[@aria-label ='More options'])[2]"));

            Driver.FindElement(By.XPath("(//span[@aria-label ='More options'])[2]")).Click();
            return this;

        }
        public BCOutboundPage3 ClickOKButtonOfPopupMainPages()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("//button[@type='button']/following::span[text()='OK']"))
               .WaitForElementToBeClickable(By.XPath("//button[@type='button']/following::span[text()='OK']"));

            Driver.FindElement(By.XPath("//button[@type='button']/following::span[text()='OK']")).Click();

            return this;
        }
        public BCOutboundPage3 SwitchToMainContentFrame()
        {

            WaitMethods.WaitForElementToBePresent(By.XPath(MainContentFrameXPath));
            Driver.SwitchTo().Frame(MainContentFrame);

            return this;
        }
        public BCOutboundPage3 SETUPMenu()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(SetupMenuXpath));

            SetupMenu.Click();
            return this;
        }
        public BCOutboundPage3 ClickBackButtonToMainPages()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickBackButtonToMainPageXpath), 10)
               .WaitForElementToBeClickable(By.XPath(ClickBackButtonToMainPageXpath));

            ClickBackButtonToMainPage.Click();

            return this;
        }
        public BCOutboundPage3 CMRmainMenu()
        {

            IJavaScriptExecutor js = ((IJavaScriptExecutor)Driver);
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");


            WaitMethods.WaitForElementToAppear(By.XPath(CMRmainXpath))
              .WaitForElementToBeClickable(By.XPath(CMRmainXpath));

            CMRmain.Click();
            return this;
        }
        public BCOutboundPage3 PrintCMR()
        {
            //if (SetMethods.IsElementPresent(Driver, By.XPath(ClickYesInThePopUpMessageXpath)))
            //{
            //    WaitMethods.WaitForElementToBeClickable(By.XPath(ClickYesInThePopUpMessageXpath));
            //    ClickYesInThePopUpMessage.Click();
            //}

            WaitMethods.WaitForElementToAppear(By.XPath(printCMRXpath))
                       .WaitForElementToBePresent(By.XPath(printCMRXpath));

            printCMR.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(OKBUTTONFROMPOPUPXpath))
                       .WaitForElementToBePresent(By.XPath(OKBUTTONFROMPOPUPXpath));

            OKBUTTONFROMPOPUP.Click();

            return this;
        }
        public BCOutboundPage3 DriverDocument()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(driverdocumentXpath))
               .WaitForElementToBeClickable(By.XPath(driverdocumentXpath));

            driverdocument.Click();
            return this;
        }
        public BCOutboundPage3 createCombinedtranportCMR()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(CombinedCMRXpath))
               .WaitForElementToBeClickable(By.XPath(CombinedCMRXpath));

            CombinedCMR.Click();
            ClickOKButtonOnThePopUpMessage.Click();
            return this;
        }
        public BCOutboundPage3 rePrintCMR()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(reprintCMRXpath))
                       .WaitForElementToBePresent(By.XPath(reprintCMRXpath));

            reprintCMR.Click();
            return this;
        }
        public BCOutboundPage3 IVerifyThatCutOffForPiecepickingIsDone()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(VerifyCutOffXpath));

            Assert.Contains(VerifyCutOff.Text, "Piece picking");

            return this;
        }
        public BCOutboundPage3 FromDropDownISelectStatusOutboundOrder()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ClickOnFilterToAddPlusXpath));
            ClickOnFilterToAddPlus.Click();
            WaitMethods.WaitForElementToBePresent(By.XPath(FromDropdownISelectStatusOutboundOrderXpath));
            FromDropdownISelectStatusOutboundOrder.SendKeys("Status Outbound Order" + Keys.Tab);

            return this;
        }
        public BCOutboundPage3 SelectDropdownForStatusOutboundOrders()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(SelectDropdownForStatusOutboundOrderXpath));
            SelectDropdownForStatusOutboundOrder.Click();
            return this;
        }
        public BCOutboundPage3 SelectLOADEDAfterOutboundOrder()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(SelectLoadedAfterOutboundOrderXpath));
            SelectLoadedAfterOutboundOrder.Click();
            WaitMethods.WaitForElementToBeGone(By.XPath(SelectLoadedAfterOutboundOrderXpath));
            return this;
        }
        public BCOutboundPage3 IClickCancelQtyAllOrderlines()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(CancelAllQtyOrderlinesXpath))
                .WaitForElementToBeClickable(By.XPath(CancelAllQtyOrderlinesXpath));

            CancelAllQtyOrderlines.Click();

            return this;
        }
        public BCOutboundPage3 BookBackAllPartOfSelectedLine()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ManageOrderOutboundTwoXpath))
                .WaitForElementToBeClickable(By.XPath(ManageOrderOutboundTwoXpath));

            WaitMethods.RepeatUntil(
            () => ManageOrderOutboundTwo.Click(),
            _ => Driver.FindElements(By.XPath(BookBackPartOfSelectedLineXpath)).Count > 0,
            TimeSpan.FromSeconds(2), 5
            );

            WaitMethods.WaitForElementToAppear(By.XPath(BookBackPartOfSelectedLineXpath))
                .WaitForElementToBeClickable(By.XPath(BookBackPartOfSelectedLineXpath));
            BookBackPartOfSelectedLine.Click();
            WaitMethods.WaitForElementToBeGone(By.XPath(ProgressBarXPath));
            return this;

        }
        public BCOutboundPage3 BookBackAllCompleteSelectedLineInReservation_Outbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ManageOrderOutboundTwoXpath))
                .WaitForElementToBeClickable(By.XPath(ManageOrderOutboundTwoXpath));

            WaitMethods.RepeatUntil(
            () => ManageOrderOutboundTwo.Click(),
            _ => Driver.FindElements(By.XPath(CompleteBookBackSelectedRecordsOrderLineOutboundXpath)).Count > 0,
            TimeSpan.FromSeconds(2), 5
            );

            WaitMethods.WaitForElementToAppear(By.XPath(CompleteBookBackSelectedRecordsOrderLineOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(CompleteBookBackSelectedRecordsOrderLineOutboundXpath));
            CompleteBookBackSelectedRecordsOrderLineOutbound.Click();
            WaitMethods.WaitForElementToBeGone(By.XPath(ProgressBarXPath));
            return this;

        }
    }
}
