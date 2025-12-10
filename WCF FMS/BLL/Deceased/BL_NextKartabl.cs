using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Deceased;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.BLL.Deceased
{
    public class BL_NextKartabl
    {
        DL_NextKartabl NextKartabl = new DL_NextKartabl();

        #region Detail
        public OBJ_NextKartabl Detail(int id, int organId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return NextKartabl.Detail(id, organId);
        }
        #endregion
        #region Select
        public List<OBJ_NextKartabl> Select(string FieldName, string FilterValue, int organId, int h)
        {
            return NextKartabl.Select(FieldName, FilterValue, organId, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldKartablNextId, int ActionId, int organId, int userId, string Desc, string IP, out ClsError error)
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
            else if (fldKartablNextId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کارتابل ضروری است";
            }
            else if (ActionId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اقدام ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return NextKartabl.Insert(fldKartablNextId, ActionId, organId, userId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int fldId, int fldKartablNextId, int ActionId, int organId, int userId, string Desc, string IP, out ClsError error)
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
            else if (fldKartablNextId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کارتابل ضروری است";
            }
            else if (ActionId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اقدام ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return NextKartabl.Update(fldId, fldKartablNextId, ActionId, organId, userId, Desc, IP);

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

            return NextKartabl.Delete(id, userId);
        }
        #endregion
    }
}