// Class Name : CattlePregnancy.cs 
// Project Name : Farm 
// Last Update : 06/04/2024 15:54:32  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/04/2024 15:54:32 
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
   [System.ComponentModel.DisplayName("CattlePregnancy")]
   // [RuleCombinationOfPropertiesIsUnique("KeyRuleCattlePregnancy", DefaultContexts.Save, "division, txndate")] 
   public class CattlePregnancy : XPObject
   {
     public CattlePregnancy(Session session) : base(session) 
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
     [Appearance("VisibleCattlePregnancyOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for CattlePregnancy : 
     private Cattle _sowgilt; 
     [XafDisplayName("Sow/Gilt"), ToolTip("Sow/Gilt")] 
     // [Appearance("CattlePregnancysowgilt", Enabled = true)]
     // [Appearance("CattlePregnancysowgiltVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("acattlepregnancy")] 
     // [DevExpress.Xpo.Aggregated]
     public  Cattle sowgilt
     { 
       get { return _sowgilt; } 
        set { bool modified =SetPropertyValue(nameof(sowgilt), ref _sowgilt, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattlePregnancy : 
     private DateTime _crossingdate; 
     [XafDisplayName("Crossing Date"), ToolTip("Crossing Date")] 
     // [Appearance("CattlePregnancycrossingdate", Enabled = true)]
     // [Appearance("CattlePregnancycrossingdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime crossingdate
     { 
       get { return _crossingdate; } 
        set { bool modified =SetPropertyValue(nameof(crossingdate), ref _crossingdate, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattlePregnancy : 
     private eNumTypeOfCrossing _typeofcrossing; 
     [XafDisplayName("Type Of Crossing"), ToolTip("Type Of Crossing")] 
     // [Appearance("CattlePregnancytypeofcrossing", Enabled = true)]
     // [Appearance("CattlePregnancytypeofcrossingVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  eNumTypeOfCrossing typeofcrossing
     { 
       get { return _typeofcrossing; } 
        set { bool modified =SetPropertyValue(nameof(typeofcrossing), ref _typeofcrossing, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattlePregnancy : 
     private CattleBreed _boarbreed; 
     [XafDisplayName("Boar Breed"), ToolTip("Boar Breed")] 
     // [Appearance("CattlePregnancyboarbreed", Enabled = true)]
     // [Appearance("CattlePregnancyboarbreedVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  CattleBreed boarbreed
     { 
       get { return _boarbreed; } 
        set { bool modified =SetPropertyValue(nameof(boarbreed), ref _boarbreed, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattlePregnancy : 
     private eNumYesNo _idboarfullbreed; 
     [XafDisplayName("Id Boar Full Breed"), ToolTip("Id Boar Full Breed")] 
     // [Appearance("CattlePregnancyidboarfullbreed", Enabled = true)]
     // [Appearance("CattlePregnancyidboarfullbreedVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public eNumYesNo idboarfullbreed
     { 
       get { return _idboarfullbreed; } 
        set { bool modified =SetPropertyValue(nameof(idboarfullbreed), ref _idboarfullbreed, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattlePregnancy : 
     private string _boartagnumber; 
     [XafDisplayName("Boar tag Number"), ToolTip("Boar tag Number")] 
     // [Appearance("CattlePregnancyboartagnumber", Enabled = true)]
     // [Appearance("CattlePregnancyboartagnumberVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string boartagnumber
     { 
       get { return _boartagnumber; } 
        set { bool modified =SetPropertyValue(nameof(boartagnumber), ref _boartagnumber, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattlePregnancy : 
     private string _boarname; 
     [XafDisplayName("Boar Name"), ToolTip("Boar Name")] 
     // [Appearance("CattlePregnancyboarname", Enabled = true)]
     // [Appearance("CattlePregnancyboarnameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(150)] 
     public  string boarname
     { 
       get { return _boarname; } 
        set { bool modified =SetPropertyValue(nameof(boarname), ref _boarname, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattlePregnancy : 
     private string _sementagnumber; 
     [XafDisplayName("Semen Tag Number"), ToolTip("Semen Tag Number")] 
     // [Appearance("CattlePregnancysementagnumber", Enabled = true)]
     // [Appearance("CattlePregnancysementagnumberVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string sementagnumber
     { 
       get { return _sementagnumber; } 
        set { bool modified =SetPropertyValue(nameof(sementagnumber), ref _sementagnumber, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for CattlePregnancy : 
     private string _notes; 
     [XafDisplayName("Notes"), ToolTip("Notes")] 
     // [Appearance("CattlePregnancynotes", Enabled = true)]
     // [Appearance("CattlePregnancynotesVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(SizeAttribute.Unlimited)] 
     public  string notes
     { 
       get { return _notes; } 
        set { bool modified =SetPropertyValue(nameof(notes), ref _notes, value);  
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
   [Appearance("CattlePregnancyUpdatebyAppearance", Enabled = false)]
   public ApplicationUser Updateby 
   { 
   get { return _Updateby; } 
   set { SetPropertyValue("Updateby", ref _Updateby, value); } 
   } 
   private DateTime _Updatedate; 
   [XafDisplayName("Update date"), ToolTip("Update date")] 
   [Appearance("CattlePregnancyUpdatedateAppearance", Enabled = false)]
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
