using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_SavabegheSanavateKHedmat
    {
        #region Detail
        public OBJ_SavabegheSanavateKHedmat Detail(int id, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblSavabegheSanavateKHedmatSelect("fldId", id.ToString(), "", "", OrganId, 1)
                    .Select(q => new OBJ_SavabegheSanavateKHedmat
                    {
                        fldId = q.fldId,
                        fldNoeSabeghe=q.fldNoeSabeghe,
                        fldNoeSabegheName=q.fldNoeSabegheName,
                        fldPersonalId=q.fldPersonalId,
                        fldAzTarikh=q.fldAzTarikh,
                        fldTaTarikh=q.fldTaTarikh,
                        fldUserId=q.fldUserId,
                        fldDesc=q.fldDesc,
                        fldDate=q.fldDate
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_SavabegheSanavateKHedmat> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var test = p.spr_tblSavabegheSanavateKHedmatSelect(FieldName, FilterValue, "", "", OrganId, h)
                    .Select(q => new OBJ_SavabegheSanavateKHedmat()
                    {
                        fldId = q.fldId,
                        fldNoeSabeghe = q.fldNoeSabeghe,
                        fldNoeSabegheName = q.fldNoeSabegheName,
                        fldPersonalId = q.fldPersonalId,
                        fldAzTarikh = q.fldAzTarikh,
                        fldTaTarikh = q.fldTaTarikh,
                        fldUserId = q.fldUserId,
                        fldDesc = q.fldDesc,
                        fldDate = q.fldDate
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, bool NoeSabeghe, string AzTarikh, string TaTarikh, int userId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblSavabegheSanavateKHedmatInsert(PersonalId, NoeSabeghe, AzTarikh, TaTarikh, userId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, bool NoeSabeghe, string AzTarikh, string TaTarikh, int userId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblSavabegheSanavateKHedmatUpdate(Id, PersonalId, NoeSabeghe, AzTarikh, TaTarikh, userId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int userId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblSavabegheSanavateKHedmatDelete(Id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(int PersonalId, string AzTarikh, string TaTarikh,int Id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                if (Id == 0)
                {
                    //q = p.spr_Prs_tblSavabegheSanavateKHedmatSelect("fldPersonalId", PersonalId.ToString(), 0).Where(l => l.fldNoeSabeghe == NoeSabeghe && l.fldAzTarikh == AzTarikh && l.fldTaTarikh == TaTarikh).Any();
                    q = p.spr_tblSavabegheSanavateKHedmatSelect("CheckPersonal", PersonalId.ToString(), AzTarikh, TaTarikh,0, 0).Any();
                }
                else
                {
                    //var query = p.spr_Prs_tblSavabegheSanavateKHedmatSelect("fldPersonalId", PersonalId.ToString(), 0).Where(l => l.fldNoeSabeghe == NoeSabeghe && l.fldAzTarikh == AzTarikh && l.fldTaTarikh == TaTarikh).FirstOrDefault();
                    var query = p.spr_tblSavabegheSanavateKHedmatSelect("CheckPersonal", PersonalId.ToString(), AzTarikh, TaTarikh,0, 0).FirstOrDefault();
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