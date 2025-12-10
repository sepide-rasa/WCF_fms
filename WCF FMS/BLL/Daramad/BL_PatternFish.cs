using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_PatternFish
    {
        DL_PatternFish PatternFish = new DL_PatternFish();

        #region Detail
        public OBJ_PatternFish Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return PatternFish.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_PatternFish> Select(string FieldName, string FilterValue, int h)
        {
            return PatternFish.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string Name, byte[] File, string pasvand, int userId, string Desc, out ClsError error)
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
            else if (Name == "" || Name == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Name.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Name.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PatternFish.Insert(Name, File, pasvand, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string Name, int FileId, byte[] File, string pasvand, int userId, string Desc, out ClsError error)
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
            else if (Name == "" || Name == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Name.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Name.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PatternFish.Update(Id, Name, FileId, File, pasvand, userId, Desc);

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

            return PatternFish.Delete(id, userId);
        }
        #endregion
    }
}