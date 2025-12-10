using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_PcPosUser
    {
        #region Detail
        public OBJ_PcPosUser Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblPcPosUserSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_PcPosUser()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIdUser = q.fldIdUser,
                        fldPosIpId = q.fldPosIpId,
                       fldUserName=q.fldUserName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_PcPosUser> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblPcPosUserSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_PcPosUser()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldIdUser = q.fldIdUser,
                        fldPosIpId = q.fldPosIpId,
                        fldUserName = q.fldUserName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PosIpId, int IdUser, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPcPosUserInsert(PosIpId,IdUser, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PosIpId, int IdUser, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPcPosUserUpdate(Id,PosIpId, IdUser, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(string FieldName,int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblPcPosUserDelete(Id, UserId, FieldName);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}