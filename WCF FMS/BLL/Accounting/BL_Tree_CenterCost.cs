using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_Tree_CenterCost
    {
        DL_Tree_CenterCost Tree_CenterCost = new DL_Tree_CenterCost();

        #region Detail
        public OBJ_Tree_CenterCost Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Tree_CenterCost.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Tree_CenterCost> Select(string FieldName, string FilterValue, int h)
        {
            return Tree_CenterCost.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int CenterCoId, int CostTreeId, int UserId, string IP, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (CenterCoId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد مرکز هزینه ضروری است";
            }
            else if (CostTreeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ساختار درختی ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Tree_CenterCost.Insert(CenterCoId, CostTreeId, UserId, IP, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int CenterCoId, int CostTreeId, int UserId, string IP, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد جهت ویرایش ضروری است";
            }
            else if (CenterCoId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد مرکز هزینه ضروری است";
            }
            else if (CostTreeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ساختار درختی ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Tree_CenterCost.Update(Id, CenterCoId, CostTreeId, UserId, IP, Desc);

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
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Tree_CenterCost.Delete(id, userId);
        }
        #endregion
    }
}