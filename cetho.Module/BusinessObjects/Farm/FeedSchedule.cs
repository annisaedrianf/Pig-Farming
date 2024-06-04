// Class Name : FeedSchedule.cs 
// Project Name : Farm 
// Last Update : 06/04/2024 15:52:56  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/04/2024 15:52:56 
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
   [System.ComponentModel.DisplayName("Feed Schedule")]
   // [RuleCombinationOfPropertiesIsUnique("KeyRuleFeedSchedule", DefaultContexts.Save, "division, txndate")] 
   public class FeedSchedule : XPObject
   {
     public FeedSchedule(Session session) : base(session) 
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
     [Appearance("VisibleFeedScheduleOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for FeedSchedule : 
     private String _feedname; 
     [XafDisplayName("Feed Name"), ToolTip("Feed Name")] 
     // [Appearance("FeedSchedulefeedname", Enabled = true)]
     // [Appearance("FeedSchedulefeednameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  String feedname
     { 
       get { return _feedname; } 
        set { bool modified =SetPropertyValue(nameof(feedname), ref _feedname, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for FeedSchedule : 
     private eENumDayType _daytype; 
     [XafDisplayName("Day Type"), ToolTip("Day Type")] 
     // [Appearance("FeedScheduledaytype", Enabled = true)]
     // [Appearance("FeedScheduledaytypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  eENumDayType daytype
     { 
       get { return _daytype; } 
        set { bool modified =SetPropertyValue(nameof(daytype), ref _daytype, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for FeedSchedule : 
     private DateTime _startdate; 
     [XafDisplayName("Start Date"), ToolTip("Start Date")] 
     // [Appearance("FeedSchedulestartdate", Enabled = true)]
     // [Appearance("FeedSchedulestartdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime startdate
     { 
       get { return _startdate; } 
        set { bool modified =SetPropertyValue(nameof(startdate), ref _startdate, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for FeedSchedule : 
     private DateTime _enddate; 
     [XafDisplayName("End Date"), ToolTip("End Date")] 
     // [Appearance("FeedScheduleenddate", Enabled = true)]
     // [Appearance("FeedScheduleenddateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime enddate
     { 
       get { return _enddate; } 
        set { bool modified =SetPropertyValue(nameof(enddate), ref _enddate, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for FeedSchedule : 
     private double _qtyperpig; 
     [XafDisplayName("Qty Per Pig"), ToolTip("Qty Per Pig")] 
     // [Appearance("FeedScheduleqtyperpig", Enabled = true)]
     // [Appearance("FeedScheduleqtyperpigVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double qtyperpig
     { 
       get { return _qtyperpig; } 
        set { bool modified =SetPropertyValue(nameof(qtyperpig), ref _qtyperpig, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for FeedSchedule : 
     private CattleScheduleTime _howmanytimes; 
     [XafDisplayName("How Many Times"), ToolTip("How Many Times")] 
     // [Appearance("FeedSchedulehowmanytimes", Enabled = true)]
     // [Appearance("FeedSchedulehowmanytimesVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  CattleScheduleTime howmanytimes
     { 
       get { return _howmanytimes; } 
        set { bool modified =SetPropertyValue(nameof(howmanytimes), ref _howmanytimes, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for FeedSchedule : 
     private DateTime _firstfeedingtimeoftheday; 
     [XafDisplayName("First Feeding time of the Day"), ToolTip("First Feeding time of the Day")] 
     // [Appearance("FeedSchedulefirstfeedingtimeoftheday", Enabled = true)]
     // [Appearance("FeedSchedulefirstfeedingtimeofthedayVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime firstfeedingtimeoftheday
     { 
       get { return _firstfeedingtimeoftheday; } 
        set { bool modified =SetPropertyValue(nameof(firstfeedingtimeoftheday), ref _firstfeedingtimeoftheday, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for FeedSchedule : 
     private CattlePin _cattlepen; 
     [XafDisplayName("Cattle Pen"), ToolTip("Cattle Pen")] 
     // [Appearance("FeedSchedulecattlepen", Enabled = true)]
     // [Appearance("FeedSchedulecattlepenVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  CattlePin cattlepen
     { 
       get { return _cattlepen; } 
        set { bool modified =SetPropertyValue(nameof(cattlepen), ref _cattlepen, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for FeedSchedule : 
     private double _totalfeedforcattles; 
     [XafDisplayName("Total Feed for Cattles"), ToolTip("Total Feed for Cattles")] 
     // [Appearance("FeedScheduletotalfeedforcattles", Enabled = true)]
     // [Appearance("FeedScheduletotalfeedforcattlesVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double totalfeedforcattles
     { 
       get { return _totalfeedforcattles; } 
        set { bool modified =SetPropertyValue(nameof(totalfeedforcattles), ref _totalfeedforcattles, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for FeedSchedule : 
     [XafDisplayName("Feed Task Detail"), ToolTip("Feed Task Detail")] 
     // [Appearance("FeedSchedulefeedtaskdetail", Enabled = true)]
     // [Appearance("FeedSchedulefeedtaskdetailVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("afeedschedule")] 
     // [DevExpress.Xpo.Aggregated]
     public XPCollection<FeedTaskDetail> feedtaskdetail
     {
     get
       {
         return GetCollection<FeedTaskDetail>("feedtaskdetail"); 
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
   [Appearance("FeedScheduleUpdatebyAppearance", Enabled = false)]
   public ApplicationUser Updateby 
   { 
   get { return _Updateby; } 
   set { SetPropertyValue("Updateby", ref _Updateby, value); } 
   } 
   private DateTime _Updatedate; 
   [XafDisplayName("Update date"), ToolTip("Update date")] 
   [Appearance("FeedScheduleUpdatedateAppearance", Enabled = false)]
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
