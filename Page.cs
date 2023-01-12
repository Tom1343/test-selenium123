using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace CGI_OUTBOUND_BC_Scenarios.Utilities
{
    [Binding]
    public class Page
    {
        internal IWebDriver Driver;
        public Page(IWebDriver driver) => Driver = driver;

        public const string ProgressBarXPath = "//span[text()='Working on it...']";
        public IWebElement ProgressBar => Driver.FindElement(By.XPath(ProgressBarXPath));

        public const string StatusOfQueueGroupXpath = "//div[@controlname='ctrlStatus']//div//select";
        public IWebElement StatusOfQueueGroup => Driver.FindElement(By.XPath(StatusOfQueueGroupXpath));

        public const string ProgressBarMainXPath = "//div[@class='spinner']";
        public IWebElement ProgressBarMain => Driver.FindElement(By.XPath(ProgressBarMainXPath));

        public const string ProgressBarValidatingXPath = "//span[contains(text(),'Validating in progress')]";
        public IWebElement ProgressBarValidating => Driver.FindElement(By.XPath(ProgressBarValidatingXPath));

        public const string ProgressBarEDIXPath = "//span[contains(text(),'NAS ---> KTN EDI')]";
        public IWebElement ProgressBarEDI => Driver.FindElement(By.XPath(ProgressBarEDIXPath));

        public const string MainContentFrameXPath = "//iframe[@title='Main Content']";
        public IWebElement MainContentFrame => Driver.FindElement(By.XPath(MainContentFrameXPath));

        public const string ManageCutOffIFrameXpath = "//form[@controlname='POWMenuRoleCenterBSG']";
        public IWebElement ManageCutOffIFrame => Driver.FindElement(By.XPath(ManageCutOffIFrameXpath));

        public const string ClickSearchLocationXpath = "//body/div/div/form/div/div/div/div/div/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]";
        public IWebElement ClickSearchLocation => Driver.FindElement(By.XPath(ClickSearchLocationXpath));

        public const string InsertSearchLocationListXpath = "//input[@placeholder='Search']";
        public IWebElement InsertSearchLocationList => Driver.FindElement(By.XPath(InsertSearchLocationListXpath));

        public const string SearchButtonOnNavBarXpath = "//div//div[2]//a[1]";
        public IWebElement SearchButtonOnNavBar => Driver.FindElement(By.XPath(SearchButtonOnNavBarXpath));

        public const string MaximixeFormForInputFieldXpath = "//div[@class='dialog-maximize icon-MaximizeOn']";
        public IWebElement MaximixeFormForInputField => Driver.FindElement(By.XPath(MaximixeFormForInputFieldXpath));

        public const string SearchInputXpath = "//body/div/div/form/div/div/div/div/div/div/div/div/div/input[1]";
        public IWebElement SearchInput => Driver.FindElement(By.XPath(SearchInputXpath));

        public const string LocationsFromSearcMainMenuhXpath = "//body/div/div/form/div/div/div/div/div/div/div/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]";
        public IWebElement LocationsFromSearchMainMenu => Driver.FindElement(By.XPath(LocationsFromSearcMainMenuhXpath));

        public const string EDIDropdownMenuFromACTIONSXpath = "//span[contains(text(),'EDI')]";
        public IWebElement EDIDropdownMenuFromACTIONS => Driver.FindElement(By.XPath(EDIDropdownMenuFromACTIONSXpath));

        public const string ClickMessageLogReceivingsFromEDIMenuXpath = "//div[contains(text(),'Message Log Receiving')]";
        public IWebElement ClickMessageLogReceivingsFromEDIMenu => Driver.FindElement(By.XPath(ClickMessageLogReceivingsFromEDIMenuXpath));

        public const string EnterFirstFilterEDIMessageXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[5]/div[2]/div[1]/div[2]/div/div[2]/div/div/div[1]/div[2]/div[2]/div/div[2]/div/div/div/div/input";
        public IWebElement EnterFirstFilterEDIMessage => Driver.FindElement(By.XPath(EnterFirstFilterEDIMessageXpath));

        public const string RunPOWEREDIManagerXpath = "//div[contains(text(),'Run POWER EDI Manager')]";
        public IWebElement RunPOWEREDIManager => Driver.FindElement(By.XPath(RunPOWEREDIManagerXpath));

        public const string MessageLogReceivingXpath = "//div[contains(text(),'Message Log Receiving')]";
        public IWebElement MessageLogReceiving => Driver.FindElement(By.XPath(MessageLogReceivingXpath));

        public const string ShowFilterPaneForEDIMessagesXpath = "//button[@title='Show filter pane']";
        public IWebElement ShowFilterPaneForEDIMessages => Driver.FindElement(By.XPath(ShowFilterPaneForEDIMessagesXpath));

        public const string FilterInNASXpath = "//button[@aria-label='Add a new filter on a field']";
        public IWebElement FilterInNAS => Driver.FindElement(By.XPath(FilterInNASXpath));

        public const string ClickFilterButtonOnNasSimulatorXpath = "(//i[@data-icon-name='Filter'])[1]";
        public IWebElement ClickFilterButtonOnNasSimulator => Driver.FindElement(By.XPath(ClickFilterButtonOnNasSimulatorXpath));

        public const string EnterFilterEDIMessageXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[5]/div[2]/div[1]/div[2]/div/div[2]/div/div/div[1]/div[2]/div[2]/div/div[2]/div/div/div/div/input";
        public IWebElement EnterFilterEDIMessage => Driver.FindElement(By.XPath(EnterFilterEDIMessageXpath));

        public const string NotProcessedEDIMessageLineXpath = "//a[contains(text(),'Not processed')]";
        public IWebElement NotProcessedEDIMessageLine => Driver.FindElement(By.XPath(NotProcessedEDIMessageLineXpath));

        public const string GoBackFromEDIMessageLogListXpath = "//button[@class='ms-Button ms-Button--icon back-button--sc3snD4Rah9iUaXSn-0h5 root-35']";
        public IWebElement GoBackFromEDIMessageLogList => Driver.FindElement(By.XPath(GoBackFromEDIMessageLogListXpath));

        public const string GoBackFromEDIMessageLogMainXpath = "//button[(@data-is-focusable='true')and(@title='Back')]";
        public IWebElement GoBackFromEDIMessageLogMain => Driver.FindElement(By.XPath(GoBackFromEDIMessageLogMainXpath));

        public const string CustomerReference2ValueEDIMessageXpath = "//span[contains(text(),'CUSTOMER REFERENCE 2 (1154)')]";
        public IWebElement CustomerReference2ValueEDIMessage => Driver.FindElement(By.XPath(CustomerReference2ValueEDIMessageXpath));

        public const string EnterCustomerReference2ValueEDIMessageXpath = "//td[7]//input[1]";
        public IWebElement EnterCustomerReference2ValueEDIMessage => Driver.FindElement(By.XPath(EnterCustomerReference2ValueEDIMessageXpath));

        public const string EnterSecondFilterEDIMessageXPath = "//select[@class='enumerationcontrol-edit thm-cont-u1-font-size thm-cont-u1-font-stack thm-cont-u1-color-2--medflat thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus thm-cont-h1-bdrcolor--hover']";
        public IWebElement EnterSecondFilterEDIMessage => Driver.FindElement(By.XPath(EnterSecondFilterEDIMessageXPath));

        public const string EnterValueTransportEDIMessageXpath = "//td[7]//input[1]";
        public IWebElement EnterValueTransportEDIMessage => Driver.FindElement(By.XPath(EnterValueTransportEDIMessageXpath));

        public const string TransportValueEDIMessageXpath = "//span[contains(text(),'UPS')]";
        public IWebElement TransportValueEDIMessage => Driver.FindElement(By.XPath(TransportValueEDIMessageXpath));

        public const string OrderTypeValueEDIMessageXpath = "//div[@class='spa-view spa-normal no-animations shown']//tr[3]//td[7]";
        public IWebElement OrderTypeValueEDIMessage => Driver.FindElement(By.XPath(OrderTypeValueEDIMessageXpath));

        public const string ClickOutboundFromMainMenuXpath = "//a[starts-with(@title,'Outbounds where Status')]";
        public IWebElement ClickOutboundFromMainMenu => Driver.FindElement(By.XPath(ClickOutboundFromMainMenuXpath));

        public const string ClickInterfaceFromMainMenuXpath = "//span[@aria-label = 'Interface']";
        public IWebElement ClickInterfaceFromMainMenu => Driver.FindElement(By.XPath(ClickInterfaceFromMainMenuXpath));

        public const string StockXpath = "//span[contains(text(),'Stock' )]";
        public IWebElement Stock => Driver.FindElement(By.XPath(StockXpath));

        public const string ClickPackingFromMainMenuXpath = "//div[text()='Packing']";
        public IWebElement ClickPackingFromMainMenu => Driver.FindElement(By.XPath(ClickPackingFromMainMenuXpath));

        public const string PowerModuleFrameXPath = "//iframe[@title='POWERModuleStart']";
        public IWebElement PowerModuleFrame => Driver.FindElement(By.XPath(PowerModuleFrameXPath));

        public IWebElement FullScreenQueueGroup => Driver.FindElement(By.XPath(FullScreenQueueGroupXpath));

        public const string FullScreenQueueGroupXpath = "//button[@title='Show wide layout view' and @data-is-focusable='true']//span//i";

        public const string FullScreenButtonPackingXpath = "//button[@title='Maximize the page']/span/i";
        public IWebElement FullScreenButtonPacking => Driver.FindElement(By.XPath(FullScreenButtonPackingXpath));

        public const string PacktableIdInputXpath = "//input[starts-with(@aria-label,'(Blank)')]";
        public IWebElement PacktableIdInput => Driver.FindElement(By.XPath(PacktableIdInputXpath));

        public const string PackTableIDInputXpath = ".//div[@class='col-12 mt-3']//input";
        public IWebElement PackTableIDInput => Driver.FindElement(By.XPath(PackTableIDInputXpath));

        public const string IDPasswordInPackingXpath = "//input[@id='password']";
        public IWebElement IDPasswordInPacking => Driver.FindElement(By.XPath(IDPasswordInPackingXpath));

        public const string PowerPackingModuleFrameXPath = "//div[@class='task-dialog-content-container thm-cont-g0-bgcolor-1']//div//div//div[4]//div//iframe";
        public IWebElement PowerPackingModuleFrame => Driver.FindElement(By.XPath(PowerPackingModuleFrameXPath));

        public const string PowerPackingModuleTempSelectFrameXPath = "(//div[@class='ms-nav-band-container'])[4]//div//iframe";
        public IWebElement PowerPackingModuleTempSelectFrame => Driver.FindElement(By.XPath(PowerPackingModuleTempSelectFrameXPath));

        public const string SwitchToPowerModuleErrorFrameXPath = "//iframe[@title='POWERModuleError']";
        public IWebElement SwitchToPowerModuleErrorFrame => Driver.FindElement(By.XPath(SwitchToPowerModuleErrorFrameXPath));

        public const string SwitchToPOWRFLogPickingErrorFramesXpath = "//div[@class='collapsibleTab-container']//div//div//div//iframe";

        public IWebElement SwitchToPOWRFLogPickingErrorFrames => Driver.FindElement(By.XPath(SwitchToPOWRFLogPickingErrorFramesXpath));

        public const string IShouldGetPOWERPACKINGMODULEERROROutboundXpath = "//label[@id='txtError']";
        public IWebElement IShouldGetPOWERPACKINGMODULEERROROutbound => Driver.FindElement(By.XPath(IShouldGetPOWERPACKINGMODULEERROROutboundXpath));

        public const string IShouldGetErrorsMessagePACKINGXpath = "//div[@class='ms-nav-logical-dialog logical-dialog-nocaption']//div//div//p";
        public IWebElement IShouldGetErrorsMessagePACKING => Driver.FindElement(By.XPath(IShouldGetErrorsMessagePACKINGXpath));

        public const string IShouldGetErrorMessagePackingNotificationXpath = "//div[starts-with(@class,'ms-nav-logical')]//following::p[contains(text(),'Scanned')]";
        public IWebElement IShouldGetErrorMessagePackingNotification => Driver.FindElement(By.XPath(IShouldGetErrorMessagePackingNotificationXpath));

        public const string IShouldGetPOWERErrorMessagePOWERPackingNotificationXpath = "//div[starts-with(@class,'ms-nav-logical')]//following::p[contains(text(),'The')]";
        public IWebElement IShouldGetPOWERErrorMessagePOWERPackingNotification => Driver.FindElement(By.XPath(IShouldGetPOWERErrorMessagePOWERPackingNotificationXpath));

        public const string ClickCloseBtnOutboundBtnXpath = "//button[@class='cursorinherit ms-nav-button thm-popp-a3-bgcolor thm-popp-a3-bgcolor-1--hover thm-popp-a3-bgcolor-3--active thm-popp-a3-color thm-popp-a3-color-1--hover thm-popp-a3-color-2--focus thm-popp-a3-color-3--active thm-popp-a3-font-stack thm-popp-a3-font-size thm-popp-a3-outlinecolor thm-popp-a3-outlinecolor-2--focus thm-popp-a3-bdrcolor thm-popp-a3-bdrcolor-1--hover thm-popp-a3-bdrcolor-2--focus thm-popp-a3-bdrcolor-3--active']";
        public IWebElement ClickCloseBtnOutboundBtn => Driver.FindElement(By.XPath(ClickCloseBtnOutboundBtnXpath));

        public const string ErrorPickButtonXpath = "//button[@id='btnErrorPick']";
        public IWebElement ErrorPickButton => Driver.FindElement(By.XPath(ErrorPickButtonXpath));

        public const string OkButtonInPackingXpath = "//button[@id='btnOk']";
        public IWebElement OkButtonInPacking => Driver.FindElement(By.XPath(OkButtonInPackingXpath));

        public const string HolderLocationIDInputXpath = "(//div[@id='controlAddIn']//div//div//div//div[2]//div//div//div//div[2]//input)[1]";
        public IWebElement HolderLocationIDInput => Driver.FindElement(By.XPath(HolderLocationIDInputXpath));

        public const string QtyOfTheItemInputXpath = "//input[@id='ctrlQty']";
        public IWebElement QtyOfTheItemInput => Driver.FindElement(By.XPath(QtyOfTheItemInputXpath));

        public const string YesButtonInPackingXpath = "//button[@id='btnYes']";
        public IWebElement YesButtonInPacking => Driver.FindElement(By.XPath(YesButtonInPackingXpath));

        public const string WriteHolderEANSSCCGSXpath = "//input[@id='ctrlScan2']";
        public IWebElement WriteHolderEANSSCCGS => Driver.FindElement(By.XPath(WriteHolderEANSSCCGSXpath));

        public const string MaximiseButtonPackingFromXpath = "(//i [@data-icon-name ='FullScreen'])[2]";
        public IWebElement MaximiseButtonPackingFrom => Driver.FindElement(By.XPath(MaximiseButtonPackingFromXpath));

        public const string ClosePickHolderPackingXpath = "//button[@id='btnClosePickHolder']";
        public IWebElement ClosePickHolderPacking => Driver.FindElement(By.XPath(ClosePickHolderPackingXpath));

        public const string ClickItemDetailPackingXpath = "//button[@id='btnItemDetail']";
        public IWebElement ClickItemDetailPacking => Driver.FindElement(By.XPath(ClickItemDetailPackingXpath));

        public const string ClickSelectButtonXpath = "//button[@id='btnSelect']";
        public IWebElement ClickSelectButton => Driver.FindElement(By.XPath(ClickSelectButtonXpath));

        public const string WriteInQtyXpath = "//input[@id='ctrlQty']";
        public IWebElement WriteInQty => Driver.FindElement(By.XPath(WriteInQtyXpath));

        public const string WriteItemBarcodeXpath = "//input[@id='ctrlItemBarcode']";
        public IWebElement WriteItemBarcode => Driver.FindElement(By.XPath(WriteItemBarcodeXpath));

        public const string DropdownTypeErrorXpath = "//select[@id='ctrlTypeError']";
        public IWebElement DropdownTypeError => Driver.FindElement(By.XPath(DropdownTypeErrorXpath));

        public const string ClickNewInOutboundXpath = "//button[@title='Create a new entry.']";
        public IWebElement ClickNewInOutbound => Driver.FindElement(By.XPath(ClickNewInOutboundXpath));

        public const string ShowMoreInOutboundXpath = "//button[@aria-label='General, Show more']";
        public IWebElement ShowMoreInOutbound => Driver.FindElement(By.XPath(ShowMoreInOutboundXpath));

        public const string OutboundCodeFieldXpath = "//div[@controlname='Outbound Code']//div//span";
        public IWebElement OutboundCodeField => Driver.FindElement(By.XPath(OutboundCodeFieldXpath));

        public const string DateToFinishPickingXpath = "//div[@controlname='Date to finish Picking']//div//input";
        public IWebElement DateToFinishPicking => Driver.FindElement(By.XPath(DateToFinishPickingXpath));

        public const string FillOnlineOrderNumberXpath = "//body/div/div/form/div/div/div/div/div/div/div/div[1]/div[2]/div[1]/div[3]/div[1]/input[1]";
        public IWebElement FillOnlineOrderNumber => Driver.FindElement(By.XPath(FillOnlineOrderNumberXpath));

        public const string FillTimeToFinishPickingXpath = "//div[@controlname='Time to finish picking']//div//input";
        public IWebElement FillTimeToFinishPicking => Driver.FindElement(By.XPath(FillTimeToFinishPickingXpath));

        public const string EnterDateDeliveredOutboundXpath = "//div[@controlname='Date Delivered']//div//input";
        public IWebElement EnterDateDeliveredOutbound => Driver.FindElement(By.XPath(EnterDateDeliveredOutboundXpath));

        public const string EnterTimeDeliveredOutboundXpath = "//div[@controlname='Time Delivered']//div//input";
        public IWebElement EnterTimeDeliveredOutbound => Driver.FindElement(By.XPath(EnterTimeDeliveredOutboundXpath));

        public const string EnterCodeOutboundXpath = "//div[@controlname='Code']//div//input";
        //public const string EnterCodeOutboundXpath = "(//input[contains(@aria-label,'Code, ')])[3]";
        public IWebElement EnterCodeOutbound => Driver.FindElement(By.XPath(EnterCodeOutboundXpath));

        public const string EnterCodeOutboundInQueueGroupXpath = "//div[@controlname='ctrlCode']//div//input";

        public IWebElement EnterCodeOutboundInQueueGroup => Driver.FindElement(By.XPath(EnterCodeOutboundInQueueGroupXpath));

        public const string EnterGroupOutboundXpath = "//div[@class='ms-nav-group contains-only-additional-fields']//div[17]//div[1]//input[1]";
        public IWebElement EnterGroupOutbound => Driver.FindElement(By.XPath(EnterGroupOutboundXpath));

        public const string ClickORDEROutboundXpath = "//span[@title='Order']";
        public IWebElement ClickORDEROutbound => Driver.FindElement(By.XPath(ClickORDEROutboundXpath));

        public const string ChangePickingRouteOutboundXpath = "//span[contains(text(),'Change Picking Route')]";
        public IWebElement ChangePickingRouteOutbound => Driver.FindElement(By.XPath(ChangePickingRouteOutboundXpath));

        public const string EnterOrderLineOutboundXpath = "//td[@controlname='Order Line No Customer']//input";
        public IWebElement EnterOrderLineOutbound => Driver.FindElement(By.XPath(EnterOrderLineOutboundXpath));

        public const string EnterOrderLineOutbound2Xpath = "//input[starts-with(@aria-label,'Order Line No Customer')]";
        public IWebElement EnterOrderLineOutbound2 => Driver.FindElement(By.XPath(EnterOrderLineOutbound2Xpath));

        public const string IEnterPickingRouteXpath = "//input[starts-with(@aria-label,'Picking Route')]";
        public IWebElement IEnterPickingRoute => Driver.FindElement(By.XPath(IEnterPickingRouteXpath));

        public const string EnterItemInOutboundXpath = "//td[@controlname='Item']//input";
        public IWebElement EnterItemInOutbound => Driver.FindElement(By.XPath(EnterItemInOutboundXpath));

        public const string EnterItem2InOutboundXpath = "//input[starts-with(@aria-label,'Item')]";
        public IWebElement EnterItem2InOutbound => Driver.FindElement(By.XPath(EnterItem2InOutboundXpath));

        public const string BookingQtyOutboundXpath = "//td[@controlname='Booking Qty']//input";
        public IWebElement BookingQtyOutbound => Driver.FindElement(By.XPath(BookingQtyOutboundXpath));

        public const string ConfigurationInOutboundXpath = "//td[@controlname='Configuration']//input";
        public IWebElement ConfigurationInOutbound => Driver.FindElement(By.XPath(ConfigurationInOutboundXpath));

        public const string OrderLineOutboundXpath = "//a[@title='Actions for Lines']";
        public IWebElement OrderLineOutbound => Driver.FindElement(By.XPath(OrderLineOutboundXpath));

        public const string BookAllRecordsOutboundXpath = "//span[contains(text(),'Book all records')]";
        public IWebElement BookAllRecordsOutbound => Driver.FindElement(By.XPath(BookAllRecordsOutboundXpath));

        public const string OKBUTTONFROMPOPUPXpath = "//span[contains(text(),'OK')]";
        public IWebElement OKBUTTONFROMPOPUP => Driver.FindElement(By.XPath(OKBUTTONFROMPOPUPXpath));

        public const string CuttOffOutboundXpath = "//span[contains(text(),'Cut Off')]";
        public IWebElement CuttOffOutbound => Driver.FindElement(By.XPath(CuttOffOutboundXpath));

        public const string ManageOrderCutOffOutboundXpath = "(//span[@aria-label='Manage'][contains(.,'Manage')])[1]";
        public IWebElement ManageOrderCutOffOutbound => Driver.FindElement(By.XPath(ManageOrderCutOffOutboundXpath));

        public const string MoreOptionsCutOffXpath = "(//span[@aria-label='More options'][contains(.,'More options')])[3]";
        public IWebElement MoreOptionsCutOff => Driver.FindElement(By.XPath(MoreOptionsCutOffXpath));

        public const string SearchInOutboundXpath = "//div[contains(text(),'Search')]";
        public IWebElement SearchInOutbound => Driver.FindElement(By.XPath(SearchInOutboundXpath));

        public const string EditInOutboundXpath = "//span[@aria-label='Edit']";
        public IWebElement EditInOutbound => Driver.FindElement(By.XPath(EditInOutboundXpath));

        public const string GoBackFromOutboundXpath = "//button[(@data-is-focusable='true')and(@title='Back')]";
        public IWebElement GoBackFromOutbound => Driver.FindElement(By.XPath(GoBackFromOutboundXpath));

        public const string GoBackOutboundXpath = "//button[(@data-is-focusable='true')and(@title='Back')]";
        public IWebElement GoBackOutbound => Driver.FindElement(By.XPath(GoBackOutboundXpath));

        public const string GoBackFromOutboundListXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[2]/div/div/div[1]/button";
        public IWebElement GoBackFromOutboundList => Driver.FindElement(By.XPath(GoBackFromOutboundListXpath));

        public const string SetupMenuXpath = "//span[contains(text(),'Setup')]";
        public IWebElement SetupMenu => Driver.FindElement(By.XPath(SetupMenuXpath));

        public const string SchedulerInSetupXpath = "//button[@aria-label='Scheduler']";
        public IWebElement SchedulerInSetup => Driver.FindElement(By.XPath(SchedulerInSetupXpath));

        public const string NasSimulatorXpath = "//button[@aria-label='Nas Simulator']";
        public IWebElement NasSimulator => Driver.FindElement(By.XPath(NasSimulatorXpath));

       // public const string SchedulerFromSetupXpath = "//a[@aria-label='Scheduler']";
        public const string SchedulerFromSetupXpath = "//div[text()= 'Scheduler']";
        public IWebElement SchedulerFromSetup => Driver.FindElement(By.XPath(SchedulerFromSetupXpath));

        public const string SchedulerFromSetupADEOXpath = "//button[@aria-label='Scheduler']";
        public IWebElement SchedulerFromSetupADEO => Driver.FindElement(By.XPath(SchedulerFromSetupADEOXpath));

        public const string NasSimulatorClickADEOXpath = "//button[@aria-label='Nas Simulator']";
        public IWebElement NasSimulatorClickADEO => Driver.FindElement(By.XPath(NasSimulatorClickADEOXpath));

        public const string NasSimulatorFromSchedulerXpath = "//div[contains(text(),'Nas Simulator')]";
        public IWebElement NasSimulatorFromScheduler => Driver.FindElement(By.XPath(NasSimulatorFromSchedulerXpath));

        public const string FilterNasSimulatorXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[3]/div/div/div/div[1]/div[2]/div/div[3]/button/div/i";
        public IWebElement FilterNasSimulator => Driver.FindElement(By.XPath(FilterNasSimulatorXpath));

        public const string FilterPaneForInboundDeliveryXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[4]/div/div/div/div[1]/div[2]/div/div[4]/button";
        public IWebElement FilterPaneForInboundDelivery => Driver.FindElement(By.XPath(FilterPaneForInboundDeliveryXpath));

        public const string ClickCodeInFilterXpath = "//button[11]//div[1]//span[1]//span[1]";
        public IWebElement ClickCodeInFilter => Driver.FindElement(By.XPath(ClickCodeInFilterXpath));

        public const string AddFilterForInboundDeliveryXpath = "//span[contains(text(),'Inserted by EDI')]";
        public IWebElement AddFilterForInboundDelivery => Driver.FindElement(By.XPath(AddFilterForInboundDeliveryXpath));

        public const string ClickFromTypeDropDownMenuOnInboundDeliveryXpath = "/html/body/div[1]/div[5]/form/div[2]/div/div[1]/div/div[2]/table/tbody/tr/td[2]";
        public IWebElement ClickFromTypeDropDownMenuOnInboundDelivery => Driver.FindElement(By.XPath(ClickFromTypeDropDownMenuOnInboundDeliveryXpath));

        public const string ClickFromTypeDropDownMenuOnTransportInboundXpath = "/html/body/div[1]/div[5]/form/div[2]/div/div[1]/div/div[2]/table/tbody/tr[5]/td[2]";
        public IWebElement ClickFromTypeDropDownMenuOnTransportInbound => Driver.FindElement(By.XPath(ClickFromTypeDropDownMenuOnTransportInboundXpath));

        public const string ClickThreeDotsToEditInboundDeliveryXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[1]/div/div[2]/table/tbody/tr[1]/td[4]/a";
        public IWebElement ClickThreeDotsToEditInboundDelivery => Driver.FindElement(By.XPath(ClickThreeDotsToEditInboundDeliveryXpath));

        public const string ClickEditFromThreeDotsInInboundDeliveryXpath = ".//div[@class='ms-nav-ctxmenu-itemlabel']/following::span[contains(text(),'Edit')]";
        public IWebElement ClickEditFromThreeDotsInInboundDelivery => Driver.FindElement(By.XPath(ClickEditFromThreeDotsInInboundDeliveryXpath));

        public const string ClickViewFromThreeDotsInInboundDeliveryTableXpath = "//span[text()='View']";
        public IWebElement ClickViewFromThreeDotsInInboundDeliveryTable => Driver.FindElement(By.XPath(ClickViewFromThreeDotsInInboundDeliveryTableXpath));

        public const string EDIYesDropDownMenuXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[6]/div[2]/div[1]/div[2]/div/div[2]/div[2]/div/div/div[1]/div[2]/div[1]/div[2]/div[2]/select/option[3]";
        public IWebElement EDIYesDropDownMenu => Driver.FindElement(By.XPath(EDIYesDropDownMenuXpath));

        public const string FilterInboundDeliveryXpath = "//div[@class='filter-pane-content--1r-gKrqgvu-CWiejhmbnrZ']//div[1]//div[2]//div[2]//div[1]//div[1]//div[1]//button[1]//div[1]//div[1]//div[1]";
        public IWebElement FilterInboundDelivery => Driver.FindElement(By.XPath(FilterInboundDeliveryXpath));

        public const string FilterButtonInIndoundDeliveryXpath = ".//button[@aria-label='Add a new filter on a field']";
        public IWebElement FilterButtonInIndoundDelivery => Driver.FindElement(By.XPath(FilterButtonInIndoundDeliveryXpath));

        public const string StartupParameterXpath = "//span[contains(text(),'Startup Parameter')]";
        public IWebElement StartupParameter => Driver.FindElement(By.XPath(StartupParameterXpath));

        public const string EnterNasSimulatorFilterFieldXpath = "//div[@controlname='Startup Parameter']//input";
        public IWebElement EnterNasSimulatorFilterField => Driver.FindElement(By.XPath(EnterNasSimulatorFilterFieldXpath));

        public const string RunSelectedTasksNASButtonXpath = "//span[contains(text(),'RUN Selected Task')]";
        public IWebElement RunSelectedTasksNASButton => Driver.FindElement(By.XPath(RunSelectedTasksNASButtonXpath));

        public const string GoBackNasSimulatorXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[2]/div/div/div[1]/button";
        public IWebElement GoBackNasSimulator => Driver.FindElement(By.XPath(GoBackNasSimulatorXpath));

        public const string GeneralCss = "li[role='presentation'] a[aria-posinset='1']";
        public IWebElement General => Driver.FindElement(By.CssSelector(GeneralCss));

        public const string GivenIClickQueueGroupFromOperationalOverviewXpath = "//body/div/div/div/div/div/div/div/ul/li[2]/div[1]/div[1]/a[1]/div[1]";
        public IWebElement GivenIClickQueueGroupFromOperationalOverview => Driver.FindElement(By.XPath(GivenIClickQueueGroupFromOperationalOverviewXpath));

        public const string OpertionOverviewsXpath = "//span[contains(text(),'Operation Overviews')]";
        public IWebElement OperationOverviews => Driver.FindElement(By.XPath(OpertionOverviewsXpath));

        public const string BatchNumberQueueGroupListXpath = "(//td[@controlname='Batch Number' and @role='gridcell'])[1]//a";
        public IWebElement BatchNumberQueueGroupList => Driver.FindElement(By.XPath(BatchNumberQueueGroupListXpath));

        public const string DeleteBatchNumberXpath = "//button[@aria-label='Delete']";
        public IWebElement DeleteBatchNumber => Driver.FindElement(By.XPath(DeleteBatchNumberXpath));

        public const string MoreOptionsBatchTableXpath = "(//button[@aria-label='Show the rest']//span//i)[3]";
        public IWebElement MoreOptionsBatchTable => Driver.FindElement(By.XPath(MoreOptionsBatchTableXpath));

        public const string BatchNumberFromCardXpath = "//div[@controlname='Batch']//div//span";
        public IWebElement BatchNumberFromCard => Driver.FindElement(By.XPath(BatchNumberFromCardXpath));

        public const string EditInPOWBatchListXpath = "//button[@aria-label='Edit']";
        public IWebElement EditInPOWBatchList => Driver.FindElement(By.XPath(EditInPOWBatchListXpath));

        public const string OpenQueueGroupfromMainXpath = "//div[text()='QueueGroup']";
        public IWebElement OpenQueueGroupfromMain => Driver.FindElement(By.XPath(OpenQueueGroupfromMainXpath));

        public const string QueueGroupDropdownXpath = "//div[contains(text(),'QueueGroup')]";
        public IWebElement QueueGroupDropdown => Driver.FindElement(By.XPath(QueueGroupDropdownXpath));

        

            public const string CodeInQueueGroupXpath = "/html/body/div[1]/div[3]/form/main/div[2]/div[4]/div[2]/div/div/div[2]/div[3]/div/input";
        public IWebElement CodeInQueueGroup => Driver.FindElement(By.XPath(CodeInQueueGroupXpath));

        public const string ClickOperationOverviewsInMainMenuWithoutSwitchContentXpath = "//span[contains(text(),'Operation Overviews')]";
        public IWebElement ClickOperationOverviewsInMainMenuWithoutSwitchContent => Driver.FindElement(By.XPath(ClickOperationOverviewsInMainMenuWithoutSwitchContentXpath));

        public const string SelectDateCreatedXpath = "//input[starts-with(@title,'Type the date in the format')]";
        public IWebElement SelectDateCreated => Driver.FindElement(By.XPath(SelectDateCreatedXpath));

        public const string DateCreatedQueueGroupListXpath = "//input[@class='cursorinherit stringcontrol-edit thm-cont-u1-font-size thm-cont-u1-font-stack thm-cont-u1-color-2--minflat thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus thm-cont-h1-bdrcolor--hover thm-cont-h1-bdrcolor--prev-sib-hover hasDatepicker']";
        public IWebElement DateCreatedQueueGroupList => Driver.FindElement(By.XPath(DateCreatedQueueGroupListXpath));

        public const string FilterQueueGroupListXpath = "//button[@aria-label='Add a new filter on a field']";
        public IWebElement FilterQueueGroupList => Driver.FindElement(By.XPath(FilterQueueGroupListXpath));

        public const string FilterListByButtonXpath = "//span[contains(text(),'Filter list by...')]";
        public IWebElement FilterListByButton => Driver.FindElement(By.XPath(FilterListByButtonXpath));

        public const string IClickMoreOptionsNavMenuOutboundXpath = "//a[@title='Reveal secondary actions']";
        public IWebElement IClickMoreOptionsNavMenuOutbound => Driver.FindElement(By.XPath(IClickMoreOptionsNavMenuOutboundXpath));

        public const string IClickNavigateNavMenudXpath = "//a[@aria-label='Navigate']";
        public IWebElement IClickNavigateNavMenud => Driver.FindElement(By.XPath(IClickNavigateNavMenudXpath));

        public const string IClickBWNErrorXpath = "//a[@aria-label='BWN Error']";
        public IWebElement IClickBWNError => Driver.FindElement(By.XPath(IClickBWNErrorXpath));

        public const string IClickDetailsFromHeaderXpath = "//li[starts-with(@class,'ms-Context')]//a[(@aria-label='Details from Header')and(@data-is-focusable='true')]";
        public IWebElement IClickDetailsFromHeader => Driver.FindElement(By.XPath(IClickDetailsFromHeaderXpath));

        public const string EnterFilterQueueGroupListXpathTest = "//button[18]//div[1]";
        public IWebElement EnterFilterQueueGroupListTest => Driver.FindElement(By.XPath(EnterFilterQueueGroupListXpathTest));

        public const string EnterFilterQueueGroupListXpath = "//div[@class='edit-container ms-nav-editcontrolandonebuttoncontainer']//input[@class='cursorinherit stringcontrol-edit thm-cont-u1-font-size thm-cont-u1-font-stack thm-cont-u1-color-2--minflat thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus thm-cont-h1-bdrcolor--hover thm-cont-h1-bdrcolor--prev-sib-hover']";
        public IWebElement EnterFilterQueueGroupList => Driver.FindElement(By.XPath(EnterFilterQueueGroupListXpath));

        public const string InputFieldFilterQueueGroupListXpath = "//div[@class='edit-container ms-nav-editcontrolandonebuttoncontainer']//following::input[starts-with(@class,'cursorinherit')]";
        public IWebElement InputFieldFilterQueueGroupList => Driver.FindElement(By.XPath(InputFieldFilterQueueGroupListXpath));

        public const string InputFieldFilterBatchNumberListXpath = "//div[@controlname='Batch Number']//input";
        public IWebElement InputFieldFilterBatchNumberList => Driver.FindElement(By.XPath(InputFieldFilterBatchNumberListXpath));

        public const string InputBatchNumberValueXpath = "//div[@controlname='Batch Number']//input";
        public IWebElement InputBatchNumberValue => Driver.FindElement(By.XPath(InputBatchNumberValueXpath));

        public const string SearchFieldInTROUnlinkXpath = "//div[@tabindex='0']";
        public IWebElement SearchFieldInTROUnlink => Driver.FindElement(By.XPath(SearchFieldInTROUnlinkXpath));

        public const string InputFieldCustomerReferenceXpath = "//div[@controlname='Customer Reference']//input";
        public IWebElement InputFieldCustomerReference => Driver.FindElement(By.XPath(InputFieldCustomerReferenceXpath));

        public const string SecondQueueFieldXpath = "(//tr[@aria-rowindex='2'])[2]//td[1]";
        public IWebElement SecondQueueField => Driver.FindElement(By.XPath(InputFieldFilterQueueGroupListXpath));

        public const string LaunchOnQuegroupXpath = "//span[contains(text(),'Launch')]";
        public IWebElement LaunchOnQuegroup => Driver.FindElement(By.XPath(LaunchOnQuegroupXpath));

        public const string CreateReplenishmentQueuesXpath = "//span[contains(text(),'Create Replenishment Queues')]";
        public IWebElement CreateReplenishmentQueues => Driver.FindElement(By.XPath(CreateReplenishmentQueuesXpath));

        public const string createWaveXpath = "//span[contains(text(),'Create Wave')]";
        public IWebElement createWave => Driver.FindElement(By.XPath(createWaveXpath));

        public const string FirstLineInCodeInputXpath = "/html/ActionsQueueGroupXpath/div[1]/div[4]/form/div[2]/div/div[1]/div/div[2]/table/tbody/tr/td[2]";
        public IWebElement FirstLineInCodeInput => Driver.FindElement(By.XPath(FirstLineInCodeInputXpath));

        public const string ShowFilterPane_QueueGroupOutboundXpath = "//div[starts-with(@class,'ms-Focus')]//button[(@title='Show filter pane')and(@data-is-focusable='true')]";
        public IWebElement ShowFilterPane_QueueGroupOutbound => Driver.FindElement(By.XPath(ShowFilterPane_QueueGroupOutboundXpath));

        public const string LaunchOnQuegroupListAfterMultiOrderXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[4]/div/div/div/div[1]/div[2]/div/div[1]/div/div/div/div/div[5]/div/div/a/div/div[2]/span/span";
        public IWebElement LaunchOnQuegroupListAfterMultiOrder => Driver.FindElement(By.XPath(LaunchOnQuegroupListAfterMultiOrderXpath));

        public const string ClickYesToLaunchQueueGroupXpath = "//div[@class='spa-view spa-dialog no-animations shown']//button[1]";
        public IWebElement ClickYesToLaunchQueueGroup => Driver.FindElement(By.XPath(ClickYesToLaunchQueueGroupXpath));

        public const string CardQueueGroupListXpath = "//span[@aria-label='Card']";
        public IWebElement CardQueueGroupList => Driver.FindElement(By.XPath(CardQueueGroupListXpath));

        public const string CloseCardQueueGroupCardXpath = "/html/body/div[1]/div[4]/form/div[2]/div/div[4]/button[2]";
        public IWebElement CloseCardQueueGroupCard => Driver.FindElement(By.XPath(CloseCardQueueGroupCardXpath));
        ////span[contains(text(),'Close')]

        public const string BackFromQueueGroupListXpath = "//body/div/div/form/div/div/div/div/div/div/button/div/i[1]";
        public IWebElement BackFromQueueGroupList => Driver.FindElement(By.XPath(BackFromQueueGroupListXpath));

        public const string ManipulationMainMenuXpath = "//div[7]//ul[1]//li[2]";
        public IWebElement ManipulationMainMenu => Driver.FindElement(By.XPath(ManipulationMainMenuXpath));

        public const string SelectStockLBSDHeaderXpath = "//span[contains(text(),'Select Stock')]";
        public IWebElement SelectStockLBSDHeader => Driver.FindElement(By.XPath(SelectStockLBSDHeaderXpath));

        public const string LBSDHeaderXpath = "//a[contains(text(),'LB2SD Header')]";
        public IWebElement LBSDHeader => Driver.FindElement(By.XPath(LBSDHeaderXpath));

        public const string HolderBarcodeInputOnLBSDHeaderXpath = "//body//div//div//div//div//div//div//div//div//div[2]//div[2]//div[1]//div[2]//div[1]//input[1]";
        public IWebElement HolderBarcodeInputOnLBSDHeader => Driver.FindElement(By.XPath(HolderBarcodeInputOnLBSDHeaderXpath));

        public const string WriteJCommentSXpath = "//div//div//div//div//div//div//div//div//div//div//div//div//div//div//tr[1]//td[14]//input[1]";
        public IWebElement WriteJCommentS => Driver.FindElement(By.XPath(WriteJCommentSXpath));

        public const string WriteJLocationXpath = "//body//div//div//div//div//div//div//div//div//div//div//div//div//div//div//td[9]//input[1]";
        public IWebElement WriteJLocation => Driver.FindElement(By.XPath(WriteJLocationXpath));

        public const string WriteJTransferXpath = "//body//div//div//div//div//div//div//div//div//div//div//div//div//div//div//td[12]//input[1]";
        public IWebElement WriteJTransfer => Driver.FindElement(By.XPath(WriteJTransferXpath));

        public const string BookAllInManipulationLBSDHeaderXpath = "//body//div//div//div//div//div//div//div//div//div//div//div//div[1]//div[1]//div[1]//div[1]//div[1]//div[5]//div[1]//div[1]//a[1]//div[1]//div[2]";
        public IWebElement BookAllInManipulationLBSDHeader => Driver.FindElement(By.XPath(BookAllInManipulationLBSDHeaderXpath));

        public const string ShowMoreOptionsButtonXpath = "//div[@class='ms-nav-listform ms-nav-noCommandBar control-addin-form']//a[@class='ms-list-itemLink thm-cont-a2-icon-color--maxtint30--grid-row-selected thm-glob-c0-icon-color thm-cont-a2-icon-color--maxtint30--grid-row-selected--edit-mode-grid thm-cont-a2-icon-color-1--medtint30--edit-mode-grid thm-cont-a2-icon-color--medtint30--grid-row-hovered icon-VertEllipsis ms-nav-contextmenu-trigger']";
        public IWebElement ShowMoreOptionsButton => Driver.FindElement(By.XPath(ShowMoreOptionsButtonXpath));

        public const string SelectViewShowMoreOptionsXpath = "//span[contains(text(),'View')]";
        public IWebElement SelectViewShowMoreOptions => Driver.FindElement(By.XPath(SelectViewShowMoreOptionsXpath));

        public const string ClickPencilToEditXpath = "//button[@class='ms-Button ms-Button--icon action-button--23inG-h-t2FNoUkfgciN8y thm-cont-g0-bgcolor--states_is-disabled header-action-edit_view root-35']//i[@class='css-52 root-43 ms-Button-icon action-icon--2-bK1RA2hIAdWonQHpJueQ thm-head-c0-icon-color-1--minflat thm-head-c0-icon-color-1--mintint--hover thm-head-c0-icon-color-1--mintint--focus thm-head-c0-icon-color-2--medflat--active thm-head-c3-subd-color--medflat--states_is-disabled thm-cont-g0-bgcolor thm-head-s1-bgcolor--hover thm-head-s1-bgcolor--focus thm-head-g2-bgcolor-1--active thm-cont-g0-bgcolor--states_is-checked thm-head-g1-bdrcolor-1--states_is-checked icon-38']";
        public IWebElement ClickPencilToEdit => Driver.FindElement(By.XPath(ClickPencilToEditXpath));

        public const string ResetEDIMessageXpath = "//span[contains(text(),'Reset')]";
        public IWebElement ResetEDIMessage => Driver.FindElement(By.XPath(ResetEDIMessageXpath));

        public const string OverruleResetEdiMessageXpath = "//span[contains(text(),'Overrule')]";
        public IWebElement OverruleResetEdiMessage => Driver.FindElement(By.XPath(OverruleResetEdiMessageXpath));

        public const string InboundDeliveryMainPageXpath = "//a[contains(@title,'Inbound Deliveries')]";
        public IWebElement InboundDeliveryMainPage => Driver.FindElement(By.XPath(InboundDeliveryMainPageXpath));

        public const string NewTabInboundDeliveryXpath = "//div[@class='button-container--iUT6fwygh610UC-k6esrT command-bar-button-container--1ms9JCUCujkBljIx4C1GfY first-item--15AeWXqkjbAQCNaM3tqgcY']//div[@class='ms-Button-flexContainer flexContainer-48']";
        public IWebElement NewTabInboundDelivery => Driver.FindElement(By.XPath(NewTabInboundDeliveryXpath));

        public const string ClickTypeDropDownMenuInGeneralXpath = "//div[@class='ms-nav-layout-body thm-cont-g0-bgcolor-1']//div[5]//div[1]//a[1]";
        public IWebElement ClickTypeDropDownMenuInGeneral => Driver.FindElement(By.XPath(ClickTypeDropDownMenuInGeneralXpath));

        public const string ClickXDOCKFromTypeDropDownMenuInGeneralXpath = "//div[@class='spa-view spa-lookup no-animations shown']//tbody//tr[2]";
        public IWebElement ClickXDOCKFromTypeDropDownMenuInGeneral => Driver.FindElement(By.XPath(ClickXDOCKFromTypeDropDownMenuInGeneralXpath));

        public const string RefrenceCustomerTabXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[1]/div[2]/div/div[7]/div/input";
        public IWebElement RefrenceCustomerTab => Driver.FindElement(By.XPath(RefrenceCustomerTabXpath));

        public const string SupplierCodeTabInboundDeliveryXpath = "//div[19]//div[1]//input[1]";
        public IWebElement SupplierCodeTabInboundDelivery => Driver.FindElement(By.XPath(SupplierCodeTabInboundDeliveryXpath));

        public const string ClickAndEnterSupplierXpath = "//div[19]//div[1]//input[1]";
        public IWebElement ClickAndEnterSupplier => Driver.FindElement(By.XPath(ClickAndEnterSupplierXpath));

        public const string EditRefereneNameTextXpath = "//div[@class='spa-view spa-normal no-animations shown']//div[7]//div[1]//input[1]";
        public IWebElement EditRefereneNameText => Driver.FindElement(By.XPath(EditRefereneNameTextXpath));

        public const string EDIMessageLogDetailTableXpath = "/html[1]/body[1]/div[1]/div[4]/form[1]/div[1]/div[2]/div[5]/div[2]/div[2]/div[2]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/table[1]";
        public IWebElement SearchAndClickInCODEField => Driver.FindElement(By.XPath(EDIMessageLogDetailTableXpath));

        public const string ClickBackButtonToGoInInboundDeliveryTableXpath = "//button[(@data-is-focusable='true')and(@title='Back')]";
        public IWebElement ClickBackButtonToGoInInboundDeliveryTable => Driver.FindElement(By.XPath(ClickBackButtonToGoInInboundDeliveryTableXpath));

        public const string ClickBackButtonToMainPageXpath = "//button[(@data-is-focusable='true')and(@title='Back')]";
        public IWebElement ClickBackButtonToMainPage => Driver.FindElement(By.XPath(ClickBackButtonToMainPageXpath));

        public const string ClickOKButtonOfPopupMainPageXpath = "//span[text()='OK']";
        public IWebElement ClickOKButtonOfPopupMainPage => Driver.FindElement(By.XPath(ClickOKButtonOfPopupMainPageXpath));

        public const string ClickOKButtonOfPopupHolderErrorOKXpath = "(//span[text()='OK'])[1]";
        public IWebElement ClickOKButtonOfPopupHolderErrorOK => Driver.FindElement(By.XPath(ClickOKButtonOfPopupHolderErrorOKXpath));

        public const string ExpectedInboundDeliveryXpath = "//span[text() = 'Expected'][@aria-expanded='false']";
        public IWebElement ExpectedInboundDelivery => Driver.FindElement(By.XPath(ExpectedInboundDeliveryXpath));

        public const string ClickInExpectedDropdownXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[3]/div[2]/div/div/div[2]/div[2]/div[1]/div/a";
        public IWebElement ClickInExpectedDropdown => Driver.FindElement(By.XPath(ClickInExpectedDropdownXpath));

        public const string ClickNewLineInDropdownMenuOfExpectedXpath = "/html/body/div[1]/div[4]/form/div[1]/div/ul/li[2]";
        public IWebElement ClickNewLineInDropdownMenuOfExpected => Driver.FindElement(By.XPath(ClickNewLineInDropdownMenuOfExpectedXpath));

        public const string ClickDeleteLineInDropdownMenuOfExpectedXpath = "/html/body/div[1]/div[4]/form/div[1]/div/ul/li[3]";
        public IWebElement ClickDeleteLineInDropdownMenuOfExpected => Driver.FindElement(By.XPath(ClickDeleteLineInDropdownMenuOfExpectedXpath));

        public const string ClickExpectedOnTRIXpath = "//span[@aria-level='3'][text() = 'Expected']";
        public IWebElement ClickExpectedOnTRI => Driver.FindElement(By.XPath(ClickExpectedOnTRIXpath));

        public const string ClickLinesFromExpectedXpath = "//a[@title='Actions for Lines'][text() = 'Lines']";
        public IWebElement ClickLinesFromExpected => Driver.FindElement(By.XPath(ClickLinesFromExpectedXpath));

        public const string ClickViewLinkedInboundDeliveriesFromTheNavigationBarXpath = "//span[contains(text(),'View Linked Inbound Deliveries')]";
        public IWebElement ClickViewLinkedInboundDeliveriesFromTheNavigationBar => Driver.FindElement(By.XPath(ClickViewLinkedInboundDeliveriesFromTheNavigationBarXpath));

        public const string ClickDeleteOnTheNavigationBarXpath = "//div[@class='ms-nav-layout-content outside-layout-control-content--32h7-0URKQXt663GFl5oyN thm-cont-g3-bdrcolor--border-bottom thm-cont-g3-bdrcolor--border-top']//div[@class='horizontal-container--2LX45lJvEpVBsEWDsV7ZLY']//div[@class='root-container--2vh9Qp7XSmGLjYtqCtZgCl']//div[@class='inline-command-bar--394862WA-5d84gDcd3LVJb command-bar--3KojEqVkS_HxbjnLTNjY-R']//div[@class='ms-FocusZone action-list-control-container--tD-KGWsW0r6cLae6QXKX7']//div[@class='ms-ResizeGroup']//div[@class='horizontal-flex-container--luLZtBKrW2ChfnWRTk_uq']//div[@class='horizontal-flex-container-item-layout--paigVxanvxFrIsRy2U02r']//div//span[contains(text(),'Delete')]";
        public IWebElement ClickDeleteOnTheNavigationBar => Driver.FindElement(By.XPath(ClickDeleteOnTheNavigationBarXpath));

        public const string ClickYesInThePopUpMessageXpath = "//div[@class='dialog-action-bar']//span[text()='Yes']";
        public IWebElement ClickYesInThePopUpMessage => Driver.FindElement(By.XPath(ClickYesInThePopUpMessageXpath));

        public const string ClearFilterTextInSearchFieldTRIXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[4]/div/div/div/div[1]/div[2]/div/div[2]/div/div[2]/button/div/i";
        public IWebElement ClearFilterTextInSearchFieldTRI => Driver.FindElement(By.XPath(ClearFilterTextInSearchFieldTRIXpath));

        public const string CloseInboundDeliveryXpath = "/html/body/div[1]/div[5]/form/div[2]/div/div[4]/button[3]";
        public IWebElement CloseInboundDelivery => Driver.FindElement(By.XPath(CloseInboundDeliveryXpath));

        public const string ItemTabInboundDeliveryXpath = "//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//td[9]//input[1]";
        public IWebElement ItemTabInboundDelivery => Driver.FindElement(By.XPath(ItemTabInboundDeliveryXpath));

        public const string CountrTabInboundDeliveryXpath = "//td[@class='thm-cont-g3-bdrcolor--border-top thm-cont-g3-bdrcolor--border-right--edit-mode-grid thm-cont-g0-bgcolor thm-cont-h1-bgcolor--hover--edit-mode-grid thm-cont-g0-bgcolor--grid-row-selected thm-cont-h1-bgcolor--hover--grid-row-selected--edit-mode-grid edit-container ms-nav-editcontrolandonebuttoncontainer edit force-edit']//input[@class='cursorinherit stringcontrol-edit thm-cont-u1-font-size thm-cont-u1-font-stack thm-cont-u1-color-2--medflat thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus thm-cont-h1-bdrcolor--hover thm-cont-h1-bdrcolor--prev-sib-hover']";
        public IWebElement CountrTabInboundDelivery => Driver.FindElement(By.XPath(CountrTabInboundDeliveryXpath));

        public const string HolderUnitTabInboundDeliveryXpath = "//td[@class='thm-cont-g3-bdrcolor--border-top thm-cont-g3-bdrcolor--border-right--edit-mode-grid thm-cont-g0-bgcolor thm-cont-h1-bgcolor--hover--edit-mode-grid thm-cont-g0-bgcolor--grid-row-selected thm-cont-h1-bgcolor--hover--grid-row-selected--edit-mode-grid edit-container ms-nav-editcontrolandonebuttoncontainer edit']//input[@class='cursorinherit stringcontrol-edit thm-cont-u1-font-size thm-cont-u1-font-stack thm-cont-u1-color-2--medflat thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus thm-cont-h1-bdrcolor--hover thm-cont-h1-bdrcolor--prev-sib-hover']";
        public IWebElement HolderUnitTabInboundDelivery => Driver.FindElement(By.XPath(HolderUnitTabInboundDeliveryXpath));

        public const string InsertSKUInboundDeliveryXpath = "//td[@class='thm-cont-g3-bdrcolor--border-top thm-cont-g3-bdrcolor--border-right--edit-mode-grid thm-cont-g0-bgcolor thm-cont-h1-bgcolor--hover--edit-mode-grid thm-cont-g0-bgcolor--grid-row-selected thm-cont-h1-bgcolor--hover--grid-row-selected--edit-mode-grid edit-container right edit']//input[@class='cursorinherit stringcontrol-edit thm-cont-u1-font-size thm-cont-u1-font-stack thm-cont-u1-color-2--medflat thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus thm-cont-h1-bdrcolor--hover thm-cont-h1-bdrcolor--prev-sib-hover']";
        public IWebElement InsertSKUInboundDelivery => Driver.FindElement(By.XPath(InsertSKUInboundDeliveryXpath));

        public const string SKUUnitExpectedInboundDeliveryXpath = "//td[16]//input[1]";
        public IWebElement SKUUnitExpectedInboundDelivery => Driver.FindElement(By.XPath(SKUUnitExpectedInboundDeliveryXpath));

        public const string SKULineNoCustomerExpectedInboundDeliveryXpath = " //td[@class='thm-cont-g3-bdrcolor--border-top thm-cont-g3-bdrcolor--border-right--edit-mode-grid thm-cont-g0-bgcolor thm-cont-h1-bgcolor--hover--edit-mode-grid thm-cont-g0-bgcolor--grid-row-selected thm-cont-h1-bgcolor--hover--grid-row-selected--edit-mode-grid edit-container edit']//input[@class='cursorinherit stringcontrol-edit thm-cont-u1-font-size thm-cont-u1-font-stack thm-cont-u1-color-2--medflat thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus thm-cont-h1-bdrcolor--hover thm-cont-h1-bdrcolor--prev-sib-hover']";
        public IWebElement SKULineNoCustomerExpectedInboundDelivery => Driver.FindElement(By.XPath(SKULineNoCustomerExpectedInboundDeliveryXpath));

        public const string QualityCheckExpectedInboundDeliveryXpath = "//td[@class='thm-cont-g3-bdrcolor--border-top thm-cont-g3-bdrcolor--border-right--edit-mode-grid thm-cont-g0-bgcolor thm-cont-h1-bgcolor--hover--edit-mode-grid thm-cont-g0-bgcolor--grid-row-selected thm-cont-h1-bgcolor--hover--grid-row-selected--edit-mode-grid edit-container edit']//input[@class='cursorinherit stringcontrol-edit thm-cont-u1-font-size thm-cont-u1-font-stack thm-cont-u1-color-2--medflat thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus thm-cont-h1-bdrcolor--hover thm-cont-h1-bdrcolor--prev-sib-hover']";
        public IWebElement QualityCheckExpectedInboundDelivery => Driver.FindElement(By.XPath(QualityCheckExpectedInboundDeliveryXpath));

        public const string SupplierExpectedInboundDeliveryXpath = "//td[19]//input[1]";
        public IWebElement SupplierExpectedInboundDelivery => Driver.FindElement(By.XPath(SupplierExpectedInboundDeliveryXpath));

        public const string UniqueIDExpectedInboundDeliveryXpath = "//td[20]//input[1]";
        public IWebElement UniqueIDExpectedInboundDelivery => Driver.FindElement(By.XPath(UniqueIDExpectedInboundDeliveryXpath));

        public const string LotNOExpectedInboundDeliveryXpath = "//td[@class='thm-cont-g3-bdrcolor--border-top thm-cont-g3-bdrcolor--border-right--edit-mode-grid thm-cont-g0-bgcolor thm-cont-h1-bgcolor--hover--edit-mode-grid thm-cont-g0-bgcolor--grid-row-selected thm-cont-h1-bgcolor--hover--grid-row-selected--edit-mode-grid edit-container edit']//input[@class='cursorinherit stringcontrol-edit thm-cont-u1-font-size thm-cont-u1-font-stack thm-cont-u1-color-2--medflat thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus thm-cont-h1-bdrcolor--hover thm-cont-h1-bdrcolor--prev-sib-hover']";
        public IWebElement LotNOExpectedInboundDelivery => Driver.FindElement(By.XPath(LotNOExpectedInboundDeliveryXpath));

        public const string DateTabInboundDeliveryXpath = "//td[@class='thm-cont-g3-bdrcolor--border-top thm-cont-g3-bdrcolor--border-right--edit-mode-grid thm-cont-g0-bgcolor thm-cont-h1-bgcolor--hover--edit-mode-grid thm-cont-g0-bgcolor--grid-row-selected thm-cont-h1-bgcolor--hover--grid-row-selected--edit-mode-grid edit-container ms-nav-editcontrolandonebuttoncontainer edit']//input[@class='cursorinherit stringcontrol-edit thm-cont-u1-font-size thm-cont-u1-font-stack thm-cont-u1-color-2--medflat thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus thm-cont-h1-bdrcolor--hover thm-cont-h1-bdrcolor--prev-sib-hover hasDatepicker']";
        public IWebElement DateTabInboundDelivery => Driver.FindElement(By.XPath(DateTabInboundDeliveryXpath));

        public const string InboundDeliveryCodeXpath = "(//span[contains(@aria-label, 'Inbound Delivery no,')])[37]";
        public IWebElement InboundDeliveryCode => Driver.FindElement(By.XPath(InboundDeliveryCodeXpath));

        public const string AddFilterForEDIMessageLogListXpath = "//input[@data-is-interactable='true']";
        public IWebElement AddFilterForEDIMessageLogList => Driver.FindElement(By.XPath(AddFilterForEDIMessageLogListXpath));

        public const string EnterAsASubfilterForRecordTypeXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[1]/div[2]/div[2]/div[2]/div/div/div[1]/div[2]/div[1]/div/div[2]/input";
        public IWebElement EnterAsASubfilterForRecordType => Driver.FindElement(By.XPath(EnterAsASubfilterForRecordTypeXpath));

        public const string ClickFromTheTableKTNEDIMessageLogDetailXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[5]/input";
        public IWebElement ClickFromTheTableKTNEDIMessageLogDetail => Driver.FindElement(By.XPath(ClickFromTheTableKTNEDIMessageLogDetailXpath));

        public const string ModifyValuetextXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[7]/input";
        public IWebElement ModifyValuetext => Driver.FindElement(By.XPath(ModifyValuetextXpath));

        public const string AddSecondFilterForEDIMessageLogListXpath = "//body//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div[2]//div[2]//input[1]";
        public IWebElement AddSecondFilterForEDIMessageLogList => Driver.FindElement(By.XPath(AddSecondFilterForEDIMessageLogListXpath));

        public const string EnterSubfilterXpath = "//input[@aria-label='Message code, (Blank)']";
        public IWebElement EnterSubfilter => Driver.FindElement(By.XPath(EnterSubfilterXpath));

        public const string ClickFilterButtonOnEDIMessageLogListXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[6]/div[2]/div[1]/div[2]/div/div[2]/div[2]/div/div/div[1]/div[2]/div[2]/div/div/div/button/div/div/div";
        public IWebElement ClickFilterButtonOnEDIMessageLogList => Driver.FindElement(By.XPath(ClickFilterButtonOnEDIMessageLogListXpath));

        public const string ClickTheDropdownMenuFromFilterPaneInEDIMessageLogListXpath = "//div[(@data-is-focusable='true')and(@role='combobox')]";
        public IWebElement ClickTheDropdownMenuFromFilterPaneInEDIMessageLogList => Driver.FindElement(By.XPath(ClickTheDropdownMenuFromFilterPaneInEDIMessageLogListXpath));

        public const string ClickTheDropdownMenuFromFilterPaneInTransportInboundXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[5]/div[2]/div[1]/div[2]/div/div[2]/div/div/div[1]/div[2]/div[1]/div/div[2]/select";
        public IWebElement ClickTheDropdownMenuFromFilterPaneInTransportInbound => Driver.FindElement(By.XPath(ClickTheDropdownMenuFromFilterPaneInTransportInboundXpath));

        public const string ClickonTitleEDISendingXpath = "//span[contains(text(),'73961 POWER EDI Message Log Send L')]";
        public IWebElement ClickonTitleEDISending => Driver.FindElement(By.XPath(ClickonTitleEDISendingXpath));

        public const string AddRefernceFilterXpath = "//div[@controlname='Reference']//input";
        public IWebElement AddRefernceFilter => Driver.FindElement(By.XPath(AddRefernceFilterXpath));

        public const string AddItemCodeFilterXpath = "//div[@controlname='Code']//input";
        public IWebElement AddItemCodeFilter => Driver.FindElement(By.XPath(AddItemCodeFilterXpath));

        public const string ClickInsertedFromTheFilterDropdownMenuXpath = "//button//following::span[contains(text(),'Inserted')]";
        public IWebElement ClickInsertedFromTheFilterDropdownMenu => Driver.FindElement(By.XPath(ClickInsertedFromTheFilterDropdownMenuXpath));

        public const string ClickYesFromTheFilterDropdownMenuXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[5]/div[2]/div[1]/div[2]/div/div[2]/div/div/div[1]/div[2]/div[1]/div/div[2]/select/option[3]";
        public IWebElement ClickYesFromTheFilterDropdownMenu => Driver.FindElement(By.XPath(ClickYesFromTheFilterDropdownMenuXpath));

        public const string ClickEditFromTheNavigationBarXpath = "//button[@aria-label='Edit']";
        public IWebElement ClickEditFromTheNavigationBar => Driver.FindElement(By.XPath(ClickEditFromTheNavigationBarXpath));

        public const string HolderTabInOutboundCardXpath = "//span[text()='Holder']";
        public IWebElement HolderTabInOutboundCard => Driver.FindElement(By.XPath(HolderTabInOutboundCardXpath));

        public const string ClickPickHolderXpath = "//span[@title='Pick Holders']";
        public IWebElement ClickPickHolder => Driver.FindElement(By.XPath(ClickPickHolderXpath));

        public const string PrintMDGFXpath = "//span[text()='Generate Holder MDGF']";
        public IWebElement PrintMDGF => Driver.FindElement(By.XPath(PrintMDGFXpath));

        public const string ClickTheButtonToExpandTheTableKTNEDIMessageLogDetailXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[1]/div/div/div/div/div[1]/div/div/div[4]/button";
        public IWebElement ClickTheButtonToExpandTheTableKTNEDIMessageLogDetail => Driver.FindElement(By.XPath(ClickTheButtonToExpandTheTableKTNEDIMessageLogDetailXpath));

        public const string ClickShowFilterPaneForEdiMessageLogMainXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[3]/div[2]/div/div/div/div[1]/div[2]/div/div[3]/button";
        public IWebElement ClickShowFilterPaneForEdiMessageLogMain => Driver.FindElement(By.XPath(ClickShowFilterPaneForEdiMessageLogMainXpath));

        public const string ClickFilterButtonOnEDIMessageLogMainXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[1]/div[2]/div[2]/div[2]/div/div/div[1]/div[2]/div[2]/div/div/div/button";
        public IWebElement ClickFilterButtonOnEDIMessageLogMain => Driver.FindElement(By.XPath(ClickFilterButtonOnEDIMessageLogMainXpath));

        public const string ClickFilterButtonOnTransportInboundXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[5]/div[2]/div[1]/div[2]/div/div[2]/div/div/div[1]/div[2]/div[2]/div/div/div/button";
        public IWebElement ClickFilterButtonOnTransportInbound => Driver.FindElement(By.XPath(ClickFilterButtonOnTransportInboundXpath));

        public const string ClickTheThreeDotsOfTheFirstRowInEdiMessageLogMainXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[4]/a";
        public IWebElement ClickTheThreeDotsOfTheFirstRowInEdiMessageLogMain => Driver.FindElement(By.XPath(ClickTheThreeDotsOfTheFirstRowInEdiMessageLogMainXpath));

        public const string ClickNewLineXpath = "/html/body/div[1]/div[4]/form/div[1]/div/ul/li[1]/div";
        public IWebElement ClickNewLine => Driver.FindElement(By.XPath(ClickNewLineXpath));

        public const string AddRecordTypeAndCodeToTheAddedLineWithLineItemNumber1Xpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[5]";
        public IWebElement AddRecordTypeAndCodeToTheAddedLineWithLineItemNumber1 => Driver.FindElement(By.XPath(AddRecordTypeAndCodeToTheAddedLineWithLineItemNumber1Xpath));

        public const string ClickOnTheSecondRowOfTheTableInEdiMessageLogMainXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[2]/td[3]/span";
        public IWebElement ClickOnTheSecondRowOfTheTableInEdiMessageLogMain => Driver.FindElement(By.XPath(ClickOnTheSecondRowOfTheTableInEdiMessageLogMainXpath));

        public const string AddRecordTypeAndCodeToTheAddedLineWithLineItemNumberXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[5]/input";
        public IWebElement AddRecordTypeAndCodeToTheAddedLineWithLineItemNumber => Driver.FindElement(By.XPath(AddRecordTypeAndCodeToTheAddedLineWithLineItemNumberXpath));

        public const string AddRecordTypeMsgLogMainXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[3]/input";
        public IWebElement AddRecordTypeMsgLogMain => Driver.FindElement(By.XPath(AddRecordTypeMsgLogMainXpath));

        public const string ClickTheThreeDotsInItemNumberLineXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[4]/a";
        public IWebElement ClickTheThreeDotsInItemNumberLine => Driver.FindElement(By.XPath(ClickTheThreeDotsInItemNumberLineXpath));

        public const string EdiLogTableXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table";
        public IWebElement EdiLogTable => Driver.FindElement(By.XPath(EdiLogTableXpath));

        public const string DeleteValuesOfAllLineItemNumberXpath = "//div[@class='spa-view spa-normal no-animations shown']//tr[22]//td[7]";
        public IWebElement DeleteValuesOfAllLineItemNumber => Driver.FindElement(By.XPath(DeleteValuesOfAllLineItemNumberXpath));

        public const string ClickValuetextOfFileActionAndChangeItsValueXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[7]/input";
        public IWebElement ClickValuetextOfFileActionAndChangeItsValue => Driver.FindElement(By.XPath(ClickValuetextOfFileActionAndChangeItsValueXpath));

        public const string ClickValuetextOfTYPINBOUNDAndChangeItsValue1Xpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[4]/td[7]/span";
        public IWebElement ClickValuetextOfTYPINBOUNDAndChangeItsValue1 => Driver.FindElement(By.XPath(ClickValuetextOfTYPINBOUNDAndChangeItsValue1Xpath));

        public const string ClickValuetextOfTYPINBOUNDAndDELETEItsValueXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[4]/td[7]/input";
        public IWebElement ClickValuetextOfTYPINBOUNDAndDELETEItsValue => Driver.FindElement(By.XPath(ClickValuetextOfTYPINBOUNDAndDELETEItsValueXpath));

        public const string ClickValuetextOfTYPINBOUNDAndDELETEItsValue1Xpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[4]/td[7]/span";
        public IWebElement ClickValuetextOfTYPINBOUNDAndDELETEItsValue1 => Driver.FindElement(By.XPath(ClickValuetextOfTYPINBOUNDAndDELETEItsValue1Xpath));

        public const string ClickValuetextOfTYPINBOUNDAndChangeItsValueXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[4]/td[7]/input";
        public IWebElement ClickValuetextOfTYPINBOUNDAndChangeItsValue => Driver.FindElement(By.XPath(ClickValuetextOfTYPINBOUNDAndChangeItsValueXpath));

        public const string ClickValuetextOfFileActionAndDELETEItsValueXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[7]/input";
        public IWebElement ClickValuetextOfFileActionAndDELETEItsValue => Driver.FindElement(By.XPath(ClickValuetextOfFileActionAndDELETEItsValueXpath));

        public const string ClickValuetextOfCustomerReferenceAndChangeItsValue1Xpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[2]/td[7]/span";
        public IWebElement ClickValuetextOfCustomerReferenceAndChangeItsValue1 => Driver.FindElement(By.XPath(ClickValuetextOfCustomerReferenceAndChangeItsValue1Xpath));

        public const string ClickValuetextOfCustomerReferenceAndChangeItsValueXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[2]/td[7]/input";
        public IWebElement ClickValuetextOfCustomerReferenceAndChangeItsValue => Driver.FindElement(By.XPath(ClickValuetextOfCustomerReferenceAndChangeItsValueXpath));

        public const string ClickValuetextOfDatePlannedAndDELETEItsValue1Xpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[5]/td[7]/span";
        public IWebElement ClickValuetextOfDatePlannedAndDELETEItsValue1 => Driver.FindElement(By.XPath(ClickValuetextOfDatePlannedAndDELETEItsValue1Xpath));

        public const string ClickValuetextOfDatePlannedAndDELETEItsValueXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[5]/td[7]/input";
        public IWebElement ClickValuetextOfDatePlannedAndDELETEItsValue => Driver.FindElement(By.XPath(ClickValuetextOfDatePlannedAndDELETEItsValueXpath));

        public const string ClickValuetextOfDatePlannedAndChangeItsValue1Xpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[5]/td[7]/span";
        public IWebElement ClickValuetextOfDatePlannedAndChangeItsValue1 => Driver.FindElement(By.XPath(ClickValuetextOfDatePlannedAndChangeItsValue1Xpath));

        public const string ClickValuetextOfDatePlannedAndChangeItsValueXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[5]/td[7]/input";
        public IWebElement ClickValuetextOfDatePlannedAndChangeItsValue => Driver.FindElement(By.XPath(ClickValuetextOfDatePlannedAndChangeItsValueXpath));

        public const string ClickValuetextOfItemNumberAndChangeItsValue1Xpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[7]/span";
        public IWebElement ClickValuetextOfItemNumberAndChangeItsValue1 => Driver.FindElement(By.XPath(ClickValuetextOfItemNumberAndChangeItsValue1Xpath));

        public const string ClickValuetextOfItemNumberAndChangeItsValueXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[7]/input";
        public IWebElement ClickValuetextOfItemNumberAndChangeItsValue => Driver.FindElement(By.XPath(ClickValuetextOfItemNumberAndChangeItsValueXpath));

        public const string ClickValuetextOfQuantityAndChangeItsValue1Xpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[7]/span";
        public IWebElement ClickValuetextOfQuantityAndChangeItsValue1 => Driver.FindElement(By.XPath(ClickValuetextOfQuantityAndChangeItsValue1Xpath));

        public const string ClickValuetextOfQuantityAndChangeItsValueXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[7]/input";
        public IWebElement ClickValuetextOfQuantityAndChangeItsValue => Driver.FindElement(By.XPath(ClickValuetextOfQuantityAndChangeItsValueXpath));

        public const string ClickValuetextOfItemLinesAndChangeItsValueXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[19]/td[7]/input";
        public IWebElement ClickValuetextOfItemLinesAndChangeItsValue => Driver.FindElement(By.XPath(ClickValuetextOfItemLinesAndChangeItsValueXpath));

        public const string ClickValuetextOfSupplierAndChangeItsValue1Xpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[8]/td[7]/span";
        public IWebElement ClickValuetextOfSupplierAndChangeItsValue1 => Driver.FindElement(By.XPath(ClickValuetextOfSupplierAndChangeItsValue1Xpath));

        public const string ClickValuetextOfSupplierAndChangeItsValueXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[8]/td[7]/input";
        public IWebElement ClickValuetextOfSupplierAndChangeItsValue => Driver.FindElement(By.XPath(ClickValuetextOfSupplierAndChangeItsValueXpath));

        public const string ClickValuetextOfBlockingInformationAndChangeItsValue1Xpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[4]/td[7]/input";
        public IWebElement ClickValuetextOfBlockingInformationAndChangeItsValue1 => Driver.FindElement(By.XPath(ClickValuetextOfBlockingInformationAndChangeItsValue1Xpath));

        public const string ClickValuetextOfBlockingInformationAndChangeItsValueXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[4]/td[7]/input";
        public IWebElement ClickValuetextOfBlockingInformationAndChangeItsValue => Driver.FindElement(By.XPath(ClickValuetextOfBlockingInformationAndChangeItsValueXpath));

        public const string ClickValuetextOfCustomerReferenceAndDELETEItsValue1Xpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[2]/td[7]/span";
        public IWebElement ClickValuetextOfCustomerReferenceAndDELETEItsValue1 => Driver.FindElement(By.XPath(ClickValuetextOfCustomerReferenceAndDELETEItsValue1Xpath));

        public const string ClickValuetextOfCustomerReferenceAndDELETEItsValueXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[2]/td[7]/input";
        public IWebElement ClickValuetextOfCustomerReferenceAndDELETEItsValue => Driver.FindElement(By.XPath(ClickValuetextOfCustomerReferenceAndDELETEItsValueXpath));

        public const string ClickValuetextXpath = "/html/body/div[1]/div[2]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div";
        public IWebElement ClickValuetext => Driver.FindElement(By.XPath(ClickValuetextXpath));

        public const string ChangeItsValueXpath = "/html/body/div[1]/div[2]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div";
        public IWebElement ChangeItsValue => Driver.FindElement(By.XPath(ChangeItsValueXpath));

        public const string ClickBackButtonFromEDIMessageLogMainXpath = "//body/div/div[4]/form[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/button[1]/div[1]/i[1]";
        public IWebElement ClickBackButtonFromEDIMessageLogMain => Driver.FindElement(By.XPath(ClickBackButtonFromEDIMessageLogMainXpath));

        public const string ClickValuetextOfLineItemNumberAndChangeItsValue1Xpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[2]/td[7]/span";
        public IWebElement ClickValuetextOfLineItemNumberAndChangeItsValue1 => Driver.FindElement(By.XPath(ClickValuetextOfLineItemNumberAndChangeItsValue1Xpath));

        public const string ClickValuetextOfLineItemNumberAndChangeItsValueXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[2]/td[7]/input";
        public IWebElement ClickValuetextOfLineItemNumberAndChangeItsValue => Driver.FindElement(By.XPath(ClickValuetextOfLineItemNumberAndChangeItsValueXpath));

        public const string ClickResetFromTheNavigationBarXpath = "//span[contains(text(),'Reset')]";
        public IWebElement ClickResetFromTheNavigationBar => Driver.FindElement(By.XPath(ClickResetFromTheNavigationBarXpath));

        public const string ClickOverruleXpath = "//span[contains(text(),'Overrule')]";
        public IWebElement ClickOverrule => Driver.FindElement(By.XPath(ClickOverruleXpath));

        public const string ClickBackButtonToGoToMainPageXpath = "//body/div/div/form/div/div/div/div/div/div/button/div/i[1]";
        public IWebElement ClickBackButtonToGoToMainPage => Driver.FindElement(By.XPath(ClickBackButtonToGoToMainPageXpath));

        public const string ClickRunPOWEREDIManagerXpath = "/html/body/div[3]/div/div/div/div/div/div/ul/li[10]/div/div/a";
        public IWebElement ClickRunPOWEREDIManager => Driver.FindElement(By.XPath(ClickRunPOWEREDIManagerXpath));

        public const string ClickEDIFromTheNavogationBarXpath = "//span[@aria-label='EDI']";
        public IWebElement ClickEDIFromTheNavogationBar => Driver.FindElement(By.XPath(ClickEDIFromTheNavogationBarXpath));

        public const string ClickMessageLogSendingXpath = "//div[text()='Message Log Sending']";
        public IWebElement ClickMessageLogSending => Driver.FindElement(By.XPath(ClickMessageLogSendingXpath));

        public const string TransportInboundCodeXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[1]/div[2]/div/div[1]/div/span";
        public IWebElement TransportInboundCode => Driver.FindElement(By.XPath(TransportInboundCodeXpath));

        public const string ClickInStockMasterXpath = "//span[@aria-level='3'][text() = 'In Stock (Master)']";
        public IWebElement ClickInStockMaster => Driver.FindElement(By.XPath(ClickInStockMasterXpath));

        public const string ClickBackButtonXpath = "/html/body/div[1]/div[6]/form/div/div[2]/div[1]/div/div/div[1]/button/div/i";
        public IWebElement ClickBackButton => Driver.FindElement(By.XPath(ClickBackButtonXpath));

        public const string GoBackFromInboundDeliveryMainXpath = "//body/div/div[4]/form[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/button[1]/div[1]/i[1]";
        public IWebElement GoBackFromInboundDeliveryMain => Driver.FindElement(By.XPath(GoBackFromInboundDeliveryMainXpath));

        public const string GoBackFromInboundDeliveryListXpath = "//button[(@data-is-focusable='true')and(@title='Back')]";
        public IWebElement GoBackFromInboundDeliveryList => Driver.FindElement(By.XPath(GoBackFromInboundDeliveryListXpath));

        public const string TRIMainPageXpath = "/html/body/div[1]/div[2]/form/div/div[2]/main/div[2]/div/div/div[4]/div[2]/div/div[3]/div/div/ul/li[2]/div/div/div/a";
        public IWebElement TRIMainPage => Driver.FindElement(By.XPath(TRIMainPageXpath));

        public const string ClickSearchFromTheNavigationBarXpath = "//div[contains(@class,'search-box-container')]";
        public IWebElement ClickSearchFromTheNavigationBar => Driver.FindElement(By.XPath(ClickSearchFromTheNavigationBarXpath));

        public const string ClickShowFilterPaneForTransportInboundXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[3]/div/div/div/div[1]/div[2]/div/div[3]/button";
        public IWebElement ClickShowFilterPaneForTransportInbound => Driver.FindElement(By.XPath(ClickShowFilterPaneForTransportInboundXpath));

        public const string ClickStartDateToFilterTheTableInNasSimulatorXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[1]/div/div[1]/table/thead/tr/th[10]/div[1]/a";
        public IWebElement ClickStartDateToFilterTheTableInNasSimulator => Driver.FindElement(By.XPath(ClickStartDateToFilterTheTableInNasSimulatorXpath));

        public const string ClickRUNSelectedTaskFromTheNavigationBarXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[3]/div/div/div/div[1]/div[2]/div/div[2]/div/div/div/div/div[4]/div/div/a";
        public IWebElement ClickRUNSelectedTaskFromTheNavigationBar => Driver.FindElement(By.XPath(ClickRUNSelectedTaskFromTheNavigationBarXpath));

        public const string ClickBackButtonFromPowerNasSimulatorXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[1]/div/div/div[1]/button/div";
        public IWebElement ClickBackButtonFromPowerNasSimulator => Driver.FindElement(By.XPath(ClickBackButtonFromPowerNasSimulatorXpath));

        public const string SearchForInNasSimulatorXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[3]/div/div/div/div[1]/div[2]/div/div[1]";
        public IWebElement SearchForInNasSimulator => Driver.FindElement(By.XPath(SearchForInNasSimulatorXpath));

        public const string PasteTRIvarFromTRITableXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[4]/div/div/div/div[1]/div[2]/div/div[2]/div[1]";
        public IWebElement PasteTRIvarFromTRITable => Driver.FindElement(By.XPath(PasteTRIvarFromTRITableXpath));

        public const string SearchForTRICodeXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[3]/div/div/div/div[1]/div[2]/div/div[1]";
        public IWebElement SearchForTRICode => Driver.FindElement(By.XPath(SearchForTRICodeXpath));

        public const string ClickEditFromTheNavigationBarInTransportInboundXpath = "//span[text()='Edit']";
        public IWebElement ClickEditFromTheNavigationBarInTransportInbound => Driver.FindElement(By.XPath(ClickEditFromTheNavigationBarInTransportInboundXpath));

        public const string ClickReportsInTransportOutboundXpath = "//span[@aria-label='Reports']";

        public IWebElement ClickReportsInTransportOutbound => Driver.FindElement(By.XPath(ClickReportsInTransportOutboundXpath));

        public const string ClickEditFromTheNavigationBarInEDIMESSAGELOGLISTXpath = "//span[@aria-label='Edit']";
        public IWebElement ClickEditFromTheNavigationBarInEDIMESSAGELOGLIST => Driver.FindElement(By.XPath(ClickEditFromTheNavigationBarInEDIMESSAGELOGLISTXpath));

        public const string ClickProcessFromTheNavigationBarInEDIMESSAGELOGLISTXpath = "//span[@aria-label='Process']";
        public IWebElement ClickProcessFromTheNavigationBarInEDIMESSAGELOGLIST => Driver.FindElement(By.XPath(ClickProcessFromTheNavigationBarInEDIMESSAGELOGLISTXpath));

        public const string ClickLoadingOrderFromReportsTROXpath = "//span[@aria-label='Loading Order']";

        public IWebElement ClickLoadingOrderFromReportsTRO => Driver.FindElement(By.XPath(ClickLoadingOrderFromReportsTROXpath));

        public const string ClickPrintFromLoadingOrderXpath = "(//div[@class='ms-nav-actionbar-container has-actions'])//button[2]";

        public IWebElement ClickPrintFromLoadingOrder => Driver.FindElement(By.XPath(ClickPrintFromLoadingOrderXpath));

        public const string TransportButtonInTROXpath = "(//span[@aria-label='Transport'])[2]";
        public IWebElement TransportButtonInTRO => Driver.FindElement(By.XPath(TransportButtonInTROXpath));

        public const string POWCreateNewTROsFromTheListXpath = "//span[contains(text(),'POWCreateNewTROs')]";
        public IWebElement POWCreateNewTROsFromTheList => Driver.FindElement(By.XPath(POWCreateNewTROsFromTheListXpath));

        public const string PrintInReportsXpath = "//span[@aria-label='Print']";
        public IWebElement PrintInReports => Driver.FindElement(By.XPath(PrintInReportsXpath));

        public const string ImportRadioButtonXpath = "//input[@type='radio'][@title='Import']";
        public IWebElement ImportRadioButton => Driver.FindElement(By.XPath(ImportRadioButtonXpath));

        public const string ChooseFileXpath = "//a[@title='Choose file']";
        public IWebElement ChooseFile => Driver.FindElement(By.XPath(ChooseFileXpath));

        public const string GoBackToMainPageAfterImportingFileXpath = "//i[@data-icon-name='Back']";
        public IWebElement GoBackToMainPageAfterImportingFile => Driver.FindElement(By.XPath(GoBackToMainPageAfterImportingFileXpath));

        public const string ClickResetFromTheNavigationBarInEDIMESSAGELOGLISTXpath = "//span[@aria-label='Reset']";
        public IWebElement ClickResetFromTheNavigationBarInEDIMESSAGELOGLIST => Driver.FindElement(By.XPath(ClickResetFromTheNavigationBarInEDIMESSAGELOGLISTXpath));

        public const string ClickShowFilterPaneForEDIMessageLogListSecondTimeXpath = "//button[@aria-label='Toggle filter']";
        public IWebElement ClickShowFilterPaneForEDIMessageLogListSecondTime => Driver.FindElement(By.XPath(ClickShowFilterPaneForEDIMessageLogListSecondTimeXpath));

        public const string SelectOverruleFromResetMenuXpath = ".//span[contains(@aria-label,'Overrule')]";
        public IWebElement SelectOverruleFromResetMenu => Driver.FindElement(By.XPath(SelectOverruleFromResetMenuXpath));

        public const string SelectDeleteFromProcessMenuXpath = "//span[contains(@aria-label,'Delete')]";
        public IWebElement SelectDeleteFromProcessMenu => Driver.FindElement(By.XPath(SelectDeleteFromProcessMenuXpath));

        public const string NewTRIXpath = ".//span[contains(text(),'New')]";
        public IWebElement NewTRI => Driver.FindElement(By.XPath(NewTRIXpath));

        public const string ShowMoreInInboundXpath = "(//button[text()='Show more'])[1]";
        public IWebElement ShowMoreInInbound => Driver.FindElement(By.XPath(ShowMoreInInboundXpath));

        public const string ReferenceDateTimeTRIXpath = "//div[@class='collapsibleTab']//div[2]//div[2]//div[5]//div[1]//input[1]";
        public IWebElement ReferenceDateTimeTRI => Driver.FindElement(By.XPath(ReferenceDateTimeTRIXpath));

        public const string ReferenceDateTimeEDIXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[2]/td[7]/input";
        public IWebElement ReferenceDateTimeEDI => Driver.FindElement(By.XPath(ReferenceDateTimeEDIXpath));

        public const string ClickOnMessageCodeEDIXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[1]/div[2]/div/div[1]/div/span";
        public IWebElement ClickOnMessageCodeEDI => Driver.FindElement(By.XPath(ClickOnMessageCodeEDIXpath));

        public const string ClickModeEDIXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[9]/td[6]/input";
        public IWebElement ClickModeEDI => Driver.FindElement(By.XPath(ClickModeEDIXpath));

        public const string ReferenceDateTimeEDI1Xpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[2]/td[7]/span";
        public IWebElement ReferenceDateTimeEDI1 => Driver.FindElement(By.XPath(ReferenceDateTimeEDI1Xpath));

        public const string EnterCodeTRIXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[1]/div[2]/div/div[3]/div[2]/div[1]/div/input";
        public IWebElement EnterCodeTRI => Driver.FindElement(By.XPath(EnterCodeTRIXpath));

        public const string DateExpectedTRIXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[1]/div[2]/div/div[6]/div/input";
        public IWebElement DateExpectedTRI => Driver.FindElement(By.XPath(DateExpectedTRIXpath));

        public const string EnterOnCharterCodeInTRIXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[1]/div[2]/div/div[5]/div[2]/div[1]/div/input";
        public IWebElement EnterOnCharterCodeInTRI => Driver.FindElement(By.XPath(EnterOnCharterCodeInTRIXpath));

        public const string EnterCustomerCodeXpath = "//*[@aria-label='Code, ']";
        public IWebElement EnterCustomerCode => Driver.FindElement(By.XPath(EnterCustomerCodeXpath));

        public const string DeleteConfigFieldInInStockMasterXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[5]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[19]/input";
        public IWebElement DeleteConfigFieldInInStockMaster => Driver.FindElement(By.XPath(DeleteConfigFieldInInStockMasterXpath));

        public const string ChangeSkuToInExpectedXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[4]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[16]/input";
        public IWebElement ChangeSkuToInExpected => Driver.FindElement(By.XPath(ChangeSkuToInExpectedXpath));

        public const string ItemDescriptionXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[4]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[13]/span";
        public IWebElement ItemDescription => Driver.FindElement(By.XPath(ItemDescriptionXpath));

        public const string SkuExpextedXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[5]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[22]/span";
        public IWebElement SkuExpexted => Driver.FindElement(By.XPath(SkuExpextedXpath));

        public const string TimeExpectedTRIXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[1]/div[2]/div/div[7]/div/input";
        public IWebElement TimeExpectedTRI => Driver.FindElement(By.XPath(TimeExpectedTRIXpath));

        public const string TypeCodeTRIXpath = "//div//div//div[4]//div[2]//div[5]//div[1]//input[1]";
        public IWebElement TypeCodeTRI => Driver.FindElement(By.XPath(TypeCodeTRIXpath));

        public const string ClickFromTypeDropdownTRIXpath = "//div//div//div[4]//div[2]//div[5]//div[1]//input[1]";
        public IWebElement ClickFromTypeDropdownTRI => Driver.FindElement(By.XPath(ClickFromTypeDropdownTRIXpath));

        public const string ClickInEmployeeDropdownMenuFromDischargersXpath = "/html/body/div[1]/div[5]/form/div[2]/div/div[3]/div[1]/div/div[3]/div/div[2]/table/tbody/tr[1]/td[3]/input";
        public IWebElement ClickInEmployeeDropdownMenuFromDischargers => Driver.FindElement(By.XPath(ClickInEmployeeDropdownMenuFromDischargersXpath));

        public const string ClickDischargersFromNavigationBarXpath = "//span[contains(text(),'Dischargers')]";
        public IWebElement ClickDischargersFromNavigationBar => Driver.FindElement(By.XPath(ClickDischargersFromNavigationBarXpath));

        public const string TRUCKDropdownTypeTRIXpath = "//div[@class='spa-view spa-lookup no-animations shown']//tr[5]//td[2]";
        public IWebElement TRUCKDropdownTypeTRI => Driver.FindElement(By.XPath(TRUCKDropdownTypeTRIXpath));

        public const string OriginDestTRIXpath = "//span[contains(text(),'Origin/Dest')]";
        public IWebElement OriginDestTRI => Driver.FindElement(By.XPath(OriginDestTRIXpath));

        public const string ClickCustomsInTRIXpath = "//span[contains(text(),'Customs')]";
        public IWebElement ClickCustomsInTRI => Driver.FindElement(By.XPath(ClickCustomsInTRIXpath));

        public const string EnterItemInInStockMasterXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[5]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[14]/input";
        public IWebElement EnterItemInInStockMaster => Driver.FindElement(By.XPath(EnterItemInInStockMasterXpath));

        public const string EnterCodeInOriginDestInTRIXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[3]/div[2]/div/div/div[2]/div[1]/div/input";
        public IWebElement EnterCodeInOriginDestInTRI => Driver.FindElement(By.XPath(EnterCodeInOriginDestInTRIXpath));

        public const string EnterOriginCodeDestFromTRIXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[3]/div[2]/div/div/div[2]/div[1]/div/input";
        public IWebElement EnterOriginCodeDestFromTRI => Driver.FindElement(By.XPath(EnterOriginCodeDestFromTRIXpath));

        public const string InputCodeOriginDestTRIXpath = "/html[1]/body[1]/div[1]/div[4]/form[1]/div[1]/div[2]/div[5]/div[2]/div[2]/div[2]/div[1]/div[3]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/input[1]";
        public IWebElement InputCodeOriginDestTRI => Driver.FindElement(By.XPath(InputCodeOriginDestTRIXpath));

        public const string LinkINBOUNDDeliveriesXpath = ".//span[contains(text(),'Link Inbound Deliveries')]";
        public IWebElement LinkINBOUNDDeliveries => Driver.FindElement(By.XPath(LinkINBOUNDDeliveriesXpath));

        public const string LinkMultipleINBOUNDDeliveriesXpath = "//div[@class='nav-bar-area-box']//div[6]";
        public IWebElement LinkMultipleINBOUNDDeliveries => Driver.FindElement(By.XPath(LinkMultipleINBOUNDDeliveriesXpath));

        public const string ClickSetStatusCancelledFromTheNavigationBarXpath = "//span[contains(@aria-label, 'Set Status: Cancelled')]";
        public IWebElement ClickSetStatusCancelledFromTheNavigationBar => Driver.FindElement(By.XPath(ClickSetStatusCancelledFromTheNavigationBarXpath));

        public const string LinkMultipleInboundDeliveriesXpath = ".//span[contains(text(),'Link Inbound Deliveries')]";
        public IWebElement LinkMultipleInboundDeliveries => Driver.FindElement(By.XPath(LinkMultipleInboundDeliveriesXpath));

        public const string NewMultipleLinkIBDXpath = "//div[@class='outside-layout-control-content--32h7-0URKQXt663GFl5oyN thm-cont-g3-bdrcolor--border-bottom thm-cont-g3-bdrcolor--border-top']//div[@class='horizontal-container--2LX45lJvEpVBsEWDsV7ZLY']//div[@class='root-container--2vh9Qp7XSmGLjYtqCtZgCl']//div[@class='inline-command-bar--394862WA-5d84gDcd3LVJb command-bar--3KojEqVkS_HxbjnLTNjY-R']//div[@class='ms-FocusZone action-list-control-container--tD-KGWsW0r6cLae6QXKX7']//div[@class='ms-ResizeGroup']//div[@class='horizontal-flex-container--luLZtBKrW2ChfnWRTk_uq']//div[@class='horizontal-flex-container-item-layout--paigVxanvxFrIsRy2U02r']//div//span[contains(text(),'New')]";
        public IWebElement NewMultipleLinkIBD => Driver.FindElement(By.XPath(NewMultipleLinkIBDXpath));

        public const string LINKSELECTEDXpath = "//span[contains(@aria-label,'Link selected')]";
        public IWebElement LINKSELECTED => Driver.FindElement(By.XPath(LINKSELECTEDXpath));

        public const string ExpectedItemXpath = "//td[@class='thm-cont-g3-bdrcolor--border-top thm-cont-g3-bdrcolor--border-right--edit-mode-grid thm-cont-g0-bgcolor thm-cont-h1-bgcolor--hover--edit-mode-grid thm-cont-g0-bgcolor--grid-row-selected thm-cont-h1-bgcolor--hover--grid-row-selected--edit-mode-grid edit-container ms-nav-editcontrolandtwobuttoncontainer edit']//input[@class='cursorinherit stringcontrol-edit thm-cont-u1-font-size thm-cont-u1-font-stack thm-cont-u1-color-2--medflat thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus thm-cont-h1-bdrcolor--hover thm-cont-h1-bdrcolor--prev-sib-hover']";
        public IWebElement ExpectedItem => Driver.FindElement(By.XPath(ExpectedItemXpath));

        public const string ExpectedSKUXpath = "//td[@class='thm-cont-g3-bdrcolor--border-top thm-cont-g3-bdrcolor--border-right--edit-mode-grid thm-cont-g0-bgcolor thm-cont-h1-bgcolor--hover--edit-mode-grid thm-cont-g0-bgcolor--grid-row-selected thm-cont-h1-bgcolor--hover--grid-row-selected--edit-mode-grid edit-container right edit']//input[@class='cursorinherit stringcontrol-edit thm-cont-u1-font-size thm-cont-u1-font-stack thm-cont-u1-color-2--medflat thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus thm-cont-h1-bdrcolor--hover thm-cont-h1-bdrcolor--prev-sib-hover']";
        public IWebElement ExpectedSKU => Driver.FindElement(By.XPath(ExpectedSKUXpath));

        public const string YesButtonLinkInboundDeliveriesXpath = "//div[@class='spa-view spa-dialog no-animations shown']//button[1]";
        public IWebElement YesButtonLinkInboundDeliveries => Driver.FindElement(By.XPath(YesButtonLinkInboundDeliveriesXpath));

        public const string ShouldSeePopupMessageXpath = "/html/body/div[1]/div[6]/form/div/div/div[1]/div/div[2]/div/p";
        public IWebElement ShouldSeePopupMessage => Driver.FindElement(By.XPath(ShouldSeePopupMessageXpath));

        public const string ShouldSeePopupMessageMainPageXpath = "/html/body/div[1]/div[3]/form/div/div/div[1]/div/div[2]/div/p";
        public IWebElement ShouldSeePopupMessageMainPage => Driver.FindElement(By.XPath(ShouldSeePopupMessageMainPageXpath));

        public const string PopUpAfterRunPowerEdiManagerXpath = "/html/body/div[1]/div[3]/form/div/div/div[1]/div/div[2]/div/p";
        public IWebElement PopUpAfterRunPowerEdiManager => Driver.FindElement(By.XPath(PopUpAfterRunPowerEdiManagerXpath));

        public const string IShouldSeeInTRIDetailsClosedXpath = "//span[contains(@aria-label,'Closed, ')][text()='Yes']";
        public IWebElement IShouldSeeInTRIDetailClosed => Driver.FindElement(By.XPath(IShouldSeeInTRIDetailsClosedXpath));

        public const string ShouldSeeLinesCreatedNotNullInExpectedTRIXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[4]/div[3]/div/div/div/div[2]/table/tbody/tr[1]/td[3]";
        public IWebElement ShouldSeeLinesCreatedNotNullInExpectedTRI => Driver.FindElement(By.XPath(ShouldSeeLinesCreatedNotNullInExpectedTRIXpath));

        public const string IShouldSeeInTRIDetailsStatusTransportXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[3]/div[2]/div[2]/div[1]/div/div[2]/div/div[1]/div[2]/div[1]/div/span";
        public IWebElement IShouldSeeInTRIDetailsStatusTransport => Driver.FindElement(By.XPath(IShouldSeeInTRIDetailsStatusTransportXpath));

        public const string TIMENOWXpath = "(//td[@controlname='Date message']//span)[1]";
        public IWebElement TIMENOW => Driver.FindElement(By.XPath(TIMENOWXpath));

        public const string TIMENOWPackXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[1]/div/div[2]/table/tbody/tr[1]/td[7]/span";
        public IWebElement TIMENOWPack => Driver.FindElement(By.XPath(TIMENOWPackXpath));

        public const string WriteWeightLocationXpath = "//input[@id='ctrlWeight']";
        public IWebElement WriteWeightLocation => Driver.FindElement(By.XPath(WriteWeightLocationXpath));

        public const string IShouldSeeListedITEMInExpectedTableXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[3]/div[2]/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[9]/input";
        public IWebElement IShouldSeeListedITEMInExpectedTable => Driver.FindElement(By.XPath(IShouldSeeListedITEMInExpectedTableXpath));

        public const string IShouldExpectMessageInfoXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[2]/div/div/div[2]/div[2]/div[1]/div/span";
        public IWebElement IShouldExpectMessageInfo => Driver.FindElement(By.XPath(IShouldExpectMessageInfoXpath));

        public const string IShouldGetWarningMessageLabelXpath = ".//div[@class='ms-nav-validationpanel-text']";
        public IWebElement IShouldGetWarningMessageLabel => Driver.FindElement(By.XPath(IShouldGetWarningMessageLabelXpath));

        public const string IShouldGetWarningMessageXpath = "//p[. = 'Fill in a comment !']";
        //public const string IShouldGetWarningMessageXpath = "/html/body/div[1]/div[5]/form/div/div/div[2]/div/div[1]/div/div[2]/div/p";
        public IWebElement IShouldGetWarningMessageFC => Driver.FindElement(By.XPath(IShouldGetWarningMessageXpath));

        public const string OkButtonWarningMessageXpath = "//div[3]//button[. = 'OK']";
        public IWebElement OkButtonWarningMessage => Driver.FindElement(By.XPath(OkButtonWarningMessageXpath));

        public const string IShouldGetErrorAfterValidateAndCloseXpath = "//*[@title='Sort on 'Error'']";
        public IWebElement IShouldGetErrorAfterValidateAndClose => Driver.FindElement(By.XPath(IShouldGetErrorAfterValidateAndCloseXpath));

        public const string IShouldGetErrorMessageLabelXpath = ".//div[@class='ms-nav-validationpanel-text']";
        public IWebElement IShouldGetErrorMessageLabel => Driver.FindElement(By.XPath(IShouldGetErrorMessageLabelXpath));

        public const string IGetNotificationInPackingXpath = "//textarea[contains(text(),'BSGG is not a valid')]";
        public IWebElement IGetNotificationInPacking => Driver.FindElement(By.XPath(IGetNotificationInPackingXpath));

        public const string IShouldGetPOWERPACKINGMODULEERRORXpath = ".//textarea[contains(text(),'Order ')]";
        public IWebElement IShouldGetPOWERPACKINGMODULEERROR => Driver.FindElement(By.XPath(IShouldGetPOWERPACKINGMODULEERRORXpath));

        public const string IShouldGetPOWERPACKINGMODULECommentXpath = "//td[@id='110']";
        public IWebElement IShouldGetPOWERPACKINGMODULEComment => Driver.FindElement(By.XPath(IShouldGetPOWERPACKINGMODULECommentXpath));

        public const string IShouldGetPOWERPACKINGMODULEERRORUnknownXpath = ".//textarea[contains(text(),'Unknown ')]";
        public IWebElement IShouldGetPOWERPACKINGMODULEERRORUnknown => Driver.FindElement(By.XPath(IShouldGetPOWERPACKINGMODULEERRORUnknownXpath));

        public const string ShouldSeeMessageInIDTRIINBListXpath = "/html/body/div[1]/div[5]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[1]/div/div[2]/div/span";
        public IWebElement ShouldSeeMessageInIDTRIINBList => Driver.FindElement(By.XPath(ShouldSeeMessageInIDTRIINBListXpath));

        public const string IShouldSeePopupMessageInTRIXpath = "/html/body/div[1]/div[5]/form/div/div/div[2]/div/div[1]/div/div[2]/div/p";
        public IWebElement IShouldSeePopupMessageInTRI => Driver.FindElement(By.XPath(IShouldSeePopupMessageInTRIXpath));

        public const string SearchIBDXpath = "/html/body/div[1]/div[5]/form/div[2]/div/div[1]/div[3]/div/div/div/div[1]/div[2]/div/div[2]/div[1]";
        public IWebElement SearchIBD => Driver.FindElement(By.XPath(SearchIBDXpath));

        public const string ExpectedLineTRIXpath = "//body[@class='ms-dyn365-fin chrome mouse']/div[@class='spa-container spa-stack-container-2 spa-top-most-wide']/div[@class='spa-view spa-normal no-animations shown']/form[@class='ms-nav-root-form ms-nav-cardform in-create-mode in-dataentry-mode ms-nav-layout-wide ms-nav-noCommandBar ms-nav-layout-aside-right-visible']/div[@class='ms-nav-layout-page ms-nav-layout-page-layered']/div[@class='ms-nav-layout-content thm-cont-g0-bgcolor-1']/div[@class='ms-nav-layout-body thm-cont-g0-bgcolor-1']/div[@class='ms-nav-layout-content']/div[@class='ms-nav-layout-main ms-nav-scrollable']/div[@class='ms-nav-layout-content']/div[@class='ms-nav-cardform part-autoheight-lastChild ms-nav-noCommandBar']/div[4]/div[1]";
        public IWebElement ExpectedLineTRI => Driver.FindElement(By.XPath(ExpectedLineTRIXpath));

        public const string BookAllInExpectedTRIXpath = "//span[contains(text(),'Book ALL')]";
        public IWebElement BookAllInExpectedTRI => Driver.FindElement(By.XPath(BookAllInExpectedTRIXpath));

        public const string RunPOWEREDIManagerFromEDIMenuXpath = "//div[contains(text(),'Run POWER EDI Manager')]";
        public IWebElement RunPOWEREDIManagerFromEDIMenu => Driver.FindElement(By.XPath(RunPOWEREDIManagerFromEDIMenuXpath));

        public const string workingOnItEDIXpath = "/html/body/div[3]/div/div[2]/span";
        public IWebElement workingOnItEDI => Driver.FindElement(By.XPath(workingOnItEDIXpath));

        public const string referenceOkButtonEDIXpath = "/html/body/div[1]/div[3]/form/div/div/div[3]/div/button";
        public IWebElement referenceOkButtonEDI => Driver.FindElement(By.XPath(referenceOkButtonEDIXpath));

        public const string ClickLinesFromInStockMasterXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[5]/div[2]/div/div/div[1]/div/a";
        public IWebElement ClickLinesFromInStockMaster => Driver.FindElement(By.XPath(ClickLinesFromInStockMasterXpath));

        public const string ClickBookBackSelectedRecordsXpath = "/html/body/div[1]/div[4]/form/div[1]/div/ul/li[8]";
        public IWebElement ClickBookBackSelectedRecords => Driver.FindElement(By.XPath(ClickBookBackSelectedRecordsXpath));

        public const string ClickDeleteLineXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[5]/div[1]/div/div/div/div/div[2]/div/div/div/div[1]/div/div/div/div/div[2]/div/a/div/div[2]/span/span";
        public IWebElement ClickDeleteLine => Driver.FindElement(By.XPath(ClickDeleteLineXpath));

        public const string ClickPrintHolderLabelXpath = "//span[contains(text(),'Print Holder Label')]";
        public IWebElement ClickPrintHolderLabel => Driver.FindElement(By.XPath(ClickPrintHolderLabelXpath));

        public const string ClickBookAllInInStockMasterXpath = "//span[text()='Book All']";
        public IWebElement ClickBookAllInInStockMaster => Driver.FindElement(By.XPath(ClickBookAllInInStockMasterXpath));

        public const string ClickOnTheAddedRecordInInStockMasterToSelectItXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[5]/div[2]/div/div/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[7]/span";
        public IWebElement ClickOnTheAddedRecordInInStockMasterToSelectIt => Driver.FindElement(By.XPath(ClickOnTheAddedRecordInInStockMasterToSelectItXpath));

        public const string ClickTheThreeDotsOnTheAddedRecordInInStockMasterXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[5]/div[2]/div/div/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[4]/a";
        public IWebElement ClickTheThreeDotsOnTheAddedRecordInInStockMaster => Driver.FindElement(By.XPath(ClickTheThreeDotsOnTheAddedRecordInInStockMasterXpath));

        public const string ClickSelectMoreXpath = "/html/body/div[1]/div[4]/form/div[1]/div/ul/li[3]/div";
        public IWebElement ClickSelectMore => Driver.FindElement(By.XPath(ClickSelectMoreXpath));

        public const string ClickSelectAllCheckboxFromLinesXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[5]/div[2]/div/div/div[2]/div/div/div/div[1]/table/thead/tr/th[2]/input";
        public IWebElement ClickSelectAllCheckboxFromLines => Driver.FindElement(By.XPath(ClickSelectAllCheckboxFromLinesXpath));

        public const string InsertDefaultLocationXpath = "//input[@placeholder='Search']";
        public IWebElement InsertDefaultLocation => Driver.FindElement(By.XPath(InsertDefaultLocationXpath));

        public const string LocationsFromSearchXpath = "//body/div/div/form/div/div/div/div/div/div/div/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]";
        public IWebElement LocationsFromSearch => Driver.FindElement(By.XPath(LocationsFromSearchXpath));

        public const string ClickOKXpath = "/html/body/div[1]/div[5]/form/div/div/div[3]/div/button";
        public IWebElement ClickOK => Driver.FindElement(By.XPath(ClickOKXpath));

        public const string ClickCreateFromExpectedFromLinesXpath = "//span[contains(text(),'Create From Expected')]";
        public IWebElement ClickCreateFromExpectedFromLines => Driver.FindElement(By.XPath(ClickCreateFromExpectedFromLinesXpath));

        public const string ItemEmptyXml = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[5]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[7]/span";
        public IWebElement ItemEmpty => Driver.FindElement(By.XPath(ItemEmptyXml));

        public const string StatusEmptyXml = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[5]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[7]/span";
        public IWebElement StatusEmpty => Driver.FindElement(By.XPath(StatusEmptyXml));

        public const string LinesEXxpectedTRIXpath = "//a[contains(text(),'Lines')]";
        public IWebElement LinesEXxpectedTRI => Driver.FindElement(By.XPath(LinesEXxpectedTRIXpath));

        public const string StockMasterLinesTRIXpath = "//span[contains(text(),'In Stock (Master)')]";
        public IWebElement StockMasterLinesTRI => Driver.FindElement(By.XPath(StockMasterLinesTRIXpath));

        public const string LinesStockMasterLinesTRIXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[5]/div[2]/div/div/div[1]/div/a";
        public IWebElement LinesStockMasterLinesTRI => Driver.FindElement(By.XPath(LinesStockMasterLinesTRIXpath));

        public const string CreateFromExpectedStockMasterLinesTRIXpath = "//span[contains(text(),'Create From Expected')]";
        public IWebElement CreateFromExpectedStockMasterLinesTRI => Driver.FindElement(By.XPath(CreateFromExpectedStockMasterLinesTRIXpath));

        public const string BookAllInStockMasterTRIXpath = "//body/div/div/form/div/div/ul/li[6]/div[1]";
        public IWebElement BookAllInStockMasterTRI => Driver.FindElement(By.XPath(BookAllInStockMasterTRIXpath));

        public const string ClickCloseFromBookedSuccesfullTRIXpath = "/html/body/div[1]/div[4]/form/div[2]/div/div[4]/button[2]/span";
        public IWebElement ClickCloseFromBookedSuccesfullTRI => Driver.FindElement(By.XPath(ClickCloseFromBookedSuccesfullTRIXpath));

        public const string ExpectedDateTimeTRIXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div[1]/div[2]/div[1]/div/div/div[2]/div/div/input";
        public IWebElement ExpectedDateTimeTRI => Driver.FindElement(By.XPath(ExpectedDateTimeTRIXpath));

        public const string ExpectedDateTimeXpath = "//body//div//div//div//div//div//div//div//div//div//div//div//div//div//div[1]//div[1]//div[1]//div[2]//div[1]//div[1]//input[1]";
        public IWebElement ExpectedDateTime => Driver.FindElement(By.XPath(ExpectedDateTimeXpath));

        public const string ExpectedDateTime1Xpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div[1]/div[2]/div[1]/div/div/div[3]/div/div/input";
        public IWebElement ExpectedDateTime1 => Driver.FindElement(By.XPath(ExpectedDateTime1Xpath));

        public const string PlannedDateTimeTRIXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div[1]/div[2]/div[2]/div/div/div[2]/div/div/input";
        public IWebElement PlannedDateTimeTRI => Driver.FindElement(By.XPath(PlannedDateTimeTRIXpath));

        public const string PlannedDateTimeTRI1Xpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div[1]/div[2]/div[2]/div/div/div[3]/div/div/input";
        public IWebElement PlannedDateTimeTRI1 => Driver.FindElement(By.XPath(PlannedDateTimeTRI1Xpath));

        public const string ArrivedDateTimeTRIXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div[1]/div[2]/div[7]/div/div/div[2]/div/div/input";
        public IWebElement ArrivedDateTimeTRI => Driver.FindElement(By.XPath(ArrivedDateTimeTRIXpath));

        public const string ArrivedDateTimeTRI1Xpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div[1]/div[2]/div[7]/div/div/div[3]/div/div/input";
        public IWebElement ArrivedDateTimeTRI1 => Driver.FindElement(By.XPath(ArrivedDateTimeTRI1Xpath));

        public const string StartDischargingDateTimeTRIXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div[1]/div[2]/div[8]/div/div/div[2]/div/div/input";
        public IWebElement StartDischargingDateTimeTRI => Driver.FindElement(By.XPath(StartDischargingDateTimeTRIXpath));

        public const string StartDischargingDateTimeTRI1Xpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div[1]/div[2]/div[8]/div/div/div[3]/div/div/input";
        public IWebElement StartDischargingDateTimeTRI1 => Driver.FindElement(By.XPath(StartDischargingDateTimeTRI1Xpath));

        public const string EndingDischargingDateTimeTRIXpath = "//div[9]//div[1]//div[1]//div[2]//div[1]//div[1]//input[1]";
        public IWebElement EndingDischargingDateTimeTRI => Driver.FindElement(By.XPath(EndingDischargingDateTimeTRIXpath));

        public const string EndingDischargingDateTime1TRIXpath = "//div[9]//div[1]//div[1]//div[3]//div[1]//div[1]//input[1]";
        public IWebElement EndingDischargingDateTime1TRI => Driver.FindElement(By.XPath(EndingDischargingDateTime1TRIXpath));

        public const string DepartedDateTimeTRIXpath = "//div[11]//div[1]//div[1]//div[2]//div[1]//div[1]//input[1]";
        public IWebElement DepartedDateTimeTRI => Driver.FindElement(By.XPath(DepartedDateTimeTRIXpath));

        public const string SelectPalletisationXpath = "//div[8]//div[1]//select[1]";
        public IWebElement SelectPalletisation => Driver.FindElement(By.XPath(SelectPalletisationXpath));

        public const string DepartedDateTime1TRIXpath = "//div[11]//div[1]//div[1]//div[3]//div[1]//div[1]//input[1]";
        public IWebElement DepartedDateTime1TRI => Driver.FindElement(By.XPath(DepartedDateTime1TRIXpath));

        public const string FillInPOWERDischargesTRIXpath = "//span[contains(text(),'Dischargers')]";
        public IWebElement FillInPOWERDischargesTRI => Driver.FindElement(By.XPath(FillInPOWERDischargesTRIXpath));

        public const string SelectEmployeeTRIXpath = "//td[@class='thm-cont-g3-bdrcolor--border-top thm-cont-g3-bdrcolor--border-right--edit-mode-grid thm-cont-h1-bgcolor--safe-sel-l1-hover--view-mode-grid thm-cont-h1-bgcolor--hover--edit-mode-grid thm-cont-s1-bgcolor--grid-row-selected thm-cont-g0-bgcolor--grid-row-selected--edit-mode-grid edit-container ms-nav-editcontrolandonebuttoncontainer edit']//a[@class='icon-DownCaretThin ms-nav-lookupbutton-embedded edit-action-control thm-cont-a2-icon-color--minflat thm-cont-a2-icon-color-2--mintint--hover thm-cont-h1-bgcolor--hover ms-nav-button-1']";
        public IWebElement SelectEmployeeTRI => Driver.FindElement(By.XPath(SelectEmployeeTRIXpath));

        public const string CloseDischargingTabTRIXpath = "/html/body/div[1]/div[5]/form/div[2]/div/div[4]/button[2]";
        public IWebElement CloseDischargingTabTRI => Driver.FindElement(By.XPath(CloseDischargingTabTRIXpath));

        public const string SelectEmployee2TRIXpath = "//a[contains(text(),'M000002')]";
        public IWebElement SelectEmployee2TRI => Driver.FindElement(By.XPath(SelectEmployee2TRIXpath));

        public const string InsertQTYTRIXpath = "//td[@class='thm-cont-g3-bdrcolor--border-top thm-cont-g3-bdrcolor--border-right--edit-mode-grid thm-cont-h1-bgcolor--safe-sel-l1-hover--view-mode-grid thm-cont-h1-bgcolor--hover--edit-mode-grid thm-cont-s1-bgcolor--grid-row-selected thm-cont-g0-bgcolor--grid-row-selected--edit-mode-grid edit-container right edit']//input[@class='cursorinherit stringcontrol-edit thm-cont-u1-font-size thm-cont-u1-font-stack thm-cont-u1-color-2--medflat thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus thm-cont-h1-bdrcolor--hover thm-cont-h1-bdrcolor--prev-sib-hover']";
        public IWebElement InsertQTYTRI => Driver.FindElement(By.XPath(InsertQTYTRIXpath));

        public const string PalletGoBackButtonTRIXpath = "//form[@class='ms-nav-root-form ms-nav-layout-slim form-no-factboxes ms-nav-worksheetform in-edit-mode in-dataentry-mode ms-nav-noCommandBar']//div//button[@class='ms-Button ms-Button--icon back-button--sc3snD4Rah9iUaXSn-0h5 root-35']";
        public IWebElement PalletGoBackButtonTRI => Driver.FindElement(By.XPath(PalletGoBackButtonTRIXpath));

        public const string PalletPoolTRIXpath = "//span[text()='Palletpool']";
        public IWebElement PalletPoolTRI => Driver.FindElement(By.XPath(PalletPoolTRIXpath));

        public const string EmptyBoxTRIXpath = "//div[@class='spa-view spa-normal no-animations shown']//td[8]//input[1]";
        public IWebElement EmptyBoxTRI => Driver.FindElement(By.XPath(EmptyBoxTRIXpath));

        public const string EmptyBox1TRIXpath = "/html/body/div[1]/div[5]/form/div/div[2]/div[7]/div[2]/div[2]/div[2]/div[1]/div[2]/div/div[1]/div/div[2]/table/tbody/tr[1]/td[8]/input";
        public IWebElement EmptyBox1TRI => Driver.FindElement(By.XPath(EmptyBox1TRIXpath));

        public const string SelectUnitTRIXpath = "//td[@class='thm-cont-g3-bdrcolor--border-top thm-cont-g3-bdrcolor--border-right--edit-mode-grid thm-cont-h1-bgcolor--safe-sel-l1-hover--view-mode-grid thm-cont-h1-bgcolor--hover--edit-mode-grid thm-cont-s1-bgcolor--grid-row-selected thm-cont-g0-bgcolor--grid-row-selected--edit-mode-grid edit-container ms-nav-editcontrolandonebuttoncontainer edit']//input[@class='cursorinherit stringcontrol-edit thm-cont-u1-font-size thm-cont-u1-font-stack thm-cont-u1-color-2--medflat thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus thm-cont-h1-bdrcolor--hover thm-cont-h1-bdrcolor--prev-sib-hover']";
        public IWebElement SelectUnitTRI => Driver.FindElement(By.XPath(SelectUnitTRIXpath));

        public const string ActionTransportKPITRIXpath = "//span[contains(text(),'KPI')]";
        public IWebElement ActionTransportKPITRI => Driver.FindElement(By.XPath(ActionTransportKPITRIXpath));

        public const string ChangeQuantityKPITRIXpath = "//body/div/div/form/div/div/div/div/div/div/div/div/table/tbody/tr/td[6]/input[1]";
        public IWebElement ChangeQuantityKPITRI => Driver.FindElement(By.XPath(ChangeQuantityKPITRIXpath));

        public const string CloseKPITabTRIXpath = "//body/div/div/form/div/div/div/button[2]";
        public IWebElement CloseKPITabTRI => Driver.FindElement(By.XPath(CloseKPITabTRIXpath));

        public const string ClickValidateAndCloseTransportFromTheNavigationBarXpath = "//span[contains(text(),'Validate+Close Transport')]";
        public IWebElement ClickValidateAndCloseTransportFromTheNavigationBar => Driver.FindElement(By.XPath(ClickValidateAndCloseTransportFromTheNavigationBarXpath));

        public const string ClickShowTheRestDotsInNavigationXpath = ".//a[@title='Show the rest']/following::i[@data-icon-name='More']";
        public IWebElement ClickShowTheRestDotsInNavigation => Driver.FindElement(By.XPath(ClickShowTheRestDotsInNavigationXpath));

        public const string ClickShowAllFromNavigationBarInPOWERASSIGNEDINBOUNDTableXpath = "//div[@class='ms-Button-flexContainer flexContainer-48']/following::span[@aria-label='Show All']";
        public IWebElement ClickShowAllFromNavigationBarInPOWERASSIGNEDINBOUNDTable => Driver.FindElement(By.XPath(ClickShowAllFromNavigationBarInPOWERASSIGNEDINBOUNDTableXpath));

        public const string ClickEditListFromNavigationBarInPOWERASSIGNEDINBOUNDTableXpath = "/html/body/div[1]/div[5]/form/div[2]/div/div[1]/div[1]/div/div/div/div[1]/div/div/div[2]/div/div/div/div/div[2]/div/div/a";
        public IWebElement ClickEditListFromNavigationBarInPOWERASSIGNEDINBOUNDTable => Driver.FindElement(By.XPath(ClickEditListFromNavigationBarInPOWERASSIGNEDINBOUNDTableXpath));

        public const string ClickFieldLineNoCustomerAndAddValueXpath = "//input[contains(@aria-label,'Line no. Customer,')]";
        public IWebElement ClickFieldLineNoCustomerAndAddValue => Driver.FindElement(By.XPath(ClickFieldLineNoCustomerAndAddValueXpath));

        public const string AddItemCodeInTheFieldOfExpectedXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[3]/div[2]/div/div/div[2]/div[2]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[9]/input";
        public IWebElement AddItemCodeInTheFieldOfExpected => Driver.FindElement(By.XPath(AddItemCodeInTheFieldOfExpectedXpath));

        public const string HoverEDIDropdownMenuFromACTIONSXpath = "//span[text()='EDI']";
        public IWebElement HoverEDIDropdownMenuFromACTIONS => Driver.FindElement(By.XPath(HoverEDIDropdownMenuFromACTIONSXpath));

        public const string InboundDeliveryhoverMainPageXpath = "//a[contains(@title, 'Inbound Deliveries')]";
        public IWebElement InboundDeliveryhoverMainPage => Driver.FindElement(By.XPath(InboundDeliveryhoverMainPageXpath));

        public const string IAddSkuInTheFieldOfExpectedXpath = ".//input[contains(@aria-label,'# Sku,')]";
        public IWebElement IAddSkuInTheFieldOfExpected => Driver.FindElement(By.XPath(IAddSkuInTheFieldOfExpectedXpath));

        public const string UnitFiledinPalletpoolXpath = ".//tr[@aria-rowindex='1']/following::input[contains(@aria-label,'Unit,')][@tabindex='0']";
        public IWebElement UnitFiledinPalletpool => Driver.FindElement(By.XPath(UnitFiledinPalletpoolXpath));

        public const string ClickValidateAndCloseTransportFromTheNavigationBarInPOWERASSIGNEDINBOUNDTableXpath = "//span[contains(@aria-label,'Validate and Close')]";
        public IWebElement ClickValidateAndCloseTransportFromTheNavigationBarInPOWERASSIGNEDINBOUNDTable => Driver.FindElement(By.XPath(ClickValidateAndCloseTransportFromTheNavigationBarInPOWERASSIGNEDINBOUNDTableXpath));

        public const string ClickOKButtonOnThePopUpMessageXpath = "//span[contains(text(),'OK')]";
        public IWebElement ClickOKButtonOnThePopUpMessage => Driver.FindElement(By.XPath(ClickOKButtonOnThePopUpMessageXpath));

        public const string DefaultFilterXpath = "//label[@title='DefaultFilter']";
        public IWebElement DefaultFilter => Driver.FindElement(By.XPath(DefaultFilterXpath));

        public const string ValidateAndCloseTRIXpath = "//span[contains(text(),'Validate+Close Transport')]";
        public IWebElement ValidateAndCloseTRI => Driver.FindElement(By.XPath(ValidateAndCloseTRIXpath));

        public const string GoBackFromTRIMainXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[2]/div/div/div[1]/button/div/i";
        public IWebElement GoBackFromTRIMain => Driver.FindElement(By.XPath(GoBackFromTRIMainXpath));

        public const string ClickBackButtonFromTransportInboundXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[1]/div/div/div[1]/button/div/i";
        public IWebElement ClickBackButtonFromTransportInbound => Driver.FindElement(By.XPath(ClickBackButtonFromTransportInboundXpath));

        public const string GoBackFromTRIListXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[2]/div/div/div[1]/button/div/i";
        public IWebElement GoBackFromTRIList => Driver.FindElement(By.XPath(GoBackFromTRIListXpath));

        public const string ClickStockFromMainPageXpath = "//span[contains(text(),'Stock')]";
        public IWebElement ClickStockFromMainPage => Driver.FindElement(By.XPath(ClickStockFromMainPageXpath));

        public const string ClickStockSelectionXpath = "//div[contains(text(),'Stock Selection')]";
        public IWebElement ClickStockSelection => Driver.FindElement(By.XPath(ClickStockSelectionXpath));

        public const string HolderBarcodeOnHolderStockSelectionXpath = "//body/div/div/form/div/div/div/div/div/div/div/div/div[2]/div[1]/div[2]/div[1]//input[1]";
        public IWebElement HolderBarcodeOnHolderStockSelection => Driver.FindElement(By.XPath(HolderBarcodeOnHolderStockSelectionXpath));

        public const string BlockingReasonOnBlockedReasonXpath = "//div[2]/div/input";
        public IWebElement BlockingReasonOnBlockedReason => Driver.FindElement(By.XPath(BlockingReasonOnBlockedReasonXpath));

        public const string OkButtonXpath = "/html/body/div[1]/div[4]/form/div[2]/div/div[4]/button[1]";
        public IWebElement OkButton => Driver.FindElement(By.XPath(OkButtonXpath));

        public const string DropDownForSelectingBlockedReasonXpath = "//div[2]/div[2]/div/a";
        public IWebElement DropDownForSelectingBlockedReason => Driver.FindElement(By.XPath(DropDownForSelectingBlockedReasonXpath));

        public const string BlockingReasonOFromDropdownnXpath = "//div[3]/div//a[. = 'BASELINE']";
        public IWebElement BlockingReasonOFromDropdownn => Driver.FindElement(By.XPath(BlockingReasonOFromDropdownnXpath));

        public const string ClickOKButtonOnTheWarningWindowXpath = "/html/body/div[1]/div[5]/form/div/div/div[3]/div/button";
        public IWebElement ClickOKButtonOnTheWarningWindow => Driver.FindElement(By.XPath(ClickOKButtonOnTheWarningWindowXpath));

        public const string OkButtonOnDropdownnXpath = "/html/body/div[1]/div[5]/form/div[2]/div/div[4]/button[1]";
        public IWebElement OkButtonOnDropdownn => Driver.FindElement(By.XPath(OkButtonOnDropdownnXpath));

        public const string WriteCommentInBlockedReasonXpath = "//input[contains(@aria-label,'Comment, (Blank)')]";
        public IWebElement WriteCommentInBlockedReason => Driver.FindElement(By.XPath(WriteCommentInBlockedReasonXpath));

        public const string BlockedReasonCheckboxXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[1]/div/div[2]/table/tbody/tr/td[17]/div";
        public IWebElement BlockedReasonCheckbox => Driver.FindElement(By.XPath(BlockedReasonCheckboxXpath));

        public const string StockFromTypeInHolderSelectionXpath = "//div[6]//div[1]//select[1]//option[2]";
        public IWebElement StockFromTypeInHolderSelection => Driver.FindElement(By.XPath(StockFromTypeInHolderSelectionXpath));

        public const string ClickMoreOptionsInHolderStockSelectionXpath = "//span[@aria-label='More options']";
        public IWebElement ClickMoreOptionsInHolderStockSelection => Driver.FindElement(By.XPath(ClickMoreOptionsInHolderStockSelectionXpath));

        public const string ClickActionsInHolderStockXpath = "//span[@aria-label='Actions']";
        public IWebElement ClickActionsInHolderStock => Driver.FindElement(By.XPath(ClickActionsInHolderStockXpath));

        public const string ClickHolderXpath = "//span[contains(text(),'Holder')]";
        public IWebElement ClickHolder => Driver.FindElement(By.XPath(ClickHolderXpath));

        public const string CliskCreateHolderXpath = "//div[contains(text(),'Create Holder')]";
        public IWebElement ClickCreateHolder => Driver.FindElement(By.XPath(CliskCreateHolderXpath));

        public const string ClickPrintEmptyLabelXpath = "//span[@aria-label='Print empty label']";
        public IWebElement ClickPrintEmptyLabel => Driver.FindElement(By.XPath(ClickPrintEmptyLabelXpath));

        public const string AddQTYForPrintingEmptyLabelXpath = "//div[@class='ms-nav-edit-control-container show-border']//input[@class='cursorinherit stringcontrol-edit thm-cont-u1-font-size thm-cont-u1-font-stack thm-cont-u1-color-2--minflat thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus thm-cont-h1-bdrcolor--hover thm-cont-h1-bdrcolor--prev-sib-hover']";
        public IWebElement AddQTYForPrintingEmptyLabel => Driver.FindElement(By.XPath(AddQTYForPrintingEmptyLabelXpath));

        public const string ClickOKAfterAddingQTYXpath = "//span[contains(text(),'OK')]";
        public IWebElement ClickOKAfterAddingQTY => Driver.FindElement(By.XPath(ClickOKAfterAddingQTYXpath));

        public const string CopyPrintedEmptyLabel1Xpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[1]/div/div[2]/table/tbody/tr[1]/td[8]";
        public IWebElement CopyPrintedEmptyLabel1 => Driver.FindElement(By.XPath(CopyPrintedEmptyLabel1Xpath));

        public const string CopyPrintedEmptyLabelXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[1]/div/div[2]/table/tbody/tr[1]/td[8]/input";
        public IWebElement CopyPrintedEmptyLabel => Driver.FindElement(By.XPath(CopyPrintedEmptyLabelXpath));

        public const string EnterOrderLineTwoOutboundXpath = "(//table[@role='presentation']/tbody/tr[2]/td[6]/span)[2]";
        public IWebElement EnterOrderLineTwoOutbound => Driver.FindElement(By.XPath(EnterOrderLineTwoOutboundXpath));

        public const string SelectSecondLineInOrderLineXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[4]/div[3]/div/div/div/div[2]/table/tbody/tr[2]/td[1]";

        public IWebElement SelectSecondLineInOrderLine => Driver.FindElement(By.XPath(SelectSecondLineInOrderLineXpath));

        public const string SelectFirstLineInQueueGroupXpath = "(//td[contains(@class,'thm-cont-h1-bgcolor-1--safe-sel-l1-hover--view-mode-grid thm-cont-h1-bgcolor--hover--edit-mode-grid thm-cont-g3-bdrcolor--border-top thm-cont-g3-bdrcolor--border-left--edit-mode-grid thm-cont-s1-bgcolor--grid-row-selected thm-cont-g0-bgcolor--grid-row-selected--edit-mode-grid thm-cont-s1-bgcolor--grid-row-current--multiselect-grid thm-cont-g0-bgcolor--grid-row-current--edit-mode-grid')])[1]";
        public IWebElement SelectFirstLineInQueueGroup => Driver.FindElement(By.XPath(SelectFirstLineInQueueGroupXpath));

        public const string SelectMoreLineQueueGroupXpath = "//span[contains(text(),'Select More')]";
        public IWebElement SelectMoreLineQueueGroup => Driver.FindElement(By.XPath(SelectMoreLineQueueGroupXpath));

        public const string SelectSecondLineInQueGroupXpath = "(//td[contains(@class,'thm-cont-h1-bgcolor-1--safe-sel-l1-hover--view-mode-grid thm-cont-h1-bgcolor--hover--edit-mode-grid thm-cont-g3-bdrcolor--border-top thm-cont-g3-bdrcolor--border-left--edit-mode-grid thm-cont-s1-bgcolor--grid-row-selected thm-cont-g0-bgcolor--grid-row-selected--edit-mode-grid thm-cont-s1-bgcolor--grid-row-current--multiselect-grid thm-cont-g0-bgcolor--grid-row-current--edit-mode-grid')])[2]";
        public IWebElement SelectSecondLineInQueGroup => Driver.FindElement(By.XPath(SelectSecondLineInQueGroupXpath));

        public const string GenerateMultiOrderXpath = "//span[starts-with(@aria-label,'Generate Multi Ord')]";
        public IWebElement GenerateMultiOrder => Driver.FindElement(By.XPath(GenerateMultiOrderXpath));

        public const string ClickSearchOutboundXpath = "//div[contains(@class,'search-box-container')]";
        public IWebElement ClickSearchOutbound => Driver.FindElement(By.XPath(ClickSearchOutboundXpath));

        public const string WriteSearchOutboundCodeXpath = "//input[@aria-label='Search View - Outbound']";
        public IWebElement WriteSearchOutboundCode => Driver.FindElement(By.XPath(WriteSearchOutboundCodeXpath));

        public const string ClickSearchTransportOutboundXpath = "//div[@tabindex='0']";

        public IWebElement ClickSearchTransportOutbound => Driver.FindElement(By.XPath(ClickSearchTransportOutboundXpath));

        public const string ClickOnSearchOutboundXpath = "//div[@class='nav-bar-area-box']/div/div/div/div/div/div/div[2]/div[1]";

        public IWebElement ClickOnsearchOutbound => Driver.FindElement(By.XPath(ClickOnSearchOutboundXpath));


        public const string ButtonCloseOutboundXpath = "//button[starts-with(@class,'cursorinherit ms-nav-button thm-popp-a3-bgcolor thm-popp-a3-bgcolor-1--hover thm-popp-a3-bgcolor-3--active thm-popp-a3-color thm-popp-a3-color-1--hover thm-popp-a3-color-2--focus thm-popp-a3-color-3--active thm-popp-a3-font-stack thm-popp-a3-font-size thm-popp-a3-outlinecolor thm-popp-a3-outlinecolor-2--focus thm-popp-a3-bdrcolor thm-popp-a3-bdrcolor-1--hover thm-popp-a3-bdrcolor-2--focus thm-popp-a3-bdrcolor-3--active')]//span[contains(text(),'Close')]";
        public IWebElement ButtonCloseOutbound => Driver.FindElement(By.XPath(ButtonCloseOutboundXpath));

        public const string ButtonSplitBoxXpath = "//button[@id='btnSplitBox']";

        public IWebElement ButtonSplitBox => Driver.FindElement(By.XPath(ButtonSplitBoxXpath));

        public const string OKButtonSplitHolderOutboundXpath = "/html/body/div[1]/div[5]/form/div[2]/div/div[4]/button[1]/span";
        public IWebElement OKButtonSplitHolderOutbound => Driver.FindElement(By.XPath(OKButtonSplitHolderOutboundXpath));

        public const string ButtonCancelOutboundXpath = "//button[starts-with(@class,'cursorinherit ms-nav-button thm-popp-a3-bgcolor thm-popp-a3-bgcolor-1--hover thm-popp-a3-bgcolor-3--active thm-popp-a3-color thm-popp-a3-color-1--hover thm-popp-a3-color-2--focus thm-popp-a3-color-3--active thm-popp-a3-font-stack thm-popp-a3-font-size thm-popp-a3-outlinecolor thm-popp-a3-outlinecolor-2--focus thm-popp-a3-bdrcolor thm-popp-a3-bdrcolor-1--hover thm-popp-a3-bdrcolor-2--focus thm-popp-a3-bdrcolor-3--active')]//span[contains(text(),'Cancel')]";
        public IWebElement ButtonCancelOutbound => Driver.FindElement(By.XPath(ButtonCancelOutboundXpath));

        public const string InsertSearchOptionOutboundListXpath = "//input[@placeholder='Search']";
        public IWebElement InsertSearchOptionOutboundList => Driver.FindElement(By.XPath(InsertSearchOptionOutboundListXpath));

        public const string LinkedTransportInputFieldXpath = "//div[@controlname='Linked Transport']//div//input";
        public IWebElement LinkedTransportInputField => Driver.FindElement(By.XPath(LinkedTransportInputFieldXpath));

        public const string InsertSearchOptionTransportOutboundListXpath = "//input[@placeholder='Search']";

        public IWebElement InsertSearchOptionTransportOutboundList => Driver.FindElement(By.XPath(InsertSearchOptionTransportOutboundListXpath));

        public const string EditOptionOutboundListXpath = "//span[@aria-label='Edit']";
        public IWebElement EditOptionOutboundList => Driver.FindElement(By.XPath(EditOptionOutboundListXpath));

        public const string YesPackingConfirmationXpath = "//span[contains(text(), 'Yes')]";
        public IWebElement YesPackingConfirmation => Driver.FindElement(By.XPath(YesPackingConfirmationXpath));

        public const string DeleteOptionOutboundListXpath = "//span[@aria-label='Delete']";
        public IWebElement DeleteOptionOutboundList => Driver.FindElement(By.XPath(DeleteOptionOutboundListXpath));

        public const string IClickCalculateBatchXpath = "//span[@aria-label='Calculate Batch']";
        public IWebElement IClickCalculateBatch => Driver.FindElement(By.XPath(IClickCalculateBatchXpath));

        public const string HolderRetrievalQueueXpath = "(//tbody[@data-focus-zone='true'])[2]//tr[2]//td[1]";
        public IWebElement HolderRetrievalQueue => Driver.FindElement(By.XPath(HolderRetrievalQueueXpath));

        public const string FullBoxRetrievalOptionXpath = "//div[@controlname='IncludeFBRetrieval']//div//label";
        public IWebElement FullBoxRetrievalOption => Driver.FindElement(By.XPath(FullBoxRetrievalOptionXpath));

        public const string PriorityBatchOptionXpath = "//div[@controlname='UrgentBatch']//div//label";
        public IWebElement PriorityBatchOption => Driver.FindElement(By.XPath(PriorityBatchOptionXpath));

        public const string FullPalletFullBoxRetrievalOptionXpath = "//div[@controlname='IncludeFPFBRetrieval']//div//label";
        public IWebElement FullPalletFullBoxRetrievalOption => Driver.FindElement(By.XPath(FullPalletFullBoxRetrievalOptionXpath));

        public const string StatusOfTheBatchXpath = "//div[@controlname='Status']//div//span";
        public IWebElement StatusOfTheBatch => Driver.FindElement(By.XPath(StatusOfTheBatchXpath));

        public const string HolderRetrievalTypeXpath = "//span[@title='Retrieval']";
        public IWebElement HolderRetrievalType => Driver.FindElement(By.XPath(HolderRetrievalTypeXpath));

        public const string PickzoneQGXpath = "//td[@controlname='Pickzone']//a";
        public IWebElement PickzoneQG => Driver.FindElement(By.XPath(PickzoneQGXpath));

        public const string batchNumberQGXpath = "//td[@controlname='Batch Number']//a";
        public IWebElement batchNumberQG => Driver.FindElement(By.XPath(batchNumberQGXpath));

        public const string FBRetrievalQueueXpath = "//tr[@aria-rowindex='2']//td[1]";
        public IWebElement FBRetrievalQueue => Driver.FindElement(By.XPath(FBRetrievalQueueXpath));

        public const string PriorityBatchXpath = "//td[@controlname='Priority']//span";
        public IWebElement PriorityBatch => Driver.FindElement(By.XPath(PriorityBatchXpath));

        public const string HolderRetrievalQueueCreatedXpath = "(//span[@title='Retrieval'])[2]";
        public IWebElement HolderRetrievalQueueCreated => Driver.FindElement(By.XPath(HolderRetrievalQueueCreatedXpath));

        public const string StatusOfTheQueueToDoneXpath = "//td[@controlname='Status']//span";
        public IWebElement StatusOfTheQueueToDone => Driver.FindElement(By.XPath(StatusOfTheQueueToDoneXpath));

        public const string ReservationsOnOutboundXpath = "//span[contains(text(),'Reservations')]";
        public IWebElement ReservationsOnOutbound => Driver.FindElement(By.XPath(ReservationsOnOutboundXpath));

        public const string YesButtonOnDeleteTROXpath = "//span[contains(text(),'Yes')]";
        public IWebElement YesButtonOnDeleteTRO => Driver.FindElement(By.XPath(YesButtonOnDeleteTROXpath));

        public const string OutboundReservationsXpath = "//div//div//div//div//div//div[5]//div[2]//div[1]//div[1]//div[2]//div[1]//div[1]//div[1]//div[2]//table[1]//tbody[1]//tr[1]//td[9]";
        public IWebElement OutboundReservations => Driver.FindElement(By.XPath(OutboundReservationsXpath));

        public const string BookBackSelectedRecordsOrderLineOutboundXpath = "//span[contains(text(),'Book Back selected records')]";
        public IWebElement BookBackSelectedRecordsOrderLineOutbound => Driver.FindElement(By.XPath(BookBackSelectedRecordsOrderLineOutboundXpath));

        public const string BatchNumberFromBatchTableXpath = "//div[@controlname='ctrlSelectBatchNumber']//div//input";
        public IWebElement BatchNumberFromBatchTable => Driver.FindElement(By.XPath(BatchNumberFromBatchTableXpath));

        public const string CompleteBookBackSelectedRecordsOrderLineOutboundXpath = "//span[contains(text(),'Book Back COMPLETE selected line(s)')]";
        public IWebElement CompleteBookBackSelectedRecordsOrderLineOutbound => Driver.FindElement(By.XPath(CompleteBookBackSelectedRecordsOrderLineOutboundXpath));

        public const string BookBackSelectedPickwaveQGXpath = "//div[contains(text (), 'Book back selected Pickwave QG')]";
        public IWebElement BookBackSelectedPickwaveQG => Driver.FindElement(By.XPath(BookBackSelectedPickwaveQGXpath));

        public const string BookBackSelectedPickwaveQueueGroupXpath = "//span[contains(text (), 'Book back selected Pickwave QG')]";
        public IWebElement BookBackSelectedPickwaveQueueGroup => Driver.FindElement(By.XPath(BookBackSelectedPickwaveQueueGroupXpath));

        public const string BookBackSelectedPickwaveQueueGroupAfterShowMoreXpath = "//div[contains(text (), 'Book back selected Pickwave QG')]";
        public IWebElement BookBackSelectedPickwaveQueueGroupAfterShowMore => Driver.FindElement(By.XPath(BookBackSelectedPickwaveQueueGroupAfterShowMoreXpath));

        public const string ShowMoreInQueueGroupForBookBackXpath = "//button[@aria-label='Show the rest']//span//div//i";
        public IWebElement ShowMoreInQueueGroupForBookBack => Driver.FindElement(By.XPath(ShowMoreInQueueGroupForBookBackXpath));

        public const string YesButtonOutboundXpath = "//div[@class='ms-nav-actionbar-container has-actions']//button[1][not(@data-is-focusable)]";
        public IWebElement YesButtonOutbound => Driver.FindElement(By.XPath(YesButtonOutboundXpath));

        public const string IClickBatchWaveNeedXpath = "//li[starts-with(@class,'ms-Context')]//a[(@aria-label='Batch Wave Need')and(@data-is-focusable='true')]";
        public IWebElement IClickBatchWaveNeed => Driver.FindElement(By.XPath(IClickBatchWaveNeedXpath));

        public const string IClickShowFilterPaneXpath = "//div[starts-with(@class,'ms-nav-layout')]//button[(starts-with(@title,'Show filter'))and(@data-is-focusable='true')]";
        public IWebElement IClickShowFilterPane => Driver.FindElement(By.XPath(IClickShowFilterPaneXpath));

        public const string IClickOnErrorDropdownToXpath = "//div[(@data-is-focusable='true')and(@role='combobox')]//span[text()='Error']";
        public IWebElement IClickOnErrorDropdownTo => Driver.FindElement(By.XPath(IClickOnErrorDropdownToXpath));

        public const string IClickOnErrorLiXpath = "//button//span[text()='Error']";
        public IWebElement IClickOnErrorLi => Driver.FindElement(By.XPath(IClickOnErrorLiXpath));

        public const string IClickOnNotProcessedLiXpath = "//button//span[text()='Not Processed']";
        public IWebElement IClickOnNotProcessedLi => Driver.FindElement(By.XPath(IClickOnNotProcessedLiXpath));

        public const string BatchManagementXpath = "//button[@aria-label='Batch Management']//span//span//div";
        public IWebElement BatchManagement => Driver.FindElement(By.XPath(BatchManagementXpath));

        public const string IClickHolderRetrievalXpath = "//button[@aria-label='Holder Retrieval']//span//span//div";
        public IWebElement IClickHolderRetrieval => Driver.FindElement(By.XPath(IClickHolderRetrievalXpath));

        public const string IClickManageHolderRetrievalXpath = "//button[@aria-label='Manage Holder Retrieval']//span//span//div";
        public IWebElement IClickManageHolderRetrieval => Driver.FindElement(By.XPath(IClickManageHolderRetrievalXpath));

        public const string IClickBatchOverviewXpath = "//li[starts-with(@class,'ms-Context')]//a[(@title='Batch Overview')and(@data-is-focusable='true')]";
        public IWebElement IClickBatchOverview => Driver.FindElement(By.XPath(IClickBatchOverviewXpath));

        public const string ClickYesBookBackXpath = "//div[@class='spa-view spa-dialog no-animations shown']//button[1]";
        public IWebElement ClickYesBookBack => Driver.FindElement(By.XPath(ClickYesBookBackXpath));

        public const string IWriteBatchNumberXpath = "//td[@controlname='Batch Number']//input";
        public IWebElement IWriteBatchNumber => Driver.FindElement(By.XPath(IWriteBatchNumberXpath));

        public const string LinesInOrderXpath = "//a[@title='Actions for Lines']";
        public IWebElement LinesInOrder => Driver.FindElement(By.XPath(LinesInOrderXpath));

        public const string CancelQtyInLinesOutboundXpath = "//span[@aria-label='Cancel Qty']";
        public IWebElement CancelQtyInLinesOutbound => Driver.FindElement(By.XPath(CancelQtyInLinesOutboundXpath));

        public const string FewerOptionsCutOffXpath = "(//span[@aria-label='Fewer options'][contains(.,'Fewer options')])[1]";
        public IWebElement FewerOptionsCutOff => Driver.FindElement(By.XPath(FewerOptionsCutOffXpath));

        public const string OpenBigScreenQueueGroupXpath = "//body/div[1]/div[3]/form/div/div[2]/div[1]/div/div/div[2]/div[1]/div[2]/button/div/i";
        public IWebElement OpenBigScreenQueueGroup => Driver.FindElement(By.XPath(OpenBigScreenQueueGroupXpath));

        public const string YesConfirmCancellationOutboundXpath = "//div[@class='spa-view spa-dialog no-animations shown']//button[1]";
        public IWebElement YesConfirmCancellationOutbound => Driver.FindElement(By.XPath(YesConfirmCancellationOutboundXpath));

        public const string CancelCodeOutboundXpath = "//div[@class='single-column-group']//div[@class='edit-container thm-cont-g0-bgcolor-1 ms-nav-editcontrolandonebuttoncontainer']/input[1]";
        public IWebElement CancelCodeOutbound => Driver.FindElement(By.XPath(CancelCodeOutboundXpath));

        public const string SecondLineOrderLineItemOutboundXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[4]/div[2]/div/div/div/div[2]/table/tbody/tr[2]/td[6]/input";
        public IWebElement SecondLineOrderLineItemOutbound => Driver.FindElement(By.XPath(SecondLineOrderLineItemOutboundXpath));

        public const string LinesReservationOutboundXpath = "//body/div/div/form/div/div/div/div/div/div/div/div[5]/div[2]/div[1]/div[1]/div[1]/div[1]/a[1]";
        public IWebElement LinesReservationOutbound => Driver.FindElement(By.XPath(LinesReservationOutboundXpath));

        public const string BookBackSelectedLinesOutboundXpath = "//span[contains(text(),'Book Back PART OF selected line')]";
        public IWebElement BookBackSelectedLinesOutbound => Driver.FindElement(By.XPath(BookBackSelectedLinesOutboundXpath));

        public const string QtyToBookBackOutboundXpath = "/html/body/div[1]/div[5]/form/div[2]/div/div[3]/div[1]/div/div[3]/div/div/div/div[8]/div/input";
        public IWebElement QtyToBookBackOutbound => Driver.FindElement(By.XPath(QtyToBookBackOutboundXpath));

        public const string OkAfterTodaysDateXpath = "//button[@class='cursorinherit ms-nav-button thm-popp-a2-font-stack-1--minflat thm-popp-a2-color-2--minflat highlight-btn thm-popp-g1-emph-bgcolor-1']";
        public IWebElement OkAfterTodaysDate => Driver.FindElement(By.XPath(OkAfterTodaysDateXpath));

        public const string EnterTransporterOutboundXpath = "//input[starts-with(@aria-label,'Transporter')]";
        public IWebElement EnterTransporterOutbound => Driver.FindElement(By.XPath(EnterTransporterOutboundXpath));

        public const string IEnterBuyerOnOutboundXpath = "//input[starts-with(@aria-label,'Buyer')]";
        public IWebElement IEnterBuyerOnOutbound => Driver.FindElement(By.XPath(IEnterBuyerOnOutboundXpath));

        public const string MoreOptionsOnQueueGroupXpath = "//div[contains(text(), 'More options')]";
        public IWebElement MoreOptionsOnQueueGroup => Driver.FindElement(By.XPath(MoreOptionsOnQueueGroupXpath));

        public const string MoreOptionsInQueueGroupListsXpath = "(//i[@data-icon-name='More'])[2]";
        public IWebElement MoreOptionsInQueueGroupLists => Driver.FindElement(By.XPath(MoreOptionsInQueueGroupListsXpath));

        public const string MoreOptionsWritenOnQueueGroupXpath = "//div[starts-with(@class,'ms-FocusZone')]//following::li[starts-with(@class,'ms-Context')]//following::a[starts-with(@title,'Reveal')]";
        public IWebElement MoreOptionsWritenOnQueueGroup => Driver.FindElement(By.XPath(MoreOptionsWritenOnQueueGroupXpath));

        public const string ActionsQueueGroupXpath = "//div[@class='no-icon-button-align--ddQBukIYLVNCGBpe2JCxo command-bar-button-text--2dIQkzAbHK18inPTYeiPdF thm-popp-a2-font-stack-2--minflat thm-popp-a2-font-size-2--minflat thm-popp-a2-color-2--minflat'][contains(.,'Actions')]";
        public IWebElement ActionsQueueGroup => Driver.FindElement(By.XPath(ActionsQueueGroupXpath));

        public const string QueueGroupOnDropdownXpath = "//div[@class='no-icon-button-align--ddQBukIYLVNCGBpe2JCxo command-bar-button-text--2dIQkzAbHK18inPTYeiPdF thm-popp-a2-font-stack-2--minflat thm-popp-a2-font-size-2--minflat thm-popp-a2-color-2--minflat'][contains(.,'Queue Group')]";
        public IWebElement QueueGroupOnDropdown => Driver.FindElement(By.XPath(QueueGroupOnDropdownXpath));

        public const string AddToBatchQueueGroupListXpath = "//button[@aria-label='Add To Batch']//span//span//div";
        public IWebElement AddToBatchQueueGroupList => Driver.FindElement(By.XPath(AddToBatchQueueGroupListXpath));

        public const string UnlinkFromBatchXpath = "//button[@aria-label='Unlink From Batch']";
        public IWebElement UnlinkFromBatch => Driver.FindElement(By.XPath(UnlinkFromBatchXpath));

        public const string WriteAddToBatchInputXpath = "//div[@controlname='ctrlSelectBatchNumber']//div//input";
        public IWebElement WriteAddToBatchInput => Driver.FindElement(By.XPath(WriteAddToBatchInputXpath));

        public const string IClickNEWBATCHButtonXpath = "//button[@aria-label='NEW BATCH']";
        public IWebElement IClickNEWBATCHButton => Driver.FindElement(By.XPath(IClickNEWBATCHButtonXpath));

        public const string ShowMoreInBatchXpath = "(//button[@aria-label='Show the rest'])[2]//span//div";
        public IWebElement ShowMoreInBatch => Driver.FindElement(By.XPath(ShowMoreInBatchXpath));

        public const string BatchTypeDropDownXpath = "//div[@controlname='BatchType']//div//select";
        public IWebElement BatchTypeDropDown => Driver.FindElement(By.XPath(BatchTypeDropDownXpath));

        public const string PlanningQueueGroupXpath = "//button[@aria-label='Planning']//span//span//div";
        public IWebElement PlanningQueueGroup => Driver.FindElement(By.XPath(PlanningQueueGroupXpath));

        public const string LinkOnMoreOptionsQueueGroupXpath = "//body/div[5]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/ul[1]/li[3]/div[1]";
        public IWebElement LinkOnMoreOptionsQueueGroup => Driver.FindElement(By.XPath(LinkOnMoreOptionsQueueGroupXpath));

        public const string LinkToATransportQueueGroupXpath = "//div[7]//div[1]//li[1]//div[2]";
        public IWebElement LinkToATransportQueueGroup => Driver.FindElement(By.XPath(LinkToATransportQueueGroupXpath));

        public const string SearchButtonMainPageXpath = "//i[@data-icon-name='Search']";
        public IWebElement SearchButtonMainPage => Driver.FindElement(By.XPath(SearchButtonMainPageXpath));

        public const string IClickRunInNasSimulatorXpath = "//span[starts-with(@aria-label,'RUN Selected Task')]";
        public IWebElement IClickRunInNasSimulator => Driver.FindElement(By.XPath(IClickRunInNasSimulatorXpath));

        public const string IClickRunInNasSimulatorADEOXpath = "//span[@aria-label='RUN Selected Task ']";
        public IWebElement IClickRunInNasSimulatorADEO => Driver.FindElement(By.XPath(IClickRunInNasSimulatorADEOXpath));

        public const string SearchInputMainPageXpath = "//body/div/div/form/div/div/div/div/div/div/div/div/div/input[1]";
        public IWebElement SearchInputMainPage => Driver.FindElement(By.XPath(SearchInputMainPageXpath));

        public const string GoBackFromLocationCardXpath = "//body/div/div/form/div/div/div/div/div/div/button[1]";
        public IWebElement GoBackFromLocationCard => Driver.FindElement(By.XPath(GoBackFromLocationCardXpath));

        public const string ShowMoreOptionsInQueueGroupXpath = "//span[contains(text(),'More options')]";
        public IWebElement ShowMoreOptionsInQueueGroup => Driver.FindElement(By.XPath(ShowMoreOptionsInQueueGroupXpath));

        public const string QueueOnQueueGroupXpath = "//span[@aria-label='Queue']";
        public IWebElement QueueOnQueueGroup => Driver.FindElement(By.XPath(QueueOnQueueGroupXpath));

        public const string TTLQueuesQueueInOutboundXpath = "//span[@aria-label='Queue']";

        public IWebElement TTLQueuesQueueInOutbound => Driver.FindElement(By.XPath(TTLQueuesQueueInOutboundXpath));

        public const string TTLQueuesButtonXpath = "//span[@title='(TT)L Queues']";

        public IWebElement TTLQueuesButton => Driver.FindElement(By.XPath(TTLQueuesButtonXpath));

        public const string UnloadSelectedMasterHoldersXpath = "//span[@aria-label='Unload Selected MasterHolders']";

        public IWebElement UnloadSelectedMasterHolders => Driver.FindElement(By.XPath(UnloadSelectedMasterHoldersXpath));

        public const string ClickBookBackSelectedRecordsOnQueueGroupXpath = "//div[contains(text(),'Book Back selected records')]";
        public IWebElement ClickBookBackSelectedRecordsOnQueueGroup => Driver.FindElement(By.XPath(ClickBookBackSelectedRecordsOnQueueGroupXpath));

        public const string InsertItemInStockXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[1]/div[2]/div/div[12]/div/input";
        public IWebElement InsertItemInStock => Driver.FindElement(By.XPath(InsertItemInStockXpath));

        public const string StockSelectionHolderBarcodeXpath = "//body[@class='ms-dyn365-fin chrome mouse']/div[@class='spa-container spa-stack-container-1 spa-top-most-slim']/div[@class='spa-view spa-normal no-animations shown']/form[@class='ms-nav-root-form ms-nav-layout-slim form-no-factboxes ms-nav-cardform in-view-mode in-dataentry-mode ms-nav-noCommandBar']/div[@class='ms-nav-layout-page ms-nav-layout-page-layered']/div[@class='ms-nav-layout-content thm-cont-g0-bgcolor-1']/div[@class='ms-nav-layout-body thm-cont-g0-bgcolor-1']/div[@class='ms-nav-layout-content']/div[@class='ms-nav-layout-main ms-nav-scrollable']/div[@class='ms-nav-layout-content']/div[@class='ms-nav-cardform part-autoheight-lastChild ms-nav-noCommandBar']/div[@class='ms-nav-band contains-show-mandatory-fields expanded']/div[@class='collapsibleTab']/div[@class='multiple-columns-group chrome-desktop-multiple-columns-group']/div[2]/div[1]/input[1]";
        public IWebElement StockSelectionHolderBarcode => Driver.FindElement(By.XPath(StockSelectionHolderBarcodeXpath));

        public const string StockSelectionLocationXpath = "//div[@class='ms-nav-layout-body thm-cont-g0-bgcolor-1']//div[5]//div[1]//input[1]";
        public IWebElement StockSelectionLocation => Driver.FindElement(By.XPath(StockSelectionLocationXpath));

        public const string StockSelectionSKUINSTOCKXpath = "//div[13]//div[1]//input[1]";
        public IWebElement StockSelectionSKUINSTOCK => Driver.FindElement(By.XPath(StockSelectionSKUINSTOCKXpath));

        public const string StockSelectionSKUINSTOCKInStockListXpath = "//html//body//div//div//div//div//div//div//div//button//div//span//span[contains(text(),'# Sku In Stock')]";
        public IWebElement StockSelectionSKUINSTOCKInStockList => Driver.FindElement(By.XPath(StockSelectionSKUINSTOCKInStockListXpath));

        public const string StockSelectionSKUINSTOCKEnterTextXpath = "//div[13]//div[1]//input[1]";
        public IWebElement StockSelectionSKUINSTOCKEnterText => Driver.FindElement(By.XPath(StockSelectionSKUINSTOCKEnterTextXpath));

        public const string StockSelectionSKUINSTOCForStockListKEnterTextXpath = "//html//body//div//div//form//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//input";
        public IWebElement StockSelectionSKUINSTOCForStockListKEnterText => Driver.FindElement(By.XPath(StockSelectionSKUINSTOCForStockListKEnterTextXpath));

        public const string FalseFromBlockedXpath = "//option[contains(text(),'False')]";
        public IWebElement FalseFromBlocked => Driver.FindElement(By.XPath(FalseFromBlockedXpath));

        public const string SelectButtonXpath = "//span[contains(text(),'Select')]";
        public IWebElement SelectButton => Driver.FindElement(By.XPath(SelectButtonXpath));

        public const string IrregularitiesMainMenuXpath = "//span[contains(text(),'Irregularities')]";
        public IWebElement IrregularitiesMainMenu => Driver.FindElement(By.XPath(IrregularitiesMainMenuXpath));

        public const string StockCorrectionsDropdownXpath = "//div[contains(text(),'StockCorrections')]";
        public IWebElement StockCorrectionsDropdown => Driver.FindElement(By.XPath(StockCorrectionsDropdownXpath));

        public const string CardInStockCorrectionsXpath = "//span[contains(text(),'Card')]";
        public IWebElement CardInStockCorrections => Driver.FindElement(By.XPath(CardInStockCorrectionsXpath));

        public const string ManageButtonInCorrectionsXpath = "//div[@class='button-container--iUT6fwygh610UC-k6esrT command-bar-button-container--1ms9JCUCujkBljIx4C1GfY first-item--15AeWXqkjbAQCNaM3tqgcY first-item--15AeWXqkjbAQCNaM3tqgcY']//span[contains(text(),'Manage')]";
        public IWebElement ManageButtonInCorrections => Driver.FindElement(By.XPath(ManageButtonInCorrectionsXpath));

        public const string NewButtonInCorrectionsXpath = "//body[@class='ms-dyn365-fin chrome mouse']/div[@class='spa-container spa-stack-container-1 spa-top-most-slim']/div[@class='spa-view spa-task-dialog slide-in-from-top animate no-animations shown']/form[@class='ms-nav-root-form ms-nav-layout-slim form-no-factboxes ms-nav-cardform in-edit-mode in-dataentry-mode thm-cont-g0-bgcolor-1 ms-nav-noCommandBar']/div[@class='ms-nav-content-box task-dialog']/div[@class='ms-nav-content']/div[@class='task-dialog-header']/div[@class='nav-bar-area-box']/div[@class='nav-bar-content']/div[@class='ms-Fabric thm-cont-g0-bgcolor-1 css-33']/div/div[@class='outside-layout-control--jNcQQmUzz0Tf2IDJtOOEB']/div[@class='outside-layout-control-content--32h7-0URKQXt663GFl5oyN thm-cont-g3-bdrcolor--border-bottom thm-cont-g3-bdrcolor--border-top']/div[@class='secondary-row-container--3KcFkKL_FLlxT5a7mQVIpO']/div[@class='secondary-row--3RpkthoIYZECQ16l-bJ2sR row-floating--3_YMMCcVM6pW8_WyXN-NuX']/div[@class='ms-FocusZone ms-nav-ColumnFocusZone commandbar-container--2NtwRaTSzGkioIG0FLXoBI']/div[@class='ms-ResizeGroup']/div[@class='root--nsRjo12_Z6aKCVf3HWNgK']/div/div[@class='row-container--3RjnD1FA2V1jWTgeFWmEcU']/div[1]/div[1]/div[1]/a[1]/div[1]";
        public IWebElement NewButtonInCorrections => Driver.FindElement(By.XPath(NewButtonInCorrectionsXpath));

        public const string MoreOptionsInNewCorrectionsTabXpath = "//div[@class='ms-nav-layout-content outside-layout-control-content--32h7-0URKQXt663GFl5oyN thm-cont-g3-bdrcolor--border-bottom thm-cont-g3-bdrcolor--border-top']//span[contains(text(),'More options')]";
        public IWebElement MoreOptionsInNewCorrectionsTab => Driver.FindElement(By.XPath(MoreOptionsInNewCorrectionsTabXpath));

        public const string ActionsTabInStockCorrectionsXpath = "//span[contains(text(),'Actions')]";
        public IWebElement ActionsTabInStockCorrections => Driver.FindElement(By.XPath(ActionsTabInStockCorrectionsXpath));

        public const string StockCorrectionsTabXpath = "//span[contains(text(),'Stockcorrections')]";
        public IWebElement StockCorrectionsTab => Driver.FindElement(By.XPath(StockCorrectionsTabXpath));

        public const string GetStockCorrectionsBalanceXpath = "//div[contains(text(),'Get Stockcorrection Balance')]";
        public IWebElement GetStockCorrectionsBalance => Driver.FindElement(By.XPath(GetStockCorrectionsBalanceXpath));

        public const string EnterTodaysDateInInputDialogXpath = "/html/body/div[1]/div[6]/form/div[2]/div/div[3]/div[1]/div/div[3]/div/div/div/div[4]/div/input";
        public IWebElement EnterTodaysDateInInputDialog => Driver.FindElement(By.XPath(EnterTodaysDateInInputDialogXpath));

        public const string EnterTodaysDateInInputDialogClickXpath = "/html/body/div[1]/div[6]/form/div[2]/div/div[3]/div[1]/div/div[3]/div/div/div/div[4]/div";
        public IWebElement EnterTodaysDateInInputDialogClick => Driver.FindElement(By.XPath(EnterTodaysDateInInputDialogClickXpath));

        public const string ManageButtonInCorrectionsInDetailXpath = "/html/body/div[1]/div[5]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[4]/div[1]/div/div/div/div/div[1]/div/div/div[2]/div/div/div/div/div[2]/div/a/div/div/span/span";
        public IWebElement ManageButtonInCorrectionsInDetail => Driver.FindElement(By.XPath(ManageButtonInCorrectionsInDetailXpath));

        public const string BookBackAllInStockCorrectionsXpath = "//span[contains(text(),'Book Back Selected Records')]";
        public IWebElement BookBackAllInStockCorrections => Driver.FindElement(By.XPath(BookBackAllInStockCorrectionsXpath));

        public const string BackFromStockCorrectionsCardXpath = "/html/body/div[1]/div[5]/form/div/div[2]/div[1]/div/div/div[1]/button/div/i";
        public IWebElement BackFromStockCorrectionsCard => Driver.FindElement(By.XPath(BackFromStockCorrectionsCardXpath));

        public const string CloseIrregularitiesCardXpath = "//span[contains(text(),'Close')]";
        public IWebElement CloseIrregularitiesCard => Driver.FindElement(By.XPath(CloseIrregularitiesCardXpath));

        public const string GoBackToBCHomeFromIrregularitiesXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[1]/div/div/div[1]/button/div/i";
        public IWebElement GoBackToBCHomeFromIrregularities => Driver.FindElement(By.XPath(GoBackToBCHomeFromIrregularitiesXpath));

        public const string UnblockingActionsFromIrregularitiesXpath = "//div[contains(text(),'[Un]Blocking Actions')]";
        public IWebElement UnblockingActionsFromIrregularities => Driver.FindElement(By.XPath(UnblockingActionsFromIrregularitiesXpath));

        public const string CardInUnblockingActionsXpath = "//span[contains(text(),'Card')]";
        public IWebElement CardInUnblockingActions => Driver.FindElement(By.XPath(CardInUnblockingActionsXpath));

        public const string ManageInCardInUnblockingActionsXpath = "//div[@class='button-container--iUT6fwygh610UC-k6esrT command-bar-button-container--1ms9JCUCujkBljIx4C1GfY first-item--15AeWXqkjbAQCNaM3tqgcY first-item--15AeWXqkjbAQCNaM3tqgcY']//span[contains(text(),'Manage')]";
        public IWebElement ManageInCardInUnblockingActions => Driver.FindElement(By.XPath(ManageInCardInUnblockingActionsXpath));

        public const string NewFromManageDropdownXpath = "//span[contains(text(),'New')]";
        public IWebElement NewFromManageDropdown => Driver.FindElement(By.XPath(NewFromManageDropdownXpath));

        public const string InNewISelectMoreOptionsXpath = "//div[@class='ms-nav-layout-content outside-layout-control-content--32h7-0URKQXt663GFl5oyN thm-cont-g3-bdrcolor--border-bottom thm-cont-g3-bdrcolor--border-top']//span[contains(text(),'More options')]";
        public IWebElement InNewISelectMoreOptions => Driver.FindElement(By.XPath(InNewISelectMoreOptionsXpath));

        public const string ActionsInBlockingXpath = "//span[contains(text(),'Actions')]";
        public IWebElement ActionsInBlocking => Driver.FindElement(By.XPath(ActionsInBlockingXpath));

        public const string UnBlockingActionsAfterActionsTabXpath = "//span[contains(text(),'[Un]Blocking Actions')]";
        public IWebElement UnBlockingActionsAfterActionsTab => Driver.FindElement(By.XPath(UnBlockingActionsAfterActionsTabXpath));

        public const string GetUnblockingBalanceWithTodaysDateXpath = "//div[contains(text(),'Get [Un]Blocking Balance')]";
        public IWebElement GetUnblockingBalanceWithTodaysDate => Driver.FindElement(By.XPath(GetUnblockingBalanceWithTodaysDateXpath));

        public const string InHolderStockSelectionsShowFilterPaneXpath = "//button[@class='ms-Button ms-Button--icon command-bar-button--2vOMW0YBNkKcDAlSFF9lUJ system-action-control--71j3QkyQSurez2TowswCH thm-head-g1-bgcolor thm-popp-h2-bgcolor--hover fade-out-transition--2bZPl-hV_UISWOGTJcI6bA root-35']//i[@class='css-52 root-43 ms-Button-icon thm-head-a1-color--medflat icon-38']";
        public IWebElement InHolderStockSelectionsShowFilterPane => Driver.FindElement(By.XPath(InHolderStockSelectionsShowFilterPaneXpath));

        public const string FilterXpath = "//body[@class='ms-dyn365-fin chrome mouse']/div[@class='spa-container spa-stack-container-1 spa-top-most-slim']/div[@class='spa-view spa-normal no-animations shown']/form[@class='ms-nav-root-form ms-nav-layout-slim form-no-factboxes ms-nav-listform in-view-mode in-overview-mode ms-nav-noCommandBar ms-nav-layout-aside-left-visible']/div[@class='ms-nav-layout-page ms-nav-layout-page-layered']/div[@class='ms-nav-layout-content thm-cont-g0-bgcolor-1']/div[@class='ms-nav-layout-body thm-cont-g1-bgcolor thm-cont-g0-bgcolor-1--pgstate_in-edit-mode thm-cont-g0-bgcolor-1--pgstate_in-create-mode']/div[@class='ms-nav-layout-content']/div[@class='ms-nav-layout-aside-left ms-nav-scrollable ms-nav-layout-expanded']/div[@class='ms-nav-layout-content']/div[@class='aside-left-control--1pLHAlzqdgVsKJ5z8FbB54']/div[@class='aside-left-control-content--3cP_PoE3j9PC6q8Qbx2iyZ']/div[@class='filter-pane-container--1aMgQGOxzhCQxgjuoGNGJG']/div[@class='filter-pane-content--1r-gKrqgvu-CWiejhmbnrZ']/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/button[1]/div[1]/div[1]";
        public IWebElement Filter => Driver.FindElement(By.XPath(FilterXpath));

        public const string InFilterISelectBlockedXpath = "//span[contains(text(),'Blocked')]";
        public IWebElement InFilterISelectBlocked => Driver.FindElement(By.XPath(InFilterISelectBlockedXpath));

        public const string AfterBlockedISelectNoXpath = "//select[@class='enumerationcontrol-edit thm-cont-u1-font-size thm-cont-u1-font-stack thm-cont-u1-color-2--medflat thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus thm-cont-h1-bdrcolor--hover']";
        public IWebElement AfterBlockedISelectNo => Driver.FindElement(By.XPath(AfterBlockedISelectNoXpath));

        public const string AfterBlockedISelectYesXpath = "//select[@class='enumerationcontrol-edit thm-cont-u1-font-size thm-cont-u1-font-stack thm-cont-u1-color-2--medflat thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus thm-cont-h1-bdrcolor--hover']";
        public IWebElement AfterBlockedISelectYes => Driver.FindElement(By.XPath(AfterBlockedISelectYesXpath));

        public const string SelectNoXpath = "//option[contains(text(),'No')]";
        public IWebElement SelectNo => Driver.FindElement(By.XPath(SelectNoXpath));

        public const string SelectYesXpath = "//option[contains(text(),'Yes')]";
        public IWebElement SelectYes => Driver.FindElement(By.XPath(SelectYesXpath));

        public const string IClickItemXpath = "//html//body//div//div//form//div//div//div//div//div//div//div//div//div//div//table//thead//tr//th//div//a[contains(text(),'Item')]";
        public IWebElement IClickItem => Driver.FindElement(By.XPath(IClickItemXpath));

        public const string ClickMaximiseXpath = "(//i[@data-icon-name='FullScreen'])[2]";
        public IWebElement ClickMaximise => Driver.FindElement(By.XPath(ClickMaximiseXpath));

        public const string SearchForIRHCodeFromIrregularitiesXpath = "//input[@class='cursorinherit stringcontrol-edit thm-cont-u1-font-size thm-cont-u1-font-stack thm-cont-u1-color-2--medflat thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus thm-cont-h1-bdrcolor--hover thm-cont-h1-bdrcolor--prev-sib-hover']";
        public IWebElement SearchForIRHCodeFromIrregularities => Driver.FindElement(By.XPath(SearchForIRHCodeFromIrregularitiesXpath));

        public const string ProcessInUnblockingActionsXpath = "//div[@class='button-container--iUT6fwygh610UC-k6esrT command-bar-button-container--1ms9JCUCujkBljIx4C1GfY first-item--15AeWXqkjbAQCNaM3tqgcY first-item--15AeWXqkjbAQCNaM3tqgcY']//span[contains(text(),'Process')]";
        public IWebElement ProcessInUnblockingActions => Driver.FindElement(By.XPath(ProcessInUnblockingActionsXpath));

        public const string CloseInUnblockingActionsXpath = "//span[@class='thm-head-a2-color-2--medflat thm-head-a2-font-size-5--medflat thm-head-a2-font-stack-2--medflat']//span[contains(text(),'Close')]";
        public IWebElement CloseInUnblockingActions => Driver.FindElement(By.XPath(CloseInUnblockingActionsXpath));

        public const string FilterListByXpath = "//div[contains(text(),'Filter list by...')]";
        public IWebElement FilterListBy => Driver.FindElement(By.XPath(FilterListByXpath));

        public const string OutboundFromMainMenuXpath = "//div[@class='caption--2Z2rg647Z6TBHx_ehbNAHC thm-summ-c2-font-size-2--sldaccn thm-summ-c2-font-stack-2--sldaccn'][contains(text(),'Outbound')]";
        public IWebElement OutboundFromMainMenu => Driver.FindElement(By.XPath(OutboundFromMainMenuXpath));

        public const string ShowFilterPaneInOutboundForStockXpath = "//button[@class='ms-Button ms-Button--icon command-bar-button--2vOMW0YBNkKcDAlSFF9lUJ system-action-control--71j3QkyQSurez2TowswCH thm-head-g1-bgcolor thm-popp-h2-bgcolor--hover fade-out-transition--2bZPl-hV_UISWOGTJcI6bA root-35']//i[@class='css-52 root-43 ms-Button-icon thm-head-a1-color--medflat icon-38']";
        public IWebElement ShowFilterPaneInOutboundForStock => Driver.FindElement(By.XPath(ShowFilterPaneInOutboundForStockXpath));

        public const string FilterInOutboundForStockXpath = "//div//div//div//div//div//div//div//div//div//div//div//div[1]//div[2]//div[2]//div[1]//div[1]//div[1]//button[1]//div[1]//div[1]//div[1]";
        public IWebElement FilterInOutboundForStock => Driver.FindElement(By.XPath(FilterInOutboundForStockXpath));

        public const string FromDropdownISelectStatusOutboundOrderXpath = "//input[@aria-autocomplete='inline']";
        public IWebElement FromDropdownISelectStatusOutboundOrder => Driver.FindElement(By.XPath(FromDropdownISelectStatusOutboundOrderXpath));

        public const string ClickOnFilterToAddPlusXpath = "//button[@aria-label='Add a new filter on a field']/span/i";

        public IWebElement ClickOnFilterToAddPlus => Driver.FindElement(By.XPath(ClickOnFilterToAddPlusXpath));

        public const string SelectLoadedAfterOutboundOrderXpath = "(//i[@data-icon-name='CheckMark'])[5]";
        public IWebElement SelectLoadedAfterOutboundOrder => Driver.FindElement(By.XPath(SelectLoadedAfterOutboundOrderXpath));

        public const string SelectDropdownForStatusOutboundOrderXpath = "(//div[@class='comboboxcontrol']/div/div/div/div)[2]";
        public IWebElement SelectDropdownForStatusOutboundOrder => Driver.FindElement(By.XPath(SelectDropdownForStatusOutboundOrderXpath));

        public const string SelectComplaintsXpath = "/html/body/div[3]/div/div/div/div/div/div/ul/li[1]/div/div/a/div";
        public IWebElement SelectComplaints => Driver.FindElement(By.XPath(SelectComplaintsXpath));

        public const string CardInComplaintsIrregularityListXpath = "//span[contains(text(),'Card')]";
        public IWebElement CardInComplaintsIrregularityList => Driver.FindElement(By.XPath(CardInComplaintsIrregularityListXpath));

        public const string ManageInComplaintsCardXpath = "//div[@class='button-container--iUT6fwygh610UC-k6esrT command-bar-button-container--1ms9JCUCujkBljIx4C1GfY first-item--15AeWXqkjbAQCNaM3tqgcY first-item--15AeWXqkjbAQCNaM3tqgcY']//span[contains(text(),'Manage')]";
        public IWebElement ManageInComplaintsCard => Driver.FindElement(By.XPath(ManageInComplaintsCardXpath));

        public const string NewInComplaintsCardXpath = "//span[@class='thm-head-a2-color-2--medflat thm-head-a2-font-size-5--medflat thm-head-a2-font-stack-2--medflat']//span[contains(text(),'New')]";
        public IWebElement NewInComplaintsCard => Driver.FindElement(By.XPath(NewInComplaintsCardXpath));

        public const string SelectCustomerInitialXpath = "/html/body/div[1]/div[5]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[1]/div[2]/div/div[1]/div/input";
        public IWebElement SelectCustomerInitial => Driver.FindElement(By.XPath(SelectCustomerInitialXpath));

        public const string InComplaintsResponsibilitySelectXpath = "/html/body/div[1]/div[5]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[1]/div[2]/div/div[13]/div/input";
        public IWebElement InComplaintsResponsibilitySelect => Driver.FindElement(By.XPath(InComplaintsResponsibilitySelectXpath));

        public const string InComplaintsReasonSelectXpath = "/html/body/div[1]/div[5]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[1]/div[2]/div/div[14]/div/input";
        public IWebElement InComplaintsReasonSelect => Driver.FindElement(By.XPath(InComplaintsReasonSelectXpath));

        public const string WriteOutboundCodeInOutboundInputFieldXpath = "/html/body/div[1]/div[5]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[1]/div[2]/div/div[15]/div/input";
        public IWebElement WriteOutboundCodeInOutboundInputField => Driver.FindElement(By.XPath(WriteOutboundCodeInOutboundInputFieldXpath));

        public const string MakeArchiveXpath = "/html/body/div[1]/div[5]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[1]/div[2]/div/div[16]/div/a";
        public IWebElement MakeArchive => Driver.FindElement(By.XPath(MakeArchiveXpath));

        public const string OkFromPopUpAfterIClickMakeArchiveXpath = "/html/body/div[1]/div[6]/form/div/div/div[3]/div/button/span";
        public IWebElement OkFromPopUpAfterIClickMakeArchive => Driver.FindElement(By.XPath(OkFromPopUpAfterIClickMakeArchiveXpath));

        public const string WriteOnAdventexDeliveryNumberXpath = "/html/body/div[1]/div[5]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[1]/div[2]/div/div[20]/div[2]/div[1]/div/input";
        public IWebElement WriteOnAdventexDeliveryNumber => Driver.FindElement(By.XPath(WriteOnAdventexDeliveryNumberXpath));

        public const string SelectComplaintAfterActionsXpath = "//span[contains(text(),'Complaint')]";
        public IWebElement SelectComplaintAfterActions => Driver.FindElement(By.XPath(SelectComplaintAfterActionsXpath));

        public const string FinishAndCloseXpath = "//div[@class='thm-popp-a2-font-stack-2--minflat thm-popp-a2-font-size-2--minflat thm-popp-a2-color-2--minflat']";
        public IWebElement FinishAndClose => Driver.FindElement(By.XPath(FinishAndCloseXpath));

        public const string HolderUnitAndISelectEUROXpath = "//span[contains(text(),'Holder Unit')]";
        public IWebElement HolderUnitAndISelectEURO => Driver.FindElement(By.XPath(HolderUnitAndISelectEUROXpath));

        public const string EuroFromHolderUnitXpath = "//input[@class='cursorinherit stringcontrol-edit thm-cont-u1-font-size thm-cont-u1-font-stack thm-cont-u1-color-2--medflat thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus thm-cont-h1-bdrcolor--hover thm-cont-h1-bdrcolor--prev-sib-hover']";
        public IWebElement EuroFromHolderUnit => Driver.FindElement(By.XPath(EuroFromHolderUnitXpath));

        public const string OnQtyToCancelXpath = "//div[@class='single-column-group']//div[@class='ms-nav-edit-control-container show-border']//div[@class='edit-container right thm-cont-g0-bgcolor-1']/input[1]";
        public IWebElement OnQtyToCancel => Driver.FindElement(By.XPath(OnQtyToCancelXpath));

        public const string MaxNumberOnMultiOrderXpath = "/html/body/div[1]/div[4]/form/div[2]/div/div[3]/div[1]/div/div[3]/div/div/div/div[8]/div/input";
        public IWebElement MaxNumberOnMultiOrder => Driver.FindElement(By.XPath(MaxNumberOnMultiOrderXpath));

        public const string EnterDateToLoadOutboundXpath = "//div[@controlname='Date to load']//div//input";
        public IWebElement EnterDateToLoadOutbound => Driver.FindElement(By.XPath(EnterDateToLoadOutboundXpath));

        public const string SetupXpath = "//span[@aria-label='Setup']";
        public IWebElement Setup => Driver.FindElement(By.XPath(SetupXpath));

        public const string NasSimulatorClickXpath = "//div[text()='Nas Simulator']";
        public IWebElement NasSimulatorClick => Driver.FindElement(By.XPath(NasSimulatorClickXpath));

        public const string ShowFilterPaneXpath = "//button[@title='Show filter pane']";
        public IWebElement ShowFilterPane => Driver.FindElement(By.XPath(ShowFilterPaneXpath));

        public const string WriteOnFilterInputXpath = "//input[starts-with(@class,'ms-ComboBox-Input')]";
        public IWebElement WriteOnFilterInput => Driver.FindElement(By.XPath(WriteOnFilterInputXpath));

        public const string OutboundOnFilterDropdown_QueueGroupListXpath = "//button[18]//div[1]";
        public IWebElement OutboundOnFilterDropdown_QueueGroupList => Driver.FindElement(By.XPath(OutboundOnFilterDropdown_QueueGroupListXpath));

        public const string Code_QuegroupDropdownXpath = "//button[11]//div[1]";
        public IWebElement Code_QuegroupDropdown => Driver.FindElement(By.XPath(Code_QuegroupDropdownXpath));

        public const string LinkOnMoreOptionsQueGroupXpath = "//a[@aria-label='Link']";
        public IWebElement LinkOnMoreOptionsQueGroup => Driver.FindElement(By.XPath(LinkOnMoreOptionsQueGroupXpath));

        const string LinkToATransportXpath = "//div[contains(text(),'Link To a Transport')]";
        public IWebElement LinkToATransport => Driver.FindElement(By.XPath(LinkToATransportXpath));

        public const string NewXpath = "//span[contains(text(), 'New')]";
        public IWebElement New => Driver.FindElement(By.XPath(NewXpath));

        public const string FillReferenceXpath = "//div[@class='collapsibleTab']//div[2]//div[2]//div[5]//div[1]//input[1]";
        public IWebElement FillReference => Driver.FindElement(By.XPath(FillReferenceXpath));

        public const string DestinationOrderNrXpath = "//input[starts-with(@aria-label,'Destination ordernr')]";
        public IWebElement DestinationOrderNr => Driver.FindElement(By.XPath(DestinationOrderNrXpath));

        public const string ClientShipmentNrXpath = "//input[starts-with(@aria-label,'Client shipment')]";
        public IWebElement ClientShipmentNr => Driver.FindElement(By.XPath(ClientShipmentNrXpath));

        public const string InsertTypeCodeTROXpath = "//div[@controlname='Type Transport']//div//input";
        public IWebElement InsertTypeCodeTRO => Driver.FindElement(By.XPath(InsertTypeCodeTROXpath));

        public const string InsertTypeCodeOutboundTROXpath = "//input[starts-with(@aria-label,'Type') and starts-with(@class,'cursorinherit stringcontrol')]";
        public IWebElement InsertTypeCodeOutboundTRO => Driver.FindElement(By.XPath(InsertTypeCodeOutboundTROXpath));

        public const string InsertCarrierBookedTROXpath = "//div[@controlname='Carrier Booked']//div//input";
        public IWebElement InsertCarrierBookedTRO => Driver.FindElement(By.XPath(InsertCarrierBookedTROXpath));

        public const string EnterTypeOutboundTROXpath = "//input[starts-with(@aria-label,'Type Outbound') and starts-with(@class,'cursorinherit stringcontrol')]";
        public IWebElement EnterTypeOutboundTRO => Driver.FindElement(By.XPath(EnterTypeOutboundTROXpath));

        public const string EnterDateExpectedArrivalXpath = "//div[@class='ms-nav-group']//div[1]//div[1]//div[1]//div[2]//div[1]//div[1]//input[1]";
        public IWebElement EnterDateExpectedArrival => Driver.FindElement(By.XPath(EnterDateExpectedArrivalXpath));

        public const string EnterTimeExpectedArrivalXpath = "//div[@class='ms-nav-group']//div[1]//div[1]//div[1]//div[3]//div[1]//div[1]//input[1]";
        public IWebElement EnterTimeExpectedArrival => Driver.FindElement(By.XPath(EnterTimeExpectedArrivalXpath));

        public const string EnterDateExpectedDeliveryXpath = "//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div[2]//div[1]//div[1]//div[2]//div[1]//div[1]//input[1]";
        public IWebElement EnterDateExpectedDelivery => Driver.FindElement(By.XPath(EnterDateExpectedDeliveryXpath));

        public const string EnterTimeExpectedDeliveryXpath = "//div[@class='ms-nav-band-container']//div[2]//div[1]//div[1]//div[3]//div[1]//div[1]//input[1]";
        public IWebElement EnterTimeExpectedDelivery => Driver.FindElement(By.XPath(EnterTimeExpectedDeliveryXpath));

        public const string MoreOptionsTabTROXpath = "(//span[contains(text(),'More options')])[2]";
        public IWebElement MoreOptionsTabTRO => Driver.FindElement(By.XPath(MoreOptionsTabTROXpath));

        public const string ClickActionsInTROUnlinkingXpath = "(//span[@aria-label='Actions'])[2]";
        public IWebElement ClickActionsInTROUnlinking => Driver.FindElement(By.XPath(ClickActionsInTROUnlinkingXpath));

        public const string MoreOptionsBasicTROXpath = "(//span[@aria-label='More options'])[2]";
        public IWebElement MoreOptionsBasicTRO => Driver.FindElement(By.XPath(MoreOptionsBasicTROXpath));

        public const string ExpectedArrivalDateTROXpath = "//div[@controlname='Date Expected arrival']//div//input";
        public IWebElement ExpectedArrivalDateTRO => Driver.FindElement(By.XPath(ExpectedArrivalDateTROXpath));

        public const string ExpectedArrivalTimeTROXpath = "//div[@controlname='Time Expected arrival']//div//input";
        public IWebElement ExpectedArrivalTimeTRO => Driver.FindElement(By.XPath(ExpectedArrivalTimeTROXpath));

        public const string ExpectedDeliveryDateTROXpath = "//div[@controlname='Date Expected Delivery']//div//input";
        public IWebElement ExpectedDeliveryDateTRO => Driver.FindElement(By.XPath(ExpectedDeliveryDateTROXpath));

        public const string ExpectedDeliveryTimeTROXpath = "//div[@controlname='Time Expected Delivery']//div//input";
        public IWebElement ExpectedDeliveryTimeTRO => Driver.FindElement(By.XPath(ExpectedDeliveryTimeTROXpath));

        public const string MoreOptionsTROMainTabXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[4]/div/div/div/div[1]/div[2]/div/div[1]/div/div/div/div/div[6]/div/a/div";
        public IWebElement MoreOptionsTROMainTab => Driver.FindElement(By.XPath(MoreOptionsTROMainTabXpath));

        public const string ActionsXpath = "//span[@aria-label='Actions']";
        public IWebElement Actions => Driver.FindElement(By.XPath(ActionsXpath));

        public const string TRIActionOtherXpath = "//span[(@aria-label='Other')]";   
        public IWebElement TRIActionOther => Driver.FindElement(By.XPath(TRIActionOtherXpath));

        public const string ClosePalletPoolTROXpath = "//button[@data-is-focusable='true']//following::span[contains(text(),'Close')]";
        public IWebElement ClosePalletPoolTRO => Driver.FindElement(By.XPath(ClosePalletPoolTROXpath));

        public const string TransportTabXpath = "(//span[@aria-label='Transport'])[1]";
        public IWebElement TransportTab => Driver.FindElement(By.XPath(TransportTabXpath));

        public const string TransportTabAfterActionInTROXpath = "(//span[@aria-label='Transport'])[3]";
        public IWebElement TransportTabAfterActionInTRO => Driver.FindElement(By.XPath(TransportTabAfterActionInTROXpath));

        public const string DestinationGroupXpath = "//div[contains(text(),'Destination Group')]";
        public IWebElement DestinationGroup => Driver.FindElement(By.XPath(DestinationGroupXpath));

        public const string DestinationGroupErrorMessageQGXpath = "//img[@aria-label='Validation Results Destination Group has linked Queue Groups!']";
        public IWebElement DestinationGroupErrorMessageQG => Driver.FindElement(By.XPath(DestinationGroupErrorMessageQGXpath));

        public const string DestinationGroupEnterDPDXpath = "/html/body/div[1]/div[6]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[1]/div/div[2]/table/tbody/tr[1]/td[5]";
        public IWebElement DestinationGroupEnterDPD => Driver.FindElement(By.XPath(DestinationGroupEnterDPDXpath));

        public const string GoBackFromDestinationGroupXpath = "//button[@data-is-focusable='true']";
        public IWebElement GoBackFromDestinationGroup => Driver.FindElement(By.XPath(GoBackFromDestinationGroupXpath));

        public const string GoBackToLinkFromNewTROXpath = "//button[(@data-is-focusable='true')and(@title='Back')]";
        public IWebElement GoBackToLinkFromNewTRO => Driver.FindElement(By.XPath(GoBackToLinkFromNewTROXpath));

        public const string SearchInputTRO_PowerTransporOutboundListXpath = "//input[starts-with(@aria-label,'Search')]";
        public IWebElement SearchInputTRO_PowerTransporOutboundList => Driver.FindElement(By.XPath(SearchInputTRO_PowerTransporOutboundListXpath));

        public const string SearchButtonTRO_PowerTransporOutboundListXpath = "//div[starts-with(@class,'search-box-container')]";
        public IWebElement SearchButtonTRO_PowerTransporOutboundList => Driver.FindElement(By.XPath(SearchButtonTRO_PowerTransporOutboundListXpath));

        public const string SearchButtonTROOutboundListXpath = "//i[@data-icon-name='Search']";
        public IWebElement SearchButtonTROOutboundList => Driver.FindElement(By.XPath(SearchButtonTROOutboundListXpath));

        public const string SearchBoxXpath = "//input[@placeholder='Search']";
        public IWebElement SearchBox => Driver.FindElement(By.XPath(SearchBoxXpath));

        public const string MoreOptionsTROQueueGroupXpath = "/html/body/div[1]/div[5]/form/div/div[2]/div[4]/div/div/div/div[1]/div[2]/div/div[1]/div/div/div/div/div[6]/div/a/div/div[2]";
        public IWebElement MoreOptionsTROQueueGroup => Driver.FindElement(By.XPath(MoreOptionsTROQueueGroupXpath));

        public const string DestinationGroupEnterDPDInputXpath = "//td[@controlname='Destination Group']//input";
        public IWebElement DestinationGroupEnterDPDInput => Driver.FindElement(By.XPath(DestinationGroupEnterDPDInputXpath));

        public const string AlreadyFilledDestinationGroupXpath = "(//td[@tabindex='0']//span)[1]";
        public IWebElement AlreadyFilledDestinationGroup => Driver.FindElement(By.XPath(AlreadyFilledDestinationGroupXpath));

        public const string OK_PowerTransportOutboundListXpath = "/html/body/div[1]/div[4]/form/div[2]/div/div[4]/button[1]";
        public IWebElement OK_PowerTransportOutboundList => Driver.FindElement(By.XPath(OK_PowerTransportOutboundListXpath));

        public const string IShouldSeePopupMessageAfterLinkWithWrongTRODestinationGroupXpath = "//div[starts-with(@class,'ms-nav-logical')]//following::p[contains(text(),'Destination Group')]";
        public IWebElement IShouldSeePopupMessageAfterLinkWithWrongTRODestinationGroup => Driver.FindElement(By.XPath(IShouldSeePopupMessageAfterLinkWithWrongTRODestinationGroupXpath));

        public const string IShouldGetBATCHWAVEXpath = "//tr[1]//td[starts-with(@class,'thm-cont')]//span[@title='Replenishment']";
        public IWebElement IShouldGetBATCHWAVE => Driver.FindElement(By.XPath(IShouldGetBATCHWAVEXpath));

        public const string InOrderEnterOrderLineTwoNOXpath = "//span[contains(text(),'Customs')]//following::div[contains(text(),'Order')]//following::tr[@aria-rowindex='2']//td[6]";
        public IWebElement InOrderEnterOrderLineTwoNO => Driver.FindElement(By.XPath(InOrderEnterOrderLineTwoNOXpath));

        public const string InOrderLineThreeIEnterOrderLineNOXpath = "//span[contains(text(),'Customs')]//following::div[contains(text(),'Order')]//following::tr[@aria-rowindex='3']//td[6]";
        public IWebElement InOrderLineThreeIEnterOrderLineNO => Driver.FindElement(By.XPath(InOrderLineThreeIEnterOrderLineNOXpath));

        public const string InOrderLineThreeIEnterOrderLineInputNOXpath = "//td[@controlname='Order Line No Customer']//input";
        public IWebElement InOrderLineThreeIEnterOrderLineInputNO => Driver.FindElement(By.XPath(InOrderLineThreeIEnterOrderLineInputNOXpath));

        public const string InOrderEnterOrderLineTwoInputNoXpath = "(//input[contains(@class,'cursorinherit stringcontrol-edit thm-cont-u1-font-size thm-cont-u1-font-stack thm-cont-g2-bdrcolor-1 thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus thm-cont-u1-color-2--medflat thm-cont-h1-bdrcolor--hover thm-cont-h1-bdrcolor--prev-sib-hover')])[1]";
        public IWebElement InOrderEnterOrderLineTwoInputNo => Driver.FindElement(By.XPath(InOrderEnterOrderLineTwoInputNoXpath));

        public const string BookBackSelectedRecordsOnOpenedCard_QueueGroupListXpath = "//span[contains(text(),'Book Back selected records')]";
        public IWebElement BookBackSelectedRecordsOnOpenedCard_QueueGroupList => Driver.FindElement(By.XPath(BookBackSelectedRecordsOnOpenedCard_QueueGroupListXpath));

        public const string ClickCloseAfterOpenedCardXpath = "/html/body/div[1]/div[4]/form/div[2]/div/div[4]/button[2]/span";
        public IWebElement ClickCloseAfterOpenedCard => Driver.FindElement(By.XPath(ClickCloseAfterOpenedCardXpath));

        public const string GoBackFromQuegroupXpath = "//button[starts-with(@class,'ms-Button ms-Button--icon back-button') and starts-with(@title,'Back')]";
        public IWebElement GoBackFromQuegroup => Driver.FindElement(By.XPath(GoBackFromQuegroupXpath));

        public const string IShouldGetStatusOutboundOrderInOutboundDetailsXpath = "//div[starts-with(@class,'edit-container right')]//following::span[@title='In Order']";
        public IWebElement IShouldGetStatusOutboundOrderInOutboundDetails => Driver.FindElement(By.XPath(IShouldGetStatusOutboundOrderInOutboundDetailsXpath));

        public const string IShouldGetStatusOutboundOrderReservedXpath = "//div[starts-with(@class,'edit-container right')]//following::span[@title='Reserved']";
        public IWebElement IShouldGetStatusOutboundOrderReserved => Driver.FindElement(By.XPath(IShouldGetStatusOutboundOrderReservedXpath));

        public const string IShouldGetStatusOutboundOrderInOrderXpath = "//div[starts-with(@class,'edit-container right')]//following::span[@title='In Order']";
        public IWebElement IShouldGetStatusOutboundOrderInOrder => Driver.FindElement(By.XPath(IShouldGetStatusOutboundOrderInOrderXpath));

        public const string IShouldGetErrorOutboundDifferenceXpath = "/html/body/div[1]/div[5]/form/div[2]/div/div[1]/div[3]/div/div/div/div[1]/div/div[1]";
        public IWebElement IShouldGetErrorOutboundDifference => Driver.FindElement(By.XPath(IShouldGetErrorOutboundDifferenceXpath));

        public const string IShouldGetErrorBookBackPartOfSelectedLineXpath = "/html/body/div[1]/div[5]/form/div/div/div[1]/div/div[2]/div/p";
        public IWebElement IShouldGetErrorBookBackPartOfSelectedLine => Driver.FindElement(By.XPath(IShouldGetErrorBookBackPartOfSelectedLineXpath));

        public const string TransportOutboundXpath = "//div[@class='cue-tile-container']//a[starts-with(@title,'Transport Outbounds')]";
        public IWebElement TransportOutbound => Driver.FindElement(By.XPath(TransportOutboundXpath));

        public const string ShowFilterPaneTransportOutboundXpath = "//button[@aria-label='Toggle filter']//span//i";
        public IWebElement ShowFilterPaneTransportOutbound => Driver.FindElement(By.XPath(ShowFilterPaneTransportOutboundXpath));

        public const string FilterInTransportOutboundXpath = "(//i[@data-icon-name='Add'])[1]";
        public IWebElement FilterInTransportOutbound => Driver.FindElement(By.XPath(FilterInTransportOutboundXpath));

        public const string DeleteInTransportOutboundXpath = "(//span[@aria-label='Delete'])[2]";
        public IWebElement DeleteInTransportOutbound => Driver.FindElement(By.XPath(DeleteInTransportOutboundXpath));

        public const string ReportsMainPageXpath = "(//div[starts-with(@class, 'action-caption-container')])[2]";
        public IWebElement ReportsMainPage => Driver.FindElement(By.XPath(ReportsMainPageXpath));

        public const string InsertSearchOptionTROListXpath = "//input[@placeholder='Search']";
        public IWebElement InsertSearchOptionTROList => Driver.FindElement(By.XPath(InsertSearchOptionTROListXpath));

        public const string EditOptionTROListXpath = "//span[@aria-label='Edit']";
        public IWebElement EditOptionTROList => Driver.FindElement(By.XPath(EditOptionTROListXpath));

        public const string ClickActions_TROXpath = "(//span[contains(text(),'Actions')])[2]";
        public IWebElement ClickActions_TRO => Driver.FindElement(By.XPath(ClickActions_TROXpath));

        public const string ClickTransport_TROXpath = "(//span[@aria-label='Transport'])[3]";
        public IWebElement ClickTransport_TRO => Driver.FindElement(By.XPath(ClickTransport_TROXpath));

        public const string ClickTransportInTRO_CardXpath = "(//span[@aria-label='Transport'])[2]";
        public IWebElement ClickTransportInTRO_Card => Driver.FindElement(By.XPath(ClickTransportInTRO_CardXpath));

        public const string ClickProcessOutboundXpath = "//span[@aria-label='Process']";

        public IWebElement ClickProcessOutbound => Driver.FindElement(By.XPath(ClickProcessOutboundXpath));

        public const string ClickUnlinkSelectedPOWOutListXpath = "//span[@aria-label='Unlink Selected From transport']";

        public IWebElement ClickUnlinkSelectedPOWOutList => Driver.FindElement(By.XPath(ClickUnlinkSelectedPOWOutListXpath));

        public const string ClickTransportTabMain_TROXpath = "(//span[@aria-label='Transport'])[2]";
        public IWebElement ClickTransportTabMain_TRO => Driver.FindElement(By.XPath(ClickTransportTabMain_TROXpath));

        public const string ClickLinkQueueGruopPicking_TROXpath = "//span[@aria-label='Link Queue Group Picking']";
        public IWebElement ClickLinkQueueGruopPicking_TRO => Driver.FindElement(By.XPath(ClickLinkQueueGruopPicking_TROXpath));

        public const string IClickLinkToATransportXpath = "//span[@aria-label='Link To a Transport']";
        public IWebElement IClickLinkToATransport => Driver.FindElement(By.XPath(IClickLinkToATransportXpath));

        public const string ClickOnSecondLinePOWERQUEUEGROUPLISTXpath = "//tr[@aria-rowindex='2']//span[starts-with(@aria-label,'Consolidation')]";
        public IWebElement ClickOnSecondLinePOWERQUEUEGROUPLIST => Driver.FindElement(By.XPath(ClickOnSecondLinePOWERQUEUEGROUPLISTXpath));

        public const string ViewLinkedQueueGroupsXpath = "//span[@aria-label='View Linked Queue Groups']";
        public IWebElement ViewLinkedQueueGroups => Driver.FindElement(By.XPath(ViewLinkedQueueGroupsXpath));

        public const string MainMenu_TROXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[3]/div/div/div/div[1]/div[2]/div/div[1]/div";
        public IWebElement MainMenu_TRO => Driver.FindElement(By.XPath(MainMenu_TROXpath));

        public const string IShouldGetNotificationOutboundCancelOrderlineXpath = "//div[starts-with(@class,'ms-nav-logical')]//following::p[contains(text(),'# To Reserve')]";
        public IWebElement IShouldGetNotificationOutboundCancelOrderline => Driver.FindElement(By.XPath(IShouldGetNotificationOutboundCancelOrderlineXpath));

        public const string IShouldGetNotificationTROPrintMessageXpath = "//span[@class='ms-nav-exceptionmessage']";
        public IWebElement IShouldGetNotificationTROPrintMessage => Driver.FindElement(By.XPath(IShouldGetNotificationTROPrintMessageXpath));

        public const string IGetPowerbatchCardStatusXpath = "//div[@class='ms-nav-edit-control-container']//span[@title='Calculated']";
        public IWebElement IGetPowerbatchCardStatus => Driver.FindElement(By.XPath(IGetPowerbatchCardStatusXpath));

        public const string IGetBatchNotificationXpath = "//div[starts-with(@class,'ms-nav-logical')]//following::p[contains(text(),'Status of')]";
        public IWebElement IGetBatchNotification => Driver.FindElement(By.XPath(IGetBatchNotificationXpath));

        public const string IGetCreatedBatchNotificationXpath = "//div[starts-with(@class,'ms-nav-logical')]//following::p[contains(text(),'Only QueueGroup with')]";
        public IWebElement IGetCreatedBatchNotification => Driver.FindElement(By.XPath(IGetCreatedBatchNotificationXpath));

        public const string IGetQueueGroupBatchNotificationXpath = "//div[starts-with(@class,'ms-nav-logical')]//following::p[contains(text(),'Queue Group [')]";
        public IWebElement IGetQueueGroupBatchNotification => Driver.FindElement(By.XPath(IGetQueueGroupBatchNotificationXpath));

        public const string IShouldGetDestinationNotificationOutboundCancelOrderlineXpath = "//div[starts-with(@class,'ms-nav-logical')]//following::p[contains(text(),'Destination Group')]";
        public IWebElement IShouldGetDestinationNotificationOutboundCancelOrderline => Driver.FindElement(By.XPath(IShouldGetDestinationNotificationOutboundCancelOrderlineXpath));

        public const string ThreeDotsOnTROQueueGroupList_TROXpath = "/html/body/div[1]/div[5]/form/div[2]/div/div[1]/div[1]/div/div/div/div[1]/div/div/div/div/div/div/div/div[7]/a/div";
        public IWebElement ThreeDotsOnTROQueueGroupList_TRO => Driver.FindElement(By.XPath(ThreeDotsOnTROQueueGroupList_TROXpath));

        public const string ActionsOnDropdown_TROQueueGroupListXpath = "//li[starts-with(@class,'ms-Context')]//a[@aria-label='Actions']";
        public IWebElement ActionsOnDropdown_TROQueueGroupList => Driver.FindElement(By.XPath(ActionsOnDropdown_TROQueueGroupListXpath));

        public const string QueueGroupOnDropdown_TROQueueGroupListXpath = "//li[starts-with(@class,'ms-Context')]//a[@aria-label='Queue Group']";
        public IWebElement QueueGroupOnDropdown_TROQueueGroupList => Driver.FindElement(By.XPath(QueueGroupOnDropdown_TROQueueGroupListXpath));

        public const string DeleteLinkedTransportPicking_TROQueueGroupListXpath = "//li[starts-with(@class,'ms-Context')]//a[@aria-label='Delete Linked Transport(picking)']";
        public IWebElement DeleteLinkedTransportPicking_TROQueueGroupList => Driver.FindElement(By.XPath(DeleteLinkedTransportPicking_TROQueueGroupListXpath));

        public const string MoreOptionsOnQueueGroup_TROXpath = "/html/body/div[1]/div[5]/form/div[2]/div/div[1]/div[1]/div/div/div/div[1]/div/div/div/div/div/div/div/div[7]/a/div";
        public IWebElement MoreOptionsOnQueueGroup_TRO => Driver.FindElement(By.XPath(MoreOptionsOnQueueGroup_TROXpath));

        public const string MoreOptionsOnQueueGroup_TROWritenXpath = "//div[contains(text(),'More options')]";
        public IWebElement MoreOptionsOnQueueGroup_TROWriten => Driver.FindElement(By.XPath(MoreOptionsOnQueueGroup_TROWritenXpath));

        public const string IShouldGetNotificationOnDeleteLinkedTransportPicking_TROQueueGroupListXpath = "/html/body/div[1]/div[6]/form/div/div/div[1]/div/div[2]/div/p";
        public IWebElement IShouldGetNotificationOnDeleteLinkedTransportPicking_TROQueueGroupList => Driver.FindElement(By.XPath(IShouldGetNotificationOnDeleteLinkedTransportPicking_TROQueueGroupListXpath));

        public const string WriteOnTypeFieldOutboundXpath = "//div[@controlname='Operation type']//div//input";
        public IWebElement WriteOnTypeFieldOutbound => Driver.FindElement(By.XPath(WriteOnTypeFieldOutboundXpath));

        public const string ShowMoreInGeneralTwoXpath = "//button[@aria-label='General2, Show more']";
        public IWebElement ShowMoreInGeneralTwo => Driver.FindElement(By.XPath(ShowMoreInGeneralTwoXpath));

        public const string ClickCloseFromBookedSuccesfullOutboundXpath = "//button[@data-is-focusable='true']//following::span[contains(text(),'Close')]";
        public IWebElement ClickCloseFromBookedSuccesfullOutbound => Driver.FindElement(By.XPath(ClickCloseFromBookedSuccesfullOutboundXpath));

        public const string ShouldGetDifferenceErrorInOutboundAfterCutOffXpath = "//div[@class='notification-area']//following::div[contains(text(),'Please Correct following difference')]";
        public IWebElement ShouldGetDifferenceErrorInOutboundAfterCutOff => Driver.FindElement(By.XPath(ShouldGetDifferenceErrorInOutboundAfterCutOffXpath));

        public const string ShouldGetErrorMessageXpath = "//p[contains(text(), 'QueueGroup')]";
        public IWebElement ShouldGetErrorMessage => Driver.FindElement(By.XPath(ShouldGetErrorMessageXpath));

        public const string NoQueueLeftInQueueListXpath = "(//span[contains(text(), '(There is nothing to show')])[2]";
        public IWebElement NoQueueLeftInQueueList => Driver.FindElement(By.XPath(NoQueueLeftInQueueListXpath));

        public const string BookBackPartOfSelectedLineOutboundXpath = "//span[contains(text(),'Book Back PART OF selected line')]";
        public IWebElement BookBackPartOfSelectedLineOutbound => Driver.FindElement(By.XPath(BookBackPartOfSelectedLineOutboundXpath));

        public const string ClickOKButtonOutboundXpath = "//span[contains(text(),'OK')]";
        public IWebElement ClickOKButtonOutbound => Driver.FindElement(By.XPath(ClickOKButtonOutboundXpath));

        public const string ClickOKButtonOutboundCalculateBatchXpath = "(//span[contains(text(),'OK')])[2]";
        public IWebElement ClickOKButtonOutboundCalculateBatch => Driver.FindElement(By.XPath(ClickOKButtonOutboundCalculateBatchXpath));

        public const string BackButtonOutboundCardXpath = "//button[@title='Back']";
        public IWebElement BackButtonOutboundCard => Driver.FindElement(By.XPath(BackButtonOutboundCardXpath));

        public const string BlockedReasonFieldOutboundXpath = "//td[@controlname='Blocked Reason']//input";
        public IWebElement BlockedReasonFieldOutbound => Driver.FindElement(By.XPath(BlockedReasonFieldOutboundXpath));

        public const string ProcessPowerOutboundListXpath = "//span[@aria-label='Process']";
        public IWebElement ProcessPowerOutboundList => Driver.FindElement(By.XPath(ProcessPowerOutboundListXpath));

        public const string EnterTransporterOnGeneralOutboundXpath = "//div[@controlname='Transporter']//div//input";
        public IWebElement EnterTransporterOnGeneralOutbound => Driver.FindElement(By.XPath(EnterTransporterOnGeneralOutboundXpath));

        public const string LOTNOOutboundOrderLineOutboundXpath = "//input[starts-with(@aria-label,'Lot No')]";
        public IWebElement LOTNOOutboundOrderLineOutbound => Driver.FindElement(By.XPath(LOTNOOutboundOrderLineOutboundXpath));

        public const string HolderSelectionHeaderXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[4]/div/div/div/div[1]/div[2]";
        public IWebElement HolderSelectionHeader => Driver.FindElement(By.XPath(HolderSelectionHeaderXpath));

        public const string MoreOptionsOnHolderStockSelectionXpath = "//span[contains(text(),'More options')]";
        public IWebElement MoreOptionsOnHolderStockSelection => Driver.FindElement(By.XPath(MoreOptionsOnHolderStockSelectionXpath));

        public const string HolderDropdownXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[4]/div/div/div/div[2]/div[2]/div/div/div[1]/div/div/div/div/div[1]/div/div/a/div";
        public IWebElement HolderDropdown => Driver.FindElement(By.XPath(HolderDropdownXpath));

        public const string BarcodeNumberINStockXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[1]/div/div[2]/table/tbody/tr[1]/td[8]/input";
        public IWebElement BarcodeNumberINStock => Driver.FindElement(By.XPath(BarcodeNumberINStockXpath));

        public const string BarcodeNumberINPickXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[1]/div/div[2]/table/tbody/tr[2]/td[8]/input";
        public IWebElement BarcodeNumberINPick => Driver.FindElement(By.XPath(BarcodeNumberINPickXpath));

        public const string PickLineSelectXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[1]/div/div[2]/table/tbody/tr[2]/td[1]";
        public IWebElement PickLineSelect => Driver.FindElement(By.XPath(PickLineSelectXpath));

        public const string TrueFromBlockedXpath = "//option[contains(text(),'True')]";
        public IWebElement TrueFromBlocked => Driver.FindElement(By.XPath(TrueFromBlockedXpath));

        public const string PackListBeingPrinterOKButtonXpath = "//button[@id='btnOK']";
        public IWebElement PackListBeingPrinterOKButton => Driver.FindElement(By.XPath(PackListBeingPrinterOKButtonXpath));

        public const string GoBackPowerHolderTypeListXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[1]/div/div/div[1]/button";
        public IWebElement GoBackPowerHolderTypeList => Driver.FindElement(By.XPath(GoBackPowerHolderTypeListXpath));

        public const string GoBackPowerHolderStockSelectionXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[1]/div/div/div[1]/button";
        public IWebElement GoBackPowerHolderStockSelection => Driver.FindElement(By.XPath(GoBackPowerHolderStockSelectionXpath));

        public const string IGetErrorOutboundXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[4]/div[2]/div/div[2]";
        public IWebElement IGetErrorOutbound => Driver.FindElement(By.XPath(IGetErrorOutboundXpath));

        public const string NavBarOnQueueGroupOutboundXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[4]/div/div/div/div[1]";
        public IWebElement NavBarOnQueueGroupOutbound => Driver.FindElement(By.XPath(NavBarOnQueueGroupOutboundXpath));

        public const string BookBackAllInStockMasterXpath = "//span[contains(text(),'Book back selected records')]";
        public IWebElement BookBackAllInStockMaster => Driver.FindElement(By.XPath(BookBackAllInStockMasterXpath));

        public const string ClickDateTimeOnTRIXpath = "//span[contains(text(),'Book BACK Selected records')]";
        public IWebElement ClickDateTimeOnTRI => Driver.FindElement(By.XPath(ClickDateTimeOnTRIXpath));

        public const string ClickTheThreeDotsOnTheAddedRecordInExpectedXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[4]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[4]/a";
        public IWebElement ClickTheThreeDotsOnTheAddedRecordInExpected => Driver.FindElement(By.XPath(ClickTheThreeDotsOnTheAddedRecordInExpectedXpath));

        public const string ClickSelectMoreInExpectedLinesDotsXpath = "//span[contains(text(), 'Select More')]";
        public IWebElement ClickSelectMoreInExpectedLinesDots => Driver.FindElement(By.XPath(ClickSelectMoreInExpectedLinesDotsXpath));

        public const string ClickSelectAllCheckboxFromLinesInExpectedXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[4]/div[2]/div/div/div/div[1]/table/thead/tr/th[2]/label";
        public IWebElement ClickSelectAllCheckboxFromLinesInExpected => Driver.FindElement(By.XPath(ClickSelectAllCheckboxFromLinesInExpectedXpath));

        public const string ClickDeleteLineInExpectedXpath = "//span[contains(text(), 'Delete Line')]";
        public IWebElement ClickDeleteLineInExpected => Driver.FindElement(By.XPath(ClickDeleteLineInExpectedXpath));

        public const string ClickFilterPaneInTRIXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[4]/div/div/div/div[1]/div[2]/div/div[4]/button";
        public IWebElement ClickFilterPaneInTRI => Driver.FindElement(By.XPath(ClickFilterPaneInTRIXpath));

        public const string ChangeFilterClosedToXpath = "//select[contains(@class,'numerationcontrol-edit')]";
        public IWebElement ChangeFilterClosedTo => Driver.FindElement(By.XPath(ChangeFilterClosedToXpath));

        public const string ClickViewLinkedInboundDeliveriesFromTheNavigationBarXXpath = "//div[contains(text(),'View Linked Inbound Deliveries')]";
        public IWebElement ClickViewLinkedInboundDeliveriesFromTheNavigationBarX => Driver.FindElement(By.XPath(ClickViewLinkedInboundDeliveriesFromTheNavigationBarXXpath));

        public const string ClickManageInEDIMessageTableXpath = "//span[@aria-label='Manage']";
        public IWebElement ClickManageInEDIMessageTable => Driver.FindElement(By.XPath(ClickManageInEDIMessageTableXpath));

        public const string ClickDeleteLineInEDIMessageTableXpath = "//span[@aria-label='Delete Line']";
        public IWebElement ClickDeleteLineInEDIMessageTable => Driver.FindElement(By.XPath(ClickDeleteLineInEDIMessageTableXpath));

        public const string KTNSchedulerXpath = "/html/body/div[1]/div[2]/form/div/div[2]/main/div[2]/div[2]/div/div[3]/div[2]/div/div[4]/ul/li/div/div/a/div[1]/span";
        public IWebElement KTNScheduler => Driver.FindElement(By.XPath(KTNSchedulerXpath));

        public const string SearchButtonTransporOutboundListXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[3]/div/div/div/div[1]/div[2]/div/div[1]/div[1]/div/i";
        public IWebElement SearchButtonTransporOutboundList => Driver.FindElement(By.XPath(SearchButtonTransporOutboundListXpath));

        public const string SearchInputTransporOutboundListXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[3]/div/div/div/div[1]/div[2]/div/div[1]/div[1]/input";
        public IWebElement SearchInputTransporOutboundList => Driver.FindElement(By.XPath(SearchInputTransporOutboundListXpath));

        public const string EditButtonTransporOutboundListXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[3]/div/div/div/div[1]/div[2]/div/div[2]/div/div/div/div/div[4]/div/div/a/div/div[2]/span/span";
        public IWebElement EditButtonTransporOutboundList => Driver.FindElement(By.XPath(EditButtonTransporOutboundListXpath));

        public const string FilterPaneInKTNSchedulerXpath = "//button[@class='ms-Button ms-Button--icon command-bar-button--2vOMW0YBNkKcDAlSFF9lUJ system-action-control--71j3QkyQSurez2TowswCH thm-head-g1-bgcolor thm-popp-h2-bgcolor--hover fade-out-transition--2bZPl-hV_UISWOGTJcI6bA root-35']//i[@class='css-52 root-43 ms-Button-icon thm-head-a1-color--medflat icon-38']";
        public IWebElement FilterPaneInKTNScheduler => Driver.FindElement(By.XPath(FilterPaneInKTNSchedulerXpath));

        public const string FilterInKTNSchedulerXpath = "//div[@class='filter-pane-content--1r-gKrqgvu-CWiejhmbnrZ']//div[1]//div[2]//div[2]//div[1]//div[1]//div[1]//button[1]//div[1]//div[1]//div[1]";
        public IWebElement FilterInKTNScheduler => Driver.FindElement(By.XPath(FilterInKTNSchedulerXpath));

        public const string SelectObjectIDFromDropdownXpath = "/html[1]/body[1]/div[1]/div[3]/form[1]/div[1]/div[2]/div[5]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]";
        public IWebElement SelectObjectIDFromDropdown => Driver.FindElement(By.XPath(SelectObjectIDFromDropdownXpath));

        public const string EnterCodeInKTNSchedulerXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[5]/div[2]/div[1]/div[2]/div/div[2]/div/div/div[1]/div[2]/div[1]/div[3]/div[2]/input";
        public IWebElement EnterCodeInKTNScheduler => Driver.FindElement(By.XPath(EnterCodeInKTNSchedulerXpath));

        public const string SelectAUTOCLOSEIRRFromTableXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div/div[2]/table/tbody/tr[3]/td[6]";
        public IWebElement SelectAUTOCLOSEIRRFromTable => Driver.FindElement(By.XPath(SelectAUTOCLOSEIRRFromTableXpath));

        public const string ClickMoreOptionsInKTNSchedulerXpath = "//span[contains(text(),'More options')]";
        public IWebElement ClickMoreOptionsInKTNScheduler => Driver.FindElement(By.XPath(ClickMoreOptionsInKTNSchedulerXpath));

        public const string ClickActionsInKTNSchedulerXpath = "//span[contains(text(),'Actions')]";
        public IWebElement ClickActionsInKTNScheduler => Driver.FindElement(By.XPath(ClickActionsInKTNSchedulerXpath));

        public const string ClickRunInKTNSchedulerXpath = "//span[contains(text(),'Run')]";
        public IWebElement ClickRunInKTNScheduler => Driver.FindElement(By.XPath(ClickRunInKTNSchedulerXpath));

        public const string OutboundLineCodeXpath = "//body/div/div/form/div/div/div/div/div/div/div/div/div/div/table/tbody/tr/td[3]";
        public IWebElement OutboundLineCode => Driver.FindElement(By.XPath(OutboundLineCodeXpath));

        public const string PickHoldersTabXpath = "//body/div/div/form/div/div/div/div/div/div/div/div[6]/div[1]/span[1]";
        public IWebElement PickHoldersTab => Driver.FindElement(By.XPath(PickHoldersTabXpath));

        public const string PackingFromActionsXpath = "//div[contains(text(),'Packing')]";
        public IWebElement PackingFromActions => Driver.FindElement(By.XPath(PackingFromActionsXpath));

        public const string HolderLocationInputXpath = "//input[starts-with(@aria-label,'Holder/Location')]";
        public IWebElement HolderLocationInput => Driver.FindElement(By.XPath(HolderLocationInputXpath));

        public const string EnterTrailerPlateNoXpath = "//input[starts-with(@aria-label,'Trailer Plate No')]";
        public IWebElement EnterTrailerPlateNo => Driver.FindElement(By.XPath(EnterTrailerPlateNoXpath));

        public const string GoBackTransportOutboundCardXpath = "(//i[@data-icon-name='Back'])[2]";
        public IWebElement GoBackTransportOutboundCard => Driver.FindElement(By.XPath(GoBackTransportOutboundCardXpath));

        public const string GoBackTransportOutboundToMainPageXpath = "//i[@data-icon-name='Back']";
        public IWebElement GoBackTransportOutboundToMainPage => Driver.FindElement(By.XPath(GoBackTransportOutboundToMainPageXpath));

        public const string EnterTransportSentTimeTROXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div[1]/div[2]/div[5]/div/div/div[2]/div/div/input";
        public IWebElement EnterTransportSentTimeTRO => Driver.FindElement(By.XPath(EnterTransportSentTimeTROXpath));

        public const string EnterTransportSentTimeTROSecondInputXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div[1]/div[2]/div[5]/div/div/div[3]/div/div/input";
        public IWebElement EnterTransportSentTimeTROSecondInput => Driver.FindElement(By.XPath(EnterTransportSentTimeTROSecondInputXpath));

        public const string EnterConfirmedTimeTROXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div[1]/div[2]/div[6]/div/div/div[2]/div/div/input";
        public IWebElement EnterConfirmedTimeTRO => Driver.FindElement(By.XPath(EnterConfirmedTimeTROXpath));

        public const string EnterConfirmedTimeTROSecondInputXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div[1]/div[2]/div[6]/div/div/div[3]/div/div/input";
        public IWebElement EnterConfirmedTimeTROSecondInput => Driver.FindElement(By.XPath(EnterConfirmedTimeTROSecondInputXpath));

        public const string EnterExpectedArrivedDateXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div[1]/div[2]/div[7]/div/div/div[2]/div/div/input";
        public IWebElement EnterExpectedArrivedDate => Driver.FindElement(By.XPath(EnterExpectedArrivedDateXpath));

        public const string EnterExpectedArrivedDateSecondInputXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div[1]/div[2]/div[7]/div/div/div[3]/div/div/input";
        public IWebElement EnterExpectedArrivedDateSecondInput => Driver.FindElement(By.XPath(EnterExpectedArrivedDateSecondInputXpath));

        public const string EnterStartLoadingDateTimeTROXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div[1]/div[2]/div[8]/div/div/div[2]/div/div/input";
        public IWebElement EnterStartLoadingDateTimeTRO => Driver.FindElement(By.XPath(EnterStartLoadingDateTimeTROXpath));

        public const string EnterStartLoadingDateTimeTROSecondInputXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div[1]/div[2]/div[8]/div/div/div[3]/div/div/input";
        public IWebElement EnterStartLoadingDateTimeTROSecondInput => Driver.FindElement(By.XPath(EnterStartLoadingDateTimeTROSecondInputXpath));

        public const string EnterEndLoadingDateTimeTROXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div[1]/div[2]/div[9]/div/div/div[2]/div/div/input";
        public IWebElement EnterEndLoadingDateTimeTRO => Driver.FindElement(By.XPath(EnterEndLoadingDateTimeTROXpath));

        public const string EnterEndLoadingDateTimeTROSecondInputXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div[1]/div[2]/div[9]/div/div/div[3]/div/div/input";
        public IWebElement EnterEndLoadingDateTimeTROSecondInput => Driver.FindElement(By.XPath(EnterEndLoadingDateTimeTROSecondInputXpath));

        public const string EnterDepartedTimeTROXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div[1]/div[2]/div[10]/div/div/div[2]/div/div/input";
        public IWebElement EnterDepartedTimeTRO => Driver.FindElement(By.XPath(EnterDepartedTimeTROXpath));

        public const string EnterDepartedTimeTROSecondInputXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div[1]/div[2]/div[10]/div/div/div[3]/div/div/input";
        public IWebElement EnterDepartedTimeTROSecondInput => Driver.FindElement(By.XPath(EnterDepartedTimeTROSecondInputXpath));

        public const string EnterDeliveredDateTimeTROXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div[1]/div[2]/div[11]/div/div/div[2]/div/div/input";
        public IWebElement EnterDeliveredDateTimeTRO => Driver.FindElement(By.XPath(EnterDeliveredDateTimeTROXpath));

        public const string EnterDeliveredDateTimeTROSecondInputXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[2]/div[2]/div/div[1]/div[2]/div[11]/div/div/div[3]/div/div/input";
        public IWebElement EnterDeliveredDateTimeTROSecondInput => Driver.FindElement(By.XPath(EnterDeliveredDateTimeTROSecondInputXpath));

        public const string CloseTROActionsXpath = "//div[contains(text(), 'Close Transport')]";
        public IWebElement CloseTROActions => Driver.FindElement(By.XPath(CloseTROActionsXpath));

        public const string IShouldSeePopupMessageErrorAfterCLOSETROXpath = "//div[starts-with(@class,'ms-nav-logical')]//following::p[contains(text(),'There are')]";
        public IWebElement IShouldSeePopupMessageErrorAfterCLOSETRO => Driver.FindElement(By.XPath(IShouldSeePopupMessageErrorAfterCLOSETROXpath));

        public const string IShouldSeePopupMessageErrorAfterCutoffXpath = "//div[starts-with(@class,'ms-nav-logical')]//following::p[contains(text(),'Nothing')]";
        public IWebElement IShouldSeePopupMessageErrorAfterCutoff => Driver.FindElement(By.XPath(IShouldSeePopupMessageErrorAfterCutoffXpath));

        public const string IShouldSeePopupMessageErrorAfterCLOSETRONotFullyBookedXpath = "//div[starts-with(@class,'ms-nav-logical')]//following::p[contains(text(),'TRO not fully booked')]";
        public IWebElement IShouldSeePopupMessageErrorAfterCLOSETRONotFullyBooked => Driver.FindElement(By.XPath(IShouldSeePopupMessageErrorAfterCLOSETRONotFullyBookedXpath));

        public const string IShouldSeePopupErrorMessageAfterChoosingDestinationGroupInTROXpath = "//div[@role='alert']//div[2]";
        public IWebElement IShouldSeePopupErrorMessageAfterChoosingDestinationGroupInTRO => Driver.FindElement(By.XPath(IShouldSeePopupErrorMessageAfterChoosingDestinationGroupInTROXpath));

        public const string IShouldSeePopupErrorMessageAfterChoosingDestinationGroupInTROQGXpath = "//div[@class='ms-nav-validationpanel-text']";
        public IWebElement IShouldSeePopupErrorMessageAfterChoosingDestinationGroupInTROQG => Driver.FindElement(By.XPath(IShouldSeePopupErrorMessageAfterChoosingDestinationGroupInTROQGXpath));

        public const string IShouldSeePopupMessageErrorAfterCLOSETROHasNoStatusLoadedXpath = "//div[starts-with(@class,'ms-nav-logical')]//following::p[contains(text(),'Outbound OUT-0166892 has not status loaded')]";
        public IWebElement IShouldSeePopupMessageErrorAfterCLOSETROHasNoStatusLoaded => Driver.FindElement(By.XPath(IShouldSeePopupMessageErrorAfterCLOSETROHasNoStatusLoadedXpath));

        public const string IShouldGetDateErrorTRONotificationXpath = "//div[starts-with(@class,'ms-nav-logical')]//following::p[contains(text(),'Date')]";
        public IWebElement IShouldGetDateErrorTRONotification => Driver.FindElement(By.XPath(IShouldGetDateErrorTRONotificationXpath));

        public const string IShouldGetErrorForUnlinkingTRONotificationXpath = "//p[starts-with(@class,'staticstringcontrol')]//following::p[contains(text(),'Not possible')]";
        public IWebElement IShouldGetErrorForUnlinkingTRONotification => Driver.FindElement(By.XPath(IShouldGetErrorForUnlinkingTRONotificationXpath));

        public const string IShouldGetCancelNotificationMessagesXpath = "//p[contains(text(), 'Unlinking has been cancelled.')]";
        public IWebElement IShouldGetCancelNotificationMessages => Driver.FindElement(By.XPath(IShouldGetCancelNotificationMessagesXpath));

        public const string UnlinkingCancelledNotificationXpath = "//p[contains(text(), 'Unlinking has been cancelled.')]";
        public IWebElement UnlinkingCancelledNotification => Driver.FindElement(By.XPath(UnlinkingCancelledNotificationXpath));

        public const string PalletPoolTROTransportXpath = "//div[contains(text(), 'Palletpool')]";
        public IWebElement PalletPoolTROTransport => Driver.FindElement(By.XPath(PalletPoolTROTransportXpath));

        public const string EnterUnitPalletPoolTransportTROXpath = "//td[@controlname='Unit']//input";
        public IWebElement EnterUnitPalletPoolTransportTRO => Driver.FindElement(By.XPath(EnterUnitPalletPoolTransportTROXpath));

        public const string InsertQTYXpath = "//td[@controlname='Qty']//input";
        public IWebElement InsertQTY => Driver.FindElement(By.XPath(InsertQTYXpath));

        public const string IShouldGetErrorOnPalletPoolTROXpath = "//div[contains(text(),('The page has '))]";
        public IWebElement IShouldGetErrorOnPalletPoolTRO => Driver.FindElement(By.XPath(IShouldGetErrorOnPalletPoolTROXpath));

        public const string CloseTransportTROXpath = "//span[contains(text(),'Close Transport')]";
        public IWebElement CloseTransportTRO => Driver.FindElement(By.XPath(CloseTransportTROXpath));

        public const string FilterButton_QueueGroupXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[7]/div[2]/div[1]/div[2]/div/div[2]/div[2]/div/div/div[1]/div[2]/div[2]/div/div/div/button/div/div";
        public IWebElement FilterButton_QueueGroup => Driver.FindElement(By.XPath(FilterButton_QueueGroupXpath));

        public const string KPITROTransportXpath = "//a[@aria-label='KPI']";
        public IWebElement KPITROTransport => Driver.FindElement(By.XPath(KPITROTransportXpath));

        public const string ClickTransportInboundNoColumnDropdownXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[5]/div[2]/div[2]/div[2]/div/div[1]/div/div[1]/table/thead/tr/th[6]/div[2]/a";
        public IWebElement ClickTransportInboundNoColumnDropdown => Driver.FindElement(By.XPath(ClickTransportInboundNoColumnDropdownXpath));

        public const string SelectCodeFromDropdownQGXpath = "//html//body//div//div//form//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//input";
        public IWebElement SelectCodeFromDropdownQG => Driver.FindElement(By.XPath(SelectCodeFromDropdownQGXpath));

        public const string EnterSavedTRICodeFromTransportInboundXpath = "//div//div//div//div//div//div[3]//div[2]//input[1]";
        public IWebElement EnterSavedTRICodeFromTransportInbound => Driver.FindElement(By.XPath(EnterSavedTRICodeFromTransportInboundXpath));

        public const string ClickCardInQGXpath = "//span[contains(text(),'Card')]";
        public IWebElement ClickCardInQG => Driver.FindElement(By.XPath(ClickCardInQGXpath));

        public const string ClickQueueInCardXpath = "//html//body//div//div//form//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//a//div//div//span//span[contains(text(),'Queue')]";
        public IWebElement ClickQueueInCard => Driver.FindElement(By.XPath(ClickQueueInCardXpath));

        public const string BookBackSelectedRecordsInCardXpath = "//span[contains(text(),'Book Back selected records')]";
        public IWebElement BookBackSelectedRecordsInCard => Driver.FindElement(By.XPath(BookBackSelectedRecordsInCardXpath));

        public const string LoadingFromTypeInHolderSelectionXpath = "//div[6]//div[1]//select[1]//option[4]";
        public IWebElement LoadingFromTypeInHolderSelection => Driver.FindElement(By.XPath(LoadingFromTypeInHolderSelectionXpath));

        public const string CardOnHolderStockListXpath = "//span[contains(text(),'Card')]";
        public IWebElement CardOnHolderStockList => Driver.FindElement(By.XPath(CardOnHolderStockListXpath));

        public const string WriteCommentInUnblockValidatedXpath = "//input[@aria-label='Comment, (Blank)']";
        public IWebElement WriteCommentInUnblockValidated => Driver.FindElement(By.XPath(WriteCommentInUnblockValidatedXpath));

        public const string DAMKTNBlockedReasonXpath = "/html/body/div[1]/div[4]/form/div[2]/div/div[3]/div[1]/div/div[3]/div[2]/div/div/div/div/div/div[3]/div/div[2]/div[2]/div/input";
        public IWebElement DAMKTNBlockedReason => Driver.FindElement(By.XPath(DAMKTNBlockedReasonXpath));


        public const string DAMKTNBlockedReasonThreeDotsXpath = "//a[@aria-label='Drill down to record']";
        public IWebElement DAMKTNBlockedReasonThreeDots => Driver.FindElement(By.XPath(DAMKTNBlockedReasonThreeDotsXpath));

        public const string DAMKTNBlockedReasonThreeDotsBlockingListXpath = "/html/body/div[1]/div[5]/form/div[2]/div/div[4]/button[1]";
        public IWebElement DAMKTNBlockedReasonThreeDotsBlockingList => Driver.FindElement(By.XPath(DAMKTNBlockedReasonThreeDotsBlockingListXpath));




        public const string ActionSPowerHolderMainXpath = "//span[contains(text(),'Actions')]";
        public IWebElement ActionSPowerHolderMain => Driver.FindElement(By.XPath(ActionSPowerHolderMainXpath));

        public const string ManipulationPowerHolderMainXpath = "(//span[(text() ='Manipulation')])[2]";
        public IWebElement ManipulationPowerHolderMain => Driver.FindElement(By.XPath(ManipulationPowerHolderMainXpath));

        public const string BlockUnblockHolderXpath = "//div[contains(text(),'Block/Unblock Holder')]";
        public IWebElement BlockUnblockHolder => Driver.FindElement(By.XPath(BlockUnblockHolderXpath));

        public const string OnInputForCancelOutboundXpath = "//div[starts-with(@class,'edit-container')]//following::input[starts-with(@aria-label,'Number')]";
        public IWebElement OnInputForCancelOutbound => Driver.FindElement(By.XPath(OnInputForCancelOutboundXpath));

        public const string NumberDivClickXpath = "/html/body/div[1]/div[5]/form/div[2]/div/div[3]/div[1]/div/div[3]/div/div[2]/div/div/div[2]/div/div/div/div[1]/div[2]/div[1]/div/div[1]/div[2]/span[1]";
        public IWebElement NumberDivClick => Driver.FindElement(By.XPath(NumberDivClickXpath));

        public const string QueueGroupFilterInputXpath = "//html//body//div//div//form//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//div//input";
        public IWebElement QueueGroupFilterInput => Driver.FindElement(By.XPath(QueueGroupFilterInputXpath));

        public const string GoFromCampaignToBlockedReasonXpath = "//td[@controlname='Campaign']//input";
        public IWebElement GoFromCampaignToBlockedReason => Driver.FindElement(By.XPath(GoFromCampaignToBlockedReasonXpath));

        public const string PrintEmptyLabelOutboundXpath = "//span[contains(text(),'Print empty label')]";
        public IWebElement PrintEmptyLabelOutbound => Driver.FindElement(By.XPath(PrintEmptyLabelOutboundXpath));

        public const string OnInputWindowOutboundXpath = "/html/body/div[1]/div[5]/form/div[2]/div/div[3]/div[1]/div/div[3]/div/div/div/div[8]/div/input";
        public IWebElement OnInputWindowOutbound => Driver.FindElement(By.XPath(OnInputWindowOutboundXpath));

        public const string SchedulerSetupMainMenuXpath = "//body/div/div/div/div/div/div/div/ul/li[16]/div[1]/div[1]/a[1]/div[1]";
        public IWebElement SchedulerSetupMainMenu => Driver.FindElement(By.XPath(SchedulerSetupMainMenuXpath));

        public const string SearchButtonNasSimulatorXpath = "//body/div/div/form/div/div/div/div/div/div/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]";
        public IWebElement SearchButtonNasSimulator => Driver.FindElement(By.XPath(SearchButtonNasSimulatorXpath));

        public const string InputSearchButtonNasSimulatorXpath = "//input[@placeholder='Search']";
        public IWebElement InputSearchButtonNasSimulator => Driver.FindElement(By.XPath(InputSearchButtonNasSimulatorXpath));

        public const string FilterPaneQueueGroupListXpath = "//button[starts-with(@title,'Show filter')]";
        public IWebElement FilterPaneQueueGroupList => Driver.FindElement(By.XPath(FilterPaneQueueGroupListXpath));

        public const string SelectMoreButtonXpath = "//span[contains(text(),'Select More')]";

        public IWebElement SelectMoreButton => Driver.FindElement(By.XPath(SelectMoreButtonXpath));

        public const string SelectSecondRowForSecondQueueXpath = "(//tr[@aria-rowindex='2'])[2]//div//label";

        public IWebElement SelectSecondRowForSecondQueue => Driver.FindElement(By.XPath(SelectSecondRowForSecondQueueXpath));

        public const string FirstFilterOnQueueGroupXpath = "//input[starts-with(@class,'ms-ComboBox')]";
        public IWebElement FirstFilterOnQueueGroup => Driver.FindElement(By.XPath(FirstFilterOnQueueGroupXpath));

        public const string ExpandShowMoreOptionsInQueueGroupXpath = "(//tbody[@data-focus-zone='true'])[2]//tr[1]//td[4]//a";

        public IWebElement ExpandShowMoreOptionsInQueueGroup => Driver.FindElement(By.XPath(ExpandShowMoreOptionsInQueueGroupXpath));

        public const string TargetPutawayDateTimeTRIXpath = "//div[10]//div[1]//div[1]//div[2]//div[1]//div[1]//input[1]";
        public IWebElement TargetPutawayDateTimeTRI => Driver.FindElement(By.XPath(TargetPutawayDateTimeTRIXpath));

        public const string TargetPutawayDateTime1TRIXpath = "//div[10]//div[1]//div[1]//div[3]//div[1]//div[1]//input[1]";
        public IWebElement TargetPutawayDateTime1TRI => Driver.FindElement(By.XPath(TargetPutawayDateTime1TRIXpath));

        public const string FillInboundTypeCodeXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[1]/div[2]/div/div[4]/div[2]/div[2]/div/input";
        public IWebElement FillInboundTypeCode => Driver.FindElement(By.XPath(FillInboundTypeCodeXpath));

        public const string FillTransportTypeCodeXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[1]/div[2]/div/div[4]/div[2]/div[5]/div/input";
        public IWebElement FillTransportTypeCode => Driver.FindElement(By.XPath(FillTransportTypeCodeXpath));

        public const string GoBackFromPalletpoolTableXpath = "/html/body/div[1]/div[5]/form/div/div[2]/div[2]/div/div/div[1]/button/div/i";
        public IWebElement GoBackFromPalletpoolTable => Driver.FindElement(By.XPath(GoBackFromPalletpoolTableXpath));

        public const string ClickBackButtonGeneralXpath = "//button[(@data-is-focusable='true')and(@title='Back')]";
        public IWebElement ClickBackButtonGeneral => Driver.FindElement(By.XPath(ClickBackButtonGeneralXpath));

        public const string SearchInboundDeliveryWithIDvarFromInboundTableXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[4]/div/div/div/div[1]/div[2]/div/div[2]/div/input";
        public IWebElement SearchInboundDeliveryWithIDvarFromInboundTable => Driver.FindElement(By.XPath(SearchInboundDeliveryWithIDvarFromInboundTableXpath));

        public const string ShouldSeeSkuReceivedXpath = "/html[1]/body[1]/div[1]/div[4]/form[1]/div[1]/div[2]/div[6]/div[2]/div[2]/div[2]/div[1]/div[3]/div[2]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/table[1]/tbody[1]/tr[1]/td[15]/span[1]";
        public IWebElement ShouldSeeSkuReceived => Driver.FindElement(By.XPath(ShouldSeeSkuReceivedXpath));

        public const string ClickAdministrationFromTheDashboardMenuXpath = "//div[contains(text(),'Administration')]";
        public IWebElement ClickAdministrationFromTheDashboardMenu => Driver.FindElement(By.XPath(ClickAdministrationFromTheDashboardMenuXpath));

        public const string ClickMoreOptionsFromTheNavMenuXpath = "//span[contains(text(),'More options')]";
        public IWebElement ClickMoreOptionsFromTheNavMenu => Driver.FindElement(By.XPath(ClickMoreOptionsFromTheNavMenuXpath));

        public const string ActionFromTheMenuXpath = "//span[contains(text(),'Actions')]";
        public IWebElement ActionFromTheMenu => Driver.FindElement(By.XPath(ActionFromTheMenuXpath));

        public const string EDIFromMenuOfAdministrationXpath = "(//span[text() = 'EDI'])[2]";
        public IWebElement EDIFromMenuOfAdministration => Driver.FindElement(By.XPath(EDIFromMenuOfAdministrationXpath));

        public const string HoverToEDIBRIDGEXpath = "//div[text()='EDI Bridge']";
        public IWebElement HoverToEDIBRIDGE => Driver.FindElement(By.XPath(HoverToEDIBRIDGEXpath));

        public const string NewInboundXpath = "//span[contains(text(),'New')]";
        public IWebElement NewInbound => Driver.FindElement(By.XPath(NewInboundXpath));

        public const string EnterBridgeXpath = "//input[starts-with(@aria-label,'Bridge, (Blank)')]";
        public IWebElement EnterBridge => Driver.FindElement(By.XPath(EnterBridgeXpath));

        public const string EnterIncomingFileLocationXpath = "//input[starts-with(@aria-label,'Incoming file location, (Blank)')]";
        public IWebElement EnterIncomingFileLocation => Driver.FindElement(By.XPath(EnterIncomingFileLocationXpath));

        public const string EnterOutgoingFileLocationXpath = "//input[starts-with(@aria-label,'Outgoing file location, (Blank)')]";
        public IWebElement EnterOutgoingFileLocation => Driver.FindElement(By.XPath(EnterOutgoingFileLocationXpath));

        public const string CheckboxOfTestCommunicationXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[1]/div/div[2]/table/tbody/tr[1]/td[7]/div/input";
        public IWebElement CheckboxOfTestCommunication => Driver.FindElement(By.XPath(CheckboxOfTestCommunicationXpath));

        public const string EnterRootDirectoryXpath = "//input[starts-with(@aria-label,'Root directory, (Blank)')]";
        public IWebElement EnterRootDirectory => Driver.FindElement(By.XPath(EnterRootDirectoryXpath));

        public const string SearchForTRIXpath = "//input[@placeholder='Search']";
        public IWebElement SearchForTRI => Driver.FindElement(By.XPath(SearchForTRIXpath));

        public const string ClickSetStatusNotArrivedXpath = "//span[contains(@aria-label, 'Set Status: Not Arrived')]";
        public IWebElement ClickSetStatusNotArrived => Driver.FindElement(By.XPath(ClickSetStatusNotArrivedXpath));

        public const string ClickShowMoreInGeneralXpath = "//button[@title='Show more fields'][@aria-label='General, Show more']";
        public IWebElement ClickShowMoreInGeneral => Driver.FindElement(By.XPath(ClickShowMoreInGeneralXpath));

        public const string GoBackFromDestinationGroupTROMainXpath = "//body//button[2][starts-with(@class,'cursorinherit')]";
        public IWebElement GoBackFromDestinationGroupTROMain => Driver.FindElement(By.XPath(GoBackFromDestinationGroupTROMainXpath));

        public const string TransportNoXpath = "//div[@controlname='Transport No']//span";
        public IWebElement TransportNo => Driver.FindElement(By.XPath(TransportNoXpath));

        public const string ClickLinkToTransportQueueGroupXpath = "//span[contains(text(),'Link To a Transport')]";
        public IWebElement ClickLinkToTransportQueueGroup => Driver.FindElement(By.XPath(ClickLinkToTransportQueueGroupXpath));

        public const string ClickYesOutboundXpath = "//span[contains(text(),'Yes')]";
        public IWebElement ClickYesOutbound => Driver.FindElement(By.XPath(ClickYesOutboundXpath));

        public const string EnterThirdSubfilterXpath = "//div//div//div//div//div//div//div//div//div//div//div[3]//div[2]//input[1]";
        public IWebElement EnterThirdSubfilter => Driver.FindElement(By.XPath(EnterThirdSubfilterXpath));

        public const string ClickFromTheFilterDropdownMenuXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[5]/div[2]/div[1]/div[2]/div/div[2]/div/div/div[1]/div[2]/div[1]/div[2]/div[2]/select";
        public IWebElement ClickFromTheFilterDropdownMenu => Driver.FindElement(By.XPath(ClickFromTheFilterDropdownMenuXpath));

        public const string ClickInterfaceButtonMainMenuXpath = "//span[@aria-label='Interface']";
        public IWebElement ClickInterfaceButtonMainMenu => Driver.FindElement(By.XPath(ClickInterfaceButtonMainMenuXpath));

        public const string ClickInterfaceTableFromInterfaceXpath = "//div[contains(text(),'Interface Table')]";
        public IWebElement ClickInterfaceTableFromInterface => Driver.FindElement(By.XPath(ClickInterfaceTableFromInterfaceXpath));

        public const string SearchInputPOWInterfaceLineXpath = "//input[@placeholder='Search']";
        public IWebElement SearchInputPOWInterfaceLine => Driver.FindElement(By.XPath(SearchInputPOWInterfaceLineXpath));

        public const string ClickRunInterfaceLinePOWInterfaceListXpath = "//body[1]/div[1]/div[3]/form[1]/div[1]/div[2]/div[4]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/a[1]/div[1]/div[2]/span[1]";
        public IWebElement ClickRunInterfaceLinePOWInterfaceList => Driver.FindElement(By.XPath(ClickRunInterfaceLinePOWInterfaceListXpath));

        public const string ClickOriginDestTROCardXpath = "//span[contains(text(),'Origin')]";
        public IWebElement ClickOriginDestTROCard => Driver.FindElement(By.XPath(ClickOriginDestTROCardXpath));

        public const string EnterLoadingLocationOriginDestinTROXpath = "//input[starts-with(@aria-label,'Loading Location')]";
        public IWebElement EnterLoadingLocationOriginDestinTRO => Driver.FindElement(By.XPath(EnterLoadingLocationOriginDestinTROXpath));

        public const string InputCodeonFilterQueueGroupXpath = "//input[@aria-autocomplete='inline']";
        public IWebElement InputCodeonFilterQueueGroup => Driver.FindElement(By.XPath(InputCodeonFilterQueueGroupXpath));

        public const string FilterPaneOnQueueGroupListXpath = "//button[@aria-label='Add a new filter on a field']//span//i";
        public IWebElement FilterPaneOnQueueGroupList => Driver.FindElement(By.XPath(FilterPaneOnQueueGroupListXpath));


        public const string CodeFieldWithoutFilterXpath = "//input[@aria-label='Code, (Blank)']";
        public IWebElement CodeFieldWithoutFilter => Driver.FindElement(By.XPath(CodeFieldWithoutFilterXpath));

        public const string ThreeDotsQueueGroupListXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[5]/div/div/div/div[1]/div[2]/div/div[2]/div/div/div/div[1]/div/div/div/div[6]/a";
        public IWebElement ThreeDotsQueueGroupList => Driver.FindElement(By.XPath(ThreeDotsQueueGroupListXpath));


        public const string TypeSupplierCodeOnInboundDeliveryXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[1]/div[2]/div/div[19]/div/input";
        public IWebElement TypeSupplierCodeOnInboundDelivery => Driver.FindElement(By.XPath(TypeSupplierCodeOnInboundDeliveryXpath));

        public const string ClickManageFromExpectedXpath = "(//span[text()='Manage'])[1]";
        public IWebElement ClickManageFromExpected => Driver.FindElement(By.XPath(ClickManageFromExpectedXpath));

        public const string ClickManageFromInStockMasterXpath = "//div[text()='In Stock (Master)']/following::span[@aria-label='Manage']";
        public IWebElement ClickManageFromInStockMaster => Driver.FindElement(By.XPath(ClickManageFromInStockMasterXpath));

        public const string ClickMoreOptionsFromInStockMasterXpath = "//div[text()='In Stock (Master)']/following::span[@aria-label='More options']";
        public IWebElement ClickMoreOptionsFromInStockMaster => Driver.FindElement(By.XPath(ClickMoreOptionsFromInStockMasterXpath));

        public const string ClickInStockFromInStockMasterXpath = "//span[text()='In stock']";
        public IWebElement ClickInStockFromInStockMaster => Driver.FindElement(By.XPath(ClickInStockFromInStockMasterXpath));

        public const string KPInavBarXpath = "//span[text()='KPI']";
        public IWebElement KPInavBar => Driver.FindElement(By.XPath(KPInavBarXpath));

        public const string EmptyBoxKPIXpath = "/html/body/div[1]/div[5]/form/div[2]/div/div[3]/div[1]/div/div[3]/div/div[2]/table/tbody/tr[1]/td[6]/input";
        public IWebElement EmptyBoxKPI => Driver.FindElement(By.XPath(EmptyBoxKPIXpath));

        public const string ClickCloseKPIXpath = "/html/body/div[1]/div[5]/form/div[2]/div/div[4]/button[2]";
        public IWebElement ClickCloseKPI => Driver.FindElement(By.XPath(ClickCloseKPIXpath));

        public const string itemExpTriXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[4]/div[3]/div/div/div/div[2]/table/tbody/tr[1]/td[10]/input";
        public IWebElement itemExpTri => Driver.FindElement(By.XPath(itemExpTriXpath));

        public const string HoverSetupDropdownMenuFromDashboardXpath = "//span[@aria-label='Setup']";
        public IWebElement HoverSetupDropdownMenuFromDashboard => Driver.FindElement(By.XPath(HoverSetupDropdownMenuFromDashboardXpath));

        public const string HoverToSchedulerForSelectXpath = "//div[text()='Scheduler']";
        public IWebElement HoverToSchedulerForSelect => Driver.FindElement(By.XPath(HoverToSchedulerForSelectXpath));

        public const string ClickNasSimulatorForSelectionXpath = "//div[text()='Nas Simulator']";
        public IWebElement ClickNasSimulatorForSelection => Driver.FindElement(By.XPath(ClickNasSimulatorForSelectionXpath));

        public const string CopyGeneratedHolderToHolVarXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[5]/div[2]/div/div/div/div[2]/table/tbody/tr[1]/td[11]/span";
        public IWebElement CopyGeneratedHolderToHolVar => Driver.FindElement(By.XPath(CopyGeneratedHolderToHolVarXpath));

        public const string CopyGeneratedHolderToHolVarSecXpath = "/html/body/div[1]/div[4]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[5]/div[2]/div/div/div/div[2]/table/tbody/tr[2]/td[11]/span";
        public IWebElement CopyGeneratedHolderToHolVarSec => Driver.FindElement(By.XPath(CopyGeneratedHolderToHolVarSecXpath));

        public const string clikOkGeneralInboundXpath = "//button[@type='button']/following::span[contains(text(),'OK')]";
        public IWebElement clikOkGeneralInbound => Driver.FindElement(By.XPath(clikOkGeneralInboundXpath));

        public const string EnterDateToDeliverOnOutboundXpath = "//div[@controlname='Date to deliver']//div//input";
        public IWebElement EnterDateToDeliverOnOutbound => Driver.FindElement(By.XPath(EnterDateToDeliverOnOutboundXpath));

        public const string ManageOrderOutboundXpath = "(//span[@aria-label='Manage'])[1]";
        public IWebElement ManageOrderOutbound => Driver.FindElement(By.XPath(ManageOrderOutboundXpath));

        public const string ManageReservationOutboundXpath = "(//span[@aria-label='Manage'])[2]";
        public IWebElement ManageReservationOutbound => Driver.FindElement(By.XPath(ManageReservationOutboundXpath));

        public const string MySavedCustomerIrregularityCodeXpath = "//div[@class='edit-container']//input[@class='cursorinherit stringcontrol-edit thm-cont-u1-font-size thm-cont-u1-font-stack thm-cont-u1-color-2--medflat thm-cont-s1-bdrcolor--focus thm-cont-s1-outlinecolor--focus thm-cont-h1-bdrcolor--hover thm-cont-h1-bdrcolor--prev-sib-hover']";
        public IWebElement MySavedCustomerIrregularityCode => Driver.FindElement(By.XPath(MySavedCustomerIrregularityCodeXpath));

        public const string ClickCloseDestinationGroupXpath = "//div[4]/button[2][not(@data-is-focusable='false')]";
        public IWebElement ClickCloseDestinationGroup => Driver.FindElement(By.XPath(ClickCloseDestinationGroupXpath));

        public const string TRONumberXpath = "//div[@controlname='Transport No']//div//span";
        public IWebElement TRONumber => Driver.FindElement(By.XPath(TRONumberXpath));

        public const string EnterTOnDateCreatedXpath = "//div[@controlname='ctrlDateCreated']//div//input";
        public IWebElement EnterTOnDateCreated => Driver.FindElement(By.XPath(EnterTOnDateCreatedXpath));

        public const string ClickTransportPlanningXpath = ".//a[@aria-label='Transport planning']";
        public IWebElement ClickTransportPlanning => Driver.FindElement(By.XPath(ClickTransportPlanningXpath));

        public const string LinkToExistingTROXpath = "//a[@aria-label='Link to existing TRO']";
        public IWebElement LinkToExistingTRO => Driver.FindElement(By.XPath(LinkToExistingTROXpath));

        public const string SearchButtonTRO_PowerTransporOutboundListSecondFrameXpath = "/html/body/div[1]/div[5]/form/div[2]/div/div[1]/div[1]/div/div/div/div[1]/div/div/div[1]/div[1]";
        public IWebElement SearchButtonTRO_PowerTransporOutboundListSecondFrame => Driver.FindElement(By.XPath(SearchButtonTRO_PowerTransporOutboundListSecondFrameXpath));

        public const string SearchInputTRO_PowerTransporOutboundListSecondFrameXpath = "/html/body/div[1]/div[5]/form/div[2]/div/div[1]/div[1]/div/div/div/div[1]/div/div/div[1]/div/input";
        public IWebElement SearchInputTRO_PowerTransporOutboundListSecondFrame => Driver.FindElement(By.XPath(SearchInputTRO_PowerTransporOutboundListSecondFrameXpath));

        public const string secondCustomerReferenceEDIXpath = "//input[@aria-label='Code, ']";
        public IWebElement secondCustomerReferenceEDI => Driver.FindElement(By.XPath(secondCustomerReferenceEDIXpath));

        public const string ClickViewLinkedInboundDeliveriesFromTheNavigationBarDivXpath = "//div[contains(text(),'View Linked Inbound Deliveries')]";
        public IWebElement ClickViewLinkedInboundDeliveriesFromTheNavigationBarDiv => Driver.FindElement(By.XPath(ClickViewLinkedInboundDeliveriesFromTheNavigationBarDivXpath));

        public const string clickFirstLineFilterQueueGroupListXpath = "//div[@class='ms-nav-content']//tr[1]//td[2]";
        public IWebElement clickFirstLineFilterQueueGroupList => Driver.FindElement(By.XPath(clickFirstLineFilterQueueGroupListXpath));

        public const string ViewLinkedOutboundsTROXpath = "//div[contains(text(),'View Linked Outbounds')]";
        public IWebElement ViewLinkedOutboundsTRO => Driver.FindElement(By.XPath(ViewLinkedOutboundsTROXpath));

        public const string ViewLinkedOutboundsINTROXpath = "//span[@aria-label='View Linked Outbounds']";
        public IWebElement ViewLinkedOutboundsINTRO => Driver.FindElement(By.XPath(ViewLinkedOutboundsINTROXpath));

        public const string ViewLinkedQueueGroupsTROXpath = "//span[@aria-label='View Linked Queue Groups']";
        public IWebElement ViewLinkedQueueGroupsTRO => Driver.FindElement(By.XPath(ViewLinkedQueueGroupsTROXpath));

        public const string ShowTheRestInQGXpath = "//button[@aria-label='Show the rest']";
        public IWebElement ShowTheRestInQG => Driver.FindElement(By.XPath(ShowTheRestInQGXpath));

        public const string MoreOptionsAfterShowTheRestXpath = "//div[contains(text(), 'More options')]";
        public IWebElement MoreOptionsAfterShowTheRest => Driver.FindElement(By.XPath(MoreOptionsAfterShowTheRestXpath));

        public const string ActionsAfterMoreOptionsXpath = "(//button[@aria-label='Actions'])[2]";
        public IWebElement ActionsAfterMoreOptions => Driver.FindElement(By.XPath(ActionsAfterMoreOptionsXpath));

        public const string QueueGroupAfterActionXpath = "//button[@aria-label='Queue Group']";
        public IWebElement QueueGroupAfterAction => Driver.FindElement(By.XPath(QueueGroupAfterActionXpath));

        public const string DeleteLinkedTransportXpath = "//button[@aria-label='Delete Linked Transport(picking)']//span//span//div";
        public IWebElement DeleteLinkedTransport => Driver.FindElement(By.XPath(DeleteLinkedTransportXpath));

        public const string ShowMoreOptionsInUnlinkOutboundsXpath = "(//a[@title='Show more options'])[2]";
        public IWebElement ShowMoreOptionsInUnlinkOutbounds => Driver.FindElement(By.XPath(ShowMoreOptionsInUnlinkOutboundsXpath));

        public const string SelectMoreOptionsInUnlinkOutboundsXpath = "//span[contains(text(),'Select More')]";
        public IWebElement SelectMoreOptionsInUnlinkOutbounds => Driver.FindElement(By.XPath(SelectMoreOptionsInUnlinkOutboundsXpath));

        public const string SelectTheSecondQueueToUnlinkOutboundsXpath = "(//td[@class='thm-cont-h1-bgcolor-1--safe-sel-l1-hover--view-mode-grid thm-cont-h1-bgcolor--hover--edit-mode-grid thm-cont-g3-bdrcolor--border-top thm-cont-g3-bdrcolor--border-left--edit-mode-grid thm-cont-s1-bgcolor--grid-row-selected thm-cont-g0-bgcolor--grid-row-selected--edit-mode-grid thm-cont-s1-bgcolor--grid-row-current--multiselect-grid thm-cont-g0-bgcolor--grid-row-current--edit-mode-grid'])[2]";

        public IWebElement SelectTheSecondQueueToUnlinkOutbounds => Driver.FindElement(By.XPath(SelectTheSecondQueueToUnlinkOutboundsXpath));

        public const string SelectTheFirstQueueToUnlinkOutboundsXpath = "(//td[@class='thm-cont-h1-bgcolor-1--safe-sel-l1-hover--view-mode-grid thm-cont-h1-bgcolor--hover--edit-mode-grid thm-cont-g3-bdrcolor--border-top thm-cont-g3-bdrcolor--border-left--edit-mode-grid thm-cont-s1-bgcolor--grid-row-selected thm-cont-g0-bgcolor--grid-row-selected--edit-mode-grid thm-cont-s1-bgcolor--grid-row-current--multiselect-grid thm-cont-g0-bgcolor--grid-row-current--edit-mode-grid'])[1]";

        public IWebElement SelectTheFirstQueueToUnlinkOutbounds => Driver.FindElement(By.XPath(SelectTheFirstQueueToUnlinkOutboundsXpath));

        public const string SelectStatusFromFilterXpath = "//span[@aria-live='polite']";
        public IWebElement SelectStatusFromFilter => Driver.FindElement(By.XPath(SelectStatusFromFilterXpath));

        public const string StatusCheckBoxDoneXpath = "(//i[@data-icon-name='CheckMark'])[4]";
        public IWebElement StatusCheckBoxDone => Driver.FindElement(By.XPath(StatusCheckBoxDoneXpath));

        public const string StatusCheckBoxLoadedXpath = "(//i[@data-icon-name='CheckMark'])[5]";
        public IWebElement StatusCheckBoxLoaded => Driver.FindElement(By.XPath(StatusCheckBoxDoneXpath));

        public const string MoreOptionsOnPowerOutboundList_TROXpath = "(//span[contains(text(),'More options')])[2]";
        public IWebElement MoreOptionsOnPowerOutboundList_TRO => Driver.FindElement(By.XPath(MoreOptionsOnPowerOutboundList_TROXpath));

        public const string ShowTheRestXpath = "//button[@aria-label='Show the rest']//span//div//i";
        public IWebElement ShowTheRest => Driver.FindElement(By.XPath(ShowTheRestXpath));

        public const string MoreOptionsOnPOWERQUEUEGROUPLIST_TROXpath = "(//i[@data-icon-name='More'])[2]";
        public IWebElement MoreOptionsOnPOWERQUEUEGROUPLIST_TRO => Driver.FindElement(By.XPath(MoreOptionsOnPOWERQUEUEGROUPLIST_TROXpath));

        public const string MoreOptionsOnPoWerQueueGroupList_TRO_WrittenXpath = "//li[starts-with(@class,'ms-Context')]//following::a[@title='Reveal secondary actions']";
        public IWebElement MoreOptionsOnPoWerQueueGroupList_TRO_Written => Driver.FindElement(By.XPath(MoreOptionsOnPoWerQueueGroupList_TRO_WrittenXpath));

        public const string ClickActionsDropdownXpath = "(//span[@aria-label='Actions'])[2]";
        public IWebElement ClickActionsDropdown => Driver.FindElement(By.XPath(ClickActionsDropdownXpath));

        public const string OutboundDropdownPowerOutboundListXpath = "//span[@aria-label='Outbound']";
        public IWebElement OutboundDropdownPowerOutboundList => Driver.FindElement(By.XPath(OutboundDropdownPowerOutboundListXpath));

        public const string UnlinkSelectedFromTransportTROQueueGroupListXpath = "//div[contains(text(), 'Unlink Selected From transport')]";
        public IWebElement UnlinkSelectedFromTransportTROQueueGroupList => Driver.FindElement(By.XPath(UnlinkSelectedFromTransportTROQueueGroupListXpath));

        public const string UnlinkSelectedFromTransportViaProcessXpath = "//span[@aria-label='Unlink Selected From transport']";
        public IWebElement UnlinkSelectedFromTransportViaProcess => Driver.FindElement(By.XPath(UnlinkSelectedFromTransportViaProcessXpath));

        public const string UnlinkSelectedFromTransportAfterClosingProcessXpath = "//span[contains(text(), 'Unlink Selected From transport')]";
        public IWebElement UnlinkSelectedFromTransportAfterClosingProcess => Driver.FindElement(By.XPath(UnlinkSelectedFromTransportAfterClosingProcessXpath));

        public const string ClickCloseButtonOutboundXpath = "//div[4]/button[2][not(@data-is-focusable='false')]";
        public IWebElement ClickCloseButtonOutbound => Driver.FindElement(By.XPath(ClickCloseButtonOutboundXpath));

        public const string CloseButtonInQueueGrouplistXpath = "//div[@class='ms-nav-actionbar-container has-actions']//button";
        public IWebElement CloseButtonInQueueGrouplist => Driver.FindElement(By.XPath(CloseButtonInQueueGrouplistXpath));

        public const string ChangeHolderMeasuresXpath = "//a[@aria-label='Change \"Holder measures\"']";
        public IWebElement ChangeHolderMeasures => Driver.FindElement(By.XPath(ChangeHolderMeasuresXpath));

        public const string EnterWidhtInHolderMeasuresXpath = "//input[@aria-label='Width (cm), ']";
        public IWebElement EnterWidhtInHolderMeasures => Driver.FindElement(By.XPath(EnterWidhtInHolderMeasuresXpath));

        public const string EnterDepthInHolderMeasuresXpath = "//input[@aria-label= 'Depth (cm), ']";
        public IWebElement EnterDepthInHolderMeasures => Driver.FindElement(By.XPath(EnterDepthInHolderMeasuresXpath));

        public const string EnterHeightInHolderMeasuresXpath = "//input[@aria-label='Height (cm), ']";
        public IWebElement EnterHeightInHolderMeasures => Driver.FindElement(By.XPath(EnterHeightInHolderMeasuresXpath));

        public const string OKOnBlockManipulationXpath = "//span[contains(text(),'OK')]";
        public IWebElement OKOnBlockManipulation => Driver.FindElement(By.XPath(OKOnBlockManipulationXpath));

        public const string TroOutboundUnlinkMoreOptionsXpath = "//div[contains(text(),'More options')]";

        public IWebElement TroOutboundUnlinkMoreOptions => Driver.FindElement(By.XPath(TroOutboundUnlinkMoreOptionsXpath));

        public const string OKOnBlockManipulationErrorXpath = "(//span[contains(text(),'OK')])[2]";
        public IWebElement OKOnBlockManipulationError => Driver.FindElement(By.XPath(OKOnBlockManipulationErrorXpath));

        public const string HolderWeightXpath = "//span[contains(@aria-label,'Total Weight Holder (KG), ')][text()='1,00']";
        public IWebElement HolderWeight => Driver.FindElement(By.XPath(HolderWeightXpath));

        public const string ClickonHolderCardXpath = "//span[text()='Card']";
        public IWebElement ClickonHolderCard => Driver.FindElement(By.XPath(ClickonHolderCardXpath));

        public const string ClickChangeConfigurationOfHolderXpath = "//a[@aria-label='Change \"Configuration\"']";
        public IWebElement ClickChangeConfigurationOfHolder => Driver.FindElement(By.XPath(ClickChangeConfigurationOfHolderXpath));

        public const string EnterConfigurationForHolderXpath = "//input[@aria-label='New Configuration, (Blank)']";
        public IWebElement EnterConfigurationForHolder => Driver.FindElement(By.XPath(EnterConfigurationForHolderXpath));

        public const string ChangeGrosWeightOfAHolderXpath = "//a[@aria-label='Change Gross Weight']";
        public IWebElement ChangeGrosWeightOfAHolder => Driver.FindElement(By.XPath(ChangeGrosWeightOfAHolderXpath));

        public const string ClickChangeTypeMoverOfAHolderXpath = "//a[@aria-label='Change \"Type mover\"']";
        public IWebElement ClickChangeTypeMoverOfAHolder => Driver.FindElement(By.XPath(ClickChangeTypeMoverOfAHolderXpath));

        public const string EnterNewTypeMoverXpath = "//input[@aria-label='New type Mover, (Blank)']";
        public IWebElement EnterNewTypeMover => Driver.FindElement(By.XPath(EnterNewTypeMoverXpath));

        public const string ChangeUnitHolderOfAHolderXpath = "//a[@aria-label='Change \"Unit Holder\"']";
        public IWebElement ChangeUnitHolderOfAHolder => Driver.FindElement(By.XPath(ChangeUnitHolderOfAHolderXpath));

        public const string EnterNewUnitXpath = "//input[@aria-label='New Unit Holder, (Blank)']";
        public IWebElement EnterNewUnit => Driver.FindElement(By.XPath(EnterNewUnitXpath));

        public const string ClickMannipulationWorkXpath = "//span[contains(text(),'Work')]";
        public IWebElement ClickMannipulationWork => Driver.FindElement(By.XPath(ClickMannipulationWorkXpath));

        public const string ClickFilterInPowerJournalHolderListXpath = "//button[@aria-label='Toggle filter']";
        public IWebElement ClickFilterInPowerJournalHolderList => Driver.FindElement(By.XPath(ClickFilterInPowerJournalHolderListXpath));

        public const string ChangeGrossWeightToXpath = "//input[@aria-label='Change weight into :, ']";
        public IWebElement ChangeGrossWeightTo => Driver.FindElement(By.XPath(ChangeGrossWeightToXpath));

        public const string ClickFilterListByXpath = "(//span[text()='Filter...'])[1]";
        public IWebElement ClickFilterListBy => Driver.FindElement(By.XPath(ClickFilterListByXpath));

        public const string ClickFilterPJXpath = "//button[@aria-label='Add a new filter on a field']";
        public IWebElement ClickFilterPJ => Driver.FindElement(By.XPath(ClickFilterPJXpath));

        public const string SelectStatusXpath = "//button[@aria-label ='Status']";
        public IWebElement SelectStatus => Driver.FindElement(By.XPath(SelectStatusXpath));

        public const string selectStatusFilterXpath = "//div[contains(@id,'Dropdown')]";
        public IWebElement selectStatusFilter => Driver.FindElement(By.XPath(selectStatusFilterXpath));

        public const string StatusValidatedXpath = "//span[contains(text(),'Validated')]";
        public IWebElement StatusValidated => Driver.FindElement(By.XPath(StatusValidatedXpath));

        public const string ISeeScreenOutboundListWrittenXpath = "(//span[text()='Outbound'])[2]";
        public IWebElement ISeeScreenOutboundListWritten => Driver.FindElement(By.XPath(ISeeScreenOutboundListWrittenXpath));

        public const string LocationPathOfLatestEDIMESSAGELOGSENDXpath = "//td[@controlname= 'File location']//span";
        public IWebElement LocationPathOfLatestEDIMESSAGELOGSEND => Driver.FindElement(By.XPath(LocationPathOfLatestEDIMESSAGELOGSENDXpath));


        public const string ChangePriorityQueueGroupListXpath = "//div[contains(text(),'Change Priority')]";
        public IWebElement ChangePriorityQueueGroupList => Driver.FindElement(By.XPath(ChangePriorityQueueGroupListXpath));


        public const string ChangePriorityFieldQueueGroupListXpath = "//input[@aria-label='Queue Group Priority, ']";
        public IWebElement ChangePriorityFieldQueueGroupList => Driver.FindElement(By.XPath(ChangePriorityFieldQueueGroupListXpath));

        public const string ClickHolderInPickHolderInOutboundXpath = "//span[@aria-label='Holder']";

        public IWebElement ClickHolderInPickHolderInOutbound => Driver.FindElement(By.XPath(ClickHolderInPickHolderInOutboundXpath));

        public const string ClickCardInHolderInOutboundXpath = "//span[@aria-label='Card']";

        public IWebElement ClickCardInHolderInOutbound => Driver.FindElement(By.XPath(ClickCardInHolderInOutboundXpath));

        public const string ClickUnpackUnlabelHolderXpath = "//span[@aria-label='Unpack / Unlabel  Holder']";

        public IWebElement ClickUnpackUnlabelHolder => Driver.FindElement(By.XPath(ClickUnpackUnlabelHolderXpath));

        public const string IGetNotificationHolderHasBeenUnpackedXpath = "(//div[starts-with(@class,'ms-nav-logical')]//following::p[contains(text(),'Holder')])[1]";

        public IWebElement IGetNotificationHolderHasBeenUnpacked => Driver.FindElement(By.XPath(IGetNotificationHolderHasBeenUnpackedXpath));

        public const string IClickPickHoldersButtonInOutboundXpath = "//span[contains(text(),'Pick Holders')]";

        public IWebElement IClickPickHoldersButtonInOutbound => Driver.FindElement(By.XPath(IClickPickHoldersButtonInOutboundXpath));

        public const string IClearFilterInStatusOutboundOrderXpath = "//button[@title='Clear this filter']";

        public IWebElement IClearFilterInStatusOutboundOrder => Driver.FindElement(By.XPath(IClearFilterInStatusOutboundOrderXpath));

        public const string BackButtonInGeneralXpath = "//button[@data-is-focusable='true'][@title='Back']//span";
        public IWebElement BackButtonInGeneral => Driver.FindElement(By.XPath(BackButtonInGeneralXpath));

        public const string BackButtonFPFBXpath = "//i[@data-icon-name='Back']";
        public IWebElement BackButtonFPFB => Driver.FindElement(By.XPath(BackButtonFPFBXpath));

        public const string SetBackCreatedXpath = "//span[@aria-label='Set Back Created']";

        public IWebElement SetBackCreated => Driver.FindElement(By.XPath(SetBackCreatedXpath));

        public const string ChangePriorityXpath = "//span[@aria-label='Change Priority']";

        public IWebElement ChangePriority => Driver.FindElement(By.XPath(ChangePriorityXpath));

        public const string ClosePackingPageXpath = "(//i[@data-icon-name='ChromeClose'])[2]";
        public IWebElement ClosePackingPage => Driver.FindElement(By.XPath(ClosePackingPageXpath));

        public const string SetupFromMainPageXpath = "//span[@aria-label='Setup']";
        public IWebElement SetupFromMainPage => Driver.FindElement(By.XPath(SetupFromMainPageXpath));

        public const string LoggingInSetupXpath = "//div[contains(text(), 'Logging')]";
        public IWebElement LoggingInSetup => Driver.FindElement(By.XPath(LoggingInSetupXpath));

        public const string PickingErrorLogInLoggingXpath = "//div[contains(text(), 'Picking Error Log')]";
        public IWebElement PickingErrorLogInLogging => Driver.FindElement(By.XPath(PickingErrorLogInLoggingXpath));

        public const string UserPickedXpath = "//span[@title='ZLATKOBASELINE'][contains(text(), 'ZLATKOBASELINE')]";
        public IWebElement UserPicked => Driver.FindElement(By.XPath(UserPickedXpath));

        public const string DeleteErrorLogXpath = "//span[@aria-label='Delete']";
        public IWebElement DeleteErrorLog => Driver.FindElement(By.XPath(DeleteErrorLogXpath));

        public const string YesButtonOnDeletePopUpXpath = "//span[contains(text(), 'Yes')]";
        public IWebElement YesButtonOnDeletePopUp => Driver.FindElement(By.XPath(YesButtonOnDeletePopUpXpath));

        public const string ScannedGSBarcodeXpath = "//input[@id='ctrlEANScanned']";
        public IWebElement ScannedGSBarcode => Driver.FindElement(By.XPath(ScannedGSBarcodeXpath));

        public const string BaselineCustomerListXpath = "/html/body/div[1]/div[3]/form/div/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[1]/div/div[2]/table/tbody/tr[1]/td[3]/a";
        public IWebElement BaselineCustomerList => Driver.FindElement(By.XPath(BaselineCustomerListXpath));

        public const string IrregularityCustomerCardXpath = "//span[contains(text(),'Irregularity')]";
        public IWebElement IrregularityCustomerCard => Driver.FindElement(By.XPath(IrregularityCustomerCardXpath));

        public const string ShowMoreOnIrregularityXpath = "(//button[contains(@class,'show-more-fields')])[6]";
        public IWebElement ShowMoreOnIrregularity => Driver.FindElement(By.XPath(ShowMoreOnIrregularityXpath));


        public const string QueueOverviewXpath = "//div[text()='Queue Overview']";
        public IWebElement QueueOverview => Driver.FindElement(By.XPath(QueueOverviewXpath));

        public const string BookBackReplenishmentQGXpath = "//button[@aria-label='Book Back Selected Replenishment QG']";
        public IWebElement BookBackReplenishmentQG => Driver.FindElement(By.XPath(BookBackReplenishmentQGXpath));

        public const string CMRmainXpath = "//div[contains(text(),'CMR')]";
        public IWebElement CMRmain => Driver.FindElement(By.XPath(CMRmainXpath));

        public const string printCMRXpath = "//span[contains(@aria-label,'Print CMR')]";
        public IWebElement printCMR => Driver.FindElement(By.XPath(printCMRXpath));

        public const string MoreOptionOutboundCardXpath = "(//a[@title='Reveal secondary actions']/following::span[contains(text(),'More options')])[1]";
        public IWebElement MoreOptionOutboundCard => Driver.FindElement(By.XPath(MoreOptionOutboundCardXpath));

        public const string ActionFroumOutboundXpath = "//span[contains(@aria-label,'Action')]";
        public IWebElement ActionFroumOutbound => Driver.FindElement(By.XPath(ActionFroumOutboundXpath));
        public const string OutboundFromActionXpath = "(//span[@aria-label='Outbound'])[2]";
        public IWebElement OutboundFromAction => Driver.FindElement(By.XPath(OutboundFromActionXpath));
        public const string CMRpickedXpath = "//button[contains(@aria-label,'CMR Picked')]";
        public IWebElement CMRpicked => Driver.FindElement(By.XPath(CMRpickedXpath));
        public const string driverdocumentXpath = "//span[@aria-label='Drivers Document']";
        public IWebElement driverdocument => Driver.FindElement(By.XPath(driverdocumentXpath));
        public const string CombinedCMRXpath = "//label[@title=' Create combined transport CMR']";
        public IWebElement CombinedCMR => Driver.FindElement(By.XPath(CombinedCMRXpath));
        public const string reprintCMRXpath = "//span[contains(@aria-label,'Print CMR')]";
        public IWebElement reprintCMR => Driver.FindElement(By.XPath(reprintCMRXpath));
        public const string VerifyCutOffXpath = "//span[@title='Piece picking']";
        public IWebElement VerifyCutOff => Driver.FindElement(By.XPath(VerifyCutOffXpath));

        public const string ClickYESInPopupMessageOutboundXpath = "//span[contains(text(),'Yes')]";
        public IWebElement ClickYESInPopupMessageOutbound => Driver.FindElement(By.XPath(ClickYESInPopupMessageOutboundXpath));

        public const string CancelToCancelTheUnlinkingXpath = "//button[@type='button']//span[contains(text(), 'Cancel')]";
        public IWebElement CancelToCancelTheUnlinking => Driver.FindElement(By.XPath(CancelToCancelTheUnlinkingXpath));

        public const string NoStockOptionToUnlinkXpath = "//input[@title='No stock']";
        public IWebElement NoStockOptionToUnlink => Driver.FindElement(By.XPath(NoStockOptionToUnlinkXpath));

        public const string ShouldGetPopupMessageXpath = "(//div[@controlname=''])[2]//div//p";
        public IWebElement ShouldGetPopupMessage => Driver.FindElement(By.XPath(ShouldGetPopupMessageXpath));

        public const string StatusOfAQueueXpath = "(//td[@controlname='Status'])[2]//span";
        public IWebElement StatusOfAQueue => Driver.FindElement(By.XPath(StatusOfAQueueXpath));
        public const string OrderNoInOutboundXpath = "//td[@controlname='No']//span";
        public IWebElement OrderNoInOutbound => Driver.FindElement(By.XPath(OrderNoInOutboundXpath));
        public const string ReservedSKUOneXpath = "//td[@controlname='# SKU']//span";

        public IWebElement ReservedSKUOne => Driver.FindElement(By.XPath(ReservedSKUOneXpath));

        public const string ReservedSKUTwoXpath = "(//span[@title='20'])[4]";

        public IWebElement ReservedSKUTwo => Driver.FindElement(By.XPath(ReservedSKUTwoXpath));

        public const string ReservedSKUThreeXpath = "(//span[@title='5'])[2]";

        public IWebElement ReservedSKUThree => Driver.FindElement(By.XPath(ReservedSKUThreeXpath));
        public const string CancelAllQtyOrderlinesXpath = "//span[@aria-label='Cancel Qty All Orderlines']";
        public IWebElement CancelAllQtyOrderlines => Driver.FindElement(By.XPath(CancelAllQtyOrderlinesXpath));
        public const string VerifyFPFBCodeXpath = "//td[@controlname='Code']//span";
        public IWebElement VerifyFPFBCode => Driver.FindElement(By.XPath(VerifyFPFBCodeXpath));
        public const string LaunchQueueGroupXpath = "//div[@class='no-icon-button-align--ddQBukIYLVNCGBpe2JCxo command-bar-button-text--2dIQkzAbHK18inPTYeiPdF thm-popp-a2-font-stack-2--minflat thm-popp-a2-font-size-2--minflat thm-popp-a2-color-2--minflat'][contains(.,'Launch')]";
        public IWebElement LaunchInQueueGroup => Driver.FindElement(By.XPath(LaunchQueueGroupXpath));

        public const string LaunchInQueueGroupListXpath = "//span[@aria-label='Launch']";
        public IWebElement LaunchInQueueGroupList => Driver.FindElement(By.XPath(LaunchInQueueGroupListXpath));


        public const string LaunchAndPrintPickLabelsXpath = "//button[@type='button'][contains(.,'Launch and Print PickLabels')]";
        public IWebElement LaunchAndPrintPickLabels => Driver.FindElement(By.XPath(LaunchAndPrintPickLabelsXpath));
        public const string PickLabelNumberFirstQueueXpath = "//td[@controlname='PickLabelNo']//span";
        public IWebElement PickLabelNumberFirstQueue => Driver.FindElement(By.XPath(PickLabelNumberFirstQueueXpath));

        public const string ManageOrderOutboundTwoXpath = "(//span[@aria-label='Manage'])[2]";
        public IWebElement ManageOrderOutboundTwo => Driver.FindElement(By.XPath(ManageOrderOutboundTwoXpath));

        public const string SelectThirdRowForThirdQueueXpath = "(//tr[@aria-rowindex='3'])[2]//div//label";
        public IWebElement SelectThirdRowForThirdQueue => Driver.FindElement(By.XPath(SelectThirdRowForThirdQueueXpath));
        public const string FilterInPOWERQueueDetailTableXpath = "//i[@data-icon-name='Filter']";
        public IWebElement FilterInPOWERQueueDetailTable => Driver.FindElement(By.XPath(FilterInPOWERQueueDetailTableXpath));
        public const string MultiOrderNumbersXpath = "//a[contains(text(), 'MultiOrderNumber')]";
        public IWebElement MultiOrderNumbers => Driver.FindElement(By.XPath(MultiOrderNumbersXpath));
        public const string FirstMultiOrderLetterXpath = "//td[@controlname='MultiOrderLetter']//span";
        public IWebElement FirstMultiOrderLetter => Driver.FindElement(By.XPath(FirstMultiOrderLetterXpath));

        public const string SecondMultiOrderLetterXpath = "//span[@title='2']";
        public IWebElement SecondMultiOrderLetter => Driver.FindElement(By.XPath(SecondMultiOrderLetterXpath));

        public const string ThirdMultiOrderLetterXpath = "//span[@title='3']";
        public IWebElement ThirdMultiOrderLetter => Driver.FindElement(By.XPath(ThirdMultiOrderLetterXpath));
        public const string SetBackCreatedroupXpath = "//span[contains(text(),'Set Back Created')]";
        public IWebElement SetBackCreatedroup => Driver.FindElement(By.XPath(SetBackCreatedroupXpath));
        public const string SetupGeneralXpath = "//div[contains(text(),'General')]";
        public IWebElement SetupGeneral => Driver.FindElement(By.XPath(SetupGeneralXpath));
        public const string ItemFromGeneralXpath = "//*[text() = 'Item']";
        public IWebElement ItemFromGeneral => Driver.FindElement(By.XPath(ItemFromGeneralXpath));
        public const string FilterButtonitemListXpath = "/html/body/div[1]/div[3]/form/main/div[2]/div[4]/div/div/div/div[1]/div[2]/div/div[2]/div[2]/div/div/div[2]/div[2]/button/span";
        public IWebElement FilterButtonitemList => Driver.FindElement(By.XPath(FilterButtonitemListXpath));
        public const string ClickItemFilterXpath = "(//span[text()='Code'])[1]";
        public IWebElement ClickItemFilter => Driver.FindElement(By.XPath(ClickItemFilterXpath));
        public const string AddRefernceFilterITEMXpath = "//div[@controlname='Code']";
        public IWebElement AddRefernceFilterITEM => Driver.FindElement(By.XPath(AddRefernceFilterITEMXpath));

        public const string EditInItemListXpath = "//span[@aria-label='Edit']";
        public IWebElement EditInItemList => Driver.FindElement(By.XPath(EditInItemListXpath));

        public const string ClickManipulationInItemCardXpath = "//span[contains(text(),'Measurements')]";
        public IWebElement ClickManipulationInItemCard => Driver.FindElement(By.XPath(ClickManipulationInItemCardXpath));

        public const string ClickShowMoreinManipulationItemCardXpath = "(//button[@title='Show more fields'])[7]";
        public IWebElement ClickShowMoreinManipulationItemCard => Driver.FindElement(By.XPath(ClickShowMoreinManipulationItemCardXpath));

        public const string CheckWidthInItemCardXpath = "/html/body/div[1]/div[4]/form/main/div[2]/div[6]/div[2]/div[2]/div[2]/div/div[9]/div[2]/div/div/div[3]/div[2]/div[1]/div/input";
        public IWebElement CheckWidthInItemCard => Driver.FindElement(By.XPath(CheckWidthInItemCardXpath));

        public const string CheckItemGroupXpath = "//div[@controlname = 'Item Group']//div//input";
        public IWebElement CheckItemGroup => Driver.FindElement(By.XPath(CheckItemGroupXpath));

        public const string ConfigurationXpath = "//span[text()='Configuration']";
        public IWebElement Configuration => Driver.FindElement(By.XPath(ConfigurationXpath));
        
        public const string ConfigurationSecondXpath = "//a[@title='Actions for Configurations']";
        public IWebElement ConfigurationSecond => Driver.FindElement(By.XPath(ConfigurationSecondXpath));

        public const string ConfigurationDetailXpath = "//span[text()='Detail']";
        public IWebElement ConfigurationDetail=> Driver.FindElement(By.XPath(ConfigurationDetailXpath));

        public const string ClickOnMoreOptionsConfigurationXpath = "//div[text()='73312 POWER Item Config Detail Sub']/following::span[text()='More options']";
        public IWebElement ClickOnMoreOptionsConfiguration => Driver.FindElement(By.XPath(ClickOnMoreOptionsConfigurationXpath));

        public const string DetailItemConfigDetailXpath = "//span[@aria-label = 'Detail']";
        public IWebElement DetailItemConfigDetail => Driver.FindElement(By.XPath(DetailItemConfigDetailXpath));

        public const string BarcodeRelatedQuantitiesXpath = "//span[@aria-label = 'Barcode Related Quantities']";
        public IWebElement BarcodeRelatedQuantities => Driver.FindElement(By.XPath(BarcodeRelatedQuantitiesXpath));

        public const string barcodeConfigDetailXpath = "//td[@controlname = 'Barcode']//input";
        public IWebElement barcodeConfigDetail => Driver.FindElement(By.XPath(barcodeConfigDetailXpath));

       
        public const string CloseButtononItemConfigDetailCardXpath = "(//span[text()='Close'])[1]";
        public IWebElement CloseButtononItemConfigDetailCard => Driver.FindElement(By.XPath(CloseButtononItemConfigDetailCardXpath));

        public const string BookBackPartOfSelectedLineXpath = "//span[contains(text(),'Book Back PART OF selected line')]";
        public IWebElement BookBackPartOfSelectedLine => Driver.FindElement(By.XPath(BookBackPartOfSelectedLineXpath));
        public const string ManipulationLobasXpath = "//div[text()='Manipulation']";
        public IWebElement ManipulationLobas => Driver.FindElement(By.XPath(ManipulationLobasXpath));
        public const string LB2SDDetailXpath = "//a[text()='LB2SD Detail']";
        public IWebElement LB2SDDetail => Driver.FindElement(By.XPath(LB2SDDetailXpath));
        public const string HolderBarcodePowerSelectStockXpath = "//div[contains(@controlname,'HolderBarcode')]//div//input";
        public IWebElement HolderBarcodePowerSelectStock => Driver.FindElement(By.XPath(HolderBarcodePowerSelectStockXpath));
        public const string AddSkutoTransferXpath = "//td[contains(@controlname,'TBX_Transfer_Journal_Sku')]//input";
        public IWebElement AddSkutoTransfer => Driver.FindElement(By.XPath(AddSkutoTransferXpath));
        public IWebElement AddJtransfer => Driver.FindElement(By.XPath(AddJtransferXpath));
        public const string AddJtransferXpath = "//td[contains(@controlname,'Journal Transfer')]//input";

      
        

        public const string AddJcommentXpath = "//td[contains(@controlname,'Journal Comment')]//input";
        public IWebElement AddJcomment => Driver.FindElement(By.XPath(AddJcommentXpath));

        public const string AddJnewlocationXpath = "//td[contains(@controlname,'Journal New Location')]//input";
        public IWebElement AddJnewlocation => Driver.FindElement(By.XPath(AddJnewlocationXpath));
        public const string BookAllinManipulationXpath = "//span[@aria-label='Book All']";
        public IWebElement BookAllinManipulation => Driver.FindElement(By.XPath(BookAllinManipulationXpath));
        public const string BookAllinManipulationLB2SDXpath = "//span[contains(text(),'Book ALL')]";
        public IWebElement BookAllinManipulationLB2SD => Driver.FindElement(By.XPath(BookAllinManipulationLB2SDXpath));
        public const string ManageButtonManipulationXpath = "//span[@aria-label='Manage']";
        public IWebElement ManageButtonManipulation => Driver.FindElement(By.XPath(ManageButtonManipulationXpath));
        public const string DeleteButtonManipulationXpath = "//span[text()='Delete']";
        public IWebElement DeleteButtonManipulation => Driver.FindElement(By.XPath(DeleteButtonManipulationXpath));
        public const string LB2SDHeaderXpath = "//a[text()='LB2SD Header']";
        public IWebElement LB2SDHeader => Driver.FindElement(By.XPath(LB2SDHeaderXpath));
        public IWebElement PickHolderGone => Driver.FindElement(By.XPath(PickHolderGoneXpath));
        public const string PickHolderGoneXpath = "//span[@title='PI238991']";
        public IWebElement CutOffFromMainMenu => Driver.FindElement(By.XPath(CutOffFromMainMenuXpath));
        public const string CutOffFromMainMenuXpath = "//a[starts-with(@title,'Outbounds with Status Outbound Order = In Order.')]";
        public IWebElement ClickOutboundfromCutoff => Driver.FindElement(By.XPath(ClickOutboundfromCutoffXpath));
        public const string ClickOutboundfromCutoffXpath = "//span[@aria-label=('Outbound')]";
        public IWebElement ClickCutOff => Driver.FindElement(By.XPath(ClickCutOffXpath));
        public const string ClickCutOffXpath = "//span[@aria-label=('Cut Off')]";
        public IWebElement BookBackBatchQG => Driver.FindElement(By.XPath(BookBackBatchQGXpath));
        public const string BookBackBatchQGXpath = "//button[@aria-label='Book Back Selected Batch Picking QG']";
        public IWebElement OKInPOWERPackingModule => Driver.FindElement(By.XPath(OKInPOWERPackingModuleQGXpath));
        public const string OKInPOWERPackingModuleQGXpath = "//button[@id='btnOK']";
        public IWebElement OKButtonERROR => Driver.FindElement(By.XPath(OKButtonERRORXpath));
        public const string OKButtonERRORXpath = "(//div[@class='ms-nav-actionbar-container has-actions']//span[contains(text(),'OK')])[2]";
        public IWebElement OKButtonSecondPacking => Driver.FindElement(By.XPath(OKButtonSecondPackingXpath));
        public const string OKButtonSecondPackingXpath = "//div[@class='ms-nav-actionbar-container has-actions']//span[contains(text(),'OK')]";
        public IWebElement CloseBtnPowerPackingVASmodule => Driver.FindElement(By.XPath(CloseBtnPowerPackingVASmoduleXpath));
        public const string CloseBtnPowerPackingVASmoduleXpath = "(//button[@class='cursorinherit ms-nav-button thm-popp-a3-bgcolor thm-popp-a3-bgcolor-1--hover thm-popp-a3-bgcolor-3--active thm-popp-a3-color thm-popp-a3-color-1--hover thm-popp-a3-color-2--focus thm-popp-a3-color-3--active thm-popp-a3-font-stack thm-popp-a3-font-size thm-popp-a3-outlinecolor thm-popp-a3-outlinecolor-2--focus thm-popp-a3-bdrcolor thm-popp-a3-bdrcolor-1--hover thm-popp-a3-bdrcolor-2--focus thm-popp-a3-bdrcolor-3--active'])[2]";
        public IWebElement VasPowerModule => Driver.FindElement(By.XPath(VasPowerModuleXpath));
        public const string VasPowerModuleXpath = "//div[@class='col-10 lbl-wrapper']//label[text()='VAS CODE MODULE']";
        public IWebElement SwitchToVASPackingFrame => Driver.FindElement(By.XPath(SwitchToVASPackingFrameXpath));
        public const string SwitchToVASPackingFrameXpath = "//iframe[@title='POWERVASModule']";
        public IWebElement WideLayoutViewButton => Driver.FindElement(By.XPath(WideLayoutViewButtonXpath));
        public const string WideLayoutViewButtonXpath = "(//button[@title='Show wide layout view'])[2]";
        public IWebElement EnterTypeOnOutbound => Driver.FindElement(By.XPath(EnterTypeOnOutboundXpath));
        public const string EnterTypeOnOutboundXpath = "//div[@controlname='Type']//div//input";

        public IWebElement ThreeDotsOnDestinationCode => Driver.FindElement(By.XPath(ThreeDotsOnDestinationCodeXpath));
        public const string ThreeDotsOnDestinationCodeXpath = "//a[@aria-label=('Drill down to record for Code')]";

        public const string PiecePickingValidationXpath = "//span[contains(text(), 'Piece picking')]";
        public IWebElement PiecePickingValidation => Driver.FindElement(By.XPath(PiecePickingValidationXpath));
        public const string InputQueueNumberXpath = "//div[@controlname='Queue Number']//input";
        public IWebElement InputQueueNumber => Driver.FindElement(By.XPath(InputQueueNumberXpath));
        public const string CreateOrderLineAdeoXpath = "//span[@aria-label='Create Orderline']";
        public IWebElement CreateOrderLineAdeo => Driver.FindElement(By.XPath(CreateOrderLineAdeoXpath));
        public IWebElement TourBuildingQueueGroupList => Driver.FindElement(By.XPath(TourBuildingQueueGroupListXpath));
        public const string TourBuildingQueueGroupListXpath = "//div[@class='no-icon-button-align--ddQBukIYLVNCGBpe2JCxo command-bar-button-text--2dIQkzAbHK18inPTYeiPdF thm-popp-a2-font-stack-2--minflat thm-popp-a2-font-size-2--minflat thm-popp-a2-color-2--minflat'][contains(.,'Tour Building')]";
        public IWebElement ImportPickingToursQueueGroupList => Driver.FindElement(By.XPath(ImportPickingToursQueueGroupListXpath));
        public const string ImportPickingToursQueueGroupListXpath = "//div[contains(text(), 'Import picking tours and multi orders')]";
        public IWebElement FilterOnTourBuildingLogivation => Driver.FindElement(By.XPath(FilterOnTourBuildingLogivationXpath));
        public const string FilterOnTourBuildingLogivationXpath = "(//button[@aria-label='Add a new filter on a field'])[2]";
        public IWebElement POWTourBuldingLogivationSearch => Driver.FindElement(By.XPath(POWTourBuldingLogivationSearchXpath));
        public const string POWTourBuldingLogivationSearchXpath = "//div[@class='ms-ComboBox-container combo-box--2YMDRz4Xh8R706OYoP98qk ']//div//input";
        public IWebElement QueueToUploadTourBuilding => Driver.FindElement(By.XPath(QueueToUploadTourBuildingXpath));
        public const string QueueToUploadTourBuildingXpath = "//a[@title = 'Choose file']//input";
        public IWebElement InputBatchOnQueuegroupList => Driver.FindElement(By.XPath(InputBatchOnQueuegroupListXpath));
        public const string InputBatchOnQueuegroupListXpath = "//div[@controlname='Batch Number']//input";
        public IWebElement ErrorMultiOrderQG => Driver.FindElement(By.XPath(ErrorMultiOrderQGXpath));
        public const string ErrorMultiOrderQGXpath = "//p[contains(text(),'It is not allowed to add queues for multiple batches to a multi-order QG.')]";

    }

}