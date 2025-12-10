using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Deceased;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.BLL.Deceased
{
    public class BL_Motevaffa
    {
        DL_Motevaffa Motevaffa = new DL_Motevaffa();

        #region Detail
        public OBJ_Motevaffa Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Motevaffa.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Motevaffa> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return Motevaffa.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int? ShomareId, int? EmployeeId, int? fldCauseOfDeathId, string fldTarikhFot, string fldTarikhDafn, int? fldMahalFotId, int userId, int OrganId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
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
            //else if (fldCauseOfDeathId == 0)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "کد علت فوت ضروری است";
            //}
            //else if (ShomareId == 0)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "کد شماره ضروری است";
            //}
            //else if (EmployeeId == 0)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "کد شخص ضروری است";
            //}
            //else if (fldMahalFotId == 0)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "کد محل فوت ضروری است";
            //}
            //else if (fldTarikhFot == null || fldTarikhFot == "")
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "تاریخ فوت ضروری است";
            //}
            //else if (!r.IsMatch(fldTarikhFot))
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "فرمت تاریخ فوت را به درستی وارد کنید";
            //}
            //else if (fldTarikhDafn == null || fldTarikhDafn == "")
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "تاریخ ضروری است";
            //}
            //else if (!r.IsMatch(fldTarikhDafn))
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "فرمت تاریخ دفن را به درستی وارد کنید";
            //}
            if (error.ErrorType == true)
                return "خطا";

            return Motevaffa.Insert(ShomareId,EmployeeId,fldCauseOfDeathId,fldTarikhFot,fldTarikhDafn,fldMahalFotId, userId, Desc, IP, OrganId);

        }
        #endregion
        #region Update
        public string Update(int fldId, int? fldCauseOfDeathId, int? fldGhabreAmanatId, string fldTarikhFot, string fldTarikhDafn, int? fldMahalFotId, int userId, int OrganId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");

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
            else if (fldId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شهر ضروری است";
            }
            //else if (fldCauseOfDeathId == 0)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "کد علت فوت ضروری است";
            //}
            //else if (fldGhabreAmanatId == 0)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "کد قبر امانت ضروری است";
            //}
            //else if (fldMahalFotId == 0)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "کد محل فوت ضروری است";
            //}
            //else if (fldTarikhFot == null || fldTarikhFot == "")
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "تاریخ فوت ضروری است";
            //}
            //else if (!r.IsMatch(fldTarikhFot))
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "فرمت تاریخ فوت را به درستی وارد کنید";
            //}
            //else if (fldTarikhDafn == null || fldTarikhDafn == "")
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "تاریخ ضروری است";
            //}
            //else if (!r.IsMatch(fldTarikhDafn))
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "فرمت تاریخ دفن را به درستی وارد کنید";
            //}
            if (error.ErrorType == true)
                return "خطا";

            return Motevaffa.Update(fldId, fldCauseOfDeathId, fldGhabreAmanatId, fldTarikhFot, fldTarikhDafn, fldMahalFotId, userId, Desc, IP, OrganId);

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

            return Motevaffa.Delete(id, userId);
        }
        #endregion
    }
}