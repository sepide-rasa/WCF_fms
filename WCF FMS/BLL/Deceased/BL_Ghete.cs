using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Deceased;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.BLL.Deceased
{
    public class BL_Ghete
    {
        DL_Ghete Ghete = new DL_Ghete();

        #region Detail
        public OBJ_Ghete Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Ghete.Detail(id,OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Ghete> Select(string FieldName, string FilterValue, int id, int OrganId, int h)
        {
            return Ghete.Select(FieldName, FilterValue,id,OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldVadiSalamId, string fldNameGhete, int Radif, int Shomare, string Tabaghe, int userId, int OrganId, string Desc, string IP, out ClsError error)
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
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (fldVadiSalamId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد وادی السلام ضروری است";
            }
            else if (Radif == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "ردیف ضروری است";
            }
            else if (Shomare == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره ضروری است";
            }
            else if (Tabaghe == "" || Tabaghe == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "طبقه ضروری است";
            }
            else if (fldNameGhete == "" || fldNameGhete == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام قطعه ضروری است";
            }
            else if (fldNameGhete.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام قطعه وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldNameGhete.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام قطعه وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Ghete.CheckRepeatedRow(fldVadiSalamId,fldNameGhete, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Ghete.Insert(fldVadiSalamId,fldNameGhete,Radif,Shomare,Tabaghe, userId, Desc, IP,OrganId);

        }
        #endregion
        #region Update
        public string Update(int fldId, int fldVadiSalamId, string fldNameGhete, int userId,int OrganId, string Desc, string IP, out ClsError error)
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
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (fldId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (fldVadiSalamId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد وادی السلام ضروری است";
            }
            else if (fldNameGhete == "" || fldNameGhete == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام قطعه ضروری است";
            }
            else if (fldNameGhete.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام قطعه وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldNameGhete.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام قطعه وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Ghete.CheckRepeatedRow(fldVadiSalamId, fldNameGhete, fldId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Ghete.Update(fldId, fldVadiSalamId,fldNameGhete, userId, Desc, IP,OrganId);

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
            else if (Ghete.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است لذا مجاز به حذف نمی باشید.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Ghete.Delete(id, userId);
        }
        #endregion
        #region UpdateGheteKhali
        public string UpdateGheteKhali(int fldGheteId, int fldVadiSalamId, string fldNameGhete, int Radif, int Shomare, string Tabaghe, int userId, int OrganId, string Desc, string IP, out ClsError error)
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
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (fldGheteId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد قطعه ضروری است";
            }
            else if (fldVadiSalamId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد وادی السلام ضروری است";
            }
            else if (Radif == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "ردیف ضروری است";
            }
            else if (Shomare == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره ضروری است";
            }
            else if (Tabaghe == "" || Tabaghe == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "طبقه ضروری است";
            }
            else if (fldNameGhete == "" || fldNameGhete == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام قطعه ضروری است";
            }
            else if (fldNameGhete.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام قطعه وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldNameGhete.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام قطعه وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Ghete.UpdateGheteKhali(fldGheteId,fldVadiSalamId, fldNameGhete, Radif, Shomare, Tabaghe, userId, Desc, IP, OrganId);

        }
        #endregion

        #region SelectGheteDetail
        public List<OBJ_Ghete> SelectGheteDetail(int GheteId)
        {
            return Ghete.SelectGheteDetail(GheteId);
        }
        #endregion

        #region DeleteAllTablesOnGhete
        public string DeleteAllTablesOnGhete(int GheteId, int UserId,int Organid,string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (GheteId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (Ghete.CheckDeleteAllTables(GheteId, Organid))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است لذا مجاز به حذف نمی باشید.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Ghete.DeleteAllTablesOnGhete(GheteId,UserId,IP);
        }
        #endregion

        #region UpdateTedadTabaghat
        public string UpdateTedadTabaghat(int fldGheteId, string fldShomare, string fldNameGhete, int userId,int OrganId, string Desc, out ClsError error)
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
            else if (fldGheteId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (fldShomare == "" || fldShomare == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره ضروری است";
            }
            else if (fldNameGhete == "" || fldNameGhete == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام قطعه ضروری است";
            }
            else if (fldNameGhete.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام قطعه وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldNameGhete.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام قطعه وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Ghete.UpdateTedadTabaghat(fldGheteId, fldShomare, fldNameGhete, userId, Desc,OrganId);

        }
        #endregion
    }
}