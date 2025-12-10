using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_AkharinHokmSal
    {

        #region Select
        public List<OBJ_AkharinHokmSal> Select(int PersonalId, string Year)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblAkharinHokmSal(PersonalId, Year)
                    .Select(q => new OBJ_AkharinHokmSal()
                    {
                        fldAnvaeEstekhdamId=q.fldAnvaeEstekhdamId,
                        fldCodeShoghl=q.fldCodeShoghl,
                        fldDate=q.fldDate,
                        fldDesc=q.fldDesc,
                        fldDescriptionHokm=q.fldDescriptionHokm,
                        fldGroup=q.fldGroup,
                        fldId=q.fldId,
                        fldMoreGroup=q.fldMoreGroup,
                        fldPrs_PersonalInfoId=q.fldPrs_PersonalInfoId,
                        fldShomareHokm=q.fldShomareHokm,
                        fldShomarePostSazmani=q.fldShomarePostSazmani,
                        fldStatusHokm=q.fldStatusHokm,
                        fldStatusTaaholId=q.fldStatusTaaholId,
                        fldTarikhEjra=q.fldTarikhEjra,
                        fldTarikhEtmam=q.fldTarikhEtmam,
                        fldTarikhSodoor=q.fldTarikhSodoor,
                        fldTedadAfradTahteTakafol=q.fldTedadAfradTahteTakafol,
                        fldTedadFarzand=q.fldTedadFarzand,
                        fldTypehokm=q.fldTypehokm,
                        fldUserId=q.fldUserId,
                        fldYear = q.fldYear
                    }).ToList();
                return k;
            }
        }
        #endregion
       
    }
}