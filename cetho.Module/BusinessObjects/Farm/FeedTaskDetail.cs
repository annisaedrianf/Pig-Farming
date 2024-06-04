// Class Name : FeedTaskDetail.cs 
// Project Name : FARM 
// Last Update : 07/04/2024 14:55:34  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 07/04/2024 14:55:34 
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
using DevExpress.Persistent.BaseImpl;

namespace cetho.Module.BusinessObjects 
{ 
   [DefaultClassOptions] 
   [ImageName("ModelEditor_Views")] 
   [DefaultProperty("name")]
   [NavigationItem("")]
   // Standard Document
   [System.ComponentModel.DisplayName("Feed Task Detail")]
   // [RuleCombinationOfPropertiesIsUnique("KeyRuleFeedTaskDetail", DefaultContexts.Save, "division, txndate")] 
   public class FeedTaskDetail : XPObject
   {
     public FeedTaskDetail(Session session) : base(session) 
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
         Updateby = GetCurrentUser();  
       //string tUser = SecuritySystem.CurrentUserName.ToString();
       //LastUpdateUser = Session.FindObject<GPUser>(new BinaryOperator("UserName", SecuritySystem.CurrentUserName.ToString())); 
       // LastUpdateUser = Session.FindObject<GPUser>(new BinaryOperator("UserName", tUser)); 
        UpdateByTime(); 
     } 
     ApplicationUser GetCurrentUser() 
     { 
         return Session.FindObject<ApplicationUser>(CriteriaOperator.Parse("Oid =CurrentUserId()")); 
     } 
     protected override void OnChanged(string propertyName, object oldValue, object newValue)
     {
       base.OnChanged(propertyName, oldValue, newValue);
       if(!IsLoading) { 
       //   switch(propertyName) {
       //     case nameof(Email):
       //        UpdateContacts();
       //        break;
       //   }
       }
     } 
     protected override void OnSaving()
     {
        base.OnSaving();
         UpdateByTime(); 
         Updateby = GetCurrentUser(); 
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
     [NonPersistent]  
     public UserLoginInfo userlogin;  
     [Appearance("VisibleFeedTaskDetailOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for FeedTaskDetail : 
     private FeedSchedule _feedschedule; 
     [XafDisplayName("Feed Schedule"), ToolTip("Feed Schedule")] 
     // [Appearance("FeedTaskDetailfeedschedule", Enabled = true)]
     // [Appearance("FeedTaskDetailfeedscheduleVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("afeedschedule")] 
     // [DevExpress.Xpo.Aggregated]
     public  FeedSchedule feedschedule
     { 
       get { return _feedschedule; } 
        set { bool modified =SetPropertyValue(nameof(feedschedule), ref _feedschedule, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for FeedTaskDetail : 
     private DateTime _date; 
     [XafDisplayName("Date"), ToolTip("Date")] 
     // [Appearance("FeedTaskDetaildate", Enabled = true)]
     // [Appearance("FeedTaskDetaildateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime date
     { 
       get { return _date; } 
        set { bool modified =SetPropertyValue(nameof(date), ref _date, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for FeedTaskDetail : 
     private int _seqno; 
     [XafDisplayName("Seq No"), ToolTip("Seq No")] 
     // [Appearance("FeedTaskDetailseqno", Enabled = true)]
     // [Appearance("FeedTaskDetailseqnoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  int seqno
     { 
       get { return _seqno; } 
        set { bool modified =SetPropertyValue(nameof(seqno), ref _seqno, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for FeedTaskDetail : 
     private CattlePin _cattlepin; 
     [XafDisplayName("CattlePin"), ToolTip("CattlePin")] 
     // [Appearance("FeedTaskDetailcattlepin", Enabled = true)]
     // [Appearance("FeedTaskDetailcattlepinVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  CattlePin cattlepin
     { 
       get { return _cattlepin; } 
        set { bool modified =SetPropertyValue(nameof(cattlepin), ref _cattlepin, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for FeedTaskDetail : 
     private double _kg; 
     [XafDisplayName("Kg"), ToolTip("Kg")] 
     // [Appearance("FeedTaskDetailkg", Enabled = true)]
     // [Appearance("FeedTaskDetailkgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double kg
     { 
       get { return _kg; } 
        set { bool modified =SetPropertyValue(nameof(kg), ref _kg, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for FeedTaskDetail : 
     private eEnumComplated _status; 
     [XafDisplayName("Status"), ToolTip("Status")] 
     // [Appearance("FeedTaskDetailstatus", Enabled = true)]
     // [Appearance("FeedTaskDetailstatusVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  eEnumComplated status
     { 
       get { return _status; } 
        set { bool modified =SetPropertyValue(nameof(status), ref _status, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for FeedTaskDetail : 
     [XafDisplayName("Feed Cattles"), ToolTip("Feed Cattles")] 
     // [Appearance("FeedTaskDetailfeedcattles", Enabled = true)]
     // [Appearance("FeedTaskDetailfeedcattlesVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("afeedcattleconsums")] 
     // [DevExpress.Xpo.Aggregated]
     public XPCollection<CattleFeedConsumption> feedcattles
     {
     get
       {
         return GetCollection<CattleFeedConsumption>("feedcattles"); 
       }
     }
   
   private void UpdateByTime() 
   { 
   string tUser = SecuritySystem.CurrentUserName.ToString(); 
   Updateby = Session.FindObject<ApplicationUser>(new BinaryOperator("UserName", tUser)); 
   Updatedate = DateTime.Now; 
   } 
   private ApplicationUser _Updateby; 
   [XafDisplayName("Update by"), ToolTip("Update by")] 
   [Appearance("FeedTaskDetailUpdatebyAppearance", Enabled = false)]
   public ApplicationUser Updateby 
   { 
   get { return _Updateby; } 
   set { SetPropertyValue("Updateby", ref _Updateby, value); } 
   } 
   private DateTime _Updatedate; 
   [XafDisplayName("Update date"), ToolTip("Update date")] 
   [Appearance("FeedTaskDetailUpdatedateAppearance", Enabled = false)]
   public DateTime Updatedate 
   { 
   get 
   { 
    
   return _Updatedate; 
   } 
   set { SetPropertyValue("Updatedate", ref _Updatedate, value); } 
   } 
   } 
} 
