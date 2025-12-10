using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_PcPosUser
    {
        DL_PcPosUser PcPosUser = new DL_PcPosUser();

        #region Detail
        public OBJ_PcPosUser Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return PcPosUser.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_PcPosUser> Select(string FieldName, string FilterValue, int h)
        {
            return PcPosUser.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int PosIpId, int IdUser, int userId, string Desc, out ClsError error)
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
            else if (IdUser == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (PosIpId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد مشخصات دستگاه pc pos ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PcPosUser.Insert(PosIpId, IdUser, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int PosIpId, int IdUser, int userId, string Desc, out ClsError error)
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
            else if (IdUser == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (PosIpId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد مشخصات دستگاه pc pos ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PcPosUser.Update(Id, PosIpId, IdUser, userId, Desc);

        }
        #endregion
        #region Delete
        public string Delete(string FieldName, int id, int userId, out ClsError error)
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

            return PcPosUser.Delete(FieldName, id, userId);
        }
        #endregion
    }
}