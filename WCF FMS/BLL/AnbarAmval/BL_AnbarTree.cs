using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.AnbarAmval;
using WCF_FMS.TOL.AnbarAmval;

namespace WCF_FMS.BLL.AnbarAmval
{
    public class BL_AnbarTree
    {
        DL_AnbarTree AnbarTree = new DL_AnbarTree();

        #region Detail
        public OBJ_AnbarTree Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return AnbarTree.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_AnbarTree> Select(string FieldName, string FilterValue, string FilterValue2, int h)
        {
            return AnbarTree.Select(FieldName, FilterValue,FilterValue2, h);
        }
        #endregion
        #region Insert
        public string Insert(int? PID, string Name, int fldGroupId, int UserId, string IP, string Desc, out ClsError error)
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
            else if (Name == "" || Name == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = ",عنوان ضروری است";
            }
            else if (Name.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Name.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldGroupId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد گروه ضروری است";
            }
            else if (AnbarTree.CheckRepeatedRow(Name, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return AnbarTree.Insert(PID, Name, fldGroupId, UserId, IP, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string Name, int fldGroupId, int UserId, string IP, string Desc, out ClsError error)
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
            else if (Name == "" || Name == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام انبار ضروری است";
            }
            else if (Name.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Name.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldGroupId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد گروه ضروری است";
            }
            else if (AnbarTree.CheckRepeatedRow(Name, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return AnbarTree.Update(Id, Name, fldGroupId, UserId, IP, Desc);

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

            return AnbarTree.Delete(id, userId);
        }
        #endregion
        #region Anbar_TarifNashode
        public List<OBJ_Anbar_TarifNashode> Anbar_TarifNashode(int GroupId)
        {
            return AnbarTree.Anbar_TarifNashode(GroupId);
        }
        #endregion
    }
}