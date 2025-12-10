using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Weigh;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.BLL.Weigh
{
    public class BL_ParametrsBaskool
    {
        DL_ParametrsBaskool ParametrsBaskool = new DL_ParametrsBaskool();

        #region Select
        public List<OBJ_ParametrsBaskool> Select(string FieldName, string FilterValue, int h)
        {
            return ParametrsBaskool.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string EnName, string FaName, int userId, string Desc, string IP, out ClsError error)
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

            else if (EnName == "" || EnName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام انگلیسی ضروری است";
            }
            else if (EnName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام انگلیسی وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (EnName.Length > 300)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام انگلیسی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (FaName == "" || FaName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام فارسی ضروری است";
            }
            else if (FaName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام فارسی وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (FaName.Length > 400)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام فارسی وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ParametrsBaskool.Insert(EnName, FaName, userId, Desc, IP);

        }
        #endregion
    }
}