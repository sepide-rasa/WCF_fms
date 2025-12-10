using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_RequestTaghsit_Takhfif
    {
        #region Detail
        public OBJ_RequestTaghsit_Takhfif Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblRequestTaghsit_TakhfifSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_RequestTaghsit_Takhfif()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAddress = q.fldAddress,
                        fldCodePosti = q.fldCodePosti,
                        fldElamAvarezId = q.fldElamAvarezId,
                        fldEmail = q.fldEmail,
                        fldEmployeeId = q.fldEmployeeId,
                        fldMobile = q.fldMobile,
                        fldRequestType = q.fldRequestType,
                        fldRequestTypeName = q.fldRequestTypeName,
                        fldStatusId = q.fldStatusId,
                        fldStatusName = q.fldStatusName,
                        fldName_Family = q.fldName_Family,
                        fldCodemeli = q.fldCodemeli,
                        fldFatherName = q.fldFatherName,
                        fldReplyRequest = q.fldReplyRequest,
                        fldReplyRequestName = q.fldReplyRequestName,
                        fldMablaghMashmoolKarmozd = q.fldMablaghMashmoolKarmozd,
                        fldMablaghKoli = q.fldMablaghKoli,
                        fldCheckTakhfif_Taghsit = q.fldCheckTakhfif_Taghsit,
                        fldMablagh = q.fldMablagh,
                        fldMablaghWithTakhfifKoli = q.fldMablaghWithTakhfifKoli,
                        MablaghAsli = q.MablaghAsli,
                        SumTedad = q.SumTedad,
                        fldMablaghAmuzesh = q.fldMablaghAmuzesh
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_RequestTaghsit_Takhfif> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblRequestTaghsit_TakhfifSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_RequestTaghsit_Takhfif()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAddress = q.fldAddress,
                        fldCodePosti = q.fldCodePosti,
                        fldElamAvarezId = q.fldElamAvarezId,
                        fldEmail = q.fldEmail,
                        fldEmployeeId = q.fldEmployeeId,
                        fldMobile = q.fldMobile,
                        fldRequestType = q.fldRequestType,
                        fldRequestTypeName = q.fldRequestTypeName,
                        fldStatusId = q.fldStatusId,
                        fldStatusName = q.fldStatusName,
                        fldName_Family = q.fldName_Family,
                        fldCodemeli = q.fldCodemeli,
                        fldFatherName = q.fldFatherName,
                        fldReplyRequest = q.fldReplyRequest,
                        fldReplyRequestName = q.fldReplyRequestName,
                        fldMablaghMashmoolKarmozd = q.fldMablaghMashmoolKarmozd,
                        fldMablaghKoli = q.fldMablaghKoli,
                        fldCheckTakhfif_Taghsit = q.fldCheckTakhfif_Taghsit,
                        fldMablagh = q.fldMablagh,
                        fldMablaghWithTakhfifKoli = q.fldMablaghWithTakhfifKoli,
                        MablaghAsli = q.MablaghAsli,
                        SumTedad = q.SumTedad,
                        fldMablaghAmuzesh = q.fldMablaghAmuzesh
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(int ElamAvarezId, byte RequestType, int EmployeeId, string Address, string Email, string CodePosti, string Mobile, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter id = new System.Data.Entity.Core.Objects.ObjectParameter("fldId", typeof(int));
                p.spr_tblRequestTaghsit_TakhfifInsert(id,ElamAvarezId,RequestType,EmployeeId,Address,Email,CodePosti,Mobile,UserId, Desc);
                return Convert.ToInt32(id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int ElamAvarezId, byte RequestType, int EmployeeId, string Address, string Email, string CodePosti, string Mobile, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblRequestTaghsit_TakhfifUpdate(Id, ElamAvarezId, RequestType, EmployeeId, Address, Email, CodePosti, Mobile, UserId, Desc);
                return "ویرایش درخواست با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblRequestTaghsit_TakhfifDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var C = p.spr_tblEbtalSelect("fldRequestTaghsit_TakhfifId", Id.ToString(), 0).FirstOrDefault();
                var s = p.spr_tblStatusTaghsit_TakhfifSelect("fldRequestId", Id.ToString(), 0).FirstOrDefault();
                if (C != null || s != null)
                    q = true;
                return q;
            }
        }
        #endregion
    }
}