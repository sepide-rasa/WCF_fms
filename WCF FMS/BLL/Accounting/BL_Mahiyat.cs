using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_Mahiyat
    {
        DL_Mahiyat Mahiyat = new DL_Mahiyat();
        public List<OBJ_Mahiyat> Select(string FieldName, string FilterValue, int h)
        {
            return Mahiyat.Select(FieldName, FilterValue, h);
        }
    }
}