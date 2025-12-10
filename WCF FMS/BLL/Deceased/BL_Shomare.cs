using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Deceased;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.BLL.Deceased
{
    public class BL_Shomare
    {
        DL_Shomare Shomare = new DL_Shomare();

        #region Detail
        public OBJ_Shomare Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Shomare.Detail(id,OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Shomare> Select(string FieldName, string FilterValue, int Id, int OrganId, int h)
        {
            return Shomare.Select(FieldName, FilterValue,Id,OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldRadifId, string fldShomare, byte fldTedadTabaghat, int OrganId, int userId, string Desc, string IP, out ClsError error)
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
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (fldRadifId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ردیف ضروری است";
            }
            else if (fldTedadTabaghat == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد طبقات ضروری است";
            }
            else if (fldShomare == "" || fldShomare == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره ضروری است";
            }
            else if (fldShomare.Length > 30)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شماره وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Shomare.CheckRepeatedRow(fldRadifId,fldShomare, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Shomare.Insert(fldRadifId, fldShomare, fldTedadTabaghat, userId, Desc, IP, OrganId);

        }
        #endregion
        #region Update
        public string Update(int fldId, int fldRadifId, string fldShomare, byte fldTedadTabaghat, int OrganId, int userId, string Desc, string IP, out ClsError error)
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
            else if (fldId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شهر ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (fldRadifId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ردیف ضروری است";
            }
            else if (fldTedadTabaghat == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد طبقات ضروری است";
            }
            else if (fldShomare == "" || fldShomare == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره ضروری است";
            }
            else if (fldShomare.Length > 30)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شماره وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Shomare.CheckRepeatedRow(fldRadifId, fldShomare, fldId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Shomare.Update(fldId, fldRadifId,fldShomare,fldTedadTabaghat, userId, Desc, IP,OrganId);

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
            else if (Shomare.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است لذا مجاز به حذف نمی باشید.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Shomare.Delete(id, userId);
        }
        #endregion

        #region SelectTabaghe
        public List<OBJ_Tabaghe> SelectTabaghe(int ShomareId, int Id)
        {
            return Shomare.SelectTabaghe(ShomareId,Id);
        }
        #endregion
    }
}