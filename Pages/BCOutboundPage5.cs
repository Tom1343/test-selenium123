using CGI_OUTBOUND_BC_Scenarios.Utilities;
using CGI_PowerBaselineTwo_Scenarios.Utilities;
//using CGI_PowerBaseline_Scenarios.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Xml;
using TechTalk.SpecFlow;
using Xunit;

namespace CGI_OUTBOUND_BC_Scenarios.OUTBOUND.Pages
{
    [Binding]
    public class BCOutboundPage5 : Page
    {
        private WaitMethods WaitMethods => new WaitMethods(Driver);

        public string currentDirectoryPath { get; private set; }

        public BCOutboundPage5(IWebDriver driver) : base(driver) { }

        public BCOutboundPage5 EnterOnInputFieldFilterQueueGroupList(string inputOnFilter)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(InputFieldFilterQueueGroupListXpath));

            InputFieldFilterQueueGroupList.SendKeys("*" + inputOnFilter + "*" + Keys.Enter);

            return this;
        }

        public BCOutboundPage5 ShowFilterPaneQueueGroupList()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(FilterPaneQueueGroupListXpath));
            FilterPaneQueueGroupList.Click();
            return this;
        }

        public BCOutboundPage5 ClickActionsAndQueueGroup_QueueGroupList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ActionsQueueGroupXpath))
                   .WaitForElementToBePresent(By.XPath(ActionsQueueGroupXpath))
                   .WaitForElementToBeClickable(By.XPath(ActionsQueueGroupXpath));
            // WaitMethods.WaitForElementToBePresent(By.XPath(ActionsQueueGroupXpath));
            ActionsQueueGroup.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(QueueGroupOnDropdownXpath))
                  .WaitForElementToBePresent(By.XPath(QueueGroupOnDropdownXpath))
                  .WaitForElementToBeClickable(By.XPath(QueueGroupOnDropdownXpath));

            // WaitMethods.WaitForElementToBePresent(By.XPath(QueueGroupOnDropdownXpath));
            QueueGroupOnDropdown.Click();

            return this;
        }

        public BCOutboundPage5 ClickPlanningAndAddToBatchQueueGroupList()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(PlanningQueueGroupXpath));
            PlanningQueueGroup.Click();

            AddToBatchQueueGroupList.Click();

            return this;
        }

        public BCOutboundPage5 ClickPlanningAndUnlinkfromBatchQueueGroupList()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(PlanningQueueGroupXpath));
            PlanningQueueGroup.Click();

            WaitMethods.WaitForElementToBePresent(By.XPath(PlanningQueueGroupXpath));
            UnlinkFromBatch.Click();

            return this;
        }

        public BCOutboundPage5 IClickNEWBATCHButtononPage()
        {
            WebDriverWait waitfirst = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            waitfirst.Until(c => c.FindElement(By.XPath(ShowMoreInBatchXpath)).Displayed);
            ShowMoreInBatch.Click();

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(IClickNEWBATCHButtonXpath)).Displayed);
            IClickNEWBATCHButton.Click();

            return this;
        }

        public BCOutboundPage5 ISelectBatchType(string p0)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(BatchTypeDropDownXpath), 10)
                .WaitForElementToBeClickable(By.XPath(BatchTypeDropDownXpath));

            WaitMethods.WaitForPageToBeReady();

            SelectElement selectTypeError = new SelectElement(Driver.FindElement(By.XPath(BatchTypeDropDownXpath)));
            selectTypeError.SelectByText(p0);

            WaitMethods.RepeatUntil(
            () =>
            {
                BatchTypeDropDown.Click();
                selectTypeError.SelectByText(p0);
                BatchTypeDropDown.SendKeys(Keys.Tab);
            },
            _ => BatchTypeDropDown.GetAttribute("title").Equals(p0),
            TimeSpan.FromSeconds(2), 5
            );

            return this;
        }


        public BCOutboundPage5 WriteAddToBatchInputvalue(string p0)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(WriteAddToBatchInputXpath)).Displayed);
            WriteAddToBatchInput.Click();

            WriteAddToBatchInput.Clear();

            WriteAddToBatchInput.SendKeys(p0);
            return this;
        }

        public BCOutboundPage5 EnterFixedValueQueueOnFilterCodeQGRPList(string QueueGroup)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(InputFieldFilterQueueGroupListXpath));
            WaitMethods.WaitForElementToBePresent(By.XPath(InputFieldFilterQueueGroupListXpath));

            InputFieldFilterQueueGroupList.SendKeys(QueueGroup + Keys.Enter);

            WaitMethods.WaitForPageToBeReady();

            return this;
        }

        public BCOutboundPage5 SelectSecondQueueField()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(SecondQueueFieldXpath));
            WaitMethods.WaitForElementToBePresent(By.XPath(SecondQueueFieldXpath));

            SecondQueueField.SendKeys(Keys.LeftShift);

            WaitMethods.WaitForPageToBeReady();

            return this;
        }


        public BCOutboundPage5 CreateWaveButton()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(createWaveXpath))
                   .WaitForElementToBePresent(By.XPath(createWaveXpath))
                   .WaitForElementToBeClickable(By.XPath(createWaveXpath));

            createWave.Click();
            return this;
        }

        public BCOutboundPage5 ClickLinkAndLinkToATransport()
        {

            LinkOnMoreOptionsQueGroup.Click();

            LinkToATransport.Click();
            return this;
        }

        public BCOutboundPage5 Setup_General_Item_New()
        {

            WaitMethods.WaitForElementToBePresent(By.XPath(NewXpath))
                        .WaitForElementToAppear(By.XPath(NewXpath), 10)
                         .WaitForElementToBeClickable(By.XPath(NewXpath));

            WaitMethods.RepeatUntil(
            () => New.Click(),
            _ => Driver.FindElements(By.XPath(TransportNoXpath)).Count > 0,
            TimeSpan.FromSeconds(2), 5
            );

            return this;
        }

        public BCOutboundPage5 EnterCopiedOutboundsValuesInputFilterQueueGroupList()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(InputFieldFilterQueueGroupListXpath));

            InputFieldFilterQueueGroupList.SendKeys(DataCollection.OutboundCodeFromNewOutbound + "|" + DataCollection.SecondOutboundCode + Keys.Enter);

            return this;
        }

        public BCOutboundPage5 GenerateMultiOrderForTwoLines()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(SelectFirstLineInQueueGroupXpath))
                .WaitForElementToBeClickable(By.XPath(SelectFirstLineInQueueGroupXpath));
            SelectFirstLineInQueueGroup.Click();

            WaitMethods.WaitForElementToBePresent(By.XPath(SelectMoreLineQueueGroupXpath))
            .WaitForElementToBeClickable(By.XPath(SelectMoreLineQueueGroupXpath));
            SelectMoreLineQueueGroup.Click();

            WaitMethods.WaitForElementToBePresent(By.XPath(SelectSecondLineInQueGroupXpath))
            .WaitForElementToBeClickable(By.XPath(SelectSecondLineInQueGroupXpath));
            SelectSecondLineInQueGroup.Click();

            WaitMethods.WaitForElementToBePresent(By.XPath(GenerateMultiOrderXpath))
            .WaitForElementToBeClickable(By.XPath(GenerateMultiOrderXpath));
            GenerateMultiOrder.Click();

            return this;
        }

        public BCOutboundPage5 SelectTwoQueueLines()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(SelectFirstLineInQueueGroupXpath))
                .WaitForElementToAppear(By.XPath(SelectFirstLineInQueueGroupXpath), 5);
            //    .WaitForElementToBeClickable(By.XPath(SelectFirstLineInQueueGroupXpath));
            //SelectFirstLineInQueueGroup.Click();

            //WaitMethods.WaitForElementToBePresent(By.XPath(SelectMoreLineQueueGroupXpath))
            //.WaitForElementToBeClickable(By.XPath(SelectMoreLineQueueGroupXpath));
            //SelectMoreLineQueueGroup.Click();

            IWebElement checkbox1 = Driver.FindElement(By.XPath(SelectFirstLineInQueueGroupXpath));
            IWebElement checkbox2 = Driver.FindElement(By.XPath(SelectSecondLineInQueGroupXpath));
            Actions aBuilder = new Actions(Driver);
            aBuilder.KeyDown(Keys.Shift).Click(checkbox1).Click(checkbox2).KeyUp(Keys.Shift).Perform();

            //WaitMethods.WaitForElementToBePresent(By.XPath(SelectSecondLineInQueGroupXpath))
            //.WaitForElementToAppear(By.XPath(SelectFirstLineInQueueGroupXpath), 5)
            //.WaitForElementToBeClickable(By.XPath(SelectSecondLineInQueGroupXpath));

            //SelectSecondLineInQueGroup.Click();

            return this;
        }

        public BCOutboundPage5 ClickSearchOptionOnOutboundList()
        {
            WaitMethods.WaitForElementToBeGone(By.XPath("//span[text()='73401 POWER Outbound']"), 5)
                .WaitForElementToAppear(By.XPath(ClickSearchOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(ClickSearchOutboundXpath));

            ClickSearchOutbound.Click();

            return this;
        }

        public BCOutboundPage5 ClickSearchOptionOnTransportOutboundList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickSearchTransportOutboundXpath), 5)
                .WaitForElementToBeClickable(By.XPath(ClickSearchTransportOutboundXpath));

            ClickSearchTransportOutbound.Click();

            return this;
        }

        public BCOutboundPage5 ClickOnSearchOptionOnOutboundList()
        {
            //WaitMethods.WaitForElementToBeGone(By.XPath("//span[text()='73401 POWER Outbound']"), 5)
            WaitMethods.WaitForElementToAppear(By.XPath(ClickOnSearchOutboundXpath))
               .WaitForElementToBeClickable(By.XPath(ClickOnSearchOutboundXpath));

            ClickOnsearchOutbound.Click();

            return this;
        }

        public BCOutboundPage5 ISearchBatchWithVariable()
        {
            InsertSearchOptionOutboundList.SendKeys(Keys.Control + "v");

            return this;
        }

        public BCOutboundPage5 EnterOutboundCodeSearchOutboundList()
        {
            InsertSearchOptionOutboundList.SendKeys(DataCollection.OutboundCodeFromNewOutbound);
            WaitMethods.WaitForElementToAppear(By.XPath($"//a[contains(@title,'{DataCollection.OutboundCodeFromNewOutbound}')]"));

            return this;
        }

        public BCOutboundPage5 EnterTransportOutboundCodeSearchOutboundList()
        {
            InsertSearchOptionTransportOutboundList.SendKeys(DataCollection.TRONumberFromNewTRO);
            WaitMethods.WaitForElementToAppear(By.XPath($"//a[contains(@title,'{DataCollection.TRONumberFromNewTRO}')]"));

            return this;
        }

        public BCOutboundPage5 IEnterOutboundInOrderCodeOnSearchOptionOutboundList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(InsertSearchOptionOutboundListXpath));
            InsertSearchOptionOutboundList.Click();
            InsertSearchOptionOutboundList.SendKeys(Keys.Control + "a");
            InsertSearchOptionOutboundList.SendKeys(Keys.Delete);
            InsertSearchOptionOutboundList.SendKeys(DataCollection.OutboundCodeFromNewOutbound);

            WaitMethods.WaitForElementToAppear(By.XPath($"//a[text()='{DataCollection.OutboundCodeFromNewOutbound}']"));

            return this;
        }

        public BCOutboundPage5 SearchMyLinkedTROWithOutbound()
        {
            InsertSearchOptionTROList.SendKeys(DataCollection.TROCodeFromNewTRO);

            return this;
        }

        public BCOutboundPage5 ClickEditOptionOutboundList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EditOptionOutboundListXpath))
                .WaitForElementToBeClickable(By.XPath(EditOptionOutboundListXpath));

            EditOptionOutboundList.Click();

            return this;
        }

        public BCOutboundPage5 ClickEditOptionOutboundListAfterFiltering()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EditOptionOutboundListXpath))
                .WaitForElementToBeClickable(By.XPath(EditOptionOutboundListXpath));

            EditOptionOutboundList.Click();

            WaitMethods.RepeatUntil(
            () => EditOptionOutboundList.Click(),
            _ => Driver.FindElements(By.XPath(IClickPickHoldersButtonInOutboundXpath)).Count > 0,
            TimeSpan.FromSeconds(2), 5
            );

            WaitMethods.WaitForPageToBeReady();

            return this;
        }

        public BCOutboundPage5 ClickYesToSendPackingConfirmation()
        {
            Driver.SwitchTo().DefaultContent();
            WaitMethods.WaitForElementToAppear(By.XPath(MainContentFrameXPath), 10);
            Driver.SwitchTo().Frame(MainContentFrame);


            WaitMethods.WaitForElementToAppear(By.XPath(YesPackingConfirmationXpath), 10)
                .WaitForElementToBeClickable(By.XPath(YesPackingConfirmationXpath));

            YesPackingConfirmation.Click();

            return this;
        }

        public BCOutboundPage5 IClickHolderButtonOnPickholders()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickHolderInPickHolderInOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(ClickHolderInPickHolderInOutboundXpath));

            ClickHolderInPickHolderInOutbound.Click();

            return this;
        }

        public BCOutboundPage5 IClickPickHolderButtonInOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(IClickPickHoldersButtonInOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(IClickPickHoldersButtonInOutboundXpath));

            IClickPickHoldersButtonInOutbound.Click();

            return this;
        }

        public BCOutboundPage5 IClickCardButtonOnHolder()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickCardInHolderInOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(ClickCardInHolderInOutboundXpath));

            ClickCardInHolderInOutbound.Click();

            return this;
        }

        public BCOutboundPage5 IClickUnpackLabelHolder()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickUnpackUnlabelHolderXpath))
                .WaitForElementToBeClickable(By.XPath(ClickUnpackUnlabelHolderXpath));

            ClickUnpackUnlabelHolder.Click();

            return this;
        }


        public BCOutboundPage5 ClickDeleteOptionOutboundList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(DeleteOptionOutboundListXpath))
                .WaitForElementToBeClickable(By.XPath(DeleteOptionOutboundListXpath));

            DeleteOptionOutboundList.Click();

            return this;
        }

        public BCOutboundPage5 IClickYesButtonToDeleteTRO()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(YesButtonOnDeleteTROXpath))
                .WaitForElementToBeClickable(By.XPath(YesButtonOnDeleteTROXpath));

            YesButtonOnDeleteTRO.Click();

            return this;
        }

        public BCOutboundPage5 IShouldGetStatusOutboundOrderReservedNotification()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(IShouldGetStatusOutboundOrderReservedXpath));
            Assert.Equal("Reserved", IShouldGetStatusOutboundOrderReserved.Text);

            return this;

        }

        public BCOutboundPage5 IShouldGetStatusOutboundInOrder()
        {

            WaitMethods.WaitForElementToAppear(By.XPath(IShouldGetStatusOutboundOrderInOutboundDetailsXpath));
            Assert.Equal("In Order", IShouldGetStatusOutboundOrderInOutboundDetails.Text);

            return this;
        }

        public BCOutboundPage5 ISeeScreenOutboundList()
        {

            WaitMethods.WaitForElementToAppear(By.XPath(ISeeScreenOutboundListWrittenXpath));
            Assert.Equal("Outbound", ISeeScreenOutboundListWritten.Text);

            return this;
        }

        public BCOutboundPage5 IClickCalculateBatchButton()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(IClickCalculateBatchXpath), 5)
                .WaitForElementToBeClickable(By.XPath(IClickCalculateBatchXpath));

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(IClickCalculateBatchXpath)).Displayed);
            IClickCalculateBatch.Click();

            return this;
        }

        public BCOutboundPage5 ISelectAndLaunchHolderRetrievalQueue()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(HolderRetrievalQueueXpath), 5)
                .WaitForElementToBeClickable(By.XPath(HolderRetrievalQueueXpath));

            WaitMethods.WaitForElementToBeGone(By.XPath(ProgressBarXPath), 5);
            WaitMethods.WaitForPageToBeReady();

            HolderRetrievalQueue.Click();

            WaitMethods.WaitForElementToBeGone(By.XPath(ProgressBarXPath), 5);
            WaitMethods.WaitForPageToBeReady();

            WaitMethods.WaitForElementToAppear(By.XPath(LaunchInQueueGroupListXpath), 5)
                .WaitForElementToBeClickable(By.XPath(LaunchInQueueGroupListXpath));


            LaunchInQueueGroupList.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(YesButtonOutboundXpath), 5)
                .WaitForElementToBeClickable(By.XPath(YesButtonOutboundXpath));

            YesButtonOutbound.Click();

            return this;
        }

        public BCOutboundPage5 ITurnOnFullBoxRetrievalOption()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(FullBoxRetrievalOptionXpath), 5)
                .WaitForElementToBeClickable(By.XPath(FullBoxRetrievalOptionXpath));

            FullBoxRetrievalOption.Click();

            return this;
        }

        public BCOutboundPage5 ITurnOnPriorityBatchOption()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(PriorityBatchOptionXpath), 5)
                .WaitForElementToBeClickable(By.XPath(PriorityBatchOptionXpath));

            PriorityBatchOption.Click();

            return this;
        }

        public BCOutboundPage5 ITurnOnFullPalletFullBoxRetrievalOption()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(FullPalletFullBoxRetrievalOptionXpath), 5)
                .WaitForElementToBeClickable(By.XPath(FullPalletFullBoxRetrievalOptionXpath));

            FullPalletFullBoxRetrievalOption.Click();

            return this;
        }

        public BCOutboundPage5 ClickEditOption_TROList()
        {
            EditOptionTROList.Click();

            return this;
        }

        public BCOutboundPage5 ClickReservationsOutbound()
        {
            WaitMethods.WaitForPageToBeReady(10);

            WaitMethods.WaitForElementToAppear(By.XPath(ReservationsOnOutboundXpath), 15)
                .WaitForElementToBeClickable(By.XPath(ReservationsOnOutboundXpath));

            ReservationsOnOutbound.Click();

            return this;
        }

        public BCOutboundPage5 SaveQueueGroupCodeOutbuondReservations()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(OutboundReservationsXpath));
            OutboundReservations.SendKeys(Keys.ArrowRight + Keys.ArrowRight + Keys.ArrowRight + Keys.ArrowRight + Keys.ArrowRight + Keys.ArrowRight + Keys.ArrowRight + Keys.ArrowRight + Keys.ArrowRight + Keys.ArrowRight + Keys.ArrowRight + Keys.ArrowRight + Keys.ArrowRight + Keys.ArrowRight);

            DataCollection.QueueGroupCodeFromOutboundReservations = Driver.FindElement(By.XPath("//div//div//div//div//div//div[5]//div[2]//div[1]//div[1]//div[2]//div[1]//div[1]//div[1]//div[2]//table[1]//tbody[1]//tr[1]//td[24]")).Text;
            return this;
        }

        public BCOutboundPage5 EnterSavedQueueGroupCodeOutboundReservations()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(InputFieldFilterQueueGroupListXpath))
                .WaitForElementToBeClickable(By.XPath(InputFieldFilterQueueGroupListXpath));

            InputFieldFilterQueueGroupList.SendKeys(DataCollection.QueueGroupCodeFromOutboundReservations + Keys.Enter);

            return this;
        }

        public BCOutboundPage5 EnterDateCreatedQueueGroupList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(DateCreatedQueueGroupListXpath))
                .WaitForElementToBeClickable(By.XPath(DateCreatedQueueGroupListXpath));

            DateCreatedQueueGroupList.SendKeys("t" + Keys.Enter);

            return this;
        }

        public BCOutboundPage5 FilterQueueGroupLists()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(FilterQueueGroupListXpath), 5)
           .WaitForElementToBeClickable(By.XPath(FilterQueueGroupListXpath));

            WaitMethods.RepeatUntil(
            () => FilterQueueGroupList.Click(),
            _ => Driver.FindElements(By.XPath(FirstFilterOnQueueGroupXpath)).Count > 0,
            TimeSpan.FromSeconds(2), 5
            );

            //FilterQueueGroupList.Click();

            return this;
        }

        public BCOutboundPage5 FilterListBy()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(FilterListByButtonXpath))
           .WaitForElementToBeClickable(By.XPath(FilterListByButtonXpath));

            FilterListByButton.Click();

            return this;
        }

        public BCOutboundPage5 IClickMoreOptionsNavigationMenuOutbound()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(IClickMoreOptionsNavMenuOutboundXpath)).Displayed);
            IClickMoreOptionsNavMenuOutbound.Click();
            return this;
        }

        public BCOutboundPage5 IClickNavigateNavMenu()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(IClickNavigateNavMenudXpath)).Displayed);
            IClickNavigateNavMenud.Click();
            return this;
        }

        public BCOutboundPage5 IClickBWNErrorButton()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(IClickBWNErrorXpath)).Displayed);
            IClickBWNError.Click();
            return this;
        }

        public BCOutboundPage5 IClickDetailsFromHeaders()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(IClickDetailsFromHeaderXpath)).Displayed);
            IClickDetailsFromHeader.Click();
            return this;
        }

        public BCOutboundPage5 ClickOutboundOnFilterDropdown_QueueGroupList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(OutboundOnFilterDropdown_QueueGroupListXpath))
                .WaitForElementToBeClickable(By.XPath(OutboundOnFilterDropdown_QueueGroupListXpath));

            OutboundOnFilterDropdown_QueueGroupList.Click();

            return this;
        }

        public BCOutboundPage5 ClickCode_QuegroupDropdown()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(Code_QuegroupDropdownXpath))
                .WaitForElementToBeClickable(By.XPath(Code_QuegroupDropdownXpath));

            Code_QuegroupDropdown.Click();

            return this;
        }

        public BCOutboundPage5 LaunchQueueGroup()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(LaunchOnQuegroupXpath))
                .WaitForElementToBeClickable(By.XPath(LaunchOnQuegroupXpath));

            LaunchOnQuegroup.Click();

            return this;
        }

        public BCOutboundPage5 ClickLaunchOnQuegroupListAfterMultiOrder()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(LaunchOnQuegroupListAfterMultiOrderXpath))
                .WaitForElementToBeClickable(By.XPath(LaunchOnQuegroupListAfterMultiOrderXpath));

            LaunchOnQuegroupListAfterMultiOrder.Click();

            return this;
        }

        public BCOutboundPage5 IClickNavBarOnQueueGroupOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(NavBarOnQueueGroupOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(NavBarOnQueueGroupOutboundXpath));

            NavBarOnQueueGroupOutbound.Click();

            return this;
        }

        public BCOutboundPage5 ClickYesToLaunchQueueGroups()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickYesToLaunchQueueGroupXpath))
                .WaitForElementToBeClickable(By.XPath(ClickYesToLaunchQueueGroupXpath));

            ClickYesToLaunchQueueGroup.Click();

            return this;
        }

        public BCOutboundPage5 CardQueueGroupListPage()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(CardQueueGroupListXpath))
                .WaitForElementToBeClickable(By.XPath(CardQueueGroupListXpath));

            CardQueueGroupList.Click();

            return this;
        }

        public string CopyPickwaveCodeQueueGroupList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("//div[@class='edit-container thm-cont-g0-bgcolor-1']//span[@class='stringcontrol-read value thm-cont-u1-font-size-2--maxflat thm-cont-u1-font-stack-2--maxflat thm-cont-u1-color-2--maxflat thm-cont-g2-bgcolor-2 thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus']"))
                .WaitForElementToBeClickable(By.XPath("//div[@class='edit-container thm-cont-g0-bgcolor-1']//span[@class='stringcontrol-read value thm-cont-u1-font-size-2--maxflat thm-cont-u1-font-stack-2--maxflat thm-cont-u1-color-2--maxflat thm-cont-g2-bgcolor-2 thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus']"));

            DataCollection.PickwaveCode = Driver.FindElement(By.XPath("//div[@class='edit-container thm-cont-g0-bgcolor-1']//span[@class='stringcontrol-read value thm-cont-u1-font-size-2--maxflat thm-cont-u1-font-stack-2--maxflat thm-cont-u1-color-2--maxflat thm-cont-g2-bgcolor-2 thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus']")).Text;

            return DataCollection.PickwaveCode;
        }

        public string SavePickwaveCodeQueueGroupList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("//div[@class='edit-container thm-cont-g0-bgcolor-1']//span[@class='stringcontrol-read value thm-cont-u1-font-size-2--maxflat thm-cont-u1-font-stack-2--maxflat thm-cont-u1-color-2--maxflat thm-cont-g2-bgcolor-2 thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus']"))
                .WaitForElementToBeClickable(By.XPath("//div[@class='edit-container thm-cont-g0-bgcolor-1']//span[@class='stringcontrol-read value thm-cont-u1-font-size-2--maxflat thm-cont-u1-font-stack-2--maxflat thm-cont-u1-color-2--maxflat thm-cont-g2-bgcolor-2 thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus']"));

            DataCollection.PickwaveCode = Driver.FindElement(By.XPath("//div[@class='edit-container thm-cont-g0-bgcolor-1']//span[@class='stringcontrol-read value thm-cont-u1-font-size-2--maxflat thm-cont-u1-font-stack-2--maxflat thm-cont-u1-color-2--maxflat thm-cont-g2-bgcolor-2 thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus']")).Text;

            return DataCollection.PickwaveCode;
        }

        public string CopyPickwaveHolderBarcodeQueueGroupList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("//div[@class='spa-view spa-task-dialog slide-in-from-top animate no-animations shown']//tr[1]//td[9]"))
                .WaitForElementToBeClickable(By.XPath("//div[@class='spa-view spa-task-dialog slide-in-from-top animate no-animations shown']//tr[1]//td[9]"));

            DataCollection.PickwaveHolderBarcode = Driver.FindElement(By.XPath("//div[@class='spa-view spa-task-dialog slide-in-from-top animate no-animations shown']//tr[1]//td[9]")).Text;

            return DataCollection.PickwaveHolderBarcode;
        }

        public string SavePickwaveHolderBarcodeQueueGroupList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("//div[@class='spa-view spa-task-dialog slide-in-from-top animate no-animations shown']//tr[1]//td[9]"))
                .WaitForElementToBeClickable(By.XPath("//div[@class='spa-view spa-task-dialog slide-in-from-top animate no-animations shown']//tr[1]//td[9]"));

            DataCollection.PickwaveHolderBarcode = Driver.FindElement(By.XPath("//div[@class='spa-view spa-task-dialog slide-in-from-top animate no-animations shown']//tr[1]//td[9]")).Text;

            return DataCollection.PickwaveHolderBarcode;
        }

        public BCOutboundPage5 CloseCardQueueGroupCardPage()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(CloseCardQueueGroupCardXpath))
                .WaitForElementToBeClickable(By.XPath(CloseCardQueueGroupCardXpath));

            CloseCardQueueGroupCard.Click();

            return this;
        }

        public BCOutboundPage5 GoBackFromQueueGroupList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(BackFromQueueGroupListXpath))
                .WaitForElementToBeClickable(By.XPath(BackFromQueueGroupListXpath));

            BackFromQueueGroupList.Click();

            return this;
        }

        public BCOutboundPage5 ClickBookBackSelectedPickwaveQG()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(BookBackSelectedPickwaveQGXpath), 10)
                .WaitForElementToBeClickable(By.XPath(BookBackSelectedPickwaveQGXpath));

            BookBackSelectedPickwaveQG.Click();

            return this;
        }

        public BCOutboundPage5 ClickBookBackSelectedPickwaveQueueGroup()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(BookBackSelectedPickwaveQueueGroupXpath), 10)
                .WaitForElementToBeClickable(By.XPath(BookBackSelectedPickwaveQueueGroupXpath));

            BookBackSelectedPickwaveQueueGroup.Click();

            return this;
        }

        public BCOutboundPage5 ClickOnShowMoreAndBookBackAfterFPFBCreation()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ShowMoreInQueueGroupForBookBackXpath), 10)
                .WaitForElementToBeClickable(By.XPath(ShowMoreInQueueGroupForBookBackXpath));

            ShowMoreInQueueGroupForBookBack.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(BookBackSelectedPickwaveQueueGroupAfterShowMoreXpath), 10)
                .WaitForElementToBeClickable(By.XPath(BookBackSelectedPickwaveQueueGroupAfterShowMoreXpath));

            BookBackSelectedPickwaveQueueGroupAfterShowMore.Click();

            return this;
        }

        public BCOutboundPage5 CancelQTYinLinesOutbound()
        {
            WaitMethods.WaitForElementToBeGone(By.XPath(ProgressBarXPath), 10);
            WaitMethods.WaitForPageToBeReady();

            WaitMethods.WaitForElementToAppear(By.XPath(ManageOrderCutOffOutboundXpath))
               .WaitForElementToBeClickable(By.XPath(ManageOrderCutOffOutboundXpath));
            ManageOrderCutOffOutbound.Click();

            WaitMethods.RepeatUntil(
            () => ManageOrderCutOffOutbound.Click(),
            _ => Driver.FindElements(By.XPath(CancelQtyInLinesOutboundXpath)).Count > 0,
            TimeSpan.FromSeconds(2), 5
            );

            WaitMethods.WaitForElementToAppear(By.XPath(CancelQtyInLinesOutboundXpath))
            .WaitForElementToBeClickable(By.XPath(CancelQtyInLinesOutboundXpath));

           // WaitMethods.WaitForElementToAppear(By.XPath(CancelQtyInLinesOutboundXpath))
           //.WaitForElementToBeClickable(By.XPath(CancelQtyInLinesOutboundXpath));

            WaitMethods.RepeatUntil(
            () => CancelQtyInLinesOutbound.Click(),
            _ => Driver.FindElements(By.XPath(OnQtyToCancelXpath)).Count > 0,
            TimeSpan.FromSeconds(2), 5
            );

            WaitMethods.WaitForPageToBeReady();


            return this;
        }

        public BCOutboundPage5 CancelQTYinLinesOutboundForPartOrderLine()
        {
            WaitMethods.WaitForElementToBeGone(By.XPath(ProgressBarXPath), 15);
            WaitMethods.WaitForPageToBeReady();

            WaitMethods.WaitForElementToAppear(By.XPath(MoreOptionsCutOffXpath))
                .WaitForElementToBeClickable(By.XPath(MoreOptionsCutOffXpath));
            MoreOptionsCutOff.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(ManageOrderCutOffOutboundXpath))
               .WaitForElementToBeClickable(By.XPath(ManageOrderCutOffOutboundXpath));
            ManageOrderCutOffOutbound.Click();

            WaitMethods.RepeatUntil(
            () => ManageOrderCutOffOutbound.Click(),
            _ => Driver.FindElements(By.XPath(CancelQtyInLinesOutboundXpath)).Count > 0,
            TimeSpan.FromSeconds(2), 5
            );

            WaitMethods.WaitForElementToAppear(By.XPath(CancelQtyInLinesOutboundXpath))
            .WaitForElementToBeClickable(By.XPath(CancelQtyInLinesOutboundXpath));

            // WaitMethods.WaitForElementToAppear(By.XPath(CancelQtyInLinesOutboundXpath))
            //.WaitForElementToBeClickable(By.XPath(CancelQtyInLinesOutboundXpath));

            WaitMethods.RepeatUntil(
            () => CancelQtyInLinesOutbound.Click(),
            _ => Driver.FindElements(By.XPath(OnQtyToCancelXpath)).Count > 0,
            TimeSpan.FromSeconds(2), 5
            );

            WaitMethods.WaitForPageToBeReady();


            return this;
        }

        public BCOutboundPage5 CancelQTYExpectErrorMessage()
        {
            WaitMethods.WaitForElementToBeGone(By.XPath(ProgressBarXPath), 15);
            WaitMethods.WaitForPageToBeReady();

            WaitMethods.WaitForElementToAppear(By.XPath(MoreOptionsCutOffXpath))
                .WaitForElementToBeClickable(By.XPath(MoreOptionsCutOffXpath));
            MoreOptionsCutOff.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(ManageOrderCutOffOutboundXpath))
               .WaitForElementToBeClickable(By.XPath(ManageOrderCutOffOutboundXpath));
            ManageOrderCutOffOutbound.Click();

            WaitMethods.RepeatUntil(
            () => ManageOrderCutOffOutbound.Click(),
            _ => Driver.FindElements(By.XPath(CancelQtyInLinesOutboundXpath)).Count > 0,
            TimeSpan.FromSeconds(2), 5
            );

            WaitMethods.WaitForElementToAppear(By.XPath(CancelQtyInLinesOutboundXpath))
            .WaitForElementToBeClickable(By.XPath(CancelQtyInLinesOutboundXpath));

            // WaitMethods.WaitForElementToAppear(By.XPath(CancelQtyInLinesOutboundXpath))
            //.WaitForElementToBeClickable(By.XPath(CancelQtyInLinesOutboundXpath));

            WaitMethods.RepeatUntil(
            () => CancelQtyInLinesOutbound.Click(),
            _ => Driver.FindElements(By.XPath(IShouldGetNotificationOutboundCancelOrderlineXpath)).Count > 0,
            TimeSpan.FromSeconds(2), 5
            );

            WaitMethods.WaitForPageToBeReady();


            return this;
        }

        public BCOutboundPage5 CancelQTYinLinesInOutbound()
        {
            WaitMethods.WaitForPageToBeReady();

            WaitMethods.WaitForElementToAppear(By.XPath(FewerOptionsCutOffXpath))
                .WaitForElementToBeClickable(By.XPath(FewerOptionsCutOffXpath));
            FewerOptionsCutOff.Click();


            WaitMethods.WaitForElementToAppear(By.XPath(ManageOrderCutOffOutboundXpath))
               .WaitForElementToBeClickable(By.XPath(ManageOrderCutOffOutboundXpath));
            ManageOrderCutOffOutbound.Click();

            WaitMethods.RepeatUntil(
            () => ManageOrderCutOffOutbound.Click(),
            _ => Driver.FindElements(By.XPath(CancelQtyInLinesOutboundXpath)).Count > 0,
            TimeSpan.FromSeconds(2), 5
            );

            WaitMethods.WaitForElementToAppear(By.XPath(CancelQtyInLinesOutboundXpath))
            .WaitForElementToBeClickable(By.XPath(CancelQtyInLinesOutboundXpath));

            WaitMethods.RepeatUntil(
            () => CancelQtyInLinesOutbound.Click(),
            _ => Driver.FindElements(By.XPath(IShouldGetNotificationOutboundCancelOrderlineXpath)).Count > 0,
            TimeSpan.FromSeconds(2), 5
            );

            WaitMethods.WaitForPageToBeReady();

            return this;
        }

        public BCOutboundPage5 YesConfirmCancellationOutbound1()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(YesConfirmCancellationOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(YesConfirmCancellationOutboundXpath));

            YesConfirmCancellationOutbound.Click();

            return this;
        }

        public BCOutboundPage5 WriteOnCancelCodeOutbound(string CancelCode)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(CancelCodeOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(CancelCodeOutboundXpath));

            CancelCodeOutbound.SendKeys(CancelCode + Keys.Enter);

            return this;
        }

        public BCOutboundPage5 ClickCloseDestinationGroupButton()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickCloseDestinationGroupXpath))
                .WaitForElementToBeClickable(By.XPath(ClickCloseDestinationGroupXpath));

            ClickCloseDestinationGroup.Click();

            WaitMethods.WaitForElementToBeGone(By.XPath(ClickCloseDestinationGroupXpath));

            WaitMethods.WaitForPageToBeReady();

            return this;
        }

        public string CopyTheTroNumber()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(TRONumberXpath));

            DataCollection.TRONumberFromNewTRO = Driver.FindElement(By.XPath(TRONumberXpath)).Text;

            return DataCollection.TRONumberFromNewTRO;

        }

        public BCOutboundPage5 IEnterTOnDateCreated()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(EnterTOnDateCreatedXpath)).Displayed);
            EnterTOnDateCreated.SendKeys("t" + Keys.Tab);

            return this;
        }

        public BCOutboundPage5 IClickYesButtonOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(YesButtonOutboundXpath))
               .WaitForElementToBeClickable(By.XPath(YesButtonOutboundXpath));

            YesButtonOutbound.Click();

            return this;

        }

        public BCOutboundPage5 SendInstructionToQueueGroup(string fileName)
        {
            WebServicesCall.WebServicePostCall(fileName);
            return this;
        }

        public BCOutboundPage5 SendInstructionToQueueGroupNoResponse(string fileName)
        {
            WebServicesCallBaselineNoRESPONES.WebServicePostCall(fileName);
            return this;
        }

        public BCOutboundPage5 SendInstructionToQueueGroupInAdeo(string fileName)
        {
            WebServicesCall_ADEO.WebServicePostCall(fileName);
            return this;
        }

        public BCOutboundPage5 SendInstructionToQueueGroupThree(string fileName)
        {
            WebServicesCall_BaselineThreeDB.WebServicePostCall(fileName);
            return this;
        }

        public BCOutboundPage5 SendInstructionToQueueGroupNilfisk(string p0)
        {
            WebServicesCall_Nilfisk.WebServicePostCall(p0);
            return this;
        }

        public BCOutboundPage5 LaunchInstructionToQueueGroupNilfisk(string p0)
        {
            WebServicesCall_Nilfisk_Launch.WebServicePostCall(p0);
            return this;
        }

        public BCOutboundPage5 SendMessageToBCNilfisk(string p0)
        {
            POWER_WMSCommunication_WS_Nilfisk.WebServicePostCall(p0);

            return this;
        }

        public BCOutboundPage5 SendInstructionToQueueGroupNilfiskLaunch(string p0)
        {
            WebServicesCall_Nilfisk_Launch.WebServicePostCall(p0);
            return this;
        }

        public BCOutboundPage5 SendInstructionToQueueGroupSTST(string fileName)
        {
            WebServicesCall_STST.WebServicePostCall(fileName);
            return this;
        }

        public BCOutboundPage5 SendInstructionToQueueGroupKitchenAid(string fileName)
        {

            WebServicesCall_KitchenAid.WebServicePostCall(fileName);
            return this;
        }
        public BCOutboundPage5 SendXMLtoBC(string p0)
        {
            POWER_WMSCommunication_WS_BaselineTWODB.WebServicePostCall(p0);
            return this;
        }

        public BCOutboundPage5 SendXMLtoBCBaseline(string p0)
        {
            POWER_WMSCommunication_WS_Baseline.WebServicePostCall(p0);
            return this;
        }
        public BCOutboundPage5 CancellLoadingQueu(string fileName)
        {
            WebServicesCall.WebServicePostCall(fileName);
            return this;
        }

        public BCOutboundPage5 SendInstructionToQueueGroupBaselineTwo(string fileName)
        {

            WebServicesCall_BaselineTWODB.WebServicePostCall(fileName);
            return this;
        }
        public BCOutboundPage5 SendNasSimulatorwithSaveData(string p0)
        {
            //currentDirectoryPath = Directory.GetCurrentDirectory();
            //string[] filePath = Directory.GetFiles(currentDirectoryPath, p0, SearchOption.AllDirectories);

            //XmlDocument doc = new XmlDocument();
            //doc.LoadXml(filePath[]);

            //const string FILENAME =
            //string currentDirectoryPath = Directory.GetCurrentDirectory();
            //string[] filePath = Directory.GetFiles(currentDirectoryPath, p0, SearchOption.AllDirectories);
            //XML.Load(filePath.FirstOrDefault());

            NASSimulatorWS.WebServicePostCall(DataCollection.OutboundCodeFromNewOutbound);
            return this;
        }
        public BCOutboundPage5 SendNasSimulator(string fileName)
        {
            NASSimulatorWS.WebServicePostCall(fileName);

            return this;
        }

        public BCOutboundPage5 WriteOnQtyToCancel(string qtyToCancel)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(OnQtyToCancelXpath))
                .WaitForElementToBeClickable(By.XPath(OnQtyToCancelXpath));

            OnQtyToCancel.Click();
            OnQtyToCancel.Clear();
            OnQtyToCancel.SendKeys(qtyToCancel + Keys.Enter);

            return this;
        }

        public BCOutboundPage5 IWriteOnInputWindowOutbound(string inputWindow)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(OnInputWindowOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(OnInputWindowOutboundXpath));

            OnInputWindowOutbound.Click();
            OnInputWindowOutbound.Clear();
            OnInputWindowOutbound.SendKeys(inputWindow + Keys.Enter);

            return this;
        }

        public BCOutboundPage5 IWriteMaxNumberOnMultiOrder(string MaxNumberOnMultiOrder1)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(MaxNumberOnMultiOrderXpath))
                .WaitForElementToBeClickable(By.XPath(MaxNumberOnMultiOrderXpath));

            MaxNumberOnMultiOrder.Click();
            MaxNumberOnMultiOrder.Clear();
            MaxNumberOnMultiOrder.SendKeys(MaxNumberOnMultiOrder1 + Keys.Enter);

            return this;
        }

        public BCOutboundPage5 ClickItemInOrderLineTwoOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(SecondLineOrderLineItemOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(SecondLineOrderLineItemOutboundXpath));

            SecondLineOrderLineItemOutbound.Click();

            return this;
        }

        public BCOutboundPage5 BookBackSelectedLineOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(LinesReservationOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(LinesReservationOutboundXpath));

            LinesReservationOutbound.Click();
            BookBackSelectedLinesOutbound.Click();

            return this;
        }

        public BCOutboundPage5 ClickBookBackPartOfSelectedLine_Outbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(LinesReservationOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(LinesReservationOutboundXpath));

            LinesReservationOutbound.Click();
            BookBackPartOfSelectedLineOutbound.Click();

            return this;
        }
        public BCOutboundPage5 YesConfirmBookBackOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickYesBookBackXpath))
                .WaitForElementToBeClickable(By.XPath(ClickYesBookBackXpath));

            ClickYesBookBack.Click();

            return this;
        }
        public BCOutboundPage5 ClickBookBackSelectedReplenishmentQG_QueueGroupList()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(BookBackReplenishmentQGXpath));
            BookBackReplenishmentQG.Click();

            return this;
        }
        public BCOutboundPage5 ClickBackButtonGenerals()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ProgressBarXPath), 3)
                .WaitForElementToBeGone(By.XPath(ProgressBarXPath))
                .WaitForElementToAppear(By.XPath("//button[@data-is-focusable='true'][@title='Back']"))
                .WaitForElementToBeClickable(By.XPath("//button[@data-is-focusable='true'][@title='Back']"));

            Driver.FindElement(By.XPath("//button[@data-is-focusable='true'][@title='Back']")).Click();
            WaitMethods.WaitForElementToBeGone(By.XPath("//button[@data-is-focusable='true'][@title='Back']"), 4);

            return this;
        }
        public BCOutboundPage5 SETUPMenu()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(SetupMenuXpath))
                .WaitForElementToBeClickable(By.XPath(SetupMenuXpath));

            SetupMenu.Click();
            return this;
        }

        public BCOutboundPage5 ClickNasSimulatorInScheduler()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(SchedulerInSetupXpath))
                .WaitForElementToBeClickable(By.XPath(SchedulerInSetupXpath));

            SchedulerInSetup.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(NasSimulatorXpath))
                .WaitForElementToBeClickable(By.XPath(NasSimulatorXpath));

            NasSimulator.Click();

            return this;
        }
        
        public BCOutboundPage5 RefreshPageContent()
        {
            WaitMethods.WaitForMainPageToBeReady()
            .WaitForElementToBeGone(By.XPath(Page.ProgressBarMainXPath), 2)
             .WaitForPageToBeReady();
            Driver.Navigate().Refresh();
            return this;
        }
        public BCOutboundPage5 OperationOverviewMenu()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(OpertionOverviewsXpath));

            OperationOverviews.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(QueueOverviewXpath))
                       .WaitForElementToBeClickable(By.XPath(QueueOverviewXpath));

            QueueOverview.Click();

            WaitMethods.WaitForElementToBePresent(By.XPath(OpenQueueGroupfromMainXpath));

            OpenQueueGroupfromMain.Click();

            //General.SendKeys(Keys.ArrowDown + Keys.Enter);
            return this;
        }
        public BCOutboundPage5 ClickLaunch_QueueGroupList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(LaunchQueueGroupXpath))
                   .WaitForElementToBePresent(By.XPath(LaunchQueueGroupXpath))
                   .WaitForElementToBeClickable(By.XPath(LaunchQueueGroupXpath));

            LaunchInQueueGroup.Click();

            return this;
        }

       public BCOutboundPage5 ClickLaunchQueueGroupList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(LaunchInQueueGroupListXpath))
                  .WaitForElementToBePresent(By.XPath(LaunchInQueueGroupListXpath))
                  .WaitForElementToBeClickable(By.XPath(LaunchInQueueGroupListXpath));

            LaunchInQueueGroupList.Click();
            return this;
        }
        public BCOutboundPage5 ClickLaunchAndPrintPicklabels()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(LaunchAndPrintPickLabelsXpath))
                   .WaitForElementToBePresent(By.XPath(LaunchAndPrintPickLabelsXpath))
                   .WaitForElementToBeClickable(By.XPath(LaunchAndPrintPickLabelsXpath));

            LaunchAndPrintPickLabels.Click();

            WaitMethods.WaitForElementToBeGone(By.XPath(LaunchAndPrintPickLabelsXpath), 3);

            WaitMethods.WaitForElementToAppear(By.XPath(ProgressBarXPath), 3)
                .WaitForElementToBeGone(By.XPath(ProgressBarXPath));

            WaitMethods.WaitForPageToBeReady(5);

            return this;
        }


        public BCOutboundPage5 ScrollUntilIGetToPicklabelNumbers()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("(//div[@class = 'freeze-pane-scrollbar'])[2]"));
            IWebElement scrollArea = Driver.FindElement(By.XPath("(//div[@class = 'freeze-pane-scrollbar'])[2]"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].scrollLeft += 4000;", scrollArea);

            WaitMethods.WaitForElementToAppear(By.XPath(PickLabelNumberFirstQueueXpath))
                   .WaitForElementToBePresent(By.XPath(PickLabelNumberFirstQueueXpath));

            return this;
        }
        public BCOutboundPage5 ValidatePicklabelNumbersAreNotEqual()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("//tr[@aria-rowindex='1']//td[47]//span"))
                         .WaitForElementToBePresent(By.XPath("//tr[@aria-rowindex='1']//td[47]//span"));

            WaitMethods.WaitForElementToAppear(By.XPath("//tr[@aria-rowindex='2']//td[47]//span"))
                      .WaitForElementToBePresent(By.XPath("//tr[@aria-rowindex='2']//td[47]//span"));


            String pickLabel1 = Driver.FindElement(By.XPath("//tr[@aria-rowindex='1']//td[47]//span")).Text;
            String pickLabel2 = Driver.FindElement(By.XPath("//tr[@aria-rowindex='2']//td[47]//span")).Text;

            Assert.NotEqual(pickLabel1, pickLabel2);

            return this;

        }
        public BCOutboundPage5 ClickSetBackCreatedOnQuegroupList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(SetBackCreatedroupXpath), 5)
                .WaitForElementToBeClickable(By.XPath(SetBackCreatedroupXpath));

            SetBackCreatedroup.Click();

            return this;
        }

        public BCOutboundPage5 ClickBookBackSelectedBatchPickingQG()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(BookBackBatchQGXpath));
            BookBackBatchQG.Click();

            return this;
        }

        public BCOutboundPage5 ClickActionsAndTourBuilding_QueueGroupList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ActionsQueueGroupXpath))
                   .WaitForElementToBePresent(By.XPath(ActionsQueueGroupXpath))
                   .WaitForElementToBeClickable(By.XPath(ActionsQueueGroupXpath));

            ActionsQueueGroup.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(TourBuildingQueueGroupListXpath))
                  .WaitForElementToBePresent(By.XPath(TourBuildingQueueGroupListXpath))
                  .WaitForElementToBeClickable(By.XPath(TourBuildingQueueGroupListXpath));


            TourBuildingQueueGroupList.Click();

            return this;
        }

        public BCOutboundPage5 GivenIClickImportPickingToursAndMultiorders()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ImportPickingToursQueueGroupListXpath))
                   .WaitForElementToBePresent(By.XPath(ImportPickingToursQueueGroupListXpath))
                   .WaitForElementToBeClickable(By.XPath(ImportPickingToursQueueGroupListXpath));

            ImportPickingToursQueueGroupList.Click();



            return this;
        }

        public BCOutboundPage5 ClickFilterInPOWERTourBuildingLogivation()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(FilterOnTourBuildingLogivationXpath))
                   .WaitForElementToBePresent(By.XPath(FilterOnTourBuildingLogivationXpath))
                   .WaitForElementToBeClickable(By.XPath(FilterOnTourBuildingLogivationXpath));

            FilterOnTourBuildingLogivation.Click();



            return this;
        }

        public BCOutboundPage5 WriteOnThePOWTourBuildingLogivationCard(string p0)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(POWTourBuldingLogivationSearchXpath));

            POWTourBuldingLogivationSearch.SendKeys(p0 + Keys.Enter);

            return this;
        }

    }
}
