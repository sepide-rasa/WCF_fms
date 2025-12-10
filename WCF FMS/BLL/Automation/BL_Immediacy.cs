using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_Immediacy
    {
        DL_Immediacy Immediacy = new DL_Immediacy();

        #region Detail
        public OBJ_Immediacy Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Immediacy.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Immediacy> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return Immediacy.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(string Name, byte[] Image, string Passvand, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (Name == "" || Name == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع فوریت ضروری است";
            }
            else if (Name.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نوع ارجاع وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Name.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نوع ارجاع وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Immediacy.Insert(Name, Image, Passvand, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, string Name,int? FileId, byte[] Image, string Passvand, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
                error.ErrorMsg = "نوع فوریت ضروری است";
            }
            else if (Name.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نوع فوریت وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Name.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نوع فوریت وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Immediacy.Update(Id, Name, FileId, Image, Passvand, OrganID, UserId, Desc, IP);

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

            return Immediacy.Delete(id, userId);
        }
        #endregion
    }
}