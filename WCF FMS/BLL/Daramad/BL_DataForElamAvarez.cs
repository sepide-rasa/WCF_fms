using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_DataForElamAvarez
    {
        DL_DataForElamAvarez DataForElamAvarez = new DL_DataForElamAvarez();
        #region Select
        public List<OBJ_DataForElamAvarez> Select(string FieldName, string FilterValue, string AzTarikh, string TaTarikh, byte Type, int OrganId, int h)
        {
            return DataForElamAvarez.Select(FieldName, FilterValue, AzTarikh, TaTarikh, Type, OrganId, h);
        }
        #endregion
        #region DataForElamAvarez_Check
        public List<OBJ_DataForElamAvarez> DataForElamAvarez_Check(string FieldName, string FilterValue, string AzTarikh, string TaTarikh, int OrganId, int h)
        {
            return DataForElamAvarez.DataForElamAvarez_Check(FieldName, FilterValue, AzTarikh, TaTarikh, OrganId, h);
        }
        #endregion
        #region DataForElamAvarez_Barat
        public List<OBJ_DataForElamAvarez> DataForElamAvarez_Barat(string FieldName, string FilterValue, string AzTarikh, string TaTarikh, int OrganId, int h)
        {
            return DataForElamAvarez.DataForElamAvarez_Barat(FieldName, FilterValue, AzTarikh, TaTarikh, OrganId, h);
        }
        #endregion
        #region DataForElamAvarez_Safte
        public List<OBJ_DataForElamAvarez> DataForElamAvarez_Safte(string FieldName, string FilterValue, string AzTarikh, string TaTarikh, int OrganId, int h)
        {
            return DataForElamAvarez.DataForElamAvarez_Safte(FieldName, FilterValue, AzTarikh, TaTarikh, OrganId, h);
        }
        #endregion
    }
}