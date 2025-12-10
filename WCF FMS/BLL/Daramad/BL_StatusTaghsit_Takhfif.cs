using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_StatusTaghsit_Takhfif
    {
        DL_StatusTaghsit_Takhfif StatusTaghsit_Takhfif = new DL_StatusTaghsit_Takhfif();

        #region Detail
        public OBJ_StatusTaghsit_Takhfif Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return StatusTaghsit_Takhfif.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_StatusTaghsit_Takhfif> Select(string FieldName, string FilterValue, int h)
        {
            return StatusTaghsit_Takhfif.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int replyId, int RequestId, byte TypeMojavez, byte TypeRequest, decimal Darsad, long Mablagh, string Tarikh, long MablaghNaghdi, byte TedadAghsat, string ShomareMojavez, byte TedadMahAghsat, long JarimeTakhir, int organId, decimal DarsadTaghsit, string DescKarmozd, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (RequestId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد درخواست تخفیف-تقسیط ضروری است";
            }
            
            else if (TypeMojavez > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد نوع مجوز وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (TypeRequest > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد نوع درخواست وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (organId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            if (TypeMojavez == 1)
            {
                if (ShomareMojavez == "" || ShomareMojavez == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "شماره مجوز ضروری است";
                }
                if (ShomareMojavez.Length > 50)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر شماره مجوز وارده شده بیشتر از حد مجاز می باشد.";
                }
                if (!r.IsMatch(Tarikh))
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
                }
                if (Tarikh == "" || Tarikh == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تاریخ ضروری است";
                }
                if (TypeRequest == 2)
                {
                    
                    if (Darsad > 100)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "درصد تخفیف وارده شده بیشتر از حد مجاز می باشد.";
                    }
                    else if (Darsad < 0)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "درصد تخفیف وارده شده کمتر از حد مجاز می باشد.";
                    }
                    else if (Mablagh == 0)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "مبلغ تخفیف ضروری است";
                    }
                }
                if (TypeRequest == 1)
                {
                    
                    if (TedadAghsat == 0)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "تعداد اقساط ضروری است";
                    }

                    else if (TedadMahAghsat == 0)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "تعداد ماه اقساط ضروری است";
                    }
                    else if (TedadMahAghsat > 255)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "مقدار فیلد تعداد ماه اقساط وارده شده بیشتر از حد مجاز می باشد.";
                    }

                    else if (DarsadTaghsit > 100)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "درصد تقسیط وارده شده بیشتر از حد مجاز می باشد.";
                    }
                }
            }
           
            
            
            if (error.ErrorType == true)
                return "خطا";

            return StatusTaghsit_Takhfif.Insert(replyId, RequestId, TypeMojavez, TypeRequest, Darsad, Mablagh, Tarikh, MablaghNaghdi, TedadAghsat, ShomareMojavez, TedadMahAghsat, JarimeTakhir, organId,DarsadTaghsit,DescKarmozd, userId, Desc);

        }
        #endregion
    }
}