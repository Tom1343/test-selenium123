using CGI_OUTBOUND_BC_Scenarios.OUTBOUND.Pages;
using CGI_OUTBOUND_BC_Scenarios.Utilities;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace CGI_OUTBOUND_BC_Scenarios.OUTBOUND.Steps
{
    [Binding]
    public class BCOutboundSteps4
    {
        public IWebDriver Driver;

        public BCOutboundSteps4(IWebDriver driver) => Driver = driver;

        private BCOutboundPage1 BCOutboundPage1 => new BCOutboundPage1(Driver);
        private BCOutboundPage2 BCOutboundPage2 => new BCOutboundPage2(Driver);
        private BCOutboundPage3 BCOutboundPage3 => new BCOutboundPage3(Driver);
        private BCOutboundPage4 BCOutboundPage4 => new BCOutboundPage4(Driver);
        private BCOutboundPage5 BCOutboundPage5 => new BCOutboundPage5(Driver);
        private BCOutboundPage6 BCOutboundPage6 => new BCOutboundPage6(Driver);
        private BCOutboundPage7 BCOutboundPage7 => new BCOutboundPage7(Driver);
        public WaitMethods WaitMethods => new WaitMethods(Driver);


        [Given(@"I select Generate Multi Order for two lines")]
        public void GivenISelectGenerateMultiOrderForTwoLines()
        {
            BCOutboundPage5.GenerateMultiOrderForTwoLines();
        }

        [Given(@"I select two queue lines")]
        public void GivenISelectTwoQueueLines()
        {
            BCOutboundPage5.SelectTwoQueueLines();
        }

        [Given(@"I click Search option on Outbound List")]
        [When(@"I click Search option on Outbound List")]
        [Then(@"I click Search option on Outbound List")]
        public void GivenIClickSearchOptionOnOutboundList()
        {
            BCOutboundPage5.ClickSearchOptionOnOutboundList();
        }

        [Given(@"I click on Search option on Outbound List")]
        public void GivenIClickOnSearchOptionOnOutboundList()
        {
            BCOutboundPage5.ClickOnSearchOptionOnOutboundList();
        }

        [Given(@"I search Batch with variable")]
        public void GivenISearchBatchWithVariable()
        {
            BCOutboundPage5.ISearchBatchWithVariable();
        }


        [Given(@"I click Edit option on Outbound List")]
        [When(@"I click Edit option on Outbound List")]
        [Then(@"I click Edit option on Outbound List")]
        public void GivenIClickEditOptionOnOutboundList()
        {
            BCOutboundPage5.ClickEditOptionOutboundList();
        }

        [Given(@"I click Edit option on Outbound List after filtering")]
        [When(@"I click Edit option on Outbound List after filtering")]
        [Then(@"I click Edit option on Outbound List after filtering")]
        public void GivenIClickEditOptionOnOutboundListAfterFiltering()
        {
            BCOutboundPage5.ClickEditOptionOutboundListAfterFiltering();
        }

        [Given(@"I click yes to send packing confirmation again")]
        [When(@"I click yes to send packing confirmation again")]
        [Then(@"I click yes to send packing confirmation again")]
        public void GivenIClickYesToSendPackingConfirmationAgain()
        {

            BCOutboundPage5.ClickYesToSendPackingConfirmation();
        }

        [Given(@"I select loaded check box in status outbound order filter")]
        public void GivenISelectLoadedCheckBoxInStatusOutboundOrderFilter()
        {
            BCOutboundPage3.SelectLoadedCheckBoxInStatusOutboundOrderFilter();
        }

        [Given(@"I click Holder button on Pickholders")]
        [When(@"I click Holder button on Pickholders")]
        [Then(@"I click Holder button on Pickholders")]
        public void GivenIClickHolderButtonOnPickholders()
        {
            BCOutboundPage5.IClickHolderButtonOnPickholders();
        }

        [Given(@"I click Pick Holders button in outbound")]
        [When(@"I click Pick Holders button in outbound")]
        [Then(@"I click Pick Holders button in outbound")]
        public void GivenIClickPickHolderButtonInOutbound()
        {
            BCOutboundPage5.IClickPickHolderButtonInOutbound();
        }

        [Given(@"I click Card button on Holder")]
        [When(@"I click Card button on Holder")]
        [Then(@"I click Card button on Holder")]
        public void GivenIClickCardButtonOnHolder()
        {
            BCOutboundPage5.IClickCardButtonOnHolder();
        }

        [Given(@"I click Unpack Unlabel Holder")]
        [When(@"I click Unpack Unlabel Holder")]
        [Then(@"I click Unpack Unlabel Holder")]
        public void GivenIClickUnpackUnlabelHolder()
        {
            BCOutboundPage5.IClickUnpackLabelHolder();
        }

        [Given(@"I click Delete option on Outbound List")]
        public void GivenIClickDeleteOptionOnOutboundList()
        {
            BCOutboundPage5.ClickDeleteOptionOutboundList();
        }

        [Given(@"I click yes button to delete TRO")]
        public void GivenIClickYesButtonToDeleteTRO()
        {
            BCOutboundPage5.IClickYesButtonToDeleteTRO();
        }

        [Given(@"I should get Status Outbound Order Reserved")]
        public void GivenIShouldGetStatusOutboundOrderReserved()
        {

            BCOutboundPage5.IShouldGetStatusOutboundOrderReservedNotification();

        }

        [Given(@"I should get Status Outbound In Order")]
        public void GivenIShouldGetStatusOutboundInOrder()
        {
            BCOutboundPage5.IShouldGetStatusOutboundInOrder();
        }


        [Given(@"I see screen Outbound List")]
        public void GivenISeeScreenOutboundList()
        {
            BCOutboundPage5.ISeeScreenOutboundList();
        }

        [When(@"I click Calculate Batch")]
        [Given(@"I click Calculate Batch")]
        public void GivenIClickCalculateBatch()
        {
            BCOutboundPage5.IClickCalculateBatchButton();
        }

        [When(@"I select and launch holder retrieval queue")]
        [Given(@"I select and launch holder retrieval queue")]
        [Then(@"I select and launch holder retrieval queue")]
        public void GivenISelectAndLaunchHolderRetrievalQueue()
        {
            BCOutboundPage5.ISelectAndLaunchHolderRetrievalQueue();
        }

        [When(@"I turn on full box retrieval option")]
        [Given(@"I turn on full box retrieval option")]
        [Then(@"I turn on full box retrieval option")]
        public void GivenITurnOnFullBoxRetrievalOption()
        {
            BCOutboundPage5.ITurnOnFullBoxRetrievalOption();
        }

        [When(@"I turn on priority batch option")]
        [Given(@"I turn on priority batch option")]
        [Then(@"I turn on priority batch option")]
        public void GivenITurnOnPriorityBatchOption()
        {
            BCOutboundPage5.ITurnOnPriorityBatchOption();
        }

        [When(@"I turn on full pallet full box retrieval option")]
        [Given(@"I turn on full pallet full box retrieval option")]
        [Then(@"I turn on full pallet full box retrieval option")]
        public void GivenITurnOnFullPalletFullBoxRetrievalOption()
        {
            BCOutboundPage5.ITurnOnFullPalletFullBoxRetrievalOption();
        }

        [Given(@"I click Edit option -> TRO List")]
        public void GivenIClickEditOption_TROList()
        {
            BCOutboundPage5.ClickEditOption_TROList();
        }


        [Given(@"I enter outbound code on search option -> Outbound list")]
        public void GivenIEnterOutboundCodeOnSearchOption_OutboundList()
        {
            BCOutboundPage5.EnterOutboundCodeSearchOutboundList();
        }



        [Given(@"I enter transport outbound code on search option -> Transport Outbound list")]
        public void GivenIEnterTransportOutboundCodeOnSearchOption_OutboundList()
        {
            BCOutboundPage5.EnterTransportOutboundCodeSearchOutboundList();
        }

        [Given(@"I enter outbound In Order code on search option -> Outbound list")]
        public void GivenIEnterOutboundInOrderCodeOnSearchOption_OutboundList()
        {
            BCOutboundPage5.IEnterOutboundInOrderCodeOnSearchOptionOutboundList();
        }


        [Given(@"I click Reservations on Outbound")]
        public void GivenIClickReservationsOnOutbound()
        {
            BCOutboundPage5.ClickReservationsOutbound();
        }

        [Given(@"I save QueueGroup code from Outbound Reservations")]
        public void GivenISaveQueueGroupCodeFromOutboundReservations()
        {
            BCOutboundPage5.SaveQueueGroupCodeOutbuondReservations();
        }

        [Given(@"I enter saved queuegroup code from Outbound Reservations")]
        public void GivenIEnterSavedQueuegroupCodeFromOutboundReservations()
        {
            BCOutboundPage5.EnterSavedQueueGroupCodeOutboundReservations();
        }

        [Given(@"I enter date created in Queue Group List")]
        public void GivenIEnterDateCreatedInQueueGroupList()
        {
            BCOutboundPage5.EnterDateCreatedQueueGroupList();
        }

        [Given(@"I click filter on QueueGroupList")]
        public void GivenIClickFilterOnQueueGroupList()
        {
            BCOutboundPage5.FilterQueueGroupLists();
        }

        [Given(@"I click on filter list by")]
        public void GivenIClickOnFilterListBy()
        {
            BCOutboundPage5.FilterListBy();
        }

        [Given(@"I click More options nav menu -> Outbound")]
        public void GivenIClickMoreOptionsNavMenu_Outbound()
        {
            BCOutboundPage5.IClickMoreOptionsNavigationMenuOutbound();
        }

        [Given(@"I click Navigate nav menu")]
        public void GivenIClickNavigateNavMenu()
        {
            BCOutboundPage5.IClickNavigateNavMenu();
        }

        [Given(@"I click BWN Error")]
        public void GivenIClickBWNError()
        {
            BCOutboundPage5.IClickBWNErrorButton();
        }

        [Given(@"I click Details from header")]
        public void GivenIClickDetailsFromHeader()
        {
            BCOutboundPage5.IClickDetailsFromHeaders();
        }


        [Given(@"I click Outbound on Filter Dropdown -> QueueGroupList")]
        public void GivenIClickOutboundOnFilterDropdown_QueueGroupList()
        {
            BCOutboundPage5.ClickOutboundOnFilterDropdown_QueueGroupList();
        }

        [Given(@"I write '(.*)' on Filter -> QueueGroupList")]
        public void GivenIWriteOnFilter_QueueGroupList(string filter)
        {
            BCOutboundPage6.WriteFilterOnQueueGroupList(filter);
        }

        [Given(@"I enter '(.*)' on Search -> OutboundList")]
        public void GivenIEnterOutboundOnSearch_OutboundList(string filter)
        {
            BCOutboundPage6.EnterOutboundOnSearchOutboundList(filter);
        }


        [Given(@"I click Code -> Quegroup Dropdown")]
        public void GivenIClickCode_QuegroupDropdown()
        {
            BCOutboundPage5.ClickCode_QuegroupDropdown();
        }



        [Given(@"I click Launch on QuegroupList")]
        public void GivenIClickLaunchOnQuegroupList()
        {
            BCOutboundPage5.LaunchQueueGroup();
        }

        [Given(@"I click Launch on QuegroupList -> after MultiOrder")]
        public void GivenIClickLaunchOnQuegroupList_AfterMultiOrder()
        {
            BCOutboundPage5.ClickLaunchOnQuegroupListAfterMultiOrder();
        }

        [Given(@"I click navBar on QueueGroup -> Outbound")]
        public void GivenIClickNavBarOnQueueGroup_Outbound()
        {
            BCOutboundPage5.IClickNavBarOnQueueGroupOutbound();
        }


        [Given(@"I click yes to launch queue groups")]
        public void GivenIClickYesToLaunchQueueGroups()
        {
            BCOutboundPage5.ClickYesToLaunchQueueGroups();
        }

        [Given(@"I click OK button -> Outbound")]
        public void GivenIClickOKButton_Outbound()
        {
            BCOutboundPage6.ClickOKButtonOutboundCard();
        }

        [Given(@"I validate error '(.*)' message Power Queue Group List")]
        public void GivenIValidateErrorMessagePowerQueueGroupList(string p0)
        {
            BCOutboundPage6.ValidateErrorMessagePowerQueueGroupList(p0);
        }
      
        [Given(@"I click OK button to calculate batch")]
        public void GivenIClickOKButton_OutboundToCalculateBatch()
        {
            BCOutboundPage6.ClickOKButtonOutboundCardCalculate();
        }

        [Given(@"I Click Back in Outbound Cart")]
        public void GivenIClickBackInOutboundCart()
        {
            BCOutboundPage1.SwitchToMainContentFrame();
            BCOutboundPage6.ClickBackButtonOutboundCard();
        }

        [Given(@"I write '(.*)' on input for cancel -> Outbound")]
        public void GivenIWriteOnInputForCancel_Outbound(string numberInput)
        {
            BCOutboundPage4.WriteOnInputForCancelOutbound(numberInput);
        }


        [Given(@"I enter outbound value '(.*)' on Input Field Filter -> QueueGroupList")]
        public void GivenIEnterOutboundValueOnInputFieldFilter_QueueGroupList(string p0)
        {
            BCOutboundPage4.nIEnterOutboundValueOnInputFieldFilter_QueueGroupList(p0);
        }

        [Given(@"I enter batch value '(.*)' on Input Field Filter -> QueueugroupList")]
        public void GivenIEnterBatchValueOnInputFieldFilter_QueueugroupList(string p0)
        {
            BCOutboundPage4.EnterBatchValueOnInputFieldFilter_QueueugroupList(p0);
        }


        [Given(@"I enter batch number value '(.*)' on Input Field Filter For Batch Number")]
        public void GivenIEnterBatchNumberValueOnInputField(string p0)
        {
            BCOutboundPage4.EnterBatchNumberValueOnInputField(p0);
        }

        [Given(@"I expand show more options in queue group")]
        public void GivenIExpandShowMoreOptionsInQueueGroup()
        {
            BCOutboundPage6.IExpandShowMoreOptionsInQueueGroup();
        }

        [Given(@"I select the second row for the second queue")]
        public void GivenISelectTheSecondRowForTheSecondQueue()
        {
            BCOutboundPage6.ISelectTheSecondRowForTheSecondQueue();
        }

        [Given(@"I enter customer reference value '(.*)' on Input Field Filter -> Transport Outbound")]
        public void GivenIEnterCustomerReferenceValueOnInputFieldFilter(string p0)
        {
            BCOutboundPage4.IEnterCustomerReferenceValueOnInputFieldFilter(p0);
        }

        [Given(@"I click Card on QueueGroupList")]
        public void GivenIClickCardOnQueueGroupList()
        {
            BCOutboundPage5.CardQueueGroupListPage();
        }

        [Given(@"I copy Pickwave Code on QueueGroupList")]
        public void GivenICopyPickwaveCodeOnQueueGroupList()
        {
            BCOutboundPage5.CopyPickwaveCodeQueueGroupList();
        }

        [Given(@"I save Pickwave holder barcode on QueueGroupList")]
        public void GivenISavePickwaveHolderBarcodeOnQueueGroupList()
        {
            BCOutboundPage5.SavePickwaveHolderBarcodeQueueGroupList();
        }


        [Given(@"I copy Pickwave holder barcode on QueueGroupList")]
        public void GivenICopyPickwaveHolderBarcodeOnQueueGroupList()
        {
            BCOutboundPage5.CopyPickwaveHolderBarcodeQueueGroupList();
        }

        [Given(@"I click close card on QueueGroup card")]
        public void GivenIClickCloseCardOnQueueGroupCard()
        {
            BCOutboundPage5.CloseCardQueueGroupCardPage();
        }

        [Given(@"I go back from QueueGroupList")]
        public void GivenIGoBackFromQueueGroupList()
        {
            BCOutboundPage5.GoBackFromQueueGroupList();
        }

        [Given(@"I save Pickwave Code on QueueGroupList")]
        public void GivenISavePickwaveCodeOnQueueGroupList()
        {
            BCOutboundPage5.SavePickwaveCodeQueueGroupList();
        }


        [Given(@"I Book Back selected records -> OrderLine Outbound")]
        public void GivenIBookBackSelectedRecords_OrderLineOutbound()
        {
            BCOutboundPage4.BookBackSelectedRecordsOrderLineOutbounds();
        }

        [Given(@"I complete book back selected records -> OrderLine Outbound")]
        public void GivenICompleteBookBackSelectedRecords_OrderLineOutbound()
        {
            BCOutboundPage4.CompleteBookBackSelectedRecordsOrderLineOutbounds();
        }


        [Given(@"I click Book back selected Pickwave QG")]
        public void GivenIClickBookBackSelectedPickwaveQG()
        {
            BCOutboundPage5.ClickBookBackSelectedPickwaveQG();
        }

        [Given(@"I click on book back selected pickwave Queue Group")]
        public void GivenIClickOnBookBackSelectedPickwaveQueueGroup()
        {
            BCOutboundPage5.ClickBookBackSelectedPickwaveQueueGroup();
        }

        [Given(@"I click on show more and book back after FPFB creation")]
        public void GivenIClickOnShowMoreAndBookBackAfterFPFBCreation()
        {
            BCOutboundPage5.ClickOnShowMoreAndBookBackAfterFPFBCreation();
        }

        [Given(@"I click Yes button -> Outbound"), When(@"I click Yes button -> Outbound"), Then(@"I click Yes button -> Outbound")]
        public void GivenIClickYesButton_Outbound()
        {
            BCOutboundPage5.IClickYesButtonOutbound();
        }

        [Given(@"I cancel qty in Lines -> Outbound")]
        public void GivenUCancelQtyInLines_Outbound()
        {
            BCOutboundPage5.CancelQTYinLinesOutbound();
        }

        [Given(@"I cancel qty in Lines Outbound for part orderline")]
        public void GivenUCancelQtyInLinesOutboundForPartOrderline()
        {
            BCOutboundPage5.CancelQTYinLinesOutboundForPartOrderLine();
        }

        [Given(@"I cancel qty expecting error message")]
        public void GivenICancelQTYExpectingErrorMessage()
        {
            BCOutboundPage5.CancelQTYExpectErrorMessage();
        }

        [Given(@"I cancel qty in Lines in Outbound")]
        public void GivenUCancelQtyInLinesInOutbound()
        {
            BCOutboundPage5.CancelQTYinLinesInOutbound();
        }

        [Given(@"I click yes to confirm cancellation -> Outbound")]
        public void GivenIClickYesToConfirmCancellation_Outbound()
        {
            BCOutboundPage5.YesConfirmCancellationOutbound1();
        }

        [Given(@"I write '(.*)' on Cancel Code")]
        public void GivenIWriteOnCancelCode(string CancelCode)
        {
            BCOutboundPage5.WriteOnCancelCodeOutbound(CancelCode);
        }

        [Given(@"I Click Close -> Destination Group")]
        public void GivenIClickClose_DestinationGroup()
        {
            BCOutboundPage5.ClickCloseDestinationGroupButton();
        }

        [Given(@"I copy the TRO number")]
        public void GivenICopyTheTroNumber()
        {
            BCOutboundPage5.CopyTheTroNumber();
        }

        [Given(@"I enter t on Date created")]
        public void GivenIEnterTOnDateCreated()
        {
            BCOutboundPage5.IEnterTOnDateCreated();
        }


        [Given(@"I Send the QueueGroups with filename '(.*)'"),Then(@"I Send the QueueGroups with filename '(.*)'")]
        
        public void GivenISendTheQueueGroupsWithFilename(string fileName)
        {
            BCOutboundPage5.SendInstructionToQueueGroup(fileName);
        }

      


        [Given(@"I Send the QueueGroups with filename '([^']*)' No Response")]
        public void GivenISendTheQueueGroupsWithFilenameNoResponse(string fileName)
        {
            BCOutboundPage5.SendInstructionToQueueGroupNoResponse(fileName);
        }


        [Given(@"I Send the QueueGroups with filename '(.*)' in ADEO")]
        public void GivenISendTheQueueGroupsWithFilenameInADEO(string fileName)
        {
            BCOutboundPage5.SendInstructionToQueueGroupInAdeo(fileName);
        }

        [Given(@"I Send the QueueGroups with filename '([^']*)' in Baselinethree")]
        public void GivenISendTheQueueGroupsWithFilenameInBaselinethree(string fileName)
        {
            BCOutboundPage5.SendInstructionToQueueGroupThree(fileName);

        }
        [Given(@"I Send the QueueGroups with filename '([^']*)' in Nilfisk")]
        public void GivenISendTheQueueGroupsWithFilenameInNilfisk(string p0)
        {
            BCOutboundPage5.SendInstructionToQueueGroupNilfisk(p0);
        }

        [Given(@"I Send the QueueGroups with filename '([^']*)' Nilfsik Launch")]
        public void GivenISendTheQueueGroupsWithFilenameNilfsikLaunch(string fileToSend)
        {
            BCOutboundPage5.LaunchInstructionToQueueGroupNilfisk(fileToSend);
        }

        [Given(@"I send '([^']*)' to BC nilfisk")]
        public void GivenISendToBCNilfisk(string p0)
        {
            BCOutboundPage5.SendMessageToBCNilfisk(p0);
        }



        [Given(@"I Send the QueueGroups with filename '([^']*)' in Nilfisk Launch")]
        public void GivenISendTheQueueGroupsWithFilenameInNilfiskLaunch(string p0)
        {
            BCOutboundPage5.SendInstructionToQueueGroupNilfiskLaunch(p0);
            System.Threading.Thread.Sleep(1300);
        }


        [Given(@"I Send the QueueGroups with filename '([^']*)' in STST")]
        public void GivenISendTheQueueGroupsWithFilenameInSTST(string fileName)
        {
            BCOutboundPage5.SendInstructionToQueueGroupSTST(fileName);
        }


        [Given(@"I Send the QueueGroups with filename '([^']*)' in KitchenAid")]
        public void GivenISendTheQueueGroupsWithFilenameInKitchenAid(string fileName)
        {
            BCOutboundPage5.SendInstructionToQueueGroupKitchenAid(fileName);
        }

        [Given(@"I send XML file to BC '([^']*)'")]
        public void GivenISendXMLFileToBC(string p0)
        {
            BCOutboundPage5.SendXMLtoBC(p0);
        }

        [Given(@"I send XML file to BC '([^']*)' in BASELINE")]
        public void GivenISendXMLFileToBCInBASELINE(string p0)
        {
            BCOutboundPage5.SendXMLtoBCBaseline(p0);
        }


        [Given(@"I cancell Loading queue '(.*)'")]
        public void GivenICancellLoadingQueue(string fileName)
        {
            BCOutboundPage5.CancellLoadingQueu(fileName);
        }


        [Given(@"I Send the QueueGroups with filename '(.*)' to BaselineTwo")]
        public void GivenISendTheQueueGroupsWithFilenameToBaselineTwo(string fileName)
        {
            BCOutboundPage5.SendInstructionToQueueGroupBaselineTwo(fileName);
        }


        [Given(@"I send queuegroups '(.*)' and launch them '(.*)'")]
        public void GivenISendQueuegroupsAndLaunchThem(string fileToSend, string fileToLaunch)
        {
            BCOutboundPage5.SendInstructionToQueueGroup(fileToSend);
            BCOutboundPage5.SendInstructionToQueueGroup(fileToLaunch);
        }

        [Given(@"I Run Nas Simulator with Saved Data '(.*)'")]
        public void GivenIRunNasSimulatorWithSavedData(string p0)
        {
            BCOutboundPage5.SendNasSimulatorwithSaveData(p0);
        }


        [Given(@"I RUN NAS SIMMULATOR '(.*)'")]
        public void GivenIRUNNASSIMMULATOR(string fileName)
        {
            BCOutboundPage5.SendNasSimulator(fileName);
        }

        [Given(@"I write '(.*)' on Qty to cancel")]
        public void GivenIWriteOnQtyToCancel(string qtyToCancel)
        {
            BCOutboundPage5.WriteOnQtyToCancel(qtyToCancel);
        }

        [Given(@"I write '(.*)' on Input Window -> Outbound")]
        public void GivenIWriteOnInputWindow_Outbound(string inputWindow)
        {
            BCOutboundPage5.IWriteOnInputWindowOutbound(inputWindow);
        }


        [Given(@"I write Max number on Multi Order '(.*)'")]
        public void GivenIWriteMaxNumberOnMultiOrder(string MaxNumberOnMultiOrder)
        {
            BCOutboundPage5.IWriteMaxNumberOnMultiOrder(MaxNumberOnMultiOrder);
        }


        [Given(@"I click second Item line")]
        public void GivenIClickSecondItemLine()
        {
            BCOutboundPage5.ClickItemInOrderLineTwoOutbound();
        }

        [Given(@"I click Book Back for the selected line -> Outbound")]
        public void GivenIClickBookBackForTheSelectedLine_Outbound()
        {
            BCOutboundPage5.BookBackSelectedLineOutbound();
        }

        [Given(@"I click Book Back part of selected line -> Outbound")]
        public void GivenIClickBookBackPartOfSelectedLine_Outbound()
        {
            BCOutboundPage5.ClickBookBackPartOfSelectedLine_Outbound();
        }

        [Given(@"I yes to confirm book back -> Outobund")]
        public void GivenIYesToConfirmBookBack_Outobund()
        {
            BCOutboundPage5.YesConfirmBookBackOutbound();
        }

        [Given(@"I enter qty '(.*)' to book back -> Outbound")]
        public void GivenIEnterQtyToBookBack_Outbound(string QtyToBookBack)
        {
            BCOutboundPage6.EnterQtyToBookBack(QtyToBookBack);
        }

        [Given(@"I enter transporter '(.*)' on Outbound")]
        public void GivenIEnterTransporterOnOutbound(string Transporter)
        {
            BCOutboundPage6.EnterTransporterOnOutbound(Transporter);
        }

        [Given(@"I enter Buyer '(.*)' on Outbound")]
        public void GivenIEnterBuyerOnOutbound(string p0)
        {
            BCOutboundPage6.IEnterBuyerOnOutboundCard(p0);
        }

        [Given(@"I enter transporter on General '(.*)' -> Outbound")]
        public void GivenIEnterTransporterOnGeneral_Outbound(string TransporterOnGeneralOutbound)
        {
            BCOutboundPage6.EnterTransporterOnGeneralOutboundCard(TransporterOnGeneralOutbound);
        }


        [Given(@"I click more options on QueueGroup")]
        public void GivenIClickMoreOptionsOnQueueGroup()
        {
            BCOutboundPage6.MoreOptionsQueueGroup();
        }

        [Given(@"I click more options on QueueGroup -> Second open")]
        public void GivenIClickMoreOptionsOnQueueGroup_SecondOpen()
        {
            BCOutboundPage6.MoreOptionsOnQueueGroupSecondOpen();
        }

        [Given(@"I click more options in queue group list")]
        public void GivenIClickMoreOptionsInQueueGroupList()
        {
            BCOutboundPage6.MoreOptionsInQueueGroupList();
        }


        [Given(@"I click more options on QueueGroup -> second time")]
        public void GivenIClickMoreOptionsOnQueueGroup_SecondTime()
        {
            BCOutboundPage6.MoreOptionsOnQueueGroupSecondTime();
        }


        [Given(@"I click more options on QueueGroup -> TRO")]
        public void GivenIClickMoreOptionsOnQueueGroup_TRO()
        {
            BCOutboundPage6.MoreOptionsOnQueueGroupTRO();
        }


        [Given(@"I click Link to a transport -> QueueGroup")]
        public void GivenIClickLinkToATransport_QueueGroup()
        {
            BCOutboundPage6.LinkToATransportQueueGroupCard();
        }

        [Given(@"I click Actions on QueueGroup")]
        public void GivenIClickActionsOnQueueGroup()
        {
            BCOutboundPage6.ActionsQueueGroups();
        }

        [Given(@"I select Generate Multi Order -> QueueGroup")]
        public void GivenISelectGenerateMultiOrder_QueueGroup()
        {
            BCOutboundPage6.GenerateMultiOrderQueueGroup();
        }

        [Given(@"I enter value '(.*)' on Input Field Filter -> QueueGroupList")]
        public void GivenIEnterValueOnInputFieldFilter_QueueGroupList(string Value)
        {
            BCOutboundPage6.EnterValueOnInputFieldFilterQueueGroupList(Value);
        }

        [Given(@"I click Search Button On NavBar")]
        public void GivenIClickSearchButtonOnNavBar()
        {
            BCOutboundPage6.SearchButtonMainPages();
        }

        [Given(@"I click Run in Nas Simulator")]
        public void GivenIClickRunInNasSimulator()
        {
            BCOutboundPage6.IClickRunButtonInNasSimulator();
        }

        [Given(@"I click Run in Nas Simulator ADEO")]
        public void GivenIClickRunInNasSimulatorADEO()
        {
            BCOutboundPage6.IClickRunButtonInNasSimulatorADEO();
        }


        [Given(@"I search '(.*)' on Search NavBar")]
        public void GivenISearchOnSearchNavBar(string p0)
        {
            BCOutboundPage6.ISearchOnSearchNavBar(p0);
        }


        [Given(@"I search my linked TRO with Outbound")]
        public void GivenISearchMyLinkedTROWithOutbound()
        {
            BCOutboundPage5.SearchMyLinkedTROWithOutbound();
        }


        [Given(@"I write filter '(.*)' On Search Input")]
        public void GivenIWriteFilterOnSearchInput(string Filter)
        {
            BCOutboundPage1.SwitchToMainContentFrame();
            BCOutboundPage6.WriteFilterOnSearchMainPage(Filter);
        }

        [Given(@"I click Search Button On NavBar -> Outbound")]
        public void GivenIClickSearchButtonOnNavBar_Outbound()
        {
            BCOutboundPage6.SearchButtonMainPages();
        }

        [Given(@"I enter '(.*)' location on Search -> Location List")]
        public void GivenIEnterLocationOnSearch_LocationList(string Location)
        {
            BCOutboundPage6.EnterLocationSearchLocationList(Location);
        }

        [Given(@"I copy Check Digit variable from Location card")]
        public void GivenICopyCheckDigitVariableFromLocationCard()
        {
            BCOutboundPage6.CopyCheckDigitLocationCard();
        }

        [Given(@"I go back from Location card")]
        public void GivenIGoBackFromLocationCard()
        {
            BCOutboundPage6.GoBackFromLocationCardPage();
        }

        [Given(@"I enter default location value on Input Field Filter -> QueueGroupList")]
        public void GivenIEnterDefaultLocationValueOnInputFieldFilter_QueueGroupList()
        {
            BCOutboundPage6.EnterDefaultLocationInputFieldFilterQueueGroupList();
        }

        [Given(@"I select my first line -> Code QueGroup Outbound")]
        public void GivenISelectMyFirstLine_CodeQueGroupOutbound()
        {
            BCOutboundPage6.SelectMyFirstLine_CodeQueGroupOutbound();
        }

        [Given(@"I click Show Filter Pane -> QueueGroup Outbound")]
        public void GivenIClickShowFilterPane_QueueGroupOutbound()
        {
            BCOutboundPage6.ClickShowFilterPane_QueueGroupOutbound();
        }

        [Given(@"I click Filter button -> QueueGroup")]
        public void GivenIClickFilterButton_QueueGroup()
        {
            BCOutboundPage6.ClickFilterButton_QueueGroup();
        }


        [Given(@"I Click Transport Outbound -> Outbound")]
        public void GivenIClickTransportOutbound_Outbound()
        {
            BCOutboundPage1.SwitchToMainContentFrame();
            BCOutboundPage2.ClickTransportOutbound();
        }

        [Given(@"I Click Reports from Main page")]
        public void GivenIClickReportsFromMainPage()
        {
            BCOutboundPage1.SwitchToMainContentFrame();
            BCOutboundPage2.ClickReportsFromMainPage();
        }

        [Given(@"I copy Unit Location on Card -> QueueGroupList")]
        public void GivenICopyUnitLocationOnCard_QueueGroupList()
        {
            BCOutboundPage6.CopyUnitLocationCardQueueGroupList();
        }

        [Given(@"I click Show More option in QueueGroupList")]
        public void GivenIClickShowMoreOptionInQueueGroupList()
        {
            BCOutboundPage6.ClickShowMoreOptionQueueGroupList();
        }

        [Given(@"I click a queue on a QueueGroupList")]
        public void GivenIClickAQueueOnAQueueGroupList()
        {
            BCOutboundPage6.ClickAQueueOnQueueGroupList();
        }

        [Given(@"I click on queue on a TTL queues and unload selected masterholders")]
        public void GivenIClickAQueueOnATTLQueuesAndUnloadSelectedMasterholders()
        {
            BCOutboundPage6.ClickOnATTLQueueAndUnloadMasterHolders();
        }

        [Given(@"I verify the location from is empty")]
        public void GivenIVerifyTheLocationFromIsEmpty()
        {
            BCOutboundPage6.VerifyTheLocationFromIsEmpty();
        }

        [Given(@"I hover EDI dropdown menu from ACTIONS")]
        public void GivenIHoverEDIDropdownMenuFromACTIONS()
        {
            WaitMethods.WaitForPageToBeReadyRUNEDI();
            BCOutboundPage6.HoverEDIDropdownsMenuFromACTIONS();
        }

        [Given(@"I click Message Log Sending")]
        public void GivenIClickMessageLogSending()
        {
            BCOutboundPage6.ClickMessageLogSendings();

        }
        [Given(@"I click EDI from navigation bar general")]
        public void GivenIClickEDIFromNavigationBarGeneral()
        {
            WaitMethods.WaitForMainPageToBeReady()
            .WaitForElementToBeGone(By.XPath(Page.ProgressBarMainXPath), 2)
            .WaitForPageToBeReady();
            WaitMethods.WaitForElementToAppear(By.XPath("//iframe[@title='Main Content']"));
            Driver.SwitchTo().Frame(0);
            BCOutboundPage6.ClickEDIFromTheNavogationBars();
        }

        [Given(@"I click Show more on TRI")]
        public void GivenIClickShowMoreOnTRI()
        {
            BCOutboundPage6.ShowMoreInInbounds();
        }
        [Given(@"I click Transport Inbound from Main Page with switching frame")]
        public void GivenIClickTransportInboundFromMainPageWithSwitchingFrame()
        {
            BCOutboundPage6.SwitchToMainContentFrame();
            BCOutboundPage6.ClickTRIMainPage();
        }
        [Given(@"I click More options -> Outbound")]
        public void GivenIClickMoreOptions_Outbound()
        {
            BCOutboundPage6.ClickMoreOptionsFromOutboundCard();
        }
        [Given(@"I click Action from Outbound")]
        public void GivenIClickActionFromOutbound()
        {
            BCOutboundPage6.ClickActionFromOutbound();
        }
        [Given(@"I click Outbound from Action")]
        public void GivenIClickOutboundFromAction()
        {
            BCOutboundPage6.ClickOutboundFromAction();
        }
        [Given(@"I Click CMR Picked")]
        public void GivenIClickCMRPicked()
        {
            BCOutboundPage6.CMRPicked();
        }
        [Given(@"I click OK button on the pop up message")]
        public void GivenIClickOKButtonOnThePopUpMessage()
        {
            BCOutboundPage6.ClickOKButtonOnThePopUpMessages();
        }
        [Given(@"I should verify that the first reserved SKU is '(.*)' , the second reserved SKU is '(.*)' and the third reserved SKU is '(.*)' -> Outbound")]
        public void GivenIVerifyTheReservedSKUAreCorrect(string FirstReservedSKU, string SecondReservedSKU, string ThirdReservedSku)
        {
            BCOutboundPage6.IVerifyTheReservedSKUAreCorrect(FirstReservedSKU, SecondReservedSKU, ThirdReservedSku);
        }
        [Given(@"I complete book back '(.*)' times")]
        public void GivenICompleteBookBackSelectedRecords_OrderLineOutbound(int BookBackTimes)
        {
            for (int i = 0; i < BookBackTimes; i++)
            {
                BCOutboundPage4.CompleteBookBackSelectedRecordsOrderLineOutbounds();
                BCOutboundPage4.ClickYesInThePopUpMessagesForCompleteBookBack();
            }
        }
        [Given(@"I enter '(.*)' value on Input Field Filter")]
        public void GivenIEnterValueOnInputFieldFilter(string Filter)
        {
            BCOutboundPage4.EnterValueOnInputFieldFilter(Filter);
        }
        [Given(@"I verify the code '(.*)' of FPFB queue that it is created")]
        public void GivenIVerifyTheCodeOfFPFBQueue(string Code)
        {
            BCOutboundPage6.IVerifyThatFPFBQueueIsCreated(Code);
        }
       
        [Given(@"I select the third row for the third queue")]
        public void GivenISelectTheThirdRowForTheThirdQueue()
        {
            BCOutboundPage6.ISelectTheThirdRowForTheThirdQueue();
        }
        [Given(@"I scroll and validate the multiorder numbers are printed correctly")]
        public void GivenIScrollUntilIGetToPickingLabelNumbers()
        {
            BCOutboundPage6.IScrollUntilIGetToPickingLabelNumbers();
        }
        [Given(@"I Click Setup In MainPage")]
        public void GivenIClickSetupInMainPage()
        {
            BCOutboundPage1.SwitchToMainContentFrame();
            BCOutboundPage1.ClickSetupInMainMenu();
        }
        [Given(@"I Delete Files from Folder")]
        public void GivenIDeleteFilesFromFolder()
        {
            BCOutboundPage1.DeleteFilesFromFolder();
        }

        [Given(@"I Delete Files from Folder (.*)Ward")]
        public void GivenIDeleteFilesFromFolderWard(int p0)
        {
            BCOutboundPage1.DeleteFilesFromFolder4Ward();
        }

        [Given(@"I Delete Files from Folder BaselineThree")]
        public void GivenIDeleteFilesFromFolderBaselineThree()
        {
            BCOutboundPage1.DeleteFilesFromFolderBaselinethree();
        }

        [Given(@"I Delete Files from Folder Nilfisk")]
        public void GivenIDeleteFilesFromFolderNilfisk()
        {
            BCOutboundPage1.DeleteFilesFromFolderNilfisk();
        }


        [Given(@"I Delete Files from Folder STST")]
        public void GivenIDeleteFilesFromFolderSTST()
        {
            BCOutboundPage1.DeleteFilesFromFolderSTST();
        }


        [Given(@"I Select General in Setup")]
        public void GivenISelectGeneralInSetup()
        {
            BCOutboundPage1.SelectGeneralInSetup();
        }
        [Given(@"I select Item")]
        public void GivenISelectItem()
        {
            BCOutboundPage1.SelectItem();
        }
        [Given(@"I click filter button on ITEM List")]
        public void GivenIClickFilterButtonOnITEMList()
        {
            BCOutboundPage1.ClickFilterbuttonOnItemList();
        }
        [Given(@"I click Filter button -> Item List")]
        public void GivenIClickFilterButton_ItemList()
        {
            BCOutboundPage1.ClickAddFilterbuttonOnItemList();
        }
        [Given(@"I select Item in Filter")]
        public void GivenISelectItemInFilter()
        {
            BCOutboundPage1.ClickIteminFilter();
        }
        [Given(@"i search in filter for Item '(.*)'")]
        public void GivenISearchInFilterForItem(string p0)
        {
            BCOutboundPage1.ItemFilter(p0);
        }
        [Given(@"i search in filter for Item '([^']*)' ItemSetup")]
        public void GivenISearchInFilterForItemItemSetup(string p0)
        {
            BCOutboundPage1.ItemFilterIteamCard(p0);
        }

        [Given(@"I Edit Item")]
        public void GivenIEditItem()
        {
            BCOutboundPage1.ClickOnEDITITEM();
        }

        [Given(@"I Click configuration and open detailed configuration")]
        public void GivenIClickConfigurationAndOpenDetailedConfiguration()
        {
            BCOutboundPage1.ClickConfigurationofItem();
        }
        [Given(@"I click more options in configuration details card")]
        public void GivenIClickMoreOptionsInConfigurationDetailsCard()
        {
            BCOutboundPage1.ClickMoreoptionsinItemConfigurationDetail();
        }

        [Given(@"i add a new Barcode in ItemConfigDetails")]
        public void GivenIAddANewBarcodeInItemConfigDetails()
        {
            BCOutboundPage1.AddBarcodeConfigDet();
        }
        [Given(@"I click Close from BarcodeItemConfig to item card")]
        public void GivenIClickCloseFromBarcodeItemConfigToItemCard()
        {
            BCOutboundPage1.ClickCloseOnItemConfigDetail();
        }


        [Given(@"I Click manipulation in ITEM Card")]
        public void GivenIClickManipulationInITEMCard()
        {
            BCOutboundPage1.ClickManipulationOnItemCard();
        }
        [Given(@"I check and change measurment")]
        public void GivenICheckAndChangeMeasurment()
        {
            BCOutboundPage1.CheckValueofMeasurmentAndRepleaceit();
        }

        [Given(@"I check and change Item Group")]
        public void GivenICheckAndChangeItemGroup()
        {
            BCOutboundPage1.CheckValueofItemGroupAndRepleaceit();
        }


        [Given(@"I click OK on Popup in ItemCard")]
        public void GivenIClickOKOnPopupInItemCard()
        {
            BCOutboundPage1.ClickOKonItemCard();
        }
        [Given(@"I read the request message")]
        public void GivenIReadTheRequestMessage()
        {
            BCOutboundPage1.ReadMessagefromWCSTempFolder();
        }

        [Given(@"I read and validate the request message")]
        public void GivenIReadAndValidateTheRequestMessage()
        {
            BCOutboundPage1.ReadMessageandValidatefromWCSTempFolder();
        }

        [Given(@"I read and validate the request message KitchenAid")]
        public void GivenIReadAndValidateTheRequestMessageKitchenAid()
        {
            BCOutboundPage1.ReadMessageandValidatefromWCSTempFolderKitchenAid();
        }


        [Given(@"I read and validate the request message BaselineThree PICKINGQUEUEINFOV004")]
        public void GivenIReadAndValidateTheRequestMessageBaselineThree()
        {
            BCOutboundPage1.ReadMessageandValidatefromWCSTempFolderBaselinethree();
        }

        

        [Given(@"I read and validate the request message Nilfisk WCS041_V02")]
        public void GivenIReadAndValidateTheRequestMessageNilfiskWCS_V()
        {
            BCOutboundPage1.ReadMessageandValidatefromWCSTempFolderNilfisk();
        }


        [Given(@"I read and validate the request message STST HOLDERTRANSFERV003")]
        public void GivenIReadAndValidateTheRequestMessageSTSTWORKFOP()
        {
            BCOutboundPage1.ReadMessageandValidatefromWCSTempFolderSTST();
        }


        [Given(@"I read and validate the request message BaselineThree PICKINGQUEUEINFOV005")]
        public void GivenIReadAndValidateTheRequestMessageBaselineThreePICKINGQUEUEINFOVV()
        {
            BCOutboundPage1.ReadMessageandValidatefromWCSTempFolderBaselinethreeV005();
        }

        [Given(@"I read and validate the request message BaselineThree HOLDERINFORMATIONV004")]
        public void GivenIReadAndValidateTheRequestMessageBaselineThreeHOLDERINFORMATIONV()
        {
            BCOutboundPage1.ReadMessageandValidatefromWCSTempFolderBaselinethreeHolderInfomrationv004();
        }


        [Given(@"I click Outbound in CutOff screen")]
        public void GivenIClickOutboundInCutOffScreen()
        {
            BCOutboundPage6.ClickOutboundInCutOffScreen();
        }

        [Given(@"I click wide layout view in Queue Group list")]
        public void GivenIClickWideLayoutViewInQueueGroupList()
        {
            BCOutboundPage6.ClickWideLayoutViewInQueueGroupList();
        }

        [Given(@"I validate that the Queuegroup is Precubing")]
        public void GivenIValidateThatTheQueuegroupIsPrecubing()
        {
            BCOutboundPage6.ValidateThatTheQueuegroupIsPrecubing();
        }

        [Given(@"I validate Holder Number To on POWER Queue Card")]
        public void GivenIValidateHolderNumberToOnPOWERQueueCard()
        {
            BCOutboundPage6.ValidateHolderNumberToOnPOWERQueueCard();
        }


        [Given(@"I click three dots in Destination Code in Ooutbound")]
        public void GivenIClickThreeDotsInDestinationCodeInOoutbound()
        {
            BCOutboundPage6.ThreeDontsInDestinationCodeInOoutbound();
        }

        [Given(@"I copy the Value of No from Outbound table")]
        public void GivenICopyTheValueOfNoFromOutboundTable()
        {
            BCOutboundPage4.CopyTheValueOfNoFromOutboundTable();
        }


        [Given(@"I enter queue number copied value on POWER Tour Building Logivation")]
        public void GivenIEnterQueueNumberCopiedValueOnPOWERTourBuildingLogivation()
        {
            BCOutboundPage4.EnterQueueNumberCopiedValueOnPOWERTourBuildingLogivation();

            BCOutboundPage4.ChoseLocationTourBuilding();
        }

        [Given(@"i save csv file")]
        public void GivenISaveCsvFile()
        {
            BCOutboundPage4.SaveCsvFile();
            System.Threading.Thread.Sleep(2000);
        }


        [Given(@"I create cvs file automation")]
        public void GivenICreateCvsFileAutomation()
        {
            BCOutboundPage4.CreateCvsFileAutomation();
            System.Threading.Thread.Sleep(2000);
        }

        [Given(@"I select alredy created cvs file")]
        public void GivenISelectAlredyCreatedCvsFile()
        {
            BCOutboundPage4.SelectAlredyCreatedCvsFile();
        }

        [Given(@"I create CSV File Tomce")]
        public void GivenICreateCSVFileTomce()
        {
            BCOutboundPage4.CreateCSVFileTomce();
        }




        [Given(@"I click Actions and TourBuilding -> QueueGroupList")]
        public void GivenIClickActionsAndTourBuilding_QueueGroupList()
        {
            BCOutboundPage5.ClickActionsAndTourBuilding_QueueGroupList();
        }

        [Given(@"I click Import Picking tours and multiorders")]
        public void GivenIClickImportPickingToursAndMultiorders()
        {
            BCOutboundPage5.GivenIClickImportPickingToursAndMultiorders();
        }

        [Given(@"I click filter in POWER TourBuilding Logivation")]
        public void GivenIClickFilterInPOWERTourBuildingLogivation()
        {
            BCOutboundPage5.ClickFilterInPOWERTourBuildingLogivation();
        }

        [Given(@"I write '(.*)' on the POWTourBuilding Logivation Card")]
        public void GivenIWriteOnThePOWTourBuildingLogivationCard(string p0)
        {
            BCOutboundPage5.WriteOnThePOWTourBuildingLogivationCard(p0);
        }

    }
}
