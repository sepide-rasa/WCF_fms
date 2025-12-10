using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL
{
    public class DL
    {
        public bool DLPermission(int AppId, int UserId,int OrganId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var q = p.spr_tblPermissionSelect("HaveAcces", AppId.ToString(), UserId, OrganId, 0).Any();
                return q;
            }
        }
        public string DLErrorMsg(string UserName, string Er, string IP, int? UserId)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter ErrorId = new System.Data.Entity.Core.Objects.ObjectParameter("fldId", typeof(int));
                var q = p.spr_tblErrorInsert(ErrorId, UserName, Er, DateTime.Now, IP, UserId, "");
                return "خطا با شماره " + ErrorId.Value + " رخ داده است، لطفا با پشتیبان تماس بگیرید.";
            }
        }
    }
}