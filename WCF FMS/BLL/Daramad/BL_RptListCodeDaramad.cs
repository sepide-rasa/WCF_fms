using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_RptListCodeDaramad
    {
        DL_RptListCodeDaramad ListCodeDaramad = new DL_RptListCodeDaramad();
        #region ListCodeDaramad_Donati
        public List<OBJ_RptListCodeDaramad_Donati> ListCodeDaramad_Donati(string AzTarikh, string TaTarikh, int OrganId, byte DateType)
        {
            return ListCodeDaramad.ListCodeDaramad_Donati(AzTarikh, TaTarikh, OrganId, DateType);
        }
        #endregion

        #region ListCodeDaramad_Gaje
        public List<OBJ_RptListCodeDaramad_Gaje> ListCodeDaramad_Gaje(string FieldName, string AzTarikh, string TaTarikh, string Value, int OrganId)
        {
            return ListCodeDaramad.ListCodeDaramad_Gaje(FieldName, AzTarikh, TaTarikh, Value, OrganId);
        }
        #endregion

        #region ListCodeDaramad_Day
        public List<OBJ_RptListCodeDaramad_Day> ListCodeDaramad_Day(string AzTarikh, string TaTarikh, int OrganId, byte DateType)
        {
            return ListCodeDaramad.ListCodeDaramad_Day(AzTarikh, TaTarikh, OrganId, DateType);
        }
        #endregion

        #region ListCodeDaramad_Month
        public List<OBJ_RptListCodeDaramad_Day> ListCodeDaramad_Month(string AzTarikh, string TaTarikh, int OrganId, byte DateType)
        {
            return ListCodeDaramad.ListCodeDaramad_Month(AzTarikh, TaTarikh, OrganId, DateType);
        }
        #endregion
    }
}