using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_ShomareHesab_AshkhasForXml
    {
        DL_ShomareHesab_AshkhasForXml ForXml = new DL_ShomareHesab_AshkhasForXml();
        public int AshkhasIdForXmlInput(byte type, int userId, string codeMeli, string name, string family, string shomareSabt, byte typeShakhs)
        {
            return ForXml.AshkhasIdForXmlInput(type, userId, codeMeli, name, family, shomareSabt, typeShakhs);
        }

        public int ShomareHesabIdForXml(string shomareHesab, string infBank, int ashkhasId, int userId)
        {
            return ForXml.ShomareHesabIdForXml(shomareHesab, infBank, ashkhasId, userId);
        }

        #region FishSaderShodeForXml
        public List<OBJ_FishSaderShodeForXml> FishSaderShodeForXml(string FieldName, string FilterValue, int h)
        {
            return ForXml.FishSaderShodeForXml(FieldName, FilterValue, h);
        }
        #endregion
    }
}