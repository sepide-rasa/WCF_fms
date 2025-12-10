using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_ShomareHesabeOmoomi
    {
        DL_ShomareHesabeOmoomi ShomareHesabeOmoomi = new DL_ShomareHesabeOmoomi();

        #region Detail
        public OBJ_ShomareHesabeOmoomi Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ShomareHesabeOmoomi.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_ShomareHesabeOmoomi> Select(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, int h)
        {
            return ShomareHesabeOmoomi.Select(FieldName, FilterValue, FilterValue2, FilterValue3, h);
        }
        #endregion
        #region Insert
        public string Insert(int ShobeId, int AshkhasId, string ShomareHesab, string ShomareSheba, int userId, string Desc, out ClsError error)
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
            else if (ShobeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شعبه ضروری است";
            }
            else if (AshkhasId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اشخاص ضروری است";
            }
            else if (ShomareHesab == "" || ShomareHesab == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره حساب ضروری است";
            }
            else if (ShomareHesab.Length < 6)/*قبلا 8 رقم بود بخاطر بانک کشاورزی شد 6 رقم*/
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شماره حساب وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (ShomareHesab.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شماره حساب وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ShomareHesabeOmoomi.CheckRepeatedRow(ShobeId, ShomareHesab, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره حساب مورد نظر در بانک انتخاب شده قبلا ثبت شده است.";
            }
            if (ShomareSheba != null)
            {
                 if (ShomareHesabeOmoomi.CheckShomareSheba(ShomareSheba))
                 {
                     error.ErrorType = true;
                     error.ErrorMsg = "فرمت شماره شبا را به درستی وارد کنید.";
                 }
                if (ShomareSheba.Length > 26)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "شماره شبا وارده شده بیشتر از حد مجاز می باشد.";
                }
            }
            
            if (error.ErrorType == true)
                return "خطا";

            return ShomareHesabeOmoomi.Insert(ShobeId, AshkhasId, ShomareHesab, ShomareSheba, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int ShobeId, int AshkhasId, string ShomareHesab, string ShomareSheba, int userId, string Desc, out ClsError error)
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
            else if (ShobeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شعبه ضروری است";
            }
            else if (AshkhasId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اشخاص ضروری است";
            }
            else if (ShomareHesab == "" || ShomareHesab == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره حساب ضروری است";
            }
            else if (ShomareHesab.Length < 8)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شماره حساب وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (ShomareHesab.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شماره حساب وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ShomareHesabeOmoomi.CheckRepeatedRow(ShobeId, ShomareHesab, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره حساب مورد نظر در بانک انتخاب شده قبلا ثبت شده است.";
            }
            if (ShomareSheba != null)
            {
                if (ShomareHesabeOmoomi.CheckShomareSheba(ShomareSheba))
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "فرمت شماره شبا را به درستی وارد کنید.";
                }
                if (ShomareSheba.Length > 26)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "شماره شبا وارده شده بیشتر از حد مجاز می باشد.";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return ShomareHesabeOmoomi.Update(Id, ShobeId, AshkhasId, ShomareHesab, ShomareSheba, userId, Desc);

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
            else if (ShomareHesabeOmoomi.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ShomareHesabeOmoomi.Delete(id, userId);
        }
        #endregion
    }
}