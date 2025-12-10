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
    public class DL_Masoulin_Detail
    {
        #region Detail
        public OBJ_Masoulin_Detail Detail(int Id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblMasuolin_DetailSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_Masoulin_Detail()
                    {
                        fldId = q.fldId,
                        fldEmployId = q.fldEmployId,
                        fldMasuolinId = q.fldMasuolinId,
                        fldOrderId = q.fldOrderId,
                        fldTarikhEjra = q.fldTarikhEjra,
                        fldNameEmployee=q.fldNameEmployee,
                        fldNameOrgan=q.fldNameOrgan,
                        fldUserId = q.fldUserId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldModule_OrganId = q.fldModule_OrganId,
                        NamePostOrgan = q.NamePostOrgan,
                        fldOrganPostId = q.fldOrganPostId,
                        TitlePost = q.TitlePost,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Masoulin_Detail> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblMasuolin_DetailSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Masoulin_Detail()
                    {
                        fldId = q.fldId,
                        fldEmployId = q.fldEmployId,
                        fldMasuolinId = q.fldMasuolinId,
                        fldOrderId = q.fldOrderId,
                        fldTarikhEjra = q.fldTarikhEjra,
                        fldNameEmployee = q.fldNameEmployee,
                        fldNameOrgan = q.fldNameOrgan,
                        fldUserId = q.fldUserId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldModule_OrganId = q.fldModule_OrganId,
                        NamePostOrgan = q.NamePostOrgan,
                        fldOrganPostId = q.fldOrganPostId,
                        TitlePost = q.TitlePost,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int? EmployeeId, int? OrganPostId, int MasoulinId, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblMasuolin_DetailInsert(EmployeeId, OrganPostId, MasoulinId, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int? EmployeeId, int? OrganPostId, int MasoulinId, int OrderId, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblMasuolin_DetailUpdate(Id, EmployeeId, OrganPostId, MasoulinId, OrderId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(string FieldName,int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblMasuolin_DetailDelete(FieldName,Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
       /* #region CheckRepeatedRow
        public bool CheckRepeatedRow(int MasoulinId, int? EmployeeId, int? OrganPostId, int Id)
        {
            bool q=false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblMasuolin_DetailSelect("fldMasuolinId", MasoulinId.ToString(), 0).Where(l => l.fldEmployId == EmployeeId && l.fldOrganPostId == OrganPostId).Any();
                }
                else
                {
                    var query = p.spr_tblMasuolin_DetailSelect("fldMasuolinId", MasoulinId.ToString(), 0).Where(l => l.fldEmployId == EmployeeId && l.fldOrganPostId == OrganPostId).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion*/
        #region Masoulin_DetailList
        public List<OBJ_Masoulin_DetailList> Masoulin_DetailList(int HeaderId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_MasuolinDetailList(HeaderId)
                    .Select(q => new OBJ_Masoulin_DetailList()
                    {
                        fldId=q.fldId,
                        fldEmployeeId=q.fldEmployeeId,
                        fldNameEmployee=q.fldNameEmployee,
                        fldOrganId=q.fldOrganId,
                        fldNameOrgan=q.fldNameOrgan,
                        fldOrderId=q.fldOrderId,
                        fldMasuolinId = q.fldMasuolinId
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}