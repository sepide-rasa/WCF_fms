using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_GHarardadBime
    {
        #region Detail
        public OBJ_GHarardadBime Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblGHarardadBimeSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_GHarardadBime()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldDarsadBime60Sal = q.fldDarsadBime60Sal,
                        fldDarsadBime70Sal = q.fldDarsadBime70Sal,
                        fldDarsadBimeOmr = q.fldDarsadBimeOmr,
                        fldDarsadBimeTakmily = q.fldDarsadBimeTakmily,
                        fldMablaghe60Sal = q.fldMablaghe60Sal,
                        fldMablaghe70Sal = q.fldMablaghe70Sal,
                        fldMablagheBimeOmr = q.fldMablagheBimeOmr,
                        fldMablagheBimeSHodeAsli = q.fldMablagheBimeSHodeAsli,
                        fldMaxBimeAsli = q.fldMaxBimeAsli,
                        fldMaxBimeAsliName = q.fldMaxBimeAsliName,
                        fldNameBime = q.fldNameBime,
                        fldTarikhPayan = q.fldTarikhPayan,
                        fldTarikhSHoro = q.fldTarikhSHoro,
                        fldDarsadBimeBedonePoshesh=q.fldDarsadBimeBedonePoshesh,
                        fldMablagheBedonePoshesh=q.fldMablagheBedonePoshesh
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_GHarardadBime> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblGHarardadBimeSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_GHarardadBime()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldDarsadBime60Sal = q.fldDarsadBime60Sal,
                        fldDarsadBime70Sal = q.fldDarsadBime70Sal,
                        fldDarsadBimeOmr = q.fldDarsadBimeOmr,
                        fldDarsadBimeTakmily = q.fldDarsadBimeTakmily,
                        fldMablaghe60Sal = q.fldMablaghe60Sal,
                        fldMablaghe70Sal = q.fldMablaghe70Sal,
                        fldMablagheBimeOmr = q.fldMablagheBimeOmr,
                        fldMablagheBimeSHodeAsli = q.fldMablagheBimeSHodeAsli,
                        fldMaxBimeAsli = q.fldMaxBimeAsli,
                        fldMaxBimeAsliName = q.fldMaxBimeAsliName,
                        fldNameBime = q.fldNameBime,
                        fldTarikhPayan = q.fldTarikhPayan,
                        fldTarikhSHoro = q.fldTarikhSHoro,
                        fldDarsadBimeBedonePoshesh=q.fldDarsadBimeBedonePoshesh,
                        fldMablagheBedonePoshesh=q.fldMablagheBedonePoshesh
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(string fldNameBime, string fldTarikhSHoro, string fldTarikhPayan, int fldMablagheBimeSHodeAsli, int fldMablaghe60Sal, 
           int fldMablaghe70Sal, int fldMablagheBimeOmr,byte fldMaxBimeAsli, int fldDarsadBimeOmr, int fldDarsadBimeTakmily
            , int fldDarsadBime60Sal, int fldDarsadBime70Sal, int fldMablagheBedonePoshesh, int fldDarsadBimeBedonePoshesh, int fldUserId, string fldDesc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblGHarardadBimeInsert(fldNameBime, fldTarikhSHoro, fldTarikhPayan, fldMablagheBimeSHodeAsli, fldMablaghe60Sal, fldMablaghe70Sal
                    , fldMablagheBimeOmr, fldMaxBimeAsli, fldDarsadBimeOmr, fldDarsadBimeTakmily, fldDarsadBime60Sal, fldDarsadBime70Sal, fldUserId, fldDesc, fldMablagheBedonePoshesh, fldDarsadBimeBedonePoshesh);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string fldNameBime, string fldTarikhSHoro, string fldTarikhPayan, int fldMablagheBimeSHodeAsli, int fldMablaghe60Sal,
           int fldMablaghe70Sal, int fldMablagheBimeOmr, byte fldMaxBimeAsli, int fldDarsadBimeOmr, int fldDarsadBimeTakmily
            , int fldDarsadBime60Sal, int fldDarsadBime70Sal,int fldMablagheBedonePoshesh,int fldDarsadBimeBedonePoshesh, int fldUserId, string fldDesc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblGHarardadBimeUpdate(Id, fldNameBime, fldTarikhSHoro, fldTarikhPayan, fldMablagheBimeSHodeAsli, fldMablaghe60Sal,fldMablaghe70Sal
                    , fldMablagheBimeOmr, fldMaxBimeAsli, fldDarsadBimeOmr, fldDarsadBimeTakmily, fldDarsadBime60Sal, fldDarsadBime70Sal, fldUserId, fldDesc, fldMablagheBedonePoshesh, fldDarsadBimeBedonePoshesh);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblGHarardadBimeDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            bool q = false;
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                q = p.spr_tblAfradeTahtePoshesheBimeTakmilySelect("CheckGHarardadBimeId", id.ToString(), 0,0,0,0,0, 0).Any();
                return q;
            }
        }
        #endregion
    }
}