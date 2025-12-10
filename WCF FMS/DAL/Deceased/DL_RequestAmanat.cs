using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.DAL.Deceased
{
    public class DL_RequestAmanat
    {
        #region Detail
        public OBJ_RequestAmanat Detail(int id, int organId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var k = p.spr_tblRequestAmanatSelect("fldId", id.ToString(), organId, 1)
                    .Select(q => new OBJ_RequestAmanat
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldEmployeeId = q.fldEmployeeId,
                        fldOrganId = q.fldOrganId,
                        fldIP = q.fldIP,
                        fldShomareId = q.fldShomareId,
                        fldName = q.fldName,
                        fldFamily = q.fldFamily,
                        fldSh_Shenasname = q.fldSh_Shenasname,
                        fldFatherName = q.fldFatherName,
                        fldMeli_Moshakhase = q.fldMeli_Moshakhase,
                        fldNameVadiSalam = q.fldNameVadiSalam,
                        fldNameGhete = q.fldNameGhete,
                        fldNameRadif = q.fldNameRadif,
                        fldShomare = q.fldShomare,
                        fldTarikhRequest = q.fldTarikhRequest,
                        fldTitleKartabl = q.fldTitleKartabl,
                        fldKartablId = q.fldKartablId,
                        ExistsCharkhe = q.ExistsCharkhe,
                        fldGheteId = q.fldGheteId,
                        fldRadifId = q.fldRadifId,
                        fldVadiSalamId = q.fldVadiSalamId,
                        fldCodemeli = q.fldCodemeli,
                        fldCodeMoshakhase = q.fldCodeMoshakhase,
                        fldIsEbtal = q.fldIsEbtal,
                        fldIsEbtalName = q.fldIsEbtalName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_RequestAmanat> Select(string FieldName, string FilterValue, int organId, int h)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var test = p.spr_tblRequestAmanatSelect(FieldName, FilterValue, organId, h)
                    .Select(q => new OBJ_RequestAmanat()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldEmployeeId = q.fldEmployeeId,
                        fldOrganId = q.fldOrganId,
                        fldIP = q.fldIP,
                        fldShomareId = q.fldShomareId,
                        fldName = q.fldName,
                        fldFamily = q.fldFamily,
                        fldSh_Shenasname = q.fldSh_Shenasname,
                        fldFatherName = q.fldFatherName,
                        fldMeli_Moshakhase = q.fldMeli_Moshakhase,
                        fldNameVadiSalam = q.fldNameVadiSalam,
                        fldNameGhete = q.fldNameGhete,
                        fldNameRadif = q.fldNameRadif,
                        fldShomare = q.fldShomare,
                        fldTarikhRequest = q.fldTarikhRequest,
                        fldTitleKartabl = q.fldTitleKartabl,
                        fldKartablId = q.fldKartablId,
                        ExistsCharkhe = q.ExistsCharkhe,
                        fldGheteId = q.fldGheteId,
                        fldRadifId = q.fldRadifId,
                        fldVadiSalamId = q.fldVadiSalamId,
                        fldCodemeli = q.fldCodemeli,
                        fldCodeMoshakhase = q.fldCodeMoshakhase,
                        fldIsEbtal = q.fldIsEbtal,
                        fldIsEbtalName = q.fldIsEbtalName
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldEmployeeId, int fldShomareId, int organId, int userId, string Desc, string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                
                p.spr_tblRequestAmanatInsert(fldEmployeeId, fldShomareId, organId, userId, IP, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, int fldEmployeeId, int fldShomareId, int organId, int userId, string Desc, string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
             
                p.spr_tblRequestAmanatUpdate(fldId, fldEmployeeId, fldShomareId,  organId, userId, IP, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblRequestAmanatDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region UpdateRequestForEbtal
        public string UpdateRequestForEbtal(int fldId, int userId, string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {

                p.spr_UpdateRequestForEbtal(fldId, userId, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion

        #region UpdateEtmamCharkhe
        public string UpdateEtmamCharkhe(int fldId, int userId, string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {

                p.spr_UpdateEtmamCharkhe(fldId, userId, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}