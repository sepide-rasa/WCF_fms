using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Weigh;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.BLL.Weigh
{
    public class BL_Remittance_Header
    {
        DL_Remittance_Header Remittance_Header = new DL_Remittance_Header();

        #region Detail
        public OBJ_Remittance_Header Detail(int id,int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Remittance_Header.Detail(id,OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Remittance_Header> Select(string FieldName, string FilterValue,int OrganId, int h)
        {
            return Remittance_Header.Select(FieldName, FilterValue,OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(string Title, int? fldAshkhasiId, bool fldStatus, string fldStartDate,byte[] fldFile,string fldPassvand, string fldEndDate, System.Data.DataTable detail, int userId, int OrganId, string DescHeader,int? OrganizationalUint,int Receiver, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (DescHeader == null)
                DescHeader = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Receiver == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تحویل گیرنده ضروری است";
            }
            else if (fldAshkhasiId == null && OrganizationalUint==null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شخص/واحد سازمانی ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (fldStartDate == "" || fldStartDate == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ شروع ضروری است";
            }
            else if (fldEndDate == "" || fldEndDate == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ پایان ضروری است";
            }
            else if (!r.IsMatch(fldStartDate))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ شروع را به درستی وارد کنید";
            }
            else if (!r.IsMatch(fldEndDate))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ پایان را به درستی وارد کنید";
            }
            else if (Title == "" || Title == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان حواله ضروری است";
            }
            else if (Title.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان حواله وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان حواله وارده شده بیشتر از حد مجاز می باشد.";
            }
            for (int i = 0; i < detail.Rows.Count; i++)
            {
                if (Convert.ToInt32(detail.Rows[i]["fldKalaId"]) == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد کالا ضروری است";
                }
                else if (Convert.ToInt32(detail.Rows[i]["fldMaxTon"]) == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "حداکثر تن ضروری است";
                }
                else if (Convert.ToInt32(detail.Rows[i]["fldMaxTon"]) > 2147483648)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "حداکثر تن وارد شده بیشتر از حد مجاز است";
                }
            }

            if (error.ErrorType == true)
                return "خطا";

            return Remittance_Header.Insert(Title, fldAshkhasiId, fldStatus,fldFile,fldPassvand, fldStartDate, fldEndDate, detail, userId, OrganId, DescHeader, OrganizationalUint, Receiver, IP);

        }
        #endregion
        #region Update
        public string Update(int fldHeaderId,string Title, int? fldAshkhasiId, bool fldStatus,byte[] fldFile,string fldPassvand,
            int? fldFileId, string fldStartDate, string fldEndDate, System.Data.DataTable detail, int userId, int OrganId, string DescHeader,int? OrganizationalUint,int Receiver, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (DescHeader == null)
                DescHeader = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldHeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد حواله ضروری است";
            }
            else if (Receiver == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تحویل گیرنده ضروری است";
            }
            else if (fldAshkhasiId == null && OrganizationalUint == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شخص/واحد سازمانی ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (Title == "" || Title == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان حواله ضروری است";
            }
            else if (Title.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان حواله وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان حواله وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldStartDate == "" || fldStartDate == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ شروع ضروری است";
            }
            else if (fldEndDate == "" || fldEndDate == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ پایان ضروری است";
            }
            else if (!r.IsMatch(fldStartDate))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ شروع را به درستی وارد کنید";
            }
            else if (!r.IsMatch(fldEndDate))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ پایان را به درستی وارد کنید";
            }
            for (int i = 0; i < detail.Rows.Count; i++)
            {
                if (Convert.ToInt32(detail.Rows[i]["fldKalaId"]) == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد کالا ضروری است";
                }
                else if (Convert.ToInt32(detail.Rows[i]["fldMaxTon"]) == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "حداکثر تن ضروری است";
                }
                else if (Convert.ToInt32(detail.Rows[i]["fldMaxTon"]) > 2147483648)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "حداکثر تن وارد شده بیشتر از حد مجاز است";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return Remittance_Header.Update(fldHeaderId, Title, fldAshkhasiId, fldStatus, fldStartDate, fldEndDate,fldFile,fldPassvand,fldFileId, detail, userId, OrganId, DescHeader, OrganizationalUint, Receiver, IP);

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

            return Remittance_Header.Delete(id, userId);
        }
        #endregion

        #region SelectSumKalaHavale
        public List<OBJ_KalaHavale> SelectSumKalaHavale(string FieldName, string FilterValue, int HavaleId)
        {
            return Remittance_Header.SelectSumKalaHavale(FieldName, FilterValue, HavaleId);
        }
        #endregion

        #region SelectSumKalaHavale_Detail
        public List<OBJ_SumKalaHavale_Detail> SelectSumKalaHavale_Detail(string FieldName, string FilterValue, int HavaleId, int IdKala)
        {
            return Remittance_Header.SelectSumKalaHavale_Detail(FieldName,FilterValue,HavaleId, IdKala);
        }
        #endregion
    }
}