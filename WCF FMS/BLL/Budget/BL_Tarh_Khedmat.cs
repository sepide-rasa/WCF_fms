using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Budget;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.BLL.Budget
{
    public class BL_Tarh_Khedmat
    {
        DL_Tarh_Khedmat Tarh_Khedmat = new DL_Tarh_Khedmat();
        #region Detail
        public OBJ_Tarh_Khedmat Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Tarh_Khedmat.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Tarh_Khedmat> Select(string FieldName, string FilterValue, string FilterValue2,short Year, int OrganId, int h)
        {
            return Tarh_Khedmat.Select(FieldName, FilterValue, FilterValue2, OrganId,Year, h);
        }
        #endregion
        #region Insert
        public string Insert(int ProgramId, string Code, string Title,byte Type,short Year, int OrganId, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (ProgramId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد برنامه ضروری است";
            }
            else if (Year == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال ضروری است";
            }
            else if (Code == "" || Code == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد طرح-خدمت ضروری است";
            }
            if (Title == "" || Title == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Title.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Tarh_Khedmat.CheckRepeatedRow(Code, Title,Year,OrganId, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Tarh_Khedmat.Insert(ProgramId, Code, Title, Type,Year, OrganId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int ProgramId, string Code, string Title, byte Type,short Year, int OrganId, int userId, string Desc, out ClsError error)
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
            if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (Year == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (ProgramId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد برنامه ضروری است";
            }
            else if (Code == "" || Code == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد طرح-خدمت ضروری است";
            }
            if (Title == "" || Title == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Title.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Tarh_Khedmat.CheckRepeatedRow(Code, Title,Year,OrganId, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Tarh_Khedmat.Update(Id, ProgramId, Code, Title, Type,Year, OrganId, userId, Desc);

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
            else if (Tarh_Khedmat.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Tarh_Khedmat.Delete(id, userId);
        }
        #endregion
    }
}