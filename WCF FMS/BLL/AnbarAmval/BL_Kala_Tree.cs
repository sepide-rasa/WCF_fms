using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.AnbarAmval;

namespace WCF_FMS.BLL.AnbarAmval
{
    public class BL_Kala_Tree
    {
        DL_Kala_Tree Kala_Tree = new DL_Kala_Tree();
        public string Insert(int KalaId, int KalaTreeId, int UserId, int OrganId, string IP, string Desc, out ClsError error)
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
                error.ErrorMsg = "شناسه سازمان ضروری است";
            }
            else if (KalaId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کالا ضروری است";
            }
            else if (KalaTreeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ساختار درختی گروه کالا ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";
            return Kala_Tree.Insert(KalaId, KalaTreeId, UserId, OrganId, IP, Desc);
        }

        #region UpdatePID_kala
        public string UpdatePID_kala(int Child, int Parent, int UserId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Kala_Tree.UpdatePID_kala(Child, Parent, UserId);

        }
        #endregion
    }
}