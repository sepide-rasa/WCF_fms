using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_SodoorFish
    {
        DL_SodoorFish SodoorFish = new DL_SodoorFish();

        #region Detail
        public OBJ_SodoorFish Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return SodoorFish.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_SodoorFish> Select(string FieldName, string FilterValue, int h)
        {
            return SodoorFish.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public int Insert(int ElamAvarezId, int ShomareHesabId, long MablaghAvarezGerdShode, byte ShorooShenaseGhabz, long JamKol, int userId, string Desc, out ClsError error)
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
            if (error.ErrorType == true)
                return 0;

            return SodoorFish.Insert(ElamAvarezId, ShomareHesabId, MablaghAvarezGerdShode, ShorooShenaseGhabz,JamKol, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int ElamAvarezId, int ShomareHesabId, long MablaghAvarezGerdShode, byte ShorooShenaseGhabz, long JamKol, int userId, string Desc, out ClsError error)
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

            if (error.ErrorType == true)
                return "خطا";

            return SodoorFish.Update(Id, ElamAvarezId, ShomareHesabId, MablaghAvarezGerdShode, ShorooShenaseGhabz, JamKol, userId, Desc);

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
            else if (SodoorFish.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return SodoorFish.Delete(id, userId);
        }
        #endregion
        #region selectEbtal_SodoorFish
        public List<OBJ_SodoorFish> selectEbtal_SodoorFish(int ElamAvarezId)
        {
            return SodoorFish.selectEbtal_SodoorFish(ElamAvarezId);
        }
        #endregion

        #region UpdateShenaseGhabz_Pardakht
        public string UpdateShenaseGhabz_Pardakht(int FishId, string ShenaseGhabz, string ShenasePardakht, string Barcode, int userId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (FishId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد فیش ضروری است";
            }
            else if (ShenaseGhabz == "" || ShenaseGhabz==null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه قبض ضروری است";
            }
            else if (ShenasePardakht == "" || ShenasePardakht == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه پرداخت ضروری است";
            }
            else if (Barcode == "" || Barcode == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "بارکد ضروری است";
            }
            /*else if (ShenaseGhabz.Length < 13)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه قبض وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (ShenaseGhabz.Length > 13)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه قبض وارد شده بیشتر از حد مجاز میباشد.";
            }
            else if (ShenasePardakht.Length < 13)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه پرداخت وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (ShenasePardakht.Length > 13)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه پرداخت وارد شده بیشتر از حد مجاز میباشد.";
            }*/
            else if (Barcode.Length < 26)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر بارکد وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Barcode.Length > 26)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر بارکد وارد شده بیشتر از حد مجاز میباشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return SodoorFish.UpdateShenaseGhabz_Pardakht(FishId, ShenaseGhabz, ShenasePardakht,Barcode, userId);

        }
        #endregion
        #region InsertSodoorFishForNaghdi_Talab
        public int InsertSodoorFishForNaghdi_Talab(int OrganId, long Mablagh, int ElamAvarezId, int naghdiTalabId, int ShomareHesabId, int UserId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


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
            else if (ElamAvarezId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه قبض ضروری است";
            }
            else if (naghdiTalabId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نقدی-طلب ضروری است";
            }
            else if (ShomareHesabId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد شماره حساب عمومی ضروری است";
            }
            if (error.ErrorType == true)
                return 0;

            return SodoorFish.InsertSodoorFishForNaghdi_Talab(OrganId, Mablagh, ElamAvarezId, naghdiTalabId, ShomareHesabId, UserId, Desc);

        }
        #endregion
        #region DetailSodoorFish
        public List<OBJ_DetailSodoorFish> DetailSodoorFish(int ElamAvarezId, int ShomareHesabId, byte ShorooShenaseGhabz)
        {
            return SodoorFish.DetailSodoorFish(ElamAvarezId, ShomareHesabId, ShorooShenaseGhabz);
        }
        #endregion
        #region UpdateSendToMali_Fish
        public string UpdateSendToMali_Fish(string FieldName, bool Flag, int id, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return SodoorFish.UpdateSendToMali_Fish(FieldName, Flag, id);

        }
        #endregion
        #region Ashkhas_Fish
        public List<OBJ_Ashkhas_Fish> Ashkhas_Fish(int ElamAvarezId)
        {
            return SodoorFish.Ashkhas_Fish(ElamAvarezId);
        }
        #endregion
    }
}