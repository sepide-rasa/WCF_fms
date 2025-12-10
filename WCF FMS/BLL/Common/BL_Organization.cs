using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_Organization
    {
        DL_Organization Organization = new DL_Organization();

        #region Detail
        public OBJ_Organization Detail(int id, int UserId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Organization.Detail(id, UserId);
        }
        #endregion
        #region Select
        public List<OBJ_Organization> Select(string FieldName, string FilterValue, int UserId, int h)
        {
            return Organization.Select(FieldName, FilterValue, UserId, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldName, int? fldPId, byte[] fldArm, string Pasvand, int fldCityId, string fldCodAnformatic, byte fldCodKhedmat, int AshkhaseHoghoghiId, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            /*fldName = CodeDecode.stringcode(fldName);*/
            var q = Organization.Select("CheckName", CodeDecode.stringDecode(fldName), 0, 0).FirstOrDefault();
            if (q != null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سازمان مورد نظر قبلا در سیستم ثبت شده است.";
            }
            else
            {
                if (Desc == null)
                    Desc = "";
                if (userId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد کاربر ضروری است";
                }
                else if (fldName == "" || fldName == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "نام سازمان ضروری است";
                }
                else if (fldCityId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "انتخاب شهر ضروری است";
                }
                else if (AshkhaseHoghoghiId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد اشخاص حقوقی ضروری است";
                }
                else if (fldName.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر نام سازمان وارد شده کمتر از حد مجاز میباشد.";
                }
                else if (fldName.Length > 300)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر نام سازمان وارده شده بیشتر از حد مجاز می باشد.";
                }
                
                else if (fldCodKhedmat > 255)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "مقدار کد خدمت وارده شده بیشتر از حد مجاز می باشد.";
                }
                if (fldCodAnformatic != null)
                {
                    if (fldCodAnformatic.Length > 3)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "تعداد کاراکتر کد انفورماتیک وارده شده بیشتر از حد مجاز می باشد.";
                    }
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return Organization.Insert(fldName, fldPId, fldArm, Pasvand, fldCityId, fldCodAnformatic, fldCodKhedmat,AshkhaseHoghoghiId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int fldId, string fldName, int? fldPId, byte[] fldArm, string Pasvand, int fldFileId, int fldCityId, string fldCodAnformatic, byte fldCodKhedmat, int AshkhaseHoghoghiId, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            var q = Organization.Select("CheckName", "",0, 0).Where(l => CodeDecode.stringDecode(l.fldName) == CodeDecode.stringDecode(fldName)).FirstOrDefault();
            if (q != null && q.fldId != fldId)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سازمان مورد نظر قبلا در سیستم ثبت شده است.";
            }
            else
            {
                if (Desc == null)
                    Desc = "";
                if (userId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد کاربر ضروری است";
                }
                else if (fldId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد سازمان ضروری است";
                }
                else if (fldName == "" || fldName == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "نام سازمان ضروری است";
                }
                else if (fldCityId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "انتخاب شهر ضروری است";
                }
                else if (AshkhaseHoghoghiId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد اشخاص حقوقی ضروری است";
                }
                else if (fldName.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر نام سازمان وارد شده کمتر از حد مجاز میباشد.";
                }
                else if (fldName.Length > 300)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر نام سازمان وارده شده بیشتر از حد مجاز می باشد.";
                }
                
                else if (fldCodKhedmat > 255)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "مقدار کد خدمت وارده شده بیشتر از حد مجاز می باشد.";
                }

                if (fldCodAnformatic != null)
                {
                    if (fldCodAnformatic.Length > 3)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "تعداد کاراکتر کد انفورماتیک وارده شده بیشتر از حد مجاز می باشد.";
                    }
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return Organization.Update(fldId, fldName, fldPId, fldArm, Pasvand, fldFileId, fldCityId, fldCodAnformatic, fldCodKhedmat, AshkhaseHoghoghiId, userId, Desc);

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
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (Organization.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Organization.Delete(id, userId);
        }
        #endregion
        
    }
}