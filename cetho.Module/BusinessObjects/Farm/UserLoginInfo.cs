// Class Name : cUser.cs 
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
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.CodeParser;
using DevExpress.Persistent.BaseImpl;

namespace cetho.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("ModelEditor_Views")]
    [DefaultProperty("Name")]
    //[NavigationItem("Master")]
    // Standard Document
    [System.ComponentModel.DisplayName("User Login")]
    [CurrentUserDisplayImage(nameof(Photo))]
    public class UserLoginInfo : ApplicationUser
    {
        //public cUser() : base()
        //{
        //    // This constructor is used when an object is loaded from a persistent storage.
        //    // Do not place any code here.
        //}
        public UserLoginInfo(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
            
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
            //SecuritySystem.CurrentUserName
            //LastUpdatedUser = Session.GetObjectByKey<GPUser>(SecuritySystem.CurrentUserId);
            string tUser = SecuritySystem.CurrentUserName.ToString();
            //DiscountApproval = false;
            //LastUpdatedUser = Session.FindObject<GPUser>(new BinaryOperator("UserName", SecuritySystem.CurrentUserName.ToString()));
            // LastUpdatedUser = Session.FindObject<GPUser>(new BinaryOperator("UserName", tUser));
            // LastUpdate = DateTime.Now;
        }
        protected override void OnSaving()
        {
            base.OnSaving();
        }
        protected override void OnDeleting()
        {
            base.OnDeleting();
        }
        //
        private MediaDataObject photo;
        public MediaDataObject Photo
        {
            get { return photo; }
            set { SetPropertyValue(nameof(Photo), ref photo, value); }
        }

        private string _Name;
        [XafDisplayName("Name"), ToolTip("Full Name")]
        [Size(50)]
        public  string Name
        {
            get { return _Name; }
            set { SetPropertyValue("Name", ref _Name, value); }
        }
        private string _TelegramID;
        [XafDisplayName("Telegram ID"), ToolTip("Telegram ID")]
        [Size(100)]
        public  string TelegramID
        {
            get { return _TelegramID; }
            set { SetPropertyValue("TelegramID", ref _TelegramID, value); }
        }

        private string _PhoneNumber;
        [XafDisplayName("Phone Number"), ToolTip("Phone Number")]
        [Size(100)]
        public  string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { SetPropertyValue("PhoneNumber", ref _PhoneNumber, value); }
        }
        private string _EmailAddress;
        [XafDisplayName("Email Address"), ToolTip("Email Address")]
        [Size(100)]
        public  string EmailAddress
        {
            get { return _EmailAddress; }
            set { SetPropertyValue("EmailAddress", ref _EmailAddress, value); }
        }
        //private GSOUnit _OUAccess;
        //[RuleRequiredField(DefaultContexts.Save)]
        //[XafDisplayName("OUAccess"), ToolTip("OUAccess")]
        //[Association("OUUserLoginAccess")]
        //public XPCollection<OperatingUnitInfo> OUAccess
        //{
        //    get
        //    {
        //        return GetCollection<OperatingUnitInfo>("OUAccess");
        //    }
        //}

        //private SyncEmailGroup _EmailGroup;
        //[Association("EmailUserLogin")]
        ////public SyncEmailGroup EmailGroup
        ////{
        ////    get { return _EmailGroup; }
        ////    set { SetPropertyValue("EmailGroup", ref _EmailGroup, value); }
        ////}
        //public XPCollection<SyncEmailGroup> EmailGroup
        //{
        //    get
        //    {
        //        return GetCollection<SyncEmailGroup>("EmailGroup");
        //    }
        //}


        //private bool _DiscountApproval;
        //[XafDisplayName("Discount Approval"), ToolTip("Discount Approval")]
        ////[Size(100)]
        //public  bool DiscountApproval
        //{
        //    get { return _DiscountApproval; }
        //    set { SetPropertyValue("DiscountApproval", ref _DiscountApproval, value); }
        //}


        //private fAppResponse _AppResponse;
        //[XafDisplayName("AppResponse"), ToolTip("AppResponse")]
        //[Association("UserResponse")]
        //public XPCollection<fAppResponse> AppResponse
        //{
        //    get
        //    {
        //        return GetCollection<fAppResponse>("AppResponse");
        //    }
        //}

    }
    public enum eDiscountApproval
    {
        [XafDisplayName("None")]
        None = 0,
        [XafDisplayName("Submit")]
        Submit = 1,
        [XafDisplayName("Checker")]
        Checker = 2,
        [XafDisplayName("Approval")]
        Approval = 3
    }
    public enum eIdxcUser
    {
        [XafDisplayName("ID")]
        ID = 0,
        [XafDisplayName("Name")]
        Name = 1,
        [XafDisplayName("Last Update")]
        LastUpdate = 2
    }
}

