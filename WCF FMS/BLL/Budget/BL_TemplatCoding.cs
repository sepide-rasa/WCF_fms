using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Budget;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.BLL.Budget
{
    public class BL_TemplatCoding
    {
        DL_TemplatCoding TemplatCoding = new DL_TemplatCoding();

        #region Detail
        public OBJ_TemplatCoding Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return TemplatCoding.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_TemplatCoding> Select(string FieldName, string FilterValue, string FilterValue2, int OrganId, int h)
        {
            return TemplatCoding.Select(FieldName, FilterValue, FilterValue2, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int? PID, string fldName, string fldPCod, int fldTemplatNameId, string fldCode, int fldCodingLevelId, int OrganId, int userId, string Desc, string IP, out ClsError error)
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
            if (fldName == "" || fldName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (fldName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldCode == "" || fldCode == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (fldCodingLevelId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سطوح کدینگ بودجه ضروری است";
            }
            else if (fldTemplatNameId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نام الگو ضروری است";
            }
            else if (TemplatCoding.CheckRepeatedRow(fldTemplatNameId, fldCode, OrganId, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TemplatCoding.Insert(PID, fldName, fldPCod, fldTemplatNameId, fldCode, fldCodingLevelId, OrganId, userId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, string fldName, int fldTemplatNameId, string fldCode, int fldCodingLevelId, int OrganId, int userId, string Desc, string IP, out ClsError error)
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
            if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (fldName == "" || fldName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (fldName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldCode == "" || fldCode == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (fldCodingLevelId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سطوح کدینگ بودجه ضروری است";
            }
            else if (fldTemplatNameId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نام الگو ضروری است";
            }
            else if (TemplatCoding.CheckRepeatedRow(fldTemplatNameId, fldCode, OrganId, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TemplatCoding.Update(Id, fldName, fldTemplatNameId, fldCode, fldCodingLevelId, OrganId, userId, Desc, IP);

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
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TemplatCoding.Delete(id, userId);
        }
        #endregion
        #region CheckValidCodeBudje
        public List<OBJ_CheckValidCodeBudje> CheckValidCodeBudje(string Code, string PCode, int fldId, int TempNameId)
        {
            return TemplatCoding.CheckValidCodeBudje(Code, PCode, fldId, TempNameId);
        }
        #endregion
        #region GetDefaultCodeBudje
        public List<OBJ_DefaultCode> GetDefaultCodeBudje(string PCode, int TempNameId)
        {
            return TemplatCoding.GetDefaultCodeBudje(PCode, TempNameId);
        }
        #endregion
    }
}