using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_CenterCost
    {
        DL_CenterCost CenterCost = new DL_CenterCost();

        #region Detail
        public OBJ_CenterCost Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return CenterCost.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_CenterCost> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return CenterCost.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(string NameCenter, int OrganId, int UserId, string IP, string Desc, out ClsError error)
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
            else if (OrganId==0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (NameCenter == "" || NameCenter == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام مرکز هزینه ضروری است";
            }
            else if (NameCenter.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (NameCenter.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (CenterCost.CheckRepeatedRow(NameCenter, OrganId, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CenterCost.Insert(NameCenter, OrganId, UserId, IP, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string NameCenter, int OrganId, int UserId, string IP, string Desc, out ClsError error)
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
                error.ErrorMsg = "کد مراکز هزینه جهت ویرایش ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (NameCenter == "" || NameCenter == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام مرکز هزینه ضروری است";
            }
            else if (NameCenter.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (NameCenter.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (CenterCost.CheckRepeatedRow(NameCenter, OrganId, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CenterCost.Update(Id, NameCenter,OrganId, UserId, IP, Desc);

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
            else if (CenterCost.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CenterCost.Delete(id, userId);
        }
        #endregion
        #region UpdatePID_Cost_Tree
        public string UpdatePID_Cost_Tree(int Cost_TreeId, int Parent, int UserId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (error.ErrorType == true)
                return "خطا";

            return CenterCost.UpdatePID_Cost_Tree(Cost_TreeId, Parent, UserId);

        }
        #endregion
        public int IsCostCenter(int CodingId, out ClsError error)
        {
            error = new ClsError();
            if (error.ErrorType == true)
                return 2;
            return CenterCost.IsCostCenter(CodingId);
        }
    }
}