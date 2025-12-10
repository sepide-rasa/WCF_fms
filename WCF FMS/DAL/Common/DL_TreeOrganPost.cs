using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.DAL.Common
{
    public class DL_TreeOrganPost
    {
        #region Select
        public List<OBJ_TreeOrganPost> Select(string FieldName, string Value, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var test = p.spr_TreeOrganPost(FieldName, Value, UserId)
                    .Select(q => new OBJ_TreeOrganPost()
                    {
                        id = q.id,
                        pid = q.pid,
                        title = q.title,
                        Namechart = q.Namechart,
                        fldOrgPostCode = q.fldOrgPostCode
                    }).ToList();
                return test;
            }
        }
        #endregion

        #region TreeOrganPostEjra
        public List<OBJ_TreeOrganPost> TreeOrganPostEjra(string FieldName, string Value, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var test = p.spr_TreeOrganPostEjra(FieldName, Value, UserId)
                    .Select(q => new OBJ_TreeOrganPost()
                    {
                        id = q.id,
                        pid = q.pid,
                        title = q.title,
                        Namechart = q.Namechart,
                        fldOrgPostCode = q.fldOrgPostCode
                    }).ToList();
                return test;
            }
        }
        #endregion
    }
}