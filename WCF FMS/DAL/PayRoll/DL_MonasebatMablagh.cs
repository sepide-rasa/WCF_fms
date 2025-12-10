using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_MonasebatMablagh
    {
        #region Detail
        public OBJ_MonasebatMablagh Detail(int id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMonasebatMablaghSelect("fldId", id.ToString(),"","", 1)
                    .Select(q => new OBJ_MonasebatMablagh
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldHeaderId=q.fldHeaderId,
                        fldMablagh=q.fldMablagh,
                        fldMonasebatId=q.fldMonasebatId,
                        fldNameMonasebat=q.fldNameMonasebat,
                        fldNameType=q.fldNameType,
                        fldTypeNesbatName=q.fldTypeNesbatName,
                        fldTypeNesbatId=q.fldTypeNesbatId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_MonasebatMablagh> Select(string FieldName, string FilterValue, string FilterValue2 ,string FilterValue3,int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var test = p.spr_tblMonasebatMablaghSelect(FieldName, FilterValue,FilterValue2,FilterValue3, h)
                    .Select(q => new OBJ_MonasebatMablagh()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldHeaderId = q.fldHeaderId,
                        fldMablagh = q.fldMablagh,
                        fldMonasebatId = q.fldMonasebatId,
                        fldNameMonasebat = q.fldNameMonasebat,
                        fldNameType = q.fldNameType,
                        fldTypeNesbatId=q.fldTypeNesbatId,
                        fldTypeNesbatName=q.fldTypeNesbatName
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int HeaderId,byte MonasebatId,int Mablagh,byte TypeNesbatId, int UserId, string IP)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMonasebatMablaghInsert(HeaderId,MonasebatId,Mablagh,TypeNesbatId, IP, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id,int HeaderId, byte MonasebatId,int Mablagh,byte TypeNesbatId, int UserId, string IP)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMonasebatMablaghUpdate(Id, HeaderId, MonasebatId, Mablagh, TypeNesbatId, IP, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMonasebatMablaghDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int Id,byte MonasebatId, int HeaderId,byte TypeNesbatId)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblMonasebatMablaghSelect("CheckUnique",HeaderId.ToString(), MonasebatId.ToString(),TypeNesbatId.ToString(), 1).Any();
                }
                else
                {
                    var query = p.spr_tblMonasebatMablaghSelect("CheckUnique", HeaderId.ToString(), MonasebatId.ToString(), TypeNesbatId.ToString(), 1).FirstOrDefault();
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