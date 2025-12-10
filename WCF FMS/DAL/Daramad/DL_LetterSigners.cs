using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_LetterSigners
    {
        #region Details
        public OBJ_LetterSigners Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var e = p.spr_tblLetterSignersSelect("fldId", Id.ToString(), 1).Select(q => new OBJ_LetterSigners()
                {
                    fldDate=q.fldDate,
                    fldDesc=q.fldDesc,
                    fldId=q.fldId,
                    fldLetterMinutId=q.fldLetterMinutId,
                    fldOrganizationalPostsId=q.fldOrganizationalPostsId,
                    fldUserId=q.fldUserId
                }).FirstOrDefault();
                return e;
            }
        }
        #endregion
        #region Select
        public List<OBJ_LetterSigners> Select(string fieldname, string value, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var d = p.spr_tblLetterSignersSelect(fieldname, value, h).Select(q => new OBJ_LetterSigners()
                {
                    fldDate = q.fldDate,
                    fldDesc = q.fldDesc,
                    fldId = q.fldId,
                    fldLetterMinutId = q.fldLetterMinutId,
                    fldOrganizationalPostsId = q.fldOrganizationalPostsId,
                    fldUserId = q.fldUserId
                }).ToList();
                return d;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldLetMiId, int fldOrgPosId,int fldUserId, string flddesc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblLetterSignersInsert(fldLetMiId, fldOrgPosId,fldUserId, flddesc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId,int fldLetMiId, int fldOrgPosId, int fldUserId, string flddesc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblLetterSignersUpdate(fldId, fldLetMiId, fldOrgPosId, fldUserId, flddesc);
                return "ویرایش با موفقیت انجام شد.";
            }    
        }
        #endregion
        #region Delete
        public string Delete(int fldLetterMinutId, int fldUserID)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblLetterSignersDelete(fldLetterMinutId, fldUserID);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}