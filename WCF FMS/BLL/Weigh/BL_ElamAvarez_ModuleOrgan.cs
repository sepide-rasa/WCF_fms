using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Weigh;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.BLL.Weigh
{
    public class BL_ElamAvarez_ModuleOrgan
    {
        DL_ElamAvarez_ModuleOrgan ElamAvarez_ModuleOrgan = new DL_ElamAvarez_ModuleOrgan();
        #region Select
        public List<OBJ_ElameAvarez_ModuleOrgan> Select(string FieldName, string FilterValue, int h)
        {
            return ElamAvarez_ModuleOrgan.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldElamAvarezId, int fldCodeDaramdElamAvarezId, int Id, int userId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (fldElamAvarezId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اعلام عوارض ضروری است";
            }
            else if (fldCodeDaramdElamAvarezId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد درآمد اعلام عوارض ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد جدول ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ElamAvarez_ModuleOrgan.Insert(fldElamAvarezId, fldCodeDaramdElamAvarezId, Id, userId, Desc, IP);
        }
        #endregion
    }
}