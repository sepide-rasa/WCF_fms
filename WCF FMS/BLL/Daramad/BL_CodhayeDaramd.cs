using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_CodhayeDaramd
    {
        DL_CodhayeDaramd CodhayeDaramd = new DL_CodhayeDaramd();

        #region Detail
        public OBJ_CodhayeDaramd Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است.";
            }
            if (error.ErrorType == true)
                return null;
            return CodhayeDaramd.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_CodhayeDaramd> Select(string FieldName, string FilterValue,int FiscalYearId, int OrganId, int h)
        {
            return CodhayeDaramd.Select(FieldName, FilterValue,FiscalYearId,OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int Id, string DaramadCode, string DaramadTitle, bool MashmooleArzesheAfzoode, bool MashmooleKarmozd, bool AmuzeshParvaresh, int? UnitId, int userId, string Desc, out ClsError error)
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
            else if (DaramadCode == null || DaramadCode=="")
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد درآمد ضروری است";
            }
            else if (DaramadTitle == null || DaramadTitle == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان درآمد ضروری است";
            }
            else if (UnitId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد واحد اندازه گیری ضروری است";
            }
            //else if (CodhayeDaramd.CheckRepeatedRow(DaramadCode, DaramadTitle, 0))
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            //}
            else if (DaramadCode.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر کد درآمد وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (DaramadTitle.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان درآمد وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (DaramadTitle.Length > 250)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان درآمد وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CodhayeDaramd.Insert(Id, DaramadCode, DaramadTitle, MashmooleArzesheAfzoode, MashmooleKarmozd, AmuzeshParvaresh,UnitId, userId, Desc);

        }
        #endregion
        #region InsertFromAccounting
        public string InsertFromAccounting(short Year, int OrganId, int userId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Year == null || Year == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال مالی ضروری است";
            }
            else if (OrganId == null || OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سازمان ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CodhayeDaramd.InsertFromAccounting(Year, OrganId, userId);

        }
        #endregion
        #region Update
        public string Update(int Id, string DaramadCode, string DaramadTitle, bool MashmooleArzesheAfzoode, bool MashmooleKarmozd, bool AmuzeshParvaresh, int? UnitId, int userId, string Desc, out ClsError error)
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
            else if (DaramadCode == null || DaramadCode == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد درآمد ضروری است";
            }
            else if (DaramadTitle == null || DaramadTitle == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان درآمد ضروری است";
            }
            else if (UnitId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد واحد اندازه گیری ضروری است";
            }
            //else if (CodhayeDaramd.CheckRepeatedRow(DaramadCode, DaramadTitle, Id))
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            //}
            else if (DaramadCode.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر کد درآمد وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (DaramadTitle.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان درآمد وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (DaramadTitle.Length > 250)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان درآمد وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CodhayeDaramd.Update(Id, DaramadCode, DaramadTitle, MashmooleArzesheAfzoode, MashmooleKarmozd,AmuzeshParvaresh, UnitId, userId, Desc);

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
            else if (CodhayeDaramd.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CodhayeDaramd.Delete(id, userId);
        }
        #endregion
        #region UpdateDaramadId
        public string UpdateDaramadId(int childe, int parent, int UserId, out ClsError error)
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

            return CodhayeDaramd.UpdateDaramadId(childe, parent,UserId);

        }
        #endregion
        #region UpdateFileForCodhayeDaramd
        public string UpdateFileForCodhayeDaramd(int ShomareHesabCodeDaramadId, byte[] Image, string Pasvand, int UserId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (ShomareHesabCodeDaramadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب درآمد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CodhayeDaramd.UpdateFileForCodhayeDaramd(ShomareHesabCodeDaramadId, Image, Pasvand, UserId, Desc);

        }
        #endregion
        #region UpdateFormolsazForCodhayeDarmd
        public string UpdateFormolsazForCodhayeDarmd(int ShomareHesabCodeDaramdId, string Formolsaz, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (ShomareHesabCodeDaramdId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CodhayeDaramd.UpdateFormolsazForCodhayeDarmd(ShomareHesabCodeDaramdId, Formolsaz);

        }
        #endregion
        #region CopyCodeDaramd
        public string CopyCodeDaramd(string FieldName, int MabdaId, int MaghsadId, int UserId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (MabdaId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد درآمد ضروری است";
            }
            else if (MaghsadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد درآمد ضروری است";
            }
            else if (CodhayeDaramd.CheckCopyCode(MaghsadId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "برای کد درآمد مورد نظر اطلاعات قبلا ثبت شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CodhayeDaramd.CopyCodeDaramd(FieldName, MabdaId, MaghsadId, UserId);

        }
        #endregion
    }
}