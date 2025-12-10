using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;


namespace WCF_FMS.DAL.PayRoll
{
    public class DL_SavabeghJebhe_Items
    {
        #region Detail
        public OBJ_SavabeghJebhe_Items Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblSavabeghJebhe_ItemsSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_SavabeghJebhe_Items()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldDarsad_Sal=q.fldDarsad_Sal,
                        fldTitle = q.fldTitle
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_SavabeghJebhe_Items> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblSavabeghJebhe_ItemsSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_SavabeghJebhe_Items()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldDarsad_Sal = q.fldDarsad_Sal,
                        fldTitle = q.fldTitle
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Title, decimal Darsad_Sal, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblSavabeghJebhe_ItemsInsert(Title, Darsad_Sal, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Title, decimal Darsad_Sal, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblSavabeghJebhe_ItemsUpdate(Id, Title, Darsad_Sal, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblSavabeghJebhe_ItemsDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                q = p.spr_tblSavabeghJebhe_PersonalSelect("fldItemId", Id.ToString(), "", 0).Any();
            }
            return q;
        }
        #endregion
    }
}