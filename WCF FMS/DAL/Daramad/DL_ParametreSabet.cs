using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_ParametreSabet
    {
        #region Detail
        public OBJ_ParametreSabet Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblParametreSabetSelect("fldId", Id.ToString(),"", 1)
                    .Select(q => new OBJ_ParametreSabet()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldShomareHesabCodeDaramadId = q.fldShomareHesabCodeDaramadId,
                        fldComboBaxId=q.fldComboBaxId,
                        fldDaramadTitle=q.fldDaramadTitle,
                        fldNameParametreEn=q.fldNameParametreEn,
                        fldNameParametreFa=q.fldNameParametreFa,
                        fldNoe=q.fldNoe,
                        fldNoeField=q.fldNoeField,
                        fldTitle=q.fldTitle,
                        fldVaziyat=q.fldVaziyat,
                        NoeFieldName=q.NoeFieldName,
                        NoeName=q.NoeName,
                        VaziyatName = q.VaziyatName,
                        fldFormulId = q.fldFormulId,
                        fldTypeParametr = q.fldTypeParametr,
                        fldNoeParametr = q.fldNoeParametr
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ParametreSabet> Select(string FieldName, string FilterValue, string FilterValue1, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblParametreSabetSelect(FieldName, FilterValue,FilterValue1, h)
                    .Select(q => new OBJ_ParametreSabet()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldShomareHesabCodeDaramadId = q.fldShomareHesabCodeDaramadId,
                        fldComboBaxId = q.fldComboBaxId,
                        fldDaramadTitle = q.fldDaramadTitle,
                        fldNameParametreEn = q.fldNameParametreEn,
                        fldNameParametreFa = q.fldNameParametreFa,
                        fldNoe = q.fldNoe,
                        fldNoeField = q.fldNoeField,
                        fldTitle = q.fldTitle,
                        fldVaziyat = q.fldVaziyat,
                        NoeFieldName = q.NoeFieldName,
                        NoeName = q.NoeName,
                        VaziyatName = q.VaziyatName,
                        fldFormulId = q.fldFormulId,
                        fldTypeParametr = q.fldTypeParametr,
                        fldNoeParametr = q.fldNoeParametr
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int ShomareHesabCodeDaramadId, string NameParametreFa, string NameParametreEn, bool Noe, byte NoeField, bool Vaziyat, Nullable<int> ComboBaxId,bool TypeParametr, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblParametreSabetInsert(ShomareHesabCodeDaramadId, NameParametreFa, NameParametreEn, Noe, NoeField, Vaziyat, ComboBaxId, UserId, Desc, TypeParametr);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int ShomareHesabCodeDaramadId, string NameParametreFa, string NameParametreEn, bool Noe, byte NoeField, bool Vaziyat, Nullable<int> ComboBaxId, bool TypeParametr, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblParametreSabetUpdate(Id, ShomareHesabCodeDaramadId, NameParametreFa, NameParametreEn, Noe, NoeField, Vaziyat, ComboBaxId, UserId, Desc,TypeParametr);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblParametreSabetDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int ShomareHesabCodeDaramadId, string NameParametreFa, string NameParametreEn, int Id)
        {
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                if (Id == 0)
                {
                    var Parametre = p.spr_tblParametreSabetSelect("fldNameParametreFa", NameParametreFa,ShomareHesabCodeDaramadId.ToString(), 0).FirstOrDefault();
                    if (Parametre != null)
                        q = true;
                    var Parametre1 = p.spr_tblParametreSabetSelect("fldNameParametreEn", NameParametreEn, ShomareHesabCodeDaramadId.ToString(), 0).FirstOrDefault();
                    if (Parametre1 != null)
                        q = true;
                }
                else
                {
                    var query = p.spr_tblParametreSabetSelect("fldNameParametreFa", NameParametreFa, ShomareHesabCodeDaramadId.ToString(), 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                    var query1 = p.spr_tblParametreSabetSelect("fldNameParametreEn", NameParametreEn, ShomareHesabCodeDaramadId.ToString(), 0).FirstOrDefault();
                    if (query1 != null && query1.fldId != Id)
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
            using (RasaNewFMSEntities m = new RasaNewFMSEntities())
            {
                var q = false;
                var Param = m.spr_tblParametreSabet_ValueSelect("fldParametreSabetId", Id.ToString(), "", 0).FirstOrDefault();
                var Param_N = m.spr_tblParametreSabet_NerkhSelect("fldParametreSabetId", Id.ToString(), 0).FirstOrDefault();
                if (Param != null || Param_N != null)
                    q = true;
                return q;
            }
        }
        #endregion
    }
}