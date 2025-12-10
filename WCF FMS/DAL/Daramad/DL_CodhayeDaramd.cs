using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.BLL;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_CodhayeDaramd
    {
        #region Detail
        public OBJ_CodhayeDaramd Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblCodhayeDaramdSelect("fldId", Id.ToString(),0,0, 1)
                    .Select(q => new OBJ_CodhayeDaramd()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldDaramadCode=q.fldDaramadCode,
                        fldDaramadTitle = q.fldDaramadTitle,
                        fldLevel=q.fldLevel,
                        fldMashmooleArzesheAfzoode=q.fldMashmooleArzesheAfzoode,
                        fldMashmooleKarmozd = q.fldMashmooleKarmozd,
                        fldAmuzeshParvaresh = q.fldAmuzeshParvaresh,
                        fldStrhid = q.fldStrhid,
                        fldUnitId = q.fldUnitId,
                        fldNameVahed = q.fldNameVahed,
                        fldFlag=q.fldFlag,
                        lastNod = q.lastNod
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_CodhayeDaramd> Select(string FieldName, string FilterValue,int FiscalYearId,int OrganId, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblCodhayeDaramdSelect(FieldName, FilterValue,OrganId,FiscalYearId, h)
                    .Select(q => new OBJ_CodhayeDaramd()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldDaramadCode = q.fldDaramadCode,
                        fldDaramadTitle = q.fldDaramadTitle,
                        fldLevel = q.fldLevel,
                        fldMashmooleArzesheAfzoode = q.fldMashmooleArzesheAfzoode,
                        fldMashmooleKarmozd = q.fldMashmooleKarmozd,
                        fldAmuzeshParvaresh=q.fldAmuzeshParvaresh,
                        fldStrhid = q.fldStrhid,
                        fldUnitId = q.fldUnitId,
                        fldNameVahed = q.fldNameVahed,
                        fldFlag=q.fldFlag,
                        lastNod=q.lastNod
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int Id,string DaramadCode, string DaramadTitle, bool MashmooleArzesheAfzoode, bool MashmooleKarmozd,bool AmuzeshParvaresh,int? UnitId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblCodhayeDaramdInsert(Id,DaramadCode, DaramadTitle, MashmooleArzesheAfzoode, MashmooleKarmozd,AmuzeshParvaresh,UnitId, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region InsertFromAccounting
        public string InsertFromAccounting(short fldYear, int OrganId, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_InsertHesabdariToDaramad(OrganId,fldYear,UserId);
                return "عملیات با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string DaramadCode, string DaramadTitle, bool MashmooleArzesheAfzoode, bool MashmooleKarmozd,bool AmuzeshParvaresh, int? UnitId, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblCodhayeDaramdUpdate(Id, DaramadCode, DaramadTitle, MashmooleArzesheAfzoode, MashmooleKarmozd,AmuzeshParvaresh, UnitId, UserId, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_DeleteCodeDaramad_ShomareHesab(Id);
                p.spr_tblCodhayeDaramdDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";

            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string DaramadCode, string DaramadTitle, int Id)
        {
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                if (Id == 0)
                {
                    var m = p.spr_tblCodhayeDaramdSelect("fldDaramadCode", DaramadCode,0,0, 0).FirstOrDefault();
                    if (m != null)
                    {
                        q = true;
                        return q;
                    }
                    var m1 = p.spr_tblCodhayeDaramdSelect("fldDaramadTitle", DaramadTitle,0,0, 0).FirstOrDefault();
                    if (m1 != null)
                    {
                        q = true;
                        return q;
                    }
                }
                else
                {
                    var query = p.spr_tblCodhayeDaramdSelect("fldDaramadCode", DaramadCode,0,0, 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true; return q;
                    }
                    var query1 = p.spr_tblCodhayeDaramdSelect("fldDaramadTitle", DaramadTitle,0,0, 0).FirstOrDefault();
                    if (query1 != null && query1.fldId != Id)
                    {
                        q = true; return q;
                    }
                }
                return q;
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int Id)
        {
            using (RasaNewFMSEntities m = new RasaNewFMSEntities())
            {
                var q = false;
                var Sh = m.spr_tblShomareHesabCodeDaramadSelect("fldCodeDaramadId", Id.ToString(), "",0, 0).FirstOrDefault();
                if (Sh != null )
                    q = true;
                return q;
            }
        }
        #endregion
        #region UpdateDaramadId
        public string UpdateDaramadId(int childe, int parent,int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_UpdateDaramadId(childe, parent, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region UpdateFileForCodhayeDaramd
        public string UpdateFileForCodhayeDaramd(int ShomareHesabCodeDaramadId, byte[] Image, string Pasvand, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblUpdateFileForCodhayeDaramd(ShomareHesabCodeDaramadId, Image, Pasvand, UserId, Desc);
                return "ذخیره الگو گزارش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region UpdateFormolsazForCodhayeDarmd
        public string UpdateFormolsazForCodhayeDarmd(int ShomareHesabCodeDaramdId, string Formolsaz)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_UpdateFormolsazForCodhayeDarmd(ShomareHesabCodeDaramdId, Formolsaz);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CopyCodeDaramd
        public string CopyCodeDaramd(string FieldName, int MabdaId, int MaghsadId, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_CopyCodeDaramd(FieldName, MabdaId, MaghsadId, UserId);
                return "عملیات با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckCopyCode
        public bool CheckCopyCode(int MaghsadId)
        {
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
               var m= p.spr_CheckCopyCode(MaghsadId).FirstOrDefault();
               if (m.fldCheck == 1)
                   q = true;
            }
            return q;
        }
        #endregion
    }
}