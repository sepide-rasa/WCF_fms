using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Deceased;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.BLL.Deceased
{
    public class BL_VadiSalam
    {
        DL_VadiSalam VadiSalam = new DL_VadiSalam();

        #region Detail
        public OBJ_VadiSalam Detail(int id,int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return VadiSalam.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_VadiSalam> Select(string FieldName, string FilterValue,int OrganId, int h)
        {
            return VadiSalam.Select(FieldName, FilterValue,OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(string fldName, int fldStateId, int fldCityId, string fldAddress, string fldLatitude, string fldLongitude, int fldUserID,int OrganId, string fldDesc, string fldIP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (fldDesc == null)
                fldDesc = "";
            if (fldUserID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldStateId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد استان ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (fldCityId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شهر ضروری است";
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
            else if (fldName.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (fldAddress == "" || fldAddress == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "ادرس ضروری است";
            }
            else if (fldAddress.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر آدرس وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldAddress.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر آدرس وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldLatitude == null || fldLatitude == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = " عرض جغرافیایی ضروری است";
            }
            else if (fldLatitude.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عرض جغرافیایی وارده شده کمتر از حد مجاز می باشد.";
                
            }
            else if (fldLatitude.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عرض جغرافیایی وارده شده بیشتر از حد مجاز می باشد.";
               
            }
            else if (fldLongitude == null || fldLongitude == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "طول جغرافیایی  ضروری است";
            }
            else if (fldLongitude.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر طول جغرافیایی وارده شده کمتر از حد مجاز می باشد.";
            }
            else if (fldLongitude.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر طول جغرافیایی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (VadiSalam.CheckRepeatedRow(fldName, fldCityId, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return VadiSalam.Insert(fldName, fldStateId, fldCityId, fldAddress, fldLatitude, fldLongitude, fldUserID, fldDesc, fldIP,OrganId);

        }
        #endregion
        #region Update
        public string Update(int fldId,string fldName, int fldStateId, int fldCityId, string fldAddress, string fldLatitude, string fldLongitude, int fldUserID,int OrganId, string fldDesc, string fldIP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (fldDesc == null)
                fldDesc = "";
            if (fldUserID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد جهت ویرایش ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (fldStateId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد استان ضروری است";
            }
            else if (fldCityId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شهر ضروری است";
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
            else if (fldName.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (fldAddress == "" || fldAddress == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "ادرس ضروری است";
            }
            else if (fldAddress.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر آدرس وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldAddress.Length > 200)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر آدرس وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (fldLatitude == null || fldLatitude == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = " عرض جغرافیایی ضروری است";
            }
            else if (fldLatitude.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عرض جغرافیایی وارده شده کمتر از حد مجاز می باشد.";

            }
            else if (fldLatitude.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عرض جغرافیایی وارده شده بیشتر از حد مجاز می باشد.";

            }
            else if (fldLongitude == null || fldLongitude == "")
            {
                error.ErrorType = true;
                error.ErrorMsg = "طول جغرافیایی  ضروری است";
            }
            else if (fldLongitude.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر طول جغرافیایی وارده شده کمتر از حد مجاز می باشد.";
            }
            else if (fldLongitude.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر طول جغرافیایی وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (VadiSalam.CheckRepeatedRow(fldName, fldCityId, fldId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return VadiSalam.Update(fldId, fldName, fldStateId, fldCityId, fldAddress, fldLatitude, fldLongitude, fldUserID, fldDesc, fldIP, OrganId);

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
            else if (VadiSalam.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است لذا مجاز به حذف نمی باشید.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return VadiSalam.Delete(id, userId);
        }
        #endregion
    }
}