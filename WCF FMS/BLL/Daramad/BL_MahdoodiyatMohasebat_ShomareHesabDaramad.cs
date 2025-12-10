using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_MahdoodiyatMohasebat_ShomareHesabDaramad
    {
        DL_MahdoodiyatMohasebat_ShomareHesabDaramad MahdoodiyatMohasebat_ShomareHesabDaramad = new DL_MahdoodiyatMohasebat_ShomareHesabDaramad();

        #region Detail
        public OBJ_MahdoodiyatMohasebat_ShomareHesabDaramad Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return MahdoodiyatMohasebat_ShomareHesabDaramad.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_MahdoodiyatMohasebat_ShomareHesabDaramad> Select(string FieldName, string FilterValue, int h)
        {
            return MahdoodiyatMohasebat_ShomareHesabDaramad.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int MahdodiyatMohasebatId, int ShomarehesabDarmadId, int userId, string Desc, out ClsError error)
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
            else if (MahdodiyatMohasebatId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد محدودیت محاسبات ضروری است";
            }
            else if (ShomarehesabDarmadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب کد درآمد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MahdoodiyatMohasebat_ShomareHesabDaramad.Insert(MahdodiyatMohasebatId, ShomarehesabDarmadId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int MahdodiyatMohasebatId, int ShomarehesabDarmadId, int userId, string Desc, out ClsError error)
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
            else if (MahdodiyatMohasebatId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد محدودیت محاسبات ضروری است";
            }
            else if (ShomarehesabDarmadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب کد درآمد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MahdoodiyatMohasebat_ShomareHesabDaramad.Update(Id, MahdodiyatMohasebatId, ShomarehesabDarmadId, userId, Desc);

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

            return MahdoodiyatMohasebat_ShomareHesabDaramad.Delete(id, userId);
        }
        #endregion
    }
}