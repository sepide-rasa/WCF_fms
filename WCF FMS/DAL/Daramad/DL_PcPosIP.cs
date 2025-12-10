using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_PcPosIP
    {
        #region Detail
        public OBJ_PcPosIP Detail(int Id,string Value1)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
             
                   var k = p.spr_tblPcPosIPSelect("fldId", Id.ToString(), Value1, 1)
                    .Select(q => new OBJ_PcPosIP()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldPcPosInfoId = q.fldPcPosInfoId,
                        fldSerial = q.fldSerial,
                        fldIp = q.fldIp,
                        fldOrganName = q.fldOrganName,
                        fldPspName = q.fldPspName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_PcPosIP> Select(string FieldName, string FilterValue,string Value1, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblPcPosIPSelect(FieldName, FilterValue,Value1, h)
                    .Select(q => new OBJ_PcPosIP()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldPcPosInfoId = q.fldPcPosInfoId,
                        fldSerial = q.fldSerial,
                        fldIp = q.fldIp,
                        fldOrganName = q.fldOrganName,
                        fldPspName = q.fldPspName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(int PcPosInfoId, string Serial,string IP, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            { System.Data.Entity.Core.Objects.ObjectParameter id= new System.Data.Entity.Core.Objects.ObjectParameter("fldId",typeof(int));
                p.spr_tblPcPosIPInsert(id,PcPosInfoId, Serial, UserId, Desc, IP);
                return Convert.ToInt32(id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PcPosInfoId, string Serial, string IP, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPcPosIPUpdate(Id,PcPosInfoId,Serial, UserId, Desc,IP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPcPosIPDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        
    }
}