using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_Signer
    {
        DL_Signer Signer = new DL_Signer();

        #region Detail
        public OBJ_Signer Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Signer.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Signer> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return Signer.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(long fldLetterId, int fldSignerComisionId, int fldIndexerId, int? fldFirstSigner, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldSignerComisionId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "حکم امضا کننده ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Signer.Insert(fldLetterId, fldSignerComisionId, fldIndexerId, fldFirstSigner, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, long fldLetterId, int fldSignerComisionId, int fldIndexerId, int? fldFirstSigner, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldSignerComisionId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "حکم امضا کننده ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Signer.Update(Id, fldLetterId, fldSignerComisionId, fldIndexerId, fldFirstSigner, OrganID, UserId, Desc, IP);

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

            return Signer.Delete(id, userId);
        }
        #endregion
    }
}