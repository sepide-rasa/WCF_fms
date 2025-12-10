using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_PardakhtFiles_Detail
    {
        #region Detail
        public OBJ_PardakhtFiles_Detail Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblPardakhtFiles_DetailSelect("fldId", Id.ToString(),"","","", 1)
                    .Select(q => new OBJ_PardakhtFiles_Detail()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldCodeRahgiry = q.fldCodeRahgiry,
                        fldNahvePardakhtId = q.fldNahvePardakhtId,
                        fldOrganId = q.fldOrganId,
                        fldPardakhtFileId = q.fldPardakhtFileId,
                        fldShenaseGhabz = q.fldShenaseGhabz,
                        fldShenasePardakht = q.fldShenasePardakht,
                        fldTarikhPardakht = q.fldTarikhPardakht,
                        fldBankId = q.fldBankId,
                        fldFileName = q.fldFileName,
                        fldDateSendFile = q.fldDateSendFile,
                        fldBankName = q.fldBankName,
                        fldTitleNahvePardakht = q.fldTitleNahvePardakht,
                        fldFishId = q.fldFishId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_PardakhtFiles_Detail> Select(string FieldName, string FilterValue, string OrganId, string AzTarikh, string TaTarikh, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblPardakhtFiles_DetailSelect(FieldName, FilterValue, OrganId, AzTarikh, TaTarikh, h)
                    .Select(q => new OBJ_PardakhtFiles_Detail()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldCodeRahgiry = q.fldCodeRahgiry,
                        fldNahvePardakhtId = q.fldNahvePardakhtId,
                        fldOrganId = q.fldOrganId,
                        fldPardakhtFileId = q.fldPardakhtFileId,
                        fldShenaseGhabz = q.fldShenaseGhabz,
                        fldShenasePardakht = q.fldShenasePardakht,
                        fldTarikhPardakht = q.fldTarikhPardakht,
                        fldBankId = q.fldBankId,
                        fldFileName = q.fldFileName,
                        fldDateSendFile = q.fldDateSendFile,
                        fldBankName = q.fldBankName,
                        fldTitleNahvePardakht = q.fldTitleNahvePardakht,
                        fldFishId = q.fldFishId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string ShenaseGhabz, string ShenasePardakht, string TarikhPardakht, string CodeRahgiry, int PardakhtFileId, int OrganId, string CodePardakht, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPardakhtFiles_DetailInsert(ShenaseGhabz, ShenasePardakht, TarikhPardakht, CodeRahgiry,PardakhtFileId, OrganId, CodePardakht, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string ShenaseGhabz, string ShenasePardakht, string TarikhPardakht, string CodeRahgiry, int NahvePardakhtId, int PardakhtFileId, int OrganId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPardakhtFiles_DetailUpdate(Id, ShenaseGhabz, ShenasePardakht, TarikhPardakht, CodeRahgiry, NahvePardakhtId, PardakhtFileId, OrganId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPardakhtFiles_DetailDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string ShenaseGhabz, string ShenasePardakht, int Id)
        {
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                if (Id == 0)
                {
                    var m = p.spr_tblPardakhtFiles_DetailSelect("fldShenaseGhabz_Check", ShenaseGhabz, "", "", "", 0).FirstOrDefault();
                    var m1 = p.spr_tblPardakhtFiles_DetailSelect("fldShenasePardakht_Check", ShenasePardakht, "", "", "", 0).FirstOrDefault();
                    if (m != null || m1 != null)
                        q = true;
                }
                else
                {
                    var query = p.spr_tblPardakhtFiles_DetailSelect("fldShenaseGhabz_Check", ShenaseGhabz, "", "", "", 0).FirstOrDefault();
                    var query1 = p.spr_tblPardakhtFiles_DetailSelect("fldShenasePardakht_Check", ShenasePardakht, "", "", "", 0).FirstOrDefault();
                    if (query != null && query.fldId != Id || query1 != null && query1.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
    }
}