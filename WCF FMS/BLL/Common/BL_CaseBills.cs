using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_CaseBills
    {
        DL_CaseBills CaseBills = new DL_CaseBills();

        #region Detail
        public OBJ_CaseBills Detail(int id,int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return CaseBills.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_CaseBills> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return CaseBills.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int BillsTypeId, int FileNum, int CentercoId, int OrganId, int OrganChartId, int? AshkhasId, int userId, string Desc, string IP, out ClsError error)
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
            else if (BillsTypeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد انواع قبوض ضروری است";
            }
            else if (FileNum == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره پرونده ضروری است";
            }
            else if (CentercoId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد مرکز هزینه ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (OrganChartId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد چارت سازمانی ضروری است";
            }
            else if (CaseBills.CheckRepeatedRow(FileNum, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره پرونده وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CaseBills.Insert(BillsTypeId, FileNum, CentercoId, OrganId, OrganChartId, AshkhasId, IP, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int BillsTypeId, int FileNum, int CentercoId, int OrganId, int OrganChartId, int? AshkhasId, int userId, string Desc, string IP, out ClsError error)
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
                error.ErrorMsg = "کد قبوض پرونده جهت ویرایش ضروری است";
            }
            else if (BillsTypeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد انواع قبوض ضروری است";
            }
            else if (FileNum == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره پرونده ضروری است";
            }
            else if (CentercoId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد مرکز هزینه ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (OrganChartId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد چارت سازمانی ضروری است";
            }
            else if (CaseBills.CheckRepeatedRow(FileNum, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره پرونده وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CaseBills.Update(Id, BillsTypeId, FileNum, CentercoId, OrganId, OrganChartId, AshkhasId, IP, userId, Desc);

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
                error.ErrorMsg = "کد استان ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CaseBills.Delete(id, userId);
        }
        #endregion
    }
}