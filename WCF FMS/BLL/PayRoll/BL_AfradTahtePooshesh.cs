using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_AfradTahtePooshesh
    {
        DL_AfradTahtePooshesh AfradTahtePooshesh = new DL_AfradTahtePooshesh();
        #region Detail
        public OBJ_AfradTahtePooshesh Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return AfradTahtePooshesh.Detail(Id,OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_AfradTahtePooshesh> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return AfradTahtePooshesh.Select(FieldName, FilterValue,OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldPersonalId, string fldName, string fldFamily, string fldBirthDate, byte fldStatus, bool fldMashmul, byte fldNesbat, string fldCodeMeli, string fldSh_Shenasname
            , string fldFatherName, string fldTarikhEzdevaj, byte fldNesbatShakhs, int fldUserId, string fldDesc,bool fldMashmoolPadash,string fldTarikhTalagh, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            int chck = 1;
            chck = new BL().checkCodeMeli(fldCodeMeli);
            if (chck != 1)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ملی وارد شده معتبر نمی باشد.";
            }
            else
            {
                var q = AfradTahtePooshesh.Select("CheckCodeMeli", fldCodeMeli, 0, 1).Where(l => l.fldPersonalId == fldPersonalId).FirstOrDefault();
                if (q != null)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "کد ملی وارد شده قبلا در سیستم ثبت شده است.";
                }
                else
                {
                    if (fldDesc == null)
                        fldDesc = "";
                    if (fldUserId == 0)
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "کد کاربر ضروری است";
                    }
                    else if (fldPersonalId == 0)
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "کد پرسنل ضروری است";
                    }
                    else if (fldName == null || fldName == "")
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "نام ضروری است";
                    }
                    else if (fldFamily == null || fldFamily == "")
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "نام خانوادگی ضروری است";
                    }
                    else if (fldBirthDate == null || fldBirthDate == "")
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "تاریخ تولد ضروری است";
                    }
                    else if (fldCodeMeli == null || fldCodeMeli == "")
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "کد ملی ضروری است";
                    }
                    else if (fldSh_Shenasname == null || fldSh_Shenasname == "")
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شماره شناسنامه ضروری است";
                    }
                    else if (fldFatherName == null || fldFatherName == "")
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "نام پدر ضروری است";
                    }
                    else if (fldNesbatShakhs == 0)
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "نسبت شخص ضروری است";
                    }
                    else if (!r.IsMatch(fldBirthDate))
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
                    }
                    else if (fldName.Length < 2)
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "تعداد کاراکتر نام وارد شده کمتر از حد مجاز میباشد.";
                    }
                    else if (fldName.Length > 100)
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "تعداد کاراکتر نام وارده شده بیشتر از حد مجاز می باشد.";
                    }
                    else if (fldFamily.Length < 2)
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "تعداد کاراکتر نام خانوادگی وارد شده کمتر از حد مجاز میباشد.";
                    }
                    else if (fldFamily.Length > 100)
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "تعداد کاراکتر نام خانوادگی وارده شده بیشتر از حد مجاز می باشد.";
                    }
                    else if (fldFatherName.Length < 2)
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "تعداد کاراکتر نام پدر وارد شده کمتر از حد مجاز میباشد.";
                    }
                    else if (fldFatherName.Length > 50)
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "تعداد کاراکتر نام پدر وارده شده بیشتر از حد مجاز می باشد.";
                    }
                    if (fldNesbat == 2)
                    {
                        if (fldTarikhEzdevaj == null || fldTarikhEzdevaj == "")
                        {
                            Error.ErrorType = true;
                            Error.ErrorMsg = "تاریخ ازدواج ضروری است";
                        }
                        else if (!r.IsMatch(fldBirthDate))
                        {
                            Error.ErrorType = true;
                            Error.ErrorMsg = "فرمت تاریخ ازدواج را به درستی وارد کنید";
                        }
                    }
                }
            }
            
            if (Error.ErrorType == true)
                return "خطا";
            return AfradTahtePooshesh.Insert(fldPersonalId, fldName, fldFamily, fldBirthDate, fldStatus, fldMashmul, fldNesbat, fldCodeMeli, fldSh_Shenasname,
                fldFatherName, fldTarikhEzdevaj, fldNesbatShakhs, fldUserId, fldDesc, fldMashmoolPadash, fldTarikhTalagh);
        }
        #endregion
        #region Update
        public string Update(int Id, int fldPersonalId, string fldName, string fldFamily, string fldBirthDate, byte fldStatus, bool fldMashmul, byte fldNesbat, string fldCodeMeli, string fldSh_Shenasname
            , string fldFatherName, string fldTarikhEzdevaj, byte fldNesbatShakhs, int fldUserId, string fldDesc,bool fldMashmoolPadash,string fldTarikhTalagh, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            int chck = 1;
            chck = new BL().checkCodeMeli(fldCodeMeli);
            if (chck != 1)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ملی وارد شده معتبر نمی باشد.";
            }
            else
            {
                var q = AfradTahtePooshesh.Select("CheckCodeMeli", fldCodeMeli, 0, 1).Where(l => l.fldPersonalId == fldPersonalId).FirstOrDefault();
                if (q != null && q.fldId != Id)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "کد ملی وارد شده قبلا در سیستم ثبت شده است.";
                }
                else
                {
                    if (fldDesc == null)
                        fldDesc = "";
                    if (fldUserId == 0)
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "کد کاربر ضروری است";
                    }
                    else if (fldPersonalId == 0)
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "کد پرسنل ضروری است";
                    }
                    else if (fldName == null || fldName == "")
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "نام ضروری است";
                    }
                    else if (fldFamily == null || fldFamily == "")
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "نام خانوادگی ضروری است";
                    }
                    else if (fldBirthDate == null || fldBirthDate == "")
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "تاریخ تولد ضروری است";
                    }
                    else if (fldCodeMeli == null || fldCodeMeli == "")
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "کد ملی ضروری است";
                    }
                    else if (fldSh_Shenasname == null || fldSh_Shenasname == "")
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "شماره شناسنامه ضروری است";
                    }
                    else if (fldFatherName == null || fldFatherName == "")
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "نام پدر ضروری است";
                    }
                    else if (fldNesbatShakhs == 0)
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "نسبت شخص ضروری است";
                    }
                    else if (fldName.Length < 2)
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "تعداد کاراکتر نام وارد شده کمتر از حد مجاز میباشد.";
                    }
                    else if (fldName.Length > 100)
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "تعداد کاراکتر نام وارده شده بیشتر از حد مجاز می باشد.";
                    }
                    else if (fldFamily.Length < 2)
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "تعداد کاراکتر نام خانوادگی وارد شده کمتر از حد مجاز میباشد.";
                    }
                    else if (fldFamily.Length > 100)
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "تعداد کاراکتر نام خانوادگی وارده شده بیشتر از حد مجاز می باشد.";
                    }
                    else if (fldFatherName.Length < 2)
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "تعداد کاراکتر نام پدر وارد شده کمتر از حد مجاز میباشد.";
                    }
                    else if (fldFatherName.Length > 50)
                    {
                        Error.ErrorType = true;
                        Error.ErrorMsg = "تعداد کاراکتر نام پدر وارده شده بیشتر از حد مجاز می باشد.";
                    }
                    if (fldNesbat == 2)
                    {
                        if (fldTarikhEzdevaj == null || fldTarikhEzdevaj == "")
                        {
                            Error.ErrorType = true;
                            Error.ErrorMsg = "تاریخ ازدواج ضروری است";
                        }
                        else if (!r.IsMatch(fldTarikhEzdevaj))
                        {
                            Error.ErrorType = true;
                            Error.ErrorMsg = "فرمت تاریخ ازدواج را به درستی وارد کنید";
                        }
                    }
                }
            }
            
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return AfradTahtePooshesh.Update(Id, fldPersonalId, fldName, fldFamily, fldBirthDate, fldStatus, fldMashmul, fldNesbat, fldCodeMeli, fldSh_Shenasname,
                fldFatherName, fldTarikhEzdevaj, fldNesbatShakhs, fldUserId, fldDesc, fldMashmoolPadash, fldTarikhTalagh);
        }
        #endregion
        #region UpdateMohasel
        public string UpdateMohasel(int Id, byte fldStatus, string fldTarikhTalagh, int fldUserId, out ClsError Error)
        {
             Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (fldTarikhTalagh == null || fldTarikhTalagh == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ اجرا ضروری است";
            }
            else if (!r.IsMatch(fldTarikhTalagh))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ اجرا را به درستی وارد کنید";
            }
            
                AfradTahtePooshesh.UpdateMohasel(Id, fldStatus, fldTarikhTalagh, fldUserId);
                return "ویرایش با موفقیت انجام شد.";
                if (Error.ErrorType == true)
                {
                    return "خطا";
                }
            
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return AfradTahtePooshesh.Delete(Id, UserId);
        }
        #endregion
    }
}