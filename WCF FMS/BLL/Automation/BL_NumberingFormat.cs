using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_NumberingFormat
    {
        DL_NumberingFormat NumberingFormat = new DL_NumberingFormat();

        #region Detail
        public OBJ_NumberingFormat Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return NumberingFormat.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_NumberingFormat> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return NumberingFormat.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int Year, int SecretariatID, string NumberFormat, int StartNumber, int OrganID, int UserId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (SecretariatID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد دبیرخانه ضروری است";
            }
            else if (NumberingFormat.CheckRepeatedRow(Year, SecretariatID, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return NumberingFormat.Insert(Year, SecretariatID, NumberFormat, StartNumber, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, int Year, int SecretariatID, string NumberFormat, int StartNumber, int OrganID, int UserId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (SecretariatID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد دبیرخانه ضروری است";
            }
            else if (NumberingFormat.CheckRepeatedRow(Year, SecretariatID, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return NumberingFormat.Update(Id, Year, SecretariatID, NumberFormat, StartNumber, OrganID, UserId, Desc, IP);

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

            return NumberingFormat.Delete(id, userId);
        }
        #endregion
    }
}