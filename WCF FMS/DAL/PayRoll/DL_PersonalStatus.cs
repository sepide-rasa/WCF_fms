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
    public class DL_PersonalStatus
    {
        #region Detail
        public OBJ_PersonalStatus Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblPersonalStatusSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_PersonalStatus()
                    {
                        fldId=q.fldId,
                        fldPayPersonalInfoId=q.fldPayPersonalInfoId,
                        fldPrsPersonalInfoId=q.fldPrsPersonalInfoId,
                        fldStatusId=q.fldStatusId,
                        fldDateTaghirVaziyat=q.fldDateTaghirVaziyat,
                        fldUserId=q.fldUserId,
                        fldDesc=q.fldDesc,
                        fldDate=q.fldDate
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_PersonalStatus> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblPersonalStatusSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_PersonalStatus()
                    {
                        fldId = q.fldId,
                        fldPayPersonalInfoId = q.fldPayPersonalInfoId,
                        fldPrsPersonalInfoId = q.fldPrsPersonalInfoId,
                        fldStatusId = q.fldStatusId,
                        fldDateTaghirVaziyat = q.fldDateTaghirVaziyat,
                        fldUserId = q.fldUserId,
                        fldDesc = q.fldDesc,
                        fldDate = q.fldDate,
                        fldTitle=q.fldTitle
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int StatusId,int? PrsPersonalInfoId ,int? PayPersonalInfoId,string  DateTaghirVaziyat, string Desc, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblPersonalStatusInsert(StatusId, PrsPersonalInfoId, PayPersonalInfoId, DateTaghirVaziyat, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int StatusId, int? PrsPersonalInfoId, int? PayPersonalInfoId, string DateTaghirVaziyat, string Desc, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblPersonalStatusUpdate(Id, StatusId, PrsPersonalInfoId, PayPersonalInfoId, DateTaghirVaziyat, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblPersonalStatusDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int StatusId, int? PrsPersonalInfoId,int? PayPersonalInfoId ,int Id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    if (PrsPersonalInfoId != null)
                    {
                        q = p.spr_tblPersonalStatusSelect("fldStatusChangeEnd_KargoziniId", PrsPersonalInfoId.ToString(), 0).Where(l => l.fldStatusId == StatusId).Any();
                    }
                    else
                    {
                        q = p.spr_tblPersonalStatusSelect("fldStatusChangeEnd_HoghughiId", PayPersonalInfoId.ToString(), 0).Where(l => l.fldStatusId == StatusId).Any();
                    }
                }
                else
                {
                    if (PrsPersonalInfoId != null)
                    {
                        var query = p.spr_tblPersonalStatusSelect("fldStatusChangeEnd_KargoziniId", PrsPersonalInfoId.ToString(), 0).Where(l => l.fldStatusId == StatusId).FirstOrDefault();
                        if (query != null && query.fldId != Id)
                        {
                            q = true;
                        }
                    }
                    else
                    {
                        var query = p.spr_tblPersonalStatusSelect("fldStatusChangeEnd_HoghughiId", PayPersonalInfoId.ToString(), 0).Where(l => l.fldStatusId == StatusId).FirstOrDefault();
                        if (query != null && query.fldId != Id)
                        {
                            q = true;
                        }
                    }
                }
            }
            return q;
        }
        #endregion
        #region validDate
        public bool validDate(string DateTaghirVaziyat, int? PrsPersonalInfoId, int? PayPersonalInfoId)
        {
            bool q = true;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (PrsPersonalInfoId != null)
                {
                    var Tarikh2 = p.spr_MaxChangeDatePersonalSelect("Prs_fldPersonalInfoId", PrsPersonalInfoId.ToString(), 1).FirstOrDefault().fldDateTaghierVaziyat;

                    if (Tarikh2 != null && MyLib.Shamsi.Shamsi2miladiDateTime(DateTaghirVaziyat) < MyLib.Shamsi.Shamsi2miladiDateTime(Tarikh2))
                    {
                        q = false;
                    }
                }
                if (PayPersonalInfoId != null)
                {
                    var Tarikh2 = p.spr_MaxChangeDatePersonalSelect("Pay_fldPersonalInfoId", PayPersonalInfoId.ToString(), 1).FirstOrDefault().fldDateTaghierVaziyat;

                    if (Tarikh2 != null && MyLib.Shamsi.Shamsi2miladiDateTime(DateTaghirVaziyat) < MyLib.Shamsi.Shamsi2miladiDateTime(Tarikh2))
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