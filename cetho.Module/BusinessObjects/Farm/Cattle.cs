// Class Name : Cattle.cs 
// Project Name : Farm 
// Last Update : 07/04/2024 15:05:32  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 07/04/2024 15:05:32 
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
   [System.ComponentModel.DisplayName("cattle ")]
   // [RuleCombinationOfPropertiesIsUnique("KeyRuleCattle", DefaultContexts.Save, "division, txndate")] 
   public class Cattle : XPObject
   {
     public Cattle(Session session) : base(session) 
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
     [Appearance("VisibleCattleOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for Cattle : 
     private CattleType _cattletype; 
     [XafDisplayName("Cattle Type"), ToolTip("Cattle Type")] 
     // [Appearance("Cattlecattletype", Enabled = true)]
     // [Appearance("CattlecattletypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
      [RuleRequiredField(DefaultContexts.Save)] 
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
     // Notes for Cattle : 
     [XafDisplayName("Cattle Group"), ToolTip("Cattle Group")] 
     // [Appearance("Cattlecattlegroup", Enabled = true)]
     // [Appearance("CattlecattlegroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("scattlegroup")] 
     // [DevExpress.Xpo.Aggregated]
     public XPCollection<CattleGroup> cattlegroup
     {
     get
       {
         return GetCollection<CattleGroup>("cattlegroup"); 
       }
     }
     // 
     // Notes for Cattle : 
     private string _tagnumber; 
     [XafDisplayName("Tag Number"), ToolTip("Tag Number")] 
     // [Appearance("Cattletagnumber", Enabled = true)]
     // [Appearance("CattletagnumberVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
      [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(150)] 
     public  string tagnumber
     { 
       get { return _tagnumber; } 
        set { bool modified =SetPropertyValue(nameof(tagnumber), ref _tagnumber, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for Cattle : 
     private string _name; 
     [XafDisplayName("Name"), ToolTip("Name")] 
     // [Appearance("Cattlename", Enabled = true)]
     // [Appearance("CattlenameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
      [RuleRequiredField(DefaultContexts.Save)] 
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
     // Notes for Cattle : 
     private eNumGender _gender; 
     [XafDisplayName("Gender"), ToolTip("Gender")] 
     // [Appearance("Cattlegender", Enabled = true)]
     // [Appearance("CattlegenderVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
      //[RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  eNumGender gender
     { 
       get { return _gender; } 
        set { bool modified =SetPropertyValue(nameof(gender), ref _gender, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for Cattle : 
     private eNumYesNo _isfullbreed; 
     [XafDisplayName("is Full Breed"), ToolTip("is Full Breed")] 
     // [Appearance("Cattleisfullbreed", Enabled = true)]
     // [Appearance("CattleisfullbreedVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  eNumYesNo isfullbreed
     { 
       get { return _isfullbreed; } 
        set { bool modified =SetPropertyValue(nameof(isfullbreed), ref _isfullbreed, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for Cattle : 
     private DateTime _dateofbirth; 
     [XafDisplayName("Date Of Birth"), ToolTip("Date Of Birth")] 
     // [Appearance("Cattledateofbirth", Enabled = true)]
     // [Appearance("CattledateofbirthVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime dateofbirth
     { 
       get { return _dateofbirth; } 
        set { bool modified =SetPropertyValue(nameof(dateofbirth), ref _dateofbirth, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for Cattle : 
     private string _litterno; 
     [XafDisplayName("Litter no."), ToolTip("Litter no.")] 
     // [Appearance("Cattlelitterno", Enabled = true)]
     // [Appearance("CattlelitternoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(12)] 
     public  string litterno
     { 
       get { return _litterno; } 
        set { bool modified =SetPropertyValue(nameof(litterno), ref _litterno, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for Cattle : 
     private CattleBreed _breed; 
     [XafDisplayName("Breed"), ToolTip("Breed")] 
     // [Appearance("Cattlebreed", Enabled = true)]
     // [Appearance("CattlebreedVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  CattleBreed breed
     { 
       get { return _breed; } 
        set { bool modified =SetPropertyValue(nameof(breed), ref _breed, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for Cattle : 
     private eNumYesNo _isbreedingstock; 
     [XafDisplayName("Is Breeding Stock"), ToolTip("Is Breeding Stock")] 
     // [Appearance("Cattleisbreedingstock", Enabled = true)]
     // [Appearance("CattleisbreedingstockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  eNumYesNo isbreedingstock
     { 
       get { return _isbreedingstock; } 
        set { bool modified =SetPropertyValue(nameof(isbreedingstock), ref _isbreedingstock, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for Cattle : 
     private CattlePin _cattlepen; 
     [XafDisplayName("Cattle Pen"), ToolTip("Cattle Pen")] 
     // [Appearance("Cattlecattlepen", Enabled = true)]
     // [Appearance("CattlecattlepenVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for Cattle : 
     private DateTime _comment; 
     [XafDisplayName("Comment"), ToolTip("Comment")] 
     // [Appearance("Cattlecomment", Enabled = true)]
     // [Appearance("CattlecommentVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime comment
     { 
       get { return _comment; } 
        set { bool modified =SetPropertyValue(nameof(comment), ref _comment, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for Cattle : 
     private Cattle _fathertagnumber; 
     [XafDisplayName("Father Tag Number"), ToolTip("Father Tag Number")] 
     // [Appearance("Cattlefathertagnumber", Enabled = true)]
     // [Appearance("CattlefathertagnumberVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  Cattle fathertagnumber
     { 
       get { return _fathertagnumber; } 
        set { bool modified =SetPropertyValue(nameof(fathertagnumber), ref _fathertagnumber, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for Cattle : 
     private Cattle _mothertagnumber; 
     [XafDisplayName("Mother Tag Number"), ToolTip("Mother Tag Number")] 
     // [Appearance("Cattlemothertagnumber", Enabled = true)]
     // [Appearance("CattlemothertagnumberVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  Cattle mothertagnumber
     { 
       get { return _mothertagnumber; } 
        set { bool modified =SetPropertyValue(nameof(mothertagnumber), ref _mothertagnumber, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for Cattle : 
     private double _weight; 
     [XafDisplayName("Weight"), ToolTip("Weight")] 
     // [Appearance("Cattleweight", Enabled = true)]
     // [Appearance("CattleweightVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double weight
     { 
       get { return _weight; } 
        set { bool modified =SetPropertyValue(nameof(weight), ref _weight, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for Cattle : 
     private double _height; 
     [XafDisplayName("Height"), ToolTip("Height")] 
     // [Appearance("Cattleheight", Enabled = true)]
     // [Appearance("CattleheightVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double height
     { 
       get { return _height; } 
        set { bool modified =SetPropertyValue(nameof(height), ref _height, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for Cattle : 
     private CattleColor _color; 
     [XafDisplayName("Color"), ToolTip("Color")] 
     // [Appearance("Cattlecolor", Enabled = true)]
     // [Appearance("CattlecolorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  CattleColor color
     { 
       get { return _color; } 
        set { bool modified =SetPropertyValue(nameof(color), ref _color, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for Cattle : 
     private DateTime _purchasedate; 
     [XafDisplayName("Purchase Date"), ToolTip("Purchase Date")] 
     // [Appearance("Cattlepurchasedate", Enabled = true)]
     // [Appearance("CattlepurchasedateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime purchasedate
     { 
       get { return _purchasedate; } 
        set { bool modified =SetPropertyValue(nameof(purchasedate), ref _purchasedate, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for Cattle : 
     private fVendor _purchasedfrom; 
     [XafDisplayName("Purchased From"), ToolTip("Purchased From")] 
     // [Appearance("Cattlepurchasedfrom", Enabled = true)]
     // [Appearance("CattlepurchasedfromVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor purchasedfrom
     { 
       get { return _purchasedfrom; } 
        set { bool modified =SetPropertyValue(nameof(purchasedfrom), ref _purchasedfrom, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for Cattle : 
     private DateTime _datedeliveredtofarm; 
     [XafDisplayName("Date Delivered to Farm"), ToolTip("Date Delivered to Farm")] 
     // [Appearance("Cattledatedeliveredtofarm", Enabled = true)]
     // [Appearance("CattledatedeliveredtofarmVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime datedeliveredtofarm
     { 
       get { return _datedeliveredtofarm; } 
        set { bool modified =SetPropertyValue(nameof(datedeliveredtofarm), ref _datedeliveredtofarm, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for Cattle : 
     private double _purchasedprice; 
     [XafDisplayName("Purchased Price"), ToolTip("Purchased Price")] 
     // [Appearance("Cattlepurchasedprice", Enabled = true)]
     // [Appearance("CattlepurchasedpriceVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double purchasedprice
     { 
       get { return _purchasedprice; } 
        set { bool modified =SetPropertyValue(nameof(purchasedprice), ref _purchasedprice, value);  
        if (!IsLoading && !IsSaving) 
        { 
             if (value != null) 
               { 
               } 
        }
             }
       } 
     // 
     // Notes for Cattle : 
     [XafDisplayName("Feeds"), ToolTip("Feeds")] 
     // [Appearance("Cattlefeeds", Enabled = true)]
     // [Appearance("CattlefeedsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("acattlefeedconsums")] 
     // [DevExpress.Xpo.Aggregated]
     public XPCollection<CattleFeedConsumption> feeds
     {
     get
       {
         return GetCollection<CattleFeedConsumption>("feeds"); 
       }
     }
     // 
     // Notes for Cattle : 
     [XafDisplayName("Pregnancy"), ToolTip("Pregnancy")] 
     // [Appearance("Cattlepregnancy", Enabled = true)]
     // [Appearance("CattlepregnancyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("acattlepregnancy")] 
     // [DevExpress.Xpo.Aggregated]
     public XPCollection<CattlePregnancy> pregnancy
     {
     get
       {
         return GetCollection<CattlePregnancy>("pregnancy"); 
       }
     }
     // 
     // Notes for Cattle : 
     [XafDisplayName("Vaccines"), ToolTip("Vaccines")] 
     // [Appearance("Cattlevaccines", Enabled = true)]
     // [Appearance("CattlevaccinesVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("acattlevaccineFor")] 
     // [DevExpress.Xpo.Aggregated]
     public XPCollection<CattleVaccineFor> vaccines
     {
     get
       {
         return GetCollection<CattleVaccineFor>("vaccines"); 
       }
     }
     // 
     // Notes for Cattle : 
     [XafDisplayName("Weighted"), ToolTip("Weighted")] 
     // [Appearance("Cattleweighted", Enabled = true)]
     // [Appearance("CattleweightedVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [Size(SizeAttribute.Unlimited)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("aCattleWeighted")] 
     // [DevExpress.Xpo.Aggregated]
     public XPCollection<CattleWeight> weighted
     {
     get
       {
         return GetCollection<CattleWeight>("weighted"); 
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
   [Appearance("CattleUpdatebyAppearance", Enabled = false)]
   public ApplicationUser Updateby 
   { 
   get { return _Updateby; } 
   set { SetPropertyValue("Updateby", ref _Updateby, value); } 
   } 
   private DateTime _Updatedate; 
   [XafDisplayName("Update date"), ToolTip("Update date")] 
   [Appearance("CattleUpdatedateAppearance", Enabled = false)]
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
