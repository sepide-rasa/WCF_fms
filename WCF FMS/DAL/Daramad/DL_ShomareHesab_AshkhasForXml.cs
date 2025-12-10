using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_ShomareHesab_AshkhasForXml
    {
        #region AshkhasIdForXmlInput
        public int AshkhasIdForXmlInput(byte type, int userId, string codeMeli, string name, string family, string shomareSabt, byte typeShakhs)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_AshkhasIdForXmlInput(type,userId,codeMeli,name,family,shomareSabt,typeShakhs).FirstOrDefault();
                return Convert.ToInt32(k.IdOutput);
            }
        }
        #endregion

        #region ShomareHesabIdForXml
        public int ShomareHesabIdForXml(string shomareHesab, string infBank, int ashkhasId, int userId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_ShomareHesabIdForXmlInput(shomareHesab,infBank,ashkhasId,userId).FirstOrDefault();
                return Convert.ToInt32(k.fldId);
            }
        }
        #endregion

        #region FishSaderShodeForXml
        public List<OBJ_FishSaderShodeForXml> FishSaderShodeForXml(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_FishSaderShodeForXmlOut(FieldName, FilterValue, h)
                    .Select(q => new OBJ_FishSaderShodeForXml()
                    {
                        Avarez = q.Avarez,
                        CodeDaramadElamAvarez = q.CodeDaramadElamAvarez,
                        CodeErja = q.CodeErja,
                        CodeMeli = q.CodeMeli,
                        CodeRahgiri = q.CodeRahgiri,
                        ElamAvarezId = q.ElamAvarezId,
                        FamilyMoadi = q.FamilyMoadi,
                        Infi_Bank = q.Infi_Bank,
                        MablaghPardakhtShode = q.MablaghPardakhtShode,
                        Maliyat = q.Maliyat,
                        NameBank = q.NameBank,
                        NameMoadi = q.NameMoadi,
                        NoeMoadi = q.NoeMoadi,
                        NoePardakht = q.NoePardakht,
                        NoeSherkat = q.NoeSherkat,
                        OrganName = q.OrganName,
                        SerialFish = q.SerialFish,
                        ShenaseMeliOrgan = q.ShenaseMeliOrgan,
                        ShenaseMeliSherkat = q.ShenaseMeliSherkat,
                        ShomareHesabVariz = q.ShomareHesabVariz,
                        ShomareSabt = q.ShomareSabt,
                        TarikhPardakht = q.TarikhPardakht,
                        TarikhSodoor = q.TarikhSodoor,
                        TarikhVarizBeHesab = q.TarikhVarizBeHesab,
                        fldSendToMaliFlag = q.fldSendToMaliFlag,
                        fldFishSentFlag = q.fldFishSentFlag,
                        fldDateSendToMali = q.fldDateSendToMali,
                        fldDateFishSent = q.fldDateFishSent,
                        AmuzeshParvaresh = q.AmuzeshParvaresh
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}