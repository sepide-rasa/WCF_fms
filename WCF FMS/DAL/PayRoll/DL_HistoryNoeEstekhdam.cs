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
    public class DL_HistoryNoeEstekhdam 
    {
        #region Detail
        public OBJ_HistoryNoeEstekhdam Detail(int Id, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblHistoryNoeEstekhdamSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_HistoryNoeEstekhdam()
                    {
                        fldId=q.fldId,
                        fldNoeEstekhdamId=q.fldNoeEstekhdamId,
                        fldPrsPersonalInfoId=q.fldPrsPersonalInfoId,
                        fldTarikh=q.fldTarikh,
                        fldNameEmployee=q.fldNameEmployee,
                        fldNoeEstekhdamTitle=q.fldNoeEstekhdamTitle,
                        fldUserId=q.fldUserId,
                        fldDate=q.fldDate,
                        fldDesc=q.fldDesc
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_HistoryNoeEstekhdam> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblHistoryNoeEstekhdamSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_HistoryNoeEstekhdam()
                    {
                        fldId = q.fldId,
                        fldNoeEstekhdamId = q.fldNoeEstekhdamId,
                        fldPrsPersonalInfoId = q.fldPrsPersonalInfoId,
                        fldTarikh = q.fldTarikh,
                        fldNameEmployee = q.fldNameEmployee,
                        fldNoeEstekhdamTitle = q.fldNoeEstekhdamTitle,
                        fldUserId = q.fldUserId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int NoeEstekhdamId, int PrsPersonalInfoId, string Tarikh,string Desc, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblHistoryNoeEstekhdamInsert(NoeEstekhdamId, PrsPersonalInfoId, Tarikh, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int NoeEstekhdamId, int PrsPersonalInfoId, string Tarikh, string Desc, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblHistoryNoeEstekhdamUpdate(Id, NoeEstekhdamId, PrsPersonalInfoId, Tarikh,UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblHistoryNoeEstekhdamDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string Tarikh,int PrsPersonalInfoId, int NoeEstekhdamId, int Id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities()) 
            {
                var t = p.spr_tblTasviehHesabSelect("MaxTarikhPrsPersonalInfoId", PrsPersonalInfoId.ToString(), "", 0, 1).FirstOrDefault();
                var h = p.spr_tblHistoryNoeEstekhdamSelect("MaxTarikh", PrsPersonalInfoId.ToString(), 0, 1).Where(l => l.fldId != Id).FirstOrDefault();
                if (t == null || MyLib.Shamsi.Shamsi2miladiDateTime(Tarikh) < MyLib.Shamsi.Shamsi2miladiDateTime(t.fldTarikh) || MyLib.Shamsi.Shamsi2miladiDateTime(t.fldTarikh) < MyLib.Shamsi.Shamsi2miladiDateTime(h.fldTarikh))
                {

                    if (Id == 0)
                    {
                        q = p.spr_tblHistoryNoeEstekhdamSelect("CheckPrsPersonalInfoId_Tarikh", Tarikh, PrsPersonalInfoId, 0).Any();
                        if (q == false)
                            q = p.spr_tblHistoryNoeEstekhdamSelect("CheckPrsPersonalInfoId", Tarikh, PrsPersonalInfoId, 0).Where(l => l.fldNoeEstekhdamId == NoeEstekhdamId).Any();
                    }
                    else
                    {
                        var query = p.spr_tblHistoryNoeEstekhdamSelect("CheckPrsPersonalInfoId_Tarikh", Tarikh, PrsPersonalInfoId, 0).Where(l => l.fldId != Id).FirstOrDefault();
                        if (query != null)
                        {
                            q = true;
                        }
                        else
                        {
                            query = p.spr_tblHistoryNoeEstekhdamSelect("CheckPrsPersonalInfoId", Tarikh, PrsPersonalInfoId, 0).Where(l => l.fldNoeEstekhdamId == NoeEstekhdamId && l.fldId != Id).FirstOrDefault();
                            if (query != null)
                            {
                                q = true;
                            }
                        }

                    }
                }
            }
            return q;
        }
        #endregion
        #region ValidDate
        public bool ValidDate(int PrsPersonalInfoId, string Tarikh)
        {
            bool q = true;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var query = p.spr_MaxPersonalEstekhdamType("",PrsPersonalInfoId,"").FirstOrDefault();
                if (query !=null)
                {
                    if (MyLib.Shamsi.Shamsi2miladiDateTime(Tarikh) < MyLib.Shamsi.Shamsi2miladiDateTime(query.fldTarikh))
                    {
                        q = false;
                    }
                }
                
            }
            return q;
        }
        #endregion
        #region ValidDateTasvie
        public bool ValidDateTasvie(int PrsPersonalInfoId, string Tarikh)
        {
            bool q = true;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var query = p.spr_tblTasviehHesabSelect("MaxTarikhPrsPersonalInfoId", PrsPersonalInfoId.ToString(), "",0,1).FirstOrDefault();
                if (query != null)
                {
                    if (MyLib.Shamsi.Shamsi2miladiDateTime(Tarikh) <= MyLib.Shamsi.Shamsi2miladiDateTime(query.fldTarikh))
                    {
                        q = false;
                    }
                }

            }
            return q;
        }
        #endregion

        #region ValidDateEdit
        public bool ValidDateEdit(int PrsPersonalInfoId, string Tarikh,int Id)
        {
            bool q = true;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var query = p.spr_tblHistoryNoeEstekhdamSelect("MaxTarikh", PrsPersonalInfoId.ToString(),0,1).Where(l=>l.fldId!=Id).FirstOrDefault();
                if (query != null)
                {
                    if (MyLib.Shamsi.Shamsi2miladiDateTime(Tarikh) < MyLib.Shamsi.Shamsi2miladiDateTime(query.fldTarikh))
                    {
                        q = false;
                    }
                }

            }
            return q;
        }
        #endregion
    }
}