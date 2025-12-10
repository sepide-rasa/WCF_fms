using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_SavabeghJebhe_Personal
    {
        #region Detail
        public OBJ_SavabeghJebhe_Personal Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblSavabeghJebhe_PersonalSelect("fldId", Id.ToString(),"", 1)
                    .Select(q => new OBJ_SavabeghJebhe_Personal()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAzTarikh=q.fldAzTarikh,
                        fldDarsad_Sal=q.fldDarsad_Sal,
                        fldItemId=q.fldItemId,
                        fldPrsPersonalId=q.fldPrsPersonalId,
                        fldTaTarikh=q.fldTaTarikh,
                        fldTitle = q.fldTitle,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_SavabeghJebhe_Personal> Select(string FieldName, string FilterValue,string FilterValue1, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblSavabeghJebhe_PersonalSelect(FieldName, FilterValue, FilterValue1, h)
                    .Select(q => new OBJ_SavabeghJebhe_Personal()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldAzTarikh = q.fldAzTarikh,
                        fldDarsad_Sal = q.fldDarsad_Sal,
                        fldItemId = q.fldItemId,
                        fldPrsPersonalId = q.fldPrsPersonalId,
                        fldTaTarikh = q.fldTaTarikh,
                        fldTitle = q.fldTitle,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int ItemId, int PrsPersonalId, string AzTarikh, string TaTarikh, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblSavabeghJebhe_PersonalInsert(ItemId,PrsPersonalId,AzTarikh,TaTarikh,UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id,int ItemId, int PrsPersonalId, string AzTarikh, string TaTarikh, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblSavabeghJebhe_PersonalUpdate(Id, ItemId, PrsPersonalId, AzTarikh, TaTarikh, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblSavabeghJebhe_PersonalDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckBazeZamani
        public bool CheckBazeZamani(int id,int PrsPersonalId,string AzTarikh, string TaTarikh)
        {
            var q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (id == 0)
                {
                    q = p.spr_tblSavabeghJebhe_PersonalSelect("fldAzTarikh_TaTarikh", AzTarikh, TaTarikh, 0).Where(l => l.fldPrsPersonalId == PrsPersonalId).Any();
                }
                else
                {
                    var query = p.spr_tblSavabeghJebhe_PersonalSelect("fldAzTarikh_TaTarikh", AzTarikh, TaTarikh, 0).Where(l => l.fldPrsPersonalId == PrsPersonalId).FirstOrDefault();
                    if (query != null && query.fldId != id)
                        q = true;
                }
                
            }
            return q;
        }
        #endregion
    }
}