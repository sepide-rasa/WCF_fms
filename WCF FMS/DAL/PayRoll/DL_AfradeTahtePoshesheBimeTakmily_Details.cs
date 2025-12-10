using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.PayRoll;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_AfradeTahtePoshesheBimeTakmily_Details
    {
        #region Detail
        public OBJ_AfradeTahtePoshesheBimeTakmily_Details Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblAfradeTahtePoshesheBimeTakmily_DetailsSelect("fldId", Id.ToString(),"0",  1)
                    .Select(q => new OBJ_AfradeTahtePoshesheBimeTakmily_Details()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldAfradTahtePoshehsId = q.fldAfradTahtePoshehsId,
                        fldId = q.fldId,
                        fldPersonalId = q.fldPersonalId,
                        fldAge = q.fldAge,
                        fldBimeTakmiliId = q.fldBimeTakmiliId,
                        fldBirthDate = q.fldBirthDate,
                        fldUserId = q.fldUserId,
                        fldCodeMeli = q.fldCodeMeli,
                        fldFamily = q.fldFamily,
                        fldName = q.fldName,
                        fldNameNesbatShakhs = q.fldNameNesbatShakhs,
                        fldBedonePoshesh=q.fldBedonePoshesh,
                        fldBedonePosheshName=q.fldBedonePosheshName
                    
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_AfradeTahtePoshesheBimeTakmily_Details> Select(string FieldName, string FilterValue, string FilterValue2, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
              
                var k = p.spr_tblAfradeTahtePoshesheBimeTakmily_DetailsSelect(FieldName, FilterValue, FilterValue2, h)
                    .Select(q => new OBJ_AfradeTahtePoshesheBimeTakmily_Details()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldAfradTahtePoshehsId = q.fldAfradTahtePoshehsId,
                        fldId = q.fldId,
                        fldPersonalId = q.fldPersonalId,
                        fldAge = q.fldAge,
                        fldBimeTakmiliId = q.fldBimeTakmiliId,
                        fldBirthDate = q.fldBirthDate,
                        fldUserId = q.fldUserId,
                        fldCodeMeli = q.fldCodeMeli,
                        fldFamily = q.fldFamily,
                        fldName = q.fldName,
                        fldNameNesbatShakhs = q.fldNameNesbatShakhs,
                        fldBedonePoshesh = q.fldBedonePoshesh,
                        fldBedonePosheshName = q.fldBedonePosheshName
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int AfradTahtePoshehsId,  int BimeTakmiliId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblAfradeTahtePoshesheBimeTakmily_DetailsInsert(AfradTahtePoshehsId, BimeTakmiliId,UserId,Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int AfradTahtePoshehsId, int BimeTakmiliId, int UserId, string Desc)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblAfradeTahtePoshesheBimeTakmily_DetailsUpdate(Id, AfradTahtePoshehsId, BimeTakmiliId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblAfradeTahtePoshesheBimeTakmily_DetailsDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
       

      
    }
}