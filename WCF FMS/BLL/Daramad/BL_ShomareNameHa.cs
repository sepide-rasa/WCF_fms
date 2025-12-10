using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_ShomareNameHa
    {
        DL_ShomareNameHa ShomareNameHa = new DL_ShomareNameHa();

        #region Detail
        public OBJ_ShomareNameHa Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ShomareNameHa.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_ShomareNameHa> Select(string FieldName, string FilterValue, int h)
        {
            return ShomareNameHa.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public int Insert(Nullable<int> MokatebatId, Nullable<int> ReplyTaghsitId, int StartNumber, int userId, string Desc, out ClsError error)
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
            if (error.ErrorType == true)
                return 0;

            return ShomareNameHa.Insert(MokatebatId, ReplyTaghsitId, StartNumber, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, Nullable<int> MokatebatId, Nullable<int> ReplyTaghsitId, short Year, int Shomare, int userId, string Desc, out ClsError error)
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
                error.ErrorMsg = "سال ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ShomareNameHa.Update(Id, MokatebatId, ReplyTaghsitId, Year, Shomare, userId, Desc);

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

            return ShomareNameHa.Delete(id, userId);
        }
        #endregion
    }
}