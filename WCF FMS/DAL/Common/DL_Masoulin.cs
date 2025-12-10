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
    public class DL_Masoulin
    {
        #region Detail
        public OBJ_Masoulin Detail(int Id,int OrganId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblMasuolinSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_Masoulin()
                    {
                        fldId = q.fldId,
                        fldTitleModule=q.fldTitleModule,
                        fldUserId = q.fldUserId,
                        fldTarikhEjra = q.fldTarikhEjra,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldModule_OrganId = q.fldModule_OrganId,
                        fldModule_OrganName = q.fldModule_OrganName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Masoulin> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblMasuolinSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_Masoulin()
                    {
                        fldId = q.fldId,
                        fldTitleModule=q.fldTitleModule,
                        fldUserId = q.fldUserId,
                        fldTarikhEjra = q.fldTarikhEjra,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldModule_OrganId = q.fldModule_OrganId,
                        fldModule_OrganName = q.fldModule_OrganName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string TarikhEjra, int Module_OrganId, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblMasuolinInsert(TarikhEjra, Module_OrganId, UserId, Desc);
                
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string TarikhEjra, int Module_OrganId, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblMasuolinUpdate(Id, TarikhEjra, Module_OrganId, UserId, Desc);
                
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string TarikhEjra, int Module_OrganId, int Id)
        {
            bool q = false; 
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblMasuolinSelect("CheckTarikhEjra", TarikhEjra, 0, 0).Where(l => l.fldModule_OrganId == Module_OrganId).Any();

                }
                else
                {
                    var query = p.spr_tblMasuolinSelect("CheckTarikhEjra", TarikhEjra, 0, 0).Where(l => l.fldModule_OrganId == Module_OrganId).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
      /*  #region CheckRepeatedRow
        public bool CheckRepeatedRow(int ModuleId,string TarikhEjra,List<OBJ_Masoulin_Detail> Detail,int Id)
        {
            bool q = false;
            if (Id == 0)
            {
                foreach (var item in Detail)
                {
                    var h = Detail.Where(l => l.fldEmployeeId != item.fldEmployeeId || l.fldOrganId != item.fldOrganId);
                    var q1 = h.Contains(item);
                    if (q1 == true)
                    {
                        q = true;
                        break;
                    }
                }
            }
            else
            {
                using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
                {
                    var query = p.spr_tblMasuolinSelect("fldTarikhEjra", TarikhEjra, 0).Where(l => l.fldModuleId == ModuleId).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                    else
                    {
                        foreach (var item in Detail)
                        {
                            var h = Detail.Where(l => l.fldEmployeeId != item.fldEmployeeId && l.fldOrganId != item.fldOrganId);
                            var q1 = h.Contains(item);
                            if (q1 == true)
                            {
                                q = true;
                                break;
                            }
                        }
                    }    
                }
            }
            return q;
        }
        #endregion*/
        #region SelectMasuolin_ZirList
        public List<OBJ_Masuolin_ZirList> SelectMasuolin_ZirList(int headerId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_Masuolin_ZirList(headerId)
                    .Select(q => new OBJ_Masuolin_ZirList()
                    {
                        fldid = q.fldid,
                        fldMasirReport = q.fldMasirReport,
                        fldTitle = q.fldTitle,
                        C1 = q.C1,
                        C2 = q.C2,
                        C3 = q.C3,
                        C4 = q.C4,
                        C5 = q.C5
                    }).ToList();
                return k;
            }
        }
        #endregion


    }
}