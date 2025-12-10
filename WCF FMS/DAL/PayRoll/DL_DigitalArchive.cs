using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.PayRoll;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.PayRoll
{
    public class DL_DigitalArchive
    {
      /*  #region Detail
        public OBJ_DigitalArchive Detail(int Id)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblDigitalArchiveSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_DigitalArchive()
                    {
                        fldId = q.fldId,
                        fldPersonalId = q.fldPersonalId,
                        fldTreeId = q.fldTreeId,
                        fldNameFile = q.fldNameFile,
                        fldUserId = q.fldUserId,
                        fldDate = q.fldDate,
                        fldImageFile = System.IO.File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory +
                            @"\Archive\" + q.fldPersonalId + "\\" + q.fldNameFile)
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_DigitalArchive> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var k = p.spr_tblDigitalArchiveSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_DigitalArchive()
                    {
                        fldId = q.fldId,
                        fldPersonalId = q.fldPersonalId,
                        fldTreeId = q.fldTreeId,
                        fldNameFile = q.fldNameFile,
                        fldUserId = q.fldUserId,
                        fldDate = q.fldDate,
                        fldScanUserId = q.fldScanUserId,
                        fldBooked = q.fldBooked,
                        fldisDeleted = q.fldisDeleted,
                        fldScanDate = q.fldScanDate
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(int PersonalId, int TreeId, byte[] ImageFile, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter ImageName = new System.Data.Entity.Core.Objects.ObjectParameter("fldImage", typeof(string));
                if (System.IO.Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Archive\" + PersonalId) == false)
                    System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Archive\" + PersonalId);

                p.spr_tblDigitalArchiveInsert(PersonalId, ImageName, null, UserId, DateTime.Now, false, null,null);
                System.IO.File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory + @"\Archive\" + PersonalId + "\\" + ImageName.Value, ImageFile);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region InsertMain
        public string InsertMain(int ParvandeId, int TreeId, byte[] ImageFile, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter ImageName = new System.Data.Entity.Core.Objects.ObjectParameter("fldImage", typeof(string));
                if (System.IO.Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Archive\" + ParvandeId) == false)
                    System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Archive\" + ParvandeId);

                p.spr_tblDigitalArchiveInsert(ParvandeId, ImageName, TreeId, null, null, true, UserId, DateTime.Now);
                System.IO.File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory + @"\Archive\" + ParvandeId + "\\" + ImageName.Value, ImageFile);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region UpdateForBookMark
        public string UpdateForBookMark(string ImageFile, int TreeId, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var q = p.spr_tblDigitalArchiveUpdate(ImageFile, TreeId, true, UserId, DateTime.Now);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int ParvandeId, string ImageName, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblDigitalArchiveDelete(ImageName, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Rotate
        public string Rotate(int Id, int PersonalId, byte[] ImageFile, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                var q = p.spr_tblDigitalArchiveSelect("fldId", Id.ToString(), 0).FirstOrDefault();
                System.IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Archive\" + PersonalId + "\\" + q.fldNameFile);
                System.IO.File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory + @"\Archive\" + PersonalId + "\\" + q.fldNameFile, ImageFile);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Move
        public string Move(int TreeId, string ImageFile, int UserId)
        {
            using (RasaFMSPayRollDBEntities p = new RasaFMSPayRollDBEntities())
            {
                p.spr_tblDigitalArchiveMove(TreeId, ImageFile);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion*/

       
    }
}