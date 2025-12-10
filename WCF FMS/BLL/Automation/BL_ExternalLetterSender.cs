using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_ExternalLetterSender
    {
        DL_ExternalLetterSender ExternalLetterSender = new DL_ExternalLetterSender();

        #region Detail
        public OBJ_ExternalLetterSender Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ExternalLetterSender.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_ExternalLetterSender> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return ExternalLetterSender.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(long? fldLetterId, int? fldMessageId, int fldAshkhasHoghoghiId, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldAshkhasHoghoghiId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اشخاص حقوقی ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ExternalLetterSender.Insert(fldLetterId, fldMessageId, fldAshkhasHoghoghiId, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, long? fldLetterId, int? fldMessageId, int fldAshkhasHoghoghiId, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldAshkhasHoghoghiId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اشخاص حقوقی ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ExternalLetterSender.Update(Id, fldLetterId, fldMessageId, fldAshkhasHoghoghiId, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Delete
        public string Delete(long id, int userId, out ClsError error)
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

            return ExternalLetterSender.Delete(id, userId);
        }
        #endregion
    }
}