using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.DAL.Deceased
{
    public class DL_Kartabl
    {
        #region Detail
        public OBJ_Kartabl Detail(int id, int organId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var k = p.spr_tblKartablSelect("fldId", id.ToString(), organId, 1)
                    .Select(q => new OBJ_Kartabl
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTitleKartabl = q.fldTitleKartabl,
                        fldOrganId = q.fldOrganId,
                        fldIP = q.fldIP,
                        fldorderid = q.fldorderid,
                        fldEbtal=q.fldHaveEbtal,
                        fldEtmam=q.fldHaveEtmam,
                        fldTitleEbtal = q.fldTitleEbtal,
                        fldTitleEtmam = q.fldTitleEtmam
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Kartabl> Select(string FieldName, string FilterValue, int organId, int h)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var test = p.spr_tblKartablSelect(FieldName, FilterValue, organId, h)
                    .Select(q => new OBJ_Kartabl()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldTitleKartabl = q.fldTitleKartabl,
                        fldOrganId = q.fldOrganId,
                        fldIP = q.fldIP,
                        fldorderid = q.fldorderid,
                        fldEbtal = q.fldHaveEbtal,
                        fldEtmam = q.fldHaveEtmam,
                        fldTitleEbtal = q.fldTitleEbtal,
                        fldTitleEtmam = q.fldTitleEtmam
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldTitleKartabl, bool fldHaveEbtal, bool fldHaveEtmam, int organId, int userId, string Desc, string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblKartablInsert(fldTitleKartabl, userId, organId, IP, Desc,fldHaveEtmam,fldHaveEbtal);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, string fldTitleKartabl, bool fldHaveEbtal, bool fldHaveEtmam, int organId, int userId, string Desc, string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblKartablUpdate(fldId, fldTitleKartabl, userId, organId, IP, Desc,fldHaveEtmam,fldHaveEbtal);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblKartablDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string fldTitleKartabl, int organId, int Id)
        {
            bool q = false;
            using (DeceasedEntities p = new DeceasedEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblKartablSelect("fldTitleKartabl", fldTitleKartabl, organId, 0).Any();

                }
                else
                {
                    var query = p.spr_tblKartablSelect("fldTitleKartabl", fldTitleKartabl, organId, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion

        #region CheckDelete
        public bool CheckDelete(int id)
        {
            bool q = false;
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var m = p.spr_tblAction_KartablSelect("CheckKartablId", id.ToString(), 0, 1).FirstOrDefault();
               
                var n1 = p.spr_tblNextKartablSelect("CheckKartablNextId", id.ToString(), 0, 1).FirstOrDefault();
                var k = p.spr_tblKartabl_RequestSelect("CheckKartablId", id.ToString(), 0, 1).FirstOrDefault();
                if (m != null ||  n1 != null)
                    q = true;
            }


            return q;
        }
        #endregion

        #region UpdateOrderKartabl
        public string UpdateOrderKartabl(int fldKartablId, int fldOrderId, int userId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_UpdateOrderKartabl(fldKartablId, fldOrderId, userId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}