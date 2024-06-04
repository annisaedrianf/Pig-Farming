// Class Name : fVendor.cs 
// Project Name : FICO 
// Last Update : 06/06/2023 14:06:56  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/06/2023 14:06:56 
 // Updated :   
//======================================================================== 
 
using System; 
using DevExpress.Xpo; 
using DevExpress.Persistent.Base; 
using System.ComponentModel; 
using DevExpress.Persistent.Validation; 
using DevExpress.ExpressApp.DC; 
using DevExpress.ExpressApp.ConditionalAppearance; 
using DevExpress.ExpressApp; 
using DevExpress.Data.Filtering; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Editors;

namespace cetho.Module.BusinessObjects 
{ 
   [DefaultClassOptions] 
   [ImageName("ModelEditor_Views")] 
   [DefaultProperty("TaxCatgr")]
   [NavigationItem("Master")]
   // Standard Document
   [System.ComponentModel.DisplayName("Create a Vendor")]
   public class fVendor : XPObject
   {
     public fVendor(Session session) : base(session) 
     {
       // This constructor is used when an object is loaded from a persistent storage.
       // Do not place any code here.
     }
     public override void AfterConstruction()
     {
       base.AfterConstruction();
       // Place here your initialization code.
       //SecuritySystem.CurrentUserName
       //LastUpdateUser = Session.GetObjectByKey<GPUser>(SecuritySystem.CurrentUserId);
       string tUser = SecuritySystem.CurrentUserName.ToString();
       //LastUpdateUser = Session.FindObject<GPUser>(new BinaryOperator("UserName", SecuritySystem.CurrentUserName.ToString())); 
       // LastUpdateUser = Session.FindObject<GPUser>(new BinaryOperator("UserName", tUser)); 
       // LastUpdate = DateTime.Now; 
     } 
     protected override void OnSaving()
     {
       base.OnSaving();
     } 
     protected override void OnSaved()
     {
       base.OnSaved();
     } 
     protected override void OnDeleting()
     {
       base.OnDeleting();
     } 
     protected override void OnDeleted()
     {
       base.OnDeleted();
     } 
     public void Sync()
     {
     } 
     [Appearance("VisiblefVendorOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Account control
     // Notes for fVendor : 
     private string _authorization; 
     [XafDisplayName("Authorization"), ToolTip("Authorization")] 
     // [Appearance("fVendorauthorization", Enabled = true)]
     // [Appearance("fVendorauthorizationVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string authorization
     { 
       get { return _authorization; } 
       set { SetPropertyValue(nameof(authorization), ref _authorization, value); } 
     } 
     // Account control
     // Notes for fVendor : 
     //private fCustomer _customer; 
     //[XafDisplayName("Customer"), ToolTip("Customer")] 
     //// [Appearance("fVendorcustomer", Enabled = true)]
     //// [Appearance("fVendorcustomerVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     //// [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     //// [RuleRequiredField(DefaultContexts.Save)] 
     //// [IsSearch(true)]
     //public  fCustomer customer
     //{ 
     //  get { return _customer; } 
     //  set { SetPropertyValue(nameof(customer), ref _customer, value); } 
     //} 
     // Account control
     // Notes for fVendor : 
     private string _groupkey1; 
     [XafDisplayName("Group Key (Ctrl)"), ToolTip("Group Key (Ctrl)")] 
     // [Appearance("fVendorgroupkey1", Enabled = true)]
     // [Appearance("fVendorgroupkey1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(15)] 
     public  string groupkey1
     { 
       get { return _groupkey1; } 
       set { SetPropertyValue(nameof(groupkey1), ref _groupkey1, value); } 
     } 
     // Account control
     // Notes for fVendor : 
     private string _tradingpartner; 
     [XafDisplayName("Trading Partner"), ToolTip("Trading Partner")] 
     // [Appearance("fVendortradingpartner", Enabled = true)]
     // [Appearance("fVendortradingpartnerVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string tradingpartner
     { 
       get { return _tradingpartner; } 
       set { SetPropertyValue(nameof(tradingpartner), ref _tradingpartner, value); } 
     } 
     // Accounting information
     // Notes for fVendor : 
     private string _authorization1; 
     [XafDisplayName("Authorization (Accnt)"), ToolTip("Authorization (Accnt)")] 
     // [Appearance("fVendorauthorization1", Enabled = true)]
     // [Appearance("fVendorauthorization1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string authorization1
     { 
       get { return _authorization1; } 
       set { SetPropertyValue(nameof(authorization1), ref _authorization1, value); } 
     } 
     // Accounting information
     // Notes for fVendor : 
     private string _cashmgmnt; 
     [XafDisplayName("Cash Mgmnt Group"), ToolTip("Cash mgmnt group")] 
     // [Appearance("fVendorcashmgmnt", Enabled = true)]
     // [Appearance("fVendorcashmgmntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string cashmgmnt
     { 
       get { return _cashmgmnt; } 
       set { SetPropertyValue(nameof(cashmgmnt), ref _cashmgmnt, value); } 
     } 
     // Accounting information
     // Notes for fVendor : 
     private DateTime _certifdate; 
     [XafDisplayName("Certificate Date"), ToolTip("Certificatn date")] 
     // [Appearance("fVendorcertifdate", Enabled = true)]
     // [Appearance("fVendorcertifdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime certifdate
     { 
       get { return _certifdate; } 
       set { SetPropertyValue(nameof(certifdate), ref _certifdate, value); } 
     } 
     // Accounting information
     // Notes for fVendor : 
     private string _headoffice; 
     [XafDisplayName("Head Office"), ToolTip("Head office")] 
     // [Appearance("fVendorheadoffice", Enabled = true)]
     // [Appearance("fVendorheadofficeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string headoffice
     { 
       get { return _headoffice; } 
       set { SetPropertyValue(nameof(headoffice), ref _headoffice, value); } 
     } 
     // Accounting information
     // Notes for fVendor : 
     private string _minorityindic; 
     [XafDisplayName("Minority Indic."), ToolTip("Minority indic.")] 
     // [Appearance("fVendorminorityindic", Enabled = true)]
     // [Appearance("fVendorminorityindicVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string minorityindic
     { 
       get { return _minorityindic; } 
       set { SetPropertyValue(nameof(minorityindic), ref _minorityindic, value); } 
     } 
     // Accounting information
     // Notes for fVendor : 
     private string _reconacct; 
     [XafDisplayName("Recon. Account"), ToolTip("Recon. Account")] 
     // [Appearance("fVendorreconacct", Enabled = true)]
     // [Appearance("fVendorreconacctVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string reconacct
     { 
       get { return _reconacct; } 
       set { SetPropertyValue(nameof(reconacct), ref _reconacct, value); } 
     } 
     // Accounting information
     // Notes for fVendor : 
     private string _releasegroup; 
     [XafDisplayName("Release Group"), ToolTip("Release group")] 
     // [Appearance("fVendorreleasegroup", Enabled = true)]
     // [Appearance("fVendorreleasegroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string releasegroup
     { 
       get { return _releasegroup; } 
       set { SetPropertyValue(nameof(releasegroup), ref _releasegroup, value); } 
     } 
     // Accounting information
     // Notes for fVendor : 
     private string _sortkey; 
     [XafDisplayName("Sort Key"), ToolTip("Sort key")] 
     // [Appearance("fVendorsortkey", Enabled = true)]
     // [Appearance("fVendorsortkeyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string sortkey
     { 
       get { return _sortkey; } 
       set { SetPropertyValue(nameof(sortkey), ref _sortkey, value); } 
     } 
     // Alternative payee in document
     // Notes for fVendor : 
     private bool _indivspec; 
     [XafDisplayName("Individual Spec."), ToolTip("Individual spec.")] 
     // [Appearance("fVendorindivspec", Enabled = true)]
     // [Appearance("fVendorindivspecVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool indivspec
     { 
       get { return _indivspec; } 
       set { SetPropertyValue(nameof(indivspec), ref _indivspec, value); } 
     } 
     // Alternative payee in document
     // Notes for fVendor : 
     private bool _specreference; 
     [XafDisplayName("Spec. per Reference"), ToolTip("Spec. per reference")] 
     // [Appearance("fVendorspecreference", Enabled = true)]
     // [Appearance("fVendorspecreferenceVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool specreference
     { 
       get { return _specreference; } 
       set { SetPropertyValue(nameof(specreference), ref _specreference, value); } 
     } 
     // Automatic payment transactions
     // Notes for fVendor : 
     private string _altrpayee; 
     [XafDisplayName("Alternat. Payee (Auto)"), ToolTip("Alternat.payee (Auto)")] 
     // [Appearance("fVendoraltrpayee", Enabled = true)]
     // [Appearance("fVendoraltrpayeeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string altrpayee
     { 
       get { return _altrpayee; } 
       set { SetPropertyValue(nameof(altrpayee), ref _altrpayee, value); } 
     } 
     // Automatic payment transactions
     // Notes for fVendor : 
     private string _bexchlimit; 
     [XafDisplayName("B/Exch. Limit"), ToolTip("B/exch.limit")] 
     // [Appearance("fVendorbexchlimit", Enabled = true)]
     // [Appearance("fVendorbexchlimitVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string bexchlimit
     { 
       get { return _bexchlimit; } 
       set { SetPropertyValue(nameof(bexchlimit), ref _bexchlimit, value); } 
     } 
     // Automatic payment transactions
     // Notes for fVendor : 
     private string _groupkey2; 
     [XafDisplayName("Grouping Key (Auto)"), ToolTip("Grouping key (Auto)")] 
     // [Appearance("fVendorgroupkey2", Enabled = true)]
     // [Appearance("fVendorgroupkey2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string groupkey2
     { 
       get { return _groupkey2; } 
       set { SetPropertyValue(nameof(groupkey2), ref _groupkey2, value); } 
     } 
     // Automatic payment transactions
     // Notes for fVendor : 
     private string _housebank; 
     [XafDisplayName("House Bank"), ToolTip("House bank")] 
     // [Appearance("fVendorhousebank", Enabled = true)]
     // [Appearance("fVendorhousebankVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string housebank
     { 
       get { return _housebank; } 
       set { SetPropertyValue(nameof(housebank), ref _housebank, value); } 
     } 
     // Automatic payment transactions
     // Notes for fVendor : 
     private bool _indivpmnt; 
     [XafDisplayName("Individual Pmnt"), ToolTip("Individual pmnt")] 
     // [Appearance("fVendorindivpmnt", Enabled = true)]
     // [Appearance("fVendorindivpmntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool indivpmnt
     { 
       get { return _indivpmnt; } 
       set { SetPropertyValue(nameof(indivpmnt), ref _indivpmnt, value); } 
     } 
     // Automatic payment transactions
     // Notes for fVendor : 
     private string _paytblock; 
     [XafDisplayName("Payment Block"), ToolTip("Payment block")] 
     // [Appearance("fVendorpaytblock", Enabled = true)]
     // [Appearance("fVendorpaytblockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string paytblock
     { 
       get { return _paytblock; } 
       set { SetPropertyValue(nameof(paytblock), ref _paytblock, value); } 
     } 
     // Automatic payment transactions
     // Notes for fVendor : 
     private string _paytmethod; 
     [XafDisplayName("Payment Method"), ToolTip("Payment method")] 
     // [Appearance("fVendorpaytmethod", Enabled = true)]
     // [Appearance("fVendorpaytmethodVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string paytmethod
     { 
       get { return _paytmethod; } 
       set { SetPropertyValue(nameof(paytmethod), ref _paytmethod, value); } 
     } 
     // Automatic payment transactions
     // Notes for fVendor : 
     private bool _pmtadvedi; 
     [XafDisplayName("Pmt Adv. by EDI"), ToolTip("pmt adv. by EDI")] 
     // [Appearance("fVendorpmtadvedi", Enabled = true)]
     // [Appearance("fVendorpmtadvediVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool pmtadvedi
     { 
       get { return _pmtadvedi; } 
       set { SetPropertyValue(nameof(pmtadvedi), ref _pmtadvedi, value); } 
     } 
     // Bank details
     // Notes for fVendor : 
     //private fGLAcct _acctholder; 
     //[XafDisplayName("Acct Holder"), ToolTip("Acct holder")] 
     //// [Appearance("fVendoracctholder", Enabled = true)]
     //// [Appearance("fVendoracctholderVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     //// [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     //// [RuleRequiredField(DefaultContexts.Save)] 
     //// [IsSearch(true)]
     //public  fGLAcct acctholder
     //{ 
     //  get { return _acctholder; } 
     //  set { SetPropertyValue(nameof(acctholder), ref _acctholder, value); } 
     //} 
     // Bank details
     //// Notes for fVendor : 
     //private fBank _bankacc; 
     //[XafDisplayName("Bank Account"), ToolTip("Bank Account")] 
     //// [Appearance("fVendorbankacc", Enabled = true)]
     //// [Appearance("fVendorbankaccVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     //// [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     //// [RuleRequiredField(DefaultContexts.Save)] 
     //// [IsSearch(true)]
     //public  fBank bankacc
     //{ 
     //  get { return _bankacc; } 
     //  set { SetPropertyValue(nameof(bankacc), ref _bankacc, value); } 
     //} 
     // Bank details
     // Notes for fVendor : 
     private string _ctry; 
     [XafDisplayName("Country"), ToolTip("Ctry")] 
     // [Appearance("fVendorctry", Enabled = true)]
     // [Appearance("fVendorctryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string ctry
     { 
       get { return _ctry; } 
       set { SetPropertyValue(nameof(ctry), ref _ctry, value); } 
     } 
     // Communication
     // Notes for fVendor : 
     private string _dataline1; 
     [XafDisplayName("Data Line "), ToolTip("Data line (Comm)")] 
     // [Appearance("fVendordataline1", Enabled = true)]
     // [Appearance("fVendordataline1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(150)] 
     public  string dataline1
     { 
       get { return _dataline1; } 
       set { SetPropertyValue(nameof(dataline1), ref _dataline1, value); } 
     } 
     // Communication
     // Notes for fVendor : 
     private string _email; 
     [XafDisplayName("E-Mail"), ToolTip("E-Mail")] 
     // [Appearance("fVendoremail", Enabled = true)]
     // [Appearance("fVendoremailVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(200)] 
     public  string email
     { 
       get { return _email; } 
       set { SetPropertyValue(nameof(email), ref _email, value); } 
     } 
     // Communication
     // Notes for fVendor : 
     private string _extension; 
     [XafDisplayName("Extension"), ToolTip("Extension")] 
     // [Appearance("fVendorextension", Enabled = true)]
     // [Appearance("fVendorextensionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string extension
     { 
       get { return _extension; } 
       set { SetPropertyValue(nameof(extension), ref _extension, value); } 
     } 
     // Communication
     // Notes for fVendor : 
     private string _fax; 
     [XafDisplayName("Fax"), ToolTip("Fax")] 
     // [Appearance("fVendorfax", Enabled = true)]
     // [Appearance("fVendorfaxVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string fax
     { 
       get { return _fax; } 
       set { SetPropertyValue(nameof(fax), ref _fax, value); } 
     } 
     // Communication
     // Notes for fVendor : 
     //private enumLang _language; 
     //[XafDisplayName("Language"), ToolTip("Language")] 
     //// [Appearance("fVendorlanguage", Enabled = true)]
     //// [Appearance("fVendorlanguageVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     //// [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     //// [RuleRequiredField(DefaultContexts.Save)] 
     //// [IsSearch(true)]
     //public  enumLang language
     //{ 
     //  get { return _language; } 
     //  set { SetPropertyValue(nameof(language), ref _language, value); } 
     //} 
     // Communication
     // Notes for fVendor : 
     private string _phone; 
     [XafDisplayName("Mobile Phone"), ToolTip("Mobile Phone")] 
     // [Appearance("fVendorphone", Enabled = true)]
     // [Appearance("fVendorphoneVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string phone
     { 
       get { return _phone; } 
       set { SetPropertyValue(nameof(phone), ref _phone, value); } 
     } 
     // Communication
     // Notes for fVendor : 
     private string _standcomm; 
     [XafDisplayName("Standard Comm. Mtd"), ToolTip("StandardComm.Mtd")] 
     // [Appearance("fVendorstandcomm", Enabled = true)]
     // [Appearance("fVendorstandcommVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string standcomm
     { 
       get { return _standcomm; } 
       set { SetPropertyValue(nameof(standcomm), ref _standcomm, value); } 
     } 
     // Communication
     // Notes for fVendor : 
     private string _telebox1; 
     [XafDisplayName("Telebox"), ToolTip("Telebox (Com)")] 
     // [Appearance("fVendortelebox1", Enabled = true)]
     // [Appearance("fVendortelebox1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(150)] 
     public  string telebox1
     { 
       get { return _telebox1; } 
       set { SetPropertyValue(nameof(telebox1), ref _telebox1, value); } 
     } 
     // Communication
     // Notes for fVendor : 
     private string _telephone; 
     [XafDisplayName("Telephone"), ToolTip("Telephone")] 
     // [Appearance("fVendortelephone", Enabled = true)]
     // [Appearance("fVendortelephoneVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string telephone
     { 
       get { return _telephone; } 
       set { SetPropertyValue(nameof(telephone), ref _telephone, value); } 
     } 
     // Correspondence
     // Notes for fVendor : 
     private string _accmemo; 
     [XafDisplayName("Account Memo"), ToolTip("Account memo")] 
     // [Appearance("fVendoraccmemo", Enabled = true)]
     // [Appearance("fVendoraccmemoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string accmemo
     { 
       get { return _accmemo; } 
       set { SetPropertyValue(nameof(accmemo), ref _accmemo, value); } 
     } 
     // Correspondence
     // Notes for fVendor : 
     private string _acctgclerk; 
     [XafDisplayName("Acctg Clerk"), ToolTip("Acctg clerk")] 
     // [Appearance("fVendoracctgclerk", Enabled = true)]
     // [Appearance("fVendoracctgclerkVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string acctgclerk
     { 
       get { return _acctgclerk; } 
       set { SetPropertyValue(nameof(acctgclerk), ref _acctgclerk, value); } 
     } 
     // Correspondence
     // Notes for fVendor : 
     private string _acctvendor; 
     [XafDisplayName("Acct w/ vendor"), ToolTip("Acct w/ vendor")] 
     // [Appearance("fVendoracctvendor", Enabled = true)]
     // [Appearance("fVendoracctvendorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(25)] 
     public  string acctvendor
     { 
       get { return _acctvendor; } 
       set { SetPropertyValue(nameof(acctvendor), ref _acctvendor, value); } 
     } 
     // Correspondence
     // Notes for fVendor : 
     private string _actclktel; 
     [XafDisplayName("Act. Cllk Telephone No"), ToolTip("Act.cllk tel.no.")] 
     // [Appearance("fVendoractclktel", Enabled = true)]
     // [Appearance("fVendoractclktelVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string actclktel
     { 
       get { return _actclktel; } 
       set { SetPropertyValue(nameof(actclktel), ref _actclktel, value); } 
     } 
     // Correspondence
     // Notes for fVendor : 
     private string _clerkvendor; 
     [XafDisplayName("Clerk at Vendor"), ToolTip("Clerk at vendor")] 
     // [Appearance("fVendorclerkvendor", Enabled = true)]
     // [Appearance("fVendorclerkvendorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string clerkvendor
     { 
       get { return _clerkvendor; } 
       set { SetPropertyValue(nameof(clerkvendor), ref _clerkvendor, value); } 
     } 
     // Correspondence
     // Notes for fVendor : 
     private string _clrkfax; 
     [XafDisplayName("Clerk's Fax"), ToolTip("Clerk's fax")] 
     // [Appearance("fVendorclrkfax", Enabled = true)]
     // [Appearance("fVendorclrkfaxVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string clrkfax
     { 
       get { return _clrkfax; } 
       set { SetPropertyValue(nameof(clrkfax), ref _clrkfax, value); } 
     } 
     // Correspondence
     // Notes for fVendor : 
     private string _clrkinternet; 
     [XafDisplayName("Clrk's Internet"), ToolTip("Clrk's internet")] 
     // [Appearance("fVendorclrkinternet", Enabled = true)]
     // [Appearance("fVendorclrkinternetVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(300)] 
     public  string clrkinternet
     { 
       get { return _clrkinternet; } 
       set { SetPropertyValue(nameof(clrkinternet), ref _clrkinternet, value); } 
     } 
     // Correspondence
     // Notes for fVendor : 
     private bool _localproc; 
     [XafDisplayName("Local Process"), ToolTip("Local process.")] 
     // [Appearance("fVendorlocalproc", Enabled = true)]
     // [Appearance("fVendorlocalprocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool localproc
     { 
       get { return _localproc; } 
       set { SetPropertyValue(nameof(localproc), ref _localproc, value); } 
     } 
     // Delection blocks
     // Notes for fVendor : 
     private bool _generaldata; 
     [XafDisplayName("General Data"), ToolTip("General data")] 
     // [Appearance("fVendorgeneraldata", Enabled = true)]
     // [Appearance("fVendorgeneraldataVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool generaldata
     { 
       get { return _generaldata; } 
       set { SetPropertyValue(nameof(generaldata), ref _generaldata, value); } 
     } 
     // Delection blocks
     // Notes for fVendor : 
     private bool _selectedcompcodegeneraldata; 
     [XafDisplayName("Selected Company Code incl. General Data"), ToolTip("Selected company code incl. general data")] 
     // [Appearance("fVendorselectedcompcodegeneraldata", Enabled = true)]
     // [Appearance("fVendorselectedcompcodegeneraldataVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool selectedcompcodegeneraldata
     { 
       get { return _selectedcompcodegeneraldata; } 
       set { SetPropertyValue(nameof(selectedcompcodegeneraldata), ref _selectedcompcodegeneraldata, value); } 
     } 
     // Delection flags
     // Notes for fVendor : 
     private bool _allareas; 
     [XafDisplayName("All Areas"), ToolTip("All areas")] 
     // [Appearance("fVendorallareas", Enabled = true)]
     // [Appearance("fVendorallareasVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool allareas
     { 
       get { return _allareas; } 
       set { SetPropertyValue(nameof(allareas), ref _allareas, value); } 
     } 
     // Delection flags
     // Notes for fVendor : 
     private bool _selectedcompcode; 
     [XafDisplayName("Selected Company Code"), ToolTip("Selected company code")] 
     // [Appearance("fVendorselectedcompcode", Enabled = true)]
     // [Appearance("fVendorselectedcompcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool selectedcompcode
     { 
       get { return _selectedcompcode; } 
       set { SetPropertyValue(nameof(selectedcompcode), ref _selectedcompcode, value); } 
     } 
     // Dunning data
     // Notes for fVendor : 
     private string _dunnblock; 
     [XafDisplayName("Dunning Block"), ToolTip("Dunning block")] 
     // [Appearance("fVendordunnblock", Enabled = true)]
     // [Appearance("fVendordunnblockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string dunnblock
     { 
       get { return _dunnblock; } 
       set { SetPropertyValue(nameof(dunnblock), ref _dunnblock, value); } 
     } 
     // Dunning data
     // Notes for fVendor : 
     private string _dunnclerk; 
     [XafDisplayName("Dunning Clerk"), ToolTip("Dunning clerk")] 
     // [Appearance("fVendordunnclerk", Enabled = true)]
     // [Appearance("fVendordunnclerkVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string dunnclerk
     { 
       get { return _dunnclerk; } 
       set { SetPropertyValue(nameof(dunnclerk), ref _dunnclerk, value); } 
     } 
     // Dunning data
     // Notes for fVendor : 
     private string _dunnlevel; 
     [XafDisplayName("Dunning Level"), ToolTip("Dunning level")] 
     // [Appearance("fVendordunnlevel", Enabled = true)]
     // [Appearance("fVendordunnlevelVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string dunnlevel
     { 
       get { return _dunnlevel; } 
       set { SetPropertyValue(nameof(dunnlevel), ref _dunnlevel, value); } 
     } 
     // Dunning data
     // Notes for fVendor : 
     private string _dunnprocedure; 
     [XafDisplayName("Dunn. Procedure"), ToolTip("Dunn.procedure")] 
     // [Appearance("fVendordunnprocedure", Enabled = true)]
     // [Appearance("fVendordunnprocedureVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string dunnprocedure
     { 
       get { return _dunnprocedure; } 
       set { SetPropertyValue(nameof(dunnprocedure), ref _dunnprocedure, value); } 
     } 
     // Dunning data
     // Notes for fVendor : 
     private string _dunnrecipient; 
     [XafDisplayName("Dunn. Recipient"), ToolTip("Dunn.recipient")] 
     // [Appearance("fVendordunnrecipient", Enabled = true)]
     // [Appearance("fVendordunnrecipientVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string dunnrecipient
     { 
       get { return _dunnrecipient; } 
       set { SetPropertyValue(nameof(dunnrecipient), ref _dunnrecipient, value); } 
     } 
     // Dunning data
     // Notes for fVendor : 
     private string _groupkey; 
     [XafDisplayName("Grouping Key"), ToolTip("Grouping key")] 
     // [Appearance("fVendorgroupkey", Enabled = true)]
     // [Appearance("fVendorgroupkeyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string groupkey
     { 
       get { return _groupkey; } 
       set { SetPropertyValue(nameof(groupkey), ref _groupkey, value); } 
     } 
     // Dunning data
     // Notes for fVendor : 
     private string _lastdunn; 
     [XafDisplayName("Last Dunned"), ToolTip("Last dunned")] 
     // [Appearance("fVendorlastdunn", Enabled = true)]
     // [Appearance("fVendorlastdunnVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string lastdunn
     { 
       get { return _lastdunn; } 
       set { SetPropertyValue(nameof(lastdunn), ref _lastdunn, value); } 
     } 
     // Dunning data
     // Notes for fVendor : 
     private string _legaldunnproc; 
     [XafDisplayName("Legal Dunn. Proc."), ToolTip("Legal dunn.proc.")] 
     // [Appearance("fVendorlegaldunnproc", Enabled = true)]
     // [Appearance("fVendorlegaldunnprocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(25)] 
     public  string legaldunnproc
     { 
       get { return _legaldunnproc; } 
       set { SetPropertyValue(nameof(legaldunnproc), ref _legaldunnproc, value); } 
     } 
     // Intereset calculation
     // Notes for fVendor : 
     private string _interestfreq; 
     [XafDisplayName("Interest Freq."), ToolTip("Interest freq.")] 
     // [Appearance("fVendorinterestfreq", Enabled = true)]
     // [Appearance("fVendorinterestfreqVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string interestfreq
     { 
       get { return _interestfreq; } 
       set { SetPropertyValue(nameof(interestfreq), ref _interestfreq, value); } 
     } 
     // Intereset calculation
     // Notes for fVendor : 
     private string _interestindic; 
     [XafDisplayName("Interest Indic."), ToolTip("Interest indic.")] 
     // [Appearance("fVendorinterestindic", Enabled = true)]
     // [Appearance("fVendorinterestindicVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string interestindic
     { 
       get { return _interestindic; } 
       set { SetPropertyValue(nameof(interestindic), ref _interestindic, value); } 
     } 
     // Intereset calculation
     // Notes for fVendor : 
     private string _lastintrun; 
     [XafDisplayName("Last Interest Run"), ToolTip("Last interest run")] 
     // [Appearance("fVendorlastintrun", Enabled = true)]
     // [Appearance("fVendorlastintrunVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string lastintrun
     { 
       get { return _lastintrun; } 
       set { SetPropertyValue(nameof(lastintrun), ref _lastintrun, value); } 
     } 
     // Intereset calculation
     // Notes for fVendor : 
     private DateTime _lastkeydate; 
     [XafDisplayName("Last Key Date"), ToolTip("Last key date")] 
     // [Appearance("fVendorlastkeydate", Enabled = true)]
     // [Appearance("fVendorlastkeydateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime lastkeydate
     { 
       get { return _lastkeydate; } 
       set { SetPropertyValue(nameof(lastkeydate), ref _lastkeydate, value); } 
     } 
     // Invoice verification
     // Notes for fVendor : 
     private string _tolerancegroup; 
     [XafDisplayName("Tolerance Group"), ToolTip("Tolerance group")] 
     // [Appearance("fVendortolerancegroup", Enabled = true)]
     // [Appearance("fVendortolerancegroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string tolerancegroup
     { 
       get { return _tolerancegroup; } 
       set { SetPropertyValue(nameof(tolerancegroup), ref _tolerancegroup, value); } 
     } 
     // Name
     // Notes for fVendor : 
     private string _name; 
     [XafDisplayName("Name"), ToolTip("Name")] 
     // [Appearance("fVendorname", Enabled = true)]
     // [Appearance("fVendornameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(250)] 
     public  string name
     { 
       get { return _name; } 
       set { SetPropertyValue(nameof(name), ref _name, value); } 
     } 
     // Name
     // Notes for fVendor : 
     private string _title; 
     [XafDisplayName("Title"), ToolTip("Title")] 
     // [Appearance("fVendortitle", Enabled = true)]
     // [Appearance("fVendortitleVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string title
     { 
       get { return _title; } 
       set { SetPropertyValue(nameof(title), ref _title, value); } 
     } 
     // Payment data
     // Notes for fVendor : 
     private string _chkcashtime; 
     [XafDisplayName("Chk Cashng Time"), ToolTip("Chk cashng time")] 
     // [Appearance("fVendorchkcashtime", Enabled = true)]
     // [Appearance("fVendorchkcashtimeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string chkcashtime
     { 
       get { return _chkcashtime; } 
       set { SetPropertyValue(nameof(chkcashtime), ref _chkcashtime, value); } 
     } 
     // Payment data
     // Notes for fVendor : 
     private bool _chkdoubleinv; 
     [XafDisplayName("Chk Double Inv"), ToolTip("Chk double inv")] 
     // [Appearance("fVendorchkdoubleinv", Enabled = true)]
     // [Appearance("fVendorchkdoubleinvVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool chkdoubleinv
     { 
       get { return _chkdoubleinv; } 
       set { SetPropertyValue(nameof(chkdoubleinv), ref _chkdoubleinv, value); } 
     } 
     // Payment data
     // Notes for fVendor : 
     private string _paytterms; 
     [XafDisplayName("Payment Terms"), ToolTip("Payment terms")] 
     // [Appearance("fVendorpaytterms", Enabled = true)]
     // [Appearance("fVendorpayttermsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string paytterms
     { 
       get { return _paytterms; } 
       set { SetPropertyValue(nameof(paytterms), ref _paytterms, value); } 
     } 
     // Payment data
     // Notes for fVendor : 
     private string _tolerancegroup1; 
     [XafDisplayName("Tolerance Group"), ToolTip("Tolerance group (Pymt)")] 
     // [Appearance("fVendortolerancegroup1", Enabled = true)]
     // [Appearance("fVendortolerancegroup1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string tolerancegroup1
     { 
       get { return _tolerancegroup1; } 
       set { SetPropertyValue(nameof(tolerancegroup1), ref _tolerancegroup1, value); } 
     } 
     // Payment transactions
     // Notes for fVendor : 
     private string _alterpayee; 
     [XafDisplayName("Alternative Payee"), ToolTip("Alternative payee")] 
     // [Appearance("fVendoralterpayee", Enabled = true)]
     // [Appearance("fVendoralterpayeeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(15)] 
     public  string alterpayee
     { 
       get { return _alterpayee; } 
       set { SetPropertyValue(nameof(alterpayee), ref _alterpayee, value); } 
     } 
     // Payment transactions
     // Notes for fVendor : 
     private string _dmeindic; 
     [XafDisplayName("DME Indicator"), ToolTip("DME indicator")] 
     // [Appearance("fVendordmeindic", Enabled = true)]
     // [Appearance("fVendordmeindicVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string dmeindic
     { 
       get { return _dmeindic; } 
       set { SetPropertyValue(nameof(dmeindic), ref _dmeindic, value); } 
     } 
     // Payment transactions
     // Notes for fVendor : 
     private string _instructkey; 
     [XafDisplayName("Instruction Key"), ToolTip("Instruction key")] 
     // [Appearance("fVendorinstructkey", Enabled = true)]
     // [Appearance("fVendorinstructkeyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string instructkey
     { 
       get { return _instructkey; } 
       set { SetPropertyValue(nameof(instructkey), ref _instructkey, value); } 
     } 
     // Payment transactions
     // Notes for fVendor : 
     private string _pbcnumb; 
     [XafDisplayName("PBC/POR Number"), ToolTip("PBC/POR number")] 
     // [Appearance("fVendorpbcnumb", Enabled = true)]
     // [Appearance("fVendorpbcnumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(15)] 
     public  string pbcnumb
     { 
       get { return _pbcnumb; } 
       set { SetPropertyValue(nameof(pbcnumb), ref _pbcnumb, value); } 
     } 
     // Person subject to withholding tax
     // Notes for fVendor : 
     private string _dataline; 
     [XafDisplayName("Data Line"), ToolTip("Data line")] 
     // [Appearance("fVendordataline", Enabled = true)]
     // [Appearance("fVendordatalineVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(150)] 
     public  string dataline
     { 
       get { return _dataline; } 
       set { SetPropertyValue(nameof(dataline), ref _dataline, value); } 
     } 
     // Person subject to withholding tax
     // Notes for fVendor : 
     private DateTime _datebirth; 
     [XafDisplayName("Date of Birth"), ToolTip("Date of birth")] 
     // [Appearance("fVendordatebirth", Enabled = true)]
     // [Appearance("fVendordatebirthVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime datebirth
     { 
       get { return _datebirth; } 
       set { SetPropertyValue(nameof(datebirth), ref _datebirth, value); } 
     } 
     // Person subject to withholding tax
     // Notes for fVendor : 
     private string _placebirth; 
     [XafDisplayName("Place of Birth"), ToolTip("Place of birth")] 
     // [Appearance("fVendorplacebirth", Enabled = true)]
     // [Appearance("fVendorplacebirthVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string placebirth
     { 
       get { return _placebirth; } 
       set { SetPropertyValue(nameof(placebirth), ref _placebirth, value); } 
     } 
     // Person subject to withholding tax
     // Notes for fVendor : 
     private string _profession; 
     [XafDisplayName("Profession"), ToolTip("Profession")] 
     // [Appearance("fVendorprofession", Enabled = true)]
     // [Appearance("fVendorprofessionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string profession
     { 
       get { return _profession; } 
       set { SetPropertyValue(nameof(profession), ref _profession, value); } 
     } 
     // Person subject to withholding tax
     // Notes for fVendor : 
     private string _sex; 
     [XafDisplayName("Sex"), ToolTip("Sex")] 
     // [Appearance("fVendorsex", Enabled = true)]
     // [Appearance("fVendorsexVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string sex
     { 
       get { return _sex; } 
       set { SetPropertyValue(nameof(sex), ref _sex, value); } 
     } 
     // Person subject to withholding tax
     // Notes for fVendor : 
     private string _telebox; 
     [XafDisplayName("Telebox"), ToolTip("Telebox")] 
     // [Appearance("fVendortelebox", Enabled = true)]
     // [Appearance("fVendorteleboxVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(150)] 
     public  string telebox
     { 
       get { return _telebox; } 
       set { SetPropertyValue(nameof(telebox), ref _telebox, value); } 
     } 
     // PO box address
     // Notes for fVendor : 
     private string _comppostalcode; 
     [XafDisplayName("Company Postal Code"), ToolTip("Company postal code")] 
     // [Appearance("fVendorcomppostalcode", Enabled = true)]
     // [Appearance("fVendorcomppostalcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string comppostalcode
     { 
       get { return _comppostalcode; } 
       set { SetPropertyValue(nameof(comppostalcode), ref _comppostalcode, value); } 
     } 
     // PO box address
     // Notes for fVendor : 
     private string _pobox; 
     [XafDisplayName("PO Box"), ToolTip("PO Box")] 
     // [Appearance("fVendorpobox", Enabled = true)]
     // [Appearance("fVendorpoboxVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string pobox
     { 
       get { return _pobox; } 
       set { SetPropertyValue(nameof(pobox), ref _pobox, value); } 
     } 
     // PO box address
     // Notes for fVendor : 
     private string _postalcode1; 
     [XafDisplayName("Postal Code"), ToolTip("Postal code")] 
     // [Appearance("fVendorpostalcode1", Enabled = true)]
     // [Appearance("fVendorpostalcode1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string postalcode1
     { 
       get { return _postalcode1; } 
       set { SetPropertyValue(nameof(postalcode1), ref _postalcode1, value); } 
     } 
     // Reference
     // Notes for fVendor : 
     //private fCompany _compcode1; 
     //[XafDisplayName("Company Code "), ToolTip("Company Code ")] 
     //// [Appearance("fVendorcompcode1", Enabled = true)]
     //// [Appearance("fVendorcompcode1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     //// [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     //// [RuleRequiredField(DefaultContexts.Save)] 
     //// [IsSearch(true)]
     //public  fCompany compcode1
     //{ 
     //  get { return _compcode1; } 
     //  set { SetPropertyValue(nameof(compcode1), ref _compcode1, value); } 
     //} 
     // Reference
     // Notes for fVendor : 
     private string _vendor1; 
     [XafDisplayName("Vendor "), ToolTip("Vendor ")] 
     // [Appearance("fVendorvendor1", Enabled = true)]
     // [Appearance("fVendorvendor1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string vendor1
     { 
       get { return _vendor1; } 
       set { SetPropertyValue(nameof(vendor1), ref _vendor1, value); } 
     } 
     // Reference data
     // Notes for fVendor : 
     private string _checkdigit; 
     [XafDisplayName("Check Digit"), ToolTip("Check digit")] 
     // [Appearance("fVendorcheckdigit", Enabled = true)]
     // [Appearance("fVendorcheckdigitVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string checkdigit
     { 
       get { return _checkdigit; } 
       set { SetPropertyValue(nameof(checkdigit), ref _checkdigit, value); } 
     } 
     // Reference data
     // Notes for fVendor : 
     private string _creditinfo; 
     [XafDisplayName("Cred. Info No"), ToolTip("Cred.info.no")] 
     // [Appearance("fVendorcreditinfo", Enabled = true)]
     // [Appearance("fVendorcreditinfoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string creditinfo
     { 
       get { return _creditinfo; } 
       set { SetPropertyValue(nameof(creditinfo), ref _creditinfo, value); } 
     } 
     // Reference data
     // Notes for fVendor : 
     private string _crfreight; 
     [XafDisplayName("Cr. Freight Grp"), ToolTip("Cr.freight grp")] 
     // [Appearance("fVendorcrfreight", Enabled = true)]
     // [Appearance("fVendorcrfreightVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string crfreight
     { 
       get { return _crfreight; } 
       set { SetPropertyValue(nameof(crfreight), ref _crfreight, value); } 
     } 
     // Reference data
     // Notes for fVendor : 
     private string _exmanuf; 
     [XafDisplayName("External Manuf."), ToolTip("External manuf.")] 
     // [Appearance("fVendorexmanuf", Enabled = true)]
     // [Appearance("fVendorexmanufVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string exmanuf
     { 
       get { return _exmanuf; } 
       set { SetPropertyValue(nameof(exmanuf), ref _exmanuf, value); } 
     } 
     // Reference data
     // Notes for fVendor : 
     private string _industry; 
     [XafDisplayName("Industry"), ToolTip("Industry")] 
     // [Appearance("fVendorindustry", Enabled = true)]
     // [Appearance("fVendorindustryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string industry
     { 
       get { return _industry; } 
       set { SetPropertyValue(nameof(industry), ref _industry, value); } 
     } 
     // Reference data
     // Notes for fVendor : 
     private string _lastext; 
     [XafDisplayName("Last Ext. Review"), ToolTip("Last ext.review")] 
     // [Appearance("fVendorlastext", Enabled = true)]
     // [Appearance("fVendorlastextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string lastext
     { 
       get { return _lastext; } 
       set { SetPropertyValue(nameof(lastext), ref _lastext, value); } 
     } 
     // Reference data
     // Notes for fVendor : 
     private string _locno1; 
     [XafDisplayName("Location No. 1"), ToolTip("Location no. 1")] 
     // [Appearance("fVendorlocno1", Enabled = true)]
     // [Appearance("fVendorlocno1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string locno1
     { 
       get { return _locno1; } 
       set { SetPropertyValue(nameof(locno1), ref _locno1, value); } 
     } 
     // Reference data
     // Notes for fVendor : 
     private string _locno2; 
     [XafDisplayName("Location No. 2"), ToolTip("Location no. 2")] 
     // [Appearance("fVendorlocno2", Enabled = true)]
     // [Appearance("fVendorlocno2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string locno2
     { 
       get { return _locno2; } 
       set { SetPropertyValue(nameof(locno2), ref _locno2, value); } 
     } 
     // Reference data
     // Notes for fVendor : 
     private string _personnumb; 
     [XafDisplayName("Personnel N umber"), ToolTip("Personnel number")] 
     // [Appearance("fVendorpersonnumb", Enabled = true)]
     // [Appearance("fVendorpersonnumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string personnumb
     { 
       get { return _personnumb; } 
       set { SetPropertyValue(nameof(personnumb), ref _personnumb, value); } 
     } 
     // Reference data
     // Notes for fVendor : 
     private string _prevaccno; 
     [XafDisplayName("Prev. Acct No."), ToolTip("Prev.acct no.")] 
     // [Appearance("fVendorprevaccno", Enabled = true)]
     // [Appearance("fVendorprevaccnoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string prevaccno
     { 
       get { return _prevaccno; } 
       set { SetPropertyValue(nameof(prevaccno), ref _prevaccno, value); } 
     } 
     // Reference data
     // Notes for fVendor : 
     private string _scac; 
     [XafDisplayName("SCAC"), ToolTip("SCAC")] 
     // [Appearance("fVendorscac", Enabled = true)]
     // [Appearance("fVendorscacVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string scac
     { 
       get { return _scac; } 
       set { SetPropertyValue(nameof(scac), ref _scac, value); } 
     } 
     // Reference data
     // Notes for fVendor : 
     private string _sevagnt; 
     [XafDisplayName("Serv. Agnt Proc.  Grp"), ToolTip("ServAgntProcGrp")] 
     // [Appearance("fVendorsevagnt", Enabled = true)]
     // [Appearance("fVendorsevagntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string sevagnt
     { 
       get { return _sevagnt; } 
       set { SetPropertyValue(nameof(sevagnt), ref _sevagnt, value); } 
     } 
     // Reference data
     // Notes for fVendor : 
     private string _statgr; 
     [XafDisplayName("Stat. Gr. Tra. Ser"), ToolTip("Stat.gr.tra.ser")] 
     // [Appearance("fVendorstatgr", Enabled = true)]
     // [Appearance("fVendorstatgrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string statgr
     { 
       get { return _statgr; } 
       set { SetPropertyValue(nameof(statgr), ref _statgr, value); } 
     } 
     // Search terms
     // Notes for fVendor : 
     private string _searchterm; 
     [XafDisplayName("Search Term 1/2"), ToolTip("Search Term 1/2")] 
     // [Appearance("fVendorsearchterm", Enabled = true)]
     // [Appearance("fVendorsearchtermVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(150)] 
     public  string searchterm
     { 
       get { return _searchterm; } 
       set { SetPropertyValue(nameof(searchterm), ref _searchterm, value); } 
     } 
     // Street address
     // Notes for fVendor : 
     //private fCountry _country; 
     //[XafDisplayName("Country"), ToolTip("Country")] 
     //// [Appearance("fVendorcountry", Enabled = true)]
     //// [Appearance("fVendorcountryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     //// [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     //// [RuleRequiredField(DefaultContexts.Save)] 
     //// [IsSearch(true)]
     //public  fCountry country
     //{ 
     //  get { return _country; } 
     //  set { SetPropertyValue(nameof(country), ref _country, value); } 
     //} 
     // Street address
     // Notes for fVendor : 
     private string _postalcode; 
     [XafDisplayName("Postal Code/City"), ToolTip("Postal Code/City")] 
     // [Appearance("fVendorpostalcode", Enabled = true)]
     // [Appearance("fVendorpostalcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string postalcode
     { 
       get { return _postalcode; } 
       set { SetPropertyValue(nameof(postalcode), ref _postalcode, value); } 
     } 
     // Street address
     // Notes for fVendor : 
     private string _street; 
     [XafDisplayName("Street/House Number"), ToolTip("Street/House Number")] 
     // [Appearance("fVendorstreet", Enabled = true)]
     // [Appearance("fVendorstreetVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(500)] 
     public  string street
     { 
       get { return _street; } 
       set { SetPropertyValue(nameof(street), ref _street, value); } 
     } 
     // Street address
     // Notes for fVendor : 
     //private fCountry _time; 
     //[XafDisplayName("Time Zone"), ToolTip("Time Zone")] 
     //// [Appearance("fVendortime", Enabled = true)]
     //// [Appearance("fVendortimeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     //// [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     //// [RuleRequiredField(DefaultContexts.Save)] 
     //// [IsSearch(true)]
     //public  fCountry time
     //{ 
     //  get { return _time; } 
     //  set { SetPropertyValue(nameof(time), ref _time, value); } 
     //} 
     // Tax information
     // Notes for fVendor : 
     private bool _equalizatntax; 
     [XafDisplayName("Equalization Tax"), ToolTip("Equalizatn tax")] 
     // [Appearance("fVendorequalizatntax", Enabled = true)]
     // [Appearance("fVendorequalizatntaxVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool equalizatntax
     { 
       get { return _equalizatntax; } 
       set { SetPropertyValue(nameof(equalizatntax), ref _equalizatntax, value); } 
     } 
     // Tax information
     // Notes for fVendor : 
     private string _fiscaladd; 
     [XafDisplayName("Fiscal Address"), ToolTip("Fiscal address")] 
     // [Appearance("fVendorfiscaladd", Enabled = true)]
     // [Appearance("fVendorfiscaladdVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string fiscaladd
     { 
       get { return _fiscaladd; } 
       set { SetPropertyValue(nameof(fiscaladd), ref _fiscaladd, value); } 
     } 
     // Tax information
     // Notes for fVendor : 
     private bool _sale; 
     [XafDisplayName("Sale/Pur. Tax"), ToolTip("Sale/pur.tax")] 
     // [Appearance("fVendorsale", Enabled = true)]
     // [Appearance("fVendorsaleVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool sale
     { 
       get { return _sale; } 
       set { SetPropertyValue(nameof(sale), ref _sale, value); } 
     } 
     // Tax information
     // Notes for fVendor : 
     private bool _soleproprietr; 
     [XafDisplayName("Sole Proprietr"), ToolTip("Sole Proprietr")] 
     // [Appearance("fVendorsoleproprietr", Enabled = true)]
     // [Appearance("fVendorsoleproprietrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool soleproprietr
     { 
       get { return _soleproprietr; } 
       set { SetPropertyValue(nameof(soleproprietr), ref _soleproprietr, value); } 
     } 
     // Tax information
     // Notes for fVendor : 
     private string _taxjur; 
     [XafDisplayName("Tax Jur."), ToolTip("Tax Jur.")] 
     // [Appearance("fVendortaxjur", Enabled = true)]
     // [Appearance("fVendortaxjurVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(25)] 
     public  string taxjur
     { 
       get { return _taxjur; } 
       set { SetPropertyValue(nameof(taxjur), ref _taxjur, value); } 
     } 
     // Tax information
     // Notes for fVendor : 
     private string _taxnum; 
     [XafDisplayName("Tax Number"), ToolTip("Tax Number")] 
     // [Appearance("fVendortaxnum", Enabled = true)]
     // [Appearance("fVendortaxnumVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(25)] 
     public  string taxnum
     { 
       get { return _taxnum; } 
       set { SetPropertyValue(nameof(taxnum), ref _taxnum, value); } 
     } 
     // Tax information
     // Notes for fVendor : 
     private string _taxnum1; 
     [XafDisplayName("Tax Number 1"), ToolTip("Tax Number 1")] 
     // [Appearance("fVendortaxnum1", Enabled = true)]
     // [Appearance("fVendortaxnum1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(25)] 
     public  string taxnum1
     { 
       get { return _taxnum1; } 
       set { SetPropertyValue(nameof(taxnum1), ref _taxnum1, value); } 
     } 
     // Tax information
     // Notes for fVendor : 
     private string _taxnum2; 
     [XafDisplayName("Tax Number 2"), ToolTip("Tax Number 2")] 
     // [Appearance("fVendortaxnum2", Enabled = true)]
     // [Appearance("fVendortaxnum2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string taxnum2
     { 
       get { return _taxnum2; } 
       set { SetPropertyValue(nameof(taxnum2), ref _taxnum2, value); } 
     } 
     // Tax information
     // Notes for fVendor : 
     private string _taxoffice; 
     [XafDisplayName("Tax Office"), ToolTip("Tax office")] 
     // [Appearance("fVendortaxoffice", Enabled = true)]
     // [Appearance("fVendortaxofficeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string taxoffice
     { 
       get { return _taxoffice; } 
       set { SetPropertyValue(nameof(taxoffice), ref _taxoffice, value); } 
     } 
     // Tax information
     // Notes for fVendor : 
     private string _vatreg; 
     [XafDisplayName("VAT Reg. No"), ToolTip("VAT reg.no")] 
     // [Appearance("fVendorvatreg", Enabled = true)]
     // [Appearance("fVendorvatregVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string vatreg
     { 
       get { return _vatreg; } 
       set { SetPropertyValue(nameof(vatreg), ref _vatreg, value); } 
     } 
     // Withholding tax
     // Notes for fVendor : 
     private string _exeptnumb; 
     [XafDisplayName("Exemption Number"), ToolTip("Exemption number")] 
     // [Appearance("fVendorexeptnumb", Enabled = true)]
     // [Appearance("fVendorexeptnumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string exeptnumb
     { 
       get { return _exeptnumb; } 
       set { SetPropertyValue(nameof(exeptnumb), ref _exeptnumb, value); } 
     } 
     // Withholding tax
     // Notes for fVendor : 
     private string _exmptauthor; 
     [XafDisplayName("Exmpt. Authority"), ToolTip("Exmpt. Authority")] 
     // [Appearance("fVendorexmptauthor", Enabled = true)]
     // [Appearance("fVendorexmptauthorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string exmptauthor
     { 
       get { return _exmptauthor; } 
       set { SetPropertyValue(nameof(exmptauthor), ref _exmptauthor, value); } 
     } 
     // Withholding tax
     // Notes for fVendor : 
     private string _recipienttype; 
     [XafDisplayName("Recipient Type"), ToolTip("Recipient type")] 
     // [Appearance("fVendorrecipienttype", Enabled = true)]
     // [Appearance("fVendorrecipienttypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string recipienttype
     { 
       get { return _recipienttype; } 
       set { SetPropertyValue(nameof(recipienttype), ref _recipienttype, value); } 
     } 
     // Withholding tax
     // Notes for fVendor : 
     private string _validuntil; 
     [XafDisplayName("Valid Until"), ToolTip("Valid until")] 
     // [Appearance("fVendorvaliduntil", Enabled = true)]
     // [Appearance("fVendorvaliduntilVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string validuntil
     { 
       get { return _validuntil; } 
       set { SetPropertyValue(nameof(validuntil), ref _validuntil, value); } 
     } 
     // Withholding tax
     // Notes for fVendor : 
     private string _whtaxcountry; 
     [XafDisplayName("WH Tax Country"), ToolTip("WH Tax Country")] 
     // [Appearance("fVendorwhtaxcountry", Enabled = true)]
     // [Appearance("fVendorwhtaxcountryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string whtaxcountry
     { 
       get { return _whtaxcountry; } 
       set { SetPropertyValue(nameof(whtaxcountry), ref _whtaxcountry, value); } 
     } 
     // Withholding tax
     // Notes for fVendor : 
     private string _wtaxcode; 
     [XafDisplayName("W. Tax Code"), ToolTip("W. Tax Code")] 
     // [Appearance("fVendorwtaxcode", Enabled = true)]
     // [Appearance("fVendorwtaxcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string wtaxcode
     { 
       get { return _wtaxcode; } 
       set { SetPropertyValue(nameof(wtaxcode), ref _wtaxcode, value); } 
     } 
     // 
     //// Notes for fVendor : 
     //private fAcctsGroup _accgroup; 
     //[XafDisplayName("Account Group"), ToolTip("Account Group")] 
     //// [Appearance("fVendoraccgroup", Enabled = true)]
     //// [Appearance("fVendoraccgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     //// [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     //// [RuleRequiredField(DefaultContexts.Save)] 
     //// [IsSearch(true)]
     //public  fAcctsGroup accgroup
     //{ 
     //  get { return _accgroup; } 
     //  set { SetPropertyValue(nameof(accgroup), ref _accgroup, value); } 
     //} 
     //// 
     //// Notes for fVendor : 
     //private fCompany _compcode; 
     //[XafDisplayName("Company Code"), ToolTip("Company Code")] 
     //// [Appearance("fVendorcompcode", Enabled = true)]
     //// [Appearance("fVendorcompcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     //// [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     //// [RuleRequiredField(DefaultContexts.Save)] 
     //// [IsSearch(true)]
     //public  fCompany compcode
     //{ 
     //  get { return _compcode; } 
     //  set { SetPropertyValue(nameof(compcode), ref _compcode, value); } 
     //} 
     // 
     // Notes for fVendor : 
     private string _vendor; 
     [XafDisplayName("Vendor"), ToolTip("Vendor")] 
     // [Appearance("fVendorvendor", Enabled = true)]
     // [Appearance("fVendorvendorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string vendor
     { 
       get { return _vendor; } 
       set { SetPropertyValue(nameof(vendor), ref _vendor, value); } 
     } 
   } 
} 
