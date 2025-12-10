using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Deceased;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.BLL.Deceased
{
    public class BL_GhabreAmanat
    {
        DL_GhabreAmanat GhabreAmanat = new DL_GhabreAmanat();

        #region Detail
        public OBJ_GhabreAmanat Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return GhabreAmanat.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_GhabreAmanat> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return GhabreAmanat.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int? fldShomareId, int? fldEmployeeId, string fldTarikhRezerv, int userId, int OrganId, string Desc, string IP, out ClsError error)
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
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            //else if (fldShomareId == 0)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "کد شماره ضروری است";
            //}
            //else if (fldEmployeeId == 0)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "کد کارمند ضروری است";
            //}
            //else if (fldTarikhRezerv == null || fldTarikhRezerv == "")
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "تاریخ ضروری است";
            //}
            //else if (!r.IsMatch(fldTarikhRezerv))
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            //}
            else if (GhabreAmanat.CheckRepeatedRow(fldEmployeeId, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return GhabreAmanat.Insert(fldShomareId, fldEmployeeId, OrganId, fldTarikhRezerv, userId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int fldId, int? fldShomareId, int? fldEmployeeId, string fldTarikhRezerv, int userId, int OrganId, string Desc, string IP, out ClsError error)
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
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (fldId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شهر ضروری است";
            }
            //else if (fldShomareId == 0)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "کد شماره ضروری است";
            //}
            //else if (fldEmployeeId == 0)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "کد کارمند ضروری است";
            //}
            //else if (fldTarikhRezerv == null || fldTarikhRezerv == "")
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "تاریخ ضروری است";
            //}
            //else if (!r.IsMatch(fldTarikhRezerv))
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            //}
            else if (GhabreAmanat.CheckRepeatedRow(fldEmployeeId, fldId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return GhabreAmanat.Update(fldId, fldShomareId, fldEmployeeId, OrganId, fldTarikhRezerv, userId, Desc, IP);

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
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (GhabreAmanat.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است لذا مجاز به حذف نمی باشید.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return GhabreAmanat.Delete(id, userId);
        }
        #endregion
        #region RptGhabrPor_Khali
        public List<OBJ_GhabrPor_Khali> RptGhabrPor_Khali(string FieldName, int VadiId, int GheteId, int RadifId, int ShomareId, int OrganId)
        {
            return GhabreAmanat.RptGhabrPor_Khali(FieldName, VadiId,GheteId,RadifId,ShomareId, OrganId);
        }
        #endregion
        #region SelectInfoEmployeeInGhabrAmanat
        public List<OBJ_EmployeeInGhabrAmanat> SelectInfoEmployeeInGhabrAmanat(int ShomareId, byte ShomareTabaghe)
        {
            return GhabreAmanat.SelectInfoEmployeeInGhabrAmanat(ShomareId, ShomareTabaghe);
        }
        #endregion
    }
}