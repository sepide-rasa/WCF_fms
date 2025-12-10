using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_FiscalTitle
    {
        #region Detail
        public OBJ_FiscalTitle Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblFiscalTitleSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_FiscalTitle()
                    {
                        fldAnvaeEstekhdamTitle = q.fldAnvaeEstekhdamTitle,
                        fldAnvaEstekhdamId = q.fldAnvaEstekhdamId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldFiscalHeaderId = q.fldFiscalHeaderId,
                        fldId = q.fldId,
                        fldItemEstekhdamId = q.fldItemEstekhdamId,
                        fldTitle = q.fldTitle,
                        fldUserId = q.fldUserId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_FiscalTitle> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblFiscalTitleSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_FiscalTitle()
                    {
                        fldAnvaeEstekhdamTitle = q.fldAnvaeEstekhdamTitle,
                        fldAnvaEstekhdamId = q.fldAnvaEstekhdamId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldFiscalHeaderId = q.fldFiscalHeaderId,
                        fldId = q.fldId,
                        fldItemEstekhdamId = q.fldItemEstekhdamId,
                        fldTitle = q.fldTitle,
                        fldUserId = q.fldUserId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int FiscalHeaderId, int ItemEstekhdamId, int AnvaEstekhdamId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblFiscalTitleInsert(FiscalHeaderId, ItemEstekhdamId, AnvaEstekhdamId, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int FiscalHeaderId, int ItemEstekhdamId, int AnvaEstekhdamId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblFiscalTitleUpdate(Id, FiscalHeaderId, ItemEstekhdamId, AnvaEstekhdamId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(string FieldName, string FilterValue, int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblFiscalTitleDelete(FieldName, FilterValue, Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}