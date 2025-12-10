using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;
using WCF_FMS.BLL.PayRoll;
using WCF_FMS.BLL;



namespace WCF_FMS.DAL.PayRoll
{
    public class DL_PersonalHokm
    {
        #region Detail
        public OBJ_PersonalHokm Detail(int Id,int OrganId,int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblPersonalHokmSelect("fldId", Id.ToString(),"", OrganId, UserId, 1)
                    .Select(q => new OBJ_PersonalHokm()
                    {
                        fldAnvaeEstekhdamId = q.fldAnvaeEstekhdamId,
                        fldCodeShoghl = q.fldCodeShoghl,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldDescriptionHokm = q.fldDescriptionHokm,
                        fldGroup = q.fldGroup,
                        fldId = q.fldId,
                        fldMoreGroup = q.fldMoreGroup,
                        fldPrs_PersonalInfoId = q.fldPrs_PersonalInfoId,
                        fldShomareHokm = q.fldShomareHokm,
                        fldShomarePostSazmani = q.fldShomarePostSazmani,
                        fldStatusHokm = q.fldStatusHokm,
                        fldTarikhEjra = q.fldTarikhEjra,
                        fldTarikhEtmam = q.fldTarikhEtmam,
                        fldTarikhSodoor = q.fldTarikhSodoor,
                        fldTedadAfradTahteTakafol = q.fldTedadAfradTahteTakafol,
                        fldTedadFarzand = q.fldTedadFarzand,
                        fldTypehokm = q.fldTypehokm,
                        fldUserId = q.fldUserId,
                        fldStatusHokmName = q.fldStatusHokmName,
                        fldStatusTaaholName = q.fldStatusTaaholName,
                        fldNoeEstekhdamName = q.fldNoeEstekhdamName,
                        fldNameEmployee = q.fldNameEmployee,
                        fldCodemeli = q.fldCodemeli,
                        fldEmployeeId = q.fldEmployeeId,
                        fldTarikhEstekhdam = q.fldTarikhEstekhdam,
                        fldName = q.fldName,
                        fldFamily = q.fldFamily,
                        fldFatherName = q.fldFatherName,
                        fldSh_Shenasname = q.fldSh_Shenasname,
                        fldFileId = q.fldFileId,
                        fldStatusTaaholId = q.fldStatusTaaholId,
                        fldMashmooleBime = q.fldMashmooleBime,
                        fldTatbigh1 = q.fldTatbigh1,
                        fldTatbigh2 = q.fldTatbigh2,
                        fldHasZaribeTadil = q.fldHasZaribeTadil,
                        fldZaribeSal1 = q.fldZaribeSal1,
                        fldZaribeSal2 = q.fldZaribeSal2,
                        fldSumItem = q.fldSumItem,
                        fldSh_Personali = q.fldSh_Personali,
                        fldTarikhShoroo = q.fldTarikhShoroo,
                        fldHokmType=q.fldHokmType,
                        fldHokmTypeName=q.fldHokmTypeName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_PersonalHokm> Select(string FieldName, string FilterValue, string FilterValue1, int OrganId, int UserId, int h)
        {
            try {
                using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
                {
                    var k = p.spr_tblPersonalHokmSelect(FieldName, FilterValue, FilterValue1, OrganId, UserId, h)
                        .Select(q => new OBJ_PersonalHokm()
                        {
                            fldAnvaeEstekhdamId = q.fldAnvaeEstekhdamId,
                            fldCodeShoghl = q.fldCodeShoghl,
                            fldDate = q.fldDate,
                            fldDesc = q.fldDesc,
                            fldDescriptionHokm = q.fldDescriptionHokm,
                            fldGroup = q.fldGroup,
                            fldId = q.fldId,
                            fldMoreGroup = q.fldMoreGroup,
                            fldPrs_PersonalInfoId = q.fldPrs_PersonalInfoId,
                            fldShomareHokm = q.fldShomareHokm,
                            fldShomarePostSazmani = q.fldShomarePostSazmani,
                            fldStatusHokm = q.fldStatusHokm,
                            fldTarikhEjra = q.fldTarikhEjra,
                            fldTarikhEtmam = q.fldTarikhEtmam,
                            fldTarikhSodoor = q.fldTarikhSodoor,
                            fldTedadAfradTahteTakafol = q.fldTedadAfradTahteTakafol,
                            fldTedadFarzand = q.fldTedadFarzand,
                            fldTypehokm = q.fldTypehokm,
                            fldUserId = q.fldUserId,
                            fldStatusHokmName = q.fldStatusHokmName,
                            fldStatusTaaholName = q.fldStatusTaaholName,
                            fldNoeEstekhdamName = q.fldNoeEstekhdamName,
                            fldNameEmployee = q.fldNameEmployee,
                            fldCodemeli = q.fldCodemeli,
                            fldEmployeeId = q.fldEmployeeId,
                            fldTarikhEstekhdam = q.fldTarikhEstekhdam,
                            fldName = q.fldName,
                            fldFamily = q.fldFamily,
                            fldFatherName = q.fldFatherName,
                            fldSh_Shenasname = q.fldSh_Shenasname,
                            fldFileId = q.fldFileId,
                            fldStatusTaaholId = q.fldStatusTaaholId,
                            fldMashmooleBime = q.fldMashmooleBime,
                            fldTatbigh1 = q.fldTatbigh1,
                            fldTatbigh2 = q.fldTatbigh2,
                            fldHasZaribeTadil = q.fldHasZaribeTadil,
                            fldZaribeSal1 = q.fldZaribeSal1,
                            fldZaribeSal2 = q.fldZaribeSal2,
                            fldSumItem = q.fldSumItem,
                            fldSh_Personali = q.fldSh_Personali,
                            fldTarikhShoroo = q.fldTarikhShoroo,
                            fldHokmType = q.fldHokmType,
                            fldHokmTypeName = q.fldHokmTypeName
                        }).ToList();
                    return k;
                }
            }
            catch (Exception x)
            {
                var Error = new ClsError();
                Error.ErrorType = false;
                Error.ErrorMsg = "";
                Error.ErrorType = true;
                //Error.ErrorMsg = "خطای پیش بینی نشده";
                string Er = x.Message;
                if (x.InnerException != null)
                    Er += " " + x.InnerException.Message;
                Error.ErrorMsg = new BL().BLErrorMsg("", Er, "1", null);
                return null;
            }
        }
        #endregion
        #region Insert
        public int Insert(int fldPrs_PersonalInfoId, string fldTarikhEjra, string fldTarikhSodoor, string fldTarikhEtmam, int fldAnvaeEstekhdamId
            , byte fldGroup, byte fldMoreGroup, string fldShomarePostSazmani, byte fldTedadFarzand, byte fldTedadAfradTahteTakafol
            , string fldTypehokm, string fldShomareHokm, bool fldStatusHokm, string fldDescriptionHokm, string fldCodeShoghl,int StatusTaaholId,byte[] File
            , string Pasvand, int MashmooleBime, int Tatbigh1, int Tatbigh2, bool HasZaribeTadil, short ZaribeSal1, short ZaribeSal2, string TarikhShoroo, int fldUserId, string fldDesc, byte fldHokmType)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldId", typeof(int));
                p.spr_tblPersonalHokmInsert(Id, fldPrs_PersonalInfoId, fldTarikhEjra, fldTarikhSodoor, fldTarikhEtmam, fldAnvaeEstekhdamId, fldGroup, fldMoreGroup
                    , fldShomarePostSazmani, fldTedadFarzand, fldTedadAfradTahteTakafol, fldTypehokm, fldShomareHokm, fldStatusHokm, fldDescriptionHokm, fldCodeShoghl, StatusTaaholId, File, Pasvand, fldUserId, fldDesc, MashmooleBime, Tatbigh1, Tatbigh2, HasZaribeTadil, ZaribeSal1, ZaribeSal2, TarikhShoroo, fldHokmType);
                return Convert.ToInt32(Id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int fldPrs_PersonalInfoId, string fldTarikhEjra, string fldTarikhSodoor, string fldTarikhEtmam, int fldAnvaeEstekhdamId
            , byte fldGroup, byte fldMoreGroup, string fldShomarePostSazmani, byte fldTedadFarzand, byte fldTedadAfradTahteTakafol
            , string fldTypehokm, string fldShomareHokm, bool fldStatusHokm, string fldDescriptionHokm, string fldCodeShoghl, int StatusTaaholId, int? FileId, byte[] File, string Pasvand
            , int MashmooleBime, int Tatbigh1, int Tatbigh2, bool HasZaribeTadil, short ZaribeSal1, short ZaribeSal2, string TarikhShoroo, int fldUserId, string fldDesc, byte fldHokmType)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblPersonalHokmUpdate(Id, fldPrs_PersonalInfoId, fldTarikhEjra, fldTarikhSodoor, fldTarikhEtmam, fldAnvaeEstekhdamId, fldGroup, fldMoreGroup
                    , fldShomarePostSazmani, fldTedadFarzand, fldTedadAfradTahteTakafol, fldTypehokm, fldShomareHokm, fldStatusHokm, fldDescriptionHokm, fldCodeShoghl, StatusTaaholId, FileId, File, Pasvand, fldUserId, fldDesc, MashmooleBime, Tatbigh1, Tatbigh2, HasZaribeTadil, ZaribeSal1, ZaribeSal2, TarikhShoroo, fldHokmType);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblPersonalHokmDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
       /* #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                q = p.spr_tblHokm_ItemSelect("fldPersonalHokmId", Id.ToString(), 0).Any();
                return q;
            }
        }
        #endregion*/
        #region CheckUpdate
        public bool CheckUpdate(int Id)
        {
            var q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                q = p.spr_tblMohasebat_PersonalInfoSelect("CheckHokmId", Id.ToString(), 0, 0).Any();
                return q;
            }
        }
        #endregion

        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int Prs_PersonalInfoId, string TarikhEjra, string TarikhSodoor, int Id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblPersonalHokmSelect("ChackPersonalId", TarikhSodoor, TarikhEjra, Prs_PersonalInfoId,0, 0).Any();

                }
                else
                {
                    var query = p.spr_tblPersonalHokmSelect("ChackPersonalId", TarikhSodoor, TarikhEjra, Prs_PersonalInfoId,0, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
    }
}