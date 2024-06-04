// Class Name : CattlePin.cs 
// Project Name : Farm 
// Last Update : 06/04/2024 15:57:20  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/04/2024 15:57:20 
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
   [System.ComponentModel.DisplayName("CattlePin")]
   // [RuleCombinationOfPropertiesIsUnique("KeyRuleCattlePin", DefaultContexts.Save, "division, txndate")] 
   public class CattlePin : XPObject
   {
     public CattlePin(Session session) : base(session) 
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
     [Appearance("VisibleCattlePinOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for CattlePin : 
     private CattleType _cattletype; 
     [XafDisplayName("CattleType"), ToolTip("CattleType")] 
     // [Appearance("CattlePincattletype", Enabled = true)]
     // [Appearance("CattlePincattletypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  CattleType cattletype
     { 
       get { return _cattletype; } 
        set { bool modified =SetPropertyValue(nameof(cattletype), ref _cattletype, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattlePin : 
     private string _name; 
     [XafDisplayName("Name"), ToolTip("Name")] 
     // [Appearance("CattlePinname", Enabled = true)]
     // [Appearance("CattlePinnameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
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
     // Notes for CattlePin : 
     private string _description; 
     [XafDisplayName("Description"), ToolTip("Description")] 
     // [Appearance("CattlePindescription", Enabled = true)]
     // [Appearance("CattlePindescriptionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(150)] 
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
     // Notes for CattlePin : 
     private string _size; 
     [XafDisplayName("Size"), ToolTip("Size")] 
     // [Appearance("CattlePinsize", Enabled = true)]
     // [Appearance("CattlePinsizeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string size
     { 
       get { return _size; } 
        set { bool modified =SetPropertyValue(nameof(size), ref _size, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattlePin : 
     private int _maximumcattles; 
     [XafDisplayName("Maximum Cattles"), ToolTip("Maximum Cattles")] 
     // [Appearance("CattlePinmaximumcattles", Enabled = true)]
     // [Appearance("CattlePinmaximumcattlesVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  int maximumcattles
     { 
       get { return _maximumcattles; } 
        set { bool modified =SetPropertyValue(nameof(maximumcattles), ref _maximumcattles, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattlePin : 
     private CattlePlant _cattleplant; 
     [XafDisplayName("CattlePlant"), ToolTip("CattlePlant")] 
     // [Appearance("CattlePincattleplant", Enabled = true)]
     // [Appearance("CattlePincattleplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("aplantpin")] 
     // [DevExpress.Xpo.Aggregated]
     public  CattlePlant cattleplant
     { 
       get { return _cattleplant; } 
        set { bool modified =SetPropertyValue(nameof(cattleplant), ref _cattleplant, value);  
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
   [Appearance("CattlePinUpdatebyAppearance", Enabled = false)]
   public ApplicationUser Updateby 
   { 
   get { return _Updateby; } 
   set { SetPropertyValue("Updateby", ref _Updateby, value); } 
   } 
   private DateTime _Updatedate; 
   [XafDisplayName("Update date"), ToolTip("Update date")] 
   [Appearance("CattlePinUpdatedateAppearance", Enabled = false)]
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
