using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_TypeHesab
    {
        DL_TypeHesab TypeHesab = new DL_TypeHesab();
        #region Detail
        public OBJ_TypeHesab Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return TypeHesab.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_TypeHesab> Select(string FieldName, string FilterValue, int h)
        {
            return TypeHesab.Select(FieldName, FilterValue, h);
        }
        #endregion
    }
}