using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Deceased;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.BLL.Deceased
{
    public class BL_Radif
    {
        DL_Radif Radif = new DL_Radif();

        #region Detail
        public OBJ_Radif Detail(int id,int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Radif.Detail(id,OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Radif> Select(string FieldName, string FilterValue, int Id, int OrganId, int h)
        {
            return Radif.Select(FieldName, FilterValue,Id,OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldGheteId, string fldNameRadif, int userId, int OrganId, string Desc, string IP, out ClsError error)
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
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (fldGheteId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد قطعه ضروری است";
            }
            else if (fldNameRadif == "" || fldNameRadif == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام ردیف ضروری است";
            }
            else if (fldNameRadif.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام ردیف وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldNameRadif.Length > 250)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام ردیف وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Radif.CheckRepeatedRow(fldGheteId,fldNameRadif, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Radif.Insert(fldGheteId,fldNameRadif, userId, Desc, IP,OrganId);

        }
        #endregion
        #region Update
        public string Update(int fldId, int fldGheteId, string fldNameRadif, int userId, int OrganId, string Desc, string IP, out ClsError error)
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
                error.ErrorMsg = "کد شهر ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (fldGheteId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد قطعه ضروری است";
            }
            else if (fldNameRadif == "" || fldNameRadif == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام ردیف ضروری است";
            }
            else if (fldNameRadif.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام ردیف وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (fldNameRadif.Length > 250)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام ردیف وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (Radif.CheckRepeatedRow(fldGheteId, fldNameRadif, fldId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Radif.Update(fldId, fldGheteId, fldNameRadif, userId, Desc, IP, OrganId);

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
            else if (Radif.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است لذا مجاز به حذف نمی باشید.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Radif.Delete(id, userId);
        }
        #endregion
    }
}