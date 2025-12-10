using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_MohdoodiyatMohasebat_User
    {
        DL_MohdoodiyatMohasebat_User MohdoodiyatMohasebat_User = new DL_MohdoodiyatMohasebat_User();

        #region Detail
        public OBJ_MohdoodiyatMohasebat_User Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return MohdoodiyatMohasebat_User.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_MohdoodiyatMohasebat_User> Select(string FieldName, string FilterValue, int h)
        {
            return MohdoodiyatMohasebat_User.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int MahdoodiyatMohasebatId, int IdUser, int userId, string Desc, out ClsError error)
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
            else if (IdUser == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MohdoodiyatMohasebat_User.Insert(MahdoodiyatMohasebatId, IdUser, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int MahdoodiyatMohasebatId, int IdUser, int userId, string Desc, out ClsError error)
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
            else if (IdUser == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MohdoodiyatMohasebat_User.Update(Id, MahdoodiyatMohasebatId, IdUser, userId, Desc);

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

            return MohdoodiyatMohasebat_User.Delete(id, userId);
        }
        #endregion
    }
}