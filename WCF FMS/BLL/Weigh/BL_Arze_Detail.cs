using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Weigh;
using WCF_FMS.TOL.Weigh;

namespace WCF_FMS.BLL.Weigh
{
    public class BL_Arze_Detail
    {
        DL_Arze_Detail Arze_Detail = new DL_Arze_Detail();

        
        #region Select
        public List<OBJ_Arze_Detail> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return Arze_Detail.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion

        #region Insert
        public string Insert(int fldHeaderId, int? fldParametrSabetCodeDaramd, string fldValue, bool fldFlag, int userId, int OrganId, string Desc, string IP, out ClsError error)
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
            else if (fldHeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد عرضه ضروری است";
            }
           
            
                
            
            if (error.ErrorType == true)
                return "خطا";

            return Arze_Detail.Insert(fldHeaderId, fldParametrSabetCodeDaramd, fldValue, fldFlag, userId, OrganId, Desc, IP);

        }
        #endregion

        #region Delete
        public string Delete(int id, int userId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Arze_Detail.Delete(id, userId);
        }
        #endregion
    }
}