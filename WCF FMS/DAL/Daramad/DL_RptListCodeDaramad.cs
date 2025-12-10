using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_RptListCodeDaramad
    {
        #region ListCodeDaramad_Donati
        public List<OBJ_RptListCodeDaramad_Donati> ListCodeDaramad_Donati(string AzTarikh, string TaTarikh, int OrganId,byte DateType)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_RptListCodeDaramad_Donati(AzTarikh, TaTarikh, OrganId, DateType)
                    .Select(q => new OBJ_RptListCodeDaramad_Donati()
                    {
                        DaramadCodeTitle = q.DaramadCodeTitle,
                        DaramdTitleChilde = q.DaramdTitleChilde,
                        fldShomareHesab = q.fldShomareHesab,
                        fldShomareHesabId = q.fldShomareHesabId,
                        hidChilde = q.hidChilde,
                        LastNode = q.LastNode,
                        lvlChilde = q.lvlChilde,
                        Mablagh = q.Mablagh,
                        P_DaramadCode = q.P_DaramadCode,
                        P_DaramadTitle = q.P_DaramadTitle,
                        P_hid = q.P_hid,
                        P_Level = q.P_Level,
                    }).ToList();
                return k;
            }
        }
        #endregion

        #region ListCodeDaramad_Gaje
        public List<OBJ_RptListCodeDaramad_Gaje> ListCodeDaramad_Gaje(string FieldName, string AzTarikh, string TaTarikh, string Value, int OrganId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_RptListCodeDaramad_Gaje(FieldName, AzTarikh, TaTarikh, Value, OrganId)
                    .Select(q => new OBJ_RptListCodeDaramad_Gaje()
                    {
                        DaramadCodeChilde = q.DaramadCodeChilde,
                        DaramdTitleChilde = q.DaramdTitleChilde,
                        Mablagh = q.Mablagh,
                        MaxDaramadCodeChilde = q.MaxDaramadCodeChilde,
                        MaxDaramdTitleChilde = q.MaxDaramdTitleChilde,
                        MaxMablagh = q.MaxMablagh,
                        MinDaramadCodeChilde = q.MinDaramadCodeChilde,
                        MinDaramdTitleChilde = q.MinDaramdTitleChilde,
                        MinMablagh = q.MinMablagh,
                    }).ToList();
                return k;
            }
        }
        #endregion

        #region ListCodeDaramad_Day
        public List<OBJ_RptListCodeDaramad_Day> ListCodeDaramad_Day(string AzTarikh, string TaTarikh, int OrganId,byte DateType)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_RptListCodeDaramad_Day(AzTarikh, TaTarikh, OrganId, DateType)
                    .Select(q => new OBJ_RptListCodeDaramad_Day()
                    {
                        Mablagh=q.Mablagh,
                        TarikhPardakht = q.TarikhPardakht,
                        fldday = q.fldday
                    }).ToList();
                return k;
            }
        }
        #endregion

        #region ListCodeDaramad_Month
        public List<OBJ_RptListCodeDaramad_Day> ListCodeDaramad_Month(string AzTarikh, string TaTarikh, int OrganId,byte DateType)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_RptListCodeDaramad_Month(AzTarikh, TaTarikh, OrganId, DateType)
                    .Select(q => new OBJ_RptListCodeDaramad_Day()
                    {
                        Mablagh = q.Mablagh,
                        fldmonth = q.fldmonth,
                        fldNameMah = q.fldNameMah,
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}