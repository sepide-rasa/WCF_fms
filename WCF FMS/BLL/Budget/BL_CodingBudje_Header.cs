using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Budget;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.BLL.Budget
{
    public class BL_CodingBudje_Header
    {
        DL_CodingBudje_Header CodingBudje_Header = new DL_CodingBudje_Header();

        #region Detail
        public OBJ_CodingBudje_Header Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return CodingBudje_Header.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_CodingBudje_Header> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return CodingBudje_Header.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public int Insert(short Year, int OrganId, int userId, string Desc, string IP, out ClsError error)
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
            else if (Year == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = " سال مالی ضروری است";
            }
            if (error.ErrorType == true)
                return 0;

            return CodingBudje_Header.Insert(Year, OrganId, userId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id,short Year, int OrganId, int userId, string Desc, string IP, out ClsError error)
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
            else if (Year == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = " سال مالی ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CodingBudje_Header.Update(Id, Year, OrganId, userId, Desc, IP);

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

            return CodingBudje_Header.Delete(id, userId);
        }
        #endregion
        
    }
}