using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_AshkhaseHoghoghi
    {
        DL_AshkhaseHoghoghi AshkhaseHoghoghi = new DL_AshkhaseHoghoghi();

        #region Detail
        public OBJ_AshkhaseHoghoghi Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return AshkhaseHoghoghi.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_AshkhaseHoghoghi> Select(string FieldName, string FilterValue, int h)
        {
            return AshkhaseHoghoghi.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public int Insert(string fldShenaseMelli, string fldName, string fldShomareSabt, byte TypeShakhs, byte Sayer, int userId, string Desc, out ClsError error)
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
            
            else if (fldName == "" || fldName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام ضروری است";
            }
            else if (fldName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 250)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (AshkhaseHoghoghi.CheckRepeatedName(fldName, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام وارد شده تکراری است.";
            }
            if (Sayer == 1)
            {
                if (TypeShakhs == 1)
                {
                    if (fldShenaseMelli == "" || fldShenaseMelli == null)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "کد فراگیر ضروری است.";
                    }
                }
                else
                {
                    //if (fldShenaseMelli == "" || fldShenaseMelli == null)
                    //{
                    //    error.ErrorType = true;
                    //    error.ErrorMsg = "شناسه ملی ضروری است.";
                    //}
                    //else
                    if (fldShenaseMelli.Length > 11)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "تعداد کاراکتر شناسه ملی وارده شده بیشتر از حد مجاز می باشد.";
                    }
                    else if (fldShenaseMelli != "0" && fldShenaseMelli != null)
                    {
                        if (AshkhaseHoghoghi.CheckRepeatedRow(fldShenaseMelli, 0))
                        {
                            error.ErrorType = true;
                            error.ErrorMsg = "شناسه ملی وارد شده تکراری است.";
                        }
                    }
                }
            }
            
            
            if (error.ErrorType == true)
                return 0;

            return AshkhaseHoghoghi.Insert(fldShenaseMelli, fldName, fldShomareSabt,TypeShakhs,Sayer, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string fldShenaseMelli, string fldName, string fldShomareSabt, byte TypeShakhs,byte Sayer, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است.";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است.";
            }
            
            else if (fldName == "" || fldName == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام ضروری است.";
            }
            else if (fldName.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldName.Length > 250)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (AshkhaseHoghoghi.CheckRepeatedName(fldName, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام وارد شده تکراری است.";
            }
            if (Sayer == 1)
            {
                if (TypeShakhs == 1)
                {
                    if (fldShenaseMelli == "" || fldShenaseMelli == null)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "کد فراگیر ضروری است.";
                    }
                }
                else
                {
                    //if (fldShenaseMelli == "" || fldShenaseMelli == null)
                    //{
                    //    error.ErrorType = true;
                    //    error.ErrorMsg = "شناسه ملی ضروری است.";
                    //}
                    //else 
                    if (fldShenaseMelli.Length > 11)
                    {
                        error.ErrorType = true;
                        error.ErrorMsg = "تعداد کاراکتر شناسه ملی وارده شده بیشتر از حد مجاز می باشد.";
                    }
                    else if (fldShenaseMelli != "0" && fldShenaseMelli != null)
                    {
                        if (AshkhaseHoghoghi.CheckRepeatedRow(fldShenaseMelli, Id))
                        {
                            error.ErrorType = true;
                            error.ErrorMsg = "شناسه ملی وارد شده تکراری است.";
                        }
                    }
                }
            }
           
            if (error.ErrorType == true)
                return "خطا";

            return AshkhaseHoghoghi.Update(Id, fldShenaseMelli, fldName, fldShomareSabt,TypeShakhs, Sayer, userId, Desc);

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
                error.ErrorMsg = "کد کاربر ضروری است.";
            }
            else if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است.";
            }
            /*else if (AshkhaseHoghoghi.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }*/
            if (error.ErrorType == true)
                return "خطا";

            return AshkhaseHoghoghi.Delete(id, userId);
        }
        #endregion
    }
}