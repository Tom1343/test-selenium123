using CGI_OUTBOUND_BC_Scenarios.Utilities;
//using CGI_PowerBaseline_Scenarios.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using TechTalk.SpecFlow;
using Xunit;


namespace CGI_OUTBOUND_BC_Scenarios.OUTBOUND.Pages
{
    [Binding]
    public class BCOutboundPage7 : Page
    {
        private WaitMethods WaitMethods => new WaitMethods(Driver);
        public BCOutboundPage7(IWebDriver driver) : base(driver) { }

        public BCOutboundPage7 AddThirdFilterForEDIMessageLogList(string thirdFilter)
        {

            Actions action = new Actions(Driver);
            action
                .MoveToElement(AddSecondFilterForEDIMessageLogList)
                .Perform();
            action
                .Click()
                .Build()
                .Perform();
            AddSecondFilterForEDIMessageLogList.SendKeys(thirdFilter);
            AddSecondFilterForEDIMessageLogList.SendKeys(Keys.Enter);
            return this;
        }

        public BCOutboundPage7 AddThirdSubFilterForEDIMessageLogList(string thirdSubFilter)
        {

            Actions action = new Actions(Driver);
            action
                .MoveToElement(EnterThirdSubfilter)
                .Perform();
            action
                .Click()
                .Build()
                .Perform();
            EnterThirdSubfilter.SendKeys(thirdSubFilter);
            EnterThirdSubfilter.SendKeys(Keys.Enter);
            return this;
        }

