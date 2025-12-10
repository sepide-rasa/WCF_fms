using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_Coding_Header
    {
        DL_Coding_Header Coding_Header = new DL_Coding_Header();
        #region Detail
        public OBJ_Coding_Header Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Coding_Header.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Coding_Header> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return Coding_Header.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(short Year, int OrganId, int UserId, string IP, string Desc, out ClsError error)
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
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (Year == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال ضروری است";
            }
            else if (Coding_Header.CheckRepeatedRow(Year, OrganId, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Coding_Header.Insert(Year,OrganId, UserId, IP, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, short Year, int OrganId, int UserId, string IP, string Desc, out ClsError error)
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
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد جهت ویرایش ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (Year == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال ضروری است";
            }
            else if (Coding_Header.CheckRepeatedRow(Year, OrganId, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Coding_Header.Update(Id ,Year, OrganId, UserId, IP, Desc);

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
            else if (Coding_Header.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Coding_Header.Delete(id, userId);
        }
        #endregion
        #region CopyFromTemplateCodingToCoding
        public string CopyFromTemplateCodingToCoding(int HeaderId, int TempNameId,System.Data.DataTable IncomeCodes, int UserId, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (TempNameId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نام الگو ضروری است";
            }
            else if (HeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد Header ضروری است";
            }

            if (error.ErrorType == true)
                return "خطا";

            return Coding_Header.CopyFromTemplateCodingToCoding(HeaderId, TempNameId,IncomeCodes, UserId, IP);

        }
        #endregion
        
    }
}