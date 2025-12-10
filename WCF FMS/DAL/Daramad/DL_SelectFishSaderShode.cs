using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_SelectFishSaderShode
    {
        #region Select
        public List<OBJ_FishSaderShode> Select(string FieldName, string FilterValue, string AzTarikh,string TaTarikh,int UserId,int OrganId,int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_SelectFishSaderShode(FieldName, FilterValue, AzTarikh,TaTarikh,UserId,OrganId,h)
                    .Select(q => new OBJ_FishSaderShode()
                    {
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAshakhasID=q.fldAshakhasID,
                        fldBarcode=q.fldBarcode,
                        fldElamAvarezId=q.fldElamAvarezId,
                        fldFather_ShomareSabt=q.fldFather_ShomareSabt,
                        fldJamKol=q.fldJamKol,
                        fldMablaghAvarezGerdShode=q.fldMablaghAvarezGerdShode,
                        fldNameShakhs=q.fldNameShakhs,
                        fldNoeShakhs=q.fldNoeShakhs,
                        fldShenaseGhabz=q.fldShenaseGhabz,
                        fldShenasePardakht=q.fldShenasePardakht,
                        fldShomareHesabId=q.fldShomareHesabId,
                        fldShorooShenaseGhabz=q.fldShorooShenaseGhabz,
                        fldTypeAvarez = q.fldTypeAvarez,
                        fldTarikh = q.fldTarikh,
                        fldNationalCode = q.fldNationalCode,
                        fldMashmool = q.fldMashmool,
                        fldPardakhFish = q.fldPardakhFish,
                        fldPcposUser = q.fldPcposUser,
                        fldShomareHesab = q.fldShomareHesab,
                        fldShomareSheba = q.fldShomareSheba,
                        fldTarikhPardakhFish = q.fldTarikhPardakhFish
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}