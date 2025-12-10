using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll; 

namespace WCF_FMS.BLL.PayRoll
{
    public class BL_AfradTahtePoosheshSelect_FromExcel
    {
        DL_AfradTahtePoosheshSelect_FromExcel AfradTahtePoosheshSelect_FromExcel = new DL_AfradTahtePoosheshSelect_FromExcel();
        #region Select
        public List<OBJ_AfradTahtePoosheshSelect_FromExcel> Select(string CodeMeli, int GharardadBimeId, int UserId)
        {
            return AfradTahtePoosheshSelect_FromExcel.Select(CodeMeli, GharardadBimeId, UserId);
        }
        #endregion
    }
}