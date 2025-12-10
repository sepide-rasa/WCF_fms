using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_ShomareHesabCodeDaramad
    {
        DL_ShomareHesabCodeDaramad ShomareHesabCodeDaramad = new DL_ShomareHesabCodeDaramad();

        #region Detail
        public OBJ_ShomareHesabCodeDaramad Detail(int id,int FiscalYearId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ShomareHesabCodeDaramad.Detail(id,FiscalYearId);
        }
        #endregion
        #region Select
        public List<OBJ_ShomareHesabCodeDaramad> Select(string FieldName, string FilterValue, string FilterValue1,int FiscalYearId, int h)
        {
            return ShomareHesabCodeDaramad.Select(FieldName, FilterValue, FilterValue1,FiscalYearId, h);
        }
        #endregion
        #region Insert
        public string Insert(int ShomareHesadId, int CodeDaramadId, int OrganId, byte ShorooshenaseGhabz, int userId, string Desc, out ClsError error)
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
            else if (ShomareHesadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب ضروری است";
            }
            else if (CodeDaramadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد درآمد ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (ShorooshenaseGhabz < 10)
            {
                error.ErrorType = true;
                error.ErrorMsg = "حداقل مقدار شناسه قبض 10 می باشد.";
            }
            else if (ShorooshenaseGhabz > 99)
            {
                error.ErrorType = true;
                error.ErrorMsg = "حداکثر مقدار شناسه قبض 99 می باشد.";
            }
            else if (ShomareHesabCodeDaramad.CheckRepeatedRow(ShomareHesadId, CodeDaramadId, OrganId, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }

            if (error.ErrorType == true)
                return "خطا";

            return ShomareHesabCodeDaramad.Insert(ShomareHesadId, CodeDaramadId, OrganId, ShorooshenaseGhabz, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int ShomareHesadId, int CodeDaramadId, int OrganId, byte ShorooshenaseGhabz, int userId, string Desc, out ClsError error)
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
            else if (ShomareHesadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب ضروری است";
            }
            else if (CodeDaramadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد درآمد ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (ShorooshenaseGhabz < 10)
            {
                error.ErrorType = true;
                error.ErrorMsg = "حداقل مقدار شناسه قبض 10 می باشد.";
            }
            else if (ShorooshenaseGhabz > 99)
            {
                error.ErrorType = true;
                error.ErrorMsg = "حداکثر مقدار شناسه قبض 99 می باشد.";
            }
            else if (ShomareHesabCodeDaramad.CheckRepeatedRow(ShomareHesadId, CodeDaramadId, OrganId,Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ShomareHesabCodeDaramad.Update(Id, ShomareHesadId, CodeDaramadId, OrganId, ShorooshenaseGhabz, userId, Desc);

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

            return ShomareHesabCodeDaramad.Delete(id, userId);
        }
        #endregion
        #region UpdateSharhecodeDaramd
        public string UpdateSharhecodeDaramd(int Id, string SharhCodeDaramad, int UserId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (SharhCodeDaramad == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شرح کد درآمد ضروری است";
            }
            
            if (error.ErrorType == true)
                return "خطا";

            return ShomareHesabCodeDaramad.UpdateSharhecodeDaramd(Id, SharhCodeDaramad, UserId);

        }
        #endregion
        #region UpdateStatus_CodeDaramad
        public string UpdateStatus_CodeDaramad(int Id, bool Status, int UserId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب کددرآمد ضروری است";
            }

            if (error.ErrorType == true)
                return "خطا";

            return ShomareHesabCodeDaramad.UpdateStatus_CodeDaramad(Id, Status, UserId);

        }
        #endregion
    }
}