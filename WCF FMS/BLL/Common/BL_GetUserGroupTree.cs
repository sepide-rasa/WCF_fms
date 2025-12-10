using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Common;
using WCF_FMS.TOL.Common;

namespace WCF_FMS.BLL.Common
{
    public class BL_GetUserGroupTree
    {
        DL_GetUserGroupTree UserGroupTree = new DL_GetUserGroupTree();
        #region Select
        public List<OBJ_GetUserGroupTree> Select(int UserId, int UserLoginId)
        {
            return UserGroupTree.Select(UserId, UserLoginId);
        }
        #endregion
    }
}