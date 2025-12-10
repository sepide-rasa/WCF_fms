using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.DAL.Deceased;

namespace WCF_FMS.BLL.Deceased
{
    public class BL_InsertEmploye
    {
        DL_InsertEmploye Employee = new DL_InsertEmploye();
        #region Insert
        public int Insert(string CodeMeli, string CodeMoshakhase, string Name, string Family, string Sh_Sh, string NameFather, int userId, string Desc,string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            int chck = 1;
            if (Desc == null)
                Desc = "";

            if (CodeMeli != null )
            {
                chck = new BL().checkCodeMeli(CodeMeli);
                if (chck != 1)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد ملی وارد شده معتبر نمی باشد.";
                }
                
            }


            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Name == "" || Name == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام ضروری است";
            }
            else if (Name.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Name.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Family == "" || Family == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام خانوادگی ضروری است";
            }
            else if (Family.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام خانوادگی وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Family.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام خانوادگی وارده شده بیشتر از حد مجاز می باشد.";
            }

            if (error.ErrorType == true)
                return 0;

            return Employee.Insert(CodeMeli,CodeMoshakhase,Name, Family,Sh_Sh,NameFather,  userId, Desc,IP);

        }
        #endregion
    }
}