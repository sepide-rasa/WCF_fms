using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Chek;

namespace WCF_FMS.DAL.Chek
{
    public class DL_CheckHayeVarede
    {
        #region Detail
        public OBJ_CheckHayeVarede Detail(int Id, int OrganId)
        {
            using (ChekEntities p = new ChekEntities())
            {
                var k = p.spr_tblCheckHayeVaredeSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_CheckHayeVarede()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldBabat = q.fldBabat,
                        fldIdShobe = q.fldIdShobe,
                        fldMablagh = q.fldMablagh,
                        fldNoeeCheck = q.fldNoeeCheck,
                        fldSaderKonandeh = q.fldSaderKonandeh,
                        fldShenaseKamelCheck = q.fldShenaseKamelCheck,
                        fldTarikhDaryaftCheck = q.fldTarikhDaryaftCheck,
                        fldTarikhVosolCheck = q.fldTarikhVosolCheck,
                        NoeeCheckName = q.NoeeCheckName,
                        fldShobeName = q.fldShobeName,
                        fldBankName = q.fldBankName,
                        fldBankId = q.fldBankId,
                        TarikhSabt = q.TarikhSabt,
                        NameFamily = q.NameFamily,
                        fldvaziat = q.fldvaziat,
                        NameVaziat = q.NameVaziat,
                        fldTarikhVaziat = q.fldTarikhVaziat,
                        fldOrganId = q.fldOrganId,
                        fldStatus = q.fldStatus,
                        fldCodemeli = q.fldCodemeli,
                        fldAshkhasId = q.fldAshkhasId,
                        fldTypeShakhs = q.fldTypeShakhs,
                        fldReceive=q.fldReceive,
                        fldReceiveName=q.fldReceiveName,
                        fldElamAvarezId=q.fldElamAvarezId
                       
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_CheckHayeVarede> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (ChekEntities p = new ChekEntities())
            {
                var k = p.spr_tblCheckHayeVaredeSelect(FieldName, FilterValue,OrganId, h)
                    .Select(q => new OBJ_CheckHayeVarede()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldBabat = q.fldBabat,
                        fldIdShobe = q.fldIdShobe,
                        fldMablagh = q.fldMablagh,
                        fldNoeeCheck = q.fldNoeeCheck,
                        fldSaderKonandeh = q.fldSaderKonandeh,
                        fldShenaseKamelCheck = q.fldShenaseKamelCheck,
                        fldTarikhDaryaftCheck = q.fldTarikhDaryaftCheck,
                        fldTarikhVosolCheck = q.fldTarikhVosolCheck,
                        NoeeCheckName = q.NoeeCheckName,
                        fldShobeName = q.fldShobeName,
                        fldBankName = q.fldBankName,
                        fldBankId = q.fldBankId,
                        TarikhSabt = q.TarikhSabt,
                        NameFamily = q.NameFamily,
                        fldvaziat = q.fldvaziat,
                        NameVaziat = q.NameVaziat,
                        fldTarikhVaziat = q.fldTarikhVaziat,
                        fldOrganId = q.fldOrganId,
                        fldStatus = q.fldStatus,
                        fldCodemeli = q.fldCodemeli,
                        fldAshkhasId = q.fldAshkhasId,
                        fldTypeShakhs = q.fldTypeShakhs,
                        fldReceive = q.fldReceive,
                        fldReceiveName = q.fldReceiveName,
                        fldElamAvarezId=q.fldElamAvarezId
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int ShobeId, int Mablagh, int AshkhasId, string TarikhVosolCheck, string TarikhDaryaftCheck, string ShenaseKamelCheck, string Babat, bool NoeeCheck, int OrganId, int UserId, string Desc)
        {
            using (ChekEntities p = new ChekEntities())
            {
                p.spr_tblCheckHayeVaredeInsert(ShobeId, Mablagh, AshkhasId, TarikhVosolCheck, TarikhDaryaftCheck, ShenaseKamelCheck, Babat, NoeeCheck, UserId, Desc, OrganId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int ShobeId, int Mablagh, int AshkhasId, string TarikhVosolCheck, string TarikhDaryaftCheck, string ShenaseKamelCheck, string Babat, bool NoeeCheck, int OrganId, int UserId, string Desc)
        {
            using (ChekEntities p = new ChekEntities())
            {
                p.spr_tblCheckHayeVaredeUpdate(Id, ShobeId, Mablagh, AshkhasId, TarikhVosolCheck, TarikhDaryaftCheck, ShenaseKamelCheck, Babat, NoeeCheck, UserId, Desc, OrganId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (ChekEntities p = new ChekEntities())
            {
                p.spr_tblCheckHayeVaredeDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (ChekEntities p = new ChekEntities())
            {
                var Aghsat = p.spr_tblAghsatCheckAmaniSelect("fldChekHayeVaredeId_CheckDelete", Id.ToString(), 0, 0).FirstOrDefault();
                var Status = p.spr_tblCheckStatusSelect("fldCheckVaredeId", Id.ToString(), 0).FirstOrDefault();
                if (Aghsat != null || Status != null)
                {
                    q = true;
                }
            }
            return q;
        }
        #endregion
    }
}