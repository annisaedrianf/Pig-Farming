// Class Name : CattleFeedConsumption.cs 
// Project Name : Farm 
// Last Update : 07/04/2024 14:55:53  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 07/04/2024 14:55:53 
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
   [System.ComponentModel.DisplayName("CattleFeedConsumption")]
   // [RuleCombinationOfPropertiesIsUnique("KeyRuleCattleFeedConsumption", DefaultContexts.Save, "division, txndate")] 
   public class CattleFeedConsumption : XPObject
   {
     public CattleFeedConsumption(Session session) : base(session) 
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
     [Appearance("VisibleCattleFeedConsumptionOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for CattleFeedConsumption : 
     private FeedTaskDetail _feedtaskdetail; 
     [XafDisplayName("FeedTaskDetail"), ToolTip("FeedTaskDetail")] 
     // [Appearance("CattleFeedConsumptionfeedtaskdetail", Enabled = true)]
     // [Appearance("CattleFeedConsumptionfeedtaskdetailVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("afeedcattleconsums")] 
     // [DevExpress.Xpo.Aggregated]
     public  FeedTaskDetail feedtaskdetail
     { 
       get { return _feedtaskdetail; } 
        set { bool modified =SetPropertyValue(nameof(feedtaskdetail), ref _feedtaskdetail, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattleFeedConsumption : 
     private DateTime _date; 
     [XafDisplayName("Date"), ToolTip("Date")] 
     // [Appearance("CattleFeedConsumptiondate", Enabled = true)]
     // [Appearance("CattleFeedConsumptiondateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for CattleFeedConsumption : 
     private int _seqno; 
     [XafDisplayName("Seq No"), ToolTip("Seq No")] 
     // [Appearance("CattleFeedConsumptionseqno", Enabled = true)]
     // [Appearance("CattleFeedConsumptionseqnoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for CattleFeedConsumption : 
     private Cattle _cattle; 
     [XafDisplayName("Cattle"), ToolTip("Cattle")] 
     // [Appearance("CattleFeedConsumptioncattle", Enabled = true)]
     // [Appearance("CattleFeedConsumptioncattleVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("acattlefeedconsums")] 
     // [DevExpress.Xpo.Aggregated]
     public  Cattle cattle
     { 
       get { return _cattle; } 
        set { bool modified =SetPropertyValue(nameof(cattle), ref _cattle, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattleFeedConsumption : 
     private double _kg; 
     [XafDisplayName("Kg"), ToolTip("Kg")] 
     // [Appearance("CattleFeedConsumptionkg", Enabled = true)]
     // [Appearance("CattleFeedConsumptionkgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
   
   private void UpdateByTime() 
   { 
   string tUser = SecuritySystem.CurrentUserName.ToString(); 
   Updateby = Session.FindObject<ApplicationUser>(new BinaryOperator("UserName", tUser)); 
   Updatedate = DateTime.Now; 
   } 
   private ApplicationUser _Updateby; 
   [XafDisplayName("Update by"), ToolTip("Update by")] 
   [Appearance("CattleFeedConsumptionUpdatebyAppearance", Enabled = false)]
   public ApplicationUser Updateby 
   { 
   get { return _Updateby; } 
   set { SetPropertyValue("Updateby", ref _Updateby, value); } 
   } 
   private DateTime _Updatedate; 
   [XafDisplayName("Update date"), ToolTip("Update date")] 
   [Appearance("CattleFeedConsumptionUpdatedateAppearance", Enabled = false)]
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
