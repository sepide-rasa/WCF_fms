using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_ChartOrgan
    {
        DL_ChartOrgan ChartOrgan = new DL_ChartOrgan();

        #region Detail
        public OBJ_ChartOrgan Detail(int id, int UserId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد چارت سازمانی ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ChartOrgan.Detail(id,UserId);
        }
        #endregion
        #region Select
        public List<OBJ_ChartOrgan> Select(string FieldName, string FilterValue, int UserId, int h)
        {
            return ChartOrgan.Select(FieldName, FilterValue, UserId, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldTitle, int? fldPId, int? fldOrganId, byte fldNoeVahed, int userId, string Desc, out ClsError error)
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
            else if (fldTitle == ""|| fldTitle==null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان چارت سازمانی ضروری است";
            }
            else if (fldTitle.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldTitle.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldOrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "انتخاب سازمان ضروری است";
            }
            else if (fldNoeVahed == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "انتخاب نوع واحد سازمان ضروری است";
            }
            else if (ChartOrgan.CheckRepeatedRow(fldTitle, fldOrganId, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ChartOrgan.Insert(fldTitle, fldPId, fldOrganId, fldNoeVahed, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int fldId, string fldTitle, int? fldPId, int? fldOrganId, byte fldNoeVahed, int userId, string Desc, out ClsError error)
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
            if (fldTitle == ""||fldTitle==null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان چارت سازمانی ضروری است";
            }
            else if (fldTitle.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldTitle.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (fldOrganId == null && fldPId == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "انتخاب سازمان یا یک گره از ساختار درختی ضروری است";
            }
            if (fldNoeVahed == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "انتخاب نوع واحد سازمان ضروری است";
            }
            else if (ChartOrgan.CheckRepeatedRow(fldTitle, fldOrganId, fldId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ChartOrgan.Update(fldId, fldTitle, fldPId, fldOrganId, fldNoeVahed, userId, Desc);

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
                error.ErrorMsg = "کد چارت سازمانی ضروری است.";
            }
            else if (ChartOrgan.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ChartOrgan.Delete(id, userId);
        }
        #endregion
    }
}