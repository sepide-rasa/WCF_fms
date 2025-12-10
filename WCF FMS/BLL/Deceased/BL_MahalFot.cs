using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Deceased;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.BLL.Deceased
{
    public class BL_MahalFot
    {
        DL_MahalFot MahalFot = new DL_MahalFot();

        #region Detail
        public OBJ_MahalFot Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return MahalFot.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_MahalFot> Select(string FieldName, string FilterValue, int h)
        {
            return MahalFot.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldNameMahal, int userId, string Desc, string IP, out ClsError error)
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
            else if (fldNameMahal == "" || fldNameMahal == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "محل فوت ضروری است";
            }
            else if (fldNameMahal.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر محل فوت وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldNameMahal.Length > 250)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر محل فوت وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (MahalFot.CheckRepeatedRow(fldNameMahal, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "محل فوت وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MahalFot.Insert(fldNameMahal, userId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int fldId, string fldNameMahal, int userId, string Desc, string IP, out ClsError error)
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
            if (fldId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (fldNameMahal == "" || fldNameMahal == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "محل فوت ضروری است";
            }
            else if (fldNameMahal.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر محل فوت وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldNameMahal.Length > 250)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر علت وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (MahalFot.CheckRepeatedRow(fldNameMahal, fldId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "محل فوت وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MahalFot.Update(fldId, fldNameMahal, userId, Desc, IP);

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
            else if (MahalFot.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است لذا مجاز به حذف نمی باشید.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MahalFot.Delete(id, userId);
        }
        #endregion
    }
}