using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_ChartOrganEjraee
    {
        #region Detail
        public OBJ_ChartOrganEjraee Detail(int Id)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblChartOrganEjraeeSelect("fldId", Id.ToString(), 0, 1)
                    .Select(q => new OBJ_ChartOrganEjraee()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldNoeVahed = q.fldNoeVahed,
                        fldNoeVahedName = q.fldNoeVahedName,
                        fldOrganId = q.fldOrganId,
                        fldOrganizationName = q.fldOrganizationName,
                        fldPId = q.fldPId,
                        fldTitle = q.fldTitle,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ChartOrganEjraee> Select(string FieldName, string FilterValue,int UserId, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblChartOrganEjraeeSelect(FieldName, FilterValue, UserId, h)
                    .Select(q => new OBJ_ChartOrganEjraee()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldNoeVahed = q.fldNoeVahed,
                        fldNoeVahedName = q.fldNoeVahedName,
                        fldOrganId = q.fldOrganId,
                        fldOrganizationName = q.fldOrganizationName,
                        fldPId = q.fldPId,
                        fldTitle = q.fldTitle,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Title, Nullable<int> PId, Nullable<int> OrganId, byte NoeVahed, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblChartOrganEjraeeInsert(Title, PId, OrganId, NoeVahed, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Title, Nullable<int> PId, Nullable<int> OrganId, byte NoeVahed, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblChartOrganEjraeeUpdate(Id, Title, PId, OrganId, NoeVahed, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblChartOrganEjraeeDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id,int organId)
        {
            bool q = false;
            using (RasaFMSCommonDBEntities m = new RasaFMSCommonDBEntities())
            {
                var o = m.spr_tblOrganizationalPostsEjraeeSelect("fldChartOrganId", Id.ToString(), 0, 1).FirstOrDefault();
                //var ch = m.spr_CheckCharEjraeeForSecretariat(Id).FirstOrDefault();
                if (o != null)
                    q = true;
                else
                {
                    var s = m.spr_tblModule_OrganSelect("CheckModuleId", "11", 0, 1).Where(l => l.fldOrganId == organId).Any();
                    if (s)
                    {
                        AutomationEntities p = new AutomationEntities();
                        var oo = p.spr_tblSecretariat_OrganizationUnitSelect("checkChartOrgan", Id.ToString(), 0, 1).FirstOrDefault();
                        if (oo != null)
                            q = true;
                    }
                }

            }
            return q;
        }
        #endregion
        //#region CheckUpdate
        //public bool CheckUpdate(int Id)
        //{
        //    bool q = false;
        //    using (RasaFMSCommonDBEntities m = new RasaFMSCommonDBEntities())
        //    {
        //         q = m.spr_CheckCharEjraeeForSecretariat(Id).Any();
        //    }
        //    return q;
        //}
        //#endregion

        //#region CheckDeleteAuto
        //public bool CheckDeleteAuto(int Id)
        //{
        //    bool q = false;
        //    using (RasaFMSCommonDBEntities m = new RasaFMSCommonDBEntities())
        //    {
        //        q = m.spr_CheckCharEjraeeForSecretariat(Id).Any();
        //    }
        //    return q;
        //}
        //#endregion

        #region SelectChartEjraee_LastNode
        public List<OBJ_ChartOrganEjraee> SelectChartEjraee_LastNode(int OrganId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_SelectChartEjraee_LastNode(OrganId)
                    .Select(q => new OBJ_ChartOrganEjraee()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldNoeVahed = q.fldNoeVahed,
                        fldNoeVahedName = q.fldNoeVahedName,
                        fldOrganId = q.fldOrganId,
                        fldOrganizationName = q.fldOrganizationName,
                        fldPId = q.fldPId,
                        fldTitle = q.fldTitle,
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}