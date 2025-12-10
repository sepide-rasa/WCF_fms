using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Deceased;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.BLL.Deceased
{
    public class BL_CauseOfDeath
    {
        DL_CauseOfDeath CauseOfDeath = new DL_CauseOfDeath();

        #region Detail
        public OBJ_CauseOfDeath Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return CauseOfDeath.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_CauseOfDeath> Select(string FieldName, string FilterValue, int h)
        {
            return CauseOfDeath.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldReason, int userId, string Desc, string IP, out ClsError error)
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
                else if (fldReason == "" || fldReason == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "علت فوت ضروری است";
                }
                else if (fldReason.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر علت وارد شده کمتر از حد مجاز میباشد.";
                }
                else if (fldReason.Length > 200)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر علت وارده شده بیشتر از حد مجاز می باشد.";
                }
                else if (CauseOfDeath.CheckRepeatedRow(fldReason, 0))
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "علت فوت وارد شده تکراری است.";
                }
            if (error.ErrorType == true)
                return "خطا";

            return CauseOfDeath.Insert(fldReason, userId, Desc,IP);

        }
        #endregion
        #region Update
        public string Update(int fldId, string fldReason, int userId, string Desc, string IP, out ClsError error)
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
            else if (fldReason == "" || fldReason == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "علت فوت ضروری است";
            }
            else if (fldReason.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر علت وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldReason.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر علت وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (CauseOfDeath.CheckRepeatedRow(fldReason, fldId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "علت فوت وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CauseOfDeath.Update(fldId, fldReason, userId, Desc, IP);

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
            else if (CauseOfDeath.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است لذا مجاز به حذف نمی باشید.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CauseOfDeath.Delete(id, userId);
        }
        #endregion
    }
}