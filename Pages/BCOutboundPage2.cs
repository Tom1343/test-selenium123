//using CGI_OUTBOUND_BC_Scenarios.INBOUND.Pages;
using CGI_OUTBOUND_BC_Scenarios.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using Xunit;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;


namespace CGI_OUTBOUND_BC_Scenarios.OUTBOUND.Pages
{
    [Binding]
    public class BCOutboundPage2 : Page
    {
        private WaitMethods WaitMethods => new WaitMethods(Driver);
        public BCOutboundPage2(IWebDriver driver) : base(driver) { }
        private BCOutboundPage1 BCOutboundPage1 => new BCOutboundPage1(Driver);
        //  private BCInboundPage2 BCInboundPage2 => new BCInboundPage2(Driver);

        public BCOutboundPage2 EnterDepartedTimeTROs()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EnterDepartedTimeTROXpath))
                .WaitForElementToBeClickable(By.XPath(EnterDepartedTimeTROXpath));

            EnterDepartedTimeTRO.Click();
            WaitMethods.WaitForElementToAppear(By.XPath(EnterDepartedTimeTROXpath))
                .WaitForElementToBeClickable(By.XPath(EnterDepartedTimeTROXpath));
            EnterDepartedTimeTRO.SendKeys("t");
            EnterDepartedTimeTRO.SendKeys(Keys.Tab + "t");

            return this;
        }



        public BCOutboundPage2 EnterDeliveredDateTimeTROs()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EnterDeliveredDateTimeTROXpath))
                .WaitForElementToBeClickable(By.XPath(EnterDeliveredDateTimeTROXpath));

            EnterDeliveredDateTimeTRO.Click();

            EnterDeliveredDateTimeTRO.SendKeys("t");

            EnterDeliveredDateTimeTRO.SendKeys(Keys.Tab + "t");
            return this;
        }

        public BCOutboundPage2 ClickLinkToATransportQueueGroup()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickLinkToTransportQueueGroupXpath))
                .WaitForElementToBeClickable(By.XPath(ClickLinkToTransportQueueGroupXpath));

            ClickLinkToTransportQueueGroup.Click();
            return this;
        }

        public BCOutboundPage2 ActionsandTransportFromMoreOptions()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ActionsXpath))
                .WaitForElementToBeClickable(By.XPath(ActionsXpath));

            Actions.Click();
            TransportTab.Click();

            return this;
        }

        public BCOutboundPage2 ActionsandTransportFromMoreOptionsInTROCard()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ActionsXpath))
                .WaitForElementToBeClickable(By.XPath(ActionsXpath));

            Actions.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(TransportTabAfterActionInTROXpath))
                .WaitForElementToBeClickable(By.XPath(TransportTabAfterActionInTROXpath));

            TransportTabAfterActionInTRO.Click();

            return this;
        }

        public BCOutboundPage2 ClickPalletPoolTROTransport()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(PalletPoolTROTransportXpath))
                .WaitForElementToBeClickable(By.XPath(PalletPoolTROTransportXpath));

            PalletPoolTROTransport.Click();
            return this;
        }

        public BCOutboundPage2 WaitForUnlinkingNotificationToAppear()
        {
            WaitMethods.WaitForPageToBeReady();
            WaitMethods.WaitForElementToAppear(By.XPath(IShouldGetErrorForUnlinkingTRONotificationXpath), 10);

            return this;
        }

        public BCOutboundPage2 WaitForUnlinkingCancelledNotificationAppear()
        {
            WaitMethods.WaitForPageToBeReady();
            WaitMethods.WaitForElementToAppear(By.XPath(UnlinkingCancelledNotificationXpath), 10);

            return this;
        }

        public BCOutboundPage2 CloseTransportFromActionsTransport()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(CloseTROActionsXpath))
                .WaitForElementToBeClickable(By.XPath(CloseTROActionsXpath));

            CloseTROActions.Click();
            return this;
        }

        public BCOutboundPage2 ClickCloseTransportTRO()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(CloseTransportTROXpath))
                .WaitForElementToBeClickable(By.XPath(CloseTransportTROXpath));

            CloseTransportTRO.Click();
            return this;
        }

        public BCOutboundPage2 WaitForErrorTroNotificationPopUp(string expectedErrorTRO)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(IShouldSeePopupMessageErrorAfterCLOSETROXpath),5)
                .WaitForElementToBePresent(By.XPath(IShouldSeePopupMessageErrorAfterCLOSETROXpath));

            Assert.Contains(expectedErrorTRO, BCOutboundPage1.IShouldSeePopupMessageErrorAfterCLOSEINGTRO);

            return this;
        }

        public BCOutboundPage2 FillUnitOnPowerPalletPoolTransportOut(string Unit)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EnterUnitPalletPoolTransportTROXpath))
                .WaitForElementToBeClickable(By.XPath(EnterUnitPalletPoolTransportTROXpath));

            EnterUnitPalletPoolTransportTRO.Click();


            EnterUnitPalletPoolTransportTRO.SendKeys(Unit + Keys.Enter);
            return this;
        }

        public BCOutboundPage2 WriteQtyInPalletPoolTransportOut(string Qty)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(InsertQTYXpath))
                .WaitForElementToBeClickable(By.XPath(InsertQTYXpath));

            InsertQTY.Click();
            InsertQTY.SendKeys(Qty);
            InsertQTY.SendKeys(Keys.Tab);

            return this;
        }

        public BCOutboundPage2 GoBackTransportOutboundToMainPages()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(GoBackTransportOutboundToMainPageXpath))
                .WaitForElementToBeClickable(By.XPath(GoBackTransportOutboundToMainPageXpath));

            GoBackTransportOutboundToMainPage.Click();
            return this;
        }

        public BCOutboundPage2 GoBackTransportOutboundsCard()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(GoBackTransportOutboundCardXpath))
                .WaitForElementToBeClickable(By.XPath(GoBackTransportOutboundCardXpath));

            GoBackTransportOutboundCard.Click();
            return this;
        }

        public BCOutboundPage2 ClickActionsTRO()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickActions_TROXpath))
                .WaitForElementToBeClickable(By.XPath(ClickActions_TROXpath));

            ClickActions_TRO.Click();
            return this;
        }

        public BCOutboundPage2 ClickMainMenu_TRO()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(MainMenu_TROXpath))
                .WaitForElementToBeClickable(By.XPath(MainMenu_TROXpath));

            MainMenu_TRO.Click();

            return this;
        }

        public BCOutboundPage2 ClickTransport_TROs()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickTransport_TROXpath))
                .WaitForElementToBeClickable(By.XPath(ClickTransport_TROXpath));

            ClickTransport_TRO.Click();
            return this;
        }

        public BCOutboundPage2 ClickTransportInTROCard()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickTransportInTRO_CardXpath))
                .WaitForElementToBeClickable(By.XPath(ClickTransportInTRO_CardXpath));

            ClickTransportInTRO_Card.Click();
            return this;
        }

        public BCOutboundPage2 ClickProcessOutboundList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickProcessOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(ClickProcessOutboundXpath));

            ClickProcessOutbound.Click();
            return this;
        }

        public BCOutboundPage2 ClickUnlinkSelectedFromTransportPOWOutList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickUnlinkSelectedPOWOutListXpath))
                .WaitForElementToBeClickable(By.XPath(ClickUnlinkSelectedPOWOutListXpath));

            ClickUnlinkSelectedPOWOutList.Click();
            return this;
        }
        public BCOutboundPage2 ClickTransportTabMain_TROs()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickTransportTabMain_TROXpath))
                .WaitForElementToBeClickable(By.XPath(ClickTransportTabMain_TROXpath));

            ClickTransportTabMain_TRO.Click();
            return this;
        }

        public BCOutboundPage2 ClickViewLinkedQueueGroups()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ViewLinkedQueueGroupsXpath))
                .WaitForElementToBeClickable(By.XPath(ViewLinkedQueueGroupsXpath));

            ViewLinkedQueueGroups.Click();
            return this;
        }

        public BCOutboundPage2 ClickLinkQueueGruopPicking_TROs()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickLinkQueueGruopPicking_TROXpath))
                .WaitForElementToBeClickable(By.XPath(ClickLinkQueueGruopPicking_TROXpath));

            ClickLinkQueueGruopPicking_TRO.Click();
            return this;
        }

        public BCOutboundPage2 IClickLinkToATransports()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(IClickLinkToATransportXpath))
                .WaitForElementToBeClickable(By.XPath(IClickLinkToATransportXpath));

            IClickLinkToATransport.Click();
            return this;
        }

        public BCOutboundPage2 ClickOnSecondLinePOWERQUEUEGROUPLISTs()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickOnSecondLinePOWERQUEUEGROUPLISTXpath))
                .WaitForElementToBeClickable(By.XPath(ClickOnSecondLinePOWERQUEUEGROUPLISTXpath));

            ClickOnSecondLinePOWERQUEUEGROUPLIST.Click();

            return this;
        }
        public BCOutboundPage2 SelectViewLinkedQueueGroups_TRO()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ViewLinkedQueueGroupsXpath))
                .WaitForElementToBeClickable(By.XPath(ViewLinkedQueueGroupsXpath));

            ViewLinkedQueueGroups.Click();
            return this;
        }

        public BCOutboundPage2 ClickThreeDotsOnTROQueueGroupList_TRO()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ThreeDotsOnTROQueueGroupList_TROXpath))
                .WaitForElementToBeClickable(By.XPath(ThreeDotsOnTROQueueGroupList_TROXpath));

            ThreeDotsOnTROQueueGroupList_TRO.Click();
            return this;
        }

        public BCOutboundPage2 ClickActionsOnDropdown_TROQueueGroupList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ActionsOnDropdown_TROQueueGroupListXpath))
                .WaitForElementToBeClickable(By.XPath(ActionsOnDropdown_TROQueueGroupListXpath));

            ActionsOnDropdown_TROQueueGroupList.Click();

            QueueGroupOnDropdown_TROQueueGroupList.Click();
            return this;
        }

        public BCOutboundPage2 ClickQueueGroupOnDropdown_TROQueueGroupList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(QueueGroupOnDropdown_TROQueueGroupListXpath))
                .WaitForElementToBeClickable(By.XPath(QueueGroupOnDropdown_TROQueueGroupListXpath));

            QueueGroupOnDropdown_TROQueueGroupList.Click();
            return this;
        }

        public BCOutboundPage2 ClickActionsFromMoreOptions()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ActionsXpath))
                .WaitForElementToBeClickable(By.XPath(ActionsXpath));

            Actions.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(TransportTabAfterActionInTROXpath))
                .WaitForElementToBeClickable(By.XPath(TransportTabAfterActionInTROXpath));

            TransportTabAfterActionInTRO.Click();
            return this;
        }

        public BCOutboundPage2 ClickOtherInActionTRI()
        {
            
            WaitMethods.WaitForElementToAppear(By.XPath(TRIActionOtherXpath))
               .WaitForElementToBeClickable(By.XPath(TRIActionOtherXpath));

            Driver.FindElement(By.XPath(TRIActionOtherXpath)).Click();
            return this;
        }

        public BCOutboundPage2 ClickInvoceInTRIActionMenu()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("//div[contains(text(), 'Invoice')]"))
                .WaitForElementToBeClickable(By.XPath("//div[contains(text(), 'Invoice')]"));

            Driver.FindElement(By.XPath("//div[contains(text(), 'Invoice')]")).Click();
            return this;
        }

        public BCOutboundPage2 ClickNEWInPOWERPrestations()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("(//span[contains(text(), 'New')])[2]"))
                .WaitForElementToBeClickable(By.XPath("(//span[contains(text(), 'New')])[2]"));

            Driver.FindElement(By.XPath("(//span[contains(text(), 'New')])[2]")).Click();


            WaitMethods.WaitForElementToAppear(By.XPath("(//span[contains(text(), 'New')])[3]"))
                .WaitForElementToBeClickable(By.XPath("(//span[contains(text(), 'New')])[3]"));

            Driver.FindElement(By.XPath("(//span[contains(text(), 'New')])[3]")).Click();
            return this;
        }

       

        public BCOutboundPage2 AddPrestionDetail()
        {


            WaitMethods.WaitForElementToAppear(By.XPath("//input[starts-with(@aria-label,'Prestationcode')]"))
              .WaitForElementToBeClickable(By.XPath("//input[starts-with(@aria-label,'Prestationcode')]"));
            Driver.FindElement(By.XPath("//input[starts-with(@aria-label,'Prestationcode')]")).Click();

            WaitMethods.WaitForElementToAppear(By.XPath("//a[contains(text(), 'NAF')]"))
             .WaitForElementToBeClickable(By.XPath("//a[contains(text(), 'NAF')]"));
            Driver.FindElement(By.XPath("//a[contains(text(), 'NAF')]")).Click();

            

            return this;
        }

    public BCOutboundPage2 AddPurchaseInvoce()
        {
            WaitMethods.WaitForElementToAppear(By.XPath("(//input[starts-with(@aria-label,'Purchase Amount, ')])[2]"))
             .WaitForElementToBeClickable(By.XPath("(//input[starts-with(@aria-label,'Purchase Amount, ')])[2]"));
            Driver.FindElement(By.XPath("(//input[starts-with(@aria-label,'Purchase Amount, ')])[2]")).Click();
            Driver.FindElement(By.XPath("(//input[starts-with(@aria-label,'Purchase Amount, ')])[2]")).SendKeys("1");

            WaitMethods.WaitForElementToAppear(By.XPath("//input[starts-with(@aria-label,'Purchase Invoice, (Blank)')]"))
             .WaitForElementToBeClickable(By.XPath("//input[starts-with(@aria-label,'Purchase Invoice, (Blank)')]"));
            Driver.FindElement(By.XPath("//input[starts-with(@aria-label,'Purchase Invoice, (Blank)')]")).Click();
            Driver.FindElement(By.XPath("//input[starts-with(@aria-label,'Purchase Invoice, (Blank)')]")).SendKeys("1");

            return this;
        }
        public BCOutboundPage2 ClickActionsOnOpenedCard_QueueGroupList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ActionsXpath))
                .WaitForElementToBeClickable(By.XPath(ActionsXpath));

            Actions.Click();
            return this;
        }

        public BCOutboundPage2 ClickDeleteLinkedTransportPicking_TROQueueGroupList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(DeleteLinkedTransportPicking_TROQueueGroupListXpath))
                .WaitForElementToBeClickable(By.XPath(DeleteLinkedTransportPicking_TROQueueGroupListXpath));

            DeleteLinkedTransportPicking_TROQueueGroupList.Click();
            return this;
        }

        public BCOutboundPage2 ClickCloseAfterOpenedCards()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickCloseAfterOpenedCardXpath))
                .WaitForElementToBeClickable(By.XPath(ClickCloseAfterOpenedCardXpath));

            ClickCloseAfterOpenedCard.Click();

            return this;
        }

        public BCOutboundPage2 EnterCopiedOutboundsOnInputFilterQueueGroupList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(InputFieldFilterQueueGroupListXpath))
                .WaitForElementToBeClickable(By.XPath(InputFieldFilterQueueGroupListXpath));

            InputFieldFilterQueueGroupList.SendKeys(DataCollection.OutboundCodeFromNewOutbound + "|" + DataCollection.SecondOutboundCode);

            InputFieldFilterQueueGroupList.SendKeys(Keys.Tab);

            return this;
        }

        public BCOutboundPage2 ClickGoBack_Quegroup()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(GoBackFromQuegroupXpath))
                .WaitForElementToBeClickable(By.XPath(GoBackFromQuegroupXpath));

            GoBackFromQuegroup.Click();
            return this;
        }

        public BCOutboundPage2 ClickTransportOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(TransportOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(TransportOutboundXpath));

            TransportOutbound.Click();

            return this;
        }

        public BCOutboundPage2 IClickShowFilterPaneForTransportOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ShowFilterPaneTransportOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(ShowFilterPaneTransportOutboundXpath));

            ShowFilterPaneTransportOutbound.Click();

            return this;
        }

        public BCOutboundPage2 IClickFilterInTransportOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(FilterInTransportOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(FilterInTransportOutboundXpath));

            FilterInTransportOutbound.Click();

            return this;
        }

        public BCOutboundPage2 IClickDeleteInTransportOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(DeleteInTransportOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(DeleteInTransportOutboundXpath));

            DeleteInTransportOutbound.Click();

            return this;
        }

        public BCOutboundPage2 IClickYesToConfirmDeletingTRO()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickYesOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(ClickYesOutboundXpath));

            ClickYesOutbound.Click();

            return this;
        }

        public BCOutboundPage2 ClickReportsFromMainPage()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ReportsMainPageXpath))
                .WaitForElementToBeClickable(By.XPath(ReportsMainPageXpath));

            ReportsMainPage.Click();

            return this;
        }

        public BCOutboundPage2 ClickDestinationGrooup()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(DestinationGroupXpath))
                .WaitForElementToBeClickable(By.XPath(DestinationGroupXpath));

            DestinationGroup.Click();

            return this;
        }

        public BCOutboundPage2 HoverOverErrorMessage()
        {
            WaitMethods.WaitForPageToBeReady();

            WaitMethods.WaitForElementToAppear(By.XPath(DestinationGroupErrorMessageQGXpath), 10);

            IWebElement errorMessage = Driver.FindElement(By.XPath(DestinationGroupErrorMessageQGXpath));

            Actions action = new Actions(Driver);

            action.MoveToElement(errorMessage).Perform();

            return this;
        }

        public BCOutboundPage2 Enter_DestinationGroup(string DestinationGroupString)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(DestinationGroupEnterDPDInputXpath), 10)
                .WaitForElementToBeClickable(By.XPath(DestinationGroupEnterDPDInputXpath));

            DestinationGroupEnterDPDInput.Click();
            DestinationGroupEnterDPDInput.SendKeys(DestinationGroupString + Keys.Tab);
            DestinationGroupEnterDPDInput.SendKeys(Keys.Tab);

            //WaitMethods.WaitForElementToBePresent(By.XPath("//input[starts-with(@aria-label,'Destination Group')]"));
            //IWebElement ContactPalletpool = Driver.FindElement(By.XPath("//input[contains(@aria-label,'Destination Group, ')]"));
            //WaitMethods.RepeatUntil(
            //() =>
            //{
            //    ContactPalletpool.Click();
            //    ContactPalletpool.SendKeys(DestinationGroupString + Keys.Tab);
            //},
            //_ => ContactPalletpool.GetAttribute("value").Equals(DestinationGroupString),
            //TimeSpan.FromSeconds(2), 5
            //);

            return this;
        }

        public BCOutboundPage2 Enter_DestinationGroupWhenDeleteTRO(string DestinationGroupString)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(DestinationGroupEnterDPDInputXpath), 10)
                .WaitForElementToBeClickable(By.XPath(DestinationGroupEnterDPDInputXpath));

            DestinationGroupEnterDPDInput.Click();
            DestinationGroupEnterDPDInput.SendKeys(DestinationGroupString + Keys.Tab);
            DestinationGroupEnterDPDInput.SendKeys(Keys.Tab);

            //WaitMethods.RepeatUntil(
            //() =>
            //{
            //    DestinationGroupEnterDPDInput.Click();
            //    DestinationGroupEnterDPDInput.SendKeys(DestinationGroupString + Keys.Tab);
            //    DestinationGroupEnterDPDInput.SendKeys(Keys.Tab);
            //},
            //_ => AlreadyFilledDestinationGroup.GetAttribute("value").Equals(DestinationGroupString),
            //TimeSpan.FromSeconds(2), 5
            //);

            return this;
        }

        public BCOutboundPage2 SearchTROWithFixedValue(string TRO)
        {
            WaitMethods.RepeatUntil(
            () =>
            {
                WaitMethods.WaitForElementToAppear(By.XPath(SearchButtonTRO_PowerTransporOutboundListXpath))
                .WaitForElementToBeClickable(By.XPath(SearchButtonTRO_PowerTransporOutboundListXpath));
                SearchButtonTRO_PowerTransporOutboundList.Click();
                SearchButtonTRO_PowerTransporOutboundList.SendKeys(Keys.Control + "a");
                SearchButtonTRO_PowerTransporOutboundList.SendKeys(Keys.Delete);

                WaitMethods.WaitForElementToAppear(By.XPath(SearchInputTRO_PowerTransporOutboundListXpath))
                    .WaitForElementToBeClickable(By.XPath(SearchInputTRO_PowerTransporOutboundListXpath));
                SearchInputTRO_PowerTransporOutboundList.SendKeys(TRO);
                SearchInputTRO_PowerTransporOutboundList.SendKeys(Keys.Enter);

                WaitMethods.WaitForElementToAppear(By.XPath($"//input[@value='{TRO}']"), 3);
            },
            _ => Driver.FindElements(By.XPath($"//input[@value='{TRO}']")).Count > 0,
            TimeSpan.FromSeconds(2), 5,
            null,
            () =>
            {
                BCOutboundPage1.ClickBackButtonGenerals();
                BCOutboundPage1.SwitchToMainContentFrame();
                BCOutboundPage1.ClickTRIMainPage();
            }
            );

            return this;
        }

        public BCOutboundPage2 SearchForATROWithFixedValue(string TRO)
        {

            WaitMethods.WaitForElementToAppear(By.XPath(SearchButtonTROOutboundListXpath))
                .WaitForElementToBeClickable(By.XPath(SearchButtonTROOutboundListXpath));

            SearchButtonTROOutboundList.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(SearchBoxXpath))
                .WaitForElementToBeClickable(By.XPath(SearchBoxXpath));

            SearchBox.SendKeys(TRO + Keys.Tab);

            WaitMethods.WaitForPageToBeReady();

            return this;
        }

        public BCOutboundPage2 GoBackFromDestinationGroups()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(GoBackFromDestinationGroupXpath))
                .WaitForElementToBeClickable(By.XPath(GoBackFromDestinationGroupXpath));

            GoBackFromDestinationGroup.Click();
            return this;
        }

        public BCOutboundPage2 GoBackFromDestinationGroupTROMains()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(GoBackFromDestinationGroupTROMainXpath))
                .WaitForElementToBeClickable(By.XPath(GoBackFromDestinationGroupTROMainXpath));

            GoBackFromDestinationGroupTROMain.Click();

            return this;
        }

        public string GetTheValue_TRO()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(TransportNoXpath))
                .WaitForElementToBeClickable(By.XPath(TransportNoXpath));

            DataCollection.TROCodeFromNewTRO = Driver.FindElement(By.XPath(TransportNoXpath)).Text;

            return DataCollection.TROCodeFromNewTRO;
        }

        public BCOutboundPage2 FillInOnlineOrderNumber(string value)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(FillOnlineOrderNumberXpath))
                .WaitForElementToBeClickable(By.XPath(FillOnlineOrderNumberXpath));

            FillOnlineOrderNumber.Click();
            FillOnlineOrderNumber.SendKeys(value);

            return this;
        }

        public BCOutboundPage2 GoBackToLinkFromNewTROs()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(GoBackToLinkFromNewTROXpath))
                .WaitForElementToBeClickable(By.XPath(GoBackToLinkFromNewTROXpath));

            GoBackToLinkFromNewTRO.Click();

            return this;
        }

        public BCOutboundPage2 SearchTRO_PowerTransporOutboundList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(SearchButtonTRO_PowerTransporOutboundListXpath))
                .WaitForElementToBeClickable(By.XPath(SearchButtonTRO_PowerTransporOutboundListXpath));

            SearchButtonTRO_PowerTransporOutboundList.Click();

            SearchInputTRO_PowerTransporOutboundList.SendKeys("TRO-001002"/*DataCollection.TROCodeFromNewTRO*/);

            return this;
        }

        public BCOutboundPage2 SearchTROInput_PowerTransporOutboundList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(SearchButtonTRO_PowerTransporOutboundListXpath))
                .WaitForElementToBeClickable(By.XPath(SearchButtonTRO_PowerTransporOutboundListXpath));

            SearchButtonTRO_PowerTransporOutboundList.Click();

            //SearchInputTRO_PowerTransporOutboundList.SendKeys("TRO-001002"/*DataCollection.TROCodeFromNewTRO*/);

            return this;
        }

        public BCOutboundPage2 SearchTROList(string troToSearch)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(SearchButtonTransporOutboundListXpath))
                .WaitForElementToBeClickable(By.XPath(SearchButtonTransporOutboundListXpath));

            SearchButtonTransporOutboundList.Click();
            SearchInputTransporOutboundList.SendKeys(troToSearch);

            return this;
        }

        public BCOutboundPage2 ClickEditTROList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EditButtonTransporOutboundListXpath))
                .WaitForElementToBeClickable(By.XPath(EditButtonTransporOutboundListXpath));

            EditButtonTransporOutboundList.Click();

            return this;
        }

        public BCOutboundPage2 ClickEditFromTheNavigationBarInTransportOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickEditFromTheNavigationBarInEDIMESSAGELOGLISTXpath))
                .WaitForElementToBeClickable(By.XPath(ClickEditFromTheNavigationBarInEDIMESSAGELOGLISTXpath));

            ClickEditFromTheNavigationBarInEDIMESSAGELOGLIST.Click();

            return this;
        }

        public BCOutboundPage2 ClickReportsButtonInTransportOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickReportsInTransportOutboundXpath))
                .WaitForElementToBeClickable(By.XPath(ClickReportsInTransportOutboundXpath));

            ClickReportsInTransportOutbound.Click();

            return this;
        }

        public BCOutboundPage2 ClickLoadingOrderFromReportsFromTRO()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickLoadingOrderFromReportsTROXpath))
                .WaitForElementToBeClickable(By.XPath(ClickLoadingOrderFromReportsTROXpath));

            ClickLoadingOrderFromReportsTRO.Click();

            return this;
        }

        public BCOutboundPage2 ClickPrintLoadingOrder()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickPrintFromLoadingOrderXpath))
                .WaitForElementToBeClickable(By.XPath(ClickPrintFromLoadingOrderXpath));

            ClickPrintFromLoadingOrder.Click();

            return this;
        }


        public BCOutboundPage2 TransportButton()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(TransportButtonInTROXpath))
                .WaitForElementToAppear(By.XPath(TransportButtonInTROXpath))
                .WaitForElementToBeClickable(By.XPath(TransportButtonInTROXpath));

            TransportButtonInTRO.Click();

            return this;
        }

        public BCOutboundPage2 ISelectPOWCreateNewTROsFromTheList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(POWCreateNewTROsFromTheListXpath))
                .WaitForElementToBeClickable(By.XPath(POWCreateNewTROsFromTheListXpath));

            POWCreateNewTROsFromTheList.Click();

            return this;
        }

        public BCOutboundPage2 IClickPrintReports()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(PrintInReportsXpath))
                .WaitForElementToBeClickable(By.XPath(PrintInReportsXpath));

            PrintInReports.Click();

            return this;
        }

        public BCOutboundPage2 ISelectImportRadioButton()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ImportRadioButtonXpath))
                .WaitForElementToBeClickable(By.XPath(ImportRadioButtonXpath));

            ImportRadioButton.Click();

            WaitMethods.WaitForPageToBeReady();

            return this;
        }

        public BCOutboundPage2 ClickShowFiltersPaneForEDIMessageLogListSecondTime()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickShowFilterPaneForEDIMessageLogListSecondTimeXpath))
                .WaitForElementToBeClickable(By.XPath(ClickShowFilterPaneForEDIMessageLogListSecondTimeXpath));

            ClickShowFilterPaneForEDIMessageLogListSecondTime.Click();

            return this;
        }

        public BCOutboundPage2 SearchTRO_PowerTransportOutboundList(string TroForLinkWithOutbound)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(SearchButtonTRO_PowerTransporOutboundListXpath))
                .WaitForElementToBeClickable(By.XPath(SearchButtonTRO_PowerTransporOutboundListXpath));

            SearchButtonTRO_PowerTransporOutboundList.Click();

            SearchInputTRO_PowerTransporOutboundList.SendKeys(TroForLinkWithOutbound);
            SearchInputTRO_PowerTransporOutboundList.SendKeys(Keys.Enter);

            return this;
        }

        public BCOutboundPage2 ClickOK_PowerTransportOutboundList()
        {
            //WaitMethods.WaitForElementToAppear(By.XPath(ClickOKButtonOfPopupMainPageXpath))
            //.WaitForElementToBeClickable(By.XPath(ClickOKButtonOfPopupMainPageXpath));
            Driver.FindElement(By.XPath(ClickOKButtonOfPopupMainPageXpath));

            ClickOKButtonOfPopupMainPage.Click();

            return this;
        }

        public BCOutboundPage2 IClickOkInBatchList()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickOKButtonOfPopupMainPageXpath))
                .WaitForElementToBeClickable(By.XPath(ClickOKButtonOfPopupMainPageXpath));

            ClickOKButtonOfPopupMainPage.Click();

            WaitMethods.WaitForElementToBeGone(By.XPath(ClickOKButtonOfPopupMainPageXpath), 10);

            return this;
        }

        public BCOutboundPage2 IClickOnBatchNumberInQueueGroupList()
        {
            WaitMethods.WaitForPageToBeReady(10);

            WaitMethods.WaitForElementToAppear(By.XPath(BatchNumberQueueGroupListXpath), 15)
                .WaitForElementToBeClickable(By.XPath(BatchNumberQueueGroupListXpath));

            WaitMethods.WaitForElementToBeClickable(By.XPath(BatchNumberQueueGroupListXpath));

            BatchNumberQueueGroupList.Click();

            return this;
        }

        public BCOutboundPage2 IDeleteBatchNumber()
        {
            WaitMethods.WaitForPageToBeReady(2);

            WaitMethods.WaitForElementToAppear(By.XPath(DeleteBatchNumberXpath), 2)
                .WaitForElementToBeClickable(By.XPath(DeleteBatchNumberXpath));

            WaitMethods.WaitForElementToBeClickable(By.XPath(DeleteBatchNumberXpath));

            DeleteBatchNumber.Click();

            return this;
        }

        public BCOutboundPage2 IClickMoreOptionsBatchTable()
        {
            WaitMethods.WaitForPageToBeReady(2);

            WaitMethods.WaitForElementToAppear(By.XPath(MoreOptionsBatchTableXpath), 2)
                .WaitForElementToBeClickable(By.XPath(MoreOptionsBatchTableXpath));

            WaitMethods.WaitForElementToBeClickable(By.XPath(MoreOptionsBatchTableXpath));

            MoreOptionsBatchTable.Click();

            return this;
        }

        public BCOutboundPage2 IClickEditInPOWBatchList()
        {
            WaitMethods.WaitForPageToBeReady();

            WebDriverWait waitfirst = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            waitfirst.Until(c => c.FindElement(By.XPath(ShowMoreInBatchXpath)).Displayed);
            ShowMoreInBatch.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(EditInPOWBatchListXpath))
                .WaitForElementToBeClickable(By.XPath(EditInPOWBatchListXpath));

            EditInPOWBatchList.Click();

            WaitMethods.WaitForElementToBeGone(By.XPath(EditInPOWBatchListXpath));

            return this;
        }

        public BCOutboundPage2 OperationOverviewMenu()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(OpertionOverviewsXpath))
                .WaitForElementToBeClickable(By.XPath(OpertionOverviewsXpath));

            OperationOverviews.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(QueueOverviewXpath))
                .WaitForElementToBeClickable(By.XPath(QueueOverviewXpath));

            QueueOverview.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(QueueGroupDropdownXpath))
               .WaitForElementToBeClickable(By.XPath(QueueGroupDropdownXpath));
            QueueGroupDropdown.Click();

            return this;
        }
        public BCOutboundPage2 ClickAndSendCodeInQueueGroup(string p0)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(CodeInQueueGroupXpath))
                .WaitForElementToBeClickable(By.XPath(CodeInQueueGroupXpath));

            CodeInQueueGroup.Click();
            CodeInQueueGroup.SendKeys(p0 + Keys.Tab);
            return this;
        }
        public BCOutboundPage2 ClickBatchManagementFromOperationsOverviews()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(OpertionOverviewsXpath))
                .WaitForElementToBeClickable(By.XPath(OpertionOverviewsXpath));

            OperationOverviews.Click();
            BatchManagement.Click();

            return this;
        }

        public BCOutboundPage2 IClickHolderRetrievals()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(IClickHolderRetrievalXpath)).Displayed);
            IClickHolderRetrieval.Click();

            return this;
        }

        public BCOutboundPage2 IClickManageHolderRetrievals()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(IClickManageHolderRetrievalXpath)).Displayed);
            IClickManageHolderRetrieval.Click();

            return this;
        }

        public BCOutboundPage2 IShouldSeePopupMessageAfterLinkWithWrongTROsDestinationGroup(string IShouldSeePopupMessageAfterLinkWithWrongTROsDestinationGroup)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(IShouldSeePopupMessageAfterLinkWithWrongTRODestinationGroupXpath));
            Assert.Contains(IShouldSeePopupMessageAfterLinkWithWrongTROsDestinationGroup, IShouldSeePopupMessageAfterLinkWithWrongTRODestinationGroup.Text);

            return this;
        }
        public BCOutboundPage2 ClickBackButtonInGenerals()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ProgressBarXPath), 15)
            .WaitForElementToBeGone(By.XPath(ProgressBarXPath))
            .WaitForElementToAppear(By.XPath(BackButtonInGeneralXpath), 10)
            .WaitForElementToBeClickable(By.XPath(BackButtonInGeneralXpath));

            Driver.FindElement(By.XPath(BackButtonInGeneralXpath)).Click();
            WaitMethods.WaitForElementToBeGone(By.XPath(BackButtonInGeneralXpath), 10);

            return this;
        }

        public BCOutboundPage2 ClickBackButtonFromOutbounds()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(BackButtonInGeneralXpath), 7)
            .WaitForElementToBeClickable(By.XPath(BackButtonInGeneralXpath));

            Driver.FindElement(By.XPath(BackButtonInGeneralXpath)).Click();
            WaitMethods.WaitForElementToBeGone(By.XPath(BackButtonInGeneralXpath), 10);

            return this;
        }

        public BCOutboundPage2 ClickRefreshButtonFPFB()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ProgressBarXPath), 15)
            .WaitForElementToBeGone(By.XPath(ProgressBarXPath));
            Driver.Navigate().Refresh();

            return this;
        }

        public BCOutboundPage2 ChangeTheStatusOfTheQueueGroupListToCreated()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(StatusOfQueueGroupXpath), 15);

            var selectStatus = Driver.FindElement(By.XPath(StatusOfQueueGroupXpath));

            var selectElement = new SelectElement(selectStatus);

            selectElement.SelectByText("Created");

            WaitMethods.WaitForPageToBeReady();

            return this;
        }

        public BCOutboundPage2 ChangeTheStatusOfTheQueueGroupListToAll()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(StatusOfQueueGroupXpath), 15);

            var selectStatus = Driver.FindElement(By.XPath(StatusOfQueueGroupXpath));

            var selectElement = new SelectElement(selectStatus);

            selectElement.SelectByText("All");

            WaitMethods.WaitForPageToBeReady();

            WaitMethods.WaitForElementToAppear(By.XPath(ProgressBarXPath), 15)
            .WaitForElementToBeGone(By.XPath(ProgressBarXPath));

            return this;
        }

    }
}
