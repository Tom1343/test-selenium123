using CGI_OUTBOUND_BC_Scenarios.OUTBOUND.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace CGI_OUTBOUND_BC_Scenarios.OUTBOUND.Steps
{
    [Binding]
    public class BCOutboundSteps5
    {
        public IWebDriver Driver;

        public BCOutboundSteps5(IWebDriver driver) => Driver = driver;

        private BCOutboundPage1 BCOutboundPage1 => new BCOutboundPage1(Driver);
        private BCOutboundPage2 BCOutboundPage2 => new BCOutboundPage2(Driver);
        private BCOutboundPage3 BCOutboundPage3 => new BCOutboundPage3(Driver);
        private BCOutboundPage4 BCOutboundPage4 => new BCOutboundPage4(Driver);
        private BCOutboundPage5 BCOutboundPage5 => new BCOutboundPage5(Driver);
        private BCOutboundPage6 BCOutboundPage6 => new BCOutboundPage6(Driver);
        private BCOutboundPage7 BCOutboundPage7 => new BCOutboundPage7(Driver);

        [Given(@"I click Book Back selected records on Opened Card -> QueueGroupList")]
        public void GivenIClickBookBackSelectedRecordsOnOpenedCard_QueueGroupList()
        {
            BCOutboundPage6.ClickBookBackSelectedRecordsOnOpenedCard_QueueGroupList();
        }

        [Given(@"I clear filter Outbound")]
        public void GivenIClearFilterOutbound()
        {
            BCOutboundPage6.ClearFilterOutbound();
        }

        [Given(@"I clear filter in status outbound order")]
        public void GivenIClearFilterInStatusOutboundOrder()
        {
            BCOutboundPage6.ClearFilterInStatusOutboundOrder();
        }

        [Given(@"I enter TRO '(.*)' value on Input Field Filter -> QueueGroupList")]
        public void GivenIEnterTROValueOnInputFieldFilter_QueueGroupList(string p0)
        {
            BCOutboundPage6.EnterTROValueOnInputFieldFilterQueueGroupList(p0);
        }

        [Given(@"I click Yes in the pop up message -> Outbound")]
        [When(@"I click Yes in the pop up message -> Outbound")]
        [Then(@"I click Yes in the pop up message -> Outbound")]
        public void GivenIClickYesInThePopUpMessage_Outbound()
        {
            BCOutboundPage6.ClickYesInThePopUpMessageOutbound();
        }

        [Given(@"I click cancel to cancel the unlinking")]
        [When(@"I click cancel to cancel the unlinking")]
        [Then(@"I click cancel to cancel the unlinking")]
        public void GivenIClickCancelToCancelTheUnlinking()
        {
            BCOutboundPage6.ClickCancelToCancelTheUnlinkings();
        }

        [Given(@"I click on no stock option to unlink")]
        [When(@"I click on no stock option to unlink")]
        [Then(@"I click on no stock option to unlink")]
        public void GivenIClickOnNoStockOptionToUnlink()
        {
            BCOutboundPage6.ClickNoStockOptionToUnlink();
        }

        [Given(@"I click on the OK button in the Packlist being printed Window")]
        public void GivenIClickOnTheOKButtonInThePacklistBeingPrintedWindow()
        {
            System.Threading.Thread.Sleep(3000);

            BCOutboundPage1.SwitchToDefaultFrame();
            System.Threading.Thread.Sleep(300);
            BCOutboundPage1.SwitchToMainContentFrame();
            BCOutboundPage6.PackListBeingPrinterOKButton();
        }


        [Given(@"I select '(.*)' Code in Picking Route")]
        public void GivenISelectCodeInPickingRoute(string p0)
        {
            BCOutboundPage7.ISelectCodeInPickingRoute(p0);
        }

        [Given(@"I select '(.*)' Code -> Picking Route")]
        public void GivenISelectCode_PickingRoute(string p0)
        {
            BCOutboundPage7.ISelectCodePickingRoute(p0);
        }


        [Given(@"I Book Back selected records")]
        public void GivenIBookBackSelectedRecords()
        {
            BCOutboundPage6.BookBackSelectedRecords();
        }

        [Given(@"I enter Date to load '(.*)' on Outbound")]
        public void GivenIEnterDateToLoadOnOutbound(string DateToLoad)
        {
            BCOutboundPage3.EnterDateToLoadOutbounds(DateToLoad);
        }

        [Given(@"I click More Options on Holder Stock Selection")]
        public void GivenIClickMoreOptionsOnHolderStockSelection()
        {
            BCOutboundPage6.ClickMoreOptionsOnHolderStockSelection();
        }

        [Given(@"I Click Actions -> Outbound")]
        public void GivenIClickActions_Outbound()
        {
            BCOutboundPage6.IClickActionsOutbound();
        }

        [Given(@"I click Holder dropdown")]
        public void GivenIClickHolderDropdown()
        {
            BCOutboundPage6.ClickHolderDropdown();
        }

        [Given(@"I save my created Holder -> Outbound")]
        public void GivenISaveMyCreatedHolder_Outbound()
        {
            BCOutboundPage6.SaveMyCreatedHolderOutbound();
        }

        [Given(@"I click Print Empty Label -> Outbound")]
        public void GivenIClickPrintEmptyLabel_Outbound()
        {
            BCOutboundPage6.ClickPrintEmptyLabelOutbound();
        }



        [Given(@"I click Nas Simulator -> KTN Scheduler from Setup Main Menu")]
        public void GivenIClickNasSimulator_KTNSchedulerFromSetupMainMenu()
        {
            BCOutboundPage6.ClickNasSimulatorFromKTNSchedulerSetup();
        }

        [Given(@"I enter '(.*)' on search button -> Nas Simulator")]
        public void GivenIEnterOnSearchButton_NasSimulator(string searchElement)
        {
            BCOutboundPage6.EnterSearchNasSimulator(searchElement);
        }

        [Given(@"I save my created Pick Holder -> Outbound")]
        public void GivenISaveMyCreatedPickHolder_Outbound()
        {
            BCOutboundPage6.SaveMyCreatedPickHolderOutbound();
        }


        [Given(@"I go back -> Power Holder Type List")]
        public void GivenIGoBack_PowerHolderTypeList()
        {
            BCOutboundPage6.GoBackToPowerHolderTypeList();
        }

        [Given(@"I go back -> Power Holder Stock Selection")]
        public void GivenIGoBack_PowerHolderStockSelection()
        {
            BCOutboundPage6.GoBackToPowerHolderStockSelection();
        }

        [Given(@"I Enter a unique Trailer Plate No for TRO")]
        public void GivenIEnterAUniqueTrailerPlateNoForTRO()
        {
            BCOutboundPage6.IEnterTrailerPlateNo();
        }



        [Given(@"I add filter '(.*)' for EDI Message Log List -> Outbound")]
        public void GivenIAddFilterForEDIMessageLogList_Outbound(string filterEDI)
        {
            BCOutboundPage6.AddFilterForEDIMessagesLogList(filterEDI);

        }

        [Given(@"I enter '(.*)' as a subfilter -> Outbound")]
        public void GivenIEnterAsASubfilter_Outbound(string subfilter)
        {
            BCOutboundPage6.EnterSubfilters(subfilter);

        }

        [Given(@"I click filter button on EDI message log list -> Outbound")]
        public void GivenIClickFilterButtonOnEDIMessageLogList_Outbound()
        {
            BCOutboundPage6.ClickFilterInButtonOnEDIMessageLogList();

        }

        [Given(@"I add second filter '(.*)' for EDI Message Log List -> Outbound")]
        public void GivenIAddSecondFilterForEDIMessageLogList_Outbound(string secondFilter)
        {
            BCOutboundPage6.AddSecondFilterInEDIMessageLogList(secondFilter);

        }

        [Given(@"I add third filter '(.*)' for EDI Message Log List -> Outbound")]
        public void GivenIAddThirdFilterForEDIMessageLogList_Outbound(string thirdFilter)
        {
            BCOutboundPage7.AddThirdFilterForEDIMessageLogList(thirdFilter);

        }

        [Given(@"I enter '(.*)' as a third subfilter -> Outbound")]
        public void GivenIEnterAsAThirdSubfilter_Outbound(string thirdSubFilter)
        {
            BCOutboundPage7.AddThirdSubFilterForEDIMessageLogList(thirdSubFilter);

        }



        [Given(@"I click the dropdown menu from filter pane in EDI Message Log List -> Outbound")]
        public void GivenIClickTheDropdownMenuFromFilterPaneInEDIMessageLogList_Outbound()
        {
            BCOutboundPage7.ClickTheDropDownMenuFromFilterPaneInEDIMessageLogList();

        }

        [Given(@"I click Inserted from the Filter dropdown menu -> Outbound")]
        public void GivenIClickInsertedFromTheFilterDropdownMenu_Outbound()
        {
            BCOutboundPage7.ClickInsertedFromTheFilterDropDownMenu();

        }

        [Given(@"I click '(.*)' from the Filter dropdown menu -> Outbound")]
        public void GivenIClickFromTheFilterDropdownMenu_Outbound(string filterDropdown)
        {
            BCOutboundPage7.ClickFromTheFilterDropDownMenu(filterDropdown);

        }

        [Given(@"I click Edit from the navigation bar -> Outbound")]
        public void GivenIClickEditFromTheNavigationBar_Outbound()
        {
            BCOutboundPage7.ClickEditFromTheNavigationbar();

        }
        [Given(@"I click on holder in PickHolders Tab in Outbound Card")]
        public void GivenIClickOnHolderInPickHoldersTabInOutboundCard()
        {
            BCOutboundPage7.ClickonHolderinOutboundCard();
        }
        [Given(@"i click Print MDGF message")]
        public void GivenIClickPrintMDGFMessage()
        {
            BCOutboundPage7.ClickPrintMDGF();
        }

        [Given(@"i change the URL by going to POWPrintDocumentLog")]
        public void GivenIChangeTheURLByGoingToPOWPrintDocumentLog()
        {
            BCOutboundPage7.ChangeURLtoPOWPrintDocumentLog();
        }


        [Given(@"I click Interface without switching content frame")]
        public void GivenIClickInterfaceWithoutSwitchingContentFrame()
        {
            BCOutboundPage7.ClickInterfaceFromMainMenu();
        }

        [Given(@"I click Batch Wave Need")]
        public void GivenIClickBatchWaveNeed()
        {
            BCOutboundPage1.IClickBatchWavesNeed();
        }

        [Given(@"I click Show filter Pane")]
        public void GivenIClickShowFilterPane()
        {
            BCOutboundPage1.IClickShowFilterPanels();
        }

        [Given(@"I click on full screen button in queue group")]
        public void GivenIClickFullScreenQueueGroup()
        {
            BCOutboundPage1.IClickFullScreenQueueGroup();
        }

        [Given(@"I click on Error dropdown to change")]
        public void GivenIClickOnErrorDropdownToChange()
        {
            BCOutboundPage1.IClickOnErrorDropdownToChange();
        }

        [Given(@"I click on Error li")]
        public void GivenIClickOnErrorLi()
        {
            BCOutboundPage1.IClickOnErrorsLi();
        }

        [Given(@"I click on Not processed li")]
        public void GivenIClickOnNotProcessedLi()
        {
            BCOutboundPage1.IClickOnNotProcessedsLi();
        }

        [Given(@"I click Interface Table from Interface")]
        public void GivenIClickInterfaceTableFromInterface()
        {
            BCOutboundPage7.ClickInterfaceTableInInterface();
        }

        [Given(@"I validate Interface Line")]
        public void GivenIValidateInterfaceLine()
        {
            BCOutboundPage7.ValidateWCSLineInInterfaceTable();
        }
        [Given(@"I validate VAC values")]
        public void GivenIValidateVACValues()
        {
            BCOutboundPage7.ValidateVacValues();
        }


        [Given(@"I enter a value to search on PowerInterface List")]
        public void GivenIEnterAValueToSearchOnPowerInterfaceList()
        {
            BCOutboundPage7.EnterValueSearchPOWInterfaceLine();
        }

        [Given(@"I click Run Interface for this record on POWER Interface List")]
        public void GivenIClickRunInterfaceForThisRecordOnPOWERInterfaceList()
        {
            BCOutboundPage7.ClickRunInterfaceLinePoWInterfaceList();
        }

        [Given(@"I click Origing/Destination on TRO card")]
        public void GivenIClickOrigingDestinationOnTROCard()
        {
            BCOutboundPage7.ClickOriginInDestTROCard();
        }

        [Given(@"I enter Loading Location '(.*)' on Origin/Destination -> TRO card")]
        public void GivenIEnterLoadingLocationOnOriginDestination_TROCard(string loadingLocation)
        {
            BCOutboundPage7.EnterLoadingLocationOriginDestTROCard(loadingLocation);
        }

        [Given(@"I click to filter Code '(.*)' without entering date on QueueGroupList")]
        public void GivenIClickToFilterCodeWithoutEnteringDateOnQueueGroupList(string Code)
        {
            BCOutboundPage7.EnterFilterWithoutDateOnQueueGroupList();
            BCOutboundPage7.EnterCodeFilterQueueGrouplist(Code);
        }


        [Given(@"I click on the Code field without filter")]
        public void GivenIClickOnTheCodeFieldWithoutFilter()

        {
            BCOutboundPage7.ClickCodeFieldWithoutFilter();
        }

        [Given(@"I enter Date to deliver on Outbound")]
        public void GivenIEnterDateToDeliverOnOutbound()
        {
            BCOutboundPage7.EnterDateToDeliverInOutbound();
        }

        [Given(@"I enter Date to deliver on Outbound plus '(.*)' days")]
        public void GivenIEnterDateToDeliverOnOutboundPlusDays(double p0)
        {
            BCOutboundPage7.EnterDateToDeliverOnOutboundPlusDays(p0);
        }

        [Given(@"I enter Date to load plus '(.*)' days")]
        public void GivenIEnterDateToLoadPlusDays(double p0)
        {
            BCOutboundPage7.EnterDateToLoadPlusDays(p0);
        }


        [Given(@"I Book All in Order Manage -> Outbound")]
        public void GivenIBookAllInOrderManage_Outbound()
        {
            BCOutboundPage7.BookAllInOrderManageOutbound();
        }

        [Given(@"I Cut Off in Order Manage -> Outbound")]
        public void GivenICutOffInOrderManage_Outbound()
        {
            BCOutboundPage7.CutOffInOrderManageOutbound();
        }

        [Given(@"I enter copied outbound on search button -> Nas Simulator")]
        public void GivenIEnterCopiedOutboundOnSearchButton_NasSimulator()
        {
            BCOutboundPage7.EnterCopiedOutboundSearchNasSimulator();
        }

        [Given(@"I enter copied outbounds on search button -> Nas Simulator")]
        public void GivenIEnterCopiedOutboundsOnSearchButton_NasSimulator()
        {
            BCOutboundPage7.EnterCopiedOutboundsSearchNasSimulator();
        }
        [Given(@"I enter '(.*)' Code on Outbound -> queue groups")]
        public void GivenIEnterCodeOnOutboundInQueueGroups(string OutboundCode)
        {
            BCOutboundPage7.EnterCodeOnOutboundInQueueGroups(OutboundCode);
        }
        [Given(@"I should see a popup message '(.*)' and click Yes")]
        [When(@"I should see a popup message '(.*)' and click Yes")]
        [Then(@"I should see a popup message '(.*)' and click Yes")]
        public void GivenIShouldGetSeeAPopupMessageAndClickYes(string PopupMessage)
        {
            BCOutboundPage6.VerifyIGetPopupMessageAndClickYes(PopupMessage);
            BCOutboundPage6.ClickYesInThePopUpMessageOutbound();
        }
        [Given(@"I should see one more popup message '(.*)' and click Yes")]
        public void GivenIShouldGetSeeOneMorePopupMessageAndClickYes(string PopupMessage)
        {
            BCOutboundPage6.VerifyIGetOneMorePopupMessageAndClickYes(PopupMessage);
            BCOutboundPage6.ClickYesInThePopUpMessageOutbound();
        }
        [Given(@"I should get status of the queue '(.*)' -> QueueGroupCard")]
        [When(@"I should get status of the queue '(.*)' -> QueueGroupCard")]
        [Then(@"I should get status of the queue '(.*)' -> QueueGroupCard")]
        public void GivenIShouldGetStatusOfTheQueue(string StatusOfQueue)
        {
            BCOutboundPage6.IShouldGetStatusOfTheQueue(StatusOfQueue);
        }
        [Given(@"I click Manipulation in main menu")]
        public void GivenIClickManipulationInMainMenu()
        {
            BCOutboundPage1.SwitchToMainContentFrame();
            BCOutboundPage7.ClickManipulationfromMainMenu();
        }
        [Given(@"I click LB(.*)SD Detail")]
        public void GivenIClickLBSDDetail(int p0)
        {
            BCOutboundPage7.ClickLB2SDDetails();
        }
        [Given(@"I click on Select Stock")]
        public void GivenIClickOnSelectStock()
        {
            BCOutboundPage7.CheckandDeleteLines();
            BCOutboundPage7.SelectStockButton();
        }
        [Given(@"I scan a holder barcode '(.*)'")]
        public void GivenIScanAHolderBarcode(string holderbarcode)
        {
            BCOutboundPage7.ScanHolderinLBSD(holderbarcode);
        }
        [Given(@"I add \# sku to transfer '(.*)'")]
        public void GivenIAddSkuToTransfer(string p0)
        {
            BCOutboundPage7.AddSKUinLB2SD(p0);
        }
        [Given(@"I add J Transfer '(.*)'")]
        public void GivenIAddJTransfer(string p0)
        {
            BCOutboundPage7.AddJTransfer(p0);
        }
        [Given(@"I add J Comment '(.*)'")]
        public void GivenIAddJComment(string p0)
        {
            BCOutboundPage7.AddJComment(p0);
        }

        [Given(@"I add J new location '(.*)'")]
        public void GivenIAddJNewLocation(string p0)
        {
            BCOutboundPage7.AddJnewLocation(p0);
        }
        [Given(@"I Book all in Manipulation details")]
        public void GivenIBookAllInManipulationDetails()
        {
            BCOutboundPage7.ClickBookAllinManipulationDetails();
        }
        [Given(@"I Click manage in Manipulation Detail and delete the line")]
        public void GivenIClickManageInManipulationDetailAndDeleteTheLine()
        {

            BCOutboundPage7.ClickManageandDeleteLine();
        }
        [Given(@"I Book all Lines in Manipulation details LB(.*)SD")]
        public void GivenIBookAllLinesInManipulationDetailsLBSD(int p0)
        {
            BCOutboundPage7.BoookALLInExpected();
        }
        [Given(@"I Click LB(.*)SD Header")]
        public void GivenIClickLBSDHeader(int p0)
        {
            BCOutboundPage7.ClickLB2SDHeader();
        }
       
    }
}

