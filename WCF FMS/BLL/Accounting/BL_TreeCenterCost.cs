using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_TreeCenterCost
    {
        DL_TreeCenterCost TreeCenterCost = new DL_TreeCenterCost();

        #region Detail
        public OBJ_TreeCenterCost Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return TreeCenterCost.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_TreeCenterCost> Select(string FieldName, string FilterValue, string FilterValue2, int OrganId, int h)
        {
            return TreeCenterCost.Select(FieldName, FilterValue, FilterValue2, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(string Name, int? PID, int GroupCenterCoId, int OrganId, int UserId, string IP, string Desc, out ClsError error)
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
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (Name == "" || Name == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (GroupCenterCoId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد گروه مراکز هزینه ضروری است";
            }
            else if (Name.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Name.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TreeCenterCost.Insert(Name, PID, GroupCenterCoId, OrganId, UserId, IP, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string Name, int GroupCenterCoId, int OrganId, int UserId, string IP, string Desc, out ClsError error)
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
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (Name == "" || Name == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (GroupCenterCoId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد گروه مراکز هزینه ضروری است";
            }
            else if (Name.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Name.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return TreeCenterCost.Update(Id, Name, GroupCenterCoId, OrganId, UserId, IP, Desc);

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

            return TreeCenterCost.Delete(id, userId);
        }
        #endregion
        
        #region UpdatePID_CostCenter
        public string UpdatePID_CostCenter(int Child, int Parent, int UserId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (error.ErrorType == true)
                return "خطا";

            return TreeCenterCost.UpdatePID_CostCenter(Child, Parent, UserId);

        }
        #endregion

        #region Centerco_TarifNashodeh
        public List<OBJ_Centerco_TarifNashodeh> Centerco_TarifNashodeh(int GroupCenterCoId)
        {
            return TreeCenterCost.Centerco_TarifNashodeh(GroupCenterCoId);
        }
        #endregion
    }
}