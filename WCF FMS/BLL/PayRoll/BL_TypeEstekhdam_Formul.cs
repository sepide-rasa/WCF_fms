using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;
using WCF_FMS.DAL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_TypeEstekhdam_Formul
    {
        DL_TypeEstekhdam_Formul TypeEstekhdam_Formul = new DL_TypeEstekhdam_Formul();
        #region Detail
        public OBJ_TypeEstekhdam_Formul Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه انواع استخدام ضروری است";
            }
            return TypeEstekhdam_Formul.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_TypeEstekhdam_Formul> Select(string FieldName, string FilterValue, int h)
        {
            return TypeEstekhdam_Formul.Select(FieldName, FilterValue, h);
        }
        #endregion
    }
}