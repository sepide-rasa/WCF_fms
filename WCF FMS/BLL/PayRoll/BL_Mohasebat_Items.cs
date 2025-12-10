using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Mohasebat_Items
    {
        DL_Mohasebat_Items Mohasebat_Items = new DL_Mohasebat_Items();
        #region Detail
        public OBJ_Mohasebat_Items Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return Mohasebat_Items.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_Mohasebat_Items> Select(string FieldName, string FilterValue, int h)
        {
            return Mohasebat_Items.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int MohasebatId, int ItemEstekhdamId, int Mablagh, int UserId, string Desc, string Tarikh, int AnvaeEstekhdamId, int TypeBimeId, int SourceId,byte fldCalcType, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }

            else if (MohasebatId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد محاسبات ضروری است";
            }
            else if (ItemEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد آیتم استخدام ضروری است";
            }
            else if (fldCalcType == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نوع محاسبات ضروری است";
            }

            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return Mohasebat_Items.Insert(MohasebatId, ItemEstekhdamId, Mablagh, UserId, Desc, Tarikh, AnvaeEstekhdamId, TypeBimeId, SourceId,fldCalcType,  OrganId);
        }
        #endregion
        #region Update
        public string Update(int Id, int MohasebatId, int ItemEstekhdamId, int Mablagh, int UserId, string Desc, out ClsError Error)
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

            else if (MohasebatId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد محاسبات ضروری است";
            }
            else if (ItemEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد آیتم استخدام ضروری است";
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return Mohasebat_Items.Update(Id, MohasebatId,ItemEstekhdamId, Mablagh, UserId, Desc);
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
            return Mohasebat_Items.Delete(Id, UserId);
        }
        #endregion
    }
}