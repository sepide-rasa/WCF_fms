using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_ComboBoxValue
    {
        #region Detail
        public OBJ_ComboBoxValue Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblComboBoxValueSelect("fldId", Id.ToString(),"", 1)
                    .Select(q => new OBJ_ComboBoxValue()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldComboBoxId = q.fldComboBoxId,
                        fldTitle = q.fldTitle,
                        fldValue = q.fldValue,
                        comboboxTitle = q.comboboxTitle
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ComboBoxValue> Select(string FieldName, string FilterValue, string FilterValue1, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblComboBoxValueSelect(FieldName, FilterValue, FilterValue1, h)
                    .Select(q => new OBJ_ComboBoxValue()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldComboBoxId = q.fldComboBoxId,
                        fldTitle = q.fldTitle,
                        fldValue = q.fldValue,
                        comboboxTitle = q.comboboxTitle
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int ComboBoxId, string Title, string Value, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblComboBoxValueInsert(ComboBoxId, Title, Value, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int ComboBoxId, string Title, string Value, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblComboBoxValueUpdate(Id, ComboBoxId, Title, Value, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblComboBoxValueDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int ComboBoxId, string Title, string Value, int Id)
        {
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblComboBoxValueSelect("fldTitle_Value", Title, Value, 0).Where(l => l.fldComboBoxId == ComboBoxId).Any();

                }
                else
                {
                    var query = p.spr_tblComboBoxValueSelect("fldTitle_Value", Title, Value, 0).Where(l => l.fldComboBoxId == ComboBoxId).FirstOrDefault();
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