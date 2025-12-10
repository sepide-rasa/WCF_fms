using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Chek;
using WCF_FMS.TOL.Chek;

namespace WCF_FMS.BLL.Chek
{
    public class BL_DasteCheck
    {
        DL_DasteCheck DasteCheck = new DL_DasteCheck();

        #region Detail
        public OBJ_DasteCheck Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return DasteCheck.Detail(id,OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_DasteCheck> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return DasteCheck.Select(FieldName, FilterValue,OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int OlgoCheckId, int ShomareHesabId, string MoshakhaseDasteCheck, byte TedadBarg, string ShoroeSeriyal, int OrganId, int userId, string Desc, out ClsError error)
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
            else if (OlgoCheckId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد الگو چک ضروری است";
            }
            else if (ShomareHesabId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب ضروری است";
            }
            else if (MoshakhaseDasteCheck == "" || MoshakhaseDasteCheck == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مشخصات دسته چک ضروری است";
            }
            else if (ShoroeSeriyal == "" || ShoroeSeriyal == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شروع سریال ضروری است";
            }
            else if (MoshakhaseDasteCheck.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر مشخصات چک وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (MoshakhaseDasteCheck.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر مشخصات چک وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ShoroeSeriyal.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شروع سریال وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (TedadBarg > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار نوع واحد وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return DasteCheck.Insert(OlgoCheckId, ShomareHesabId, MoshakhaseDasteCheck, TedadBarg, ShoroeSeriyal,OrganId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int OlgoCheckId, int ShomareHesabId, string MoshakhaseDasteCheck, byte TedadBarg, string ShoroeSeriyal, int OrganId, int userId, string Desc, out ClsError error)
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
            else if (OlgoCheckId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد الگو چک ضروری است";
            }
            else if (ShomareHesabId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب ضروری است";
            }
            else if (MoshakhaseDasteCheck == "" || MoshakhaseDasteCheck == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مشخصات دسته چک ضروری است";
            }
            else if (ShoroeSeriyal == "" || ShoroeSeriyal == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شروع سریال ضروری است";
            }
            else if (MoshakhaseDasteCheck.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر مشخصات چک وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (MoshakhaseDasteCheck.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر مشخصات چک وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ShoroeSeriyal.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شروع سریال وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (TedadBarg > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار نوع واحد وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return DasteCheck.Update(Id, OlgoCheckId, ShomareHesabId, MoshakhaseDasteCheck, TedadBarg, ShoroeSeriyal,OrganId, userId, Desc);

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
            else if (DasteCheck.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return DasteCheck.Delete(id, userId);
        }
        #endregion
    }
}