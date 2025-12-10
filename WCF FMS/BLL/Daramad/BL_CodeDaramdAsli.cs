using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_CodeDaramdAsli
    {
        DL_CodeDaramdAsli CodeDaramdAsli = new DL_CodeDaramdAsli();
        #region Select
        public List<OBJ_ShomareHesabCodeDaramad> select()
        {
            return CodeDaramdAsli.select();
        }
            #endregion


    }
}