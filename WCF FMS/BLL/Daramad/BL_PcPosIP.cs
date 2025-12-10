using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_PcPosIP
    {
        DL_PcPosIP PcPosIP = new DL_PcPosIP();

        #region Detail
        public OBJ_PcPosIP Detail(int id,string Value1, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return PcPosIP.Detail(id,Value1);
        }
        #endregion
        #region Select
        public List<OBJ_PcPosIP> Select(string FieldName, string FilterValue, string Value1, int h)
        {
            return PcPosIP.Select(FieldName, FilterValue, Value1, h);
        }
        #endregion
        #region Insert
        public int Insert(int PcPosInfoId, string Serial, string IP, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (PcPosInfoId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اطلاعات pc pos ضروری است";
            }
            else if (Serial == "" || Serial == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سریال ضروری است";
            }
            else if (IP == "" || IP == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "IP ضروری است";
            }
            else if (IP.Length > 15)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر IP وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Serial.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر سریال وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return 0;

            return PcPosIP.Insert(PcPosInfoId, Serial, IP, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int PcPosInfoId, string Serial, string IP, int userId, string Desc, out ClsError error)
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
            else if (PcPosInfoId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اطلاعات pc pos ضروری است";
            }
            else if (Serial == "" || Serial == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سریال ضروری است";
            }
            else if (IP == "" || IP == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "IP ضروری است";
            }
            else if (IP.Length > 15)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر IP وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Serial.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر سریال وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PcPosIP.Update(Id, PcPosInfoId, Serial, IP, userId, Desc);

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

            return PcPosIP.Delete(id, userId);
        }
        #endregion
        
    }
}