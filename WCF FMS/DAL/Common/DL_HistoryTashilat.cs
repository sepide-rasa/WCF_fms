using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.Common;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;


namespace WCF_FMS.DAL.Common
{
    public class DL_HistoryTahsilat
    {
        #region Detail
        public OBJ_HistoryTahsilat Detail(int Id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblHistoryTahsilatSelect("fldId", Id.ToString(),"", 1)
                    .Select(q => new OBJ_HistoryTahsilat()
                    {
                        fldId = q.fldId,
                        fldEmployeeId = q.fldEmployeeId,
                        fldMadrakId = q.fldMadrakId,
                        fldTarikh = q.fldTarikh,
                        fldReshteId = q.fldReshteId,
                        fldTitleMadrak = q.fldTitleMadrak,
                        fldTitleReshte = q.fldTitleReshte,
                        fldUserId = q.fldUserId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_HistoryTahsilat> Select(string FieldName, string FilterValue, string FilterValue2,  int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblHistoryTahsilatSelect(FieldName, FilterValue, FilterValue2, h)
                    .Select(q => new OBJ_HistoryTahsilat()
                    {
                        fldId = q.fldId,
                        fldEmployeeId = q.fldEmployeeId,
                        fldMadrakId = q.fldMadrakId,
                        fldTarikh = q.fldTarikh,
                        fldReshteId = q.fldReshteId,
                        fldTitleMadrak = q.fldTitleMadrak,
                        fldTitleReshte = q.fldTitleReshte,
                        fldUserId = q.fldUserId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldEmployeeId, int fldMadrakId, int fldReshteId, string fldTarikh, string Desc, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblHistoryTahsilatInsert(fldEmployeeId,fldMadrakId,fldReshteId,fldTarikh, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int fldEmployeeId, int fldMadrakId, int fldReshteId, string fldTarikh, string Desc, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblHistoryTahsilatUpdate(Id, fldEmployeeId, fldMadrakId, fldReshteId, fldTarikh, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblHistoryTahsilatDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion


        #region ValidDateMadrak
        public bool ValidDateMadrak(int fldEmployeeId,  string fldMadrakId, int fldReshteId, int Id)
        {
            bool q = true;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var query = p.spr_tblHistoryTahsilatSelect("fldMadrakId_ReshteId", fldEmployeeId.ToString(), fldMadrakId,fldReshteId).Where(l => l.fldId != Id).FirstOrDefault();
                if (query != null)
                {
                    q = false;
                }

            }
            return q;
        }
        #endregion
        #region ValidDateTarikh
        public bool ValidDateTarikh(int fldEmployeeId, string fldTarikh, int Id)
        {
            bool q = true;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var query = p.spr_tblHistoryTahsilatSelect("fldTarikh", fldEmployeeId.ToString(), fldTarikh, 1).Where(l => l.fldId != Id).FirstOrDefault();
                if (query != null)
                {
                    q = false;
                }

            }
            return q;
        }
        #endregion
        #region CheckEdit
        public bool CheckEdit(int fldEmployeeId, string fldTarikh, int Id)
        {
            bool q = true;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var query = p.spr_tblHistoryTahsilatSelect("fldTarikh", fldEmployeeId.ToString(), fldTarikh, 1).Where(l => l.fldId != Id).FirstOrDefault();
                if (query != null)
                {
                    q = false;
                }

            }
            return q;
        }
        #endregion
    }
}