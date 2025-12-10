using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_MahdoodiyatMohasebat_Ashkhas
    {
        DL_MahdoodiyatMohasebat_Ashkhas MahdoodiyatMohasebat_Ashkhas = new DL_MahdoodiyatMohasebat_Ashkhas();

        #region Detail
        public OBJ_MahdoodiyatMohasebat_Ashkhas Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return MahdoodiyatMohasebat_Ashkhas.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_MahdoodiyatMohasebat_Ashkhas> Select(string FieldName, string FilterValue, int h)
        {
            return MahdoodiyatMohasebat_Ashkhas.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int MahdoodiyatMohasebatId, int AshkhasId, int userId, string Desc, out ClsError error)
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
            else if (MahdoodiyatMohasebatId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد محدودیت محاسبات ضروری است";
            }
            else if (AshkhasId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اشخاص ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MahdoodiyatMohasebat_Ashkhas.Insert(MahdoodiyatMohasebatId, AshkhasId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int MahdoodiyatMohasebatId, int AshkhasId, int userId, string Desc, out ClsError error)
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
            else if (MahdoodiyatMohasebatId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد محدودیت محاسبات ضروری است";
            }
            else if (AshkhasId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اشخاص ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MahdoodiyatMohasebat_Ashkhas.Update(Id, MahdoodiyatMohasebatId, AshkhasId, userId, Desc);

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

            return MahdoodiyatMohasebat_Ashkhas.Delete(id, userId);
        }
        #endregion
    }
}