        public BCOutboundPage7 ClickTheDropDownMenuFromFilterPaneInEDIMessageLogList()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ClickTheDropdownMenuFromFilterPaneInEDIMessageLogListXpath));

            ClickTheDropdownMenuFromFilterPaneInEDIMessageLogList.Click();
            return this;
        }

        public BCOutboundPage7 ClickInsertedFromTheFilterDropDownMenu()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ClickInsertedFromTheFilterDropdownMenuXpath));

            ClickInsertedFromTheFilterDropdownMenu.Click();
            return this;
        }

        public BCOutboundPage7 ClickEditFromTheNavigationbar()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ClickEditFromTheNavigationBarXpath));

            ClickEditFromTheNavigationBar.Click();
            return this;
        }
        public BCOutboundPage7 ClickonHolderinOutboundCard()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ClickPickHolderXpath));
            ClickPickHolder.Click();

            WaitMethods.WaitForElementToBePresent(By.XPath(HolderTabInOutboundCardXpath));

            HolderTabInOutboundCard.Click();


            return this;
        }

        public BCOutboundPage7 ClickPrintMDGF()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(PrintMDGFXpath));
            PrintMDGF.Click();

            WaitMethods.WaitForElementToBePresent(By.XPath("//p[contains(text(),'Holder MDGF')]"));
            

            return this;
        }
        public BCOutboundPage7 ClickFromTheFilterDropDownMenu(string filterDropdown)
        {

            Actions action = new Actions(Driver);
            action
                .MoveToElement(ClickFromTheFilterDropdownMenu)
                .Perform();
            action
                .Click()
                .Build()
                .Perform();
            ClickFromTheFilterDropdownMenu.SendKeys(filterDropdown);
            return this;
        }

        public BCOutboundPage7 ChangeURLtoPOWPrintDocumentLog()
        {
            Driver.Navigate().GoToUrl("https://power-baseline.emea.tst.itglo.net/POWER/?tenant=baseline&table=74083");
            WaitMethods.WaitForElementToBePresent(By.XPath("(//span[@title = 'PRINT HOLDER MDGF'])[1]"));

            return this;
        }

        public BCOutboundPage7 ClickInterfaceFromMainMenu()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ClickInterfaceButtonMainMenuXpath));

            ClickInterfaceButtonMainMenu.Click();
            return this;
        }

        public BCOutboundPage7 ClickInterfaceTableInInterface()
        {
 //WaitMethods.WaitForElementToBePresent(By.XPath(ClickInterfaceTableFromInterfaceXpath));

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(ClickInterfaceTableFromInterfaceXpath)).Displayed);

            ClickInterfaceTableFromInterface.Click();
            return this;
        }

        public BCOutboundPage7 ValidateWCSLineInInterfaceTable()
        {
            WaitMethods.WaitForAllElementsToBeVisible(By.XPath("(//span[text() ='Processed'])[2]"));
            WaitMethods.WaitForElementToBePresent(By.XPath("(//span[text() ='Processed'])[2]"));
            WaitMethods.WaitForElementToBePresent(By.XPath("(//span[text() ='SYSTORE'])[1]"));
            WaitMethods.WaitForElementToBePresent(By.XPath("(//span[text() ='Transfer'])[1]"));
            WaitMethods.WaitForElementToBePresent(By.XPath("(//span[text() ='ST073161'])[1]"));
            WaitMethods.WaitForElementToBePresent(By.XPath("(//a[text() ='MOVE MASTER'])[1]"));


            return this;
        }

        public BCOutboundPage7 ValidateVacValues()
        {
            System.Threading.Thread.Sleep(2000);
            WaitMethods.WaitForAllElementsToBeVisible(By.XPath("(//span[text() ='Processed'])[2]"));
            WaitMethods.WaitForElementToBePresent(By.XPath("(//span[text() ='GEEKPLUS'])[1]"));
            WaitMethods.WaitForElementToBePresent(By.XPath("(//span[text() ='Processed'])[1]"));
            WaitMethods.WaitForElementToBePresent(By.XPath("(//span[text() ='ConfirmVAS'])[1]"));



            return this;
        }

        public BCOutboundPage7 EnterValueSearchPOWInterfaceLine()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(SearchButtonNasSimulatorXpath));
            SearchButtonNasSimulator.Click();

            InputSearchButtonNasSimulator.SendKeys(DataCollection.PickwaveHolderBarcode + Keys.Tab);
            return this;
        }

        public BCOutboundPage7 ClickRunInterfaceLinePoWInterfaceList()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ClickRunInterfaceLinePOWInterfaceListXpath));

            ClickRunInterfaceLinePOWInterfaceList.Click();
            return this;
        }

        public BCOutboundPage7 ClickOriginInDestTROCard()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ClickOriginDestTROCardXpath));

            ClickOriginDestTROCard.Click();
            new Actions(Driver).SendKeys(Keys.PageDown).Perform();
            return this;
        }

        public BCOutboundPage7 EnterLoadingLocationOriginDestTROCard(string loadingLocation)
        {
            Actions action = new Actions(Driver);
            action
                .MoveToElement(EnterLoadingLocationOriginDestinTRO)
                .Perform();
            action
                .Click()
                .SendKeys(loadingLocation)
                .Build()
                .Perform();
            return this;
        }

        public BCOutboundPage7 EnterFilterWithoutDateOnQueueGroupList()
        {

            WaitMethods.WaitForElementToAppear(By.XPath(FilterPaneOnQueueGroupListXpath))
                .WaitForElementToBeClickable(By.XPath(FilterPaneOnQueueGroupListXpath));

            //FilterPaneOnQueueGroupList.Click();

            WaitMethods.RepeatUntil(
           () => FilterPaneOnQueueGroupList.Click(),
           _ => Driver.FindElements(By.XPath(InputCodeonFilterQueueGroupXpath)).Count > 0,
           TimeSpan.FromSeconds(2), 5
           );

            return this;
        }

        public BCOutboundPage7 ClickCodeFieldWithoutFilter()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(CodeFieldWithoutFilterXpath))
                .WaitForElementToBeClickable(By.XPath(CodeFieldWithoutFilterXpath));
            CodeFieldWithoutFilter.Click();

            return this;
        }


        public BCOutboundPage7 SendQueueCodeInCodeField(string Filter)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(CodeFieldWithoutFilterXpath))
                .WaitForElementToBeClickable(By.XPath(CodeFieldWithoutFilterXpath));
            CodeFieldWithoutFilter.Click();
            CodeFieldWithoutFilter.SendKeys(Filter + Keys.Tab);

            return this;
        }


        public BCOutboundPage7 EnterCodeFilterQueueGrouplist(string Code)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(InputCodeonFilterQueueGroupXpath))
                .WaitForElementToBeClickable(By.XPath(InputCodeonFilterQueueGroupXpath));

            InputCodeonFilterQueueGroup.Click();
            InputCodeonFilterQueueGroup.SendKeys(Code + Keys.Tab);

            return this;
        }

        public BCOutboundPage7 EnterDateToDeliverInOutbound()
        {
            string DateToLoad = DateTime.Now.Date.ToString("dd/MM/yyyy");
            WaitMethods.RepeatUntil(
                () =>
                {
                    EnterDateToDeliverOnOutbound.Click();
                    EnterDateToDeliverOnOutbound.SendKeys(DateToLoad);
                },
                _ => EnterDateToDeliverOnOutbound.GetAttribute("value").Equals(DateToLoad),
                TimeSpan.FromSeconds(2), 5
                );

            return this;
        }

        public BCOutboundPage7 EnterDateToDeliverOnOutboundPlusDays(double p0)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(EnterDateToDeliverOnOutboundXpath)).Displayed);
            EnterDateToDeliverOnOutbound.Click();

            var dt = DateTime.Now.AddDays(p0).ToString("dd/MM/yyyy");
            EnterDateToDeliverOnOutbound.SendKeys(dt + Keys.Tab);

            return this;
        }

        public BCOutboundPage7 EnterDateToLoadPlusDays(double p0)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(c => c.FindElement(By.XPath(EnterDateToDeliverOnOutboundXpath)).Displayed);
            EnterDateToLoadOutbound.Click();

            var dt = DateTime.Now.AddDays(p0).ToString("dd/MM/yyyy");
            EnterDateToLoadOutbound.SendKeys(dt + Keys.Tab);

            return this;
        }

        public BCOutboundPage7 BookAllInOrderManageOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ManageOrderOutboundXpath))
                            .WaitForElementToBeClickable(By.XPath(ManageOrderOutboundXpath));
            ManageOrderOutbound.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(BookAllRecordsOutboundXpath))
                            .WaitForElementToBeClickable(By.XPath(BookAllRecordsOutboundXpath));
            BookAllRecordsOutbound.Click();

            return this;
        }

        public BCOutboundPage7 CutOffInOrderManageOutbound()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(ManageOrderOutboundXpath))
                            .WaitForElementToBeClickable(By.XPath(ManageOrderOutboundXpath));
            ManageOrderOutbound.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(CuttOffOutboundXpath))
                            .WaitForElementToBeClickable(By.XPath(CuttOffOutboundXpath));
            CuttOffOutbound.Click();

            return this;
        }

        public BCOutboundPage7 EnterCopiedOutboundSearchNasSimulator()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(SearchButtonNasSimulatorXpath))
                           .WaitForElementToBeClickable(By.XPath(SearchButtonNasSimulatorXpath));
            SearchButtonNasSimulator.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(InputSearchButtonNasSimulatorXpath))
                           .WaitForElementToBeClickable(By.XPath(InputSearchButtonNasSimulatorXpath));
            InputSearchButtonNasSimulator.SendKeys('*' + DataCollection.OutboundCodeFromNewOutbound + '*' + Keys.Tab);
            return this;
        }

        public BCOutboundPage7 EnterCopiedOutboundsSearchNasSimulator()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(SearchButtonNasSimulatorXpath));
            InputSearchButtonNasSimulator.SendKeys(DataCollection.SecondOutboundCode + Keys.Tab);

            return this;
        }

        public BCOutboundPage7 OperationsOverviewsWithoutSwitch()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(OpertionOverviewsXpath));

            OperationOverviews.Click();

            return this;
        }

        public BCOutboundPage7 ClickTransportPlanningButton()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ClickTransportPlanningXpath));

            ClickTransportPlanning.Click();
            return this;
        }

        public BCOutboundPage7 SearchOutboundPowerTransportOutboundList()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(SearchButtonTRO_PowerTransporOutboundListXpath));

            SearchButtonTRO_PowerTransporOutboundList.Click();

            SearchInputTRO_PowerTransporOutboundList.SendKeys(DataCollection.OutboundCodeFromNewOutbound);

            return this;
        }

        public BCOutboundPage7 ClickActionsMenu()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ActionsXpath));

            Actions.Click();
            return this;
        }

        public BCOutboundPage7 ClickLinkTitle()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(LinkOnMoreOptionsQueGroupXpath)); ;

            LinkOnMoreOptionsQueGroup.Click();
            return this;
        }

        public BCOutboundPage7 ClickLinkToExistingTRO()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(LinkToExistingTROXpath)); ;

            LinkToExistingTRO.Click();
            return this;
        }

        public BCOutboundPage7 SearchCreatedTROPowerTransportList()
        {

            WaitMethods.WaitForElementToBePresent(By.XPath(SearchButtonTRO_PowerTransporOutboundListXpath));

            SearchButtonTRO_PowerTransporOutboundListSecondFrame.Click();

            SearchInputTRO_PowerTransporOutboundListSecondFrame.SendKeys(DataCollection.TROCodeFromNewTRO);

            return this;
        }

        public BCOutboundPage7 CopyAFileToAFolderLocationOrder()
        {
            const string fileName = "EDI0000012.TXT";
            const string sourcePath = Constants.sourcePath;
            const string targetPath = Constants.targetPath;

            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);
            File.Copy(sourceFile, destFile, true);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (!File.Exists(destFile)
                && new FileInfo(destFile).Length == 0
                && stopwatch.Elapsed.TotalSeconds < SetMethods.DefaultTimeOut) ;

            return this;
        }
        public BCOutboundPage7 CopyAFileToAFolderLocationOrdermissingcustomerreference()
        {
            const string fileName = "EDI0000003  missing customer reference.TXT";
            const string sourcePath = Constants.sourcePath;
            const string targetPath = Constants.targetPath;

            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);
            File.Copy(sourceFile, destFile, true);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (!File.Exists(destFile)
                && new FileInfo(destFile).Length == 0
                && stopwatch.Elapsed.TotalSeconds < SetMethods.DefaultTimeOut) ;

            return this;
        }

        public BCOutboundPage7 SearchForSecondCustomerReferenceAndUpdateFieldVALUETEXTTo(string p0)
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(secondCustomerReferenceEDIXpath));
            secondCustomerReferenceEDI.Click();

            secondCustomerReferenceEDI.SendKeys(Keys.Tab + Keys.Tab + p0);

            return this;
        }

        public BCOutboundPage7 ISelectCodeInPickingRoute(string p0)
        {
            WaitMethods.WaitForElementToAppear(By.XPath($"//tr[@aria-rowindex='3']//a[text()='{p0}']"))
                .WaitForElementToBeClickable(By.XPath($"//tr[@aria-rowindex='3']//a[text()='{p0}']"));

            Driver.FindElement(By.XPath($"//tr[@aria-rowindex='3']//a[text()='{p0}']")).Click();

            return this;
        }

        public BCOutboundPage7 ISelectCodePickingRoute(string p0)
        {
            WaitMethods.WaitForElementToAppear(By.XPath($"//span[text()='{p0}']"))
                .WaitForElementToBeClickable(By.XPath($"//span[text()='{p0}']"));

            Driver.FindElement(By.XPath($"//span[text()='{p0}']")).Click();

            return this;
        }
        public BCOutboundPage7 EnterCodeOnOutboundInQueueGroups(string OutboundCode)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(EnterCodeOutboundInQueueGroupXpath))
                .WaitForElementToBeClickable(By.XPath(EnterCodeOutboundInQueueGroupXpath));

            WaitMethods.RepeatUntil(
            () =>
            {
                EnterCodeOutboundInQueueGroup.Click();
                EnterCodeOutboundInQueueGroup.SendKeys(OutboundCode + Keys.Enter);
            },
            _ => EnterCodeOutboundInQueueGroup.GetAttribute("value").Equals(OutboundCode),
            TimeSpan.FromSeconds(2), 5
            );

            WaitMethods.WaitForPageToBeReady();

            return this;
        }
        public BCOutboundPage7 ClickManipulationfromMainMenu()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(ManipulationLobasXpath));

            ManipulationLobas.Click();
            return this;
        }
        public BCOutboundPage7 ClickLB2SDDetails()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(LB2SDDetailXpath));

            LB2SDDetail.Click();

            if (SetMethods.IsElementPresent(Driver, By.XPath("//span[contains(text(),'PI')]")))
            {
                Driver.FindElement(By.XPath("//span[@aria-label='Manage']")).Click();
                WaitMethods.WaitForElementToBePresent(By.XPath("//span[@aria-label='Delete']"));
                Driver.FindElement(By.XPath("//span[@aria-label='Delete']")).Click();
                WaitMethods.WaitForElementToBePresent(By.XPath(ClickYesInThePopUpMessageXpath));
                ClickYesInThePopUpMessage.Click();
                WaitMethods.WaitForElementToBeGone(By.XPath(ClickYesInThePopUpMessageXpath));
            }
            return this;
        }
        public BCOutboundPage7 CheckandDeleteLines()
        {


            if (SetMethods.IsElementPresent(Driver, By.XPath("//span[@title='PI238991']")))

            { 
                WaitMethods.WaitForElementToAppear(By.XPath(ManageButtonManipulationXpath))
               .WaitForElementToBeClickable(By.XPath(ManageButtonManipulationXpath));


            ManageButtonManipulation.Click();


            WaitMethods.WaitForElementToAppear(By.XPath(DeleteButtonManipulationXpath))
               .WaitForElementToBeClickable(By.XPath(DeleteButtonManipulationXpath));

            DeleteButtonManipulation.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(ClickYesInThePopUpMessageXpath))
               .WaitForElementToBeClickable(By.XPath(ClickYesInThePopUpMessageXpath));

            ClickYesInThePopUpMessage.Click();

            WaitMethods.WaitForElementToBeGone(By.XPath(PickHolderGoneXpath));

            }
            return this;
        }
        public BCOutboundPage7 SelectStockButton()
        {

            

            WaitMethods.WaitForElementToAppear(By.XPath(SelectStockLBSDHeaderXpath))
                        .WaitForElementToBeClickable(By.XPath(SelectStockLBSDHeaderXpath));
            SelectStockLBSDHeader.Click();
            return this;
        }
        public BCOutboundPage7 ScanHolderinLBSD(string holderbarcode)
        {

            WaitMethods.WaitForElementToAppear(By.XPath(HolderBarcodePowerSelectStockXpath))
               .WaitForElementToBeClickable(By.XPath(HolderBarcodePowerSelectStockXpath));

            HolderBarcodePowerSelectStock.Clear();
            HolderBarcodePowerSelectStock.SendKeys(holderbarcode + Keys.Tab);
            ClickOKButtonOnThePopUpMessage.Click();

            WaitMethods.WaitForElementToBeGone(By.XPath(HolderBarcodePowerSelectStockXpath));


            return this;
        }
        public BCOutboundPage7 AddSKUinLB2SD(string p0)
        {

            WaitMethods.WaitForElementToAppear(By.XPath(AddSkutoTransferXpath))
               .WaitForElementToBeClickable(By.XPath(AddSkutoTransferXpath));

            AddSkutoTransfer.SendKeys(p0 + Keys.Tab);
            return this;
        }
        public BCOutboundPage7 AddJTransfer(string p0)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(AddJtransferXpath))
               .WaitForElementToBeClickable(By.XPath(AddJtransferXpath));

            AddJtransfer.SendKeys(p0 + Keys.Tab);
            return this;
        }
        public BCOutboundPage7 AddJComment(string p0)
        {
            WaitMethods.WaitForElementToAppear(By.XPath(AddJcommentXpath))
               .WaitForElementToBeClickable(By.XPath(AddJcommentXpath));

            AddJcomment.SendKeys(p0 + Keys.Return);
            return this;
        }

        public BCOutboundPage7 AddJnewLocation(string p0)
        {
            // AddJnewlocation

            WaitMethods.WaitForElementToAppear(By.XPath(AddJnewlocationXpath))
               .WaitForElementToBeClickable(By.XPath(AddJnewlocationXpath));

            AddJnewlocation.SendKeys(p0 + Keys.Tab);
            return this;
        }
        public BCOutboundPage7 ClickBookAllinManipulationDetails()
        {

            WaitMethods.WaitForElementToAppear(By.XPath(BookAllinManipulationXpath))
               .WaitForElementToBeClickable(By.XPath(BookAllinManipulationXpath));


            BookAllinManipulation.Click();
            WaitMethods.WaitForElementToBeGone(By.XPath(BookAllinManipulationXpath));
            return this;
        }

        public BCOutboundPage7 BoookALLInExpected()
        {
            WaitMethods.WaitForElementToAppear(By.XPath(BookAllinManipulationLB2SDXpath))
               .WaitForElementToBeClickable(By.XPath(BookAllinManipulationLB2SDXpath));


            BookAllinManipulationLB2SD.Click();
            WaitMethods.WaitForElementToBeGone(By.XPath("//span[text()='Working on it...']"));
            return this;
        }
        public BCOutboundPage7 ClickManageandDeleteLine()
        {


            WaitMethods.WaitForElementToAppear(By.XPath(ManageButtonManipulationXpath))
               .WaitForElementToBeClickable(By.XPath(ManageButtonManipulationXpath));


            ManageButtonManipulation.Click();


            WaitMethods.WaitForElementToAppear(By.XPath(DeleteButtonManipulationXpath))
               .WaitForElementToBeClickable(By.XPath(DeleteButtonManipulationXpath));

            DeleteButtonManipulation.Click();

            WaitMethods.WaitForElementToAppear(By.XPath(ClickYesInThePopUpMessageXpath))
               .WaitForElementToBeClickable(By.XPath(ClickYesInThePopUpMessageXpath));

            ClickYesInThePopUpMessage.Click();

            WaitMethods.WaitForElementToBeGone(By.XPath(PickHolderGoneXpath));

            return this;
        }
        public BCOutboundPage7 ClickLB2SDHeader()
        {
            WaitMethods.WaitForElementToBePresent(By.XPath(LB2SDHeaderXpath));

            LB2SDHeader.Click();


            if (SetMethods.IsElementPresent(Driver, By.XPath("//span[contains(text(),'PI')]")))
            {
                Driver.FindElement(By.XPath("//span[@aria-label='Manage']")).Click();
                WaitMethods.WaitForElementToBePresent(By.XPath("//span[@aria-label='Delete']"));
                Driver.FindElement(By.XPath("//span[@aria-label='Delete']")).Click();
                WaitMethods.WaitForElementToBePresent(By.XPath(ClickYesInThePopUpMessageXpath));
                ClickYesInThePopUpMessage.Click();
                WaitMethods.WaitForElementToBeGone(By.XPath(ClickYesInThePopUpMessageXpath));
            }
            return this;
        }     
    }
}
