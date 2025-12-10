using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Automation
{
    public class DL_LetterNumber
    {
        #region Insert
        public int Insert(long fldLetterId,int StartNumber, int OrganID, int UserId, string Desc, string IP)
        {
            using (AutomationEntities p = new AutomationEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter fldNumber = new System.Data.Entity.Core.Objects.ObjectParameter("fldNumber", typeof(int));
                p.spr_tblLetterNumberInsert(fldLetterId, fldNumber, StartNumber, UserId, OrganID, Desc, IP);
                return Convert.ToInt32(fldNumber.Value);
            }
        }
        #endregion
    }
}