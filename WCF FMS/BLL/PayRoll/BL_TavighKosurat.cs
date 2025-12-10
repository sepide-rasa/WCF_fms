using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_TavighKosurat
    {
        DL_TavighKosurat TavighKosurat = new DL_TavighKosurat();

        #region Detail
        public OBJ_TavighKosurat Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return TavighKosurat.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_TavighKosurat> Select(string FieldName, string FilterValue, int h)
        {
            return TavighKosurat.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int KosuratId, short Year, byte Month, int userId, string Desc, out ClsError error)
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
            else if (KosuratId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Year == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال ضروری است";
            }
            else if (Month == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "ماه ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TavighKosurat.Insert(KosuratId, Year, Month, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int KosuratId, short Year, byte Month, int userId, string Desc, out ClsError error)
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
            else if (KosuratId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Year == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال ضروری است";
            }
            else if (Month == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "ماه ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TavighKosurat.Update(Id, KosuratId, Year, Month, userId, Desc);

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

            return TavighKosurat.Delete(id, userId);
        }
        #endregion
    }
}