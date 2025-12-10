using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_ParametreOmoomi_Value
    {
        #region Detail
        public OBJ_ParametreOmoomi_Value Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblParametreOmoomi_ValueSelect("fldId", Id.ToString(),"", 1)
                    .Select(q => new OBJ_ParametreOmoomi_Value()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldEndDate = q.fldEndDate,
                        fldFromDate = q.fldFromDate,
                        fldParametreOmoomiId = q.fldParametreOmoomiId,
                        fldValue = q.fldValue,
                        nameParametrFa_En = q.nameParametrFa_En
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ParametreOmoomi_Value> Select(string FieldName, string FilterValue, string FilterValue1, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblParametreOmoomi_ValueSelect(FieldName, FilterValue,FilterValue1, h)
                    .Select(q => new OBJ_ParametreOmoomi_Value()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldEndDate = q.fldEndDate,
                        fldFromDate = q.fldFromDate,
                        fldParametreOmoomiId = q.fldParametreOmoomiId,
                        fldValue = q.fldValue,
                        nameParametrFa_En = q.nameParametrFa_En
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int ParametreOmoomiId, string FromDate, string EndDate, string Value, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblParametreOmoomi_ValueInsert(ParametreOmoomiId, FromDate, EndDate, Value, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int ParametreOmoomiId, string FromDate, string EndDate, string Value, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblParametreOmoomi_ValueUpdate(Id, ParametreOmoomiId, FromDate, EndDate, Value, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblParametreOmoomi_ValueDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int ParametreOmoomiId, string FromDate, string EndDate, int Id)
        {
            bool q = false;
            if (EndDate == null)
                EndDate = "";
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblParametreOmoomi_ValueSelect("CheckDate", FromDate, EndDate, 0).Where(l => l.fldParametreOmoomiId == ParametreOmoomiId).Any();

                }
                else
                {
                    var query = p.spr_tblParametreOmoomi_ValueSelect("CheckDate", FromDate, EndDate, 0).Where(l => l.fldParametreOmoomiId == ParametreOmoomiId).FirstOrDefault();
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