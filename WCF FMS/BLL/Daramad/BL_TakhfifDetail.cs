using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_TakhfifDetail
    {
        DL_TakhfifDetail TakhfifDetail = new DL_TakhfifDetail();

        #region Detail
        public OBJ_TakhfifDetail Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return TakhfifDetail.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_TakhfifDetail> Select(string FieldName, string FilterValue, int h)
        {
            return TakhfifDetail.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int TakhfifId, int ShCodeDaramad, int userId, string Desc, out ClsError error)
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
            else if (TakhfifId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد تخفیف ضروری است";
            }
            else if (ShCodeDaramad == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره کد درآمد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TakhfifDetail.Insert(TakhfifId, ShCodeDaramad, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int TakhfifId, int ShCodeDaramad, int userId, string Desc, out ClsError error)
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
            else if (TakhfifId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد تخفیف ضروری است";
            }
            else if (ShCodeDaramad == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره کد درآمد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TakhfifDetail.Update(Id, TakhfifId, ShCodeDaramad, userId, Desc);

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

            return TakhfifDetail.Delete(id, userId);
        }
        #endregion
    }
}