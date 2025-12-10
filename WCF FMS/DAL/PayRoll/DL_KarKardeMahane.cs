using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_KarKardeMahane
    {
        #region Detail
        public OBJ_KarKardeMahane Detail(int Id,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var e = p.spr_tblKarKardeMahaneSelect("fldId", Id.ToString(), "", "", 0, 0, OrganId, 1).FirstOrDefault().fldEstelagi;
                var k = p.spr_tblKarKardeMahaneSelect("fldId", Id.ToString(), "", "", 0, 0, OrganId, 1)
                    .Select(q => new OBJ_KarKardeMahane()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBa10 = q.fldBa10,
                        fldBa20 = q.fldBa20,
                        fldBa30 = q.fldBa30,
                        fldBe10 = q.fldBe10,
                        fldBe20 = q.fldBe20,
                        fldBe30 = q.fldBe30,
                        fldBimeOmr = q.fldBimeOmr,
                        fldBimeOmrS = q.fldBimeOmrS,
                        fldBimeTakmili = q.fldBimeTakmili,
                        fldBimeTakmiliName = q.fldBimeTakmiliName,
                        fldCodemeli = q.fldCodemeli,
                        fldCostCenterId = q.fldCostCenterId,
                        fldEzafeKari = q.fldEzafeKari,
                        fldFlag = q.fldFlag,
                        fldGhati = q.fldGhati,
                        fldGheybat = q.fldGheybat,
                        fldJobeCode = q.fldJobeCode,
                        fldKarkard = q.fldKarkard,
                        fldMah = q.fldMah,
                        fldMamoriatBaBeitote = q.fldMamoriatBaBeitote,
                        fldMamoriatBedoneBeitote = q.fldMamoriatBedoneBeitote,
                        fldMashagheleSakhtVaZianAvar = q.fldMashagheleSakhtVaZianAvar,
                        fldMashagheleSakhtVaZianAvarName = q.fldMashagheleSakhtVaZianAvarName,
                        fldMazad30Sal = q.fldMazad30Sal,
                        fldMazad30SalName = q.fldMazad30SalName,
                        fldMonth = q.fldMonth,
                        fldMosaedeh = q.fldMosaedeh,
                        fldName_Father = q.fldName_Father,
                        fldNobateKari = q.fldNobateKari,
                        fldNobatePardakht = q.fldNobatePardakht,
                        fldNobatePardakhtS = q.fldNobatePardakhtS,
                        fldPasAndaz = q.fldPasAndaz,
                        fldPasAndazName = q.fldPasAndazName,
                        fldPersonalId = q.fldPersonalId,
                        fldSanavatPayanKhedmat = q.fldSanavatPayanKhedmat,
                        fldSanavatPayanKhedmatName = q.fldSanavatPayanKhedmatName,
                        fldSh_Personali = q.fldSh_Personali,
                        fldShomareBime = q.fldShomareBime,
                        fldTatileKari = q.fldTatileKari,
                        fldTypeEstekhdamId = q.fldTypeEstekhdamId,
                        fldYear = q.fldYear,
                        fldOrganId = q.fldOrganId,
                        fldStatusId = q.fldStatusId,
                        fldStatusTitle = q.fldStatusTitle,
                        fldShift = q.fldShift,
                        fldMoavaghe=q.fldMoavaghe,
                        fldAzTarikhMoavaghe = q.fldAzTarikhMoavaghe,
                        fldTaTarikhMoavaghe = q.fldTaTarikhMoavaghe,
                        fldAzTarikhMoavagheS = q.fldAzTarikhMoavagheS,
                        fldTaTarikhMoavagheS = q.fldTaTarikhMoavagheS,
                        fldMoavagheName = q.fldMoavagheName,
                        fldMeetingCount = Convert.ToInt16(q.fldMeetingCount),
                        fldEstelagi=q.fldEstelagi
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_KarKardeMahane> Select(string FieldName, string FilterValue, string Year, string Month, byte NobatPardakht, int id, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblKarKardeMahaneSelect(FieldName, FilterValue, Year, Month, NobatPardakht, id, OrganId, h)
                    .Select(q => new OBJ_KarKardeMahane()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldBa10 = q.fldBa10,
                        fldBa20 = q.fldBa20,
                        fldBa30 = q.fldBa30,
                        fldBe10 = q.fldBe10,
                        fldBe20 = q.fldBe20,
                        fldBe30 = q.fldBe30,
                        fldBimeOmr = q.fldBimeOmr,
                        fldBimeOmrS = q.fldBimeOmrS,
                        fldBimeTakmili = q.fldBimeTakmili,
                        fldBimeTakmiliName = q.fldBimeTakmiliName,
                        fldCodemeli = q.fldCodemeli,
                        fldCostCenterId = q.fldCostCenterId,
                        fldEzafeKari = q.fldEzafeKari,
                        fldFlag = q.fldFlag,
                        fldGhati = q.fldGhati,
                        fldGheybat = q.fldGheybat,
                        fldJobeCode = q.fldJobeCode,
                        fldKarkard = q.fldKarkard,
                        fldMah = q.fldMah,
                        fldMamoriatBaBeitote = q.fldMamoriatBaBeitote,
                        fldMamoriatBedoneBeitote = q.fldMamoriatBedoneBeitote,
                        fldMashagheleSakhtVaZianAvar = q.fldMashagheleSakhtVaZianAvar,
                        fldMashagheleSakhtVaZianAvarName = q.fldMashagheleSakhtVaZianAvarName,
                        fldMazad30Sal = q.fldMazad30Sal,
                        fldMazad30SalName = q.fldMazad30SalName,
                        fldMonth = q.fldMonth,
                        fldMosaedeh = q.fldMosaedeh,
                        fldName_Father = q.fldName_Father,
                        fldNobateKari = q.fldNobateKari,
                        fldNobatePardakht = q.fldNobatePardakht,
                        fldNobatePardakhtS = q.fldNobatePardakhtS,
                        fldPasAndaz = q.fldPasAndaz,
                        fldPasAndazName = q.fldPasAndazName,
                        fldPersonalId = q.fldPersonalId,
                        fldSanavatPayanKhedmat = q.fldSanavatPayanKhedmat,
                        fldSanavatPayanKhedmatName = q.fldSanavatPayanKhedmatName,
                        fldSh_Personali = q.fldSh_Personali,
                        fldShomareBime = q.fldShomareBime,
                        fldTatileKari = q.fldTatileKari,
                        fldTypeEstekhdamId = q.fldTypeEstekhdamId,
                        fldYear = q.fldYear,
                        fldOrganId = q.fldOrganId,
                        fldStatusId = q.fldStatusId,
                        fldStatusTitle = q.fldStatusTitle,
                        fldShift = q.fldShift,
                        fldMoavaghe = q.fldMoavaghe,
                        fldAzTarikhMoavaghe = q.fldAzTarikhMoavaghe,
                        fldTaTarikhMoavaghe = q.fldTaTarikhMoavaghe,
                        fldAzTarikhMoavagheS = q.fldAzTarikhMoavagheS,
                        fldTaTarikhMoavagheS = q.fldTaTarikhMoavagheS,
                        fldMoavagheName = q.fldMoavagheName,
                        fldMeetingCount = Convert.ToInt16(q.fldMeetingCount),
                        fldEstelagi = q.fldEstelagi
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(int PersonalId, short Year, byte Mah, byte Karkard, byte Gheybat, byte NobateKari, decimal EzafeKari, decimal TatileKari, byte MamoriatBaBeitote
            , byte MamoriatBedoneBeitote, int Mosaedeh, byte NobatePardakht, bool Flag, bool Ghati, byte Ba10, byte Ba20, byte Ba30,byte Be10,
           byte Be20, byte Be30, int Shift, bool Moavaghe, int? AzTarikhMoavaghe, int? TaTarikhMoavaghe, short fldMeetingCount, byte fldEstelagi, int UserId, string Desc)
        {
            System.Data.Entity.Core.Objects.ObjectParameter fldId = new System.Data.Entity.Core.Objects.ObjectParameter("fldId", typeof(int));
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                 p.spr_tblKarKardeMahaneInsert(fldId, PersonalId, Year, Mah, Karkard, Gheybat, NobateKari, EzafeKari, TatileKari, MamoriatBaBeitote, MamoriatBedoneBeitote, Mosaedeh
                    , NobatePardakht, Flag, Ghati, Ba10, Ba20, Ba30, Be10, Be20, Be30, UserId, Desc, Shift, Moavaghe, AzTarikhMoavaghe, TaTarikhMoavaghe, fldMeetingCount,  fldEstelagi);
                return Convert.ToInt32( fldId.Value);
                
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, short Year, byte Mah, byte Karkard, byte Gheybat, byte NobateKari, decimal EzafeKari, decimal TatileKari, byte MamoriatBaBeitote
            , byte MamoriatBedoneBeitote, int Mosaedeh, byte NobatePardakht, bool Flag, bool Ghati, byte Ba10, byte Ba20, byte Ba30, byte Be10,
           byte Be20, byte Be30, int Shift, bool Moavaghe, int? AzTarikhMoavaghe, int? TaTarikhMoavaghe, short fldMeetingCount, byte fldEstelagi, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblKarKardeMahaneUpdate(Id, PersonalId, Year, Mah, Karkard, Gheybat, NobateKari, EzafeKari, TatileKari, MamoriatBaBeitote, MamoriatBedoneBeitote, Mosaedeh
                    , NobatePardakht, Flag, Ghati, Ba10, Ba20, Ba30, Be10, Be20, Be30, UserId, Desc, Shift, Moavaghe, AzTarikhMoavaghe, TaTarikhMoavaghe, fldMeetingCount,fldEstelagi);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblKarKardeMahaneDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                q = p.spr_tblKarkardMahane_DetailSelect("fldKarkardMahaneId", Id.ToString(), 0).Any();
                return q;
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int PersonalId,string Year,string Month,byte NobatePardakht, int Id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblKarKardeMahaneSelect("CheckSave", PersonalId.ToString(), Year, Month, NobatePardakht, 0,0, 0).Any();

                }
                else
                {
                    var query = p.spr_tblKarKardeMahaneSelect("CheckSave", PersonalId.ToString(), Year, Month, NobatePardakht, 0,0, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion

        #region KarKardeMahaneGroup
        public List<OBJ_KarKardeMahane> KarKardeMahaneGroup(string FieldName, string FilterValue, short Year, byte Month, byte NobatPardakht,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblKarKardeMahaneGroupSelect(FieldName, FilterValue, Year, Month, NobatPardakht, OrganId)
                    .Select(q => new OBJ_KarKardeMahane()
                    {
                        fldBa10 = q.fldBa10,
                        fldBa20 = q.fldBa20,
                        fldBa30 = q.fldBa30,
                        fldBe10 = q.fldBe10,
                        fldBe20 = q.fldBe20,
                        fldBe30 = q.fldBe30,
                        fldChecked = q.fldChecked,
                        fldCodemeli = q.fldCodemeli,
                        fldCostCenterId = q.fldCostCenterId,
                        fldEzafeKari = q.fldEzafeKari,
                        fldGhati = q.fldGhati,
                        fldGheybat = q.fldGheybat,
                        fldKarkard =Convert.ToByte( q.fldKarkard),
                        fldKarKardeMahaneId = q.fldKarKardeMahaneId,
                        fldMah = q.fldMah,
                        fldMamoriatBaBeitote = q.fldMamoriatBaBeitote,
                        fldMamoriatBedoneBeitote = q.fldMamoriatBedoneBeitote,
                        fldMosaedeh = q.fldMosaedeh,
                        fldName = q.fldName,
                        fldNobateKari =Convert.ToByte(  q.fldNobateKari),
                        fldNobatePardakht = q.fldNobatePardakht,
                        fldOrganPostId = q.fldOrganPostId,
                        fldPersonalInfoId = q.fldPersonalInfoId,
                        fldPrs_PersonalInfoId = q.fldPrs_PersonalInfoId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldTatileKari = q.fldTatileKari,
                        fldTypeEstekhdamId = q.fldTypeEstekhdamId,
                        fldYear = q.fldyear,
                        fldGhatiEzafeKar = q.fldGhatiEzafeKar,
                        fldShift = q.fldShift,
                        fldMoavaghe = q.fldMoavaghe,
                        fldAzTarikhMoavagheS = q.fldAzTarikhMoavagheS ,
                        fldTaTarikhMoavagheS = q.fldTaTarikhMoavagheS,
                        fldMeetingCount = Convert.ToInt16(q.fldMeetingCount),
                        fldEstelagi = Convert.ToByte(q.fldEstelagi)
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}