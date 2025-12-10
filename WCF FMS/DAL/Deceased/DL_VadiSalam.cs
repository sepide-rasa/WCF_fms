using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Deceased;

namespace WCF_FMS.DAL.Deceased
{
    public class DL_VadiSalam
    {
        #region Detail
        public OBJ_VadiSalam Detail(int id,int OrganId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var k = p.spr_tblVadiSalamSelect("fldId", id.ToString(),OrganId, 1)
                    .Select(q => new OBJ_VadiSalam
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserID = q.fldUserID,
                        fldName = q.fldName,
                        fldIP = q.fldIP,
                        fldStateId = q.fldStateId,
                        fldCityId = q.fldCityId,
                        fldAddress = q.fldAddress,
                        fldLatitude = q.fldLatitude,
                        fldLongitude = q.fldLongitude,
                        fldNameState = q.fldNameState,
                        fldNameCity = q.fldNameCity,
                        fldOrganId = q.fldOrganId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_VadiSalam> Select(string FieldName, string FilterValue,int OrganId, int h)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var test = p.spr_tblVadiSalamSelect(FieldName, FilterValue,OrganId, h)
                    .Select(q => new OBJ_VadiSalam()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserID = q.fldUserID,
                        fldName = q.fldName,
                        fldIP = q.fldIP,
                        fldStateId = q.fldStateId,
                        fldCityId = q.fldCityId,
                        fldAddress = q.fldAddress,
                        fldLatitude = q.fldLatitude,
                        fldLongitude = q.fldLongitude,
                        fldNameState = q.fldNameState,
                        fldNameCity = q.fldNameCity,
                        fldOrganId = q.fldOrganId
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldName, int fldStateId, int fldCityId, string fldAddress, string fldLatitude, string fldLongitude, int fldUserID, string fldDesc, string fldIP,int fldOrganId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblVadiSalamInsert(fldName, fldStateId, fldCityId,fldOrganId, fldAddress, fldLatitude, fldLongitude, fldUserID, fldDesc, fldIP);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int fldId, string fldName, int fldStateId, int fldCityId, string fldAddress, string fldLatitude, string fldLongitude, int fldUserID, string fldDesc, string fldIP,int OrganId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblVadiSalamUpdate(fldId, fldName, fldStateId, fldCityId,OrganId, fldAddress, fldLatitude, fldLongitude, fldUserID, fldDesc, fldIP);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (DeceasedEntities p = new DeceasedEntities())
            {
                p.spr_tblVadiSalamDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string fldName, int fldCityId, int Id)
        {
            bool q = false;
            using (DeceasedEntities p = new DeceasedEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblVadiSalamSelect("CheckName", fldName, 0, 0).Where(l => l.fldCityId == fldCityId).Any();

                }
                else
                {
                    var query = p.spr_tblVadiSalamSelect("CheckName", fldName, 0, 0).Where(l => l.fldCityId == fldCityId).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            bool q = false;
            using (DeceasedEntities p = new DeceasedEntities())
            {
                var m = p.spr_tblGheteSelect("CheckVadiSalamId", id.ToString(),0, 0, 1).FirstOrDefault();
                if (m != null)
                    q = true;
            }
            

            return q;
        }
        #endregion
    }
}