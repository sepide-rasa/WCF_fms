using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_TreeOrganPost
    {
        DL_TreeOrganPost TreeOrganPost = new DL_TreeOrganPost();
        #region Select
        public List<OBJ_TreeOrganPost> Select(string FieldName, string Value, int UserId)
        {
            return TreeOrganPost.Select(FieldName, Value, UserId);
        }
        #endregion

        #region TreeOrganPostEjra
        public List<OBJ_TreeOrganPost> TreeOrganPostEjra(string FieldName, string Value, int UserId)
        {
            return TreeOrganPost.TreeOrganPostEjra(FieldName, Value, UserId);
        }
        #endregion
    }
}