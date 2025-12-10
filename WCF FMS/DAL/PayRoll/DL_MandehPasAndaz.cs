using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;


namespace WCF_FMS.DAL.PayRoll
{
    public class DL_MandehPasAndaz
    {
        #region Detail
        public OBJ_MandehPasAndaz Detail(int Id,int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMandehPasAndazSelect("fldId", Id.ToString(), OrganId, 1)
                    .Select(q => new OBJ_MandehPasAndaz()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserID = q.fldUserID,
                        fldCodemeli = q.fldCodemeli,
                        FldMablagh = q.FldMablagh,
                        fldName_Father = q.fldName_Father,
                        fldPersonalId = q.fldPersonalId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldTarikhSabt = q.fldTarikhSabt,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_MandehPasAndaz> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblMandehPasAndazSelect(FieldName, FilterValue, OrganId, h)
                    .Select(q => new OBJ_MandehPasAndaz()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserID = q.fldUserID,
                        fldCodemeli = q.fldCodemeli,
                        FldMablagh = q.FldMablagh,
                        fldName_Father = q.fldName_Father,
                        fldPersonalId = q.fldPersonalId,
                        fldSh_Personali = q.fldSh_Personali,
                        fldTarikhSabt = q.fldTarikhSabt,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, int Mablagh, string TarikhSabt, int UserID, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMandehPasAndazInsert(PersonalId,Mablagh, TarikhSabt, UserID, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int PersonalId, int Mablagh, string TarikhSabt, int UserID, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMandehPasAndazUpdate(Id, PersonalId, Mablagh, TarikhSabt, UserID, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblMandehPasAndazDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}