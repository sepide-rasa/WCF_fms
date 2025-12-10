using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_PcPosInfo
    {
        #region Detail
        public OBJ_PcPosInfo Detail(int Id, string value1)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var s = p.spr_tblPcPosInfoSelect("fldId", Id.ToString(),value1, 1)
                    .Select(q => new OBJ_PcPosInfo()
                    {
                        fldOrganId = q.fldOrganId,
                        fldUserId = q.fldUserId,
                        fldDesc = q.fldDesc,
                        fldDate = q.fldDate,
                        fldId = q.fldId,
                        fldOrganName = q.fldOrganName,
                        fldPspId = q.fldPspId,
                        fldPspName = q.fldPspName
                    }).FirstOrDefault();
                return s;
            }
        }
        #endregion
        #region Select
        public List<OBJ_PcPosInfo> select(string FieldName, string Value, string value1 ,int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var l = p.spr_tblPcPosInfoSelect(FieldName, Value,value1, h)
                    .Select(q => new OBJ_PcPosInfo()
                    {
                        fldOrganId = q.fldOrganId,
                        fldUserId = q.fldUserId,
                        fldDesc = q.fldDesc,
                        fldDate = q.fldDate,
                        fldId = q.fldId,
                        fldOrganName = q.fldOrganName,
                        fldPspId = q.fldPspId,
                        fldPspName = q.fldPspName
                    }).ToList();
                return l;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldPspId, int fldOrganId, int fldUserId, string fldDesc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPcPosInfoInsert(fldPspId, fldOrganId, fldUserId, fldDesc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, int fldPspId, int fldOrganId, int fldUserId, string fldDesc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPcPosInfoUpdate(fldId, fldPspId, fldOrganId, fldUserId, fldDesc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int fldID, int fldUserID)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPcPosInfoDelete(fldID, fldUserID);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var PcPosInfo = p.spr_tblPcPosParam_DetailSelect("fldPcPosInfoId", id.ToString(), 0).FirstOrDefault();
                var PcposIP = p.spr_tblPcPosIPSelect("CheckPcPosInfoId", id.ToString(),"", 0).FirstOrDefault();
                if (PcPosInfo != null || PcposIP!=null)
                    q = true;

                return q;

            }
        }
            #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int fldid, int fldPspId, int fldorganid)
            {
                var b = false;
                using (RasaNewFMSEntities p = new RasaNewFMSEntities())
                {
                    if (fldid == 0)
                    {
                        b = p.spr_tblPcPosInfoSelect("CheckPsp_OrganId", fldPspId.ToString(), fldorganid.ToString(), 0).Any();
                    }
                    else
                    {
                        var s = p.spr_tblPcPosInfoSelect("CheckPsp_OrganId", fldPspId.ToString(), fldorganid.ToString(), 0).FirstOrDefault();
                        if (s != null && s.fldId != fldid)
                            b = true;
                    }
                } return b;
            }
            #endregion

        
    }
}