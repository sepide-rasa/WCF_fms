using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_PcPosTransaction
    {
        DL_PcPosTransaction PcPosTransaction = new DL_PcPosTransaction();

        #region Detail
        public OBJ_PcPosTransaction Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return PcPosTransaction.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_PcPosTransaction> Select(string FieldName, string FilterValue, int h)
        {
            return PcPosTransaction.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public int Insert(int FishId, long Price, bool Status, string TrackingCode, string ShGhabz, string ShPardakht, string TerminalCode, string SerialNumber, string CardNumber, string Tarikh, int userId, string Desc, out ClsError error)
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
            else if (FishId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد صدور فیش ضروری است";
            }
            //else if (ShGhabz == "" || ShGhabz == null)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "شناسه قبض ضروری است";
            //}
            //else if (ShPardakht == "" || ShPardakht == null)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "شناسه پرداخت ضروری است";
            //}
            else if (ShGhabz.Length > 20)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه قبض وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ShPardakht.Length > 20)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه پرداخت وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return 0;

            return PcPosTransaction.Insert(FishId, Price, Status, TrackingCode, ShGhabz, ShPardakht,TerminalCode,SerialNumber,CardNumber,Tarikh, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int FishId, long Price, bool Status, string TrackingCode, string ShGhabz, string ShPardakht, string TerminalCode, string SerialNumber, string CardNumber, string Tarikh, int userId, string Desc, out ClsError error)
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
            else if (FishId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد صدور فیش ضروری است";
            }
            else if (TrackingCode == "" || TrackingCode == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد رهگیری ضروری است";
            }
            //else if (ShGhabz == "" || ShGhabz == null)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "شناسه قبض ضروری است";
            //}
            //else if (ShPardakht == "" || ShPardakht == null)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "شناسه پرداخت ضروری است";
            //}
            else if (TrackingCode.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر کد رهگیری وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ShGhabz.Length > 20)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه قبض وارده شده بیشتر از حد مجاز می باشد.";
            }
            else if (ShPardakht.Length > 20)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر شناسه پرداخت وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PcPosTransaction.Update(Id, FishId, Price, Status, TrackingCode, ShGhabz, ShPardakht,TerminalCode,SerialNumber,CardNumber,Tarikh, userId, Desc);

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
            if (error.ErrorType == true)
                return "خطا";

            return PcPosTransaction.Delete(id, userId);
        }
        #endregion
        #region PcPosTransactionUpdate_Status
        public string PcPosTransactionUpdate_Status(int Id, string TrackingCode, string TerminalCode, string SerialNumber, string CardNumber, string Tarikh, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (Desc == null)
                Desc = "";
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (TrackingCode == "" || TrackingCode == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد رهگیری ضروری است";
            }
            else if (TrackingCode.Length > 50)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر کد رهگیری وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PcPosTransaction.PcPosTransactionUpdate_Status(Id,TrackingCode,TerminalCode,SerialNumber,CardNumber,Tarikh, Desc);

        }
        #endregion
    }
}