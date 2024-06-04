// Class Name : CattleMortality.cs 
// Project Name : Farm 
// Last Update : 06/04/2024 15:55:19  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/04/2024 15:55:18 
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
   [System.ComponentModel.DisplayName("CattleMortality")]
   // [RuleCombinationOfPropertiesIsUnique("KeyRuleCattleMortality", DefaultContexts.Save, "division, txndate")] 
   public class CattleMortality : XPObject
   {
     public CattleMortality(Session session) : base(session) 
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
     [Appearance("VisibleCattleMortalityOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for CattleMortality : 
     private Cattle _cattletag; 
     [XafDisplayName("Cattle Tag"), ToolTip("Cattle Tag")] 
     // [Appearance("CattleMortalitycattletag", Enabled = true)]
     // [Appearance("CattleMortalitycattletagVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  Cattle cattletag
     { 
       get { return _cattletag; } 
        set { bool modified =SetPropertyValue(nameof(cattletag), ref _cattletag, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattleMortality : 
     private string _causeofdeath; 
     [XafDisplayName("Cause of Death"), ToolTip("Cause of Death")] 
     // [Appearance("CattleMortalitycauseofdeath", Enabled = true)]
     // [Appearance("CattleMortalitycauseofdeathVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(150)] 
     public  string causeofdeath
     { 
       get { return _causeofdeath; } 
        set { bool modified =SetPropertyValue(nameof(causeofdeath), ref _causeofdeath, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattleMortality : 
     private DateTime _deathdate; 
     [XafDisplayName("Death Date"), ToolTip("Death Date")] 
     // [Appearance("CattleMortalitydeathdate", Enabled = true)]
     // [Appearance("CattleMortalitydeathdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime deathdate
     { 
       get { return _deathdate; } 
        set { bool modified =SetPropertyValue(nameof(deathdate), ref _deathdate, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // Symptoms
     // Notes for CattleMortality : 
     private bool _paddling; 
     [XafDisplayName("Paddling"), ToolTip("Paddling")] 
     // [Appearance("CattleMortalitypaddling", Enabled = true)]
     // [Appearance("CattleMortalitypaddlingVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool paddling
     { 
       get { return _paddling; } 
        set { bool modified =SetPropertyValue(nameof(paddling), ref _paddling, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // Symptoms
     // Notes for CattleMortality : 
     private bool _suddendeath; 
     [XafDisplayName("Sudden Death"), ToolTip("Sudden Death")] 
     // [Appearance("CattleMortalitysuddendeath", Enabled = true)]
     // [Appearance("CattleMortalitysuddendeathVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool suddendeath
     { 
       get { return _suddendeath; } 
        set { bool modified =SetPropertyValue(nameof(suddendeath), ref _suddendeath, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // Symptoms
     // Notes for CattleMortality : 
     private bool _fever; 
     [XafDisplayName("Fever"), ToolTip("Fever")] 
     // [Appearance("CattleMortalityfever", Enabled = true)]
     // [Appearance("CattleMortalityfeverVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool fever
     { 
       get { return _fever; } 
        set { bool modified =SetPropertyValue(nameof(fever), ref _fever, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // Symptoms
     // Notes for CattleMortality : 
     private bool _tremorsorsesizures; 
     [XafDisplayName("Tremors Or Sesizures"), ToolTip("Tremors Or Sesizures")] 
     // [Appearance("CattleMortalitytremorsorsesizures", Enabled = true)]
     // [Appearance("CattleMortalitytremorsorsesizuresVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool tremorsorsesizures
     { 
       get { return _tremorsorsesizures; } 
        set { bool modified =SetPropertyValue(nameof(tremorsorsesizures), ref _tremorsorsesizures, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // Symptoms
     // Notes for CattleMortality : 
     private bool _uncoordinatedorweekness; 
     [XafDisplayName("Uncoordinated Or Weekness"), ToolTip("Uncoordinated Or Weekness")] 
     // [Appearance("CattleMortalityuncoordinatedorweekness", Enabled = true)]
     // [Appearance("CattleMortalityuncoordinatedorweeknessVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool uncoordinatedorweekness
     { 
       get { return _uncoordinatedorweekness; } 
        set { bool modified =SetPropertyValue(nameof(uncoordinatedorweekness), ref _uncoordinatedorweekness, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // Symptoms
     // Notes for CattleMortality : 
     private string _comments; 
     [XafDisplayName("Comments"), ToolTip("Comments")] 
     // [Appearance("CattleMortalitycomments", Enabled = true)]
     // [Appearance("CattleMortalitycommentsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(SizeAttribute.Unlimited)] 
     public  string comments
     { 
       get { return _comments; } 
        set { bool modified =SetPropertyValue(nameof(comments), ref _comments, value);  
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
   [Appearance("CattleMortalityUpdatebyAppearance", Enabled = false)]
   public ApplicationUser Updateby 
   { 
   get { return _Updateby; } 
   set { SetPropertyValue("Updateby", ref _Updateby, value); } 
   } 
   private DateTime _Updatedate; 
   [XafDisplayName("Update date"), ToolTip("Update date")] 
   [Appearance("CattleMortalityUpdatedateAppearance", Enabled = false)]
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
