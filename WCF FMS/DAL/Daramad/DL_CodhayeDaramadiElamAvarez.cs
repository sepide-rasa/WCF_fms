using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_CodhayeDaramadiElamAvarez
    {
        #region Detail
        public OBJ_CodhayeDaramadiElamAvarez Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblCodhayeDaramadiElamAvarezSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_CodhayeDaramadiElamAvarez()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldID = q.fldID,
                        fldUserId = q.fldUserId,
                        fldAsliValue = q.fldAsliValue,
                        fldAvarezValue = q.fldAvarezValue,
                        fldShomareHesabCodeDaramadId = q.fldShomareHesabCodeDaramadId,
                        fldElamAvarezId = q.fldElamAvarezId,
                        fldMaliyatValue = q.fldMaliyatValue,
                        fldSharheCodeDaramad = q.fldSharheCodeDaramad,
                        fldShomareHesabId = q.fldShomareHesabId,
                        codeDaramadTitle = q.codeDaramadTitle,
                        fldTedad = q.fldTedad,
                        fldDaramadTitle = q.fldDaramadTitle,
                        fldDaramadCode = q.fldDaramadCode,
                        fldShorooshenaseGhabz = q.fldShorooshenaseGhabz,
                        fldSumMablgh = q.fldSumMablgh,
                        fldTakhfifAsliValue=q.fldTakhfifAsliValue,
                        fldTakhfifAvarezValue=q.fldTakhfifAvarezValue,
                        fldTakhfifMaliyatValue=q.fldTakhfifMaliyatValue,
                        fldAmuzeshParvareshValue = q.fldAmuzeshParvareshValue,
                        fldTakhfifAmuzeshParvareshValue = q.fldTakhfifAmuzeshParvareshValue
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_CodhayeDaramadiElamAvarez> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblCodhayeDaramadiElamAvarezSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_CodhayeDaramadiElamAvarez()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldID = q.fldID,
                        fldUserId = q.fldUserId,
                        fldAsliValue = q.fldAsliValue,
                        fldAvarezValue = q.fldAvarezValue,
                        fldShomareHesabCodeDaramadId = q.fldShomareHesabCodeDaramadId,
                        fldElamAvarezId = q.fldElamAvarezId,
                        fldMaliyatValue = q.fldMaliyatValue,
                        fldSharheCodeDaramad = q.fldSharheCodeDaramad,
                        fldShomareHesabId = q.fldShomareHesabId,
                        codeDaramadTitle = q.codeDaramadTitle,
                        fldTedad = q.fldTedad,
                        fldDaramadTitle = q.fldDaramadTitle,
                        fldDaramadCode = q.fldDaramadCode,
                        fldShorooshenaseGhabz = q.fldShorooshenaseGhabz,
                        fldSumMablgh = q.fldSumMablgh,
                        fldTakhfifAsliValue = q.fldTakhfifAsliValue,
                        fldTakhfifAvarezValue = q.fldTakhfifAvarezValue,
                        fldTakhfifMaliyatValue = q.fldTakhfifMaliyatValue,
                        fldAmuzeshParvareshValue = q.fldAmuzeshParvareshValue,
                        fldTakhfifAmuzeshParvareshValue = q.fldTakhfifAmuzeshParvareshValue
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(int ElamAvarezId, string SharheCodeDaramad, int ShomareHesabCodeDaramadId, long AsliValue, int Tedad, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldID", typeof(int));
                p.spr_tblCodhayeDaramadiElamAvarezInsert(Id,ElamAvarezId, SharheCodeDaramad, ShomareHesabCodeDaramadId, Tedad, AsliValue, UserId, Desc);
                return Convert.ToInt32(Id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int ElamAvarezId, string SharheCodeDaramad, int ShomareHesabCodeDaramadId, long AsliValue, int Tedad, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblCodhayeDaramadiElamAvarezUpdate(Id, ElamAvarezId, SharheCodeDaramad, ShomareHesabCodeDaramadId, Tedad, AsliValue, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id,string FieldName,int ElamAvarezId,int CodeDaramadId, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblCodhayeDaramadiElamAvarezDelete(FieldName,Id,ElamAvarezId,CodeDaramadId, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;var check=false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                DL_Ebtal Ebtal = new DL_Ebtal();
                DL_ElamAvarez ElamAvarez = new DL_ElamAvarez();
                DL_SodoorFish SodoorFish = new DL_SodoorFish();
                var code = p.spr_tblCodhayeDaramadiElamAvarezSelect("fldId", Id.ToString(), 0).FirstOrDefault();
                if (code != null)
                {
                    var fish = SodoorFish.Select("fldElamAvarezId", code.fldElamAvarezId.ToString(), 0).FirstOrDefault();
                    if (fish != null)
                    {
                        var t = Ebtal.Select("fldFishId", fish.fldId.ToString(), 0).FirstOrDefault();
                        if (t != null)
                            check = true;
                    }

                }

                if (check == false)
                {
                    var C = p.spr_tblSodoorFish_DetailSelect("fldCodeElamAvarezId", Id.ToString(), 0).FirstOrDefault();
                    if (C != null)
                        q = true;
                }

                var Mokatebat = p.spr_tblMokatebatSelect("fldCodhayeDaramadiElamAvarezId", Id.ToString(), 0).FirstOrDefault();
                if (Mokatebat != null)
                    q = true;
                return q;
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int ElamAvarezId, int ShomareHesabCodeDaramadId, int Id)
        {
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblCodhayeDaramadiElamAvarezSelect("fldElamAvarezId", ElamAvarezId.ToString(), 0).Where(l => l.fldShomareHesabCodeDaramadId == ShomareHesabCodeDaramadId).Any();

                }
                else
                {
                    var query = p.spr_tblCodhayeDaramadiElamAvarezSelect("fldElamAvarezId", ElamAvarezId.ToString(), 0).Where(l => l.fldShomareHesabCodeDaramadId == ShomareHesabCodeDaramadId).FirstOrDefault();
                    if (query != null && query.fldID != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion

        #region Insert_External
        public int Insert_External(int ElamAvarezId, string SharheCodeDaramad, int ShomareHesabCodeDaramadId, long AsliValue, int Tedad, long MaliyatValue, long AvarezValue, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldID", typeof(int));
                p.spr_tblCodhayeDaramadiElamAvarezInsert_External(Id, ElamAvarezId, SharheCodeDaramad, ShomareHesabCodeDaramadId, Tedad, AsliValue, MaliyatValue, AvarezValue, UserId, Desc);
                return Convert.ToInt32(Id.Value);
            }
        }
        #endregion

        #region Update_External
        public string Update_External(int ID, int ElamAvarezId, string SharheCodeDaramad, int ShomareHesabCodeDaramadId, long AsliValue, long AvarezValue, long MaliyatValue, int Tedad, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblCodhayeDaramadiElamAvarezUpdate_External(ID, ElamAvarezId, SharheCodeDaramad, ShomareHesabCodeDaramadId, AsliValue, AvarezValue, MaliyatValue, Tedad, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion

        #region TakhfifUpdate
        public string TakhfifUpdate(int Id, int Tedad, long TakhfifAsliValue, int ElamAvarezId, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblCodhayeDaramadiElamAvarez_TakhfifUpdate(Id, Tedad, TakhfifAsliValue, ElamAvarezId, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}