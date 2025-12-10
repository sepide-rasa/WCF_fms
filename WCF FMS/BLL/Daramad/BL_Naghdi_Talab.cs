using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_Naghdi_Talab
    {
        DL_Naghdi_Talab Naghdi_Talab = new DL_Naghdi_Talab();

        #region Detail
        public OBJ_Naghdi_Talab Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Naghdi_Talab.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Naghdi_Talab> Select(string FieldName, string FilterValue, int h)
        {
            return Naghdi_Talab.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(long Mablagh, int ReplyTaghsitId, byte Type, int? ShomareHesabId, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (ReplyTaghsitId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پاسخ درخواست تقسیط ضروری است";
            }
            else if (Type >255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد نوع بیش از حد مجاز است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Naghdi_Talab.Insert(Mablagh, ReplyTaghsitId, Type, ShomareHesabId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, long Mablagh, int ReplyTaghsitId, byte Type, int? ShomareHesabId, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (ReplyTaghsitId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پاسخ درخواست تقسیط ضروری است";
            }
            else if (Type > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد نوع بیش از حد مجاز است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Naghdi_Talab.Update(Id, Mablagh, ReplyTaghsitId, Type, ShomareHesabId, userId, Desc);

        }
        #endregion
        #region Delete
        public string Delete(int id, int userId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Naghdi_Talab.Delete(id, userId);
        }
        #endregion
    }
}