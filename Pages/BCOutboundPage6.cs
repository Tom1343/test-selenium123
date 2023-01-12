using CGI_OUTBOUND_BC_Scenarios.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using Xunit;

namespace CGI_OUTBOUND_BC_Scenarios.OUTBOUND.Pages
{
    [Binding]
    public class BCOutboundPage6 : Page
    {
        private WaitMethods WaitMethods => new WaitMethods(Driver);
        public BCOutboundPage6(IWebDriver driver) : base(driver) { }

        public BCOutboundPage6 EnterQtyToBookBack(string QtyToBookBack)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(QtyToBookBackOutboundXpath))
                    .WaitForElementToBeClickable(By.XPath(QtyToBookBackOutboundXpath));

            QtyToBookBackOutbound.SendKeys(QtyToBookBack);
            OkAfterTodaysDate.Click();

            return this;
        }

        public BCOutboundPage6 ClickOKButtonOutboundCard()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickOKButtonOutboundXpath), 10);

            if (SetMethods.IsElementPresent(Driver, By.XPath(ClickOKButtonOutboundXpath)))
            {
                WaitMethods.WaitForElementToBeClickable(By.XPath(ClickOKButtonOutboundXpath));
                ClickOKButtonOutbound.Click();
            }

            return this;
        }

        public BCOutboundPage6 ClickOKButtonOutboundCardCalculate()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickOKButtonOutboundCalculateBatchXpath), 10);

            if (SetMethods.IsElementPresent(Driver, By.XPath(ClickOKButtonOutboundCalculateBatchXpath)))
            {
                WaitMethods.WaitForElementToBeClickable(By.XPath(ClickOKButtonOutboundCalculateBatchXpath));
                ClickOKButtonOutboundCalculateBatch.Click();
            }

            return this;
        }

        public BCOutboundPage6 ClickBackButtonOutboundCard()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(BackButtonOutboundCardXpath))
                    .WaitForElementToBeClickable(By.XPath(BackButtonOutboundCardXpath));
            BackButtonOutboundCard.Click();
            return this;
        }

        public BCOutboundPage6 EnterTransporterOnOutbound(string Transporter)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EnterTransporterOutboundXpath))
                    .WaitForElementToBeClickable(By.XPath(EnterTransporterOutboundXpath));

            EnterTransporterOutbound.SendKeys(Transporter);
            EnterTransporterOutbound.SendKeys(Keys.Tab);

            return this;
        }

        public BCOutboundPage6 IEnterBuyerOnOutboundCard(string Transporter)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(IEnterBuyerOnOutboundXpath))
                    .WaitForElementToBeClickable(By.XPath(IEnterBuyerOnOutboundXpath));

            WaitMethods.RepeatUntil(
            () =>
            {
                IEnterBuyerOnOutbound.SendKeys(Transporter);
                IEnterBuyerOnOutbound.SendKeys(Keys.Tab);
            },
            _ => IEnterBuyerOnOutbound.GetAttribute("value").Equals(Transporter),
            TimeSpan.FromSeconds(2), 5
            );

            return this;
        }

        public BCOutboundPage6 EnterTransporterOnGeneralOutboundCard(string TransporterOnGeneralOutbound)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EnterTransporterOnGeneralOutboundXpath))
                    .WaitForElementToBeClickable(By.XPath(EnterTransporterOnGeneralOutboundXpath));

            EnterTransporterOnGeneralOutbound.Click();
            EnterTransporterOnGeneralOutbound.SendKeys(TransporterOnGeneralOutbound);
            EnterTransporterOnGeneralOutbound.SendKeys(Keys.Tab);

            return this;
        }

        public BCOutboundPage6 MoreOptionsQueueGroup()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(MoreOptionsOnQueueGroupXpath))
                    .WaitForElementToBeClickable(By.XPath(MoreOptionsOnQueueGroupXpath));


            MoreOptionsOnQueueGroup.Click();
            WaitMethods.WaitForElementToAppear(By.XPath(MoreOptionsWritenOnQueueGroupXpath))
                     .WaitForElementToBeClickable(By.XPath(MoreOptionsWritenOnQueueGroupXpath));

            MoreOptionsWritenOnQueueGroup.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(MoreOptionsOnQueueGroupXpath))
                    .WaitForElementToBeClickable(By.XPath(MoreOptionsOnQueueGroupXpath));

            MoreOptionsOnQueueGroup.Click();
            return this;
        }

        public BCOutboundPage6 MoreOptionsOnQueueGroupSecondOpen()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(MoreOptionsOnQueueGroupXpath))
                    .WaitForElementToBeClickable(By.XPath(MoreOptionsOnQueueGroupXpath));

            MoreOptionsOnQueueGroup.Click();

            return this;
        }

        public BCOutboundPage6 MoreOptionsInQueueGroupList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(MoreOptionsInQueueGroupListsXpath))
                    .WaitForElementToBeClickable(By.XPath(MoreOptionsInQueueGroupListsXpath));

            MoreOptionsInQueueGroupLists.Click();

            return this;
        }

        public BCOutboundPage6 MoreOptionsOnQueueGroupSecondTime()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(MoreOptionsOnQueueGroupXpath))
                    .WaitForElementToBeClickable(By.XPath(MoreOptionsOnQueueGroupXpath));

            MoreOptionsOnQueueGroup.Click();

            return this;
        }

        public BCOutboundPage6 MoreOptionsOnQueueGroupTRO()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(MoreOptionsOnQueueGroup_TROXpath));
            MoreOptionsOnQueueGroup_TRO.Click();

            return this;
        }

        public BCOutboundPage6 ActionsQueueGroups()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ActionsQueueGroupXpath));
            ActionsQueueGroup.Click();

            return this;
        }

        public BCOutboundPage6 LinkToATransportQueueGroupCard()
        {

            LinkToATransportQueueGroup.Click();
            OkAfterTodaysDate.Click();

            return this;
        }

        public BCOutboundPage6 GenerateMultiOrderQueueGroup()
        {
            WaitMethods.WaitForElementToBeClickable(By.XPath(GenerateMultiOrderXpath));

            GenerateMultiOrder.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(ProgressBarXPath), 15)
            .WaitForElementToBeGone(By.XPath(ProgressBarXPath));

            return this;
        }

        public BCOutboundPage6 EnterValueOnInputFieldFilterQueueGroupList(string Value)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(InputFieldFilterQueueGroupListXpath));

            InputFieldFilterQueueGroupList.SendKeys(Value);

            return this;
        }

        public BCOutboundPage6 SearchButtonMainPages()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(SearchButtonMainPageXpath));
            SearchButtonMainPage.Click();

            return this;
        }

        public BCOutboundPage6 IClickRunButtonInNasSimulator()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(IClickRunInNasSimulatorXpath))
                 .WaitForElementToBeClickable(By.XPath(IClickRunInNasSimulatorXpath));
            IClickRunInNasSimulator.Click();

            return this;
        }

        public BCOutboundPage6 IClickRunButtonInNasSimulatorADEO()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(IClickRunInNasSimulatorADEOXpath))
                 .WaitForElementToBeClickable(By.XPath(IClickRunInNasSimulatorADEOXpath));

            WaitMethods.WaitForElementToAppear(By.XPath(ProgressBarXPath), 5)
            .WaitForElementToBeGone(By.XPath(ProgressBarXPath));

            IClickRunInNasSimulatorADEO.Click();

            return this;
        }

        public BCOutboundPage6 ISearchOnSearchNavBar(string p0)
        {

            WaitMethods.WaitForElementToAppear(By.XPath(InsertSearchOptionOutboundListXpath))
                    .WaitForElementToBeClickable(By.XPath(InsertSearchOptionOutboundListXpath));

                InsertSearchOptionOutboundList.SendKeys(p0);
            

            return this;
        }

        public BCOutboundPage6 WriteFilterOnSearchMainPage(string Filter)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(MaximixeFormForInputFieldXpath));

            MaximixeFormForInputField.Click();

            SearchInputMainPage.SendKeys(Filter + Keys.Enter + Keys.Enter);

            LocationsFromSearchMainMenu.Click();

            return this;
        }

        public BCOutboundPage6 EnterLocationSearchLocationList(string Location)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ClickSearchLocationXpath));

            ClickSearchLocation.Click();

            InsertSearchLocationList.SendKeys(Location);
            DataCollection.DefaultLocation = Location;
            return this;
        }

        public string CopyCheckDigitLocationCard()
        {
            DataCollection.CheckDigit = Driver.FindElement(By.XPath("//td[14]//span[1]")).Text;

            return DataCollection.CheckDigit;
        }

        public BCOutboundPage6 GoBackFromLocationCardPage()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(GoBackFromLocationCardXpath));
            GoBackFromLocationCard.Click();
            return this;
        }

        public BCOutboundPage6 EnterDefaultLocationInputFieldFilterQueueGroupList()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(InputFieldFilterQueueGroupListXpath));

            InputFieldFilterQueueGroupList.SendKeys(DataCollection.DefaultLocation);
            FirstLineInCodeInput.Click();

            return this;
        }

        public BCOutboundPage6 SelectMyFirstLine_CodeQueGroupOutbound()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(FirstLineInCodeInputXpath));

            FirstLineInCodeInput.Click();

            return this;
        }

        public BCOutboundPage6 ClickShowFilterPane_QueueGroupOutbound()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ShowFilterPane_QueueGroupOutboundXpath));

            ShowFilterPane_QueueGroupOutbound.Click();

            return this;
        }

        public BCOutboundPage6 ClickFilterButton_QueueGroup()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(FilterButton_QueueGroupXpath));

            FilterButton_QueueGroup.Click();

            return this;
        }

        public string CopyUnitLocationCardQueueGroupList()
        {
            DataCollection.Text1 = Driver.FindElement(By.XPath("//div[@class='edit-container thm-cont-g0-bgcolor-1']//span[@class='stringcontrol-read value thm-cont-u1-font-size-2--maxflat thm-cont-u1-font-stack-2--maxflat thm-cont-u1-color-2--maxflat thm-cont-g2-bgcolor-2 thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus']")).Text;

            return DataCollection.Text1;
        }

        public BCOutboundPage6 ClickShowMoreOptionQueueGroupList()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ShowMoreOptionsInQueueGroupXpath));

            ShowMoreOptionsInQueueGroup.Click();
            return this;
        }

        public BCOutboundPage6 ClickAQueueOnQueueGroupList()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(QueueOnQueueGroupXpath));

            QueueOnQueueGroup.Click();
            return this;
        }

        public BCOutboundPage6 ClickOnATTLQueueAndUnloadMasterHolders()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(TTLQueuesButtonXpath));

            TTLQueuesButton.Click();

            WaitMethods.WaitForElementToBePresent(By.XPath(TTLQueuesQueueInOutboundXpath));

            TTLQueuesQueueInOutbound.Click();

            WaitMethods.WaitForElementToBePresent(By.XPath(UnloadSelectedMasterHoldersXpath));

            UnloadSelectedMasterHolders.Click();
            return this;
        }

        public BCOutboundPage6 ClickBookBackSelectedRecordsOnOpenedCard_QueueGroupList()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(BookBackSelectedRecordsOnOpenedCard_QueueGroupListXpath));
            BookBackSelectedRecordsOnOpenedCard_QueueGroupList.Click();

            return this;
        }

        public BCOutboundPage6 ClickYesInThePopUpMessageOutbound()
        {
            WaitMethods.WaitForPageToBeReady();

            WaitMethods.WaitForElementToAppear(By.XPath(ClickYESInPopupMessageOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(ClickYESInPopupMessageOutboundXpath));

            ClickYESInPopupMessageOutbound.Click();

            WaitMethods.WaitForPageToBeReady();
            WaitMethods.WaitForElementToBeGone(By.XPath(ClickYESInPopupMessageOutboundXpath));

            return this;
            //WaitMethods.WaitForElementToAppear(By.XPath("//div[@class='ms-nav-actionbar-container has-actions']//button[1][not(@data-is-focusable)]"))
            //    .WaitForElementToBeClickable(By.XPath("//div[@class='ms-nav-actionbar-container has-actions']//button[1][not(@data-is-focusable)]"));

            //Driver.FindElement(By.XPath("//div[@class='ms-nav-actionbar-container has-actions']//button[1][not(@data-is-focusable)]")).Click();

            //return this;
        }

        public BCOutboundPage6 ClickCancelToCancelTheUnlinkings()
        {
            WaitMethods.WaitForPageToBeReady();

            WaitMethods.WaitForElementToAppear(By.XPath(ProgressBarXPath), 3)
            .WaitForElementToBeGone(By.XPath(ProgressBarXPath));

            WaitMethods.WaitForElementToAppear(By.XPath(CancelToCancelTheUnlinkingXpath),5)
                .WaitForElementToBeClickable(By.XPath(CancelToCancelTheUnlinkingXpath));

            CancelToCancelTheUnlinking.Click();

            return this;
        }

        public BCOutboundPage6 ClickNoStockOptionToUnlink()
        {
            WaitMethods.WaitForPageToBeReady();

            WaitMethods.WaitForElementToAppear(By.XPath(ProgressBarXPath), 2)
            .WaitForElementToBeGone(By.XPath(ProgressBarXPath));

            WaitMethods.WaitForElementToAppear(By.XPath(NoStockOptionToUnlinkXpath), 5)
                .WaitForElementToBeClickable(By.XPath(NoStockOptionToUnlinkXpath));

            NoStockOptionToUnlink.Click();

            return this;
        }
        public BCOutboundPage6 IShouldGetStatusOfTheQueue(string StatusOfQueue)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(StatusOfAQueueXpath));
            Assert.Contains(StatusOfQueue, StatusOfAQueue.Text);

            return this;
        }

        public BCOutboundPage6 VerifyIGetPopupMessageAndClickYes(string PopupMessage)
        {
            WaitMethods.WaitForPageToBeReady();

            WaitMethods.WaitForElementToAppear(By.XPath(ShouldGetPopupMessageXpath));
            Assert.Contains(PopupMessage, ShouldGetPopupMessage.Text);

            WaitMethods.WaitForPageToBeReady();

            return this;
        }
        public BCOutboundPage6 VerifyIGetOneMorePopupMessageAndClickYes(string PopupMessage)
        {
            WaitMethods.WaitForPageToBeReady();

            WaitMethods.WaitForElementToAppear(By.XPath(ShouldGetPopupMessageXpath));

            Assert.Contains(PopupMessage, ShouldGetPopupMessage.Text);

            WaitMethods.WaitForPageToBeReady();

            return this;
        }
        public BCOutboundPage6 PackListBeingPrinterOKButton()
        {
            IWebElement iframe = Driver.FindElement(By.XPath("//iframe[@title='POWERModuleError']"));
            Driver.SwitchTo().Frame(iframe);
            WaitMethods.WaitForElementToAppear(By.XPath(PackListBeingPrinterOKButtonXpath));
            Driver.FindElement(By.XPath("//button[@id='btnOK']")).Click();
            return this;
        }

        public BCOutboundPage6 ClearFilterOutbound()
        {
            IList<IWebElement> buttons = Driver.FindElements(By.XPath("//button[@title='Clear this filter']"));

            foreach (var element in buttons.Skip(1))
            {
                element.Click();
            }

            return this;
        }

        public BCOutboundPage6 ClearFilterInStatusOutboundOrder()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(IClearFilterInStatusOutboundOrderXpath))
                .WaitForElementToBeClickable(By.XPath(IClearFilterInStatusOutboundOrderXpath));

            IClearFilterInStatusOutboundOrder.Click();

            return this;
        }
        public BCOutboundPage6 ValidateErrorMessagePowerQueueGroupList(string p0)
        {

            WaitMethods.WaitForPageToBeReady();

            WaitMethods.WaitForElementToAppear(By.XPath(ErrorMultiOrderQGXpath));
            Assert.Contains(p0, ErrorMultiOrderQG.Text);

            WaitMethods.WaitForPageToBeReady();

            

            return this;
        }

        public BCOutboundPage6 EnterTROValueOnInputFieldFilterQueueGroupList(string p0)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(InputFieldFilterQueueGroupListXpath));

            InputFieldFilterQueueGroupList.SendKeys(p0 + "-" + DataCollection.PickwaveCode);

            clickFirstLineFilterQueueGroupList.Click();

            return this;
        }

        public BCOutboundPage6 ClickMoreOptionsOnHolderStockSelection()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(HolderSelectionHeaderXpath));
            HolderSelectionHeader.Click();

            MoreOptionsOnHolderStockSelection.Click();

            return this;
        }

        public BCOutboundPage6 IClickActionsOutbound()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ActionsXpath));
            Actions.Click();
            return this;
        }

        public BCOutboundPage6 ClickHolderDropdown()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(HolderDropdownXpath));
            HolderDropdown.Click();

            return this;
        }
        public BCOutboundPage6 ClickPrintEmptyLabelOutbound()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(PrintEmptyLabelOutboundXpath));
            PrintEmptyLabelOutbound.Click();

            return this;
        }

        public BCOutboundPage6 SaveMyCreatedHolderOutbound()
        {

            BarcodeNumberINStock.Click();

            BarcodeNumberINStock.SendKeys(Keys.Control + "c");

            DataCollection.mySavedCreatedStockHolder = System.Windows.Forms.Clipboard.GetText();
            return this;
        }

        public BCOutboundPage6 ClickNasSimulatorFromKTNSchedulerSetup()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(SchedulerSetupMainMenuXpath));
            SchedulerSetupMainMenu.Click();

            WaitMethods.WaitForElementToBePresent(By.XPath(NasSimulatorFromSchedulerXpath));
            NasSimulatorFromScheduler.Click();
            return this;
        }

        public BCOutboundPage6 EnterSearchNasSimulator(string searchElement)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(SearchButtonNasSimulatorXpath));
            SearchButtonNasSimulator.Click();

            InputSearchButtonNasSimulator.SendKeys(searchElement + Keys.Tab);
            return this;
        }

        public BCOutboundPage6 SaveMyCreatedPickHolderOutbound()
        {
            PickLineSelect.Click();

            BarcodeNumberINPick.SendKeys(Keys.Control + "c");


            DataCollection.mySavedCreatedPickHolder = System.Windows.Forms.Clipboard.GetText();
            return this;
        }

        public BCOutboundPage6 GoBackToPowerHolderTypeList()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(GoBackPowerHolderTypeListXpath));

            GoBackPowerHolderTypeList.Click();
            return this;
        }

        public BCOutboundPage6 GoBackToPowerHolderStockSelection()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(GoBackPowerHolderStockSelectionXpath));

            GoBackPowerHolderStockSelection.Click();
            return this;
        }

        public BCOutboundPage6 BookBackSelectedRecords()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ClickBookBackSelectedRecordsOnQueueGroupXpath));

            ClickBookBackSelectedRecordsOnQueueGroup.Click();

            return this;
        }

        public void SetFillOnlineOrderNumber(string value)
        {
            FillOnlineOrderNumber.Click();

            FillOnlineOrderNumber.SendKeys(value);
        }

        public BCOutboundPage6 IEnterTrailerPlateNo()
        {
            DataCollection.UniqueTrailerNoTRO = DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString();
            WaitMethods.WaitForElementToBePresent(By.XPath(EnterTrailerPlateNoXpath));
            EnterTrailerPlateNo.Click();

            EnterTrailerPlateNo.SendKeys(DataCollection.UniqueTrailerNoTRO);

            EnterTrailerPlateNo.SendKeys(Keys.Tab);

            return this;
        }

        public BCOutboundPage6 WriteFilterOnQueueGroupList(string filter)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(FirstFilterOnQueueGroupXpath));

            FirstFilterOnQueueGroup.SendKeys(filter + Keys.Tab);

            return this;
        }

        public BCOutboundPage6 IExpandShowMoreOptionsInQueueGroup()
        {
            WaitMethods.WaitForPageToBeReady();
            WaitMethods.WaitForElementToBePresent(By.XPath(ExpandShowMoreOptionsInQueueGroupXpath));

            ExpandShowMoreOptionsInQueueGroup.Click();

            WaitMethods.WaitForElementToBePresent(By.XPath(SelectMoreButtonXpath))
                .WaitForElementToBeClickable(By.XPath(SelectMoreButtonXpath));

            SelectMoreButton.Click();
            return this;
        }

        public BCOutboundPage6 ISelectTheSecondRowForTheSecondQueue()
        {
            WaitMethods.WaitForPageToBeReady();
            WaitMethods.WaitForElementToBePresent(By.XPath(SelectSecondRowForSecondQueueXpath));

            SelectSecondRowForSecondQueue.Click();

            return this;
        }

        public BCOutboundPage6 EnterOutboundOnSearchOutboundList(string filter)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(WriteSearchOutboundCodeXpath));

            WriteSearchOutboundCode.SendKeys(filter + Keys.Tab);

            return this;
        }


        public BCOutboundPage6 AddFilterForEDIMessagesLogList(string filterEDI)
        {

            Actions action = new Actions(Driver);
            action
                .MoveToElement(AddFilterForEDIMessageLogList)
                .Perform();
            action
                .Click()
                .Build()
                .Perform();
            AddFilterForEDIMessageLogList.SendKeys(filterEDI);
            AddFilterForEDIMessageLogList.SendKeys(Keys.Enter);
            return this;
        }

        public BCOutboundPage6 EnterSubfilters(string subfilter)
        {

            Actions action = new Actions(Driver);
            action
                .MoveToElement(EnterSubfilter)
                .Perform();
            action
                .Click()
                .Build()
                .Perform();
            EnterSubfilter.SendKeys(subfilter);
            EnterSubfilter.SendKeys(Keys.Enter);
            return this;
        }

        public BCOutboundPage6 ClickFilterInButtonOnEDIMessageLogList()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(FilterInNASXpath));
            FilterInNAS.Click();

            return this;
        }

        public BCOutboundPage6 AddSecondFilterInEDIMessageLogList(string secondFilter)
        {

            AddSecondFilterForEDIMessageLogList.SendKeys(secondFilter);
            AddSecondFilterForEDIMessageLogList.SendKeys(Keys.Enter);
            return this;
        }

        public BCOutboundPage6 VerifyTheLocationFromIsEmpty()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("(//div[@class='freeze-pane-scrollbar-div'])[4]"));
            IWebElement scrollArea = Driver.FindElement(By.XPath("(//div[@class='freeze-pane-scrollbar-div'])[4]"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].scrollLeft += 2000;", scrollArea);

            WaitMethods.WaitForElementToAppear(By.XPath("//td[@controlname='codLocationFrom']"))
                   .WaitForElementToBePresent(By.XPath("//td[@controlname='codLocationFrom']"));

            return this;
        }

        public BCOutboundPage6 HoverEDIDropdownsMenuFromACTIONS()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("//div[@data-columns-container='true']"))
                    .WaitForElementToBeClickable(By.XPath(EDIDropdownMenuFromACTIONSXpath));

            WaitMethods.RepeatUntil(
            () => HoverEDIDropdownMenuFromACTIONS.Click(),
            _ => Driver.FindElements(By.XPath("//div[contains(@class,'ContextualMenu')]")).Count > 0,
            TimeSpan.FromSeconds(2), 5
            );

            return this;
        }

        public BCOutboundPage6 ClickMessageLogSendings()
        {
            System.Threading.Thread.Sleep(5000);
            //WaitMethods.WaitForElementToBePresent(By.XPath("//ul[@role='menu']"))
            //       .WaitForElementToAppear(By.XPath("//ul[@role='menu']"));
            WaitMethods.WaitForAllElementsToBeVisible(By.XPath(ClickMessageLogSendingXpath));
                   WaitMethods.WaitForElementToBeClickable(By.XPath(ClickMessageLogSendingXpath));
            ClickMessageLogSending.Click();
            return this;
        }
        public BCOutboundPage6 ShowMoreInInbounds()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ShowMoreInInboundXpath))
                        .WaitForElementToAppear(By.XPath(ShowMoreInInboundXpath))
                         .WaitForElementToBeClickable(By.XPath(ShowMoreInInboundXpath));

            ShowMoreInInbound.Click();

            return this;
        }

        public BCOutboundPage6 ClickEDIFromTheNavogationBars()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("//div[@data-columns-container='true']"))
            .WaitForElementToAppear(By.XPath(ClickEDIFromTheNavogationBarXpath))
            .WaitForElementToBeClickable(By.XPath(ClickEDIFromTheNavogationBarXpath));
            ClickEDIFromTheNavogationBar.Click();

            return this;
        }

        public BCOutboundPage6 SwitchToMainContentFrame()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(MainContentFrameXPath));
            Driver.SwitchTo().Frame(MainContentFrame);

            return this;
        }

        public BCOutboundPage6 ClickTRIMainPage()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("//a[contains(@title,'Transport Inbounds')]"))
                .WaitForElementToBeClickable(By.XPath("//a[contains(@title,'Transport Inbounds')]"));
            Driver.FindElement(By.XPath("//a[contains(@title,'Transport Inbounds')]")).Click();

            return this;
        }
        public BCOutboundPage6 ClickMoreOptionsFromOutboundCard()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(MoreOptionOutboundCardXpath))
                .WaitForElementToBeClickable(By.XPath(MoreOptionOutboundCardXpath));

            MoreOptionOutboundCard.Click();
            return this;
        }
        public BCOutboundPage6 ClickActionFromOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ActionFroumOutboundXpath))
                   .WaitForElementToBeClickable(By.XPath(ActionFroumOutboundXpath));

            ActionFroumOutbound.Click();

            return this;
        }
        public BCOutboundPage6 ClickOutboundFromAction()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(OutboundFromActionXpath))
                      .WaitForElementToBeClickable(By.XPath(OutboundFromActionXpath));

            OutboundFromAction.Click();
            return this;
          
        }
        public BCOutboundPage6 CMRPicked()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(CMRpickedXpath))
                       .WaitForElementToBePresent(By.XPath(CMRpickedXpath));

            CMRpicked.Click();
            return this;
        }
        public BCOutboundPage6 ClickOKButtonOnThePopUpMessages()
        {
            ClickOKButtonOnThePopUpMessage.Click();

            return this;
        }
        public BCOutboundPage6 IVerifyTheReservedSKUAreCorrect(string FirstReservedSKU, string SecondReservedSKU, string ThirdReservedSku)
        {
            WaitMethods.WaitForPageToBeReady();

            WaitMethods.WaitForElementToAppear(By.XPath(ReservedSKUOneXpath));
            Assert.Contains(FirstReservedSKU, ReservedSKUOne.Text);

            WaitMethods.WaitForElementToAppear(By.XPath(ReservedSKUTwoXpath));
            Assert.Contains(SecondReservedSKU, ReservedSKUTwo.Text);

            WaitMethods.WaitForElementToAppear(By.XPath(ReservedSKUThreeXpath));
            Assert.Contains(ThirdReservedSku, ReservedSKUThree.Text);

            WaitMethods.WaitForPageToBeReady();

            return this;
        }

        public BCOutboundPage6 IVerifyThatFPFBQueueIsCreated(string Code)
        {
            WaitMethods.WaitForPageToBeReady();

            WaitMethods.WaitForElementToAppear(By.XPath(VerifyFPFBCodeXpath));

            Assert.Contains(Code, VerifyFPFBCode.Text);

            return this;
        }
       
        public BCOutboundPage6 ISelectTheThirdRowForTheThirdQueue()
        {
            WaitMethods.WaitForPageToBeReady();
            WaitMethods.WaitForElementToBePresent(By.XPath(SelectThirdRowForThirdQueueXpath));

            SelectThirdRowForThirdQueue.Click();

            return this;
        }
        public BCOutboundPage6 IScrollUntilIGetToPickingLabelNumbers()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("//div[@class='ms-nav-scrollable scroll-source thm-cont-g1-bgcolor']"));
            IWebElement scrollArea = Driver.FindElement(By.XPath("//div[@class='ms-nav-scrollable scroll-source thm-cont-g1-bgcolor']"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].scrollLeft += 5300;", scrollArea);

            WaitMethods.WaitForElementToAppear(By.XPath(MultiOrderNumbersXpath))
                   .WaitForElementToBePresent(By.XPath(MultiOrderNumbersXpath));

            Assert.Equal("1", FirstMultiOrderLetter.Text);

            Assert.Equal("2", SecondMultiOrderLetter.Text);

            Assert.Equal("3", ThirdMultiOrderLetter.Text);


            return this;
        }

        public BCOutboundPage6 ClickOutboundInCutOffScreen()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickOutboundfromCutoffXpath))
                    .WaitForElementToBeClickable(By.XPath(ClickOutboundfromCutoffXpath));
            ClickOutboundfromCutoff.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(ClickCutOffXpath))
                   .WaitForElementToBeClickable(By.XPath(ClickCutOffXpath));
            ClickCutOff.Click();
            return this;
        }

        public BCOutboundPage6 ClickWideLayoutViewInQueueGroupList()
        {
            //WaitMethods.WaitForElementToAppear(By.XPath(WideLayoutViewButtonXpath))
            //.WaitForElementToBeClickable(By.XPath(WideLayoutViewButtonXpath));
            WaitMethods.WaitForElementToBePresent(By.XPath(WideLayoutViewButtonXpath));
            Driver.FindElement(By.XPath(WideLayoutViewButtonXpath));


            WideLayoutViewButton.Click();


            return this;
        }

        public BCOutboundPage6 ValidateThatTheQueuegroupIsPrecubing() 
        {

            var precubing = Driver.FindElement(By.XPath("//caption[text()='POWER Queue Group List']//following::td[@controlname ='Precubing']//div")).GetAttribute("aria-checked");
            
            Assert.Equal("true", precubing);

            return this;
        }

        public BCOutboundPage6 ThreeDontsInDestinationCodeInOoutbound()
        {
            
            WaitMethods.WaitForElementToBePresent(By.XPath(ThreeDotsOnDestinationCodeXpath));
            WaitMethods.WaitForElementToBeClickable(By.XPath(ThreeDotsOnDestinationCodeXpath));
            Driver.FindElement(By.XPath(ThreeDotsOnDestinationCodeXpath));


            ThreeDotsOnDestinationCode.Click();


            return this;
        }

        public BCOutboundPage6 ValidateHolderNumberToOnPOWERQueueCard()
        {

             

            string HolderNoTo = Driver.FindElement(By.XPath("(//div[@class='edit-container right thm-cont-g0-bgcolor-1 edit-container-read'])[17]")).Text;

            string ActualNumber = "4571620";

             Assert.Equal(HolderNoTo, ActualNumber);

               

                

            return this;
        }
    }
}
