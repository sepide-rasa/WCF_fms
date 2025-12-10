using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_Psp
    {
        #region Detail
        public OBJ_Psp Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblPspSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_Psp()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldFileId=q.fldFileId,
                        fldTitle = q.fldTitle
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Psp> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblPspSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Psp()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldFileId = q.fldFileId,
                        fldTitle = q.fldTitle
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Title, byte[] File, string Pasvand, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPspInsert(File, Pasvand, Title, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Title,int FileId, byte[] File, string Pasvand, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPspUpdate(Id, Title, UserId, Desc, File, Pasvand, FileId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPspDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string Title, int Id)
        {
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblPspSelect("fldTitle", Title, 0).Any();

                }
                else
                {
                    var query = p.spr_tblPspSelect("fldTitle", Title, 0).FirstOrDefault();
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
        public bool CheckDelete(int Id)
        {
            var q = false;
            using(RasaNewFMSEntities m=new RasaNewFMSEntities())
            {
                var Param = m.spr_tblPcPosParametrSelect("CheckPspId", Id.ToString(), 0, 0).FirstOrDefault();
                var Info = m.spr_tblPcPosInfoSelect("CheckPspId", Id.ToString(), "", 0).FirstOrDefault();
                var C = m.spr_tblPspModelSelect("fldPspId", Id.ToString(), 0).FirstOrDefault();
                if (Param != null || Info != null||C!=null)
                    q = true;
            }
            return q;
        }
        #endregion
    }
}