using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_StatusTaghsit_Takhfif
    {
        #region Detail
        public OBJ_StatusTaghsit_Takhfif Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblStatusTaghsit_TakhfifSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_StatusTaghsit_Takhfif()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldRequestId = q.fldRequestId,
                        fldTypeMojavez = q.fldTypeMojavez,
                        fldTypeRequest = q.fldTypeRequest,
                        NoeDarkhast = q.NoeDarkhast,
                        Vaziyat = q.Vaziyat
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_StatusTaghsit_Takhfif> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblStatusTaghsit_TakhfifSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_StatusTaghsit_Takhfif()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldRequestId = q.fldRequestId,
                        fldTypeMojavez = q.fldTypeMojavez,
                        fldTypeRequest = q.fldTypeRequest,
                        NoeDarkhast = q.NoeDarkhast,
                        Vaziyat = q.Vaziyat
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int replyId, int RequestId, byte TypeMojavez, byte TypeRequest, decimal Darsad, long Mablagh, string Tarikh, long MablaghNaghdi, byte TedadAghsat, string ShomareMojavez, byte TedadMahAghsat, long JarimeTakhir, int organId, decimal DarsadTaghsit, string DescKarmozd, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblStatusTaghsit_TakhfifInsert(replyId, RequestId, TypeMojavez, TypeRequest, UserId, Desc, Darsad, Mablagh, Tarikh, MablaghNaghdi, TedadAghsat, ShomareMojavez, TedadMahAghsat, JarimeTakhir, organId, DarsadTaghsit,DescKarmozd);
                return "عملیات با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            var q = false;
            using (RasaNewFMSEntities m = new RasaNewFMSEntities())
            {
                var r = m.spr_tblReplyTakhfifSelect("fldStatusId", id.ToString(), 0).FirstOrDefault();
                var t = m.spr_tblReplyTaghsitSelect("fldStatusId", id.ToString(), 0).FirstOrDefault();
                if (r != null || t != null)
                    q = true;
                return q;
            }
        }
        #endregion
    }
}