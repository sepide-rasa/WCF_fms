using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_SavabeghGroupTashvighi
    {
        #region Detail
        public OBJ_SavabeghGroupTashvighi Detail(int id,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblSavabeghGroupTashvighiSelect("fldId", id.ToString(),OrganId, 1)
                    .Select(q => new OBJ_SavabeghGroupTashvighi
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldAnvaGroupTashvighiTitle=q.fldAnvaGroupTashvighiTitle,
                        fldUserId = q.fldUserId,
                        fldAnvaGroupId = q.fldAnvaGroupId,
                        fldPersonalId=q.fldPersonalId,
                        fldTarikh=q.fldTarikh,
                        fldTedadGroup=q.fldTedadGroup
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_SavabeghGroupTashvighi> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var test = p.spr_tblSavabeghGroupTashvighiSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_SavabeghGroupTashvighi()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldAnvaGroupTashvighiTitle=q.fldAnvaGroupTashvighiTitle,
                        fldAnvaGroupId = q.fldAnvaGroupId,
                        fldPersonalId = q.fldPersonalId,
                        fldTarikh = q.fldTarikh,
                        fldTedadGroup = q.fldTedadGroup
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldPersonalId,byte fldAnvaGroupId,byte fldTedadGroup,string fldTarikh, int userId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblSavabeghGroupTashvighiInsert(fldPersonalId, fldAnvaGroupId, fldTedadGroup, fldTarikh, userId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, int fldPersonalId, byte fldAnvaGroupId, byte fldTedadGroup, string fldTarikh, int userId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblSavabeghGroupTashvighiUpdate(fldId, fldPersonalId, fldAnvaGroupId, fldTedadGroup, fldTarikh, userId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblSavabeghGroupTashvighiDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}