using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_ChartOrganEjraee
    {
        DL_ChartOrganEjraee ChartOrganEjraee = new DL_ChartOrganEjraee();

        #region Detail
        public OBJ_ChartOrganEjraee Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ChartOrganEjraee.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_ChartOrganEjraee> Select(string FieldName, string FilterValue, int UserId, int h)
        {
            return ChartOrganEjraee.Select(FieldName, FilterValue, UserId, h);
        }
        #endregion
        #region Insert
        public string Insert(string Title, Nullable<int> PId, Nullable<int> OrganId, byte NoeVahed, int userId, string Desc, out ClsError error)
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
            else if (Title == "" || Title == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Title.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (NoeVahed == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع واحد ضروری است";
            }
            else if (NoeVahed > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار نوع واحد وارده شده بیشتر از حد مجاز می باشد.";
            }
           
            if (error.ErrorType == true)
                return "خطا";

            return ChartOrganEjraee.Insert(Title, PId, OrganId, NoeVahed, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string Title, Nullable<int> PId, Nullable<int> OrganId, byte NoeVahed, int userId, string Desc, out ClsError error)
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
            else if (Title == "" || Title == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Title.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (NoeVahed == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع واحد ضروری است";
            }
            else if (NoeVahed > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار نوع واحد وارده شده بیشتر از حد مجاز می باشد.";
            }
            //else if (ChartOrganEjraee.CheckUpdate(Id))
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "آیتم انتخاب شده دبیرخانه بوده لذا مجاز به ویرایش نمی باشید.";
            //}
            if (error.ErrorType == true)
                return "خطا";

            return ChartOrganEjraee.Update(Id, Title, PId, OrganId, NoeVahed, userId, Desc);

        }
        #endregion
        #region Delete
        public string Delete(int id, int userId,int organId, out ClsError error)
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
            else if (ChartOrganEjraee.CheckDelete(id, organId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است";
            }
            //else if (ChartOrganEjraee.CheckDeleteAuto(id))
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "آیتم مورد نظر در ماژول اتوماسیون استفاده شده لذا مجاز به حذف نمی باشید";
            //}
            if (error.ErrorType == true)
                return "خطا";

            return ChartOrganEjraee.Delete(id, userId);
        }
        #endregion
        #region SelectChartEjraee_LastNode
        public List<OBJ_ChartOrganEjraee> SelectChartEjraee_LastNode(int OrganId)
        {
            return ChartOrganEjraee.SelectChartEjraee_LastNode(OrganId);
        }
        #endregion
    }
}