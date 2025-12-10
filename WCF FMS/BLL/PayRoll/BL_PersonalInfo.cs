using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.Common;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_PersonalInfo
    {
        DL_PersonalInfo Personal = new DL_PersonalInfo();
        #region Detail
        public OBJ_PersonalInfo Detail(int Id,int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه اطلاعات پرسنلی ضروری است";
            }
            return Personal.Detail(Id,OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_PersonalInfo> Select(string FieldName, string FilterValue,int OrganId, int h)
        {
            return Personal.Select(FieldName, FilterValue,OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(OBJ_Employee Employee, OBJ_Employee_Detail Employee_Detail, OBJ_PersonalInfo PersonalInfo, byte[] Image, string Pasvand, string DateTaghirVaziyat, int NoeEstekhdamId, string Tarikh, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (PersonalInfo.fldOrganPostId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (PersonalInfo.fldNezamVazifeId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد نظام وظیفه ضروری است";
            }
            else if (PersonalInfo.fldMahalTavalodId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد محل تولد ضروری است";
            }
            else if (PersonalInfo.fldMahalSodoorId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد محل صدور ضروری است";
            }
            else if (PersonalInfo.fldEsargariId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ایثارگری ضروری است";
            }
            else if (PersonalInfo.fldMadrakId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد مدرک تحصیلی ضروری است";
            }
            else if (PersonalInfo.fldCodemeli == null || PersonalInfo.fldCodemeli == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ملی ضروری است";
            }
            else if (PersonalInfo.fldSh_Shenasname == null || PersonalInfo.fldSh_Shenasname == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شماره شناسنامه ضروری است";
            }
            else if (PersonalInfo.fldSh_Personali == null || PersonalInfo.fldSh_Personali == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شماره پرسنلی ضروری است";
            }
            
            else if (PersonalInfo.fldReshteId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "رشته تحصیلی ضروری است";
            }
            else if (PersonalInfo.fldTabaghe == null || PersonalInfo.fldTabaghe == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "طبقه ضروری است";
            }
            else if (PersonalInfo.fldName == null || PersonalInfo.fldName == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام ضروری است";
            }
            else if (PersonalInfo.fldName.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (PersonalInfo.fldFamily == null || PersonalInfo.fldFamily == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام خانوادگی ضروری است";
            }
            else if (PersonalInfo.fldFamily.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام خانوادگی وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (PersonalInfo.fldFatherName.Length < 2)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر نام پدر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (PersonalInfo.fldFatherName == null || PersonalInfo.fldFatherName == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "نام پدر ضروری است";
            }
            else if (PersonalInfo.fldTarikhTavalod == null || PersonalInfo.fldTarikhTavalod == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ تولد ضروری است";
            }
            else if (PersonalInfo.fldTarikhEstekhdam == null || PersonalInfo.fldTarikhEstekhdam == "")
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تاریخ استخدام ضروری است";
            }
            else if (Image == null)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "عکس ضروری است";
            }
            else if (new BL().checkCodeMeli(PersonalInfo.fldCodemeli) != 1)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ملی وارد شده معتبر نمی باشد.";
            }
            else if (PersonalInfo.fldSh_Shenasname.Length > 10)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شماره شناسنامه وارد شده بزرگتر از 10 رقم می باشد";
            }
            
            else if (!r.IsMatch(PersonalInfo.fldTarikhTavalod) || !r.IsMatch(PersonalInfo.fldTarikhEstekhdam))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (PersonalInfo.fldIdStatus == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد وضعیت ضروری است.";
            }
            else if (DateTaghirVaziyat == null || DateTaghirVaziyat == "")
            {
                Error.ErrorMsg = "تاریخ تغییر وضعیت ضروری است.";
                Error.ErrorType = true;
            }
            else if (!r.IsMatch(DateTaghirVaziyat))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (NoeEstekhdamId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد نوع استخدام ضروری است";
            }
            else if (PersonalInfo.fldSh_Personali.Length > 20)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "تعداد کاراکتر شماره پرسنلی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Tarikh == null || Tarikh == "")
            {
                Error.ErrorMsg = "تاریخ ضروری است.";
                Error.ErrorType = true;
            }
            else if (!r.IsMatch(Tarikh))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (Personal.CheckRepeatedRow(PersonalInfo.fldSh_Personali, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (PersonalInfo.fldDesc == null)
                PersonalInfo.fldDesc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }

            return Personal.Insert(Employee, Employee_Detail, PersonalInfo, Image,Pasvand, DateTaghirVaziyat, NoeEstekhdamId, Tarikh,UserId);
        }
        #endregion
        #region Update
        public string Update(OBJ_Employee Employee, OBJ_Employee_Detail Employee_Detail, OBJ_PersonalInfo PersonalInfo, int FileId, byte[] Image, string Pasvand, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            int chck = 1;
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            chck = new BL().checkCodeMeli(PersonalInfo.fldCodemeli);
            if (chck != 1)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ملی وارد شده معتبر نمی باشد.";
            }
            else
            {
                if (UserId == 0)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "کد کاربر ضروری است";
                }
                else if (PersonalInfo.fldId == 0)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "کد اطلاعات پرسنلی ضروری است";
                }
                else if (Employee.fldId == 0)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "کد کارمندی ضروری است";
                }
                else if (PersonalInfo.fldOrganPostId == 0)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "کد سازمان ضروری است";
                }

                else if (PersonalInfo.fldNezamVazifeId == 0)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "کد نظام وظیفه ضروری است";
                }
                else if (PersonalInfo.fldMahalTavalodId == 0)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "کد محل تولد ضروری است";
                }
                else if (PersonalInfo.fldMahalSodoorId == 0)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "کد محل صدور ضروری است";
                }
                else if (PersonalInfo.fldEsargariId == 0)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "کد ایثارگری ضروری است";
                }
                else if (PersonalInfo.fldMadrakId == 0)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "کد مدرک تحصیلی ضروری است";
                }
                else if (PersonalInfo.fldSh_Shenasname == null || PersonalInfo.fldSh_Shenasname == "")
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "شماره شناسنامه ضروری است";
                }
                else if (PersonalInfo.fldSh_Personali == null || PersonalInfo.fldSh_Personali == "")
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "شماره پرسنلی ضروری است";
                }

                else if (PersonalInfo.fldReshteId == 0)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "رشته تحصیلی ضروری است";
                }
                else if (PersonalInfo.fldTabaghe == null || PersonalInfo.fldTabaghe == "")
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "طبقه ضروری است";
                }

                else if (PersonalInfo.fldTarikhTavalod == null || PersonalInfo.fldTarikhTavalod == "")
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "تاریخ تولد ضروری است";
                }

                else if (PersonalInfo.fldTarikhEstekhdam == null || PersonalInfo.fldTarikhEstekhdam == "")
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "تاریخ استخدام ضروری است";
                }
                else if (PersonalInfo.fldSh_Shenasname.Length > 10)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "شماره شناسنامه وارد شده بزرگتر از 10 رقم می باشد";
                }
                else if (!r.IsMatch(PersonalInfo.fldTarikhTavalod) || !r.IsMatch(PersonalInfo.fldTarikhEstekhdam))
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
                }
                else if (PersonalInfo.fldName == null || PersonalInfo.fldName == "")
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "نام ضروری است";
                }
                else if (PersonalInfo.fldName.Length < 2)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "تعداد کاراکتر نام وارد شده کمتر از حد مجاز میباشد.";
                }
                else if (PersonalInfo.fldFamily == null || PersonalInfo.fldFamily == "")
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "نام خانوادگی ضروری است";
                }
                else if (PersonalInfo.fldFamily.Length < 2)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "تعداد کاراکتر نام خانوادگی وارد شده کمتر از حد مجاز میباشد.";
                }
                else if (PersonalInfo.fldFatherName.Length < 2)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "تعداد کاراکتر نام پدر وارد شده کمتر از حد مجاز میباشد.";
                }
                else if (PersonalInfo.fldFatherName == null || PersonalInfo.fldFatherName == "")
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "نام پدر ضروری است";
                }
                else if (FileId == 0)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "شناسه عکس ضروری است";
                }
                else if (PersonalInfo.fldSh_Personali.Length > 20)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "تعداد کاراکتر وارده شده شماره پرسنلی بیشتر از حد مجاز می باشد.";
                }
                else if (Personal.CheckRepeatedRow(PersonalInfo.fldSh_Personali, PersonalInfo.fldId))
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "شماره پرسنلی وارد شده تکراری است";
                }
            }
            if (PersonalInfo.fldDesc == null)
                PersonalInfo.fldDesc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return Personal.Update(Employee, Employee_Detail, PersonalInfo, FileId, Image,Pasvand,UserId);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, string IP, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد اطلاعات پرسنلی ضروری است";
            }
            else if (Personal.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (Error.ErrorType == true)
                return "خطا";

            return Personal.Delete(Id, UserId);
        }
        #endregion

        #region Select_Hokm
        public List<OBJ_PersonalInfo> Select_Hokm(string FieldName, string FilterValue, int OrganId,int UserId, int h)
        {
            return Personal.Select_Hokm(FieldName, FilterValue, OrganId, UserId, h);
        }
        #endregion
    }
}