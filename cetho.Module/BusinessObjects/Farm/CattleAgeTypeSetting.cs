// Class Name : CattleAgeTypeSetting.cs 
// Project Name : Farm 
// Last Update : 06/04/2024 15:55:36  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/04/2024 15:55:36 
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
   [System.ComponentModel.DisplayName("CattleAgeTypeSetting")]
   // [RuleCombinationOfPropertiesIsUnique("KeyRuleCattleAgeTypeSetting", DefaultContexts.Save, "division, txndate")] 
   public class CattleAgeTypeSetting : XPObject
   {
     public CattleAgeTypeSetting(Session session) : base(session) 
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
     [Appearance("VisibleCattleAgeTypeSettingOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for CattleAgeTypeSetting : 
     private CattleType _cattletype; 
     [XafDisplayName("Cattle Type"), ToolTip("Cattle Type")] 
     // [Appearance("CattleAgeTypeSettingcattletype", Enabled = true)]
     // [Appearance("CattleAgeTypeSettingcattletypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for CattleAgeTypeSetting : 
     private int _startweaner; 
     [XafDisplayName("Start Weaner"), ToolTip("Start Weaner")] 
     // [Appearance("CattleAgeTypeSettingstartweaner", Enabled = true)]
     // [Appearance("CattleAgeTypeSettingstartweanerVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  int startweaner
     { 
       get { return _startweaner; } 
        set { bool modified =SetPropertyValue(nameof(startweaner), ref _startweaner, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattleAgeTypeSetting : 
     private int _endweaner; 
     [XafDisplayName("End Weaner"), ToolTip("End Weaner")] 
     // [Appearance("CattleAgeTypeSettingendweaner", Enabled = true)]
     // [Appearance("CattleAgeTypeSettingendweanerVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  int endweaner
     { 
       get { return _endweaner; } 
        set { bool modified =SetPropertyValue(nameof(endweaner), ref _endweaner, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattleAgeTypeSetting : 
     private int _startgrower; 
     [XafDisplayName("Start Grower"), ToolTip("Start Grower")] 
     // [Appearance("CattleAgeTypeSettingstartgrower", Enabled = true)]
     // [Appearance("CattleAgeTypeSettingstartgrowerVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  int startgrower
     { 
       get { return _startgrower; } 
        set { bool modified =SetPropertyValue(nameof(startgrower), ref _startgrower, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattleAgeTypeSetting : 
     private int _endgrower; 
     [XafDisplayName("End Grower"), ToolTip("End Grower")] 
     // [Appearance("CattleAgeTypeSettingendgrower", Enabled = true)]
     // [Appearance("CattleAgeTypeSettingendgrowerVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  int endgrower
     { 
       get { return _endgrower; } 
        set { bool modified =SetPropertyValue(nameof(endgrower), ref _endgrower, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattleAgeTypeSetting : 
     private int _startfinishergiltboar; 
     [XafDisplayName("Start Finisher/Gilt/Boar"), ToolTip("Start Finisher/Gilt/Boar")] 
     // [Appearance("CattleAgeTypeSettingstartfinishergiltboar", Enabled = true)]
     // [Appearance("CattleAgeTypeSettingstartfinishergiltboarVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  int startfinishergiltboar
     { 
       get { return _startfinishergiltboar; } 
        set { bool modified =SetPropertyValue(nameof(startfinishergiltboar), ref _startfinishergiltboar, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattleAgeTypeSetting : 
     private int _endfinishergiltboar; 
     [XafDisplayName("End Finisher/Gilt/Boar"), ToolTip("End Finisher/Gilt/Boar")] 
     // [Appearance("CattleAgeTypeSettingendfinishergiltboar", Enabled = true)]
     // [Appearance("CattleAgeTypeSettingendfinishergiltboarVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  int endfinishergiltboar
     { 
       get { return _endfinishergiltboar; } 
        set { bool modified =SetPropertyValue(nameof(endfinishergiltboar), ref _endfinishergiltboar, value);  
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
   [Appearance("CattleAgeTypeSettingUpdatebyAppearance", Enabled = false)]
   public ApplicationUser Updateby 
   { 
   get { return _Updateby; } 
   set { SetPropertyValue("Updateby", ref _Updateby, value); } 
   } 
   private DateTime _Updatedate; 
   [XafDisplayName("Update date"), ToolTip("Update date")] 
   [Appearance("CattleAgeTypeSettingUpdatedateAppearance", Enabled = false)]
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
