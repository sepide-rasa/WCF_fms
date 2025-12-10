using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Deceased;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.BLL.Deceased
{
    public class BL_Kartabl
    {
        DL_Kartabl Kartabl = new DL_Kartabl();

        #region Detail
        public OBJ_Kartabl Detail(int id, int organId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Kartabl.Detail(id, organId);
        }
        #endregion
        #region Select
        public List<OBJ_Kartabl> Select(string FieldName, string FilterValue, int organId, int h)
        {
            return Kartabl.Select(FieldName, FilterValue, organId, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldTitleKartabl, bool fldHaveEbtal, bool fldHaveEtmam, int organId, int userId, string Desc, string IP, out ClsError error)
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
            else if (fldTitleKartabl == "" || fldTitleKartabl == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان کارتابل ضروری است";
            }
            else if (fldTitleKartabl.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان کارتابل وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldTitleKartabl.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان کارتابل وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Kartabl.CheckRepeatedRow(fldTitleKartabl, organId, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "کارتابل وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Kartabl.Insert(fldTitleKartabl,fldHaveEbtal,fldHaveEtmam, organId, userId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int fldId, string fldTitleKartabl, bool fldHaveEbtal, bool fldHaveEtmam, int organId, int userId, string Desc, string IP, out ClsError error)
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
            else if (fldTitleKartabl == "" || fldTitleKartabl == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان کارتابل ضروری است";
            }
            else if (fldTitleKartabl.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان کارتابل وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldTitleKartabl.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان کارتابل وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Kartabl.CheckRepeatedRow(fldTitleKartabl, organId, fldId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "کارتابل وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Kartabl.Update(fldId, fldTitleKartabl,fldHaveEbtal,fldHaveEtmam, organId, userId, Desc, IP);

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
            else if (Kartabl.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است لذا مجاز به حذف نمی باشید.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Kartabl.Delete(id, userId);
        }
        #endregion

        #region UpdateOrderKartabl
        public string UpdateOrderKartabl(int fldKartablId, int fldOrderId, int userId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            if (fldKartablId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کارتابل ضروری است";
            }
            
            if (error.ErrorType == true)
                return "خطا";

            return Kartabl.UpdateOrderKartabl(fldKartablId, fldOrderId, userId);

        }
        #endregion
    }
}