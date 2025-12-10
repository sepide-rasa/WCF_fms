using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;


namespace WCF_FMS.DAL.Daramad
{
    public class DL_PcPosParam_Dtail
    {
        #region Detail
        public OBJ_PcPosParam_Dtail Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var z = p.spr_tblPcPosParam_DetailSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_PcPosParam_Dtail()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldPcPosInfoId = q.fldPcPosInfoId,
                        fldPcPosParamId = q.fldPcPosParamId,
                        fldUserId = q.fldUserId,
                        fldValue = q.fldValue,
                    }).FirstOrDefault();
                return z;
            }

        }
        #endregion
        #region Select
        public List<OBJ_PcPosParam_Dtail> Select(string fieldname, string value, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var a = p.spr_tblPcPosParam_DetailSelect(fieldname, value, h)
                    .Select(q => new OBJ_PcPosParam_Dtail()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldPcPosInfoId = q.fldPcPosInfoId,
                        fldPcPosParamId = q.fldPcPosParamId,
                        fldUserId = q.fldUserId,
                        fldValue = q.fldValue,
                    }).ToList();
                return a;
            }
        }
        #endregion
        #region Insert
        public string Insert(int fldPcPosParamId,int fldPcPosInfoId,string fldValue,int fldUserId,string fldDesc)
        { 
            using (RasaNewFMSEntities p= new RasaNewFMSEntities())
             {
                p.spr_tblPcPosParam_DetailInsert(fldPcPosParamId, fldPcPosInfoId, fldValue, fldUserId, fldDesc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId,int fldPcPosParamId,int fldPcPosInfoId,string fldValue,int fldUserId,string fldDesc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPcPosParam_DetailUpdate(fldId, fldPcPosParamId, fldPcPosInfoId, fldValue, fldUserId, fldDesc);
                    return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int fldID,int fldUserID)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPcPosParam_DetailDelete(fldID, fldUserID);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        
    }
}