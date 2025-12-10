using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_Company
    {
        DL_Company Company = new DL_Company();

        #region Detail
        public OBJ_Company Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Company.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Company> Select(string FieldName, string FilterValue, int h)
        {
            return Company.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string Title, string ShenaseMeli, int KarbarId, string URL, string UserNameService, string PassService,int? OrganId, int userId, string Desc, out ClsError error)
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
            else if (Title == "" || Title == null)
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
            else if (ShenaseMeli.Length > 11)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه ملی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ShenaseMeli.Length < 11)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه ملی وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (KarbarId ==0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Company.Insert(Title, ShenaseMeli, KarbarId, URL, UserNameService, PassService, OrganId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string Title, string ShenaseMeli, int KarbarId, string URL, string UserNameService, string PassService, int? OrganId, int userId, string Desc, out ClsError error)
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
            else if (Title == "" || Title == null)
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
            else if (ShenaseMeli.Length > 11)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه ملی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ShenaseMeli.Length < 11)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه ملی وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (KarbarId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Company.Update(Id, Title, ShenaseMeli, KarbarId, URL, UserNameService, PassService, OrganId, userId, Desc);

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
            else if (Company.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Company.Delete(id, userId);
        }
        #endregion
    }
}