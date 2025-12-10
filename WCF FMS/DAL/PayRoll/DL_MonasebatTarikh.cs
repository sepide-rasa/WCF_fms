using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_MonasebatTarikh
    {
        #region Detail
        public OBJ_MonasebatTarikh Detail(int id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMonasebatTarikhSelect("fldId", id.ToString(),"","","", 1)
                    .Select(q => new OBJ_MonasebatTarikh
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldDay=q.fldDay,
                        fldMonasebatId=q.fldMonasebatId,
                        fldMonth=q.fldMonth,
                        fldNameMonasebat=q.fldNameMonasebat,
                        fldNameType=q.fldNameType,
                        fldYear=q.fldYear,
                        fldMazaya = q.fldMazaya
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_MonasebatTarikh> Select(string FieldName, string FilterValue, string FilterValue1, string FilterValue2, string FilterValue3, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var test = p.spr_tblMonasebatTarikhSelect(FieldName, FilterValue, FilterValue1, FilterValue2, FilterValue3, h)
                    .Select(q => new OBJ_MonasebatTarikh()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldDay = q.fldDay,
                        fldMonasebatId = q.fldMonasebatId,
                        fldMonth = q.fldMonth,
                        fldNameMonasebat = q.fldNameMonasebat,
                        fldNameType = q.fldNameType,
                        fldYear = q.fldYear,
                        fldMazaya=q.fldMazaya
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(short Year, byte Month, byte Day, byte MonasebatId, int UserId, string IP)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMonasebatTarikhInsert(Year, Month, Day, MonasebatId, IP, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, short Year,byte Month,byte Day, byte MonasebatId, int UserId, string IP)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMonasebatTarikhUpdate(Id, Year,Month,Day, MonasebatId,IP, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMonasebatTarikhDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int Id,short Year,byte Month,byte Day, byte MonasebatId)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblMonasebatTarikhSelect("CheckUniqe", Year.ToString(), Month.ToString(), Day.ToString(), MonasebatId.ToString(), 1).Any();
                }
                else
                {
                    var query = p.spr_tblMonasebatTarikhSelect("CheckUniqe", Year.ToString(), Month.ToString(), Day.ToString(), MonasebatId.ToString(), 1).FirstOrDefault();
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