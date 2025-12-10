using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Deceased
{
    public class DL_InsertEmploye
    {
        #region Insert
        public int Insert(string CodeMeli,string CodeMoshakhase,string Name,string Family,string Sh_Sh,string NameFather, int userId, string Desc, string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldEmployeeId", typeof(int));
                p.spr_InsertEmployee(Id,CodeMeli,CodeMoshakhase,Name,Family,Sh_Sh,NameFather, userId, Desc, IP);
                return Convert.ToInt32(Id.Value);
            }
        }
        #endregion
    }
}