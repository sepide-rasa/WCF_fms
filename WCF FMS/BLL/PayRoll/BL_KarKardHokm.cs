using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_KarKardHokm
    {
        DL_KarKardHokm KarKardHokm = new DL_KarKardHokm();
        #region Detail
        public OBJ_KarKardHokm Detail(int Id,  out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            return KarKardHokm.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_KarKardHokm> Select(string FieldName, string FilterValue, string FilterValue2, int KarkardId, decimal Roz, decimal Gheybat, int h)
        {
            return KarKardHokm.Select(FieldName, FilterValue, FilterValue2, KarkardId, Roz,  Gheybat, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldKarkardId, int fldHokmId, decimal fldRoze, decimal fldGheybat, out ClsError Error)
        {
            Error = new ClsError();
            if (fldKarkardId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کارکرد ضروری است";
            }

            else if (fldHokmId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد حکم ضروری است";
            }
           
            
            if (Error.ErrorType == true)
                return "خطا";
            return KarKardHokm.Insert(fldKarkardId, fldHokmId, fldRoze, fldGheybat);
        }
        #endregion
        #region Update
        public string Update(int Id, int fldKarkardId, int fldHokmId, decimal fldRoze, decimal fldGheybat, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            else if (fldKarkardId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کارکرد ضروری است";
            }

            else if (fldHokmId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد حکم ضروری است";
            }
            
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return KarKardHokm.Update(Id, fldKarkardId, fldHokmId, fldRoze,  fldGheybat);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            
            if (Error.ErrorType == true)
                return "خطا";
            return KarKardHokm.Delete(Id, UserId);
        }
        #endregion

        
    }
}