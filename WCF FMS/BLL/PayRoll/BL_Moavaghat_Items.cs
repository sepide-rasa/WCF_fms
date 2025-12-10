using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Moavaghat_Items
    {
        DL_Moavaghat_Items Moavaghat_Items = new DL_Moavaghat_Items();
        #region Detail
        public OBJ_Moavaghat_Items Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return Moavaghat_Items.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_Moavaghat_Items> Select(string FieldName, string FilterValue, int h)
        {
            return Moavaghat_Items.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int MoavaghatId, int ItemEstekhdamId, int Mablagh, int UserId, string Desc, string Tarikh, int AnvaeEstekhdamId, int TypeBimeId, int SourceId, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }

            else if (MoavaghatId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد معوقات ضروری است";
            }
            else if (ItemEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد آیتم استخدام ضروری است";
            }

            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return Moavaghat_Items.Insert(MoavaghatId, ItemEstekhdamId, Mablagh, UserId, Desc, Tarikh, AnvaeEstekhdamId, TypeBimeId,  SourceId, OrganId);
        }
        #endregion
        #region Update
        public string Update(int Id, int MoavaghatId, int ItemEstekhdamId, int Mablagh, int UserId, string Desc, out ClsError Error)
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

            else if (MoavaghatId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد معوقات ضروری است";
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
            return Moavaghat_Items.Update(Id, MoavaghatId, ItemEstekhdamId, Mablagh, UserId, Desc);
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
            return Moavaghat_Items.Delete(Id, UserId);
        }
        #endregion
    }
}