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
using System.Text;

namespace CGI_OUTBOUND_BC_Scenarios.OUTBOUND.Pages
{
    [Binding]
    public class BCOutboundPage4 : Page
    {
        private WaitMethods WaitMethods => new WaitMethods(Driver);
        public BCOutboundPage4(IWebDriver driver) : base(driver) { }

        public BCOutboundPage4 ClickonActionsDropdown()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ClickActionsDropdownXpath));

            ClickActionsDropdown.Click();
            return this;
        }

        public BCOutboundPage4 ClickOutboundDropdownPowerOutboundList()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(OutboundDropdownPowerOutboundListXpath)).Displayed);
            OutboundDropdownPowerOutboundList.Click();
            return this;
        }

        public BCOutboundPage4 ClickUnlinkSelectedFromTransportTROQueueGroupList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(UnlinkSelectedFromTransportTROQueueGroupListXpath), 10);

            UnlinkSelectedFromTransportTROQueueGroupList.Click();
            return this;
        }

        public BCOutboundPage4 ClickUnlinkSelectedFromTransportViaProcess()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(UnlinkSelectedFromTransportViaProcessXpath), 10);

            UnlinkSelectedFromTransportViaProcess.Click();
            return this;
        }

        public BCOutboundPage4 IClickUnlinkSelectedFromTransportAfterClosingProcess()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(UnlinkSelectedFromTransportAfterClosingProcessXpath), 10);

            UnlinkSelectedFromTransportAfterClosingProcess.Click();
            return this;
        }

        public BCOutboundPage4 ClickCloseButtonOutbounds()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(ClickCloseButtonOutboundXpath)).Displayed);
            ClickCloseButtonOutbound.Click();
            return this;
        }

        public BCOutboundPage4 ClickCloseButtonOutboundsQueueGroupList()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(CloseButtonInQueueGrouplistXpath)).Displayed);
            CloseButtonInQueueGrouplist.Click();
            return this;
        }

        public BCOutboundPage4 ScrollToBlockedReasonFromQTYOutbound()
        {

            BookingQtyOutbound.SendKeys(Keys.Tab + Keys.Tab + Keys.Tab + Keys.Tab);

            GoFromCampaignToBlockedReason.SendKeys(Keys.Tab + Keys.Tab + Keys.Tab + Keys.Tab);

            return this;
        }

        public BCOutboundPage4 ScrollToLotNoFromBlockedReason_Outbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(BlockedReasonFieldOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(BlockedReasonFieldOutboundXpath));

            BlockedReasonFieldOutbound.SendKeys(Keys.Tab);
            BlockedReasonFieldOutbound.SendKeys(Keys.Tab + Keys.Tab + Keys.Tab + Keys.Tab);

            return this;
        }


        public BCOutboundPage4 IClickProcessPowerOutboundList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ProcessPowerOutboundListXpath))
               .WaitForElementToBeClickable(By.XPath(ProcessPowerOutboundListXpath));

            ProcessPowerOutboundList.Click();

            return this;
        }

        public BCOutboundPage4 InOrderLineTwo_IEnterOrderLineNO()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("//span[text()='73401 POWER Outbound']"))
                .WaitForElementToAppear(By.XPath(InOrderEnterOrderLineTwoNOXpath))
                .WaitForElementToBeClickable(By.XPath(InOrderEnterOrderLineTwoNOXpath));

            Actions action = new Actions(Driver);
            action
                .MoveToElement(InOrderEnterOrderLineTwoNO)
                .Perform();
            action
                .Click()
                .Build()
                .Perform();

            WaitMethods.RepeatUntil(
                () =>
                {
                    WaitMethods.WaitForElementToAppear(By.XPath(InOrderEnterOrderLineTwoNOXpath))
                        .WaitForElementToBeClickable(By.XPath(InOrderEnterOrderLineTwoNOXpath));
                    InOrderEnterOrderLineTwoInputNo.Click();
                    InOrderEnterOrderLineTwoInputNo.SendKeys("2");
                },
                _ => InOrderEnterOrderLineTwoInputNo.GetAttribute("value").Equals("2"),
                TimeSpan.FromSeconds(2), 5
                );

            return this;
        }

        public BCOutboundPage4 InOrderLineThreeIEnterOrderLineNOM()
        {

            WaitMethods.WaitForElementToAppear(By.XPath("//span[text()='73401 POWER Outbound']"));

            WaitMethods.WaitForElementToAppear(By.XPath(InOrderLineThreeIEnterOrderLineNOXpath))
                .WaitForElementToBeClickable(By.XPath(InOrderLineThreeIEnterOrderLineNOXpath));


            Actions action = new Actions(Driver);
            action
                .MoveToElement(InOrderLineThreeIEnterOrderLineNO)
                .Perform();
            action
                .Click()
                .Build()
                .Perform();

            WaitMethods.RepeatUntil(
                () =>
                {
                    InOrderLineThreeIEnterOrderLineInputNO.Click();
                    InOrderLineThreeIEnterOrderLineInputNO.SendKeys("3");
                },
                _ => InOrderLineThreeIEnterOrderLineInputNO.GetAttribute("value").Equals("3"),
                TimeSpan.FromSeconds(2), 5
                );

            return this;
        }

        public BCOutboundPage4 EnterBookingQtyOrderLineTwoOutbound(string BookingQty)
        {
            BookingQtyOutbound.Click();

            BookingQtyOutbound.SendKeys(BookingQty);
            return this;
        }

        public BCOutboundPage4 EnterArrivalAndDeliveryTimeTRO()
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            string date = DateTime.Now.Date.ToString("dd/MM/yyyy");

            WaitMethods.RepeatUntil(
                () =>
                {
                    ExpectedArrivalDateTRO.SendKeys(Keys.Control + "a");
                    ExpectedArrivalDateTRO.SendKeys(Keys.Delete);
                    ExpectedArrivalDateTRO.SendKeys(date);
                    WaitMethods.WaitForFieldToBePopulated(ExpectedArrivalDateTRO);
                },
                _ => ExpectedArrivalDateTRO.GetAttribute("value").Equals(date),
                TimeSpan.FromSeconds(3), 3
                );

            WaitMethods.RepeatUntil(
                () =>
                {
                    ExpectedArrivalTimeTRO.SendKeys(Keys.Control + "a");
                    ExpectedArrivalTimeTRO.SendKeys(Keys.Delete);
                    ExpectedArrivalTimeTRO.SendKeys(time);
                    WaitMethods.WaitForFieldToBePopulated(ExpectedArrivalTimeTRO);
                },
                _ => ExpectedArrivalTimeTRO.GetAttribute("value").Equals(time),
                TimeSpan.FromSeconds(3), 3
                );

            WaitMethods.RepeatUntil(
                () =>
                {
                    ExpectedDeliveryDateTRO.SendKeys(Keys.Control + "a");
                    ExpectedDeliveryDateTRO.SendKeys(Keys.Delete);
                    ExpectedDeliveryDateTRO.SendKeys(date);
                    WaitMethods.WaitForFieldToBePopulated(ExpectedDeliveryDateTRO);
                },
                _ => ExpectedDeliveryDateTRO.GetAttribute("value").Equals(date),
                TimeSpan.FromSeconds(3), 3
                );

            WaitMethods.RepeatUntil(
                () =>
                {
                    ExpectedDeliveryTimeTRO.SendKeys(Keys.Control + "a");
                    ExpectedDeliveryTimeTRO.SendKeys(Keys.Delete);
                    ExpectedDeliveryTimeTRO.SendKeys(time);
                    WaitMethods.WaitForFieldToBePopulated(ExpectedDeliveryTimeTRO);
                },
                _ => ExpectedDeliveryTimeTRO.GetAttribute("value").Equals(time),
                TimeSpan.FromSeconds(3), 3
                );

            return this;
        }

        public BCOutboundPage4 WriteTimeOnTimeFieldsTRO()
        {
            IList<IWebElement> allDateFields = Driver.FindElements(By.XPath("//input[starts-with(@title,'Type the date in the')]"));

            foreach (var element in allDateFields.Skip(1)) //I Skip first input ( no need to write)
            {
                string date = DateTime.Now.Date.ToString("dd/MM/yyyy");
                WaitMethods.RepeatUntil(
                () =>
                {
                    element.SendKeys(Keys.Control + "a");
                    element.SendKeys(Keys.Delete);
                    element.SendKeys(date);
                    WaitMethods.WaitForFieldToBePopulated(element);
                },
                 _ => element.GetAttribute("value").Equals(date),
                TimeSpan.FromSeconds(3), 3
                );

                IWebElement timeField = element.FindElement(By.XPath(".//following::div[3]/input"));
                string time = DateTime.Now.ToString("HH:mm:ss");

                WaitMethods.RepeatUntil(
                () =>
                {
                    timeField.SendKeys(Keys.Control + "a");
                    timeField.SendKeys(Keys.Delete);
                    timeField.SendKeys(time);
                    WaitMethods.WaitForFieldToBePopulated(timeField);
                },
                _ => timeField.GetAttribute("value").Equals(time),
                TimeSpan.FromSeconds(3), 3
                );
            }
            return this;
        }

        internal BCOutboundPage4 VerifyIGetDifferenceErrorInOutboundAfterCutOff(string DifferenceErrorInOutboundAfterCutOff)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ShouldGetDifferenceErrorInOutboundAfterCutOffXpath));
            Assert.Contains(DifferenceErrorInOutboundAfterCutOff, ShouldGetDifferenceErrorInOutboundAfterCutOff.Text);

            return this;
        }

        public BCOutboundPage4 IGetAnErrorMessage(string errorMessage)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ShouldGetErrorMessageXpath), 10);

            Assert.Contains(errorMessage, ShouldGetErrorMessage.Text);

            return this;
        }

        public BCOutboundPage4 IValidateQueueIsAddedToTheBatch()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(NoQueueLeftInQueueListXpath), 10);

            Assert.Contains("(There is nothing to show in this view)", NoQueueLeftInQueueList.Text);

            return this;
        }

        public BCOutboundPage4 BookAllOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(OrderLineOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(OrderLineOutboundXpath));
            OrderLineOutbound.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(BookAllRecordsOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(BookAllRecordsOutboundXpath));
            BookAllRecordsOutbound.Click();

            return this;
        }

        public BCOutboundPage4 ClickCloseOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickCloseFromBookedSuccesfullOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(ClickCloseFromBookedSuccesfullOutboundXpath));

            ClickCloseFromBookedSuccesfullOutbound.Click();

            return this;
        }

        public BCOutboundPage4 WriteOnTypeFieldOutbounds(string OnTypeFieldOutbound)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ShowMoreInGeneralTwoXpath))
                .WaitForElementToBeClickable(By.XPath(ShowMoreInGeneralTwoXpath));

            ShowMoreInGeneralTwo.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(WriteOnTypeFieldOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(WriteOnTypeFieldOutboundXpath));

            WriteOnTypeFieldOutbound.SendKeys(OnTypeFieldOutbound);
            WriteOnTypeFieldOutbound.SendKeys(Keys.Enter);


            return this;
        }

        public BCOutboundPage4 DeleteTextOnTypeField_Outbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(WriteOnTypeFieldOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(WriteOnTypeFieldOutboundXpath));

            WriteOnTypeFieldOutbound.Clear();

            return this;
        }


        public BCOutboundPage4 BookBackSelectedRecordsOrderLineOutbounds()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ManageOrderOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(ManageOrderOutboundXpath));
            ManageOrderOutbound.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(BookBackSelectedRecordsOrderLineOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(BookBackSelectedRecordsOrderLineOutboundXpath));
            BookBackSelectedRecordsOrderLineOutbound.Click();

            return this;
        }

        public BCOutboundPage4 CompleteBookBackSelectedRecordsOrderLineOutbounds()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ManageReservationOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(ManageReservationOutboundXpath));
            ManageReservationOutbound.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(CompleteBookBackSelectedRecordsOrderLineOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(CompleteBookBackSelectedRecordsOrderLineOutboundXpath));
            CompleteBookBackSelectedRecordsOrderLineOutbound.Click();

            return this;
        }

        public BCOutboundPage4 CutOffOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(BookBackSelectedRecordsOrderLineOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(BookBackSelectedRecordsOrderLineOutboundXpath));
            OrderLineOutbound.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(BookBackSelectedRecordsOrderLineOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(BookBackSelectedRecordsOrderLineOutboundXpath));
            CuttOffOutbound.Click();

            return this;
        }

        public BCOutboundPage4 CopyValueOfOutboundOnOutboundTable()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("//div[@controlname='Outbound Code']//div//span"));
            DataCollection.OutboundCodeFromNewOutbound = Driver.FindElement(By.XPath("//div[@controlname='Outbound Code']//div//span")).Text;

            return this;



            //WaitMethods.WaitForElementToAppear(By.XPath("//span[@aria-label='Outbound Code, ']"));
            //string data = Driver.FindElement(By.XPath("//span[@aria-label='Outbound Code, ']")).Text;
            //data = DataCollection.OutboundCodeFromNewOutbound;

            //// DataCollection.OutboundCodeFromNewOutbound = Driver.FindElement(By.XPath("//span[starts-with(@aria-label,'Outbound Code')]")).Text;

            //return DataCollection.OutboundCodeFromNewOutbound;
            Console.WriteLine(DataCollection.OutboundCodeFromNewOutbound);
        }


        public BCOutboundPage4 CopyValueOfBatchFromBatchTable()
        {

            WaitMethods.WaitForElementToAppear(By.XPath(ProgressBarXPath), 3)
                .WaitForElementToBeGone(By.XPath(ProgressBarXPath));


            WaitMethods.WaitForElementToAppear(By.XPath(BatchNumberQueueGroupListXpath));
            DataCollection.BatchNumberFromBatchTable = Driver.FindElement(By.XPath(BatchNumberQueueGroupListXpath)).Text;

            return this;
        }

        public BCOutboundPage4 CopyValueOfBatchFromBatchCard()
        {

            WaitMethods.WaitForElementToAppear(By.XPath(ProgressBarXPath), 3)
                .WaitForElementToBeGone(By.XPath(ProgressBarXPath));


            WaitMethods.WaitForElementToAppear(By.XPath(BatchNumberFromCardXpath));
            DataCollection.BatchNumberFromBatchCard = Driver.FindElement(By.XPath(BatchNumberFromCardXpath)).Text;

            return this;
        }

        public BCOutboundPage4 SaveAddToBatchNumbers()
        {

            WriteAddToBatchInput.Click();

            WriteAddToBatchInput.SendKeys(Keys.Control + "a");
            WriteAddToBatchInput.SendKeys(Keys.Control + "c");
            DataCollection.AddToBatchNumber = System.Windows.Forms.Clipboard.GetText();


            return this;
        }

        public string CopyValueOfSecondOutboundOnOutboundTable()
        {
            DataCollection.SecondOutboundCode = Driver.FindElement(By.XPath("//div[@class='spa-view spa-normal no-animations shown']//div[@class='multiple-columns-group chrome-desktop-multiple-columns-group']//div[1]//div[1]//span[1]")).Text;

            return DataCollection.SecondOutboundCode;
        }

        public BCOutboundPage4 GoBackFromOutboundPage()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(GoBackFromOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(GoBackFromOutboundXpath));

            GoBackFromOutbound.Click();
            WaitMethods.WaitForElementToBeGone(By.XPath(GoBackFromOutboundXpath));

            return this;
        }

        public BCOutboundPage4 GoBackOutboundPage()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(GoBackOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(GoBackOutboundXpath));

            GoBackOutbound.Click();
            WaitMethods.WaitForElementToBeGone(By.XPath(GoBackOutboundXpath), 10);

            return this;
        }

        public BCOutboundPage4 ClickYesOutboundPage()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickYesOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(ClickYesOutboundXpath));

            ClickYesOutbound.Click();
            return this;
        }

        public BCOutboundPage4 GoBackFromOutboundListPage()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(GoBackFromOutboundListXpath))
                .WaitForElementToBeClickable(By.XPath(GoBackFromOutboundListXpath));

            GoBackFromOutboundList.Click();
            return this;
        }

        public BCOutboundPage4 WriteOnInputForCancelOutbound(string numberInput)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(OnInputForCancelOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(OnInputForCancelOutboundXpath));

            OnInputForCancelOutbound.Click();
            OnInputForCancelOutbound.SendKeys(numberInput);
            NumberDivClick.Click();

            return this;
        }

        public BCOutboundPage4 nIEnterOutboundValueOnInputFieldFilter_QueueGroupList(string p0)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(InputFieldFilterQueueGroupListXpath))
                .WaitForElementToBeClickable(By.XPath(InputFieldFilterQueueGroupListXpath));

            InputFieldFilterQueueGroupList.SendKeys("*" + p0 + "*" + Keys.Enter);

            return this;
        }

        public BCOutboundPage4 EnterBatchValueOnInputFieldFilter_QueueugroupList(string p0)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(InputBatchOnQueuegroupListXpath))
                .WaitForElementToBeClickable(By.XPath(InputBatchOnQueuegroupListXpath));

            InputBatchOnQueuegroupList.SendKeys(p0 + Keys.Enter);

            return this;
        }

        public BCOutboundPage4 EnterBatchNumberValueOnInputField(string p0)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(InputBatchNumberValueXpath))
                .WaitForElementToBeClickable(By.XPath(InputBatchNumberValueXpath));

            InputBatchNumberValue.SendKeys(p0 + Keys.Enter);

            return this;
        }

        public BCOutboundPage4 IEnterCustomerReferenceValueOnInputFieldFilter(string p0)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(InputFieldCustomerReferenceXpath))
                .WaitForElementToBeClickable(By.XPath(InputFieldCustomerReferenceXpath));

            InputFieldCustomerReference.SendKeys("*" + p0 + "*" + Keys.Enter);

            return this;
        }

        public BCOutboundPage4 WriteOnFilterQueueGroupList(string inputText)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(QueueGroupFilterInputXpath))
                .WaitForElementToBeClickable(By.XPath(QueueGroupFilterInputXpath));

            QueueGroupFilterInput.SendKeys("Outbound" + Keys.Enter);

            return this;
        }

        public BCOutboundPage4 CopyFileToFolder()
        {
            const string fileName = "EDI0163184.txt";
            const string sourcePath = "C:\\Users\\Aliu\\Source\\Repos\\test-selenium-cgi-businesscentral-navnext1\\ITG.CGI.NavNext.UITests\\TestData";
            const string targetPath = "\\\\S-be-ki-abrain2\\EDIFILES TEST\\SkatePro\\In";
            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);

            File.Copy(sourceFile, destFile, true);
            return this;
        }

        public BCOutboundPage4 RunPOWEREDIManagerFunction()
        {

            RunPOWEREDIManager.Click();

            return this;
        }

        public BCOutboundPage4 MessageLogReceivingButton()
        {

            MessageLogReceiving.Click();
            return this;
        }

        public BCOutboundPage4 ShowFilterPaneForEDIMessageLogList()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ShowFilterPaneForEDIMessagesXpath));

            ShowFilterPaneForEDIMessages.Click();

            FilterInNAS.Click();
            return this;
        }

        public BCOutboundPage4 WriteFilterKTNEDIMsgLogList(string firstFilter, string secondFilter)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(EnterFirstFilterEDIMessageXpath));
            EnterFirstFilterEDIMessage.SendKeys(firstFilter);
            EnterFirstFilterEDIMessage.SendKeys(Keys.Enter);
            WaitMethods.WaitForElementToBePresent(By.XPath(EnterSecondFilterEDIMessageXPath));
            EnterSecondFilterEDIMessage.Click();
            EnterSecondFilterEDIMessage.SendKeys(secondFilter);
            EnterSecondFilterEDIMessage.SendKeys(Keys.Enter);

            return this;
        }

        public BCOutboundPage4 SelectNotProcessedLineEDIMeessageLogReceiving()
        {
            WaitMethods.WaitForAllElementsToBeVisible(By.XPath(NotProcessedEDIMessageLineXpath));
            NotProcessedEDIMessageLine.Click();
            return this;
        }

        public BCOutboundPage4 EnterUniqueNumberCustomRef2EDIMessageLogList()
        {
            var uniqueNumber = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString();
            WaitMethods.WaitForElementToBePresent(By.XPath(CustomerReference2ValueEDIMessageXpath));
            CustomerReference2ValueEDIMessage.Click();

            EnterCustomerReference2ValueEDIMessage.SendKeys(uniqueNumber);

            EnterCustomerReference2ValueEDIMessage.SendKeys(Keys.Enter);
            return this;
        }

        public BCOutboundPage4 GoBackFromEDIMessageLogMainPage()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(GoBackFromEDIMessageLogMainXpath));
            GoBackFromEDIMessageLogMain.Click();
            return this;
        }

        public BCOutboundPage4 GoBackFromEDIMessageLogListPage()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(GoBackFromEDIMessageLogListXpath));
            GoBackFromEDIMessageLogList.Click();
            return this;
        }

        public BCOutboundPage4 EDIDropdownMenusFromACTIONS()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(EDIDropdownMenuFromACTIONSXpath));

            EDIDropdownMenuFromACTIONS.Click();
            return this;
        }

        public BCOutboundPage4 ClearCustomerReferenceValueEDIMessageLogList()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(CustomerReference2ValueEDIMessageXpath));
            CustomerReference2ValueEDIMessage.Click();
            WaitMethods.WaitForElementToBePresent(By.XPath(EnterCustomerReference2ValueEDIMessageXpath));
            EnterCustomerReference2ValueEDIMessage.Clear();

            EnterCustomerReference2ValueEDIMessage.SendKeys(Keys.Enter);
            return this;
        }

        public BCOutboundPage4 ClearTransporterValueOnEDIMessageLogMain()
        {
            TransportValueEDIMessage.Click();

            EnterValueTransportEDIMessage.Clear();

            EnterValueTransportEDIMessage.SendKeys(Keys.Enter);
            return this;
        }

        public BCOutboundPage4 EnterANonExistingTransporterOnEDIMessageLogMain(string Transport)
        {

            TransportValueEDIMessage.Click();

            EnterValueTransportEDIMessage.SendKeys(Transport);

            EnterValueTransportEDIMessage.SendKeys(Keys.Enter);
            return this;
        }

        public BCOutboundPage4 EnterOrderType(string OrderType)
        {
            OrderTypeValueEDIMessage.Click();

            EnterCustomerReference2ValueEDIMessage.SendKeys(OrderType);

            EnterCustomerReference2ValueEDIMessage.SendKeys(Keys.Enter);
            return this;
        }

        public BCOutboundPage4 ClearOrderTypeFromEdiMessagLogList()
        {

            OrderTypeValueEDIMessage.Click();

            EnterCustomerReference2ValueEDIMessage.Clear();

            EnterCustomerReference2ValueEDIMessage.SendKeys(Keys.Enter);
            return this;
        }

        public BCOutboundPage4 EnterFilteronQueueGroupList(string Filter)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(EnterFilterQueueGroupListXpath));

            EnterFilterQueueGroupList.Click();
            EnterFilterQueueGroupList.SendKeys(Filter);

            EnterFilterQueueGroupList.SendKeys(Keys.Enter);
            return this;
        }

        public BCOutboundPage4 EnterCopiedOutboundInputFilterQueueGroupList()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(InputFieldFilterQueueGroupListXpath))
                .WaitForElementToBePresent(By.XPath(InputFieldFilterQueueGroupListXpath));

            InputFieldFilterQueueGroupList.SendKeys("*" + DataCollection.OutboundCodeFromNewOutbound + "*" + Keys.Enter);

            return this;
        }

        public BCOutboundPage4 EnterCopiedBatchInputFilterQueueGroupList()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(InputFieldFilterBatchNumberListXpath))
                .WaitForElementToBePresent(By.XPath(InputFieldFilterBatchNumberListXpath));

            InputFieldFilterBatchNumberList.SendKeys(DataCollection.BatchNumberFromBatchTable + Keys.Enter);

            return this;
        }

        public BCOutboundPage4 EnterCopiedBatchInputFilterQueueGroupListFromCard()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(InputFieldFilterBatchNumberListXpath))
                .WaitForElementToBePresent(By.XPath(InputFieldFilterBatchNumberListXpath));

            InputFieldFilterBatchNumberList.SendKeys(DataCollection.BatchNumberFromBatchCard + Keys.Enter);

            return this;
        }

        public BCOutboundPage4 EnterCopiedOutboundValueInSearchBoxTROUnlink()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(SearchFieldInTROUnlinkXpath))
                .WaitForElementToBeClickable(By.XPath(SearchFieldInTROUnlinkXpath));

            WaitMethods.WaitForPageToBeReady();

            WaitMethods.WaitUntilElementExists(By.XPath(SearchFieldInTROUnlinkXpath), 10);

            SearchFieldInTROUnlink.Click();

            SearchFieldInTROUnlink.SendKeys(DataCollection.OutboundCodeFromNewOutbound + Keys.Enter + Keys.Tab + Keys.Tab);

            WaitMethods.WaitForPageToBeReady();

            WaitMethods.WaitForElementToAppear(By.XPath("//div[starts-with(@title,'Edit')]"))
               .WaitForElementToBeClickable(By.XPath("//div[starts-with(@title,'Edit')]"));

            return this;
        }
        public BCOutboundPage4 ClickYesInThePopUpMessagesForCompleteBookBack()
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
        public BCOutboundPage4 EnterValueOnInputFieldFilter(string Filter)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(InputFieldFilterQueueGroupListXpath));

            InputFieldFilterQueueGroupList.SendKeys(Filter);

            InputFieldFilterQueueGroupList.SendKeys(Keys.Tab);

            WaitMethods.WaitForPageToBeReady();

            return this;
        }

        public BCOutboundPage4 CopyTheValueOfNoFromOutboundTable()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("//td[@controlname='Queue No']"));
            DataCollection.NofromOutbound = Driver.FindElement(By.XPath("//td[@controlname='Queue No']")).Text;

            return this;


        }




        public BCOutboundPage4 EnterQueueNumberCopiedValueOnPOWERTourBuildingLogivation()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(InputQueueNumberXpath))
                .WaitForElementToBePresent(By.XPath(InputQueueNumberXpath));

            InputQueueNumber.SendKeys(DataCollection.NofromOutbound);

            WaitMethods.WaitForElementToBePresent(By.XPath(ClickOKButtonOfPopupMainPageXpath));
            ClickOKButtonOfPopupMainPage.Click();



            System.Threading.Thread.Sleep(2000);




            return this;
        }



        public BCOutboundPage4 ChoseLocationTourBuilding()
        {
            System.Threading.Thread.Sleep(2000);
            //WaitMethods.WaitForElementToBePresent(By.XPath(QueueToUploadTourBuildingXpath));
            ////.WaitForElementToBePresent(By.XPath(QueueToUploadTourBuildingXpath))
            ////.WaitForElementToBeClickable(By.XPath(QueueToUploadTourBuildingXpath))
            //QueueToUploadTourBuilding.Click();


            new Actions(Driver).SendKeys(Keys.Enter).Perform();
            System.Threading.Thread.Sleep(3000);
            return this;
        }




        public BCOutboundPage4 SaveCsvFile()
        {



            System.Diagnostics.Process.Start(@"\\S-be-ki-adesc\EDIFILES_TEST\TestTeam\QueueNO.csv");


            System.Threading.Thread.Sleep(5000);

            System.Windows.Forms.SendKeys.SendWait("^(s)");


            System.Threading.Thread.Sleep(5000);







            return this;
        }




        public BCOutboundPage4 CreateCvsFileAutomation()
        {

            string data = "Queue" + ";" + "Holder unit;" + "Holder QTY;" + "Holder ID;" + "Pallet ID;" + "Tour ID";
            string data2 = "22748105" + ";" + "A-BOX;" + "1;" + "1;" + "0;" + "0";
            //string data3 = "\n";
            string filePath = "\\\\S-be-ki-abrain2\\EDIFILES_TEST\\Adeo\\TourBuilding\\QueueNO.csv";
            //string filePath = "\\\\itglo.net\\public\\EMEA\\BE-KI\\DataShares\\Share Analyze Consumers\\21 TEST TEAM\\Tomislav\\QueueNO.csv";
            string data4 = DataCollection.NofromOutbound + ";" + "A-BOX;" + "1;" + "1;" + "0;" + "0";

            StringBuilder outString = new StringBuilder();



            outString.AppendLine(data);
            // outString.AppendLine(data3);
            outString.AppendLine(data2);
            // outString.Replace(data2, data4);
            outString.Replace(data2, data4);


            File.WriteAllText(filePath, outString.ToString());



            //System.Windows.Forms.SendKeys.SendWait("^(s)");
            // data2[0] = DataCollection.NofromOutbound;

            //var result = string.Empty;
            //foreach (var item in data2)
            //{
            //    result += item;
            //}

            //File.AppendAllText(filePath, outString.ToString());
            //  string data4  = "22747896";
            // data4.Replace(DataCollection.NofromOutbound, "22747896");



            //using (StreamWriter swriter = new StreamWriter(filePath))
            //{
            //    swriter.Write(outString.ToString());

            //}








            return this;
        }



        public BCOutboundPage4 SelectAlredyCreatedCvsFile()
        {
            System.Threading.Thread.Sleep(3000);
            System.Windows.Forms.SendKeys.SendWait(@"\\S-be-ki-abrain2\EDIFILES_TEST\Adeo\TourBuilding\QueueNO.csv");
            //System.Windows.Forms.SendKeys.SendWait(@"\\itglo.net\public\EMEA\BE-KI\DataShares\Share Analyze Consumers\21 TEST TEAM\Tomislav");
            System.Threading.Thread.Sleep(5000);
            System.Windows.Forms.SendKeys.SendWait(@"{ENTER}");
            System.Threading.Thread.Sleep(2000);
            //System.Windows.Forms.SendKeys.SendWait(@"QueueNO.csv");
            //System.Threading.Thread.Sleep(5000);
            //System.Windows.Forms.SendKeys.SendWait(@"{ENTER}");




            System.Threading.Thread.Sleep(5000);
            return this;




        }


        public BCOutboundPage4 CreateCSVFileTomce()
        {

            StringBuilder stringb = new StringBuilder();

            stringb.Append("Queue Holderunit HolderQTY HolderID PalletID Tour ID");
            stringb.Append("\n");
            stringb.Append("22748444 A-BOX 1 1 0 0");

            string convertedString = stringb.ToString();
            string result = convertedString.Replace(' ', ';');

            stringb.Replace(stringb.ToString(), result);

            string filePath = "\\\\S-be-ki-adesc\\EDIFILES_TEST\\TestTeam\\QueueNO.csv";



            //stringbuilder to physical csv file
            using (StreamWriter swriter = new StreamWriter(filePath))
            {
                swriter.Write(stringb.ToString());
            }


            //System.Windows.Forms.SaveFileDialog savefile = new System.Windows.Forms.SaveFileDialog();
            //// set a default file name
            //savefile.FileName = "\\\\S-be-ki-adesc\\EDIFILES_TEST\\TestTeam\\QueueNO.csv";
            //// set filters - this can be done in properties as well
            //savefile.Filter = "Custom Files (*.txt)|*.csv|xml|*.*";

            //if (savefile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    using (StreamWriter sw = new StreamWriter(savefile.FileName)) ;
            //        //sw.WriteLine("Hello World!");
            //}



            return this;
        }


    }
}
