using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Mohasebat_kosorat_MotalebatParam
    {
        DL_Mohasebat_kosorat_MotalebatParam Mohasebat_kosorat_MotalebatParam = new DL_Mohasebat_kosorat_MotalebatParam();
        #region Detail
        public OBJ_Mohasebat_kosorat_MotalebatParam Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return Mohasebat_kosorat_MotalebatParam.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_Mohasebat_kosorat_MotalebatParam> Select(string FieldName, string FilterValue, int h)
        {
            return Mohasebat_kosorat_MotalebatParam.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int MohasebatId, int? KosoratId, int? MotalebatId, int Mablagh, int OrganId, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }

            /*else if (MohasebatId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد محاسبات ضروری است";
            }
            else if (KosoratId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کسورات ضروری است";
            }*/
            else if (MohasebatId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد محاسبات ضروری است";
            }
            if (KosoratId == 0)
                KosoratId = null;
            if (MotalebatId == 0)
                MotalebatId = null;
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return Mohasebat_kosorat_MotalebatParam.Insert(MohasebatId, KosoratId, MotalebatId, Mablagh, UserId, Desc, OrganId);
        }
        #endregion
        #region Update
        public string Update(int Id, int MohasebatId, int? KosoratId, int? MotalebatId, int Mablagh, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }

           /* else if (MohasebatId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد محاسبات ضروری است";
            }
            else if (KosoratId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کسورات ضروری است";
            }*/
            else if (MotalebatId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد مطالبات ضروری است";
            }
            if (KosoratId == 0)
                KosoratId = null;
            if (MotalebatId == 0)
                MotalebatId = null;
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return Mohasebat_kosorat_MotalebatParam.Update(Id, MohasebatId, KosoratId, MotalebatId, Mablagh, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return Mohasebat_kosorat_MotalebatParam.Delete(Id, UserId);
        }
        #endregion
    }
}