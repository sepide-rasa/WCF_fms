using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_DaramadGroup
    {
        #region Detail
        public OBJ_DaramadGroup Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblDaramadGroupSelect("fldId", Id.ToString(),0, 1)
                    .Select(q => new OBJ_DaramadGroup()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldOrganId=q.fldOrganId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_DaramadGroup> Select(string FieldName, string FilterValue,int OrganId, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblDaramadGroupSelect(FieldName, FilterValue,OrganId, h)
                    .Select(q => new OBJ_DaramadGroup()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldTitle = q.fldTitle,
                        fldOrganId = q.fldOrganId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Title, int UserId,int OrganId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblDaramadGroupInsert(Title, UserId, Desc, OrganId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Title, int UserId,int OrganId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblDaramadGroupUpdate(Id, Title, UserId, Desc,OrganId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblDaramadGroupDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
               var daramad= p.spr_tblDaramadGroup_ParametrSelect("fldDaramadGroupId", Id.ToString(), 0).ToList();
               foreach (var item in daramad)
               {
                   var value = p.spr_tblDaramadGroup_ParametrValuesSelect("fldParametrGroupDaramadId", item.fldId.ToString(), 0).FirstOrDefault();
                   if (value != null)
                   {
                       q = true;
                       break;
                   } 
               }
               return q;
            }
        }
        #endregion
    }
}