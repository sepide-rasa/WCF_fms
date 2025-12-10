using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_KarKardeMahane
    {
        DL_KarKardeMahane KarKardeMahane = new DL_KarKardeMahane();
        #region Detail
        public OBJ_KarKardeMahane Detail(int Id, int OrganId, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return KarKardeMahane.Detail(Id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_KarKardeMahane> Select(string FieldName, string FilterValue, string Year, string Month, byte NobatPardakht, int id, int OrganId, int h)
        {
            return KarKardeMahane.Select(FieldName, FilterValue, Year, Month, NobatPardakht, id, OrganId, h);
        }
        #endregion
        #region Insert
        public int Insert(int PersonalId, short Year, byte Mah, byte Karkard, byte Gheybat, byte NobateKari, decimal EzafeKari, decimal TatileKari, byte MamoriatBaBeitote
            , byte MamoriatBedoneBeitote, int Mosaedeh, byte NobatePardakht, bool Flag, bool Ghati, byte Ba10, byte Ba20, byte Ba30, byte Be10,
           byte Be20, byte Be30, int Shift, bool Moavaghe, int? AzTarikhMoavaghe, int? TaTarikhMoavaghe, short fldMeetingCount, byte fldEstelagi, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }

            else if (PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل ضروری است";
            }
            else if (Year == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال ضروری است";
            }
            else if (Mah == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "ماه ضروری است";
            }
            else if (KarKardeMahane.CheckRepeatedRow(PersonalId, Year.ToString(), Mah.ToString(), NobatePardakht, 0))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (MamoriatBaBeitote + MamoriatBedoneBeitote > 30)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "مجموع ماموریت وارد شده بیش از حد مجاز حداکثر مقدار 30 است";
            }
            if (System.Configuration.ConfigurationManager.AppSettings["OverTime_Holiday"].ToString() == "1")/*جمع شود*/
            {
                if (EzafeKari + TatileKari > 175)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "مجموع اضافه کاری و تعطیل کاری وارد شده بیش از حد مجاز است حداکثر مجموع 175 است";
                }
            }
            else
            {
                if (EzafeKari > 175)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "اضافه کاری وارد شده بیش از حد مجاز است حداکثر اضافه کاری 175 است";
                }
                if (TatileKari >= 120)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "تعطیل کاری وارد شده بیش از حد مجاز است حداکثر تعطیل کاری 120 است";
                }
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return 0;
            return KarKardeMahane.Insert(PersonalId, Year, Mah, Karkard, Gheybat, NobateKari, EzafeKari, TatileKari, MamoriatBaBeitote, MamoriatBedoneBeitote, Mosaedeh
                    , NobatePardakht, Flag, Ghati, Ba10, Ba20, Ba30, Be10, Be20, Be30, Shift, Moavaghe, AzTarikhMoavaghe, TaTarikhMoavaghe, fldMeetingCount,  fldEstelagi, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, short Year, byte Mah, byte Karkard, byte Gheybat, byte NobateKari, decimal EzafeKari, decimal TatileKari, byte MamoriatBaBeitote
            , byte MamoriatBedoneBeitote, int Mosaedeh, byte NobatePardakht, bool Flag, bool Ghati, byte Ba10, byte Ba20, byte Ba30, byte Be10,
           byte Be20, byte Be30, int Shift, bool Moavaghe, int? AzTarikhMoavaghe, int? TaTarikhMoavaghe, short fldMeetingCount, byte fldEstelagi, int UserId, string Desc, out ClsError Error)
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
                Error.ErrorMsg = "کد ضروری است";
            }
            else if (PersonalId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد پرسنل ضروری است";
            }
            else if (Year == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال ضروری است";
            }
            else if (Mah == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "ماه ضروری است";
            }
            else if (KarKardeMahane.CheckRepeatedRow(PersonalId, Year.ToString(), Mah.ToString(), NobatePardakht, Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (MamoriatBaBeitote + MamoriatBedoneBeitote > 30)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "مجموع ماموریت وارد شده بیش از حد مجاز حداکثر مقدار 30 است";
            }
            if (System.Configuration.ConfigurationManager.AppSettings["OverTime_Holiday"].ToString() == "1")/*جمع شود*/
            {
                if (EzafeKari + TatileKari > 175)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "مجموع اضافه کاری و تعطیل کاری وارد شده بیش از حد مجاز است حداکثر مجموع 175 است";
                }
            }
            else
            {
                if (EzafeKari > 175)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "اضافه کاری وارد شده بیش از حد مجاز است حداکثر اضافه کاری 175 است";
                }
                if (TatileKari >= 120)
                {
                    Error.ErrorType = true;
                    Error.ErrorMsg = "تعطیل کاری وارد شده بیش از حد مجاز است حداکثر تعطیل کاری 120 است";
                }
            }
            if (Moavaghe == true)
            {
                {
                    if (AzTarikhMoavaghe == 0 || AzTarikhMoavaghe == null)
                        Error.ErrorType = true;
                    Error.ErrorMsg = "تاریخ شروع محاسبات معوقه ضروری است";
                }
                {
                    if (TaTarikhMoavaghe == 0 || TaTarikhMoavaghe == null)
                        Error.ErrorType = true;
                    Error.ErrorMsg = "تاریخ پایان محاسبات معوقه ضروری است";
                }
            }
            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return KarKardeMahane.Update(Id, PersonalId, Year, Mah, Karkard, Gheybat, NobateKari, EzafeKari, TatileKari, MamoriatBaBeitote, MamoriatBedoneBeitote, Mosaedeh
                    , NobatePardakht, Flag, Ghati, Ba10, Ba20, Ba30, Be10, Be20, Be30, Shift, Moavaghe, AzTarikhMoavaghe, TaTarikhMoavaghe, fldMeetingCount,  fldEstelagi, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, out ClsError Error)
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
                Error.ErrorMsg = "کد ضروری است";
            }
            else if (KarKardeMahane.CheckDelete(Id))
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return KarKardeMahane.Delete(Id, UserId);
        }
        #endregion

        #region KarKardeMahaneGroup
        public List<OBJ_KarKardeMahane> KarKardeMahaneGroup(string FieldName, string FilterValue, short Year, byte Month, byte NobatPardakht, int OrganId)
        {
            return KarKardeMahane.KarKardeMahaneGroup(FieldName, FilterValue, Year, Month, NobatPardakht, OrganId);
        }
        #endregion
    }
}