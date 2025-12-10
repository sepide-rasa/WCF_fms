using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Deceased;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.BLL.Deceased
{
    public class BL_Action_Kartabl
    {
        DL_Action_Kartabl Action_Kartabl = new DL_Action_Kartabl();

        #region Detail
        public OBJ_Action_Kartabl Detail(int id, int organId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Action_Kartabl.Detail(id, organId);
        }
        #endregion
        #region Select
        public List<OBJ_Action_Kartabl> Select(string FieldName, string FilterValue, int organId, int h)
        {
            return Action_Kartabl.Select(FieldName, FilterValue, organId, h);
        }
        #endregion
        #region Insert
        public string Insert(int ActionId, int KartablId, int organId, int userId, string Desc, string IP, out ClsError error)
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
            else if (ActionId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اقدام ضروری است";
            }
            else if (KartablId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کارتابل ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Action_Kartabl.Insert(ActionId, KartablId, organId, userId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int fldId, int ActionId, int KartablId, int organId, int userId, string Desc, string IP, out ClsError error)
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
            else if (ActionId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اقدام ضروری است";
            }
            else if (KartablId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کارتابل ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Action_Kartabl.Update(fldId, ActionId,KartablId, organId, userId, Desc, IP);

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

            return Action_Kartabl.Delete(id, userId);
        }
        #endregion
    }
}