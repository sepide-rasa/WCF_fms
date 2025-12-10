using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;
using WCF_FMS.DAL;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_AnvaGroupTashvighi
    {
        #region Detail
        public OBJ_AnvaGroupTashvighi Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblAnvaGroupTashvighiSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_AnvaGroupTashvighi()
                    {
                        fldId=q.fldId,
                        fldTitle=q.fldTitle,
                        fldUserId=q.fldUserId,
                        fldDesc=q.fldDesc,
                        fldDate=q.fldDate
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_AnvaGroupTashvighi> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblAnvaGroupTashvighiSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_AnvaGroupTashvighi()
                    {
                        fldId = q.fldId,
                        fldTitle = q.fldTitle,
                        fldUserId = q.fldUserId,
                        fldDesc = q.fldDesc,
                        fldDate = q.fldDate
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Title, string Desc, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblAnvaGroupTashvighiInsert(Title, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(byte Id, string Title, string Desc, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblAnvaGroupTashvighiUpdate(Id, Title, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(byte Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblAnvaGroupTashvighiDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string Title, int Id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblAnvaGroupTashvighiSelect("fldTitle", Title, 0).Any();
                }
                else
                {
                    var query = p.spr_tblAnvaGroupTashvighiSelect("fldTitle", Title, 0).FirstOrDefault();
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
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                q = p.spr_tblSavabeghGroupTashvighiSelect("CheckAnvaGroupId", Id.ToString(),0, 1).Any();
                return q;
            }
        }
        #endregion
    }
}