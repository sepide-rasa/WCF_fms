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
    public class DL_AnvaEstekhdam
    {
        #region Detail
        public OBJ_AnvaEstekhdam Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblAnvaEstekhdamSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_AnvaEstekhdam()
                    {
                       fldId=q.fldId,
                       fldNoeEstekhdamId=q.fldNoeEstekhdamId,
                       fldTitle=q.fldTitle,
                       fldUserId=q.fldUserId,
                       fldTitleNoeEstekhdam=q.fldTitleNoeEstekhdam,
                       fldDesc=q.fldDesc,
                       fldDate=q.fldDate,
                       fldPatternNoeEstekhdamId=q.fldPatternNoeEstekhdamId,
                       fldTitlePattern=q.fldTitlePattern,
                       fldTypeEstekhdamFormul=q.fldTypeEstekhdamFormul
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_AnvaEstekhdam> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblAnvaEstekhdamSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_AnvaEstekhdam()
                    {
                        fldId = q.fldId,
                        fldNoeEstekhdamId = q.fldNoeEstekhdamId,
                        fldTitleNoeEstekhdam = q.fldTitleNoeEstekhdam,
                        fldTitle = q.fldTitle,
                        fldUserId = q.fldUserId,
                        fldDesc = q.fldDesc,
                        fldDate = q.fldDate,
                        fldPatternNoeEstekhdamId = q.fldPatternNoeEstekhdamId,
                        fldTitlePattern = q.fldTitlePattern,
                        fldTypeEstekhdamFormul = q.fldTypeEstekhdamFormul
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Title, int NoeEstekhdamId, int? fldPatternNoeEstekhdamId,byte? fldTypeEstekhdamFormul, string Desc, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblAnvaEstekhdamInsert(Title, NoeEstekhdamId, fldPatternNoeEstekhdamId, UserId, Desc, fldTypeEstekhdamFormul);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Title, int NoeEstekhdamId, int? fldPatternNoeEstekhdamId, byte? fldTypeEstekhdamFormul, string Desc, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblAnvaEstekhdamUpdate(Id, Title, NoeEstekhdamId, fldPatternNoeEstekhdamId, UserId, Desc, fldTypeEstekhdamFormul);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblAnvaEstekhdamDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int NoeEstekhdamId, string Title, int Id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblAnvaEstekhdamSelect("fldTitle", Title, 0).Where(l => l.fldNoeEstekhdamId == NoeEstekhdamId).Any();
                }
                else
                {
                    var query = p.spr_tblAnvaEstekhdamSelect("fldTitle", Title, 0).Where(l => l.fldNoeEstekhdamId == NoeEstekhdamId).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion

        #region CheckPattern
        public bool CheckPattern(int Id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                    q = p.spr_tblAnvaEstekhdamSelect("fldPatternNoeEstekhdamId", Id.ToString(), 0).Any();
                
            }
            return q;
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var f = p.spr_tblFiscalTitleSelect("fldAnvaEstekhdamId", id.ToString(), 1).FirstOrDefault();
                var s = p.spr_tblMohasebat_PersonalInfoSelect("CheckAnvaEstekhdamId", id.ToString(), 0, 1).FirstOrDefault();
                var m = p.spr_tblMoteghayerhayeHoghoghiSelect("fldAnvaeEstekhdamId", id.ToString(), 1).FirstOrDefault();
                var h = p.spr_tblHistoryNoeEstekhdamSelect("CheckNoeEstekhdamId", id.ToString(),0, 1).FirstOrDefault();
                var r = p.spr_tblHokmReportSelect("fldAnvaEstekhdamId", id.ToString(), 1).FirstOrDefault();
                var personal_H = p.spr_tblPersonalHokmSelect("CheckAnvaeEstekhdamId", id.ToString(),"",0,0, 1).FirstOrDefault();
                if (f != null || s != null || m != null || h != null || r != null || personal_H != null)
                    q = true;
                return q;
            }
        }
        #endregion
    }
}