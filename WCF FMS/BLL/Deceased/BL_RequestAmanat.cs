using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Deceased;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.BLL.Deceased
{
    public class BL_RequestAmanat
    {
        DL_RequestAmanat RequestAmanat = new DL_RequestAmanat();

        #region Detail
        public OBJ_RequestAmanat Detail(int id, int organId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return RequestAmanat.Detail(id, organId);
        }
        #endregion
        #region Select
        public List<OBJ_RequestAmanat> Select(string FieldName, string FilterValue, int organId, int h)
        {
            return RequestAmanat.Select(FieldName, FilterValue, organId, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldEmployeeId, int fldShomareId, int organId, int userId, string Desc, string IP, out ClsError error)
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
            else if (fldEmployeeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کارمند ضروری است";
            }
            else if (fldShomareId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره ضروری است";
            }
            //else if (fldTarikhRequest == null || fldTarikhRequest == "")
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "تاریخ ضروری است";
            //}
            //else if (!r.IsMatch(fldTarikhRequest))
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            //}
            if (error.ErrorType == true)
                return "خطا";

            return RequestAmanat.Insert(fldEmployeeId, fldShomareId, organId, userId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int fldId, int fldEmployeeId, int fldShomareId, int organId, int userId, string Desc, string IP, out ClsError error)
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
            if (fldId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (fldEmployeeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کارمند ضروری است";
            }
            else if (fldShomareId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره ضروری است";
            }
            //else if (fldTarikhRequest == null || fldTarikhRequest == "")
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "تاریخ ضروری است";
            //}
            //else if (!r.IsMatch(fldTarikhRequest))
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            //}
            if (error.ErrorType == true)
                return "خطا";

            return RequestAmanat.Update(fldId, fldEmployeeId, fldShomareId, organId, userId, Desc, IP);

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

            return RequestAmanat.Delete(id, userId);
        }
        #endregion

        #region UpdateRequestForEbtal
        public string UpdateRequestForEbtal(int fldId, int userId, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            if (fldId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            
            if (error.ErrorType == true)
                return "خطا";

            return RequestAmanat.UpdateRequestForEbtal(fldId, userId, IP);

        }
        #endregion
        #region UpdateEtmamCharkhe
        public string UpdateEtmamCharkhe(int fldId, int userId, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            if (fldId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }

            if (error.ErrorType == true)
                return "خطا";

            return RequestAmanat.UpdateEtmamCharkhe(fldId, userId, IP);

        }
        #endregion

    }
}