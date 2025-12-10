using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_GozareshatFile
    {
        DL_GozareshatFile GozareshatFile = new DL_GozareshatFile();

        #region Detail
        public OBJ_GozareshatFile Detail(int id, string OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return GozareshatFile.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_GozareshatFile> Select(string FieldName, string FilterValue, string OrganId, int h)
        {
            return GozareshatFile.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int GozareshatId, int OrganId, byte[] file, string passvand, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (GozareshatId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد گزارش ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پست سازمانی ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return GozareshatFile.Insert(GozareshatId, OrganId, file, passvand, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int GozareshatId, int OrganId, int ReportFileId, byte[] file, string passvand, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (GozareshatId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد گزارش ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پست سازمانی ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return GozareshatFile.Update(Id, GozareshatId, OrganId, ReportFileId, file, passvand, userId, Desc);

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
            if (error.ErrorType == true)
                return "خطا";

            return GozareshatFile.Delete(id, userId);
        }
        #endregion
        #region SelectGozareshat
        public List<OBJ_GozareshatFile> SelectGozareshat(string FieldName, string FilterValue, int h)
        {
            return GozareshatFile.SelectGozareshat(FieldName, FilterValue, h);
        }
        #endregion
    }
}