using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Deceased;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.BLL.Deceased
{
    public class BL_Actions
    {
        DL_Actions Actions = new DL_Actions();

        #region Detail
        public OBJ_Actions Detail(int id, int organId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Actions.Detail(id, organId);
        }
        #endregion
        #region Select
        public List<OBJ_Actions> Select(string FieldName, string FilterValue, int organId, int h)
        {
            return Actions.Select(FieldName, FilterValue,organId, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldTitleAction, int organId, int userId, string Desc, string IP, out ClsError error)
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
            else if (fldTitleAction == "" || fldTitleAction == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان اقدام ضروری است";
            }
            else if (fldTitleAction.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر اقدام وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldTitleAction.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر اقدام وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Actions.CheckRepeatedRow(fldTitleAction,organId, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اقدام وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Actions.Insert(fldTitleAction,organId, userId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int fldId, string fldTitleAction, int organId, int userId, string Desc, string IP, out ClsError error)
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
            else if (fldTitleAction == "" || fldTitleAction == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان اقدام ضروری است";
            }
            else if (fldTitleAction.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر اقدام وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldTitleAction.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر اقدام وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Actions.CheckRepeatedRow(fldTitleAction,organId, fldId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اقدام وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Actions.Update(fldId, fldTitleAction,organId, userId, Desc, IP);

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
            else if (Actions.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است لذا مجاز به حذف نمی باشید.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Actions.Delete(id, userId);
        }
        #endregion
    }
}