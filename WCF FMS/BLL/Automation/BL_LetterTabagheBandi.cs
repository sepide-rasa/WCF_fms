using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_LetterTabagheBandi
    {
        DL_LetterTabagheBandi LetterTabagheBandi = new DL_LetterTabagheBandi();

        #region Detail
        public OBJ_LetterTabagheBandi Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return LetterTabagheBandi.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_LetterTabagheBandi> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return LetterTabagheBandi.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldTabagheBandiId, long? fldLetterId, int? fldMessageId, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldTabagheBandiId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد طبقه بندی ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return LetterTabagheBandi.Insert(fldTabagheBandiId, fldLetterId,fldMessageId, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, int fldTabagheBandiId, long? fldLetterId, int? fldMessageId, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldTabagheBandiId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد طبقه بندی ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return LetterTabagheBandi.Update(Id, fldTabagheBandiId, fldLetterId,fldMessageId, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Delete
        public string Delete(string FieldName, long id, int userId, out ClsError error)
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

            return LetterTabagheBandi.Delete(FieldName,id, userId);
        }
        #endregion
    }
}