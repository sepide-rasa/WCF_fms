using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_AfradeTahtePoshesheBimeTakmily
    {
        #region Detail
        public OBJ_AfradeTahtePoshesheBimeTakmily Detail(int Id,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblAfradeTahtePoshesheBimeTakmilySelect("fldId", Id.ToString(), 0,0,0,0, OrganId, 1)
                    .Select(q => new OBJ_AfradeTahtePoshesheBimeTakmily()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldGHarardadBimeId = q.fldGHarardadBimeId,
                        fldId = q.fldId,
                        fldPersonalId = q.fldPersonalId,
                        fldTedadAsli = q.fldTedadAsli,
                        fldTedadTakafol60Sal = q.fldTedadTakafol60Sal,
                        fldTedadTakafol70Sal = q.fldTedadTakafol70Sal,
                        fldUserId = q.fldUserId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldName_Father = q.fldName_Father,
                        fldCodemeli = q.fldCodemeli,
                        fldNameBime = q.fldNameBime,
                        fldTedadBedonePoshesh = q.fldTedadBedonePoshesh
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_AfradeTahtePoshesheBimeTakmily> Select(string FieldName, string FilterValue, int PersonalId,short sal,byte mah,byte nobat, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblAfradeTahtePoshesheBimeTakmilySelect(FieldName, FilterValue, PersonalId,sal,mah,nobat, OrganId, h)
                    .Select(q => new OBJ_AfradeTahtePoshesheBimeTakmily()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldGHarardadBimeId = q.fldGHarardadBimeId,
                        fldId = q.fldId,
                        fldPersonalId = q.fldPersonalId,
                        fldTedadAsli = q.fldTedadAsli,
                        fldTedadTakafol60Sal = q.fldTedadTakafol60Sal,
                        fldTedadTakafol70Sal = q.fldTedadTakafol70Sal,
                        fldUserId = q.fldUserId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldName_Father = q.fldName_Father,
                        fldCodemeli = q.fldCodemeli,
                        fldNameBime = q.fldNameBime,
                        fldTedadBedonePoshesh=q.fldTedadBedonePoshesh
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, int TedadAsli, int TedadTakafol60Sal, int TedadTakafol70Sal, int GHarardadBimeId, string AfradTahtePoshehsId, byte TedadBedonePoshesh, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblAfradeTahtePoshesheBimeTakmilyInsert(PersonalId, TedadAsli, TedadTakafol60Sal, TedadTakafol70Sal,  TedadBedonePoshesh, GHarardadBimeId, UserId, Desc, AfradTahtePoshehsId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, int TedadAsli, int TedadTakafol60Sal, int TedadTakafol70Sal, int GHarardadBimeId, string AfradTahtePoshehsId, byte TedadBedonePoshesh, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblAfradeTahtePoshesheBimeTakmilyUpdate(Id, PersonalId, TedadAsli, TedadTakafol60Sal, TedadTakafol70Sal, TedadBedonePoshesh, GHarardadBimeId, UserId, Desc, AfradTahtePoshehsId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Copy
        public string Copy(int GHarardadBimeId_From, int GHarardadBimeId_To, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblAfradeTahtePoshesheBimeTakmilyCopy(GHarardadBimeId_From, GHarardadBimeId_To,  UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblAfradeTahtePoshesheBimeTakmilyDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int PersonalId, int GHarardadBimeId, int Id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblAfradeTahtePoshesheBimeTakmilySelect("CheckGHarardadBimeId_PersonalId", GHarardadBimeId.ToString(), PersonalId,0,0,0, 0, 0).Any();

                }
                else
                {
                    var query = p.spr_tblAfradeTahtePoshesheBimeTakmilySelect("CheckGHarardadBimeId_PersonalId", GHarardadBimeId.ToString(), PersonalId,0,0,0, 0, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion

        #region HistoryAfradTahtePoshesheBimeTakmily
        public List<OBJ_HistoryAfradTahtePoshesheBimeTakmily> HistoryAfradTahtePoshesheBimeTakmily(int PersonalId,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_Pay_HistoryAfradTahtePoshesheBimeTakmily(PersonalId, OrganId)
                    .Select(q => new OBJ_HistoryAfradTahtePoshesheBimeTakmily()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldFamily = q.fldFamily,
                        fldFatherName = q.fldFatherName,
                        fldGHarardadBimeId = q.fldGHarardadBimeId,
                        fldId = q.fldId,
                        fldName = q.fldName,
                        fldPersonalId = q.fldPersonalId,
                        fldTedadAsli = q.fldTedadAsli,
                        fldTedadTakafol60Sal = q.fldTedadTakafol60Sal,
                        fldTedadTakafol70Sal = q.fldTedadTakafol70Sal,
                        fldUserId = q.fldUserId,
                        fldNameBime = q.fldNameBime,
                        fldCodemeli = q.fldCodemeli,
                        fldSh_Personali = q.fldSh_Personali
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}