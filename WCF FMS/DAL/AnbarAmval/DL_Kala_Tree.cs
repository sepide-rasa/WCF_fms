using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.AnbarAmval
{
    public class DL_Kala_Tree
    {
        #region Insert
        public string Insert(int KalaId, int KalaTreeId, int UserId,int OrganId, string IP, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblKala_TreeInsert(KalaId, KalaTreeId, Desc, IP, UserId,OrganId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region UpdatePID_kala
        public string UpdatePID_kala(int Child, int Parent, int UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_UpdatePID_kala(Child, Parent, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion

        #region CheckExistsKala
        public int CheckExistsKala(int Id, string KalaTreeId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var fldCheck = p.spr_CheckExistsKala(Id, KalaTreeId).FirstOrDefault().fldCheck;
                return fldCheck;
            }
        }
        #endregion
    }
}