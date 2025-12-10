using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_CharacterPersianPlaque
    {
        DL_CharacterPersianPlaque CharacterPersianPlaque = new DL_CharacterPersianPlaque();

        #region Detail
        public OBJ_CharacterPersianPlaque Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد استان ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return CharacterPersianPlaque.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_CharacterPersianPlaque> Select(string FieldName, string FilterValue, int h)
        {
            return CharacterPersianPlaque.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldName, int userId, string Desc,string IP, out ClsError error)
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
                if (fldName == "" || fldName == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "حروف پلاک ضروری است";
                }
                else if (fldName.Length > 1)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
                }
                else if (CharacterPersianPlaque.CheckRepeatedRow(fldName, 0))
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "اطلاعات وارد شده تکراری است";
                }
            if (error.ErrorType == true)
                return "خطا";

            return CharacterPersianPlaque.Insert(fldName, userId, Desc,IP);

        }
        #endregion
        #region Update
        public string Update(int fldId, string fldName, int userId, string Desc, string IP, out ClsError error)
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
                if (fldId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد ضروری است";
                }
                if (fldName == "" || fldName == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "حروف پلاک ضروری است";
                }
                else if (fldName.Length > 1)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
                }
                else if (CharacterPersianPlaque.CheckRepeatedRow(fldName, fldId))
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "اطلاعات وارد شده تکراری است";
                }
            if (error.ErrorType == true)
                return "خطا";

            return CharacterPersianPlaque.Update(fldId, fldName, userId, Desc,IP);

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

            return CharacterPersianPlaque.Delete(id, userId);
        }
        #endregion
    }
}