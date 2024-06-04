// Class Name : CattleScheduleTime.cs 
// Project Name : Farm 
// Last Update : 06/04/2024 15:53:18  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/04/2024 15:53:18 
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
   [System.ComponentModel.DisplayName("CattleScheduleTime")]
   // [RuleCombinationOfPropertiesIsUnique("KeyRuleCattleScheduleTime", DefaultContexts.Save, "division, txndate")] 
   public class CattleScheduleTime : XPObject
   {
     public CattleScheduleTime(Session session) : base(session) 
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
     [Appearance("VisibleCattleScheduleTimeOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for CattleScheduleTime : 
     private string _name; 
     [XafDisplayName("Name"), ToolTip("Name")] 
     // [Appearance("CattleScheduleTimename", Enabled = true)]
     // [Appearance("CattleScheduleTimenameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string name
     { 
       get { return _name; } 
        set { bool modified =SetPropertyValue(nameof(name), ref _name, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattleScheduleTime : 
     private string _description; 
     [XafDisplayName("Description"), ToolTip("Description")] 
     // [Appearance("CattleScheduleTimedescription", Enabled = true)]
     // [Appearance("CattleScheduleTimedescriptionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(SizeAttribute.Unlimited)] 
     public  string description
     { 
       get { return _description; } 
        set { bool modified =SetPropertyValue(nameof(description), ref _description, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattleScheduleTime : 
     private MeasureUnit _measureunit; 
     [XafDisplayName("Measure Unit"), ToolTip("Measure Unit")] 
     // [Appearance("CattleScheduleTimemeasureunit", Enabled = true)]
     // [Appearance("CattleScheduleTimemeasureunitVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  MeasureUnit measureunit
     { 
       get { return _measureunit; } 
        set { bool modified =SetPropertyValue(nameof(measureunit), ref _measureunit, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattleScheduleTime : 
     private double _times; 
     [XafDisplayName("Times"), ToolTip("Times")] 
     // [Appearance("CattleScheduleTimetimes", Enabled = true)]
     // [Appearance("CattleScheduleTimetimesVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double times
     { 
       get { return _times; } 
        set { bool modified =SetPropertyValue(nameof(times), ref _times, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
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
   [Appearance("CattleScheduleTimeUpdatebyAppearance", Enabled = false)]
   public ApplicationUser Updateby 
   { 
   get { return _Updateby; } 
   set { SetPropertyValue("Updateby", ref _Updateby, value); } 
   } 
   private DateTime _Updatedate; 
   [XafDisplayName("Update date"), ToolTip("Update date")] 
   [Appearance("CattleScheduleTimeUpdatedateAppearance", Enabled = false)]
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
