using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Budget;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.BLL.Budget
{
    public class BL_Project_Details
    {
        DL_Project_Details Project_Details = new DL_Project_Details();

        #region Detail
        public OBJ_Project_Details Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Project_Details.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Project_Details> Select(string FieldName, string FilterValue,short Year, int OrganId, int h)
        {
            return Project_Details.Select(FieldName, FilterValue,Year, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int Project_faaliyatId, string Address, string Mojri, short StratYear, short EndYear, int Meghdar, long GheymatVahed, long Etebar, short Year, int OrganId, int userId, string Desc, out ClsError error)
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
            else if (Project_faaliyatId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پروژه ضروری است";
            }
            else if (Year == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال ضروری است";
            }
            else if (StratYear == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال شروع ضروری است";
            }
            else if (EndYear == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال پایان ضروری است";
            }
            else if (Meghdar == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار ضروری است";
            }
            else if (GheymatVahed == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "قیمت واحد ضروری است";
            }
            else if (Etebar == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "اعتبار ضروری است";
            }
            if (Address == "" || Address == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "آدرس ضروری است";
            }
            else if (Address.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر آدرس وارد شده کمتر از حد مجاز میباشد.";
            }
            if (Mojri == "" || Mojri == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مجری ضروری است";
            }
            else if (Mojri.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر مجری وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Mojri.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر مجری وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Project_Details.Insert(Project_faaliyatId, Address, Mojri, StratYear, EndYear, Meghdar, GheymatVahed, Etebar,Year, OrganId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int Project_faaliyatId, string Address, string Mojri, short StratYear, short EndYear, int Meghdar, long GheymatVahed, long Etebar, short Year, int OrganId, int userId, string Desc, out ClsError error)
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
            else if (Project_faaliyatId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد پروژه ضروری است";
            }
            else if (Year == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال ضروری است";
            }
            else if (StratYear == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال شروع ضروری است";
            }
            else if (EndYear == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال پایان ضروری است";
            }
            else if (Meghdar == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار ضروری است";
            }
            else if (GheymatVahed == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "قیمت واحد ضروری است";
            }
            else if (Etebar == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "اعتبار ضروری است";
            }
            if (Address == "" || Address == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "آدرس ضروری است";
            }
            else if (Address.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر آدرس وارد شده کمتر از حد مجاز میباشد.";
            }
            if (Mojri == "" || Mojri == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مجری ضروری است";
            }
            else if (Mojri.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر مجری وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Mojri.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر مجری وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Project_Details.Update(Id, Project_faaliyatId, Address, Mojri, StratYear, EndYear, Meghdar, GheymatVahed, Etebar,Year, OrganId, userId, Desc);

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

            return Project_Details.Delete(id, userId);
        }
        #endregion
    }
}