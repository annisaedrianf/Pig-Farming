using DevExpress.ExpressApp.DC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cetho.Module.BusinessObjects
{

    public enum eNumGender
    {

        [XafDisplayName("None")]
        None = 0,
        [XafDisplayName("Male")]
        Male = 1,
        [XafDisplayName("Female")]
        Female = 2
    }
    public enum eNumYesNo
    {

        [XafDisplayName("Yes")]
        Yes = 0,
        [XafDisplayName("No")]
        No = 1
    }
    public enum eNumTypeOfCrossing
    {

        [XafDisplayName("Yes")]
        Yes = 0,
        [XafDisplayName("No")]
        No = 1
    }
    public enum eENumDayType
    {

        [XafDisplayName("Yes")]
        Yes = 0,
        [XafDisplayName("No")]
        No = 1
    }

    public enum eEnumComplated
    {

        [XafDisplayName("Yes")]
        Yes = 0,
        [XafDisplayName("No")]
        No = 1
    }
}
