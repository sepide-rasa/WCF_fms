using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_DisketBime
    {
        DL_DisketBime DisketBime = new DL_DisketBime();
        
        #region Select
        public List<OBJ_DisketBime> Select(short sal, byte mah, int kargaBime, byte nobat)
        {
            return DisketBime.Select(sal, mah, kargaBime, nobat);
        }
        #endregion
        #region SelectDisketBimeSum
        public List<OBJ_DisketBimeSum> SelectDisketBimeSum(short sal, byte mah, int kargaBime, byte nobat)
        {
            return DisketBime.SelectDisketBimeSum(sal, mah, kargaBime, nobat);
        }
        #endregion
        #region SelectBASTAM
        public List<OBJ_DisketBime> SelectBASTAM(short sal, byte mah, int kargaBime, byte nobat)
        {
            return DisketBime.SelectBASTAM(sal, mah, kargaBime, nobat);
        }
        #endregion
        #region SelectDisketBime_DBF
        public List<OBJ_DisketBime_DBF> SelectDisketBime_DBF(short sal, byte mah, int kargaBime, byte nobat)
        {
            return DisketBime.SelectDisketBime_DBF(sal, mah, kargaBime, nobat);
        }
        #endregion
        #region SelectDisketBime_DBF_Header
        public OBJ_DisketBime_DBF_Header SelectDisketBime_DBF_Header(short sal, byte mah, int kargaBime, byte nobat)
        {
            return DisketBime.SelectDisketBime_DBF_Header(sal, mah, kargaBime, nobat);
        }
        #endregion
        #region InsertInsuranceJobs
        public string InsertInsuranceJobs()
        {
            return DisketBime.InsertInsuranceJobs();
        }
        #endregion
        
    }
}