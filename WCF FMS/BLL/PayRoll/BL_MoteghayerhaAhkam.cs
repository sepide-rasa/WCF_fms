using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_MoteghayerhaAhkam
    {
        DL_MoteghayerhaAhkam MoteghayerhaAhkam = new DL_MoteghayerhaAhkam();
        #region Detail
        public OBJ_MoteghayerhaAhkam Detail(int Id, out ClsError Error)
        {
            Error = new ClsError();
            if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            return MoteghayerhaAhkam.Detail(Id);
        }
        #endregion
        #region Select
        public List<OBJ_MoteghayerhaAhkam> Select(string FieldName, string FilterValue, int h)
        {
            return MoteghayerhaAhkam.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(short Year, bool Type, int HagheOlad, int HagheAeleMandi, int KharoBar, int Maskan, int KharoBarMojarad, int HadaghalDaryafti, int HaghBon, int HadaghalTadil, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Year == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال ضروری است";
            }

            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
                return "خطا";
            return MoteghayerhaAhkam.Insert(Year, Type, HagheOlad, HagheAeleMandi, KharoBar, Maskan, KharoBarMojarad, HadaghalDaryafti, HaghBon,HadaghalTadil, UserId, Desc);
        }
        #endregion
        #region Update
        public string Update(int Id, short Year, bool Type, int HagheOlad, int HagheAeleMandi, int KharoBar, int Maskan, int KharoBarMojarad, int HadaghalDaryafti, int HaghBon, int HadaghalTadil, int UserId, string Desc, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه ضروری است";
            }
            else if (Year == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "سال ضروری است";
            }

            if (Desc == null)
                Desc = "";
            if (Error.ErrorType == true)
            {
                return "خطا";
            }
            return MoteghayerhaAhkam.Update(Id, Year, Type, HagheOlad, HagheAeleMandi, KharoBar, Maskan, KharoBarMojarad, HadaghalDaryafti, HaghBon,HadaghalTadil, UserId, Desc);
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId, out ClsError Error)
        {
            Error = new ClsError();
            if (UserId == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                Error.ErrorType = true;
                Error.ErrorMsg = "کد ضروری است";
            }
            if (Error.ErrorType == true)
                return "خطا";
            return MoteghayerhaAhkam.Delete(Id, UserId);
        }
        #endregion
    }
}