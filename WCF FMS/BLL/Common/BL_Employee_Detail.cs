using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_Employee_Detail
    {
        DL_Employee_Detail Employee_Detail = new DL_Employee_Detail();

        #region Detail
        public OBJ_Employee_Detail Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کارمند ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Employee_Detail.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Employee_Detail> Select(string FieldName, string FilterValue, int h)
        {
            return Employee_Detail.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldEmployeeId, string fldFatherName, Nullable<bool> fldJensiyat, string fldTarikhTavalod, 
            Nullable<int> fldMadrakId, Nullable<byte> fldNezamVazifeId, Nullable<int> fldTaaholId, Nullable<int> fldReshteId, 
            byte[] fldFile, string fldPassvand, string fldSh_Shenasname, Nullable<int> fldMahalTavalodId,
            Nullable<int> fldMahalSodoorId, string fldTarikhSodoor, string fldAddress, string fldCodePosti, Nullable<bool> fldMeliyat, 
            int fldUserId, string fldDesc,string fldTel,string fldMobile, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (fldDesc == null)
                fldDesc = "";

            if (fldUserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            if (fldEmployeeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شخص حقیقی ضروری است.";
            }
            /*if (fldFatherName != null)
            {
                if (fldFatherName.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر نام پدر وارد شده کمتر از حد مجاز میباشد.";
                }
            }
            if (fldTarikhTavalod != null)
            {
                if (!r.IsMatch(fldTarikhTavalod))
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
                }
            }
            if (fldTarikhSodoor != null)
            {
                if (!r.IsMatch(fldTarikhSodoor))
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
                }
            }
            if (fldCodePosti!=null)
            {
                 if (fldCodePosti.Length > 10)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد پستی وارد شده بزرگتر از 10 رقم می باشد";
                }
                 if (fldCodePosti.Length < 10)
                 {
                     error.ErrorType = true;
                     error.ErrorMsg = "کد پستی وارد شده کمتر از حد مجاز می باشد";
                 }
            }
            if (fldSh_Shenasname != null)
            {
                if (fldSh_Shenasname.Length > 10)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "شماره شناسنامه وارد شده بزرگتر از 10 رقم می باشد";
                }
            }*/
            if (fldAddress != null)
            {
                if (fldAddress.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر آدرس وارد شده کمتر از حد مجاز میباشد.";
                }
            }
            if (Employee_Detail.CheckRepeatedRow(fldEmployeeId, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات تکمیلی شخص حقیقی مورد نظر قبلا در سیستم ثبت شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Employee_Detail.Insert(fldEmployeeId, fldFatherName, fldJensiyat, fldTarikhTavalod, fldMadrakId,
                fldNezamVazifeId, fldTaaholId, fldReshteId, fldFile, fldPassvand, fldSh_Shenasname, fldMahalTavalodId
                    , fldMahalSodoorId, fldTarikhSodoor, fldAddress, fldCodePosti, fldMeliyat, fldUserId, fldDesc, fldTel, fldMobile);

        }
        #endregion
        #region Update
        public string Update(int fldId, int fldEmployeeId, string fldFatherName, Nullable<bool> fldJensiyat, string fldTarikhTavalod,
            Nullable<int> fldMadrakId, Nullable<byte> fldNezamVazifeId, Nullable<int> fldTaaholId, Nullable<int> fldReshteId,
            Nullable<int> fldFileId, byte[] fldFile, string fldPasvand, string fldSh_Shenasname, Nullable<int> fldMahalTavalodId,
            Nullable<int> fldMahalSodoorId, string fldTarikhSodoor, string fldAddress, string fldCodePosti, Nullable<bool> fldMeliyat,
            int fldUserId, string fldDesc,string fldTel,string fldMobile, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (fldDesc == null)
                fldDesc = "";
            if (fldUserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            if (fldId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (fldEmployeeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شخص حقیقی ضروری است.";
            }
            /*if (fldFatherName != null)
            {
                if (fldFatherName.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر نام پدر وارد شده کمتر از حد مجاز میباشد.";
                }
            }
            if (fldTarikhTavalod != null)
            {
                if (!r.IsMatch(fldTarikhTavalod))
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
                }
            }
            if (fldTarikhSodoor != null)
            {
                if (!r.IsMatch(fldTarikhSodoor))
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
                }
            }
            if (fldCodePosti != null)
            {
                if (fldCodePosti.Length > 10)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد پستی وارد شده بزرگتر از 10 رقم می باشد";
                }
                if (fldCodePosti.Length < 10)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد پستی وارد شده کمتر از حد مجاز می باشد";
                }
            }
            if (fldSh_Shenasname != null)
            {
                if (fldSh_Shenasname.Length > 10)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "شماره شناسنامه وارد شده بزرگتر از 10 رقم می باشد";
                }
            }*/
            if (fldAddress != null)
            {
                if (fldAddress.Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر آدرس وارد شده کمتر از حد مجاز میباشد.";
                }
            }
            if (Employee_Detail.CheckRepeatedRow(fldEmployeeId, fldId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات تکمیلی شخص حقیقی مورد نظر قبلا در سیستم ثبت شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Employee_Detail.Update(fldId, fldEmployeeId, fldFatherName, fldJensiyat, fldTarikhTavalod, fldMadrakId, fldNezamVazifeId, fldTaaholId, fldReshteId, fldFileId, fldFile
                    , fldPasvand, fldSh_Shenasname, fldMahalTavalodId, fldMahalSodoorId, fldTarikhSodoor, fldAddress, fldCodePosti, fldMeliyat, fldUserId, fldDesc, fldTel, fldMobile);

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
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Employee_Detail.Delete(id, userId);
        }
        #endregion
    }
}