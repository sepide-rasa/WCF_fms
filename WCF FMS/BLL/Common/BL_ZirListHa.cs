using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;


namespace WCF_FMS.BLL.Common
{
    public class BL_ZirListHa
    {
        DL_ZirListHa ZirListHa = new DL_ZirListHa();

        #region Detail
        public OBJ_ZirListHa Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد زیرلیست ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ZirListHa.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_ZirListHa> Select(string FieldName, string FilterValue, int h)
        {
            return ZirListHa.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldReportId, int fldMasuolin_DetailId, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            var q = ZirListHa.Select("fldReportId", fldReportId.ToString(), 0).Where(l => l.fldMasuolin_DetailId == fldMasuolin_DetailId).FirstOrDefault();
            if (q != null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "داده مورد نظر قبلا در سیستم ثبت شده است.";
            }
            else
            {
                if (Desc == null)
                    Desc = "";
                if (userId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "شناسه کاربر ضروری است";
                }
                if (fldReportId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد گزارش ضروری است";
                }
                if (fldMasuolin_DetailId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد جزئیات مسئولین ضروری است";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return ZirListHa.Insert(fldReportId,fldMasuolin_DetailId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int fldId, int fldReportId, int fldMasuolin_DetailId, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            var q = ZirListHa.Select("fldReportId", fldReportId.ToString(), 0).Where(l => l.fldMasuolin_DetailId == fldMasuolin_DetailId).FirstOrDefault();
            if (q != null && q.fldId != fldId)
            {
                error.ErrorType = true;
                error.ErrorMsg = "داده مورد نظر قبلا در سیستم ثبت شده است.";
            }
            else
            {
                if (Desc == null)
                    Desc = "";
                if (userId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "شناسه کاربر ضروری است";
                }
                if (fldId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد زیرلیست ضروری است";
                }
                if (fldReportId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد گزارش ضروری است";
                }
                if (fldMasuolin_DetailId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد جزئیات مسئولین ضروری است";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return ZirListHa.Update(fldId, fldReportId, fldMasuolin_DetailId, userId, Desc);

        }
        #endregion
        #region Delete
        public string Delete(string FieldName, int id, int userId, out ClsError error)
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
                error.ErrorMsg = "کد زیرلیست ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ZirListHa.Delete(FieldName, id, userId);
        }
        #endregion
    }
}