using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_AfradTahtePooshesh
    {
        #region Detail
        public OBJ_AfradTahtePooshesh Detail(int Id, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblAfradTahtePoosheshSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_AfradTahtePooshesh()
                    {
                        fldBirthDate = q.fldBirthDate,
                        fldCodeMeli = q.fldCodeMeli,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldFamily = q.fldFamily,
                        fldFatherName = q.fldFatherName,
                        fldId = q.fldId,
                        fldMashmul = q.fldMashmul,
                        fldMashmulName = q.fldMashmulName,
                        fldName = q.fldName,
                        fldNameNesbat = q.fldNameNesbat,
                        fldNesbat = q.fldNesbat,
                        fldPersonalId = q.fldPersonalId,
                        fldSh_Shenasname = q.fldSh_Shenasname,
                        fldStatus = q.fldStatus,
                        fldStatusName = q.fldStatusName,
                        fldUserId = q.fldUserId,
                        fldTarikhEzdevaj = q.fldTarikhEzdevaj,
                        fldNesbatShakhs = Convert.ToByte(q.fldNesbatShakhs),
                       fldNameNesbatShakhs= q.fldNameNesbatShakhs,
                       fldMashmoolPadash=q.fldMashmoolPadash,
                       fldMashmoolPadashName=q.fldMashmoolPadashName,
                       fldTarikhTalagh=q.fldTarikhTalagh
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_AfradTahtePooshesh> Select(string FieldName, string FilterValue,int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblAfradTahtePoosheshSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_AfradTahtePooshesh()
                    {
                        fldBirthDate = q.fldBirthDate,
                        fldCodeMeli = q.fldCodeMeli,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldFamily = q.fldFamily,
                        fldFatherName = q.fldFatherName,
                        fldId = q.fldId,
                        fldMashmul = q.fldMashmul,
                        fldMashmulName = q.fldMashmulName,
                        fldName = q.fldName,
                        fldNameNesbat = q.fldNameNesbat,
                        fldNesbat = q.fldNesbat,
                        fldPersonalId = q.fldPersonalId,
                        fldSh_Shenasname = q.fldSh_Shenasname,
                        fldStatus = q.fldStatus,
                        fldStatusName = q.fldStatusName,
                        fldUserId = q.fldUserId,
                        fldTarikhEzdevaj = q.fldTarikhEzdevaj,
                        fldNesbatShakhs = Convert.ToByte(q.fldNesbatShakhs),
                        fldNameNesbatShakhs = q.fldNameNesbatShakhs,
                        fldMashmoolPadash = q.fldMashmoolPadash,
                        fldMashmoolPadashName = q.fldMashmoolPadashName,
                        fldTarikhTalagh=q.fldTarikhTalagh
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldPersonalId, string fldName, string fldFamily, string fldBirthDate, byte fldStatus, bool fldMashmul, byte fldNesbat, string fldCodeMeli, 
            string fldSh_Shenasname, string fldFatherName, string fldTarikhEzdevaj, byte fldNesbatShakhs, int fldUserId, string fldDesc,bool fldMashmoolPadash,string fldTarikhTalagh)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblAfradTahtePoosheshInsert(fldPersonalId, fldName, fldFamily, fldBirthDate, fldStatus, fldMashmul, fldNesbat, fldCodeMeli, fldSh_Shenasname,
                    fldFatherName, fldUserId, fldDesc, fldTarikhEzdevaj, fldNesbatShakhs, fldMashmoolPadash, fldTarikhTalagh);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int fldPersonalId, string fldName, string fldFamily, string fldBirthDate, byte fldStatus, bool fldMashmul, byte fldNesbat,
            string fldCodeMeli, string fldSh_Shenasname, string fldFatherName, string fldTarikhEzdevaj, byte fldNesbatShakhs, int fldUserId, string fldDesc, bool fldMashmoolPadash, string fldTarikhTalagh)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblAfradTahtePoosheshUpdate(Id, fldPersonalId, fldName, fldFamily, fldBirthDate, fldStatus, fldMashmul, fldNesbat, fldCodeMeli, fldSh_Shenasname,
                    fldFatherName, fldUserId, fldDesc, fldTarikhEzdevaj, fldNesbatShakhs, fldMashmoolPadash, fldTarikhTalagh);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region UpdateMohasel
        public string UpdateMohasel(int Id, byte fldStatus, string fldTarikhTalagh, int fldUserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblAfradTahtePoosheshUpdate_Mohasel(Id, fldStatus, fldTarikhTalagh, fldUserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblAfradTahtePoosheshDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}