using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_MonasebatTarikh
    {
        DL_MonasebatTarikh MonasebatTarikh = new DL_MonasebatTarikh();

        #region Detail
        public OBJ_MonasebatTarikh Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return MonasebatTarikh.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_MonasebatTarikh> Select(string FieldName, string FilterValue, string FilterValue1, string FilterValue2,string FilterValue3, int h)
        {
            return MonasebatTarikh.Select(FieldName, FilterValue,FilterValue1, FilterValue2, FilterValue3, h);
        }
        #endregion
        #region Insert
        public string Insert(short Year,byte Month,byte Day, byte MonasebatId,int UserId, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است.";
            }
            else if (MonasebatId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد مناسبت ضروری است.";
            }
            else if (Year == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال ضروری است.";
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
            else if (Year.ToString().Length !=4)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال نادرست است.";
            }
            else if (Month>12)
            {
                error.ErrorType = true;
                error.ErrorMsg = "ماه نادرست است.";
            }
            else if ((Month==12 && MyLib.Shamsi.Iskabise(Year)&& Day>30) || (Month==12 && MyLib.Shamsi.Iskabise(Year)==false && Day>29)
            || (Month<=6 && Day>31) || (Month>6 && Month!=12 && Day>30))
            {
                error.ErrorType = true;
                error.ErrorMsg = "روز نادرست است.";
            }
            else if (MonasebatTarikh.CheckRepeatedRow(0,Year,Month,Day,MonasebatId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MonasebatTarikh.Insert(Year,Month,Day, MonasebatId, UserId, IP);
        }
        #endregion
        #region Update
        public string Update(int Id, short Year,byte Month,byte Day, byte MonasebatId, int UserId, string IP, out ClsError error)
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
                error.ErrorMsg = "کد ضروری است.";
            }
            else if (MonasebatId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد مناسبت ضروری است.";
            }
            else if (Year == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال ضروری است.";
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
            else if (Year.ToString().Length !=4)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال نادرست است.";
            }
            else if (Month>12)
            {
                error.ErrorType = true;
                error.ErrorMsg = "ماه نادرست است.";
            }
            else if ((Month==12 && MyLib.Shamsi.Iskabise(Year)&& Day>30) || (Month==12 && MyLib.Shamsi.Iskabise(Year)==false && Day>29)
            || (Month<=6 && Day>31) || (Month>6 && Month!=12 && Day>30))
            {
                error.ErrorType = true;
                error.ErrorMsg = "روز نادرست است.";
            }
            else if (MonasebatTarikh.CheckRepeatedRow(Id,Year,Month,Day,MonasebatId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MonasebatTarikh.Update(Id, Year,Month,Day,MonasebatId, UserId, IP);
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
            //else if (MonasebatMablagh.CheckDelete(id))
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است";
            //}
            if (error.ErrorType == true)
                return "خطا";

            return MonasebatTarikh.Delete(id, userId);
        }
        #endregion
    }
}