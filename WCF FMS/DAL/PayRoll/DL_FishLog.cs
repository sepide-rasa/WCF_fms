using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
     class DL_FishLog
    {
        #region Detail
         public OBJ_FishLog Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblFishLogSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_FishLog()
                    {
                        fldId = q.fldId,
                        fldCalcType = q.fldCalcType,
                        fldDate = q.fldDate,
                        fldCostCenterId = q.fldCostCenterId,
                        fldFilterType = q.fldFilterType,
                        fldFishType = q.fldFishType,
                        fldIP = q.fldIP,
                        fldMahaleKhedmat = q.fldMahaleKhedmat,
                        fldMonth = q.fldMonth,
                        fldMostamar = q.fldMostamar,
                        fldOrganId = q.fldOrganId,
                        fldNobatPardakht = q.fldNobatPardakht,
                        fldPersonalId = q.fldPersonalId,
                        fldType = q.fldType,
                        fldUserId = q.fldUserId,
                        fldYear = q.fldYear,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
         public List<OBJ_FishLog> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblFishLogSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_FishLog()
                    {
                        fldId = q.fldId,
                        fldCalcType = q.fldCalcType,
                        fldDate = q.fldDate,
                        fldCostCenterId = q.fldCostCenterId,
                        fldFilterType = q.fldFilterType,
                        fldFishType = q.fldFishType,
                        fldIP = q.fldIP,
                        fldMahaleKhedmat = q.fldMahaleKhedmat,
                        fldMonth = q.fldMonth,
                        fldMostamar = q.fldMostamar,
                        fldOrganId = q.fldOrganId,
                        fldNobatPardakht = q.fldNobatPardakht,
                        fldPersonalId = q.fldPersonalId,
                        fldType = q.fldType,
                        fldUserId = q.fldUserId,
                        fldYear = q.fldYear,
                        fldQRCode=q.fldQRCode
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
         public string Insert( byte fldType, int? fldPersonalId, int fldOrganId, short fldYear, byte fldMonth, byte fldNobatPardakht, byte? fldFilterType, byte? fldFishType, int? fldCostCenterId, int? fldMahaleKhedmat, byte fldCalcType, byte? fldMostamar,  string fldIP, int fldUserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter QRCode = new System.Data.Entity.Core.Objects.ObjectParameter("fldQRCode", typeof(string));
                p.spr_tblFishLogInsert(fldType, fldPersonalId, fldOrganId, fldYear, fldMonth, fldNobatPardakht, fldFilterType, fldFishType, fldCostCenterId, fldMahaleKhedmat, fldCalcType, fldMostamar, fldIP, fldUserId, QRCode).ToString();
               return QRCode.Value.ToString();
            }
        }
        #endregion
    }
}