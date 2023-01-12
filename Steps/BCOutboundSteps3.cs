using CGI_OUTBOUND_BC_Scenarios.OUTBOUND.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace CGI_OUTBOUND_BC_Scenarios.OUTBOUND.Steps
{
    [Binding]
    public class BCOutboundSteps3
    {
        public IWebDriver Driver;

        public BCOutboundSteps3(IWebDriver driver) => Driver = driver;

        private BCOutboundPage1 BCOutboundPage1 => new BCOutboundPage1(Driver);
        private BCOutboundPage2 BCOutboundPage2 => new BCOutboundPage2(Driver);
        private BCOutboundPage3 BCOutboundPage3 => new BCOutboundPage3(Driver);
        private BCOutboundPage4 BCOutboundPage4 => new BCOutboundPage4(Driver);
        private BCOutboundPage5 BCOutboundPage5 => new BCOutboundPage5(Driver);
        private BCOutboundPage6 BCOutboundPage6 => new BCOutboundPage6(Driver);
        private BCOutboundPage7 BCOutboundPage7 => new BCOutboundPage7(Driver);

        [Given(@"I enter Order Line No on Order two-> Outbound")]
        public void GivenIEnterOrderLineNoOnOrderTwo_Outbound()
        {
            BCOutboundPage3.EnterOrderLineTwoOutbounds();
        }


        [Given(@"I enter item '(.*)' in Order -> Outbound")]
        public void GivenIEnterItemInOrder_Outbound(string Item)
        {
            BCOutboundPage3.EnterItemInOutbounds(Item);
        }

        [Given(@"I enter item '(.*)' in OrderLine two-> Outbound")]
        public void GivenIEnterItemInOrderLineTwo_Outbound(string Item)
        {
            BCOutboundPage3.EnterItemInOrderLineTwoOutbound(Item);
        }

        [Given(@"I go to second line and enter item '(.*)'")]
        public void GivenIGoToSecondLineAndEnterItem(string Item)
        {
            BCOutboundPage3.EnterItemInOutboundsSecond(Item);
        }



        [Given(@"I enter Booking Qty '(.*)' on Order -> Outbound")]
        public void GivenIEnterBookingQtyOnOrder_Outbound(string BookingQty)
        {
            BCOutboundPage3.EnterBookingQtyOutbound(BookingQty);
        }

        [Given(@"I enter Booking Qty '(.*)' on Order -> Outbound ZC")]
        public void GivenIEnterBookingQtyOnOrder_OutboundZC(string BookingQty)
        {
            BCOutboundPage3.EnterBookingQtyOutboundZC(BookingQty);
        }

        [Given(@"I enter '(.*)' on configuration")]
        public void GivenIEnterConfigOnConfiguration(string Config)
        {
            BCOutboundPage3.EnterConfigInConfiguration(Config);
        }

        [Given(@"I enter second line Booking QTY '(.*)'")]
        public void GivenIEnterSecondLineBookingQTY(string BookingQty)
        {
            BCOutboundPage3.EnterBookingQtyOutbound2(BookingQty);
        }

        [Given(@"I enter Booking Qty '(.*)' on Order -> Outbound down")]
        public void GivenIEnterBookingQtyOnOrder_OutboundDown(string BookingQty)
        {
            BCOutboundPage3.EnterBookingQtyOutboundDown(BookingQty);
        }


        [Given(@"I enter LOT NO '(.*)' -> Outbound Order Line")]
        public void GivenIEnterLOTNO_OutboundOrderLine(string enterLOTNOOutboundOrderLine)
        {
            BCOutboundPage3.EnterLOTNOOutboundOrderLine(enterLOTNOOutboundOrderLine);
        }


        [Given(@"I scroll to Blocked Reason from QTY -> Outbound")]
        public void GivenIScrollToBlockedReasonFromQTY_Outbound()
        {
            BCOutboundPage4.ScrollToBlockedReasonFromQTYOutbound();
        }

        [Given(@"I write Blocked Reason Field '(.*)' -> Outbound")]
        public void GivenIWriteBlockedReasonField_Outbound(string BlockedReasonsFieldOutbound1)
        {
            BCOutboundPage3.WriteBlockedReasonFieldOutbound(BlockedReasonsFieldOutbound1);
        }

        [Given(@"I scroll to Lot No from Blocked Reason -> Outbound")]
        public void GivenIScrollToLotNoFromBlockedReason_Outbound()
        {
            BCOutboundPage4.ScrollToLotNoFromBlockedReason_Outbound();
        }

        [Given(@"I enter outbound code '(.*)' into linked transport input field")]
        [When(@"I enter outbound code '(.*)' into linked transport input field")]
        [Then(@"I enter outbound code '(.*)' into linked transport input field")]
        public void GivenIEnterOutboundCodeOnLinkedTransportFieldInput(string p0)
        {
            BCOutboundPage3.EnterOutboundCodeOnLinkedTransportFieldInput(p0);
        }

        [Given(@"I enter outbound code '(.*)' on search option -> Outbound list")]
        [When(@"I enter outbound code '(.*)' on search option -> Outbound list")]
        [Then(@"I enter outbound code '(.*)' on search option -> Outbound list")]
        public void GivenIEnterOutboundCodeOnSearchOption_OutboundList(string p0)
        {
            BCOutboundPage3.EnterOutboundCodeOnSearchOptionOutboundList(p0);
        }

        [Given(@"I search my linked TRO '(.*)' with Outbound")]
        public void GivenISearchMyLinkedTROWithOutbound(string p0)
        {
            BCOutboundPage3.SearchMyStaticLinkedTROWithOutbound(p0);
        }

        [Given(@"I change status of outbound status filter to done")]
        public void GivenIChangeStatusOfOutboundFilterToDone()
        {
            BCOutboundPage3.ChangeStatusOfOutboundFilterToDone();
        }

        [Given(@"I select View Linked Outbounds -> TRO")]
        public void GivenISelectViewLinkedOutbounds_TRO()
        {
            BCOutboundPage3.SelectViewLinkedOutboundsTRO();
        }

        [Given(@"I click on view linked Outbounds in TRO card")]
        public void GivenIClickOnViewLinkedOutboundsInTROCard()
        {
            BCOutboundPage3.ClickViewLinkedOutboundsTROCard();
        }

        [Given(@"I select view linked queue groups")]
        public void GivenISelectViewLinkedQueueGroupsTRO()
        {
            BCOutboundPage3.SelectViewLinkedQueueGroupsTRO();
        }

        [Given(@"I click show more in QG -> More options -> Actions")]
        public void GivenIClickShowMoreINQGMoreOptionsActions()
        {
            BCOutboundPage3.SelectMoreOptionsINQGActions();
        }

        [Given(@"I click Queue group -> Delete Linked Transport picking")]
        [When(@"I click Queue group -> Delete Linked Transport picking")]
        [Then(@"I click Queue group -> Delete Linked Transport picking")]
        public void GivenIClickQueueGroupDeleteLinkedTransport()
        {
            BCOutboundPage3.SelectQueueGroupDeleteLinkedTransport();
        }

        [Given(@"I select multiple outbounds to unlink")]
        public void GivenISelectMultipleOutboundsToUnlink()
        {
            BCOutboundPage3.SelectMultipleOutboundsToUnlink();
        }

        [Given(@"I click more options on Power Outbound List -> TRO")]
        public void GivenIClickMoreOptionsOnPowerOutboundList_TRO()
        {
            BCOutboundPage3.MoreOptionsOnPowerOutboundList_TROs();
        }

        [Given(@"I click more options on POWER QUEUE GROUP LIST -> TRO")]
        public void GivenIClickMoreOptionsOnPOWERQUEUEGROUPLIST_TRO()
        {
            BCOutboundPage3.ClickMoreOptionsOnPOWERQUEUEGROUPLIST_TRO();
        }

        [Given(@"I click more options on POWER QUEUE GROUP LIST -> Outbound")]
        [When(@"I click more options on POWER QUEUE GROUP LIST -> Outbound")]
        [Then(@"I click more options on POWER QUEUE GROUP LIST -> Outbound")]
        public void GivenIClickMoreOptionsOnPOWERQUEUEGROUPLIST_Outbound()
        {
            BCOutboundPage3.ClickMoreOptionsOnPOWERQUEUEGROUPLIST_Outbound();
        }


        [Given(@"I click more options withoud inside More Options POWER QUEUE GROUP LIST -> TRO")]
        public void GivenIClickMoreOptionsWithoudInsideMoreOptionsPOWERQUEUEGROUPLIST_TRO()
        {
            BCOutboundPage3.ClickMoreOptionsWithoudInsideMoreOptionsPOWERQUEUEGROUPLIST_TRO();
        }

        [Given(@"I click Actions Dropdown")]
        public void GivenIClickActionsDropdown()
        {
            BCOutboundPage4.ClickonActionsDropdown();
        }

        [Given(@"I click Outbound Dropdown -> Power Outbound List")]
        public void GivenIClickOutboundDropdown_PowerOutboundList()
        {
            BCOutboundPage4.ClickOutboundDropdownPowerOutboundList();
        }

        [Given(@"I click Process -> Power Outbound List")]
        [When(@"I click Process -> Power Outbound List")]
        [Then(@"I click Process -> Power Outbound List")]
        public void GivenIClickProcess_PowerOutboundList()
        {
            BCOutboundPage4.IClickProcessPowerOutboundList();
        }


        [Given(@"I click Unlink Selected From transport -> TRO Queue group List")]
        public void GivenIClickUnlinkSelectedFromTransport_TROQueueGroupList()
        {
            BCOutboundPage4.ClickUnlinkSelectedFromTransportTROQueueGroupList();
        }

        [Given(@"I click unlink selected from transport via process")]
        [When(@"I click unlink selected from transport via process")]
        [Then(@"I click unlink selected from transport via process")]
        public void GivenIClickUnlinkSelectedFromTransportViaProcess()
        {
            BCOutboundPage4.ClickUnlinkSelectedFromTransportViaProcess();
        }

        [Given(@"I Click Unlink selected from transport after clicking process")]
        public void GivenIClickUnlinkSelectedFromTransportAfterClosingProcess()
        {
            BCOutboundPage4.IClickUnlinkSelectedFromTransportAfterClosingProcess();
        }

        [Given(@"I Click Close Button -> Outbound")]
        [When(@"I Click Close Button -> Outbound")]
        [Then(@"I Click Close Button -> Outbound")]
        public void GivenIClickCloseButton_Outbound()
        {
            BCOutboundPage4.ClickCloseButtonOutbounds();
        }

        [Given(@"I Click Close Button -> Outbound Queue Group list")]
        [When(@"I Click Close Button -> Outbound Queue Group list")]
        [Then(@"I Click Close Button -> Outbound Queue Group list")]
        public void GivenIClickCloseButton_OutboundQueueGroupList()
        {
            BCOutboundPage4.ClickCloseButtonOutboundsQueueGroupList();
        }

        [Given(@"In Order line two -> I Enter Order Line NO")]
        public void GivenInOrderLineTwo_IEnterOrderLineNO()
        {
            BCOutboundPage4.InOrderLineTwo_IEnterOrderLineNO();
        }

        [Given(@"In Order Line three -> I Enter Order Line NO")]
        public void GivenInOrderLineThree_IEnterOrderLineNO()
        {
            BCOutboundPage4.InOrderLineThreeIEnterOrderLineNOM();
        }


        [Given(@"I enter Arrival and Delivery Time -> TRO")]
        public void GivenIEnterArrivalAndDeliveryTime_TRO()
        {
            BCOutboundPage4.EnterArrivalAndDeliveryTimeTRO();
        }

        [Given(@"I write time on Time Fields -> TRO")]
        public void GivenIWriteTimeOnTimeFields_TRO()
        {
            BCOutboundPage4.WriteTimeOnTimeFieldsTRO();
        }

        [Given(@"I enter Booking Qty '(.*)' on OrderLine two -> Outbound")]
        public void GivenIEnterBookingQtyOnOrderLineTwo_Outbound(string BookingQty)
        {
            BCOutboundPage4.EnterBookingQtyOrderLineTwoOutbound(BookingQty);
        }


        [Given(@"I Book All in Order -> Outbound")]
        public void GivenIBookAllInOrder_Outbound()
        {
            BCOutboundPage4.BookAllOutbound();
        }

        [Given(@"I should get Difference Error in Outbound after CutOff '(.*)'")]
        public void GivenIShouldGetDifferenceErrorInOutboundAfterCutOff(string DifferenceErrorInOutboundAfterCutOff)
        {
            BCOutboundPage4.VerifyIGetDifferenceErrorInOutboundAfterCutOff(DifferenceErrorInOutboundAfterCutOff);
        }

        [Given, Then(@"I get an error message '(.*)' for batch picking")]
        public void GivenIGetAnErrorMessage(string errorMessage)
        {
            BCOutboundPage4.IGetAnErrorMessage(errorMessage);
        }

        [Given, Then(@"I validate that the queue is added to the batch")]
        public void GivenIValidateQueueIsAddedToTheBatch()
        {
            BCOutboundPage4.IValidateQueueIsAddedToTheBatch();
        }

        [Given(@"I Click Close -> Outbound")]
        public void GivenIClickClose_Outbound()
        {
            BCOutboundPage4.ClickCloseOutbound();
        }


        [Given(@"I write on Type Field '(.*)' -> Outbound")]
        public void GivenIWriteOnTypeField_Outbound(string OnTypeFieldOutbound)
        {
            BCOutboundPage4.WriteOnTypeFieldOutbounds(OnTypeFieldOutbound);
        }

        [Given(@"I delete text on Type Field -> Outbound")]
        public void GivenIDeleteTextOnTypeField_Outbound()
        {
            BCOutboundPage4.DeleteTextOnTypeField_Outbound();
        }


        [Given(@"I Cut Off in Order -> Outbound")]
        public void GivenICutOffInOrder_Outbound()
        {
            BCOutboundPage4.CutOffOutbound();
        }

        [Given(@"I copy the Value Of Outbound from Outbound table")]
        public void GivenICopyTheValueOfOutboundFromOutboundTable()
        {
            BCOutboundPage4.CopyValueOfOutboundOnOutboundTable();
        }

        [Given(@"I copy the Value Of Batch from batch table")]
        public void GivenICopyTheValueOfBatchFromBatchTable()
        {
            BCOutboundPage4.CopyValueOfBatchFromBatchTable();
        }

        [Given(@"I copy the Value Of Batch from batch card")]
        public void GivenICopyTheValueOfBatchFromBatchCard()
        {
            BCOutboundPage4.CopyValueOfBatchFromBatchCard();
        }

        [Given(@"I save Add to Batch number")]
        public void GivenISaveAddToBatchNumber()
        {
            BCOutboundPage4.SaveAddToBatchNumbers();
        }


        [Given(@"I copy the Value Of Second Outbound from Outbound table")]
        public void GivenICopyTheValueOfSecondOutboundFromOutboundTable()
        {
            BCOutboundPage4.CopyValueOfSecondOutboundOnOutboundTable();
        }

        [Given(@"I go back from Outbound")]
        public void GivenIGoBackFromOutbound()
        {
            BCOutboundPage4.GoBackFromOutboundPage();
        }

        [Given(@"I go back -> Outbound")]
        public void GivenIGoBack_Outbound()
        {
            BCOutboundPage4.GoBackOutboundPage();
        }

        [Given(@"I click yes -> Outbound")]
        public void GivenIClickYes_Outbound()
        {
            BCOutboundPage4.ClickYesOutboundPage();
        }


        [Given(@"I go back from Outbound List")]
        public void GivenIGoBackFromOutboundList()
        {
            BCOutboundPage4.GoBackFromOutboundListPage();
        }

        [Given(@"I click Operations Overviews without switchContent Frame -> Outbound")]
        public void GivenIClickOperationsOverviewsWithoutSwitchContentFrame()
        {
            BCOutboundPage2.OperationOverviewMenu();
        }

        [Given(@"I click Batch Management from Operations Overviews")]
        public void GivenIClickBatchManagementFromOperationsOverviews()
        {
            BCOutboundPage2.ClickBatchManagementFromOperationsOverviews();
        }

        [Given(@"I click Batch Management from Operations Overviews -> Batch")]
        public void GivenIClickBatchManagementFromOperationsOverviews_Batch()
        {
            BCOutboundPage1.SwitchToMainContentFrame();
            BCOutboundPage2.ClickBatchManagementFromOperationsOverviews();
        }

        [Given(@"I click Holder Retrieval")]
        public void GivenIClickHolderRetrieval()
        {
            BCOutboundPage2.IClickHolderRetrievals();
        }

        [Given(@"I click Manage Holder Retrieval")]
        public void GivenIClickManageHolderRetrieval()
        {
            BCOutboundPage2.IClickManageHolderRetrievals();
        }

        [Given(@"I click user '(.*)'")]
        public void GivenIClickUser(string p0)
        {
            BCOutboundPage3.IClickUser(p0);
        }

        [Given(@"I write Batch Number '(.*)'")]
        public void GivenIWriteBatchNumber(string p0)
        {
            BCOutboundPage3.IWriteBatchNumbers(p0);
        }


        [Given(@"I click Batch Overview")]
        public void GivenIClickBatchOverview()
        {
            BCOutboundPage3.IClickBatchOverviews();
        }


        [Given(@"I select date created -> Outbound")]
        public void GivenISelectDateCreated()
        {
            BCOutboundPage3.SelectDateCreateds();
        }

        [Given(@"I copy a file to a folder")]
        public void GivenICopyAFileToAFolder()
        {
            BCOutboundPage4.CopyFileToFolder();
        }

        [Given(@"I run POWER EDI Manager")]
        public void GivenIRunPOWEREDIManager()
        {
            BCOutboundPage4.RunPOWEREDIManagerFunction();
        }

        [Given(@"I click Message Log Receivings")]
        public void GivenIClickMessageLogReceivings()
        {
            BCOutboundPage4.MessageLogReceivingButton();
        }

        [Given(@"I click Show Filter Pane For EDI Message Log List")]
        public void GivenIClickShowFilterPaneForEDIMessageLogList()
        {
            BCOutboundPage4.ShowFilterPaneForEDIMessageLogList();
        }

        [Given(@"I write first filter '(.*)' and second filter '(.*)' on EDI Message Log List")]
        public void GivenIWriteFirstFilterAndSecondFilterOnEDIMessageLogList(string firstFilter, string secondFilter)
        {
            BCOutboundPage4.WriteFilterKTNEDIMsgLogList(firstFilter, secondFilter);
        }

        [Given(@"I select Not Processed line on EDI Message Log List")]
        public void GivenISelectNotProcessedLineOnEDIMessageLogReceiving()
        {
            BCOutboundPage4.SelectNotProcessedLineEDIMeessageLogReceiving();
        }

        [Given(@"I enter UniqueID to CustomerRefTwo on EDI Message Log List")]
        public void GivenIEnterUniqueIDToCustomerRefTwoOnEDIMessageLogList()
        {
            BCOutboundPage4.EnterUniqueNumberCustomRef2EDIMessageLogList();

        }

        [Given(@"I go back from EDI Message Log Main")]
        public void GivenIGoBackFromEDIMessageLogMain()
        {
            BCOutboundPage4.GoBackFromEDIMessageLogMainPage();
        }

        [Given(@"I go back from EDI Message Log List")]
        public void GivenIGoBackFromEDIMessageLogList()
        {
            BCOutboundPage4.GoBackFromEDIMessageLogListPage();
        }

        [Given(@"I click EDI dropdown menu from ACTIONS without switching ContentFrame")]
        public void GivenIClickEDIDropdownMenuFromACTIONSWithoutSwitchingContentFrame()
        {
            BCOutboundPage4.EDIDropdownMenusFromACTIONS();
        }

        [Given(@"I clear customer reference value on EDI Message Log List")]
        public void GivenIClearCustomerReferenceValueOnEDIMessageLogList()
        {
            BCOutboundPage4.ClearCustomerReferenceValueEDIMessageLogList();
        }

        [Given(@"I enter a non existing transporter on EDI Message Log Main '(.*)'")]
        public void GivenIEnterANonExistingTransporterOnEDIMessageLogMain(string Transport)
        {
            BCOutboundPage4.EnterANonExistingTransporterOnEDIMessageLogMain(Transport);
        }

        [Given(@"I clear value of transporter on EDI Message Log Main")]
        public void GivenIClearValueOfTransporterOnEDIMessageLogMain()
        {
            BCOutboundPage4.ClearTransporterValueOnEDIMessageLogMain();
        }


        [Given(@"I enter an Order Type '(.*)'")]
        public void GivenIEnterAnOrderType(string OrderType)
        {
            BCOutboundPage4.EnterOrderType(OrderType);
        }

        [Given(@"I clear Order Type from EDI Message Log List")]
        public void GivenIClearOrderTypeFromEDIMessageLogList()
        {
            BCOutboundPage4.ClearOrderTypeFromEdiMessagLogList();
        }

        [Given(@"I enter filter '(.*)' on Queue Group List")]
        public void GivenIEnterFilterOnQueueGroupList(string Filter)
        {
            BCOutboundPage4.EnterFilteronQueueGroupList(Filter);
        }


        [Given(@"I enter queue code '(.*)' in code field")]
        public void GivenIEnterQueueCodeInCodeField(string Filter)
        {
            BCOutboundPage7.SendQueueCodeInCodeField(Filter);
        }

        [Given(@"I enter outbound copied value on Input Field Filter -> QueueGroupList")]
        public void GivenIEnterOutboundCopiedValueOnInputFieldFilter_QueueGroupList()
        {
            BCOutboundPage4.EnterCopiedOutboundInputFilterQueueGroupList();
        }
        [Given(@"I enter batch copied value on Input Field Filter -> QueueGroupList")]
        [When(@"I enter batch copied value on Input Field Filter -> QueueGroupList")]
        [Then(@"I enter batch copied value on Input Field Filter -> QueueGroupList")]
        public void GivenIEnterBatchCopiedValueOnInputFieldFilter_QueueGroupList()
        {
            BCOutboundPage4.EnterCopiedBatchInputFilterQueueGroupList();
        }

        [Given(@"I enter batch copied value from card on Input Field Filter -> QueueGroupList")]
        [When(@"I enter batch copied value from card on Input Field Filter -> QueueGroupList")]
        [Then(@"I enter batch copied value from card on Input Field Filter -> QueueGroupList")]
        public void GivenIEnterBatchCopiedValueOnInputFieldFilterFromCard_QueueGroupList()
        {
            BCOutboundPage4.EnterCopiedBatchInputFilterQueueGroupListFromCard();
        }

        [Given(@"I enter outbound copied value in search box -> TRO Unlink")]
        public void GivenIEnterOutboundCopiedValueInSearchBox_TROUnlink()
        {
            BCOutboundPage4.EnterCopiedOutboundValueInSearchBoxTROUnlink();
        }

        [Given(@"I enter '(.*)' on Input Field Filter -> QueueGroupList")]
        public void GivenIEnterOnInputFieldFilter_QueueGroupList(string inputOnFilter)
        {
            BCOutboundPage5.EnterOnInputFieldFilterQueueGroupList(inputOnFilter);
        }

        [Given(@"I click Show filter Pane -> QueueGroupList")]
        public void GivenIClickShowFilterPane_QueueGroupList()
        {
            BCOutboundPage5.ShowFilterPaneQueueGroupList();
        }



        [Given(@"I enter copied outbounds on Input Field Filter -> QueueGroupList")]
        public void GivenIEnterCopiedOutboundsOnInputFieldFilter_QueueGroupList()
        {
            BCOutboundPage2.EnterCopiedOutboundsOnInputFilterQueueGroupList();
        }


        [Given(@"I click Actions and QueueGroup -> QueueGroupList")]
        [When(@"I click Actions and QueueGroup -> QueueGroupList")]
        [Then(@"I click Actions and QueueGroup -> QueueGroupList")]
        public void GivenIClickActionsAndQueueGroup_QueueGroupList()
        {
            BCOutboundPage5.ClickActionsAndQueueGroup_QueueGroupList();
        }

        [Given(@"I click Planning and Add to Batch -> QueueGroupList"), When(@"I click Planning and Add to Batch -> QueueGroupList")]
        public void GivenIClickPlanningAndAddToBatch_QueueGroupList()
        {
            BCOutboundPage5.ClickPlanningAndAddToBatchQueueGroupList();
        }

        [Given(@"I click Planning and Unlink from Batch -> QueueGroupList"), When(@"I click Planning and Unlink from Batch -> QueueGroupList"), Then(@"I click Planning and Unlink from Batch -> QueueGroupList")]
        public void GivenIClickPlanningAndUnlinkfromBatch_QueueGroupList()
        {
            BCOutboundPage5.ClickPlanningAndUnlinkfromBatchQueueGroupList();
        }

        [Given(@"I click NEW BATCH button")]
        public void GivenIClickNEWBATCHButton()
        {
            BCOutboundPage5.IClickNEWBATCHButtononPage();
        }

        [Given(@"I select batch type '(.*)'"), When(@"I select batch type '(.*)'")]
        public void GivenISelectBatchType(string p0)
        {
            BCOutboundPage5.ISelectBatchType(p0);
        }


        [Given(@"I write Add to Batch '(.*)' input")]
        public void GivenIWriteAddToBatchInput(string p0)
        {
            BCOutboundPage5.WriteAddToBatchInputvalue(p0);
        }


        [Given(@"I click Operations Overviews in Main Menu -> Outbound")]
        public void GivenIClickOperationsOverviewsInMainMenu_Outbound()
        {
            BCOutboundPage1.SwitchToMainContentFrame();
            BCOutboundPage2.OperationOverviewMenu();
        }

        [Given(@"I click and send Code in Queue Group List '([^']*)'")]
        public void GivenIClickAndSendCodeInQueueGroupList(string p0)
        {
            BCOutboundPage2.ClickAndSendCodeInQueueGroup(p0);
        }



        [Given(@"I enter fixed value '(.*)' of queuegroup on filter code -> QueueGroupList")]
        public void GivenIEnterFixedValueOfQueuegroupOnFilterCode_QueueGroupList(string QueueGroup)
        {
            BCOutboundPage5.EnterFixedValueQueueOnFilterCodeQGRPList(QueueGroup);
        }

        [Given(@"I select the second queue in outbound")]
        public void ISelectTheSecondQueueInOutbound()
        {
            BCOutboundPage5.SelectSecondQueueField();
        }

        [Given(@"I click create Wave")]
        public void GivenIClickCreateWave()
        {
            BCOutboundPage5.CreateWaveButton();
        }

        [Given(@"I click Link and Link To a Transport -> Outbound")]
        public void GivenIClickLinkAndLinkToATransport()
        {
            BCOutboundPage5.ClickLinkAndLinkToATransport();
        }

        [Given(@"I click New in TRO")]
        public void GivenIClickNewInTRO()
        {
            BCOutboundPage5.Setup_General_Item_New();

        }

        [Given(@"I enter two outbounds copied values on Input Field Filter -> QueueGroupList")]
        public void GivenIEnterTwoOutboundsCopiedValuesOnInputFieldFilter_QueueGroupList()
        {
            BCOutboundPage5.EnterCopiedOutboundsValuesInputFilterQueueGroupList();
        }

        [Given(@"I click on back button in general")]
        public void GivenIClickBackButtonInGeneral()
        {
            BCOutboundPage2.ClickBackButtonInGenerals();
        }

        [Given(@"I click on back button from outbound")]
        public void GivenIClickBackButtonFromOutbound()
        {
            BCOutboundPage2.ClickBackButtonFromOutbounds();
        }

        [Given(@"I Refresh the page FPFB after creating multi order")]
        public void GivenIClickRefreshButtonFPFB()
        {
            BCOutboundPage2.ClickRefreshButtonFPFB();
            BCOutboundPage1.SwitchToMainContentFrame();
        }

        [Given(@"I change the status of the queue group list to Created")]
        public void GivenIChangeTheStatusOfTheQueueGroupListToCreated()
        {
            BCOutboundPage2.ChangeTheStatusOfTheQueueGroupListToCreated();
        }

        [Given(@"I change the status of the queue group list to All")]
        public void GivenIChangeTheStatusOfTheQueueGroupListToAll()
        {
            BCOutboundPage2.ChangeTheStatusOfTheQueueGroupListToAll();
        }

        [Given(@"I click Book Back Selected Replenishment QG -> QueueGroupList")]
        public void GivenIClickBookBackSelectedReplenishmentQG_QueueGroupList()
        {
            BCOutboundPage5.ClickBookBackSelectedReplenishmentQG_QueueGroupList();
        }
        [Given(@"I click back button general")]
        public void GivenIClickBackButtonGeneral()
        {
            BCOutboundPage5.ClickBackButtonGenerals();
        }
        [Given(@"I click Setup on Main Menu without Switch content frame")]
        public void GivenIClickSetupOnMainMenuWithoutSwitchContentFrame()
        {
            BCOutboundPage5.SETUPMenu();
        }
        [Given(@"I refresh page content")]
        public void GivenIRefreshPageContent()
        {
            BCOutboundPage5.RefreshPageContent();
        }
        [Given(@"I click Setup on Main Menu without switch to Main Content Frame")]
        public void GivenIClickSetupOnMainMenuWithoutSwitchToMainContentFrame()
        {
            BCOutboundPage5.SETUPMenu();
        }

        [Given(@"I click Scheduler -> Nas simulator")]
        public void GivenIClickSchedulerNasSimulator()
        {
            BCOutboundPage5.ClickNasSimulatorInScheduler();
        }

        [Given(@"I click Operations Overviews in Main Menu without SwitchContent")]
        public void GivenIClickOperationsOverviewsInMainMenuWithoutSwitchContent()
        {
            BCOutboundPage5.OperationOverviewMenu();
        }

        [Given(@"I click Launch -> QueueGroupList")]
        public void GivenIClickLaunch_QueueGroupList()
        {
            BCOutboundPage5.ClickLaunch_QueueGroupList();
        }

        [Given(@"I click Launch Queue Group")]
        public void GivenIClickLaunchQueueGroup()
        {
            BCOutboundPage5.ClickLaunchQueueGroupList();
        }

        [Given(@"I click Launch and print picklabels -> QueueGroupList")]
        public void GivenIClickLaunchAndPrintPickLabels_QueueGroupList()
        {
            BCOutboundPage5.ClickLaunchAndPrintPicklabels();
        }
        [Given(@"I scroll until i get to picklabel numbers")]
        public void GivenIScrollUntilIGetToPicklabelNumbers()
        {
            BCOutboundPage5.ScrollUntilIGetToPicklabelNumbers();
        }
        [Given(@"I validate that picklabel numbers are not equal")]
        public void GivenIValidatePicklabelNumbersAreNotEqual()
        {
            BCOutboundPage5.ValidatePicklabelNumbersAreNotEqual();
        }
        [Given(@"I navigate to table page of POWER Queue Detail")]
        public void GivenINavigateToTablePageOfPOWERQueueDetail()
        {
            BCOutboundPage1.INavigateToTablePageOfPOWERQueueDetail();
            BCOutboundPage1.SwitchToMainContentFrame();
        }
        [Given(@"I click Set Back Created on QuegroupList")]
        public void GivenIClickSetBackCreatedOnQuegroupList()
        {
            BCOutboundPage5.ClickSetBackCreatedOnQuegroupList();
        }

        [Given(@"I click Book Back selected Batch picking QG")]
        public void GivenIClickBookBackSelectedBatchPickingQG()
        {
            BCOutboundPage5.ClickBookBackSelectedBatchPickingQG();
        }

    }
}
