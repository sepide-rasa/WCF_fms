using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.DAL.Deceased
{
    public class DL_GhabreAmanat
    {
        #region Detail
        public OBJ_GhabreAmanat Detail(int id,int OrganId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var k = p.spr_tblGhabreAmanatSelect("fldId", id.ToString(),OrganId, 1)
                    .Select(q => new OBJ_GhabreAmanat
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldShomareId = q.fldShomareId,
                        fldIP = q.fldIP,
                        fldShomareTabaghe = q.fldShomareTabaghe,
                        fldEmployeeId = q.fldEmployeeId,
                        fldOrganId = q.fldOrganId,
                        fldTarikhRezerv = q.fldTarikhRezerv,
                        fldShomare = q.fldShomare,
                        fldFatherName = q.fldFatherName,
                        fldCodemeli = q.fldCodemeli,
                        Tabaghe = q.Tabaghe,
                        fldname = q.fldname,
                        fldFamily = q.fldFamily,
                        fldSh_Shenasname = q.fldSh_Shenasname,
                        fldCodeMoshakhase = q.fldCodeMoshakhase,
                        fldGheteId = q.fldGheteId,
                        fldRadifId = q.fldRadifId,
                        fldVadiSalamId = q.fldVadiSalamId,
                        fldNameVadiSalam = q.fldNameVadiSalam,
                        fldNameGhete = q.fldNameGhete,
                        fldNameRadif = q.fldNameRadif,
                        fldMeli_Moshakhase = q.fldMeli_Moshakhase,
                        fldGhabrInfoId = q.fldGhabrInfoId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_GhabreAmanat> Select(string FieldName, string FilterValue,int OrganId, int h)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var test = p.spr_tblGhabreAmanatSelect(FieldName, FilterValue,OrganId, h)
                    .Select(q => new OBJ_GhabreAmanat()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldShomareId = q.fldShomareId,
                        fldIP = q.fldIP,
                        fldShomareTabaghe = q.fldShomareTabaghe,
                        fldEmployeeId = q.fldEmployeeId,
                        fldOrganId = q.fldOrganId,
                        fldTarikhRezerv = q.fldTarikhRezerv,
                        fldShomare = q.fldShomare,
                        fldFatherName = q.fldFatherName,
                        fldCodemeli = q.fldCodemeli,
                        Tabaghe = q.Tabaghe,
                        fldname = q.fldname,
                        fldFamily = q.fldFamily,
                        fldSh_Shenasname = q.fldSh_Shenasname,
                        fldCodeMoshakhase = q.fldCodeMoshakhase,
                        fldGheteId = q.fldGheteId,
                        fldRadifId = q.fldRadifId,
                        fldVadiSalamId = q.fldVadiSalamId,
                        fldNameVadiSalam = q.fldNameVadiSalam,
                        fldNameGhete = q.fldNameGhete,
                        fldNameRadif = q.fldNameRadif,
                        fldMeli_Moshakhase = q.fldMeli_Moshakhase,
                        fldGhabrInfoId = q.fldGhabrInfoId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int? fldShomareId, int? fldEmployeeId, int? OrganId, string fldTarikhRezerv, int userId, string Desc, string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                int? Tarikh = null;
                if (fldTarikhRezerv != null)
                    Tarikh = Convert.ToInt32(fldTarikhRezerv.Replace("/", ""));
                p.spr_tblGhabreAmanatInsert(fldShomareId,fldEmployeeId,OrganId,Tarikh, userId, Desc, IP);
                return "ذخیره با موفقیت انجام شد.";
            }
            
        }
        #endregion
        #region Update
        public string Update(int fldId, int? fldShomareId, int? fldEmployeeId, int? OrganId, string fldTarikhRezerv, int userId, string Desc, string IP)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                int? Tarikh = null;
                if (fldTarikhRezerv != null)
                    Tarikh = Convert.ToInt32(fldTarikhRezerv.Replace("/", ""));
                p.spr_tblGhabreAmanatUpdate(fldId, fldShomareId, fldEmployeeId, OrganId, Tarikh, userId, Desc, IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblGhabreAmanatDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            bool q = false;
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var m = p.spr_tblMotevaffaSelect("CheckGhabreAmanatId", id.ToString(), 0, 1).FirstOrDefault();
                if (m != null)
                    q = true;
            }


            return q;
        }
        #endregion
        //#region CheckSaveGhabreAmanat
        //public bool CheckSaveGhabreAmanat(int Id,int fldShomareId,int OrganId)
        //{
        //    var q = false;
        //    using (DeceasedEntities p = new DeceasedEntities())
        //    {
        //        if (Id == 0)
        //        {
        //            var tedadtabaghe = p.spr_tblShomareSelect("fldId", fldShomareId.ToString(), OrganId, 0).FirstOrDefault().fldTedadTabaghat;
        //            var Amanat = p.spr_tblGhabreAmanatSelect("fldShomareId", fldShomareId.ToString(), OrganId, 0).ToList();
        //            if (tedadtabaghe == Amanat.Count)
        //                q = true;
        //        }
        //        else
        //        {
        //            var tedadtabaghe = p.spr_tblShomareSelect("fldId", fldShomareId.ToString(), OrganId, 0).FirstOrDefault().fldTedadTabaghat;
        //            var Amanat = p.spr_tblGhabreAmanatSelect("fldShomareId", fldShomareId.ToString(), OrganId, 0).ToList();
        //            foreach (var item in Amanat)
        //            {
        //                if (item.fldId != Id)
        //                {
        //                    if (tedadtabaghe == Amanat.Count)
        //                        q = true;
        //                }  
        //            }
                    
        //        }
               
        //    }
        //    return q;
        //}
        //#endregion

        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int? fldEmployeeId, int Id)
        {
            bool q = false;
            using (DeceasedEntities p = new DeceasedEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblGhabreAmanatSelect("CheckEmployeeId", fldEmployeeId.ToString(), 0, 0).Any();

                }
                else
                {
                    var query = p.spr_tblGhabreAmanatSelect("CheckEmployeeId", fldEmployeeId.ToString(), 0, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion

        #region RptGhabrPor_Khali
        public List<OBJ_GhabrPor_Khali> RptGhabrPor_Khali(string FieldName, int VadiId, int GheteId, int RadifId, int ShomareId, int OrganId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var test = p.spr_RptGhabrPor_Khali(FieldName, VadiId, GheteId, RadifId, ShomareId, OrganId)
                    .Select(q => new OBJ_GhabrPor_Khali()
                    {
                        GheteId = q.GheteId,
                        RadifId = q.RadifId,
                        ShomareId = q.ShomareId,
                        NameGhete = q.NameGhete,
                        NameRadif = q.NameRadif,
                        Shomare = q.Shomare,
                        Tabaghe = q.Tabaghe,
                        Name_Family = q.Name_Family,
                        Meli_Moshakhase = q.Meli_Moshakhase,
                        FatherName = q.FatherName,
                        Sh_Sh = q.Sh_Sh,
                        TarikhFot = q.TarikhFot,
                        NameVadiSalam = q.NameVadiSalam
                    }).ToList();
                return test;
            }
        }
        #endregion

        #region SelectInfoEmployeeInGhabrAmanat
        public List<OBJ_EmployeeInGhabrAmanat> SelectInfoEmployeeInGhabrAmanat(int ShomareId,byte ShomareTabaghe)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var test = p.spr_SelectInfoEmployeeInGhabrAmanat(ShomareId, ShomareTabaghe)
                    .Select(q => new OBJ_EmployeeInGhabrAmanat()
                    {
                        fldid = q.fldid,
                        fldShomareTabaghe = q.fldShomareTabaghe,
                        fldName_Family = q.fldName_Family,
                        fldFatherName = q.fldFatherName,
                        fldSh_Shenasname = q.fldSh_Shenasname,
                        fldMeli_Moshakhase = q.fldMeli_Moshakhase,
                        fldTarikhRezerv=q.fldTarikhRezerv,
                        fldTarikhFot = q.fldTarikhFot,
                        fldNameMahal = q.fldNameMahal,
                        fldReason = q.fldReason,
                        fldTarikhDafn = q.fldTarikhDafn
                    }).ToList();
                return test;
            }
        }
        #endregion
    }
}