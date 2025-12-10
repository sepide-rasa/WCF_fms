using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_Monasebat
    {
        #region Detail
        public OBJ_Monasebat Detail(int id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var test = p.spr_tblMonasebatSelect("fldId",id.ToString(),"",false,1)
                    .Select(q => new OBJ_Monasebat
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldMonasebatTypeId = q.fldMonasebatTypeId,
                        fldNameMonasebat = q.fldNameMonasebat,
                        fldNameType = q.fldNameType,
                        fldDateType = q.fldDateType,
                        fldDateTypeName = q.fldDateTypeName,
                        fldDay = q.fldDay,
                        fldHoliday = q.fldHoliday,
                        fldHolidayName = q.fldHolidayName,
                        fldMazaya = q.fldMazaya,
                        fldMazayaName = q.fldMazayaName,
                        fldMonth = q.fldMonth,
                        fldTarikh = q.fldTarikh
                    }).FirstOrDefault();
                return test;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Monasebat> Select(string FieldName, string FilterValue, string FilterValue2,bool DateType, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var test = p.spr_tblMonasebatSelect(FieldName, FilterValue,FilterValue2,DateType, h)
                    .Select(q => new OBJ_Monasebat
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldMonasebatTypeId = q.fldMonasebatTypeId,
                        fldNameMonasebat = q.fldNameMonasebat,
                        fldNameType = q.fldNameType,
                        fldDateType=q.fldDateType,
                        fldDateTypeName=q.fldDateTypeName,
                        fldDay=q.fldDay,
                        fldHoliday=q.fldHoliday,
                        fldHolidayName=q.fldHolidayName,
                        fldMazaya=q.fldMazaya,
                        fldMazayaName=q.fldMazayaName,
                        fldMonth=q.fldMonth,
                        fldTarikh=q.fldTarikh
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region SelectMonasebatType
        public List<OBJ_MonasebatType> SelectMonasebatType(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var test = p.spr_tblMonasebatTypeSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_MonasebatType
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldDesc=q.fldDesc,
                        fldName=q.fldName
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Name,byte MonasebatType,byte Month,byte Day,bool DateType,bool Holiday,bool Mazaya, int UserId, string IP)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.prs_tblMonasebatInsert(Name,MonasebatType,Month,Day,DateType,Holiday,Mazaya, IP, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(byte Id, string Name, byte MonasebatType, byte Month, byte Day, bool DateType, bool Holiday, bool Mazaya, int UserId, string IP)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.prs_tblMonasebatUpdate(Id, Name, MonasebatType, Month, Day, DateType, Holiday, Mazaya, IP, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(byte id, int userId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.prs_tblMonasebatDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(byte Id,byte Month, byte Day,bool DateType)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblMonasebatSelect("CheckMonasebat", Month.ToString(),Day.ToString(),DateType, 0).Any();
                }
                else
                {
                    var query = p.spr_tblMonasebatSelect("CheckMonasebat", Month.ToString(),Day.ToString(),DateType, 0).FirstOrDefault();
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