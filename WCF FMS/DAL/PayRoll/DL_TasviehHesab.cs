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
    public class DL_TasviehHesab
    {
        #region Detail
        public OBJ_TasviehHesab Detail(int Id, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblTasviehHesabSelect("fldId", Id.ToString(),"", OrganId, 1)
                    .Select(q => new OBJ_TasviehHesab()
                    {
                        fldId = q.fldId,
                        fldPrsPersonalInfoId = q.fldPrsPersonalInfoId,
                        fldTarikh = q.fldTarikh,
                        fldUserId = q.fldUserId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_TasviehHesab> Select(string FieldName, string FilterValue, string FilterValue2, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblTasviehHesabSelect(FieldName, FilterValue,FilterValue2, OrganId, h)
                    .Select(q => new OBJ_TasviehHesab()
                    {
                        fldId = q.fldId,
                        fldPrsPersonalInfoId = q.fldPrsPersonalInfoId,
                        fldTarikh = q.fldTarikh,
                        fldUserId = q.fldUserId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert( int PrsPersonalInfoId, string Tarikh, string Desc, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblTasviehHesabInsert( PrsPersonalInfoId, Tarikh, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PrsPersonalInfoId, string Tarikh, string Desc, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblTasviehHesabUpdate(Id, PrsPersonalInfoId, Tarikh, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblTasviehHesabDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string Tarikh, int PrsPersonalInfoId, int Id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblTasviehHesabSelect("CheckPrsPersonalInfoId_Tarikh", PrsPersonalInfoId.ToString(), Tarikh,0, 0).Any();
                }
                else
                {
                    var query = p.spr_tblTasviehHesabSelect("CheckPrsPersonalInfoId_Tarikh", PrsPersonalInfoId.ToString(), Tarikh, 0, 0).Where(l => l.fldId != Id).FirstOrDefault();
                    if (query != null)
                    {
                        q = true;
                    }
                   

                }
            }
            return q;
        }
        #endregion
        #region ValidDate
        public bool ValidDate(int PrsPersonalInfoId, string Tarikh,int Id)
        {
            bool q = true;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var query = p.spr_tblTasviehHesabSelect("MaxTarikhPrsPersonalInfoId", PrsPersonalInfoId.ToString(), "", 0, 0).Where(l=>l.fldId!=Id).FirstOrDefault();
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

        #region ValidDateHistoryEstkhdam
        public bool ValidDateHistoryEstkhdam(int PrsPersonalInfoId, string Tarikh)
        {
            bool q = true;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                 q = p.spr_tblHistoryNoeEstekhdamSelect("fldTarikhP",Tarikh, PrsPersonalInfoId, 0).Any();
                

            }
            return q;
        }
        #endregion
    }
}