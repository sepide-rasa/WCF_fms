using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_ParametreSabet_Value
    {
        #region Detail
        public OBJ_ParametreSabet_Value Detail(int Id)
        {
            using (RasaNewFMSEntities m = new RasaNewFMSEntities())
            {
                var k = m.spr_tblParametreSabet_ValueSelect("fldId", Id.ToString(),"", 1)
                    .Select(q => new OBJ_ParametreSabet_Value()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldElamAvarezId = q.fldElamAvarezId,
                        fldID = q.fldID,
                        fldParametreSabetId = q.fldParametreSabetId,
                        fldUserId = q.fldUserId,
                        fldValue = q.fldValue,
                        fldIsCombo = q.fldIsCombo,
                        fldIsComboName = q.fldIsComboName,
                        fldCodeDaramadElamAvarezId = q.fldCodeDaramadElamAvarezId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ParametreSabet_Value> Select(string FieldName,string Value,string Value1,int h)
        {
            using (RasaNewFMSEntities m = new RasaNewFMSEntities())
            {
                var k = m.spr_tblParametreSabet_ValueSelect(FieldName,Value,Value1,h)
                    .Select(q => new OBJ_ParametreSabet_Value()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldElamAvarezId = q.fldElamAvarezId,
                        fldID = q.fldID,
                        fldParametreSabetId = q.fldParametreSabetId,
                        fldUserId = q.fldUserId,
                        fldValue = q.fldValue,
                        fldIsCombo = q.fldIsCombo,
                        fldIsComboName = q.fldIsComboName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int ElamAvarezId,string Value,int ParametrSabetId,int? CodeDaramadElamAvarezId,int UserId,string Desc)
        {
            using (RasaNewFMSEntities m = new RasaNewFMSEntities())
            {
                m.spr_tblParametreSabet_ValueInsert(ElamAvarezId, Value, ParametrSabetId, UserId, Desc, CodeDaramadElamAvarezId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int ElamAvarezId, string Value, int ParametrSabetId, int? CodeDaramadElamAvarezId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities m = new RasaNewFMSEntities())
            {
                m.spr_tblParametreSabet_ValueUpdate(Id, ElamAvarezId, Value, ParametrSabetId, UserId, Desc, CodeDaramadElamAvarezId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int ElamAvarezId, int ShomareHesabCodeDaramadId, int UserId)
        {
            using (RasaNewFMSEntities q = new RasaNewFMSEntities())
            {
                q.spr_tblParametreSabet_ValueDelete(ElamAvarezId, ShomareHesabCodeDaramadId, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int? CodeDaramadElamAvarezId, int ParametrSabetId, int Id)
        {
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblParametreSabet_ValueSelect("checkCodeDaramadElamAvarezId_ParametreSabetId", ParametrSabetId.ToString(), CodeDaramadElamAvarezId.ToString(), 0).Any();

                }
                else
                {
                    var query = p.spr_tblParametreSabet_ValueSelect("checkCodeDaramadElamAvarezId_ParametreSabetId", ParametrSabetId.ToString(), CodeDaramadElamAvarezId.ToString(), 0).FirstOrDefault();
                    if (query != null && query.fldID != Id)
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