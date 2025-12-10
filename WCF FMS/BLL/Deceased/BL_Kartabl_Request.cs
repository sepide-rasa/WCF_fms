using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Deceased;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.BLL.Deceased
{
    public class BL_Kartabl_Request
    {
        DL_Kartabl_Request Kartabl_Request = new DL_Kartabl_Request();

        #region Detail
        public OBJ_Kartabl_Request Detail(int id, int organId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Kartabl_Request.Detail(id, organId);
        }
        #endregion
        #region Select
        public List<OBJ_Kartabl_Request> Select(string FieldName, string FilterValue, int organId, int h)
        {
            return Kartabl_Request.Select(FieldName, FilterValue, organId, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldKartablId, int fldActionId, int fldRequestId, int fldKartablNextId, int organId, int userId, string Desc, string IP, out ClsError error)
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
            else if (fldKartablId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کارتابل ضروری است";
            }
            else if (fldActionId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اقدام ضروری است";
            }
            else if (fldRequestId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد درخواست امانت ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Kartabl_Request.Insert(fldKartablId, fldActionId, fldRequestId, fldKartablNextId, organId, userId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int fldId, int fldKartablId, int fldActionId, int fldRequestId, int fldKartablNextId, int organId, int userId, string Desc, string IP, out ClsError error)
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
            if (fldId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (fldKartablId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کارتابل ضروری است";
            }
            else if (fldActionId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اقدام ضروری است";
            }
            else if (fldRequestId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد درخواست امانت ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Kartabl_Request.Update(fldId, fldKartablId, fldActionId, fldRequestId, fldKartablNextId, organId, userId, Desc, IP);

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

            return Kartabl_Request.Delete(id, userId);
        }
        #endregion
    }
}