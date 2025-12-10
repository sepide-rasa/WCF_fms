using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace WCF_FMS.DAL.Model
{

    public partial class BudgetEntities
    {
        public virtual int spr_tblBudje_khedmatDarsadIdInsert(Nullable<int> fldCodingAcc_detailId, Nullable<int> fldCodingBudje_DetailsId, Nullable<double> fldDarsad, Nullable<int> fldUserId, System.Data.DataTable Pishbini)
        {
            var fldCodingAcc_detailIdParameter = fldCodingAcc_detailId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldCodingAcc_detailId", fldCodingAcc_detailId) :
                new System.Data.SqlClient.SqlParameter("fldCodingAcc_detailId", typeof(int));

            var fldCodingBudje_DetailsIdParameter = fldCodingBudje_DetailsId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldCodingBudje_DetailsId", fldCodingBudje_DetailsId) :
                new System.Data.SqlClient.SqlParameter("fldCodingBudje_DetailsId", DBNull.Value);

            var fldDarsadParameter = fldDarsad.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldDarsad", fldDarsad) :
                new System.Data.SqlClient.SqlParameter("fldDarsad", typeof(double));

            var fldUserIdParameter = fldUserId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldUserId", fldUserId) :
                new System.Data.SqlClient.SqlParameter("fldUserId", typeof(int));

            var PishbiniParameter = Pishbini.Rows.Count > 0 ?
               new System.Data.SqlClient.SqlParameter("Pishbini", Pishbini) :
               new System.Data.SqlClient.SqlParameter("Pishbini", typeof(System.Data.DataTable));
            PishbiniParameter.TypeName = "Bud.Pishbini";
            PishbiniParameter.SqlDbType = System.Data.SqlDbType.Structured;

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand("BUD.spr_tblBudje_khedmatDarsadIdInsert @fldCodingAcc_detailId, @fldCodingBudje_DetailsId, @fldDarsad, @Pishbini, @fldUserId",
                fldCodingAcc_detailIdParameter, fldCodingBudje_DetailsIdParameter, fldDarsadParameter,PishbiniParameter, fldUserIdParameter);
        }
        public virtual int spr_tblPishbiniInsert(Nullable<int> fldCodingAcc_DetailsId, Nullable<int> fldCodingBudje_DetailsId, Nullable<int> fldUserId, System.Data.DataTable Pishbini)
        {
            var fldCodingAcc_DetailsIdParameter = fldCodingAcc_DetailsId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldCodingAcc_DetailsId", fldCodingAcc_DetailsId) :
                new System.Data.SqlClient.SqlParameter("fldCodingAcc_DetailsId", typeof(int));

            var fldCodingBudje_DetailsIdParameter = fldCodingBudje_DetailsId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldCodingBudje_DetailsId", fldCodingBudje_DetailsId) :
                new System.Data.SqlClient.SqlParameter("fldCodingBudje_DetailsId", DBNull.Value);

            var fldUserIdParameter = fldUserId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldUserId", fldUserId) :
                new System.Data.SqlClient.SqlParameter("fldUserId", typeof(int));

            var PishbiniParameter = Pishbini.Rows.Count > 0 ?
               new System.Data.SqlClient.SqlParameter("Pishbini", Pishbini) :
               new System.Data.SqlClient.SqlParameter("Pishbini", typeof(System.Data.DataTable));
            PishbiniParameter.TypeName = "Bud.Pishbini";
            PishbiniParameter.SqlDbType = System.Data.SqlDbType.Structured;

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand("BUD.spr_tblPishbiniInsert @fldCodingAcc_DetailsId, @fldCodingBudje_DetailsId, @Pishbini, @fldUserId",
              fldCodingAcc_DetailsIdParameter, fldCodingBudje_DetailsIdParameter, PishbiniParameter, fldUserIdParameter);
        }
        public virtual int spr_DocumentInsert(ObjectParameter fldDocumentNum, string fldArchiveNum, string fldDescriptionDocu, Nullable<int> fldOrganId,
            string fldTarikhDocument, string fldDesc, string fldIP, Nullable<int> fldUserId, Nullable<byte> fldAccept, Nullable<byte> fldType,
            Nullable<int> fldModuleSaveId, Nullable<int> fldModuleErsalId, Nullable<int> fldShomareFaree, Nullable<int> fldFiscalYearId, Nullable<int> fldTypeSanad,
            Nullable<int> fldPid,Nullable<byte> fldEdit, System.Data.DataTable Detail)
        {
            var fldDocumentNumParameter = new System.Data.SqlClient.SqlParameter();
            fldDocumentNumParameter.SqlDbType = SqlDbType.Int;
            fldDocumentNumParameter.ParameterName = "@fldDocumentNum";
            fldDocumentNumParameter.Direction = ParameterDirection.Output;

            var fldArchiveNumParameter = fldArchiveNum != null ?
                new System.Data.SqlClient.SqlParameter("fldArchiveNum", fldArchiveNum) :
                new System.Data.SqlClient.SqlParameter("fldArchiveNum", DBNull.Value);

            var fldDescriptionDocuParameter = fldDescriptionDocu != null ?
                new System.Data.SqlClient.SqlParameter("fldDescriptionDocu", fldDescriptionDocu) :
                new System.Data.SqlClient.SqlParameter("fldDescriptionDocu", typeof(string));

            var fldOrganIdParameter = fldOrganId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldOrganId", fldOrganId) :
                new System.Data.SqlClient.SqlParameter("fldOrganId", typeof(int));

            var fldTarikhDocumentParameter = fldTarikhDocument != null ?
                new System.Data.SqlClient.SqlParameter("fldTarikhDocument", fldTarikhDocument) :
                new System.Data.SqlClient.SqlParameter("fldTarikhDocument", typeof(string));

            var fldAcceptParameter = fldAccept.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldAccept", fldAccept) :
                new System.Data.SqlClient.SqlParameter("fldAccept", typeof(byte));

            var fldTypeParameter = fldType.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldType", fldType) :
                new System.Data.SqlClient.SqlParameter("fldType", typeof(byte));

            var fldModuleSaveIdParameter = fldModuleSaveId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldModuleSaveId", fldModuleSaveId) :
                new System.Data.SqlClient.SqlParameter("fldModuleSaveId", DBNull.Value);

            var fldModuleErsalIdParameter = fldModuleErsalId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldModuleErsalId", fldModuleErsalId) :
                new System.Data.SqlClient.SqlParameter("fldModuleErsalId", DBNull.Value);

            var fldShomareFareeParameter = fldShomareFaree.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldShomareFaree", fldShomareFaree) :
                new System.Data.SqlClient.SqlParameter("fldShomareFaree", DBNull.Value);

            var fldFiscalYearIdParameter = fldFiscalYearId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldFiscalYearId", fldFiscalYearId) :
                new System.Data.SqlClient.SqlParameter("fldFiscalYearId", typeof(int));

            var fldTypeSanadParameter = fldTypeSanad.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldTypeSanad", fldTypeSanad) :
                new System.Data.SqlClient.SqlParameter("fldTypeSanad", typeof(int));

            var fldDescParameter = fldDesc != null ?
                new System.Data.SqlClient.SqlParameter("fldDesc", fldDesc) :
                new System.Data.SqlClient.SqlParameter("fldDesc", typeof(string));

            var fldIPParameter = fldIP != null ?
                new System.Data.SqlClient.SqlParameter("fldIP", fldIP) :
                new System.Data.SqlClient.SqlParameter("fldIP", typeof(string));

            var fldUserIdParameter = fldUserId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldUserId", fldUserId) :
                new System.Data.SqlClient.SqlParameter("fldUserId", typeof(int));

            var fldPidParameter = fldPid.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldPid", fldPid) :
                new System.Data.SqlClient.SqlParameter("fldPid", DBNull.Value);

            var fldEditParameter = fldEdit.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldEdit", fldEdit) :
                new System.Data.SqlClient.SqlParameter("fldEdit", DBNull.Value);

            var DetailParameter = Detail.Rows.Count > 0 ?
                new System.Data.SqlClient.SqlParameter("Detail", Detail) :
                new System.Data.SqlClient.SqlParameter("Detail", typeof(System.Data.DataTable));
            DetailParameter.TypeName = "Acc.DocumentDetail";
            DetailParameter.SqlDbType = System.Data.SqlDbType.Structured;

            ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand("ACC.spr_DocumentInsert @fldDocumentNum OUT, @fldArchiveNum, @fldDescriptionDocu, @fldOrganId, @fldTarikhDocument, @fldDesc, @fldIP, @fldUserId, @fldAccept, @fldType, @fldModuleSaveId, @fldModuleErsalId,@fldShomareFaree,@fldFiscalYearId,@fldTypeSanad,@fldPid,@fldEdit, @Detail",
              fldDocumentNumParameter, fldArchiveNumParameter, fldDescriptionDocuParameter, fldOrganIdParameter, fldTarikhDocumentParameter, fldDescParameter, fldIPParameter, fldUserIdParameter, fldAcceptParameter, fldTypeParameter, fldModuleSaveIdParameter, fldModuleErsalIdParameter, fldShomareFareeParameter, fldFiscalYearIdParameter, fldTypeSanadParameter, fldPidParameter,fldEditParameter, DetailParameter);
            return Convert.ToInt32(fldDocumentNumParameter.Value);
        }        
    }
    public partial class AccountingEntities
    {
        public virtual int CopyFromTemplateCodingToCoding(Nullable<int> fldHeaderId, Nullable<int> fldTempNameId, string fldIp, Nullable<int> fldUserId, System.Data.DataTable TempCode)
        {
            var fldHeaderIdParameter = fldHeaderId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldHeaderId", fldHeaderId) :
                new System.Data.SqlClient.SqlParameter("fldHeaderId", typeof(int));

            var fldTempNameIdParameter = fldTempNameId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldTempNameId", fldTempNameId) :
                new System.Data.SqlClient.SqlParameter("fldTempNameId", typeof(int));

            var fldIpParameter = fldIp != null ?
                new System.Data.SqlClient.SqlParameter("fldIp", fldIp) :
                new System.Data.SqlClient.SqlParameter("fldIp", typeof(string));

            var fldUserIdParameter = fldUserId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldUserId", fldUserId) :
                new System.Data.SqlClient.SqlParameter("fldUserId", typeof(int));

            var TempCodeParameter = TempCode.Rows.Count > 0 ?
                new System.Data.SqlClient.SqlParameter("TempCode", TempCode) :
                new System.Data.SqlClient.SqlParameter("TempCode", typeof(System.Data.DataTable));
            TempCodeParameter.TypeName = "Acc.TemplateCode";
            TempCodeParameter.SqlDbType = System.Data.SqlDbType.Structured;

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand("Acc.CopyFromTemplateCodingToCoding @fldHeaderId, @fldTempNameId, @TempCode, @fldIp, @fldUserId",
                fldHeaderIdParameter, fldTempNameIdParameter, TempCodeParameter, fldIpParameter, fldUserIdParameter);
        }
        public virtual int spr_tblBankTemplate_HeaderInsert(string fldNamePattern, Nullable<short> fldStartRow,byte[] fldImage, string fldPasvand, string fldDesc, string fldIP, Nullable<int> fldUserId,
            System.Data.DataTable Details)
        {

            var fldNamePatternParameter = fldNamePattern != null ?
               new System.Data.SqlClient.SqlParameter("fldNamePattern", fldNamePattern) :
               new System.Data.SqlClient.SqlParameter("fldNamePattern", typeof(string));

            var fldStartRowParameter = fldStartRow.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldStartRow", fldStartRow) :
                new System.Data.SqlClient.SqlParameter("fldStartRow", typeof(short));

            var fldDescParameter = fldDesc != null ?
                new System.Data.SqlClient.SqlParameter("fldDesc", fldDesc) :
                new System.Data.SqlClient.SqlParameter("fldDesc", typeof(string));

            var fldIPParameter = fldIP != null ?
                new System.Data.SqlClient.SqlParameter("fldIP", fldIP) :
                new System.Data.SqlClient.SqlParameter("fldIP", typeof(string));

            var fldUserIdParameter = fldUserId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldUserId", fldUserId) :
                new System.Data.SqlClient.SqlParameter("fldUserId", typeof(int));

            var fldImageParameter = fldImage != null ?
                new System.Data.SqlClient.SqlParameter("fldImage", fldImage) :
                new System.Data.SqlClient.SqlParameter("fldImage", typeof(byte[]));

            var fldPasvandParameter = fldPasvand != null ?
                new System.Data.SqlClient.SqlParameter("fldPasvand", fldPasvand) :
                new System.Data.SqlClient.SqlParameter("fldPasvand", typeof(string));

            var DetailsParameter = Details.Rows.Count > 0 ?
                new System.Data.SqlClient.SqlParameter("Details", Details) :
                new System.Data.SqlClient.SqlParameter("Detail", typeof(System.Data.DataTable));
            DetailsParameter.TypeName = "Acc.BankTemplate_Details";
            DetailsParameter.SqlDbType = System.Data.SqlDbType.Structured;

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand("ACC.spr_tblBankTemplate_HeaderInsert @fldNamePattern, @fldStartRow, @Details, @fldDesc, @fldIP, @fldUserId, @fldImage, @fldPasvand",
              fldNamePatternParameter, fldStartRowParameter, DetailsParameter, fldDescParameter, fldIPParameter, fldUserIdParameter, fldImageParameter, fldPasvandParameter);
        }
        public virtual int spr_tblBankTemplate_HeaderUpdate(Nullable<int> fldId, string fldNamePattern, Nullable<short> fldStartRow,Nullable<int> fldFileId, byte[] fldImage, string fldPasvand, string fldDesc, string fldIP,
            Nullable<int> fldUserId, System.Data.DataTable Details)
        {
            var fldIdParameter = fldId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldId", fldId) :
                new System.Data.SqlClient.SqlParameter("fldId", typeof(int));

            var fldNamePatternParameter = fldNamePattern != null ?
                new System.Data.SqlClient.SqlParameter("fldNamePattern", fldNamePattern) :
                new System.Data.SqlClient.SqlParameter("fldNamePattern", typeof(string));

            var fldStartRowParameter = fldStartRow.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldStartRow", fldStartRow) :
                new System.Data.SqlClient.SqlParameter("fldStartRow", typeof(short));

            var fldDescParameter = fldDesc != null ?
                new System.Data.SqlClient.SqlParameter("fldDesc", fldDesc) :
                new System.Data.SqlClient.SqlParameter("fldDesc", typeof(string));

            var fldIPParameter = fldIP != null ?
                new System.Data.SqlClient.SqlParameter("fldIP", fldIP) :
                new System.Data.SqlClient.SqlParameter("fldIP", typeof(string));

            var fldUserIdParameter = fldUserId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldUserId", fldUserId) :
                new System.Data.SqlClient.SqlParameter("fldUserId", typeof(int));

            var fldFileIdParameter = fldFileId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldFileId", fldFileId) :
                new System.Data.SqlClient.SqlParameter("fldFileId", DBNull.Value);

            var fldImageParameter = fldImage != null ?
                new System.Data.SqlClient.SqlParameter("fldImage", fldImage) :
                new System.Data.SqlClient.SqlParameter("fldImage", DBNull.Value);
                fldImageParameter.SqlDbType = System.Data.SqlDbType.VarBinary;

            var fldPasvandParameter = fldPasvand != null ?
                new System.Data.SqlClient.SqlParameter("fldPasvand", fldPasvand) :
                new System.Data.SqlClient.SqlParameter("fldPasvand", typeof(string));

            var DetailsParameter = Details.Rows.Count > 0 ?
                new System.Data.SqlClient.SqlParameter("Details", Details) :
                new System.Data.SqlClient.SqlParameter("Detail", typeof(System.Data.DataTable));
            DetailsParameter.TypeName = "Acc.BankTemplate_Details";
            DetailsParameter.SqlDbType = System.Data.SqlDbType.Structured;

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand("ACC.spr_tblBankTemplate_HeaderUpdate @fldId, @fldNamePattern, @fldStartRow, @Details, @fldDesc, @fldIP, @fldUserId, @fldFileId, @fldImage, @fldPasvand",
                fldIdParameter, fldNamePatternParameter, fldStartRowParameter, DetailsParameter, fldDescParameter, fldIPParameter, fldUserIdParameter, fldFileIdParameter, fldImageParameter, fldPasvandParameter);
        }
        public virtual int spr_DocumentInsert(ObjectParameter fldDocumentNum, string fldArchiveNum, string fldDescriptionDocu, Nullable<int> fldOrganId,
            string fldTarikhDocument, string fldDesc, string fldIP, Nullable<int> fldUserId, Nullable<byte> fldAccept, Nullable<byte> fldType,
            Nullable<int> fldModuleSaveId, Nullable<int> fldModuleErsalId, Nullable<int> fldShomareFaree, Nullable<int> fldFiscalYearId, Nullable<int> fldTypeSanad,
            Nullable<int> fldPid, Nullable<byte> fldEdit, System.Data.DataTable Detail)
        {
            var fldDocumentNumParameter = new System.Data.SqlClient.SqlParameter();
            fldDocumentNumParameter.SqlDbType = SqlDbType.Int;
            fldDocumentNumParameter.ParameterName = "@fldDocumentNum";
            fldDocumentNumParameter.Direction = ParameterDirection.Output;

            var fldArchiveNumParameter = fldArchiveNum != null ?
                new System.Data.SqlClient.SqlParameter("fldArchiveNum", fldArchiveNum) :
                new System.Data.SqlClient.SqlParameter("fldArchiveNum", DBNull.Value);

            var fldDescriptionDocuParameter = fldDescriptionDocu != null ?
                new System.Data.SqlClient.SqlParameter("fldDescriptionDocu", fldDescriptionDocu) :
                new System.Data.SqlClient.SqlParameter("fldDescriptionDocu", typeof(string));

            var fldOrganIdParameter = fldOrganId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldOrganId", fldOrganId) :
                new System.Data.SqlClient.SqlParameter("fldOrganId", typeof(int));

            var fldTarikhDocumentParameter = fldTarikhDocument != null ?
                new System.Data.SqlClient.SqlParameter("fldTarikhDocument", fldTarikhDocument) :
                new System.Data.SqlClient.SqlParameter("fldTarikhDocument", typeof(string));

            var fldAcceptParameter = fldAccept.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldAccept", fldAccept) :
                new System.Data.SqlClient.SqlParameter("fldAccept", typeof(byte));

            var fldTypeParameter = fldType.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldType", fldType) :
                new System.Data.SqlClient.SqlParameter("fldType", typeof(byte));

            var fldModuleSaveIdParameter = fldModuleSaveId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldModuleSaveId", fldModuleSaveId) :
                new System.Data.SqlClient.SqlParameter("fldModuleSaveId", DBNull.Value);

            var fldModuleErsalIdParameter = fldModuleErsalId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldModuleErsalId", fldModuleErsalId) :
                new System.Data.SqlClient.SqlParameter("fldModuleErsalId", DBNull.Value);

            var fldShomareFareeParameter = fldShomareFaree.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldShomareFaree", fldShomareFaree) :
                new System.Data.SqlClient.SqlParameter("fldShomareFaree", DBNull.Value);

            var fldFiscalYearIdParameter = fldFiscalYearId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldFiscalYearId", fldFiscalYearId) :
                new System.Data.SqlClient.SqlParameter("fldFiscalYearId", typeof(int));

            var fldTypeSanadParameter = fldTypeSanad.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldTypeSanad", fldTypeSanad) :
                new System.Data.SqlClient.SqlParameter("fldTypeSanad", typeof(int));

            var fldDescParameter = fldDesc != null ?
                new System.Data.SqlClient.SqlParameter("fldDesc", fldDesc) :
                new System.Data.SqlClient.SqlParameter("fldDesc", typeof(string));

            var fldIPParameter = fldIP != null ?
                new System.Data.SqlClient.SqlParameter("fldIP", fldIP) :
                new System.Data.SqlClient.SqlParameter("fldIP", typeof(string));

            var fldUserIdParameter = fldUserId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldUserId", fldUserId) :
                new System.Data.SqlClient.SqlParameter("fldUserId", typeof(int));

            var fldPidParameter = fldPid.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldPid", fldPid) :
                new System.Data.SqlClient.SqlParameter("fldPid", DBNull.Value);

            var fldEditParameter = fldEdit.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldEdit", fldEdit) :
                new System.Data.SqlClient.SqlParameter("fldEdit", DBNull.Value);

            var DetailParameter = Detail.Rows.Count > 0 ?
                new System.Data.SqlClient.SqlParameter("Detail", Detail) :
                new System.Data.SqlClient.SqlParameter("Detail", typeof(System.Data.DataTable));
            DetailParameter.TypeName = "Acc.DocumentDetail";
            DetailParameter.SqlDbType = System.Data.SqlDbType.Structured;

            ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand("ACC.spr_DocumentInsert @fldDocumentNum OUT, @fldArchiveNum, @fldDescriptionDocu, @fldOrganId, @fldTarikhDocument, @fldDesc, @fldIP, @fldUserId, @fldAccept, @fldType, @fldModuleSaveId, @fldModuleErsalId,@fldShomareFaree,@fldFiscalYearId,@fldTypeSanad,@fldPid,@fldEdit, @Detail",
              fldDocumentNumParameter, fldArchiveNumParameter, fldDescriptionDocuParameter, fldOrganIdParameter, fldTarikhDocumentParameter, fldDescParameter, fldIPParameter, fldUserIdParameter, fldAcceptParameter, fldTypeParameter, fldModuleSaveIdParameter, fldModuleErsalIdParameter, fldShomareFareeParameter, fldFiscalYearIdParameter, fldTypeSanadParameter, fldPidParameter,fldEditParameter, DetailParameter);
            return Convert.ToInt32(fldDocumentNumParameter.Value);
        }
        public virtual int spr_DocumentUpdate(Nullable<int> fldHeaderId, Nullable<int> fldDocumentNum, string fldArchiveNum, string fldDescriptionDocu, Nullable<int> fldOrganId, string fldTarikhDocument, string fldDesc, string fldIP, Nullable<int> fldUserId, Nullable<byte> fldAccept, Nullable<byte> fldType, Nullable<int> fldModuleSaveId, Nullable<int> fldModuleErsalId, Nullable<int> fldShomareFaree, Nullable<int> fldTypeSanad, System.Data.DataTable Detail)
        {
            var fldHeaderIdParameter = fldHeaderId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldHeaderId", fldHeaderId) :
                new System.Data.SqlClient.SqlParameter("fldHeaderId", typeof(int));

            var fldDocumentNumParameter = fldDocumentNum.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldDocumentNum", fldDocumentNum) :
                new System.Data.SqlClient.SqlParameter("fldDocumentNum", typeof(int));
            
            var fldArchiveNumParameter = fldArchiveNum != null ?
                new System.Data.SqlClient.SqlParameter("fldArchiveNum", fldArchiveNum) :
                new System.Data.SqlClient.SqlParameter("fldArchiveNum", DBNull.Value);

            var fldDescriptionDocuParameter = fldDescriptionDocu != null ?
                new System.Data.SqlClient.SqlParameter("fldDescriptionDocu", fldDescriptionDocu) :
                new System.Data.SqlClient.SqlParameter("fldDescriptionDocu", typeof(string));

            var fldOrganIdParameter = fldOrganId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldOrganId", fldOrganId) :
                new System.Data.SqlClient.SqlParameter("fldOrganId", typeof(int));

            var fldTarikhDocumentParameter = fldTarikhDocument != null ?
                new System.Data.SqlClient.SqlParameter("fldTarikhDocument", fldTarikhDocument) :
                new System.Data.SqlClient.SqlParameter("fldTarikhDocument", typeof(string));

            var fldDescParameter = fldDesc != null ?
                new System.Data.SqlClient.SqlParameter("fldDesc", fldDesc) :
                new System.Data.SqlClient.SqlParameter("fldDesc", typeof(string));

            var fldIPParameter = fldIP != null ?
                new System.Data.SqlClient.SqlParameter("fldIP", fldIP) :
                new System.Data.SqlClient.SqlParameter("fldIP", typeof(string));

            var fldUserIdParameter = fldUserId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldUserId", fldUserId) :
                new System.Data.SqlClient.SqlParameter("fldUserId", typeof(int));

            var fldAcceptParameter = fldAccept.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldAccept", fldAccept) :
                new System.Data.SqlClient.SqlParameter("fldAccept", typeof(byte));

            var fldTypeParameter = fldType.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldType", fldType) :
                new System.Data.SqlClient.SqlParameter("fldType", typeof(byte));

            var fldModuleSaveIdParameter = fldModuleSaveId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldModuleSaveId", fldModuleSaveId) :
                new System.Data.SqlClient.SqlParameter("fldModuleSaveId", DBNull.Value);

            var fldModuleErsalIdParameter = fldModuleErsalId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldModuleErsalId", fldModuleErsalId) :
                new System.Data.SqlClient.SqlParameter("fldModuleErsalId", DBNull.Value);

            var fldShomareFareeParameter = fldShomareFaree.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldShomareFaree", fldShomareFaree) :
                new System.Data.SqlClient.SqlParameter("fldShomareFaree", DBNull.Value);

            var fldTypeSanadParameter = fldTypeSanad.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldTypeSanad", fldTypeSanad) :
                new System.Data.SqlClient.SqlParameter("fldTypeSanad", typeof(int));

            var DetailParameter = Detail.Rows.Count > 0 ?
                new System.Data.SqlClient.SqlParameter("Detail", Detail) :
                new System.Data.SqlClient.SqlParameter("Detail", typeof(System.Data.DataTable));
            DetailParameter.TypeName = "Acc.DocumentDetailUpdate";
            DetailParameter.SqlDbType = System.Data.SqlDbType.Structured;

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand("ACC.spr_DocumentUpdate @fldHeaderId, @fldDocumentNum, @fldArchiveNum, @fldDescriptionDocu, @fldOrganId, @fldTarikhDocument, @fldDesc, @fldIP, @fldUserId, @fldAccept, @fldType, @fldModuleSaveId, @fldModuleErsalId,@fldShomareFaree,@fldTypeSanad, @Detail"
                , fldHeaderIdParameter, fldDocumentNumParameter, fldArchiveNumParameter, fldDescriptionDocuParameter, fldOrganIdParameter, fldTarikhDocumentParameter, fldDescParameter, fldIPParameter, fldUserIdParameter, fldAcceptParameter, fldTypeParameter, fldModuleSaveIdParameter, fldModuleErsalIdParameter, fldShomareFareeParameter, fldTypeSanadParameter, DetailParameter);
        }
        public virtual int spr_tblDocumentRecorde_File_BookMarkInsert(Nullable<int> fldDocumentHeaderId, Nullable<int> fldOrganId, Nullable<int> fldUserId, string fldDesc, string fldIP, System.Data.DataTable tblRecorde_File, string fldDocumentRecordeId_Del)
        {
            var fldDocumentHeaderIdParameter = fldDocumentHeaderId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldDocumentHeaderId", fldDocumentHeaderId) :
                new System.Data.SqlClient.SqlParameter("fldDocumentHeaderId", typeof(int));

            var fldOrganIdParameter = fldOrganId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldOrganId", fldOrganId) :
                new System.Data.SqlClient.SqlParameter("fldOrganId", typeof(int));

            var fldUserIdParameter = fldUserId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldUserId", fldUserId) :
                new System.Data.SqlClient.SqlParameter("fldUserId", typeof(int));

            var fldDescParameter = fldDesc != null ?
                new System.Data.SqlClient.SqlParameter("fldDesc", fldDesc) :
                new System.Data.SqlClient.SqlParameter("fldDesc", typeof(string));

            var fldIPParameter = fldIP != null ?
                new System.Data.SqlClient.SqlParameter("fldIP", fldIP) :
                new System.Data.SqlClient.SqlParameter("fldIP", typeof(string));

            var DetailParameter = tblRecorde_File.Rows.Count > 0 ?
               new System.Data.SqlClient.SqlParameter("tblRecorde_File", tblRecorde_File) :
               new System.Data.SqlClient.SqlParameter("tblRecorde_File", new System.Data.DataTable { Columns = { "Url", "fldId", "fldImage", "fldPasvand", "fldArchiveTreeId", "fldIsBookMark" } });
            DetailParameter.TypeName = "Acc.tblRecorde_File";
            DetailParameter.SqlDbType = System.Data.SqlDbType.Structured;

            var fldDocumentRecordeId_DelParameter = fldDocumentRecordeId_Del != null ?
                new System.Data.SqlClient.SqlParameter("fldDocumentRecordeId_Del", fldDocumentRecordeId_Del) :
                new System.Data.SqlClient.SqlParameter("fldDocumentRecordeId_Del", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand("ACC.spr_tblDocumentRecorde_File_BookMarkInsert @fldDocumentHeaderId,@fldOrganId,@fldUserId,@fldDesc,@fldIP,@tblRecorde_File,@fldDocumentRecordeId_Del"
                , fldDocumentHeaderIdParameter, fldOrganIdParameter, fldUserIdParameter, fldDescParameter, fldIPParameter, DetailParameter, fldDocumentRecordeId_DelParameter);
        }
    }
    public partial class WeighEntities
    {
        public virtual int spr_tblRemittance_HeaderInsert(Nullable<int> fldAshkhasiId, Nullable<bool> fldStatus,byte[] fldFile, string fldpasvand, string fldStartDate, string fldEndDate, 
            System.Data.DataTable Detail, Nullable<int> fldUserId, Nullable<int> fldOrganId, string fldDescHeader,Nullable<int> fldEmployId, Nullable<int> fldChartOrganEjraeeId, string fldIP, string fldTitle)
        {
            var fldAshkhasiIdParameter = fldAshkhasiId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldAshkhasiId", fldAshkhasiId) :
                new System.Data.SqlClient.SqlParameter("fldAshkhasiId", DBNull.Value);

            var fldStatusParameter = fldStatus.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldStatus", fldStatus) :
                new System.Data.SqlClient.SqlParameter("fldStatus", typeof(bool));

            var fldStartDateParameter = fldStartDate != null ?
                new System.Data.SqlClient.SqlParameter("fldStartDate", fldStartDate) :
                new System.Data.SqlClient.SqlParameter("fldStartDate", typeof(string));

            var fldEndDateParameter = fldEndDate != null ?
                new System.Data.SqlClient.SqlParameter("fldEndDate", fldEndDate) :
                new System.Data.SqlClient.SqlParameter("fldEndDate", typeof(string));

            var fldFileParameter = fldFile != null ?
                new System.Data.SqlClient.SqlParameter("fldFile", fldFile) :
                new System.Data.SqlClient.SqlParameter("fldFile",DBNull.Value);
            fldFileParameter.SqlDbType = SqlDbType.VarBinary;

            var fldpasvandParameter = fldpasvand != null ?
                new System.Data.SqlClient.SqlParameter("fldpasvand", fldpasvand) :
                new System.Data.SqlClient.SqlParameter("fldpasvand", typeof(string));

            var DetailParameter = Detail.Rows.Count > 0 ?
                new System.Data.SqlClient.SqlParameter("Detail", Detail) :
                new System.Data.SqlClient.SqlParameter("Detail", typeof(System.Data.DataTable));
            DetailParameter.TypeName = "Weigh.tblRemittance_Details";
            DetailParameter.SqlDbType = System.Data.SqlDbType.Structured;

            var fldUserIdParameter = fldUserId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldUserId", fldUserId) :
                new System.Data.SqlClient.SqlParameter("fldUserId", typeof(int));

            var fldOrganIdParameter = fldOrganId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldOrganId", fldOrganId) :
                new System.Data.SqlClient.SqlParameter("fldOrganId", typeof(int));

            var fldDescParameter = fldDescHeader != null ?
                new System.Data.SqlClient.SqlParameter("fldDescHeader", fldDescHeader) :
                new System.Data.SqlClient.SqlParameter("fldDescHeader", typeof(string));

            var fldEmployIdParameter = fldEmployId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldEmployId", fldEmployId) :
                new System.Data.SqlClient.SqlParameter("fldEmployId", typeof(int));

            var fldChartOrganEjraeeIdParameter = fldChartOrganEjraeeId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldChartOrganEjraeeId", fldChartOrganEjraeeId) :
                new System.Data.SqlClient.SqlParameter("fldChartOrganEjraeeId", DBNull.Value);

            var fldIPParameter = fldIP != null ?
                new System.Data.SqlClient.SqlParameter("fldIP", fldIP) :
                new System.Data.SqlClient.SqlParameter("fldIP", typeof(string));

            var fldTitleParameter = fldTitle != null ?
                new System.Data.SqlClient.SqlParameter("fldTitle", fldTitle) :
                new System.Data.SqlClient.SqlParameter("fldTitle", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand("Weigh.spr_tblRemittance_HeaderInsert @fldAshkhasiId,@fldStatus,@fldStartDate,@fldEndDate, "+
            "@Detail,@fldFile,@fldpasvand,@fldUserId,@fldOrganId,@fldDescHeader,@fldEmployId,@fldChartOrganEjraeeId,@fldIP,@fldTitle"
                , fldAshkhasiIdParameter, fldStatusParameter, fldStartDateParameter, fldEndDateParameter, DetailParameter, fldFileParameter, fldpasvandParameter,fldUserIdParameter, fldOrganIdParameter,
                fldDescParameter, fldEmployIdParameter, fldChartOrganEjraeeIdParameter,fldIPParameter, fldTitleParameter);
        }
        public virtual int spr_tblRemittance_HeaderUpdate(Nullable<int> fldHeaderId, Nullable<int> fldAshkhasiId, Nullable<bool> fldStatus, string fldStartDate, 
            string fldEndDate,Nullable<int> fldFileId, byte[] fldFile, string fldpasvand, System.Data.DataTable Detail, Nullable<int> fldUserId, Nullable<int> fldOrganId, 
            string fldDescHeader,Nullable<int> fldEmployId, Nullable<int> fldChartOrganEjraeeId, string fldIP, string fldTitle)
        {
            var fldHeaderIdParameter = fldHeaderId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldHeaderId", fldHeaderId) :
                new System.Data.SqlClient.SqlParameter("fldHeaderId", typeof(int));

            var fldAshkhasiIdParameter = fldAshkhasiId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldAshkhasiId", fldAshkhasiId) :
                new System.Data.SqlClient.SqlParameter("fldAshkhasiId", DBNull.Value);

            var fldStatusParameter = fldStatus.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldStatus", fldStatus) :
                new System.Data.SqlClient.SqlParameter("fldStatus", typeof(bool));

            var fldStartDateParameter = fldStartDate != null ?
                new System.Data.SqlClient.SqlParameter("fldStartDate", fldStartDate) :
                new System.Data.SqlClient.SqlParameter("fldStartDate", typeof(string));

            var fldEndDateParameter = fldEndDate != null ?
                new System.Data.SqlClient.SqlParameter("fldEndDate", fldEndDate) :
                new System.Data.SqlClient.SqlParameter("fldEndDate", typeof(string));

            var DetailParameter = Detail.Rows.Count > 0 ?
                new System.Data.SqlClient.SqlParameter("Detail", Detail) :
                new System.Data.SqlClient.SqlParameter("Detail", typeof(System.Data.DataTable));
            DetailParameter.TypeName = "Weigh.tblRemittance_Details";
            DetailParameter.SqlDbType = System.Data.SqlDbType.Structured;

            var fldFileIdParameter = fldFileId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldFileId", fldFileId) :
                new System.Data.SqlClient.SqlParameter("fldFileId", DBNull.Value);            

            var fldFileParameter = fldFile != null ?
                new System.Data.SqlClient.SqlParameter("fldFile", fldFile) :
                new System.Data.SqlClient.SqlParameter("fldFile", DBNull.Value);
            fldFileParameter.SqlDbType = SqlDbType.VarBinary;

            var fldpasvandParameter = fldpasvand != null ?
                new System.Data.SqlClient.SqlParameter("fldpasvand", fldpasvand) :
                new System.Data.SqlClient.SqlParameter("fldpasvand", typeof(string));

            var fldUserIdParameter = fldUserId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldUserId", fldUserId) :
                new System.Data.SqlClient.SqlParameter("fldUserId", typeof(int));

            var fldOrganIdParameter = fldOrganId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldOrganId", fldOrganId) :
                new System.Data.SqlClient.SqlParameter("fldOrganId", typeof(int));

            var fldDescParameter = fldDescHeader != null ?
                new System.Data.SqlClient.SqlParameter("fldDescHeader", fldDescHeader) :
                new System.Data.SqlClient.SqlParameter("fldDescHeader", typeof(string));

            var fldEmployIdParameter = fldEmployId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldEmployId", fldEmployId) :
                new System.Data.SqlClient.SqlParameter("fldEmployId", typeof(int));

            var fldChartOrganEjraeeIdParameter = fldChartOrganEjraeeId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldChartOrganEjraeeId", fldChartOrganEjraeeId) :
                new System.Data.SqlClient.SqlParameter("fldChartOrganEjraeeId", DBNull.Value);

            var fldIPParameter = fldIP != null ?
                new System.Data.SqlClient.SqlParameter("fldIP", fldIP) :
                new System.Data.SqlClient.SqlParameter("fldIP", typeof(string));

            var fldTitleParameter = fldTitle != null ?
                new System.Data.SqlClient.SqlParameter("fldTitle", fldTitle) :
                new System.Data.SqlClient.SqlParameter("fldTitle", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand("Weigh.spr_tblRemittance_HeaderUpdate @fldHeaderId,@fldAshkhasiId,@fldStatus,@fldStartDate, "+
            "@fldEndDate,@Detail,@fldFileId,@fldFile,@fldpasvand,@fldUserId,@fldOrganId,@fldDescHeader,@fldEmployId,@fldChartOrganEjraeeId,@fldIP,@fldTitle"
                , fldHeaderIdParameter, fldAshkhasiIdParameter, fldStatusParameter, fldStartDateParameter, fldEndDateParameter, DetailParameter,fldFileIdParameter,fldFileParameter,fldpasvandParameter, fldUserIdParameter,
                fldOrganIdParameter, fldDescParameter,fldEmployIdParameter,fldChartOrganEjraeeIdParameter, fldIPParameter, fldTitleParameter);
        }
       
    }
    public partial class RasaFMSCommonDBEntities
    {
        public virtual int spr_GeneralSettingInsert(string fldName, string fldValue, Nullable<int> fldUserId, string fldDesc, Nullable<int> fldOrganId, Nullable<int> fldModuleId, System.Data.DataTable ComboBox)
        {
            var fldNameParameter = fldName != null ?
                new System.Data.SqlClient.SqlParameter("fldName", fldName) :
                new System.Data.SqlClient.SqlParameter("fldName", typeof(string));

            var fldValueParameter = fldValue != null ?
                new System.Data.SqlClient.SqlParameter("fldValue", fldValue) :
                new System.Data.SqlClient.SqlParameter("fldValue", typeof(string));

            var fldUserIdParameter = fldUserId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldUserId", fldUserId) :
                new System.Data.SqlClient.SqlParameter("fldUserId", typeof(int));

            var fldDescParameter = fldDesc != null ?
                new System.Data.SqlClient.SqlParameter("fldDesc", fldDesc) :
                new System.Data.SqlClient.SqlParameter("fldDesc", typeof(string));

            var fldOrganIdParameter = fldOrganId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldOrganId", fldOrganId) :
                new System.Data.SqlClient.SqlParameter("fldOrganId", typeof(int));

            var fldModuleIdParameter = fldModuleId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldModuleId", fldModuleId) :
                new System.Data.SqlClient.SqlParameter("fldModuleId", typeof(int));

            var DetailParameter = ComboBox.Rows.Count > 0 ?
                new System.Data.SqlClient.SqlParameter("ComboBox", ComboBox) :
                new System.Data.SqlClient.SqlParameter("ComboBox", new System.Data.DataTable { Columns = { "fldId", "fldTtile", "fldValue" } });
            DetailParameter.TypeName = "com.GeneralSettingComboBox";
            DetailParameter.SqlDbType = System.Data.SqlDbType.Structured;

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand("Com.spr_GeneralSettingInsert @fldName,@fldValue,@fldUserId,@fldDesc,@fldOrganId,@fldModuleId,@ComboBox"
                , fldNameParameter, fldValueParameter, fldUserIdParameter, fldDescParameter, fldOrganIdParameter, fldModuleIdParameter, DetailParameter);
        }

        public virtual int spr_GeneralSettingUpdate(Nullable<int> fldHeaderId, string fldName, string fldValue, Nullable<int> fldUserId, string fldDesc, Nullable<int> fldOrganId, Nullable<int> fldModuleId, System.Data.DataTable ComboBox)
        {
            var fldHeaderIdParameter = fldHeaderId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldHeaderId", fldHeaderId) :
                new System.Data.SqlClient.SqlParameter("fldHeaderId", typeof(int));

            var fldNameParameter = fldName != null ?
                new System.Data.SqlClient.SqlParameter("fldName", fldName) :
                new System.Data.SqlClient.SqlParameter("fldName", typeof(string));

            var fldValueParameter = fldValue != null ?
                new System.Data.SqlClient.SqlParameter("fldValue", fldValue) :
                new System.Data.SqlClient.SqlParameter("fldValue", typeof(string));

            var fldUserIdParameter = fldUserId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldUserId", fldUserId) :
                new System.Data.SqlClient.SqlParameter("fldUserId", typeof(int));

            var fldDescParameter = fldDesc != null ?
                new System.Data.SqlClient.SqlParameter("fldDesc", fldDesc) :
                new System.Data.SqlClient.SqlParameter("fldDesc", typeof(string));

            var fldOrganIdParameter = fldOrganId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldOrganId", fldOrganId) :
                new System.Data.SqlClient.SqlParameter("fldOrganId", typeof(int));

            var fldModuleIdParameter = fldModuleId.HasValue ?
                new System.Data.SqlClient.SqlParameter("fldModuleId", fldModuleId) :
                new System.Data.SqlClient.SqlParameter("fldModuleId", typeof(int));

            var DetailParameter = ComboBox.Rows.Count > 0 ?
               new System.Data.SqlClient.SqlParameter("ComboBox", ComboBox) :
               new System.Data.SqlClient.SqlParameter("ComboBox", new System.Data.DataTable { Columns = { "fldId", "fldTtile", "fldValue" } });
            DetailParameter.TypeName = "com.GeneralSettingComboBox";
            DetailParameter.SqlDbType = System.Data.SqlDbType.Structured;

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteStoreCommand("Com.spr_GeneralSettingUpdate @fldHeaderId,@fldName,@fldValue,@fldUserId,@fldDesc,@fldOrganId,@fldModuleId,@ComboBox"
                 ,fldHeaderIdParameter, fldNameParameter, fldValueParameter, fldUserIdParameter, fldDescParameter, fldOrganIdParameter, fldModuleIdParameter, DetailParameter);
        }
    }


}