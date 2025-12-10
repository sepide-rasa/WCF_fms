using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_SodoorFish
    {
        #region Detail
        public OBJ_SodoorFish Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblSodoorFishSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_SodoorFish()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldElamAvarezId = q.fldElamAvarezId,
                        fldMablaghAvarezGerdShode = q.fldMablaghAvarezGerdShode,
                        fldShenaseGhabz = q.fldShenaseGhabz,
                        fldShomareHesabId = q.fldShomareHesabId,
                        fldShorooShenaseGhabz = q.fldShorooShenaseGhabz,
                        fldShenasePardakht = q.fldShenasePardakht,
                        fldStatusName = q.fldStatusName,
                        fldStatusId = q.fldStatusId,
                        fldJamKol = q.fldJamKol,
                        fldBarcode = q.fldBarcode,
                        fldSendToMaliFlag = q.fldSendToMaliFlag,
                        fldFishSentFlag = q.fldFishSentFlag,
                        fldDateSendToMali = q.fldDateSendToMali,
                        fldDateFishSent = q.fldDateFishSent,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_SodoorFish> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblSodoorFishSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_SodoorFish()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldElamAvarezId = q.fldElamAvarezId,
                        fldMablaghAvarezGerdShode = q.fldMablaghAvarezGerdShode,
                        fldShenaseGhabz = q.fldShenaseGhabz,
                        fldShomareHesabId = q.fldShomareHesabId,
                        fldShorooShenaseGhabz = q.fldShorooShenaseGhabz,
                        fldShenasePardakht = q.fldShenasePardakht,
                        fldStatusName = q.fldStatusName,
                        fldStatusId = q.fldStatusId,
                        fldJamKol = q.fldJamKol,
                        fldBarcode = q.fldBarcode,
                        fldSendToMaliFlag = q.fldSendToMaliFlag,
                        fldFishSentFlag = q.fldFishSentFlag,
                        fldDateSendToMali = q.fldDateSendToMali,
                        fldDateFishSent = q.fldDateFishSent,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(int ElamAvarezId,int ShomareHesabId, long MablaghAvarezGerdShode, byte ShorooShenaseGhabz,long JamKol, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter id = new System.Data.Entity.Core.Objects.ObjectParameter("fldId", typeof(int));
                p.spr_tblSodoorFishInsert(id,ElamAvarezId, ShomareHesabId, MablaghAvarezGerdShode, ShorooShenaseGhabz, UserId, Desc,JamKol);
                return Convert.ToInt32(id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int ElamAvarezId, int ShomareHesabId, long MablaghAvarezGerdShode, byte ShorooShenaseGhabz, long JamKol, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblSodoorFishUpdate(Id, ElamAvarezId, ShomareHesabId, MablaghAvarezGerdShode, ShorooShenaseGhabz, UserId, Desc, JamKol);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblSodoorFishDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region selectEbtal_SodoorFish
        public List<OBJ_SodoorFish> selectEbtal_SodoorFish(int ElamAvarezId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_selectEbtal_SodoorFish(ElamAvarezId)
                    .Select(q => new OBJ_SodoorFish()
                    {
                        fldAvarez=q.fldAvarez,
                        fldElamAvarezId=q.fldElamAvarezId,
                        fldId=q.fldId,
                        fldItem=q.fldItem,
                        fldJamFish=q.fldJamFish,
                        fldJamKol=q.fldjamkol,
                        fldMaliyat=q.fldMaliyat,
                        fldShenaseGhabz=q.fldShenaseGhabz,
                        fldShenasePardakht=q.fldShenasePardakht,
                        fldShomareHesab=q.fldShomareHesab,
                        fldShomareHesabId=q.fldShomareHesabId,
                        fldShorooShenaseGhabz = q.fldShorooshenaseGhabz,
                        fldStatus = q.fldStatus,
                        fldAsliValue=q.fldAsliValue,
                        fldOrganId = q.fldOrganId,
                        fldMablaghTakhfif = q.fldMablaghTakhfif,
                        PardakhtStatus = q.PardakhtStatus,
                        fldAmuzeshParvareshValue = q.fldAmuzeshParvareshValue
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var C = p.spr_tblSodoorFish_DetailSelect("fldFishId", Id.ToString(), 0).FirstOrDefault();
                var Ebtal = p.spr_tblEbtalSelect("fldFishId", Id.ToString(), 0).FirstOrDefault();
                var N = p.spr_tblPardakhtFishSelect("fldFishId", Id.ToString(), 0).FirstOrDefault();
                var Factor = p.spr_tblFactorSelect("fldFishId", Id.ToString(), 0).FirstOrDefault();
                var Pc = p.spr_tblPcPosTransactionSelect("fldFishId", Id.ToString(), 0).FirstOrDefault();
                var Naghdi = p.spr_tblNaghdi_TalabSelect("fldFishId", Id.ToString(), 0).FirstOrDefault();
                if (C != null || Ebtal != null || N != null || Factor != null || Pc != null || Naghdi!=null)
                    q = true;
                return q;
            }
        }
        #endregion
        #region UpdateShenaseGhabz_Pardakht
        public string UpdateShenaseGhabz_Pardakht(int FishId, string ShenaseGhabz, string ShenasePardakht,string Barcode, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_UpdateSodoorFishShenaseGhabz_Pardakht(FishId, ShenaseGhabz, ShenasePardakht,UserId,Barcode);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region InsertSodoorFishForNaghdi_Talab
        public int InsertSodoorFishForNaghdi_Talab(int OrganId, long Mablagh, int ElamAvarezId, int naghdiTalabId,int ShomareHesabId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldId", typeof(int));
                p.spr_InsertSodoorFishForNaghdi_Talab(Id, OrganId, Mablagh, ElamAvarezId, naghdiTalabId, ShomareHesabId, UserId, Desc);
                return Convert.ToInt32(Id.Value);
            }
        }
        #endregion
        #region DetailSodoorFish
        public List<OBJ_DetailSodoorFish> DetailSodoorFish(int ElamAvarezId, int ShomareHesabId, byte ShorooShenaseGhabz)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_SelectDetailSodoorFish(ElamAvarezId, ShomareHesabId, ShorooShenaseGhabz)
                    .Select(q => new OBJ_DetailSodoorFish()
                    {
                        fldAsliValue = q.fldAsliValue,
                        fldAvarezValue = q.fldAvarezValue,
                        fldCodeDaramadId = q.fldCodeDaramadId,
                        fldMaliyatValue = q.fldMaliyatValue,
                        fldSharheCodeDaramad = q.fldSharheCodeDaramad,
                        fldShomareHesabId = q.fldShomareHesabId,
                        fldShomareHesab = q.fldShomareHesab,
                        fldShorooshenaseGhabz = q.fldShorooshenaseGhabz,
                        fldAmuzeshParvareshValue = q.fldAmuzeshParvareshValue
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region UpdateSendToMali_Fish
        public string UpdateSendToMali_Fish(string FieldName, bool Flag, int id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_UpdateSendToMali_Fish(FieldName, Flag, id);
                return "عملیات با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Ashkhas_Fish
        public List<OBJ_Ashkhas_Fish> Ashkhas_Fish(int ElamAvarezId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_SelectAshkhas_Fish(ElamAvarezId)
                    .Select(q => new OBJ_Ashkhas_Fish()
                    {
                        fldBarcode = q.fldBarcode,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldJamKol = q.fldJamKol,
                        fldMablaghAvarezGerdShode = q.fldMablaghAvarezGerdShode,
                        fldShenaseGhabz = q.fldShenaseGhabz,
                        fldShenasePardakht = q.fldShenasePardakht,
                        fldShomareHesab = q.fldShomareHesab,
                        fldShomareHesabId = q.fldShomareHesabId,
                        fldShorooShenaseGhabz = q.fldShorooShenaseGhabz,
                        fldStatus = q.fldStatus,
                        fldTarikh = q.fldTarikh,
                        fldTarikhPardakht = q.fldTarikhPardakht,
                        NoePardakht = q.NoePardakht,
                        fldAsliValue = q.fldAsliValue,
                        fldMaliyatValue = q.fldMaliyatValue,
                        fldAvarezValue = q.fldAvarezValue,
                        fldTarikhVariz = q.fldTarikhVariz
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}