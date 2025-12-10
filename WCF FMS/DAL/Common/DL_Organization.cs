using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_Organization
    {
        #region Detail
        public OBJ_Organization Detail(int id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblOrganizationSelect("fldId", id.ToString(), UserId, 1)
                    .Select(q => new OBJ_Organization
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldName = q.fldName,
                        fldAddress = q.fldAddress,
                        fldCityId = q.fldCityId,
                        fldCityName = q.fldCityName,
                        fldCodePosti = q.fldCodePosti,
                        fldFileId = q.fldFileId,
                        fldPId = q.fldPId,
                        fldTelphon = q.fldTelphon,
                        fldCodAnformatic = q.fldCodAnformatic,
                        fldCodKhedmat = q.fldCodKhedmat,
                        fldShenaseMelli = q.fldShenaseMelli,
                        fldCodEghtesadi = q.fldCodEghtesadi,
                        fldShomareSabt = q.fldShomareSabt,
                        fldAshkhaseHoghoghiId = q.fldAshkhaseHoghoghiId,
                        FldNameAshkhaseHoghoghi = q.FldNameAshkhaseHoghoghi,
                        fldStateId = q.fldStateId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Organization> Select(string FieldName, string FilterValue, int UserId, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var test = p.spr_tblOrganizationSelect(FieldName, FilterValue,UserId, h)
                    .Select(q => new OBJ_Organization()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldName =q.fldName,
                        fldAddress = q.fldAddress,
                        fldCityId = q.fldCityId,
                        fldCityName = q.fldCityName,
                        fldCodePosti = q.fldCodePosti,
                        fldFileId = q.fldFileId,
                        fldPId = q.fldPId,
                        fldTelphon = q.fldTelphon,
                        fldCodAnformatic = q.fldCodAnformatic,
                        fldCodKhedmat = q.fldCodKhedmat,
                        fldShenaseMelli = q.fldShenaseMelli,
                        fldCodEghtesadi = q.fldCodEghtesadi,
                        fldShomareSabt = q.fldShomareSabt,
                        fldAshkhaseHoghoghiId = q.fldAshkhaseHoghoghiId,
                        FldNameAshkhaseHoghoghi = q.FldNameAshkhaseHoghoghi,
                        fldStateId = q.fldStateId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldName, int? fldPId, byte[] fldArm,string Pasvand, int fldCityId, string fldCodAnformatic, byte fldCodKhedmat,int AshkhaseHoghoghiId, int userId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
               /* var Name=CodeDecode.stringcode(fldName);*/
                p.spr_tblOrganizationInsert(fldName, fldPId, fldArm, Pasvand, fldCityId, userId, Desc, fldCodAnformatic, fldCodKhedmat, AshkhaseHoghoghiId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, string fldName, int? fldPId, byte[] fldArm, string Pasvand, int fldFileId, int fldCityId, string fldCodAnformatic, byte fldCodKhedmat, int AshkhaseHoghoghiId, int userId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
               /* var Name = CodeDecode.stringcode(fldName);*/
                p.spr_tblOrganizationUpdate(fldId, fldName, fldPId, fldArm, Pasvand, fldFileId, fldCityId, userId, Desc, fldCodAnformatic, fldCodKhedmat, AshkhaseHoghoghiId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblOrganizationDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            bool q = false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var m = p.spr_tblChartOrganSelect("CheckOrganId", id.ToString(), 0, 0).FirstOrDefault();
                var query = p.spr_tblModule_OrganSelect("CheckOrganId", id.ToString(), 0, 0).FirstOrDefault();
                var c = p.spr_tblChartOrganEjraeeSelect("fldOrganId", id.ToString(), 0, 1).FirstOrDefault();
                if (m != null || query != null || c != null)
                    q = true;
            }
            if (q == false)
            {
                using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
                {
                    var Disket = p.spr_tblDisketSelect("CheckOrganId", id.ToString(), 0).FirstOrDefault();
                    if (Disket != null)
                        q = true;

                }
                using (RasaNewFMSEntities m = new RasaNewFMSEntities())
                {
                    var t = m.spr_tblTanzimateDaramadSelect("fldOrganId_Check", id.ToString(),0, 0).FirstOrDefault();
                    var sh = m.spr_tblShomareHesabCodeDaramadSelect("fldOrganId", id.ToString(), "", 0,0).FirstOrDefault();
                    var pcpos = m.spr_tblPcPosInfoSelect("CheckOrganId", id.ToString(), "", 0).FirstOrDefault();
                    var Pardakht = m.spr_tblPardakhtFiles_DetailSelect("fldOrganId", id.ToString(), "", "", "", 0).FirstOrDefault();
                    if (t != null || sh != null || pcpos != null || Pardakht != null)
                        q = true;
                }
                using (AutomationEntities m = new AutomationEntities())
                {
                    var co = m.spr_tblCommisionSelect("fldOrganID", "", id, 0).FirstOrDefault();
                    var Imm = m.spr_tblImmediacySelect("fldOrganID", "", id, 0).FirstOrDefault();
                    var num = m.spr_tblNumberingFormatSelect("fldOrganID", "", id, 0).FirstOrDefault();
                    if (co != null || Imm != null || num != null)
                        q = true;
                }
            }
            return q;
        }
        #endregion
    }
}