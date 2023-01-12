using CGI_OUTBOUND_BC_Scenarios.OUTBOUND.Pages;
using CGI_OUTBOUND_BC_Scenarios.Utilities;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace CGI_OUTBOUND_BC_Scenarios.OUTBOUND.Steps
{
    [Binding]
    public class BCOutboundSteps1
    {
        public IWebDriver Driver;
        private BCOutboundPage1 BCOutboundPage1 => new BCOutboundPage1(Driver);
        private BCOutboundPage2 BCOutboundPage2 => new BCOutboundPage2(Driver);
        private BCOutboundPage3 BCOutboundPage3 => new BCOutboundPage3(Driver);
        private BCOutboundPage4 BCOutboundPage4 => new BCOutboundPage4(Driver);
        private BCOutboundPage5 BCOutboundPage5 => new BCOutboundPage5(Driver);
        private BCOutboundPage6 BCOutboundPage6 => new BCOutboundPage6(Driver);
        private BCOutboundPage7 BCOutboundPage7 => new BCOutboundPage7(Driver);
        public WaitMethods WaitMethods => new WaitMethods(Driver);
        public BCOutboundSteps1(IWebDriver driver) => Driver = driver;


        [Given(@"I am on the BASELINE database for Outbound")]
        public void GivenIAmOnTheBASELINEDatabaseForOutbound()
        {
            BCOutboundPage1.NavigateToNavNext();
        }

        [Given(@"I am on the MADEFUR database for Outbound")]
        public void GivenIamOnTheMADEFURDatabaseForOutbound()
        {
            BCOutboundPage1.NavigateToNavNextMadefur();
        }

        [Given(@"I am on the ADEO database for Outbound")]
        public void GivenIamOnTheADEODatabaseForOutbound()
        {
            BCOutboundPage1.NavigateToNavNextAdeo();
        }

        [Given(@"I am on the BaselineTwo database for Outbound")]
        public void GivenIAmOnTheBaselineTwoDatabaseForInbound()
        {
            BCOutboundPage1.NavigateToNavNextBaselineTwo();
            WaitMethods.WaitForMainPageToBeReady()
                    .WaitForElementToAppear(By.XPath("//iframe[@title='Main Content']"));
        }

        [Given(@"I am on the KitchenAid database for Outbound")]
        public void GivenIAmOnTheKitchenAidDatabaseForOutbound()
        {
            BCOutboundPage1.NavigateToNavNextKitchenAid();
            WaitMethods.WaitForMainPageToBeReady()
                    .WaitForElementToAppear(By.XPath("//iframe[@title='Main Content']"));
        }

        [Given(@"I am on the STST database for Outbound")]
        public void GivenIAmOnTheSTSTDatabaseForOutbound()
        {
            BCOutboundPage1.NavigateToNavNextSTST();
            WaitMethods.WaitForMainPageToBeReady()
                    .WaitForElementToAppear(By.XPath("//iframe[@title='Main Content']"));
        }



        [Given(@"I am on the BaselineThree database for Outbound")]
        public void GivenIAmOnTheBaselineThreeDatabaseForOutbound()
        {
            BCOutboundPage1.NavigateToNavNextBaselinethree();
            WaitMethods.WaitForMainPageToBeReady()
                    .WaitForElementToAppear(By.XPath("//iframe[@title='Main Content']"));
        }



        [Given(@"I am on the Nilfisk database for Outbound")]
        public void GivenIAmOnTheNilfiskDatabaseForOutbound()
        {
            BCOutboundPage1.NavigatetoNavNextNilfisk();
            WaitMethods.WaitForMainPageToBeReady()
                    .WaitForElementToAppear(By.XPath("//iframe[@title='Main Content']"));
        }

        [Given(@"I add filter '(.*)' for EDI Message Log Sending")]
        public void GivenIAddFilterForEDIMessageLogSending(string p0)
        {
            BCOutboundPage1.FilterForEdiMessageLogSeinding(p0);
        }
        [Given(@"i validate the date of PPLCON Pack Message")]
        public void GivenIValidateTheDateOfPPLCONPackMessage()
        {
            System.Threading.Thread.Sleep(1000);
            string TimeNowPPLCON = Driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/main/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[1]/div/div[2]/table/tbody/tr[1]/td[8]/span")).Text;
            Assert.Equal(DateTime.Now.ToString("d/MM/yyyy"), TimeNowPPLCON);
        }


        [Given(@"I add filter with copied Oubound card")]
        public void GivenIAddFilterWithCopiedOuboundCard()
        {
            BCOutboundPage1.AddFilterOutboundCard();
        }


        [Given(@"I click Outbound from Main Page")]
        [When(@"I click Outbound from Main Page")]
        [Then(@"I click Outbound from Main Page")]
        public void GivenIClickOutboundFromMainPage()
        {
            BCOutboundPage1.SwitchToMainContentFrame()
                    .ClickOutboundMainMenu();
        }

        [Given(@"I click Outbound from Main Page in ADEO ZC")]
        [When(@"I click Outbound from Main Page in ADEO ZC")]
        [Then(@"I click Outbound from Main Page in ADEO ZC")]
        public void GivenIClickOutboundFromMainPageInAdeoZC()
        {
            BCOutboundPage1.SwitchToMainContentFrame()
                    .ClickOutboundMainMenuInAdeoZC();
        }

        [Given(@"I click Outbound from Main Page - Madefur")]
        [When(@"I click Outbound from Main Page - Madefur")]
        [Then(@"I click Outbound from Main Page - Madefur")]
        public void GivenIClickOutboundFromMainPageMadefur()
        {
            BCOutboundPage1.ClickOutboundMainMenu();
        }

        [Given(@"I click Interface in Main Menu")]
        [When(@"I click Interface in Main Menu")]
        [Then(@"I click Interface in Main Menu")]
        public void GivenIClickInterfaceInMainMenu()
        {
            BCOutboundPage1.SwitchToMainContentFrame()
                .ClickInterfaceButtonMainMenu();
        }


        [Given(@"I click Outbound from Main Page in BC")]
        public void GivenIClickOutboundFromMainPageInBC()
        {
            BCOutboundPage1.SwitchToMainContentFrame()
                    .ClickOutboundMainMenuinBC();
        }


        [Given(@"I click Outbound from Main Page without switching frames")]
        [When(@"I click Outbound from Main Page without switching frames")]
        [Then(@"I click Outbound from Main Page without switching frames")]
        public void GivenIClickOutboundFromMainPageWithoutSwitchingFrames()
        {
            BCOutboundPage1.ClickOutboundWithoutSwitchingFrames();
        }

        [Given(@"I switch to default content frame")]
        [When(@"I switch to default content frame")]
        [Then(@"I switch to default content frame")]
        public void GivenISwitchToDefaultContentFrame()
        {
            BCOutboundPage1.SwitchToDefaultFrame();
        }

        [Given(@"I switch to Main Page")]
        public void GivenISwitchToMainPage()
        {
            BCOutboundPage1.SwitchToMainContentFrame();
        }

        [Given(@"I click Packing from Main Page")]
        public void GivenIClickPackingFromMainPage()
        {
            BCOutboundPage1.SwitchToMainContentFrame()
                    .ClickPackingFromMainPage();
        }

        [Given(@"I scan Pack-Table ID '(.*)'")]
        public void GivenIScanPack_TableID(string p0)
        {
            BCOutboundPage1.IScanPackTableID(p0);
        }

        [Given(@"I write Holder/Location '(.*)'")]
        [When(@"I write Holder/Location '(.*)'")]
        public void GivenIWriteHolderLocation(string p0)
        {
            BCOutboundPage1.SwitchToMainContentFrame()
                    .WriteHolderLocation(p0);
        }

        [Given(@"I write qty '(.*)' of the item")]
        [When(@"I write qty '(.*)' of the item")]
        public void GivenIWriteQtyOfTheItem(string p0)
        {
            BCOutboundPage1.SwitchToMainContentFrame()
                    .WriteQtyOfTheItem(p0);
        }

        [Given(@"I click on yes button in packing")]
        [When(@"I click on yes button in packing")]
        public void GivenIClickOnYesButtonInPacking()
        {
            BCOutboundPage1.SwitchToMainContentFrame()
                    .ClickYesButtonInPacking();
        }

        [Given, When(@"I click on Error pick button")]
        public void GivenIClickOnErrorPickButton()
        {
            BCOutboundPage1.ClickErrorPickButton();
        }

        [Given, When(@"I click OK button")]
        public void GivenIClickOKButton()
        {
            BCOutboundPage1.ClickOKButton();
        }

        [Given, When(@"I close the packing page")]
        public void GivenICloseThePackingPage()
        {
            BCOutboundPage1.SwitchToDefaultFrame()
                    .SwitchToMainContentFrame()
                    .CloseThePackingPage();
        }

        [Given, When(@"I go to Setup from main page -> Logging -> Picking Error Log")]
        public void GivenIGoToPickingErrorLogFromMainPage()
        {
            BCOutboundPage1.ClickSetupFromMainPage()
                    .ClickLogging()
                    .ClickPickingErrorLog();
        }

        [Given, When, Then(@"I delete the picking log error")]
        public void GivenIDeleteThePickingLogError()
        {
            BCOutboundPage1.DeleteThePickingLogError();
        }

        [Given, When(@"I switch to POWRFLogPickingError frame")]
        public void GivenISwitchToPOWRFLogPickingErrorFrame()
        {
            BCOutboundPage1.SwitchToPOWRFLogPickingErrorFrame();
        }

        [Given(@"i click yes -> Pack")]
        public void GivenIClickYes_Pack()
        {
            BCOutboundPage1.ClickYesPack();
        }

        [Given, When(@"I click full screen button in packing")]
        public void GivenIClickFullScreenButtonInPacking()
        {
            BCOutboundPage1.ClickFullScreenButtonInPacking();
        }

        [Given(@"I write Weight '(.*)'"), When(@"I write Weight '(.*)'"), Then(@"I write Weight '(.*)'")]
        public void GivenIWriteWeight(string p0)
        {
            

            BCOutboundPage1.WriteWeight(p0);
            //BCOutboundPage1.SwitchToMainContentFrame();
        }

        [Given(@"I click Yes in the pop up message In Packing")]
        public void GivenIClickYesInThePopUpMessageInPacking()
        {
            
                BCOutboundPage1.ClickYesInPacking();
        }

        [Given(@"I close packing module")]
        public void GivenIClosePackingModule()
        {
            BCOutboundPage1.ClickClosePackingModule();

        }

        [Given(@"I go back one window with ESC")]
        public void GivenIGoBackOneWindowWithESC()
        {
            BCOutboundPage1.GoBackOneWindowWithESC();

        }



        [Given(@"I click Expected on Inbound Delivery")]
        public void GivenIClickExpectedOnInboundDelivery()
        {
            BCOutboundPage1.ClickExpectedInboundDelivery();

        }

        [Given(@"I type Supplier code '(.*)' on Inbound Delivery")]
        public void GivenITypeSupplierCodeOnInboundDelivery(string supplierCode)
        {
            BCOutboundPage1.TypeSupplierCodeOnInboundsDelivery(supplierCode);
        }
        [Given(@"I click Manage from Expected")]
        public void GivenIClickManageFromExpected()
        {
            BCOutboundPage1.ClickManagesFromExpected();
        }

        [Given(@"I click General of the Setup nav menu")]
        public void GivenIClickGeneralOfTheSetupNavMenu()
        {
            BCOutboundPage1.ClickGeneralOfTheSetupNavMenu();
        }
        [Given(@"I Book All in Expected on TRI")]
        public void GivenIBookAllInExpectedOnTRI()
        {
            BCOutboundPage1.BookAllFromExpectedTRI();
        }
        [Given(@"I click Book All in In Stock \(Master\)")]
        public void GivenIClickBookAllInInStockMaster()
        {
            BCOutboundPage1.ClickBookAllInInStockMasters();
        }

        [Given(@"I click In stock from In Stock \(Master\)")]
        public void GivenIClickInStockFromInStockMaster()
        {
            BCOutboundPage1.ClickInStockFromInStockMasters();
        }
        [Given(@"I click Book Back in In Stock \(Master\)")]
        public void GivenIClickBookBackInInStockMaster()
        {
            BCOutboundPage1.BookBackInInStockMaster();
        }


        [Given(@"I enter the Holder Unit '(.*)'")]
        public void GivenIEnterTheHolderUnit(string p0)
        {
            BCOutboundPage1.SwitchToDefaultFrame();

            BCOutboundPage1.SwitchToMainContentFrame();

            IWebElement iframe = Driver.FindElement(By.XPath("//iframe[@title='POWERPackingMeasurements']"));
            Driver.SwitchTo().Frame(iframe);

            BCOutboundPage1.EnterHolderUnit(p0);
        }
        [Given(@"I click on the OK button in the Change Dimensions Window")]
        public void GivenIClickOnTheOKButtonInTheChangeDimensionsWindow()
        {

            BCOutboundPage1.SwitchToDefaultFrame();

            BCOutboundPage1.SwitchToMainContentFrame();



            IWebElement iframe = Driver.FindElement(By.XPath("//iframe[@title='POWERPackingMeasurements']"));
            Driver.SwitchTo().Frame(iframe);



            BCOutboundPage1.ChangeDimensionsOkButton();
        }




        [Given(@"Control quality scans value is '(.*)'")] [Then(@"Control quality scans value is '(.*)'")]
        public void ThenControlQualityScansValueIs(int p0)
        {
            BCOutboundPage1.SwitchToMainContentFrame()
                .VerifyControlQualityScan(p0);
        }

        [Given(@"I click Close Btn two times -> Outbound Btn")]
        [When(@"I click Close Btn two times -> Outbound Btn")]
        [Then(@"I click Close Btn two times -> Outbound Btn")]
        public void GivenIClickCloseBtnTwoTimes_OutboundBtn()
        {
            BCOutboundPage1.SwitchToDefaultFrame()
                    .SwitchToMainContentFrame()
                    .ClickCloseBtnOutboundsBtnTwoTImes();
        }
        [Given(@"I write Packing Location '([^']*)'")]
        public void GivenIWritePackingLocation(string p0)
        {
            BCOutboundPage1.WritePackingLocation(p0);
        }


        [Given(@"I click close BTN once in Packing")]
        [When(@"I click close BTN once in Packing")]
        [Then(@"I click close BTN once in Packing")]
        public void GivenIClickCloseBTNOnce()
        {
            BCOutboundPage1.SwitchToDefaultFrame()
                    .SwitchToMainContentFrame()
                    .ClickCloseButtonOncePacking();
        }

        [Given(@"I click on Close on Packing")]
        public void GivenIClickOnCloseOnPacking()
        {
            BCOutboundPage1.ClickClosePackingModule();
        }


        [Given(@"I should get POWER PACKING MODULE ERROR '(.*)' -> Outbound"), When(@"I should get POWER PACKING MODULE ERROR '(.*)' -> Outbound"), Then(@"I should get POWER PACKING MODULE ERROR '(.*)' -> Outbound")]
        public void GivenIShouldGetPOWERPACKINGMODULEERROR_Outbound(string p0)
        {
            BCOutboundPage1.SwitchToMainContentFrame();
            IWebElement iframe = Driver.FindElement(By.XPath("(//div[@class='task-dialog-content-container thm-cont-g0-bgcolor-1'])[2]//div//div//div[4]//div//iframe"));
            Driver.SwitchTo().Frame(iframe);
            Assert.Contains(p0, BCOutboundPage1.IShouldGetPOWERPACKINGMODULEsERROROutbound);
        }

        [Given(@"I should get POWER pack table error '(.*)'"), When(@"I should get POWER pack table error '(.*)'"), Then(@"I should get POWER pack table error '(.*)'")]
        public void GivenIShouldGetPOWERPACKINGTABLEMODULEERROR_Outbound(string p0)
        {
            BCOutboundPage1.SwitchToMainContentFrame();
            IWebElement iframe = Driver.FindElement(By.XPath("//div[@class='task-dialog-content-alignbox']//div[4]//div//iframe"));
            Driver.SwitchTo().Frame(iframe);
            Assert.Contains(p0, BCOutboundPage1.IShouldGetPOWERPACKINGMODULEsERROROutbound);
        }

        [Given(@"I should get POWER PACKING MODULE NOTIFICATION '(.*)' -> Outbound"), When(@"I should get POWER PACKING MODULE NOTIFICATION '(.*)' -> Outbound"), Then(@"I should get POWER PACKING MODULE NOTIFICATION '(.*)' -> Outbound")]
        public void GivenIShouldGetPOWERPACKINGMODULENOTIFICATION_Outbound(string p0)
        {
            BCOutboundPage1.SwitchToPowerModuleError();
            Assert.Contains(p0, BCOutboundPage1.IShouldGetPOWERPACKINGMODULEsERROROutbound);

        }

        [Given(@"I should get error message '(.*)' -> PACKING"), When(@"I should get error message '(.*)' -> PACKING"), Then(@"I should get error message '(.*)' -> PACKING")]
        public void GivenIShouldGetErrorMessage_PACKING(string p0)
        {
            BCOutboundPage1.SwitchToDefaultFrame()
                    .SwitchToMainContentFrame();
            Assert.Contains(p0, BCOutboundPage1.IShouldGetErrorMessagePACKING);

        }

        [Given(@"I should get error message '(.*)' -> packing notification")]
        public void GivenIShouldGetErrorMessage_PackingNotification(string p0)
        {
            BCOutboundPage1.SwitchToDefaultFrame()
                    .SwitchToMainContentFrame();

            Assert.Contains(p0, BCOutboundPage1.IShouldGetErrorMessagePackingNotifications);
        }

        [Given(@"I should get comment message '(.*)' -> packing notification")]
        public void GivenIShouldGetCommentMessage_PackingNotification(string p0)
        {
            IWebElement iframe2 = Driver.FindElement(By.XPath("//iframe[@class='designer-client-frame']"));
            Driver.SwitchTo().Frame(iframe2);

            IWebElement iframe = Driver.FindElement(By.XPath("(//iframe[@scrolling='no'])[2]"));
            Driver.SwitchTo().Frame(iframe);
            Assert.Contains(p0, BCOutboundPage1.IShouldGetPOWERPACKINGMODULEsComment);
        }

        [Given(@"I should get POWER error message '(.*)' -> POWER packing notification")]
        public void GivenIShouldGetPOWERErrorMessage_POWERPackingNotification(string p0)
        {
            BCOutboundPage1.SwitchToDefaultFrame()
                    .SwitchToMainContentFrame();

            Assert.Contains(p0, BCOutboundPage1.IShouldGetPOWERErrorMessagePOWERPackingNotifications);

        }
        [Given(@"I click Close Btn -> Outbound Btn")]
        [When(@"I click Close Btn -> Outbound Btn")]
        [Then(@"I click Close Btn -> Outbound Btn")]
        public void GivenIClickCloseBtn_OutboundBtn()
        {
            BCOutboundPage1.SwitchToDefaultFrame()
                    .SwitchToMainContentFrame()
                    .ClickCloseBtnOutboundsBtn();
        }

        [Given(@"I write Holder/EAN/SSCC/GS '(.*)'"), When(@"I write Holder/EAN/SSCC/GS '(.*)'")]
        public void GivenIWriteHolderEANSSCCGS(string p0)
        {
            BCOutboundPage1.SwitchToMainContentFrame()
                    .WriteHoldersEANSSCCGS(p0);
        }
        [Given(@"I expand Packing From")]
        public void GivenIExpandPackingFrom()
        {
            BCOutboundPage1.SwitchToMainContentFrame();
            BCOutboundPage1.ExpandPackingForm();
        }

        [Given(@"I write Holder/EAN/SSCC/GS '([^']*)' second time BB")]
        public void GivenIWriteHolderEANSSCCGSSecondTimeBB(string p0)
        {
            BCOutboundPage1.WriteHoldersEANSSCCGS2(p0);
        }

        [Given(@"I click on Close PickHolder button"), When(@"I click on Close PickHolder button")]
        public void GivenIClickOnClosePickholderButton()
        {
            BCOutboundPage1.ClosePickHolderPacking();
        }

        [Given(@"I click on Item Detail button"), When(@"I click on Item Detail button")]
        public void GivenIClickOnItemDetailButton()
        {
            BCOutboundPage1.ClickItemDetailButton();
        }

        [Given(@"I click on Select button"), When(@"I click on Select button")]
        public void GivenIClickONSelectButton()
        {
            BCOutboundPage1.SwitchToMainContentFrame()
                .SwitchFramePowerPackingModuleTempPacking()
                .ClickSelectButtonPacking();
            
        }

        [Given(@"I validate '(.*)' when GS barcode is scanned")]
        public void GivenIValidateWhenGSBarcodeIsScanned(string p0)
        {
            BCOutboundPage1.SwitchToMainContentFrame()
                     .ValidateWhenGSBarcodeIsScanned(p0);
        }


        [Given(@"I write Qty '(.*)'"), When(@"I write Qty '(.*)'")]
        public void GivenIWriteQty(string p0)
        {
            BCOutboundPage1.WriteQty(p0);
        }

        [Given(@"I write '(.*)' for Item/Barcode"), When(@"I write '(.*)' for Item/Barcode")]
        public void GivenIWriteItemForBarcode(string item)
        {
            BCOutboundPage1.IWriteItemForBarcode(item);
        }

        [Given(@"I select '(.*)' from the dropdown"), When(@"I select '(.*)' from the dropdown")]
        public void GivenISelectFromTheDropdown(string p0)
        {
            BCOutboundPage1.ISelectFromTheDropdown(p0);
        }

        [Then(@"I validate the user picked '(.*)' is correct")]
        [Given(@"I validate the user picked '(.*)' is correct"), When(@"I validate the user picked '(.*)' is correct")]
        public void GivenIValidateTheUserPickedIsCorrect(string userPicked)
        {
            BCOutboundPage1.IValidateTheUserPickedIsCorrect(userPicked);
        }

        [Then(@"I validate the status of the batch is '(.*)'")]
        [Given(@"I validate the status of the batch is '(.*)'"), When(@"I validate the status of the batch is '(.*)'")]
        public void GivenIValidateTheStatusOfTheBatch(string statusOfBatch)
        {
            BCOutboundPage1.IValidateTheStatusOfTheBatch(statusOfBatch);
        }

        [Then(@"I verify that the '(.*)' queue is created")]
        [Given(@"I verify that the '(.*)' queue is created"), When(@"I verify that the '(.*)' queue is created")]
        public void GivenIVerifyThatTheHolderRetrievalIsCreated(string holderRetrieval)
        {
            BCOutboundPage1.IVerifyHolderRetrievalIsCreated(holderRetrieval);
        }

        [Then(@"I verify that the pickzone '(.*)' doesn't disappear")]
        [Given(@"I verify that the pickzone '(.*)' doesn't disappear"), When(@"I verify that the pickzone '(.*)' doesn't disappear")]
        public void GivenIVerifyThatThePickzoneDoesntDisappear(string pickzone)
        {
            BCOutboundPage1.IVerifyPickzoneDoesntDisappear(pickzone);
        }

        [Then(@"I verify that the batch number is '(.*)'")]
        [Given(@"I verify that the batch number is '(.*)'"), When(@"I verify that the batch number is '(.*)'")]
        public void GivenIVerifyThatTheBatchNumberIsZero(string batchNumber)
        {
            BCOutboundPage1.IVerifyBatchNumber(batchNumber);
        }

        [Then(@"I validate the priority of the FB retrieval queue is '(.*)'")]
        [Given(@"I validate the priority of the FB retrieval queue is '(.*)'"), When(@"I validate the priority of the FB retrieval queue is '(.*)'")]
        public void GivenIValidateThePriorityOfTheFBRetrievalQueue(string priority)
        {
            BCOutboundPage1.IValidateThePriorityOfTheFBRetrievalQueue(priority);
        }



        [Then(@"I verify that the status of the launched queue is on '(.*)' and new '(.*)' queue is created")]
        [Given(@"I verify that the status of the launched queue is on '(.*)' and new '(.*)' queue is created")]
        [When(@"I verify that the status of the launched queue is on '(.*)' and new '(.*)' queue is created")]
        public void GivenIVerifyThatTheStatusOfTheLaunchedQueueAndQueueCreated(string status, string queue)
        {
            BCOutboundPage1.IVerifyThatTheStatusOfTheLaunchedQueueAndQueueCreated(status, queue);
        }

        [Given(@"I write Holder/EAN/SSCC/GS '(.*)' 4 times"), When(@"I write Holder/EAN/SSCC/GS '(.*)' 4 times")]
        public void GivenIWriteHolderEANSSCCGSFourTimes(string p0)
        {
            for (int i = 0; i < 4; i++)
            {
                BCOutboundPage1.SwitchToMainContentFrame()
                    .WriteHoldersEANSSCCGS(p0);
            }

        }

        [Given(@"I write Holder/EAN/SSCC/GS '(.*)' second time"), When(@"I write Holder/EAN/SSCC/GS '(.*)' second time")]
        public void GivenIWriteHolderEANSSCCGSSecondTime(string p0)
        {
            BCOutboundPage1.WriteHoldersEANSSCCGSSecondtime(p0);

        }

        [Given(@"I click on Split Box button"), When(@"I click on Split Box button'")]
        public void GivenIClickOnSplitBoxButton()
        {
            BCOutboundPage1.ClickButtonSplitBox();
        }

        [Given(@"I switch frame -> Power packing module frame"), When(@"I switch frame -> Power packing module frame")]
        public void GivenISwitchFramePowerPackingModuleFrame()
        {
            BCOutboundPage1.SwitchFramePowerPackingModule();
        }

        [Given(@"I should get error message label '(.*)'")]
        public void GivenIShouldGetErrorMessageLabel(string p0)
        {
            Assert.Contains(p0, BCOutboundPage1.IShouldGetErrorMessagesLabel);

        }

        [Given(@"I get notification '(.*)' in Packing")]
        public void GivenIGetNotificationInPacking(string p0)
        {

            Assert.Contains(p0, BCOutboundPage1.IGetNotificationInPackingCard);

        }

        [Given(@"I should get POWER PACKING MODULE ERROR '(.*)'")]
        public void GivenIShouldGetPOWERPACKINGMODULEERROR(string p0)
        {

            Assert.Contains(p0, BCOutboundPage1.IShouldGetPOWERPACKINGMODULEsERROR);
        }

        [Given(@"I should get POWER PACKING MODULE ERROR Unknown '(.*)'")]
        public void GivenIShouldGetPOWERPACKINGMODULEERRORUnknown(string p0)
        {
            Assert.Contains(p0, BCOutboundPage1.IShouldGetPOWERPACKINGMODULEsERRORUnknown);
        }



        [Given(@"I Click Button Close -> Outbound")]
        public void GivenIClickButtonClose_Outbound()
        {
            BCOutboundPage1.ClickButtonCloseOutbound();
        }

        [Given(@"I click OK button Split Holder -> Outbound")]
        public void GivenIClickOKButtonSplitHolder_Outbound()
        {
            BCOutboundPage1.ClickOKButtonSplitHolderOutbound();
        }

        [Given(@"I Click Button Cancel -> Outbound")]
        public void GivenIClickButtonCancel_Outbound()
        {
            BCOutboundPage1.ClickButtonCancelOutbound();
        }

        [Given(@"I click Outbound from Main Page without switchContent Frame")]
        public void GivenIClickOutboundFromMainPageWithoutSwitchContentFrame()
        {
            BCOutboundPage1.ClickOutboundMainMenu();
        }

        [Given(@"I click Search and search Outbound -> Outbound")]
        public void GivenIClickSearchAndSearchOutbound_Outbound()
        {
            BCOutboundPage1.SearchLocationAndSearchOutbound();
        }

        [Given(@"I click Search and search Outbound code '([^']*)'-> Outbound")]
        public void GivenIClickSearchAndSearchOutboundCode_Outbound(string p0)
        {
            BCOutboundPage1.SearchOutboundCard(p0);
        }


        [Given(@"I save Pick Holder from created -> Outbound")]
        public void GivenISavePickHolderFromCreated_Outbound()
        {
            BCOutboundPage1.SavePickHolderFromCreatedOutbound();
        }

        [Given(@"I click Packing from Actions")]
        public void GivenIClickPackingFromActions()
        {
            BCOutboundPage1.ClickPackingFromActions();
        }

        [Given(@"I scan packtable-id '(.*)'")]
        public void GivenIScanPacktable_Id(string PacktableId)
        {
            BCOutboundPage1.ScanPacktableId(PacktableId);
        }

        [Given(@"I scan Saved Pick Holder from Outbound on Holder/Location")]
        public void GivenIScanSavedPickHolderFromOutboundOnHolderLocation()
        {
            BCOutboundPage1.ScanSavedPickHolderFromOutboundOnHolderLocation();
        }

        [Given(@"I click Outbound on Main Page without SwitchContent")]
        public void GivenIClickOutboundOnMainPageWithoutSwitchContent()
        {
            BCOutboundPage1.ClickOutboundMainMenu();
        }

        [Given(@"I click New in Outbound")]
        public void GivenIClickNewInOutbound()
        {
            BCOutboundPage1.ClickNewInOutbounds();
        }

        [Given(@"I click Show More in Outbound")]
        public void GivenIClickShowMoreInOutbound()
        {
            BCOutboundPage1.ClickShowMoreInOutbound();
        }

        [Given(@"I copy a file to a folder location Order")]
        public void GivenICopyAFileToAFolderLocationOrder()
        {
            BCOutboundPage7.CopyAFileToAFolderLocationOrder();
            Driver.SwitchTo().DefaultContent();
        }

        [Given(@"I copy a file to a folder location Order for missing customer")]
        public void GivenICopyAFileToAFolderLocationOrderMissingCustomerReference()
        {
            BCOutboundPage7.CopyAFileToAFolderLocationOrdermissingcustomerreference();
            Driver.SwitchTo().DefaultContent();
        }

        [Given(@"I search for second Customer Reference and update field VALUETEXT to '(.*)'")]
        public void GivenISearchForSecondCustomerReferenceAndUpdateFieldVALUETEXTTo(string p0)
        {
            BCOutboundPage7.SearchForSecondCustomerReferenceAndUpdateFieldVALUETEXTTo(p0);
        }

        [Given(@"I click Show More -> TRO")]
        public void GivenIClickShowMore_TRO()
        {
            BCOutboundPage1.ClickShowMoreInOutbound();
        }

        [Given(@"I Enter Carrier Booked '(.*)'")]
        public void GivenIEnterCarrierBooked(string CarrierBooked)
        {
            BCOutboundPage1.EnterCarrierBooked(CarrierBooked);
        }

        [Given(@"I enter type Outbound '(.*)'")]
        public void GivenIEnterTypeOutbound(string p0)
        {
            BCOutboundPage1.EnterTypeOutbound(p0);
        }

        [Given(@"I Enter Trailer Plate No '(.*)'")]
        public void GivenIEnterTrailerPlateNo(string trailerPlateNo)
        {
            BCOutboundPage1.IEnterTrailerPlateNo(trailerPlateNo);
        }

        [Given(@"I Enter Expected Arrival TRO")]
        public void GivenIEnterExpectedArrivalTRO()
        {
            BCOutboundPage1.EnterExpectedArrivalTRO();
        }

        [Given(@"I enter Expected Delivery TRO")]
        public void GivenIEnterExpectedDeliveryTRO()
        {
            BCOutboundPage1.EnterExpectedDeliveryTRO();
        }

        [Given(@"I click More options -> TRO")]
        public void GivenIClickMoreOptions_TRO()
        {
            BCOutboundPage1.ClickMoreOptionsTRO();
        }

        [Given(@"I click More options -> Basic TRO")]
        public void GivenIClickMoreOptions_BasicTRO()
        {
            BCOutboundPage1.ClickMoreOptionsBasicTRO();
        }

        [Given(@"I click More options -> TRO Main")]
        public void GivenIClickMoreOptions_TROMain()
        {
            BCOutboundPage1.ClickMoreOptionsTROMain();
        }

        [Given(@"I Close Pallet Pool -> TRO")]
        public void GivenIClosePalletPool_TRO()
        {
            BCOutboundPage1.ClosePalletPoolTROs();
        }

        [Given(@"I Click KPI -> TRO Transport")]
        public void GivenIClickKPI_TROTransport()
        {
            BCOutboundPage1.ClickKPITROTransport();
        }

        [Given(@"I go back -> Transport Outbound Card")]
        public void GivenIGoBack_TransportOutboundCard()
        {
            BCOutboundPage2.GoBackTransportOutboundsCard();
        }

        [Given(@"I click Search option on Transport Outbound List")]
        public void GivenIClickSearchOptionOnTransportOutboundList()
        {
            BCOutboundPage5.ClickSearchOptionOnTransportOutboundList();
        }

        [Given(@"I go back -> Transport Outbound to Main page")]
        public void GivenIGoBack_TransportOutboundToMainPage()
        {
            BCOutboundPage2.GoBackTransportOutboundToMainPages();
        }

        [Given(@"I enter Expected Arrived date -> TRO")]
        public void GivenIEnterExpectedArrivedDate_TRO()
        {
            BCOutboundPage1.EnterExpectedArrivedDateTRO();
        }

        [Given(@"I enter Start Loading Date Time -> TRO")]
        public void GivenIEnterStartLoadingDateTime_TRO()
        {
            BCOutboundPage1.EnterStartLoadingDateTimeTROs();
        }

        [Given(@"I enter Departed Time -> TRO")]
        public void GivenIEnterDepartedTime_TRO()
        {
            BCOutboundPage2.EnterDepartedTimeTROs();
        }

        [Given(@"I Click Actions and Transport From More options")]
        public void GivenIClickActionsandTransportFromMoreOptions()
        {
            BCOutboundPage2.ActionsandTransportFromMoreOptions();
        }

        [Given(@"I Click actions and transport from more options in TRO card")]
        public void GivenIClickActionsandTransportFromMoreOptionsInTROCard()
        {
            BCOutboundPage2.ActionsandTransportFromMoreOptionsInTROCard();
        }

        [Given(@"I Click Close Transport from Actions -> Transport")]
        public void GivenIClickCloseTransportFromActions_Transport()
        {
            BCOutboundPage2.CloseTransportFromActionsTransport();
        }

        [Given(@"I Click Close Transport -> TRO")]
        public void GivenIClickCloseTransport_TRO()
        {
            BCOutboundPage2.ClickCloseTransportTRO();
        }

        [Given(@"I should get Error '(.*)' -> TRO Notification")]
        public void GivenIShouldGetError_TRONotification(string expectedErrorTRO)
        {
            BCOutboundPage2.WaitForErrorTroNotificationPopUp(expectedErrorTRO);
            //Assert.Contains(expectedErrorTRO, BCOutboundPage1.IShouldSeePopupMessageErrorAfterCLOSEINGTRO);

        }

        [Given(@"I should get cutoff Error '(.*)' -> Outbound Notification")]
        public void GivenIShouldGetCutoffError_OutboundNotification(string expectedErrorOutbound)
        {

            Assert.Contains(expectedErrorOutbound, BCOutboundPage1.IShouldSeePopupMessageErrorsAfterCutoff);

        }

        [Given(@"I should get an Error '(.*)' -> TRO Notification")]
        public void GivenIShouldGetAnError_TRONotification(string expectedErrorTRO)
        {
            Assert.Contains(expectedErrorTRO, BCOutboundPage1.IShouldSeePopupMessageErrorAfterCLOSEINGTRONotFullyBooked);

        }

        [Given(@"I should get an error message '(.*)' -> TRO destination group")]
        public void GivenIShouldGetAnError_TRODestinationGroupNotification(string expectedErrorTROdestinationgroup)
        {
            Assert.Contains(expectedErrorTROdestinationgroup, BCOutboundPage1.IShouldSeePopupErrorMessageAfterChoosingDestinationGroup);

        }

        [Given(@"I should get an error message '(.*)' in TRO destination group")]
        public void GivenIShouldGetAnErrorInTRODestinationGroupNotification(string expectedErrorTROdestinationgroup)
        {
            Assert.Contains(expectedErrorTROdestinationgroup, BCOutboundPage1.IShouldSeePopupErrorMessageAfterChoosingDestinationGroupInTROQGs);

        }

        [Given(@"I should get an Error about status '(.*)' -> TRO Notification")]
        public void GivenIShouldGetAnErrorNoStatusLoaded_TRONotification(string expectedErrorTRO)
        {
            Assert.Contains(expectedErrorTRO, BCOutboundPage1.IShouldSeePopupMessageErrorAfterCLOSEINGTRONoStatusLoadeed);

        }



        [Given(@"I should get Date Error '(.*)' -> TRO Notification")]
        public void GivenIShouldGetDateError_TRONotification(string p0)
        {
            Assert.Contains(p0, BCOutboundPage1.IShouldGetDateErrorTRONotifications);

        }

        [Given(@"I should get unlinking Error '(.*)' -> TRO Notification")]
        public void GivenIShouldGetUnlinkingErrorTRO(string p0)
        {
            BCOutboundPage2.WaitForUnlinkingNotificationToAppear();
            Assert.Contains(p0, BCOutboundPage1.IShouldGetErrorForUnlinkingTRONotifications);

        }

        [Given(@"I should get cancel unlinking notification '(.*)'")]
        [When(@"I should get cancel unlinking notification '(.*)'")]
        [Then(@"I should get cancel unlinking notification '(.*)'")]
        public void GivenIShouldGetCancelUnlinkingNotification(string p0)
        {
            BCOutboundPage2.WaitForUnlinkingCancelledNotificationAppear();
            Assert.Contains(p0, BCOutboundPage1.IShouldGetCancelNotificationMessage);

        }

        [Given(@"I Click Pallet Pool -> TRO Transport")]
        public void GivenIClickPalletPool_TROTransport()
        {
            BCOutboundPage2.ClickPalletPoolTROTransport();
        }

        [Given(@"I fill unit '(.*)' on POWER Palletpool Transport Out")]
        public void GivenIFillUnitOnPOWERPalletpoolTransportOut(string Unit)
        {
            BCOutboundPage2.FillUnitOnPowerPalletPoolTransportOut(Unit);
        }

        [Given(@"I write qty '(.*)' in palletpool -> Transport Out")]
        public void GivenIFillQtyInPalletpool_TransportOut(string Qty)
        {
            BCOutboundPage2.WriteQtyInPalletPoolTransportOut(Qty);
        }

        [Given(@"I should get Error on Pallet Pool '(.*)' -> TRO")]
        public void GivenIShouldGetErrorOnPalletPool_TRO(string errorOnPalletPool)
        {
            Assert.Contains(errorOnPalletPool, BCOutboundPage1.IShouldGetErrorOnPalletPoolTROCard);

        }

        [Given(@"I enter Delivered Date Time -> TRO")]
        public void GivenIEnterDeliveredDateTime_TRO()
        {
            BCOutboundPage2.EnterDeliveredDateTimeTROs();
        }

        [Given(@"I click Link to a Transport from QueueGroup screen")]
        public void GivenIClickLinkToATransportFromQueueGroupScreen()
        {
            BCOutboundPage2.ClickLinkToATransportQueueGroup();
        }

        [Given(@"I enter End Loading Date Time -> TRO")]
        public void GivenIEnterEndLoadingDateTime_TRO()
        {
            BCOutboundPage1.EnterEndLoadingDateTimeTROs();
        }

        [Given(@"I enter Transport Sent Time -> TRO")]
        public void GivenIEnterTransportSentTime_TRO()
        {
            BCOutboundPage1.EnterTransportSentTimeTROs();
        }

        [Given(@"I enter Confirmed Time -> TRO")]
        public void GivenIEnterConfirmedTime_TRO()
        {
            BCOutboundPage1.IEnterConfirmedTimeTRO();
        }

        [Given(@"I click More options -> TRO QueueGroup")]
        public void GivenIClickMoreOptions_TROQueueGroup()
        {
            BCOutboundPage1.ClickMoreOptionsTROQueueGroup();
        }


        [Given(@"I click Actions -> TRO")]
        public void GivenIClickActions_TRO()
        {
            BCOutboundPage2.ClickActionsTRO();
        }

        [Given(@"I click Main Menu -> TRO")]
        public void GivenIClickMainMenu_TRO()
        {
            BCOutboundPage2.ClickMainMenu_TRO();
        }


        [Given(@"I click Transport -> TRO")]
        public void GivenIClickTransport_TRO()
        {
            BCOutboundPage2.ClickTransport_TROs();
        }

        [Given(@"I click on Transport in TRO card")]
        [When(@"I click on Transport in TRO card")]
        [Then(@"I click on Transport in TRO card")]
        public void GivenIClickTransportInTROCard()
        {
            BCOutboundPage2.ClickTransportInTROCard();
        }

        [Given(@"I click on Process in power outbound list")]
        public void GivenIClickOnProcessInOutboundList()
        {
            BCOutboundPage2.ClickProcessOutboundList();
        }

        [Given(@"I click Unlink Selected From transport -> Power outbound list")]
        public void GivenIClickUnlinkSelectedFromTransportPOWOutList()
        {
            BCOutboundPage2.ClickUnlinkSelectedFromTransportPOWOutList();
        }

        [Given(@"I click Transport Tab Main -> TRO")]
        public void GivenIClickTransportTabMain_TRO()
        {
            BCOutboundPage2.ClickTransportTabMain_TROs();
        }

        [Given(@"I click View Linked Queue Groups")]
        public void GivenIClickViewLinkedQueueGroups()
        {
            BCOutboundPage2.ClickViewLinkedQueueGroups();
        }


        [Given(@"I click Link queue gruop Picking -> TRO")]
        public void GivenIClickLinkQueueGruopPicking_TRO()
        {
            BCOutboundPage2.ClickLinkQueueGruopPicking_TROs();
        }

        [Given(@"I click Link to a Transport")]
        public void GivenIClickLinkToATransport()
        {
            BCOutboundPage2.IClickLinkToATransports();
        }

        [Given(@"I click on second Line -> POWER QUEUE GROUP LIST")]
        public void GivenIClickOnSecondLine_POWERQUEUEGROUPLIST()
        {
            BCOutboundPage2.ClickOnSecondLinePOWERQUEUEGROUPLISTs();
        }



        [Given(@"I select View Linked Queue Groups -> TRO")]
        public void GivenISelectViewLinkedQueueGroups_TRO()
        {
            BCOutboundPage2.SelectViewLinkedQueueGroups_TRO();
        }

        [Given(@"I click three dots on TRO Queue group List -> TRO")]
        public void GivenIClickThreeDotsOnTROQueueGroupList_TRO()
        {
            BCOutboundPage2.ClickThreeDotsOnTROQueueGroupList_TRO();
        }

        [Given(@"I click Actions and Queue Group on Dropdown -> TRO Queue group List")]
        public void GivenIClickActionsOnDropdown_TROQueueGroupList()
        {
            BCOutboundPage2.ClickActionsOnDropdown_TROQueueGroupList();
        }

        [Given(@"I click Queue Group on dropdown -> TRO Queue group List")]
        public void GivenIClickQueueGroupOnDropdown_TROQueueGroupList()
        {
            BCOutboundPage2.ClickQueueGroupOnDropdown_TROQueueGroupList();
        }



        [Given(@"I Click Actions From More options")]
        public void GivenIClickActionsFromMoreOptions()
        {
            BCOutboundPage2.ClickActionsFromMoreOptions();
        }

        [Given(@"I Click Other in Action Menu TRI")]
        public void GivenIClickOtherInActionMenuTRI()
        {
            BCOutboundPage2.ClickOtherInActionTRI();
        }

        [Given(@"I Click Invoce from Action Menu TRI")]
        public void GivenIClickInvoceFromActionMenuTRI()
        {
            BCOutboundPage2.ClickInvoceInTRIActionMenu();
        }
        [Given(@"I click NEW in POWER Prestations")]
        public void GivenIClickNEWInPOWERPrestations()
        {
            BCOutboundPage2.ClickNEWInPOWERPrestations();
        }
     
        [Given(@"I add Prestationcode Card")]
        public void GivenIAddPrestationcodeCard()
        {
            BCOutboundPage2.AddPrestionDetail();
        }
        [Given(@"I add AddInvocePurchase")]
        public void GivenIAddAddInvocePurchase()
        {
            BCOutboundPage2.AddPurchaseInvoce();
        }


        [Given(@"I press esc form keybord on BC"), When(@"I press esc form keybord on BC")]
        public void GivenIPressEscFormKeyboardOnBC()
        {
            BCOutboundPage1.SwitchToMainContentFrame()
              .PressEscFormKeyboardOnBC();
        }

        [Given(@"I press backspace on keyboard on BC")]
        public void GivenIPressBackspaceOnKeyboardOnBC()
        {
            BCOutboundPage1.SwitchToMainContentFrame()
                .PressBackspaceOnKeyboardOnBC();
        }

        [When(@"I validate the picture -> Packing page")]
        public void WhenIValidateThePicture_PackingPage()
        {
            BCOutboundPage1.SwitchToMainContentFrame()
                .ValidateThePicture_PackingPage();

        }

        [Given(@"I click Yes in the pop up message")]
        [When(@"I click Yes in the pop up message")]
        [Then(@"I click Yes in the pop up message")]
        public void GivenIClickYesInThePopUpMessage()
        {
            BCOutboundPage1.ClickYesInThePopUpMessages();
        }
        [Given(@"i validate the date of PPLCON message")]
        public void GivenIValidateTheDateOfPPLCONMessage()
        {
            BCOutboundPage1.WaitandValidateDatePPLCON();

        }
        [Given(@"i validate the date of PPLCON message for PPLCON LOAD")]
        public void GivenIValidateTheDateOfPPLCONMessageForPPLCONLOAD()
        {
            BCOutboundPage1.WaitandValidateDatePPLCONLOAD();
        }

        [Given(@"I copy File Location path of latest EDI MESSAGE LOG SEND")]
        public void GivenICopyFileLocationPathOfLatestEDIMESSAGELOGSEND()
        {
            BCOutboundPage1.CopyFileLocationPathOfLatestEDIMESSAGELOGSEND();
        }
        [Given(@"I verify value one '(.*)' and value two '(.*)' exits in File Location")]
        public void GivenIVerifyValueOneAndValueTwoExitsInFileLocation(string value1, string value2)
        {
            BCOutboundPage1.VerifyValueOneAndValueTwoExitsInFileLocation(value1, value2);
        }
        [Given(@"I copy file path of PPLCON")]
        public void GivenICopyFilePathOfPPLCON()
        {
            BCOutboundPage1.CopyPPLCONPath();
        }
        [Given(@"i check if PPLCON has the status of packed")]
        public void GivenICheckIfPPLCONHasTheStatusOfPacked()
        {
            BCOutboundPage1.CheckIfPacked();
        }

        [Given(@"i Check Item and QTY from PPLCON Message for pack")]
        public void GivenICheckItemAndQTYFromPPLCONMessageForPack()
        {
            BCOutboundPage1.CheckItemAndQTYPack();
        }


        [Given(@"i validate item and cancled QTY")]
        public void GivenIValidateItemAndCancledQTY()
        {
            BCOutboundPage1.ValidateItemandQTY();
        }
        [Given(@"i check item and cancelled QTY (.*)")]
        public void GivenICheckItemAndCancelledQTY(int p0)
        {
            BCOutboundPage1.CheckItemAndCanceledQTYminus1();
        }

        [Given(@"I check PAKCON message")]
        public void GivenICheckPAKCONMessage()
        {
            BCOutboundPage1.CheckPakConMessage();
        }


        [Given(@"I check Incorrect format message")]
        public void GivenICheckIncorrectFormatMessage()
        {
            BCOutboundPage1.CheckIncorretFormatMessage();
        }


        [Given(@"i Check Item and QTY from PPLCON Message")]
        public void GivenICheckItemAndQTYFromPPLCONMessage()
        {
            BCOutboundPage1.CheckItemAndQTY();
        }
        [Given(@"I verify that the order is deleted")]
        public void GivenIVerifyThatTheOrderIsDeleted()
        {
            BCOutboundPage1.VerifyThatOrderIsDeleted();
        }

        [Given(@"I click CutOff ---> Main Page")]
        public void GivenIClickCutOff_MainPage()
        {
            BCOutboundPage1.ClickCutOff_MainPage();
        }

        [Given(@"I click OK button in POWER Packing module table")]
        public void ThenIClickOKButtonInPOWERPackingModuleTable()
        {
            BCOutboundPage1.OKButtonInPOWERPackingModuleTable();
        }
        [Given(@"I click OK button in POWER Packing module ERROR")]
        [When(@"I click OK button in POWER Packing module ERROR")]
        [Then(@"I click OK button in POWER Packing module ERROR")]
        public void ThenIClickOKButtonInPOWERPackingModuleERROR()
        {
            BCOutboundPage1.OKButtonInPOWERPackingModuleERROR();
        }

        [Given(@"I click OK button in Packingmodule Second Opening")]
        [When(@"I click OK button in Packingmodule Second Opening")]
        [Then(@"I click OK button in Packingmodule Second Opening")]
        public void WhenIClickOKButtonInPackingmoduleSecondOpening()
        {
            BCOutboundPage1.OKButtonInPackingmoduleSecondOpening();
        }

        [Given(@"I click close button in POWER Packing error screen")]
        public void GivenIClickCloseButtonInPOWERPackingErrorScreen()
        {
            BCOutboundPage1.SwitchToDefaultFrame()
                    .SwitchToMainContentFrame();
            BCOutboundPage1.ClickCloseButtonInPOWERPackingErrorScreen();
        }

        [Given(@"I validate '(.*)' in POWER VAS Module")]
        public void GivenIValidateInPOWERVASModule(string vas)
        {

            BCOutboundPage1.SwitchToDefaultFrame()
                     .SwitchToMainContentFrame();


            BCOutboundPage1.ValidateInPOWERVASModule(vas);
        }
       
        [Given(@"I switch frame -> POWER packing VAS module")]
        public void GivenISwitchFrame_POWERPackingVASModule()
        {
            BCOutboundPage1.SwitchFrame_POWERPackingVASModule();
        }


    }
}
