using CGI_OUTBOUND_BC_Scenarios.OUTBOUND.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace CGI_OUTBOUND_BC_Scenarios.OUTBOUND.Steps
{
    [Binding]
    public class BCOutboundSteps2
    {
        public IWebDriver Driver;

        public BCOutboundSteps2(IWebDriver driver) => Driver = driver;

        private BCOutboundPage1 BCOutboundPage1 => new BCOutboundPage1(Driver);
        private BCOutboundPage2 BCOutboundPage2 => new BCOutboundPage2(Driver);
        private BCOutboundPage3 BCOutboundPage3 => new BCOutboundPage3(Driver);
        private BCOutboundPage4 BCOutboundPage4 => new BCOutboundPage4(Driver);
        private BCOutboundPage5 BCOutboundPage5 => new BCOutboundPage5(Driver);
        private BCOutboundPage6 BCOutboundPage6 => new BCOutboundPage6(Driver);
        private BCOutboundPage7 BCOutboundPage7 => new BCOutboundPage7(Driver);

        [Given(@"I Click Actions on Opened Card -> QueueGroupList")]
        public void GivenIClickActionsOnOpenedCard_QueueGroupList()
        {
            BCOutboundPage2.ClickActionsOnOpenedCard_QueueGroupList();
        }

        [Given(@"I click Delete Linked Transport\(picking\) -> TRO Queue group List")]
        public void GivenIClickDeleteLinkedTransportPicking_TROQueueGroupList()
        {
            BCOutboundPage2.ClickDeleteLinkedTransportPicking_TROQueueGroupList();
        }


        [Given(@"I Click Close after Opened Card -> Quegroup")]
        public void GivenIClickCloseAfterOpenedCard()
        {
            BCOutboundPage2.ClickCloseAfterOpenedCards();
        }

        [Given(@"I click Go Back -> Quegroup")]
        public void GivenIClickGoBack_Quegroup()
        {
            BCOutboundPage2.ClickGoBack_Quegroup();
        }

        [Given(@"I click Transport Outbound")]
        public void GivenIClickTransportOutbound()
        {

            BCOutboundPage2.ClickTransportOutbound();
        }

        [Given(@"I click show filter pane for Transport Outbound")]
        public void GivenIClickShowFilterPaneForTransportOutbound()
        {

            BCOutboundPage2.IClickShowFilterPaneForTransportOutbound();
        }

        [Given(@"I click filter in Transport Outbound")]
        public void GivenIClickFilterInTransportOutbound()
        {

            BCOutboundPage2.IClickFilterInTransportOutbound();
        }

        [Given(@"I click delete -> Transport Outbound")]
        public void GivenIClickDeleteInTransportOutbound()
        {

            BCOutboundPage2.IClickDeleteInTransportOutbound();
        }

        [Given(@"I click yes to confirm deleting TRO")]
        public void GivenIClickYesToConfirmDeletingTRO()
        {

            BCOutboundPage2.IClickYesToConfirmDeletingTRO();
        }

        [Given(@"I Click Destination Group")]
        public void GivenIClickDestinationGrooup()
        {
            BCOutboundPage2.ClickDestinationGrooup();
        }

        [Given(@"I hover over error message")]
        public void GivenIHoverOverErrorMessage()
        {
            BCOutboundPage2.HoverOverErrorMessage();
        }

        [Given(@"I enter '(.*)' -> Destination Group")]
        public void GivenIEnter_DestinationGroup(string DestinationGroupString)
        {
            BCOutboundPage2.Enter_DestinationGroup(DestinationGroupString);
        }

        [Given(@"I enter '(.*)' -> Destination Group when delete TRO")]
        public void GivenIEnter_DestinationGroupWhenDeleteTRO(string DestinationGroupString)
        {
            BCOutboundPage2.Enter_DestinationGroupWhenDeleteTRO(DestinationGroupString);
        }

        [Given(@"I go back from Destination Group")]
        public void GivenIGoBackFromDestinationGroup()
        {
            BCOutboundPage2.GoBackFromDestinationGroups();
        }

        [Given(@"I go back from Destination Group -> TRO Main")]
        public void GivenIGoBackFromDestinationGroup_TROMain()
        {
            BCOutboundPage2.GoBackFromDestinationGroupTROMains();
        }


        [Given(@"I get the Value -> TRO")]
        public void GivenIGetTheValue_TRO()
        {
            BCOutboundPage2.GetTheValue_TRO();
        }

        [Given(@"I go back to link from new TRO")]
        public void GivenIGoBackToLinkFromNewTRO()
        {
            BCOutboundPage2.GoBackToLinkFromNewTROs();
        }

        [Given(@"I search TRO -> Power Transport Outbound List")]
        public void GivenISearchTRO_PowerTransporOutboundList()
        {
            BCOutboundPage2.SearchTRO_PowerTransporOutboundList();
        }


        [Given(@"I search TRO input -> Power Transport Outbound List")]
        public void GivenISearchTROInput_PowerTransporOutboundList()
        {
            BCOutboundPage2.SearchTROInput_PowerTransporOutboundList();
        }


        [Given(@"I search TRO '(.*)' -> TRO List")]
        public void GivenISearchTRO_TROList(string troToSearch)
        {
            BCOutboundPage2.SearchTROList(troToSearch);
        }

        [Given(@"I click Edit -> TRO List")]
        public void GivenIClickEdit_TROList()
        {
            BCOutboundPage2.ClickEditTROList();
        }



        [Given(@"I search a TRO with fixed value '(.*)' -> Power Transport Outbound List")]
        public void GivenISearchATROWithFixedValue_PowerTransportOutboundList(string TRO)
        {
            BCOutboundPage2.SearchTROWithFixedValue(TRO);
        }

        [Given(@"I search TRO with fixed value '(.*)' in POWER Transport Outbound List")]
        public void GivenISearchTROWithFixedValue_POWERTransportOutboundList(string TRO)
        {
            BCOutboundPage2.SearchForATROWithFixedValue(TRO);
        }

        [Given(@"I click Edit from the navigation bar in Transport Outbound")]
        public void GivenIClickEditFromTheNavigationBarInTransportOutbound()
        {
            BCOutboundPage2.ClickEditFromTheNavigationBarInTransportOutbound();
        }

        [Given(@"I click Reports in Transport Outbound")]
        public void GivenIClickReportsInTransportOutbound()
        {
            BCOutboundPage2.ClickReportsButtonInTransportOutbound();
        }

        [Given(@"I click loading order from reports in Transport Outbound")]
        public void GivenIClickLoadingOrderFromReports()
        {
            BCOutboundPage2.ClickLoadingOrderFromReportsFromTRO();
        }

        [Given(@"I click print loading order -> TRO")]
        public void GivenIClickPrintLoadingOrder()
        {
            BCOutboundPage2.ClickPrintLoadingOrder();
        }

        [Given(@"i click Transport in Tranport Outbound")]
        public void GivenIClickTransportInTranportOutbound()
        {
            BCOutboundPage2.TransportButton();
        }

        [Given(@"I select POWCreateNewTROs from the list")]
        public void GivenISelectPOWCreateNewTROsFromTheList()
        {
            BCOutboundPage2.ISelectPOWCreateNewTROsFromTheList();
        }

        [Given(@"I click print -> Reports")]
        public void GivenIClickPrintReports()
        {
            BCOutboundPage2.IClickPrintReports();
        }

        [Given(@"I select import radio button")]
        public void GivenISelectImportRadioButton()
        {
            BCOutboundPage2.ISelectImportRadioButton();
        }

        [Given(@"I add time Departed and Delivered")]
        public void GivenIAddTimeDepartedAndDelivered()
        {

            BCOutboundPage2.EnterDepartedTimeTROs()
                    .EnterDeliveredDateTimeTROs();

        }

        [Given(@"I click Show Filter Pane For EDI Message Log List second time")]
        public void GivenIClickShowFilterPaneForEDIMessageLogListSecondTime()
        {
            BCOutboundPage2.ClickShowFiltersPaneForEDIMessageLogListSecondTime();
        }

        [Given(@"I search TRO '(.*)' -> Power Transport Outbound List")]
        public void GivenISearchTRO_PowerTransportOutboundList(string TroForLinkWithOutbound)
        {
            BCOutboundPage2.SearchTRO_PowerTransportOutboundList(TroForLinkWithOutbound);
        }


        [Given(@"I click OK -> Power Transport Outbound List")]
        [When(@"I click OK -> Power Transport Outbound List")]
        [Then(@"I click OK -> Power Transport Outbound List")]
        public void GivenIClickOK_PowerTransportOutboundList()
        {
            BCOutboundPage2.ClickOK_PowerTransportOutboundList();
        }

        [Given(@"I click OK in batch list"), When(@"I click OK in batch list"), Then(@"I click OK in batch list")]
        public void GivenIClickOkInBatchList()
        {
            BCOutboundPage2.IClickOkInBatchList();
        }

        [Given(@"I click on Batch Number in Queue group list")]
        [When(@"I click on Batch Number in Queue group list")]
        [Then(@"I click on Batch Number in Queue group list")]
        public void GivenIClickOnBatchNumberInQueueGroupList()
        {
            BCOutboundPage2.IClickOnBatchNumberInQueueGroupList();
        }

        [Given(@"I delete the batch number")]
        [When(@"I delete the batch number")]
        [Then(@"I delete the batch number")]
        public void GivenIDeleteBatchNumber()
        {
            BCOutboundPage2.IDeleteBatchNumber();
        }

        [Given(@"I click more options in batch table")]
        [When(@"I click more options in batch table")]
        [Then(@"I click more options in batch table")]
        public void GivenIClickMoreOptionsInBatchTable()
        {
            BCOutboundPage2.IClickMoreOptionsBatchTable();
        }

        [Given(@"I click Edit in POWBatchList")]
        public void GivenIClickEditInPOWBatchList()
        {
            BCOutboundPage2.IClickEditInPOWBatchList();
        }

        [Given(@"I should get Error '(.*)' -> Outbound Link")]
        public void GivenIShouldGetError(string ExpextedErrorWrongDestinationGroup)
        {
            BCOutboundPage2.IShouldSeePopupMessageAfterLinkWithWrongTROsDestinationGroup(ExpextedErrorWrongDestinationGroup);

        }

        [Given(@"I should get '(.*)' -> BATCH WAVE")]
        public void GivenIShouldGet_BATCHWAVE(string p0)
        {
            BCOutboundPage3.ShouldGet_BATCHWAVE();

            Assert.Contains(p0, BCOutboundPage1.IShouldGetBATCHWAVES);

        }


        [Given(@"I get notification '(.*)' - > Outbound Orderline")]
        public void GivenIGetNotification_OutboundCancelOrderline(string Notification_OutboundCancelOrderline)
        {

            Assert.Contains(Notification_OutboundCancelOrderline, BCOutboundPage1.IShouldGetNotificationOutboundCancelOrderlines);

        }

        [Given(@"I get notification '(.*)' - > TRO print message")]
        public void GivenIGetNotification_TROPrintMessage(string Notification_OutboundCancelOrderline)
        {

            Assert.Contains(Notification_OutboundCancelOrderline, BCOutboundPage1.IShouldGetNotificationTROPrintMessages);

        }

        [Given(@"I get notification '(.*)' - > Outbound Holder unpack")]
        public void GivenIGetNotification_OutboundHolderUnpack(string Notification_OutboundHolderUnpack)
        {
            BCOutboundPage3.IWaitForTheNotificationToAppear();

            Assert.Contains(Notification_OutboundHolderUnpack, BCOutboundPage1.IShouldGetNotificationOutboundHolderUnpacked);

        }

        [Given(@"I get PowerbatchCard status '(.*)'")]
        public void GivenIGetPowerbatchCardStatus(string p0)
        {

            Assert.Contains(p0, BCOutboundPage1.IGetPowerbatchCardStatuses);

        }


        [Given(@"I get '(.*)' - > Batch notification")]
        public void GivenIGet_BatchNotification(string p0)
        {

            Assert.Contains(p0, BCOutboundPage1.IGetBatchNotifications);

        }

        [Given(@"I get '(.*)' - > Created Batch notification")]
        public void GivenIGet_CreatedBatchNotification(string p0)
        {

            Assert.Contains(p0, BCOutboundPage1.IGetCreatedBatchNotifications);

        }


        [Given(@"I get '(.*)' - > Queue Group Batch notification")]
        public void GivenIGet_QueueGroupBatchNotification(string p0)
        {

            Assert.Contains(p0, BCOutboundPage1.IGetQueuesGroupBatchNotification);

        }


        [Given(@"I get destination notification '(.*)' - > Outbound Orderline")]
        public void GivenIGetDestinationNotification_OutboundOrderline(string DestinationNotification_OutboundOrderline)
        {
            //Assert.Contains(DestinationNotification_OutboundOrderline, BCOutboundPage1.IShouldGetDestinationNotificationsOutboundCancelOrderline);
            BCOutboundPage1.IShouldGetDestinationNotificationsOutboundCancelOrderline(DestinationNotification_OutboundOrderline);
        }

        [Given(@"I get notification on Delete Linked Transport\(picking\) -> TRO Queue group List '(.*)'")]
        public void GivenIGetNotificationOnDeleteLinkedTransportPicking_TROQueueGroupList(string NotificationOnDeleteLinkedTransportPicking_TROQueueGroupList)
        {
            Assert.Contains(NotificationOnDeleteLinkedTransportPicking_TROQueueGroupList, BCOutboundPage1.IShouldGetNotificationOnDeleteLinkedTransportsPicking_TROQueueGroupList);

        }


        [Given(@"I should get Error Outbound Difference '(.*)'")]
        public void GivenIShouldGetErrorOutboundDifference(string ExpextedErrorOutboundDifference)
        {

            Assert.Contains(ExpextedErrorOutboundDifference, BCOutboundPage1.IShouldGetErrorsOutboundDifference);

        }

        [Given(@"I should get Error Book Back part of selected line '(.*)'")]
        public void GivenIShouldGetErrorBookBackPartOfSelectedLine(string GetErrorBookBackPartOfSelectedLine)
        {

            Assert.Contains(GetErrorBookBackPartOfSelectedLine, BCOutboundPage1.IShouldGetErrorBookBackPartOfSelectedLines);

        }


        [Given(@"I get error '(.*)' -> Outbound")]
        public void GivenIGetErrorOutbound(string getErrorOutbound)
        {

            Assert.Contains(getErrorOutbound, BCOutboundPage1.IGetErrorOutboundCard);
        }

        [Given(@"I should get Status Outbound Order '(.*)'")]
        public void GivenIShouldGetStatusOutboundOrder(string ExpectedStatusOutboundOrder)
        {
            BCOutboundPage1.VerifyIGetStatusOutboundOrder(ExpectedStatusOutboundOrder);
        }

        [Given(@"I should get Status Outbound Order '(.*)' -> In Order")]
        public void GivenIShouldGetStatusOutboundOrder_InOrder(string p0)
        {
            Assert.Contains(p0, BCOutboundPage1.IShouldGetStatusOutboundOrderInOrderCard);

        }

        [Given(@"I click Operations Overviews -> without Switch")]
        public void GivenIClickOperationsOverviews_WithoutSwitch()
        {
            BCOutboundPage7.OperationsOverviewsWithoutSwitch();
        }

        [Given(@"I Click Transport Planning")]
        public void GivenIClickTransportPlanning()
        {
            BCOutboundPage7.ClickTransportPlanningButton();
        }

        [Given(@"I search Outbound -> Power Transport Outbound List")]
        public void GivenISearchOutbound_PowerTransportOutboundList()
        {
            BCOutboundPage7.SearchOutboundPowerTransportOutboundList();
        }

        [Given(@"I Click Actions -> Menu")]
        public void GivenIClickActions_Menu()
        {
            BCOutboundPage7.ClickActionsMenu();
        }

        [Given(@"I Click Link -> Title")]
        public void GivenIClickLink_Title()
        {
            BCOutboundPage7.ClickLinkTitle();
        }

        [Given(@"I Click Link to existing TRO")]
        public void GivenIClickLinkToExistingTRO()
        {
            BCOutboundPage7.ClickLinkToExistingTRO();
        }

        [Given(@"I search Created TRO -> Power Transport List")]
        public void GivenISearchCreatedTRO_PowerTransportList()
        {
            BCOutboundPage7.SearchCreatedTROPowerTransportList();
        }

        [Given(@"I click Operations Overviews without Switch -> Main Menu")]
        public void GivenIClickOperationsOverviewsWithoutSwitch_MainMenu()
        {
            BCOutboundPage2.OperationOverviewMenu();
        }

        [Given(@"I enter Refrence datetime '(.*)'")]
        public void GivenIEnterRefrenceDatetime(string CustomerRefrenceDatetime)
        {
            var UniqueNumber = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            CustomerRefrenceDatetime += UniqueNumber;
            BCOutboundPage3.OperationOverviews_OpenTransportInbounds_List_SelectDocument_NewDocument_FillRefrence(CustomerRefrenceDatetime);
        }

        [Given(@"I enter destination Order nr '(.*)' with random")]
        public void GivenIEnterDestinationOrderNrWithRandom(string p0)
        {
            var UniqueNumber = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            p0 += UniqueNumber;
            BCOutboundPage3.SetIEnterDestinationOrderNrWithRandom(p0);
        }

        [Given(@"I enter Client shipment nr '(.*)' with random")]
        public void GivenIEnterClientShipmentNrWithRandom(string p0)
        {
            var UniqueNumber = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            p0 += UniqueNumber;
            BCOutboundPage3.SetIEnterClientShipmentNrWithRandom(p0);
        }

        [Given(@"I enter Type Code '(.*)'")]
        public void GivenIEnterTypeCode(string TypeCode)
        {
            BCOutboundPage1.EnterTypeCode(TypeCode);
        }
        [Given(@"I enter Type Code '(.*)' in Outbound")]
        public void GivenIEnterTypeCodeInOutbound(string TypeCode)
        {
            BCOutboundPage1.EnterTypeCodeOutbound(TypeCode);
        }


        [Given(@"I fill Online Order Number '(.*)' field on Outbound")]
        public void GivenIFillOnlineOrderNumberFieldOnOutbound(string OnlineNumberDateTime)
        {
            var UniqueNumber = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            OnlineNumberDateTime += UniqueNumber;
            BCOutboundPage2.FillInOnlineOrderNumber(OnlineNumberDateTime);
        }

        [Given(@"I fill In Date To Finish Picking field '(.*)' on Outbound")]
        public void GivenIFillInDateToFinishPickingFieldOnOutbound(string DateTime)
        {
            BCOutboundPage3.DateToFinishPickingQueue(DateTime);
        }

        [Given(@"I fill Time To Finish Picking field '(.*)' on Outbound")]
        public void GivenIFillTimeToFinishPickingFieldOnOutbound(string Time)
        {
            BCOutboundPage3.FillTimeToFinishPickingQueue(Time);
        }

        [Given(@"I fill Finish Picking field '(.*)' on Outbound")]
        public void GivenIFillFinishPickingFieldOnOutbound(string p0)
        {
            BCOutboundPage3.FillFinishPickingFieldOnOutbound(p0);
        }

        [Given(@"I enter Date Delivered on Outbound")]
        public void GivenIEnterDateDeliveredOnOutbound()
        {
            BCOutboundPage3.EnterDatesDeliveredOutbound();
        }

        [Given(@"I enter Time Delivered on Outbound")]
        public void GivenIEnterTimeDeliveredOnOutbound()
        {
            BCOutboundPage3.EnterTimeDeliveredOutbounds();
        }

        [Given(@"I enter Date to load")]
        public void GivenIEnterDateToLoad()
        {
            BCOutboundPage3.EnterDateToLoad();
        }

        [Given(@"I Click Nas Simulator")]
        public void GivenIClickNasSimulator()
        {
            BCOutboundPage3.NasSimulatorClicks();
        }

        [Given(@"I Click Nas Simulator ADEO")]
        public void GivenIClickNasSimulatorADEO()
        {
            BCOutboundPage3.NasSimulatorClicksADEO();
        }

        [Given(@"I Click Show Filter Pane For OutBound")]
        public void GivenIClickShowFilterPaneForOutBound()
        {
            BCOutboundPage3.ShowFilterPaneForOutbound();
        }

        [Given(@"I Write Saved Outbound Code for Outbound in Nas Simulator")]
        public void GivenIWriteSavedOutboundCodeForOutboundInNasSimulator()
        {
            BCOutboundPage3.SaveOutboundCodeForOutboundInNasSimulator();
        }

        [Given(@"I Run Nas Simulator STKADJ")]
        public void GivenIRunNasSimulatorSTKADJ()
        {
            BCOutboundPage3.InNASSimulatorSelectMyLineAndClickRuun();
        }

        [Given(@"I write '(.*)' on Filter")]
        public void GivenIWriteOnFilter(string inputFilter)
        {
            BCOutboundPage3.WriteOnFilter(inputFilter);
        }
        [Given(@"I Click Setup without switchContent Frame")]
        public void GivenIClickSetupWithoutSwitchContentFrame()
        {
            BCOutboundPage3.SetupMenu1();
        }

        [Given(@"I enter '(.*)' Code on Outbound")]
        public void GivenIEnterCodeOnOutbound(string OutboundCode)
        {
            BCOutboundPage3.EnterCodesOutbound(OutboundCode);
        }

        [Given(@"I fill '(.*)' Type on Outobund")]
        public void GivenIFillTypeOnOutobund(string p0)
        {
            BCOutboundPage3.FillTypeOnOutobun(p0);
        }


        [Given(@"I enter '(.*)' Code in Queue for Outbound")]
        public void GivenIEnterCodeInQueueForOutbound(string OutboundCode)
        {
            BCOutboundPage3.EnterCodeInQueueForOutbound(OutboundCode);
        }

        [Given(@"I enter '(.*)' Group on Outbound")]
        public void GivenIEnterGroupOnOutbound(string GroupOnOutbound)
        {
            BCOutboundPage3.EnterGroupOnOutbound(GroupOnOutbound);
        }

        [Given(@"I Book all in Manage -> Outbound")]
        public void GivenIBookAllInManage_Outbound()
        {
            BCOutboundPage3.IBookAllInManageOutbound();
        }

        [Given(@"I click Manage order in Outbound card")]
        public void GivenIClickManageOrderInOutboundCard()
        {
            BCOutboundPage3.IClickManageOrderInOutboundCard();
        }

        [Given(@"I click delete line in Manage order in Outbound card")]
        public void GivenIClickDeleteLineManageOrderInOutboundCard()
        {
            BCOutboundPage3.IClickDeleteLineInManageOrderInOutboundCard();
        }

        [Given(@"I Cut Off in Manage -> Outbound")]
        public void GivenICutOffInManage_Outbound()
        {
            //BCOutboundPage1.SwitchToMainContentFrame();
            //BCOutboundPage1.SwitchToDefaultFrame();
            //BCOutboundPage1.SwitchToCutOffManageIFrame();
            BCOutboundPage3.ICutOffInManageOutbound();
        }

        [Given(@"I Cut off in Manage after book back")]
        public void GivenICutOffInManageAfterBookBack()
        {
            //BCOutboundPage1.SwitchToMainContentFrame();
            //BCOutboundPage1.SwitchToDefaultFrame();
            //BCOutboundPage1.SwitchToCutOffManageIFrame();
            BCOutboundPage3.ICutOffInManageAfterBookBack();
        }

        [Given(@"I enter Picking Route '(.*)'")]
        public void GivenIEnterPickingRoute(string p0)
        {
            BCOutboundPage3.IEnterPickingRoutes(p0);
        }

        [Given(@"I select Change Picking Route -> Outbound")]
        public void GivenISelectChangePickingRoute_Outbound()
        {
            BCOutboundPage3.ISelectChangePickingRouteOutbound();
        }

        [Given(@"I enter Code on Outbound")]
        public void GivenIEnterCodeOnOutbound()
        {
            BCOutboundPage3.EnterCodeOutbounds();
        }

        [Given(@"I enter Group on Outbound")]
        public void GivenIEnterGroupOnOutbound()
        {
            BCOutboundPage3.EnterGroupOutbounds();
        }

        [Given(@"I click Order on Outbound")]
        public void GivenIClickOrderOnOutbound()
        {
            BCOutboundPage3.ClickORDEROutbounds();
        }

        [Given(@"I Enter Order Line No on Order -> Outbound")]
        public void GivenIEnterOrderLineNoOnOrder_Outbound()
        {
            BCOutboundPage3.EnterOrderLineOutbounds();
        }
        [Given(@"I Enter Order Line No (.*) on Order -> Outbound")]
        public void GivenIEnterOrderLineNoOnOrder_Outbound(int p0)
        {
            BCOutboundPage3.EnterOrderLineOutbounds2();
        }


        [Given(@"I Enter Order Line two No on Order -> Outbound")]
        public void GivenIEnterOrderLineTwoNoOnOrder_Outbound()
        {
            BCOutboundPage3.EnterOrderLineTwoOutbounds();
        }

        [Given(@"I enter date to load on Outbound")]
        public void GivenIEnterDateToLoadOnOutbound()
        {
            BCOutboundPage3.EnterDateToLoadOnOutbound();
        }

        [Given(@"I Filter list by  -- > Filter")]
        public void GivenIFilterListBy_Filter()
        {
            BCOutboundPage3.FilterListByThenClickFilter();
        }
        [Given(@"I click Filter in NAS")]
        public void GivenIClickFilterInNAS()
        {
            BCOutboundPage3.FilterInNASsim();
        }
        [Given(@"I click Startup Parameter")]
        public void GivenIClickStartupParameter()
        {
            BCOutboundPage3.ClickStartupParameter();
        }
        [Given(@"I enter copied outbound code in Nas Simulator filter")]
        public void GivenIEnterCopiedOutboundCodeInNasSimulatorFilter()
        {
            BCOutboundPage3.EnterCopiedOutboundCodeNasSimulatorFilter();
        }
        [Given(@"I click search from the navigation bar")]
        public void GivenIClickSearchFromTheNavigationBar()
        {
           BCOutboundPage3.ClickSearchFromTheNavigationBars();
        }

        [Given(@"I enter TRI '(.*)' to search label")]
        public void GivenIEnterTRIToSearchLabel(string TRIno)
        {
            BCOutboundPage3.EnterTRIToSearchLabel(TRIno);
        }

        [Given(@"I click Edit from the navigation bar in Transport Inbound")]
        public void GivenIClickEditFromTheNavigationBarInTransportInbound()
        {
            BCOutboundPage3.ClickEditFromTheNavigationBarInTransportInbounds();
        }
        [Given(@"I click Validate and Close Transport from the navigation bar")]
        public void GivenIClickValidateAndCloseTransportFromTheNavigationBar()
        {
            BCOutboundPage3.ClickValidateAndCloseTransportFromTheNavigationBars();
        }

        [Given(@"I click More Options in TRI")]
        public void GivenIClickMoreOptionsInTRI()
        {
            BCOutboundPage3.ClickMoreOptionsTRIMenu();
        }

        [Given(@"I Click OK FROM POP UP")]
        public void GivenIClickOKFROMPOPUPForStock()
        {
            BCOutboundPage3.OKBUTTONFROMPOPUPs();

        }
        [Given(@"I click OK button of popup Main Page")]
        public void GivenIClickOKButtonOfPopupMainPage()
        {
            BCOutboundPage3.ClickOKButtonOfPopupMainPages();
        }
        [Given(@"I Click Print CMR on Ktn CMR Main")]
        public void GivenIClickPrintCMROnKtnCMRMain()
        {
            BCOutboundPage3.PrintCMR();
        }
        [Given(@"I click Setup on Main Menu")]
        public void GivenIClickSetupOnMainMenu()
        {
            BCOutboundPage3.SwitchToMainContentFrame()
                    .SETUPMenu();
        }
        [Given(@"I click back button to main page")]
        public void GivenIClickBackButtonToMainPage()
        {
            BCOutboundPage3.ClickBackButtonToMainPages();
        }
        [Given(@"I click CMR from Main Menu")]
        public void GivenIClickCMRFromMainMenu()
        {
            BCOutboundPage3.SwitchToMainContentFrame();
            BCOutboundPage3.CMRmainMenu();
        }
        [Given(@"I click driver documents")]
        public void GivenIClickDriverDocuments()
        {
            BCOutboundPage3.DriverDocument();
        }
        [Given(@"select in ""(.*)""")]
        public void GivenSelectIn(string p0)
        {
            BCOutboundPage3.createCombinedtranportCMR();
        }
        [Given(@"I Click rePrint CMR on Ktn CMR Main")]
        public void GivenIClickrePrintCMROnKtnCMRMain()
        {
            BCOutboundPage3.rePrintCMR();
        }
        [Given(@"I verify that cut off for piecepicking is done")]
        public void GivenIVerifyThatCutOffForPiecepickingIsDone()
        {
            BCOutboundPage3.IVerifyThatCutOffForPiecepickingIsDone();
        }
        [Given(@"From dropdown i select Status Outbound Order")]
        public void GivenFromDropdownISelectStatusOutboundOrder()
        {
            BCOutboundPage3.FromDropDownISelectStatusOutboundOrder();
        }
        [Given(@"I select dropdown after Outbound Order")]
        public void GivenISelectDropdownAfterOutboundOrder()
        {
            BCOutboundPage3.SelectDropdownForStatusOutboundOrders();
        }
        [Given(@"I select Loaded after Outbound Order")]
        public void GivenISelectLoadedAfterOutboundOrder()
        {
            BCOutboundPage3.SelectLOADEDAfterOutboundOrder();
        }
        [Given(@"I click Cancel Qty All orderlines to cancel all orderlines")]
        public void GivenIClickCancelQtyAllOrderlines()
        {
            BCOutboundPage3.IClickCancelQtyAllOrderlines();
        }
        [Given(@"I Book Back PART OF selected line")]
        public void GivenIBookBackPartOfSelectedLine()
        {
            BCOutboundPage3.BookBackAllPartOfSelectedLine();
        }
        [Given(@"I Book back all complete selected line in Reservation ---> Outbound"), When(@"I Book back all complete selected line in Reservation ---> Outbound"), Then(@"I Book back all complete selected line in Reservation ---> Outbound")]
        public void GivenIBookBackAllCompleteSelectedLineInReservation_Outbound()
        {
            BCOutboundPage3.BookBackAllCompleteSelectedLineInReservation_Outbound();
        }
    }
}
