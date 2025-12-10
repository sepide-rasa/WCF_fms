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
    public class DL_Module
    {
        #region Detail
        public OBJ_Module Detail(int Id,int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblModuleSelect("fldId", Id.ToString(),UserId, 1)
                    .Select(q => new OBJ_Module()
                    {
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Module> Select(string FieldName, string FilterValue, int UserId, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblModuleSelect(FieldName, FilterValue,UserId, h)
                    .Select(q => new OBJ_Module()
                    {
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int UserId,string Title, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblModuleInsert(Title, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int UserId, string Title, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblModuleUpdate(Id, Title, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblModuleDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string Title, int Id)
        {
            bool q=false;
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblModuleSelect("CheckTitle", Title.ToString(),0, 0).Any();
                }
                else
                {
                    var query = p.spr_tblModuleSelect("CheckTitle", Title.ToString(),0, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            var q = false;
            using (RasaFMSCommonDBEntities m = new RasaFMSCommonDBEntities())
            {
                var Module_O = m.spr_tblModule_OrganSelect("CheckModuleId", id.ToString(), 0, 0).FirstOrDefault();
                if (Module_O != null)
                    q = true;
            }
            return q;
        }
        #endregion
    }
}