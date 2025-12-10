using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_DisketPasAndaz
    {
        #region Select
        public List<OBJ_DisketPasAndaz> Select(short sal, byte mah, byte nobat,int organid)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_DisketPasAndaz(sal, mah, nobat,organid)
                    .Select(q => new OBJ_DisketPasAndaz()
                    {
                        fldPasAndaz = q.fldPasAndaz,
                        fldShPasAndazPersonal = q.fldShPasAndazPersonal,
                        fldShPasAndazKarFarma = q.fldShPasAndazKarFarma,
                        fldNoeEstekhdam = q.fldNoeEstekhdam,
                        fldName=q.fldName,
                        fldFamily=q.fldFamily,
                        fldFatherName=q.fldFatherName,
                        fldCodemeli=q.fldCodemeli
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}