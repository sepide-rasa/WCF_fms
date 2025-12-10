using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_Kala
    {
        DL_Kala Kala = new DL_Kala();

        #region Detail
        public OBJ_Kala Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Kala.Detail(id,OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_Kala> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return Kala.Select(FieldName, FilterValue,OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(string Name, byte KalaType, string KalaCode, byte Status, bool? Sell, bool ArzeshAfzodeh, string IranCode, byte MoshakhaseType, string Moshakhase, int VahedAsli, int VahedFaree, byte NesbatType, int? VahedMoadel, int UserId, int OrganId, string IP, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (Name == "" || Name == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام انبار ضروری است";
            }
            else if (KalaCode == "" || KalaCode == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کالا ضروری است";
            }
            else if (IranCode == "" || IranCode == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "ایران کد ضروری است";
            }
            else if (KalaType == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع کالا ضروری است";
            }
            else if (Status == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "وضعیت ضروری است";
            }
            else if (VahedAsli == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "واحد اصلی ضروری است";
            }
            else if (VahedFaree == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "واحد فرعی ضروری است";
            }
            else if (NesbatType == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع نسبت ضروری است";
            }
            else if (MoshakhaseType == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع مشخصه ضروری است";
            }
            else if (Name.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام انبار وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Name.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام انبار وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (KalaCode.Length > 20)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر کد کالا وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (IranCode.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر ایران کد وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (MoshakhaseType > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد نوع مشخصه از حد مجاز است";
            }
            else if (NesbatType > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد نوع نسبت از حد مجاز است";
            }
            else if (KalaType > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد نوع کالا از حد مجاز است";
            }
            else if (Status > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد وضعیت از حد مجاز است";
            }
            else if (Kala.CheckRepeatedRow(0, Name, KalaCode,OrganId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Kala.Insert(Name, KalaType, KalaCode, Status, Sell, ArzeshAfzodeh, IranCode, MoshakhaseType, Moshakhase, VahedAsli, VahedFaree, NesbatType, VahedMoadel, UserId, OrganId, IP, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string Name, byte KalaType, string KalaCode, byte Status, bool? Sell, bool ArzeshAfzodeh, string IranCode, byte MoshakhaseType, string Moshakhase, int VahedAsli, int VahedFaree, byte NesbatType, int? VahedMoadel, int UserId, int OrganId, string IP, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (Name == "" || Name == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام انبار ضروری است";
            }
            else if (KalaCode == "" || KalaCode == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کالا ضروری است";
            }
            else if (IranCode == "" || IranCode == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "ایران کد ضروری است";
            }
            else if (KalaType == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع کالا ضروری است";
            }
            else if (Status == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "وضعیت ضروری است";
            }
            else if (VahedAsli == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "واحد اصلی ضروری است";
            }
            else if (VahedFaree == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "واحد فرعی ضروری است";
            }
            else if (NesbatType == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع نسبت ضروری است";
            }
            else if (MoshakhaseType == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع مشخصه ضروری است";
            }
            else if (Name.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام انبار وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Name.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر نام انبار وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (KalaCode.Length > 20)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر کد کالا وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (IranCode.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر ایران کد وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (MoshakhaseType > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد نوع مشخصه از حد مجاز است";
            }
            else if (NesbatType > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد نوع نسبت از حد مجاز است";
            }
            else if (KalaType > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد نوع کالا از حد مجاز است";
            }
            else if (Status > 255)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار فیلد وضعیت از حد مجاز است";
            }
            else if (Kala.CheckRepeatedRow(Id, Name, KalaCode,OrganId))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Kala.Update(Id, Name, KalaType, KalaCode, Status, Sell, ArzeshAfzodeh, IranCode, MoshakhaseType, Moshakhase, VahedAsli, VahedFaree, NesbatType, VahedMoadel, UserId,OrganId, IP, Desc);

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

            return Kala.Delete(id, userId);
        }
        #endregion
    }
}