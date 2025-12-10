using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_Ronevesht
    {
        DL_Ronevesht Ronevesht = new DL_Ronevesht();

        #region Detail
        public OBJ_Ronevesht Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Ronevesht.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Ronevesht> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return Ronevesht.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(long fldLetterId, int? fldAshkhasHoghoghiId, int? fldCommisionId, int fldAssignmentTypeId, string fldText, int OrganID, int UserId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (fldLetterId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نامه ضروری است";
            }
            //else if (fldAshkhasHoghoghiId == 0)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "کد اشخاص حقوقی ضروری است";
            //}
            //else if (fldCommisionId == 0)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "کد احکام کاری ضروری است";
            //}
            else if (fldAssignmentTypeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع ارجاع ضروری است";
            }
            //else if (fldText == "" || fldText == null)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "متن ضروری است";
            //}
            //else if (fldText.Length < 2)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "تعداد کاراکتر متن وارد شده کمتر از حد مجاز میباشد.";
            //}
            else if (fldText.Length > 300)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر متن وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Ronevesht.Insert(fldLetterId, fldAshkhasHoghoghiId, fldCommisionId, fldAssignmentTypeId, fldText, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, long fldLetterId, int? fldAshkhasHoghoghiId, int? fldCommisionId, int fldAssignmentTypeId, string fldText, int OrganID, int UserId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldLetterId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نامه ضروری است";
            }
            //else if (fldAshkhasHoghoghiId == 0)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "کد اشخاص حقوقی ضروری است";
            //}
            //else if (fldCommisionId == 0)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "کد احکام کاری ضروری است";
            //}
            else if (fldAssignmentTypeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع ارجاع ضروری است";
            }
            else if (fldText == "" || fldText == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "متن ضروری است";
            }
            else if (fldText.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر متن وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldText.Length > 300)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر متن وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Ronevesht.Update(Id, fldLetterId, fldAshkhasHoghoghiId, fldCommisionId, fldAssignmentTypeId, fldText, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Delete
        public string Delete(string FieldNAme,long id, int userId, out ClsError error)
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

            return Ronevesht.Delete(FieldNAme,id, userId);
        }
        #endregion
    }
}