using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Chek;

namespace WCF_FMS.DAL.Chek
{
    public class DL_StatusChek
    {
        #region Insert
        public string Insert(Nullable<int> SodorCheckId, Nullable<int> CheckVaredeId, Nullable<int> AghsatId, byte Status, string Tarikh, int UserId, string Desc)
        {
            using (ChekEntities p = new ChekEntities())
            {
                p.spr_tblCheckStatusInsert(SodorCheckId, CheckVaredeId, AghsatId, Status, Tarikh, UserId, Desc);
                return "تغییر وضعیت با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}