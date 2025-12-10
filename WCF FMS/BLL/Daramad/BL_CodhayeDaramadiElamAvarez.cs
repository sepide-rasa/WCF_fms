using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_CodhayeDaramadiElamAvarez
    {
        DL_CodhayeDaramadiElamAvarez CodhayeDaramadiElamAvarez = new DL_CodhayeDaramadiElamAvarez();

        #region Detail
        public OBJ_CodhayeDaramadiElamAvarez Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return CodhayeDaramadiElamAvarez.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_CodhayeDaramadiElamAvarez> Select(string FieldName, string FilterValue, int h)
        {
            return CodhayeDaramadiElamAvarez.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public int Insert(int ElamAvarezId, string SharheCodeDaramad, int ShomareHesabCodeDaramadId, long AsliValue, int Tedad, int UserId, string Desc, out ClsError error)
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
            else if (ElamAvarezId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اعلام عوارض ضروری است";
            }
            else if (ShomareHesabCodeDaramadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب درآمد ضروری است";
            }
            else if (AsliValue < 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار اصلی کمتر از حد مجاز است";
            }
            if (error.ErrorType == true)
                return 0;

            return CodhayeDaramadiElamAvarez.Insert(ElamAvarezId, SharheCodeDaramad, ShomareHesabCodeDaramadId, AsliValue, Tedad, UserId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int ElamAvarezId, string SharheCodeDaramad, int ShomareHesabCodeDaramadId, long AsliValue, int Tedad, int userId, string Desc, out ClsError error)
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
            else if (SharheCodeDaramad == "" || SharheCodeDaramad == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شرح کد درآمد ضروری است";
            }
            else if (ElamAvarezId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اعلام عوارض ضروری است";
            }
            else if (ShomareHesabCodeDaramadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب درآمد ضروری است";
            }
            else if (Tedad == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد ضروری است";
            }
            else if (AsliValue < 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار اصلی کمتر از حد مجاز است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CodhayeDaramadiElamAvarez.Update(Id, ElamAvarezId, SharheCodeDaramad, ShomareHesabCodeDaramadId, AsliValue, Tedad, userId, Desc);

        }
        #endregion
        #region Delete
        public string Delete(int id, string FieldName, int ElamAvarezId, int CodeDaramadId, int userId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (CodhayeDaramadiElamAvarez.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CodhayeDaramadiElamAvarez.Delete(id,FieldName,ElamAvarezId,CodeDaramadId, userId);
        }
        #endregion

        #region Insert_External
        public int Insert_External(int ElamAvarezId, string SharheCodeDaramad, int ShomareHesabCodeDaramadId, long AsliValue, int Tedad, long MaliyatValue, long AvarezValue, int UserId, string Desc, out ClsError error)
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
            else if (SharheCodeDaramad == "" || SharheCodeDaramad == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شرح کد درآمد ضروری است";
            }
            else if (ElamAvarezId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اعلام عوارض ضروری است";
            }
            else if (ShomareHesabCodeDaramadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب درآمد ضروری است";
            }
            else if (AsliValue < 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار اصلی کمتر از حد مجاز است";
            }
            else if (Tedad == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد ضروری است";
            }
            if (error.ErrorType == true)
                return 0;

            return CodhayeDaramadiElamAvarez.Insert_External(ElamAvarezId, SharheCodeDaramad, ShomareHesabCodeDaramadId, AsliValue, Tedad, MaliyatValue, AvarezValue, UserId, Desc);

        }
        #endregion
        #region Update_External
        public string Update_External(int ID, int ElamAvarezId, string SharheCodeDaramad, int ShomareHesabCodeDaramadId, long AsliValue, long AvarezValue, long MaliyatValue, int Tedad, int UserId, string Desc, out ClsError error)
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
            else if (ID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (SharheCodeDaramad == "" || SharheCodeDaramad == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شرح کد درآمد ضروری است";
            }
            else if (ElamAvarezId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اعلام عوارض ضروری است";
            }
            else if (ShomareHesabCodeDaramadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب درآمد ضروری است";
            }
            else if (AsliValue < 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار اصلی کمتر از حد مجاز است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CodhayeDaramadiElamAvarez.Update_External(ID, ElamAvarezId, SharheCodeDaramad, ShomareHesabCodeDaramadId, AsliValue, AvarezValue, MaliyatValue, Tedad, UserId, Desc);

        }
        #endregion

        #region TakhfifUpdate
        public string TakhfifUpdate(int Id, int Tedad, long TakhfifAsliValue, int ElamAvarezId, int UserId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (Tedad ==0 )
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد ضروری است";
            }
            else if (ElamAvarezId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اعلام عوارض ضروری است";
            }
            else if (TakhfifAsliValue < 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مقدار اصلی کمتر از حد مجاز است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CodhayeDaramadiElamAvarez.TakhfifUpdate(Id, Tedad, TakhfifAsliValue, ElamAvarezId, UserId);

        }
        #endregion
    }
}