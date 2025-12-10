using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_Monasebat
    {
        DL_Monasebat Monasebat = new DL_Monasebat();

        #region Detail
        public OBJ_Monasebat Detail(byte id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Monasebat.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Monasebat> Select(string FieldName, string FilterValue,string FilterValue2,bool DateType, int h)
        {
            return Monasebat.Select(FieldName, FilterValue,FilterValue2,DateType, h);
        }
        #endregion
        #region SelectMonasebatType
        public List<OBJ_MonasebatType> SelectMonasebatType(string FieldName, string FilterValue, int h)
        {
            return Monasebat.SelectMonasebatType(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string Name, byte MonasebatType, byte Month, byte Day, bool DateType, bool Holiday, bool Mazaya, int UserId, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است.";
            }
            else if (Name=="" || Name==null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان مناسبت ضروری است.";
            }
            else if (Name.ToString().Length <2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (MonasebatType==0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "گروه مناسبت ضروری است.";
            }
            else if (DateType == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع تاریخ ضروری است.";
            }
            else if (Holiday == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "وضعیت مناسبت ضروری است.";
            }
            else if (Mazaya == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع مناسبت ضروری است.";
            }
            else if (Month ==0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "ماه ضروری است.";
            }
            else if (Day ==0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "روز ضروری است.";
            }
            else if (Month > 12)
            {
                error.ErrorType = true;
                error.ErrorMsg = "ماه نادرست است.";
            }
            else if ((DateType==false &&((Month <= 6 && Day > 31) || (Month > 6 &&  Day > 30))) || (DateType && Day>30))
            {
                error.ErrorType = true;
                error.ErrorMsg = "روز نادرست است.";
            }
            else if (Monasebat.CheckRepeatedRow(0,Month,Day,DateType))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            } 
            if (error.ErrorType == true)
                return "خطا";

            return Monasebat.Insert(Name,MonasebatType,Month,Day,DateType,Holiday,Mazaya, UserId, IP);
        }
        #endregion
        #region Update
        public string Update(byte Id, string Name, byte MonasebatType, byte Month, byte Day, bool DateType, bool Holiday, bool Mazaya, int UserId, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است.";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد مناسبت ضروری است.";
            }
            else if (Name == "" || Name == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان مناسبت ضروری است.";
            }
            else if (Name.ToString().Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (MonasebatType == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "گروه مناسبت ضروری است.";
            }
            else if (DateType == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع تاریخ ضروری است.";
            }
            else if (Holiday == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "وضعیت مناسبت ضروری است.";
            }
            else if (Mazaya == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع مناسبت ضروری است.";
            }
            else if (Month == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "ماه ضروری است.";
            }
            else if (Day == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "روز ضروری است.";
            }
            else if (Month > 12)
            {
                error.ErrorType = true;
                error.ErrorMsg = "ماه نادرست است.";
            }
            else if ((DateType == false && ((Month <= 6 && Day > 31) || (Month > 6 && Day > 30))) || (DateType && Day > 30))
            {
                error.ErrorType = true;
                error.ErrorMsg = "روز نادرست است.";
            }
            else if (Monasebat.CheckRepeatedRow(Id, Month, Day, DateType))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            } 
            if (error.ErrorType == true)
                return "خطا";

            return Monasebat.Update(Id,Name,MonasebatType,Month,Day,DateType,Holiday,Mazaya, UserId, IP);
        }
        #endregion
        #region Delete
        public string Delete(byte id, int userId, out ClsError error)
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
            //else if (MonasebatHeader.CheckDelete(id))
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است";
            //}
            if (error.ErrorType == true)
                return "خطا";

            return Monasebat.Delete(id, userId);
        }
        #endregion
    }
}