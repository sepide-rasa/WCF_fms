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
    public class DL_Parametrs
    {
        #region Detail
        public OBJ_Parametrs Detail(int Id,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblParametrsSelect("fldId", Id.ToString(), OrganId.ToString(), 1)
                    .Select(q => new OBJ_Parametrs()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldTitle = q.fldTitle,
                        fldTypeEstekhdamId = q.fldTypeEstekhdamId,
                        fldTypeMablagh = q.fldTypeMablagh,
                        fldTypeParametr = q.fldTypeParametr,
                        fldUserId = q.fldUserId,
                        fldNoeParametrName = q.fldNoeParametrName,
                        fldNoeMablaghName = q.fldNoeMablaghName,
                        TypeEstekhdamName = q.TypeEstekhdamName,
                        fldFormulId = q.fldFormulId,
                        fldActive = q.fldActive,
                        fldPrivate = q.fldPrivate,
                        fldHesabTypeParam = q.fldHesabTypeParam,
                        fldActiveName = q.fldActiveName,
                        fldPrivateName = q.fldPrivateName,
                        fldHesabTypeParamName = q.fldHesabTypeParamName,
                        fldIsMostamar = q.fldIsMostamar,
                        fldMostamarName = q.fldMostamarName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Parametrs> Select(string FieldName, string FilterValue, string FilterValue2, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblParametrsSelect(FieldName, FilterValue, FilterValue2, h)
                    .Select(q => new OBJ_Parametrs()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldTitle = q.fldTitle,
                        fldTypeEstekhdamId = q.fldTypeEstekhdamId,
                        fldTypeMablagh = q.fldTypeMablagh,
                        fldTypeParametr = q.fldTypeParametr,
                        fldUserId = q.fldUserId,
                        fldNoeParametrName = q.fldNoeParametrName,
                        fldNoeMablaghName = q.fldNoeMablaghName,
                        TypeEstekhdamName = q.TypeEstekhdamName,
                        fldFormulId = q.fldFormulId,
                        fldActive = q.fldActive,
                        fldPrivate = q.fldPrivate,
                        fldHesabTypeParam = q.fldHesabTypeParam,
                        fldActiveName = q.fldActiveName,
                        fldPrivateName = q.fldPrivateName,
                        fldHesabTypeParamName = q.fldHesabTypeParamName,
                        fldIsMostamar = q.fldIsMostamar,
                        fldMostamarName = q.fldMostamarName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Title, bool TypeParametr, bool TypeMablagh, int? TypeEstekhdamId, int UserId, string Desc, bool Active, bool Private, byte HesabTypeParam, byte IsMostamar, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblParametrsInsert(Title, TypeParametr, TypeMablagh, TypeEstekhdamId, UserId, Desc,Active,Private,HesabTypeParam,IsMostamar,OrganId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Title, bool TypeParametr, bool TypeMablagh, int? TypeEstekhdamId, int UserId, string Desc, bool Active, bool Private, byte HesabTypeParam, byte IsMostamar, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblParametrsUpdate(Id, Title, TypeParametr, TypeMablagh, TypeEstekhdamId, UserId, Desc, Active, Private, HesabTypeParam, IsMostamar, OrganId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblParametrsDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var kosorat = p.spr_tblKosorateParametri_PersonalSelect("CheckParametrId", Id.ToString(), "", "", "", 0, 1).FirstOrDefault();
                var Motalebate = p.spr_tblMotalebateParametri_PersonalSelect("CheckParametrId", Id.ToString(), "", "", "", 0, 1).FirstOrDefault();
                if (Motalebate != null || kosorat != null)
                    q = true;
                return q;
            }
        }
        #endregion
    }
}