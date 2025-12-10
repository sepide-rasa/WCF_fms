using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Contract;
using WCF_FMS.TOL.Accounting;
using WCF_FMS.TOL.Contract;

namespace WCF_FMS.BLL.Contract
{
    public class BL_RegistrationContract
    {
        DL_RegistrationContract RegistrationContract = new DL_RegistrationContract();

        #region Detail
        public OBJ_RegistrationContract Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return RegistrationContract.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_RegistrationContract> Select(string FieldName, string FilterValue, int h)
        {
            return RegistrationContract.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int WarrantyId, byte RoleOrgan, string TitleContract, int AshkhasId, byte SuplyMaterialsType, long AmountContract, string Number, string Tarikh, int? ShobeId, string SepamNum, string TarikhEtmam, string StartContract, string EndContract, int OrganId, int UserId, string IP, string Desc, out ClsError error)
        {
            error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (TitleContract == "" || TitleContract == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان قرارداد ضروری است";
            }
            else if (TitleContract.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان قرارداد وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (StartContract == "" || StartContract == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ شروع قرارداد ضروری است";
            }
            else if (EndContract == "" || EndContract == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ پایان قرارداد ضروری است";
            }
            else if (!r.IsMatch(StartContract) || !r.IsMatch(EndContract))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if ((MyLib.Shamsi.Shamsi2miladiDateTime(EndContract) - MyLib.Shamsi.Shamsi2miladiDateTime(StartContract)).TotalDays < 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "لطفا بازه زمانی وارد شده را صحیح انتخاب کنید";
            }
            else if (AmountContract == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مبلغ قرارداد ضروری است";
            }
            else if (RoleOrgan == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نقش سازمان ضروری است";
            }
            else if (RoleOrgan > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد نقش سازمان از حد مجاز است";
            }
            else if (SuplyMaterialsType == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع تامین مصالح ضروری است";
            }
            else if (SuplyMaterialsType > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد نوع تامین مصالح از حد مجاز است";
            }
            else if (AshkhasId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اشخاص ضروری است";
            }

            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }

            else if (WarrantyId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد انواع ضمانت ضروری است";
            }

            if (WarrantyId != 8)
            {
                if (WarrantyId == 9)
                {
                    if (Tarikh == "" || Tarikh == null)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "تاریخ وارده ضروری است";
                    }
                    if (!r.IsMatch(Tarikh))
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
                    }
                    else if (Number == "" || Number == null)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "شماره وارده ضروری است";
                    }
                }
                if (WarrantyId == 10)
                {
                    if (Number == "" || Number == null)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "شماره ضمانت نامه ضروری است";
                    }
                    else if (SepamNum == "" || SepamNum == null)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "شماره سپام ضروری است";
                    }
                    else if (SepamNum.Length > 100)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "تعداد کاراکتر شماره سپام وارده شده بیشتر از حد مجاز می باشد.";
                    }
                    else if (ShobeId == 0)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "کد شعبه ضروری است";
                    }
                    else if (Tarikh == "" || Tarikh == null)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "تاریخ صدور وارده ضروری است";
                    }
                    else if (!r.IsMatch(Tarikh))
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "فرمت تاریخ صدور را به درستی وارد کنید";
                    }
                    else if (TarikhEtmam == "" || TarikhEtmam == null)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "تاریخ اتمام ضروری است";
                    }

                    else if (!r.IsMatch(TarikhEtmam))
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
                    }
                }
                if (WarrantyId == 11)
                {
                    if (Tarikh == "" || Tarikh == null)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "تاریخ واریز ضروری است";
                    }
                    if (!r.IsMatch(Tarikh))
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
                    }
                    else if (Number == "" || Number == null)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "شماره فیش ضروری است";
                    }
                }
                if (WarrantyId == 12)
                {
                    if (Tarikh == "" || Tarikh == null)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "تاریخ صدور ضروری است";
                    }
                    if (!r.IsMatch(Tarikh))
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
                    }
                    else if (Number == "" || Number == null)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "شماره چک ضروری است";
                    }
                    else if (ShobeId == 0)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "کد شعبه ضروری است";
                    }
                }
            }


            if (error.ErrorType == true)
                return "خطا";

            return RegistrationContract.Insert(WarrantyId, RoleOrgan, TitleContract, AshkhasId, SuplyMaterialsType, AmountContract, Number, Tarikh, ShobeId, SepamNum, TarikhEtmam, StartContract, EndContract, OrganId, UserId, IP, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int WarrantyId, byte RoleOrgan, string TitleContract, int AshkhasId, byte SuplyMaterialsType, long AmountContract, string Number, string Tarikh, int? ShobeId, string SepamNum, string TarikhEtmam, string StartContract, string EndContract, int OrganId, int UserId, string IP, string Desc, out ClsError error)
        {
            error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (TitleContract == "" || TitleContract == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان قرارداد ضروری است";
            }
            else if (TitleContract.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان قرارداد وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (StartContract == "" || StartContract == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ شروع قرارداد ضروری است";
            }
            else if (EndContract == "" || EndContract == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ پایان قرارداد ضروری است";
            }
            else if (!r.IsMatch(StartContract) || !r.IsMatch(EndContract))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if ((MyLib.Shamsi.Shamsi2miladiDateTime(EndContract) - MyLib.Shamsi.Shamsi2miladiDateTime(StartContract)).TotalDays < 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "لطفا بازه زمانی وارد شده را صحیح انتخاب کنید";
            }
            else if (AmountContract == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مبلغ قرارداد ضروری است";
            }
            else if (RoleOrgan == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نقش سازمان ضروری است";
            }
            else if (RoleOrgan > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد نقش سازمان از حد مجاز است";
            }
            else if (SuplyMaterialsType == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع تامین مصالح ضروری است";
            }
            else if (SuplyMaterialsType > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد نوع تامین مصالح از حد مجاز است";
            }
            else if (AshkhasId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اشخاص ضروری است";
            }

            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }

            else if (WarrantyId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد انواع ضمانت ضروری است";
            }

            if (WarrantyId != 8)
            {
                if (WarrantyId == 9)
                {
                    if (Tarikh == "" || Tarikh == null)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "تاریخ وارده ضروری است";
                    }
                    if (!r.IsMatch(Tarikh))
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
                    }
                    else if (Number == "" || Number == null)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "شماره وارده ضروری است";
                    }
                }
                if (WarrantyId == 10)
                {
                    if (Number == "" || Number == null)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "شماره ضمانت نامه ضروری است";
                    }
                    else if (SepamNum == "" || SepamNum == null)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "شماره سپام ضروری است";
                    }
                    else if (SepamNum.Length > 100)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "تعداد کاراکتر شماره سپام وارده شده بیشتر از حد مجاز می باشد.";
                    }
                    else if (ShobeId == 0)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "کد شعبه ضروری است";
                    }
                    else if (Tarikh == "" || Tarikh == null)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "تاریخ صدور وارده ضروری است";
                    }
                    else if (!r.IsMatch(Tarikh))
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "فرمت تاریخ صدور را به درستی وارد کنید";
                    }
                    else if (TarikhEtmam == "" || TarikhEtmam == null)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "تاریخ اتمام ضروری است";
                    }

                    else if (!r.IsMatch(TarikhEtmam))
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
                    }
                }
                if (WarrantyId == 11)
                {
                    if (Tarikh == "" || Tarikh == null)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "تاریخ واریز ضروری است";
                    }
                    if (!r.IsMatch(Tarikh))
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
                    }
                    else if (Number == "" || Number == null)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "شماره فیش ضروری است";
                    }
                }
                if (WarrantyId == 12)
                {
                    if (Tarikh == "" || Tarikh == null)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "تاریخ صدور ضروری است";
                    }
                    if (!r.IsMatch(Tarikh))
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
                    }
                    else if (Number == "" || Number == null)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "شماره چک ضروری است";
                    }
                    else if (ShobeId == 0)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "کد شعبه ضروری است";
                    }
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return RegistrationContract.Update(Id, WarrantyId, RoleOrgan, TitleContract, AshkhasId, SuplyMaterialsType, AmountContract, Number, Tarikh, ShobeId, SepamNum, TarikhEtmam, StartContract, EndContract,OrganId, UserId, IP, Desc);

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

            return RegistrationContract.Delete(id, userId);
        }
        #endregion
    }
}