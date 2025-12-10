using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.AnbarAmval;
using WCF_FMS.TOL.AnbarAmval;

namespace WCF_FMS.BLL.AnbarAmval
{
    public class BL_Anbar
    {
        DL_Anbar Anbar = new DL_Anbar();

        #region Detail
        public OBJ_Anbar Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Anbar.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Anbar> Select(string FieldName, string FilterValue, int h)
        {
            return Anbar.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string Name, string Address, string Phone, string AnbarTreeId, int UserId, string IP, string Desc, out ClsError error)
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
            else if (Name == "" || Name == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام انبار ضروری است";
            }
            else if (Phone == "" || Phone == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تلفن ضروری است";
            }
            else if (Name.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام انبار وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Name.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام انبار وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Phone.Length < 8)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر تلفن وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Phone.Length > 11)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر تلفن وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Anbar.CheckRepeatedRow(Name))
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام انبار وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Anbar.Insert(Name, Address, Phone,AnbarTreeId, UserId, IP, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string Name, string Address, string Phone, string AnbarTreeId, int UserId, string IP, string Desc, out ClsError error)
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
            else if (Name == "" || Name == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام انبار ضروری است";
            }
            else if (Phone == "" || Phone == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تلفن ضروری است";
            }
            else if (Name.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام انبار وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Name.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام انبار وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Phone.Length < 8)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر تلفن وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Phone.Length > 11)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر تلفن وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Anbar.CheckExistsAnbar(Id, AnbarTreeId) == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Anbar.Update(Id, Name, Address, Phone, AnbarTreeId, UserId, IP, Desc);

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

            return Anbar.Delete(id, userId);
        }
        #endregion
        #region UpdatePID_Anbar
        public string UpdatePID_Anbar(int Child, int Parent,int UserId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            
            if (error.ErrorType == true)
                return "خطا";

            return Anbar.UpdatePID_Anbar(Child, Parent,UserId);

        }
        #endregion
        #region UpdatePID_Anbar_Tree
        public string UpdatePID_Anbar_Tree(int Anbar_TreeId, int Parent, int UserId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }

            if (error.ErrorType == true)
                return "خطا";

            return Anbar.UpdatePID_Anbar_Tree(Anbar_TreeId, Parent, UserId);

        }
        #endregion
    }
}