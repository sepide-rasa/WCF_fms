using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Weigh;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.BLL.Weigh
{
    public class BL_Arze
    {
        DL_Arze Arze = new DL_Arze();

        #region Detail
        public OBJ_Arze Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Arze.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Arze> Select(string FieldName, string FilterValue,int OrganId, int h)
        {
            return Arze.Select(FieldName, FilterValue,OrganId, h);
        }
        #endregion
        #region Insert
        public int Insert(int fldBaskoolId, int fldKalaId, int ShomareHesabCodeDaramadId, byte Tedad, long Mablagh, int OrganizationId, byte Type,int? fldVaznVahed, int userId, string Desc, string IP, out ClsError error)
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
            else if (fldBaskoolId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد باسکول ضروری است";
            }
            //else if (Type == 0)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "نحوه فروش ضروری است";
            //}
            else if (fldKalaId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کالا ضروری است";
            }
            else if (ShomareHesabCodeDaramadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره حساب درآمد ضروری است";
            }
            else if (OrganizationId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            if (error.ErrorType == true)
                return 0;

            return Arze.Insert(fldBaskoolId, fldKalaId, ShomareHesabCodeDaramadId, Tedad, Mablagh, OrganizationId,Type,fldVaznVahed, userId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int fldId, int fldBaskoolId, int fldKalaId, int ShomareHesabCodeDaramadId, byte Tedad, long Mablagh, int OrganizationId,byte Type,int? fldVaznVahed, int userId, string Desc, string IP, out ClsError error)
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
                error.ErrorMsg = "کد ضروری است";
            }
            else if (fldBaskoolId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد باسکول ضروری است";
            }
            //else if (Type == 0)
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "نحوه فروش ضروری است";
            //}
            else if (fldKalaId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کالا ضروری است";
            }
            else if (ShomareHesabCodeDaramadId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شماره حساب درآمد ضروری است";
            }
            else if (OrganizationId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Arze.Update(fldId, fldBaskoolId, fldKalaId, ShomareHesabCodeDaramadId, Tedad, Mablagh, OrganizationId,Type,fldVaznVahed, userId, Desc, IP);

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

            return Arze.Delete(id, userId);
        }
        #endregion

        #region SelectArze_Kala
        public List<OBJ_Arze_Kala> SelectArze_Kala(int BaskoolId, int OrganId)
        {
            return Arze.SelectArze_Kala(BaskoolId, OrganId);
        }
        #endregion
    }
}