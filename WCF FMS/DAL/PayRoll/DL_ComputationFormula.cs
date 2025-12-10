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
    public class DL_ComputationFormula
    {
        #region Detail
        public OBJ_ComputationFormula Detail(int Id, int OrganId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblComputationFormulaSelect("fldId", Id.ToString(), "", "", OrganId, 1)
                    .Select(q => new OBJ_ComputationFormula()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldFormule = q.fldFormule,
                        fldId = q.fldId,
                        fldLibrary = q.fldLibrary,
                        fldOrganId = q.fldOrganId,
                        fldType = q.fldType,
                        fldUserId = q.fldUserId,
                        fldAzTarikh = q.fldAzTarikh,
                        NameOrgan =q.NameOrgan,
                        fldTypeName = q.fldTypeName
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_ComputationFormula> Select(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, int OrganId, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblComputationFormulaSelect(FieldName, FilterValue, FilterValue2, FilterValue3, OrganId, h)
                    .Select(q => new OBJ_ComputationFormula()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldFormule = q.fldFormule,
                        fldId = q.fldId,
                        fldLibrary = q.fldLibrary,
                        fldOrganId = q.fldOrganId,
                        fldType = q.fldType,
                        fldUserId = q.fldUserId,
                        fldAzTarikh = q.fldAzTarikh,
                        NameOrgan =q.NameOrgan,
                        fldTypeName = q.fldTypeName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(bool? Type, string Formule, int? OrganId, string Library, string AzTarikh, int id, string fieldname, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter fldIdd = new System.Data.Entity.Core.Objects.ObjectParameter("fldId", typeof(int));
                p.spr_tblComputationFormulaInsert(fldIdd, Type, Formule, OrganId, Library, AzTarikh, UserId, Desc, id, fieldname);
                return fldIdd.Value.ToString();
            }
        }
        #endregion
        #region Update
        public string Update(int Id, bool? Type, string Formule, int? OrganId, string Library,string AzTarikh, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                    p.spr_tblComputationFormulaUpdate(Id, Type, Formule, OrganId, Library, AzTarikh, UserId, Desc);
                    return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblComputationFormulaDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            var q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                //var CodeDaramd = p.spr_tblCodhayeDaramdSelect("fldFormulKoliId", Id.ToString(), 0, 0).FirstOrDefault();
                //var CodeDaramd1 = p.spr_tblCodhayeDaramdSelect("fldFormulMohasebatId", Id.ToString(),0, 0).FirstOrDefault();
                //var param = p.spr_tblParametreOmoomiSelect("fldFormulId", Id.ToString(), 0).FirstOrDefault();
                //var paramsabt = p.spr_tblParametreSabetSelect("fldFormulId", Id.ToString(),"", 0).FirstOrDefault();
                //if (CodeDaramd != null || CodeDaramd1 != null || param != null || paramsabt!=null)
                //    q = true;
                //return q;
                return false;
            }
        }
        #endregion
    }
}