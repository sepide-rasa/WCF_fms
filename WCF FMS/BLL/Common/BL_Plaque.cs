using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_Plaque
    {
        DL_Plaque Plaque = new DL_Plaque();

        #region Detail
        public OBJ_Plaque Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد استان ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Plaque.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Plaque> Select(string FieldName, string FilterValue, int h)
        {
            return Plaque.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(byte fldSerialPlaque, string harf, string fldPlaque2, string fldPlaque3, int userId, string Desc, string IP, out ClsError error)
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
            else if (fldSerialPlaque == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سریال پلاک ضروری است";
            }
            if (harf == "" || harf == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کاراکتر وسط پلاک ضروری است";
            }
            //else if (fldPlaque2 == "" || fldPlaque2 == null)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "پلاک ضروری است";
            //}
            //else if (fldPlaque3 == "" || fldPlaque3 == null)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "پلاک ضروری است";
            //}
            if (error.ErrorType == true)
                return "خطا";

            return Plaque.Insert(fldSerialPlaque, harf, fldPlaque2, fldPlaque3, userId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int fldId, byte fldSerialPlaque, string harf, string fldPlaque2, string fldPlaque3, int userId, string Desc, string IP, out ClsError error)
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
            else if (fldId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (fldSerialPlaque == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سریال پلاک ضروری است";
            }
            if (harf == "" || harf == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کاراکتر وسط پلاک ضروری است";
            }
            //else if (fldPlaque2 == "" || fldPlaque2 == null)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "پلاک ضروری است";
            //}
            //else if (fldPlaque3 == "" || fldPlaque3 == null)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "پلاک ضروری است";
            //}
            if (error.ErrorType == true)
                return "خطا";

            return Plaque.Update(fldId, fldSerialPlaque, harf, fldPlaque2, fldPlaque3, userId, Desc, IP);

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

            return Plaque.Delete(id, userId);
        }
        #endregion

        #region InsertPlaque_WebService
        public int InsertPlaque_WebService(string Harf, string Plaque2, string Plaque3, byte Serial, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (Harf == "" || Harf == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کاراکتر وسط پلاک ضروری است";
            }
            //else if (Plaque2 == "" || Plaque2 == null)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "پلاک ضروری است";
            //}
            //else if (Plaque3 == "" || Plaque3 == null)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "پلاک ضروری است";
            //}
            else if (Serial == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سریال پلاک ضروری است";
            }
            if (error.ErrorType == true)
                return 0;

            return Plaque.InsertPlaque_WebService(Harf,Plaque2,Plaque3,Serial);

        }
        #endregion
    }
}