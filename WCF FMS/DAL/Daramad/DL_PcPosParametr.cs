using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_PcPosParametr
    {
        #region Detail
        public OBJ_PcPosParametr Detail(int Id, int OrganId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var e = p.spr_tblPcPosParametrSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_PcPosParametr()
                {
                    fldDate = q.fldDate,
                    fldDesc = q.fldDesc,
                    fldEnName = q.fldEnName,
                    fldFaName = q.fldFaName,
                    fldId = q.fldId,
                    fldUserId = q.fldUserId,
                    fldPspId = q.fldPspId,
                    fldPspName = q.fldPspName
                }).FirstOrDefault();
                return e;
            }
        }

        #endregion
        #region Select
        public List<OBJ_PcPosParametr> Select(string fieldname, string value, int OrganId, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var j = p.spr_tblPcPosParametrSelect(fieldname, value,OrganId, h).Select(q => new OBJ_PcPosParametr()
                {
                    fldDate = q.fldDate,
                    fldDesc = q.fldDesc,
                    fldEnName = q.fldEnName,
                    fldFaName = q.fldFaName,
                    fldId = q.fldId,
                    fldUserId = q.fldUserId,
                    fldPspId = q.fldPspId,
                    fldPspName = q.fldPspName
                }).ToList();
                return j;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldFaName, string fldEnName, int PspId, int fldUserId, string fldDesc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPcPosParametrInsert(fldFaName, fldEnName, PspId, fldUserId, fldDesc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, string fldFaName, string fldEnName, int PspId, int fldUserId, string fldDesc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPcPosParametrUpdate(fldId, fldFaName, fldEnName, PspId, fldUserId, fldDesc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int fldID, int fldUserID)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPcPosParametrDelete(fldID, fldUserID);
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
                var PcPosParam_D = p.spr_tblPcPosParam_DetailSelect("fldPcPosParamId", id.ToString(), 0).FirstOrDefault();
                if (PcPosParam_D != null)
                    q = true;

                

            }

            return q;

        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int fldid, string fldFaName, string fldEnName, int PspId)
        {
            var b = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                if (fldid == 0)
                {
                    var b1 = p.spr_tblPcPosParametrSelect("fldFaName_PspId", fldFaName, PspId, 0).FirstOrDefault();
                    var b2 = p.spr_tblPcPosParametrSelect("fldEnName_PspId", fldEnName, PspId, 0).FirstOrDefault();
                    if (b1!=null||b2!=null)
                    {
                        b = true;
                    }
                }
                else
                {
                    var s = p.spr_tblPcPosParametrSelect("fldFaName_PspId", fldFaName, PspId, 0).FirstOrDefault();
                    var s1 = p.spr_tblPcPosParametrSelect("fldEnName_PspId", fldEnName, PspId, 0).FirstOrDefault();
                    if (s != null && s.fldId != fldid||s1!=null&&s1.fldId!=fldid)
                        b = true;
                }
            }
            return b;
        }
        #endregion
        #region SelectPcPos_Param_Value
        public List<OBJ_PcPosParametr> SelectPcPos_Param_Value(int Value)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.sp_tblPcPos_Param_Value(Value)
                    .Select(q => new OBJ_PcPosParametr()
                    {
                        fldId = q.fldId,
                        fldEnName = q.fldEnName,
                        fldFaName = q.fldFaName,
                        fldValue = q.fldValue,
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}