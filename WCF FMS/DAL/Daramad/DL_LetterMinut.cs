using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_LetterMinut
    {
        #region Detail
        public OBJ_LetterMinut Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblLetterMinutSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_LetterMinut()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldShomareHesabCodeDaramadId = q.fldShomareHesabCodeDaramadId,
                        fldDescMinut = q.fldDescMinut,
                        fldTitle = q.fldTitle,
                        fldSodoorBadAzVarizNaghdi = q.fldSodoorBadAzVarizNaghdi,
                        fldSodoorBadAzTaghsit = q.fldSodoorBadAzTaghsit,
                        fldTanzimkonande = q.fldTanzimkonande
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_LetterMinut> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblLetterMinutSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_LetterMinut()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldShomareHesabCodeDaramadId = q.fldShomareHesabCodeDaramadId,
                        fldDescMinut = q.fldDescMinut,
                        fldTitle = q.fldTitle,
                        fldSodoorBadAzVarizNaghdi = q.fldSodoorBadAzVarizNaghdi,
                        fldSodoorBadAzTaghsit = q.fldSodoorBadAzTaghsit,
                        fldTanzimkonande = q.fldTanzimkonande
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public int Insert(int ShomareHesabCodeDaramadId, string Title, string DescMinut, bool SodoorBadAzVarizNaghdi, bool SodoorBadAzTaghsit, bool Tanzimkonande, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                System.Data.Entity.Core.Objects.ObjectParameter id = new System.Data.Entity.Core.Objects.ObjectParameter("fldId",typeof (int));



                p.spr_tblLetterMinutInsert(id,ShomareHesabCodeDaramadId, Title, DescMinut, UserId, Desc, SodoorBadAzVarizNaghdi, SodoorBadAzTaghsit, Tanzimkonande);
                return Convert.ToInt32(id.Value);
            }
        }
        #endregion
        #region Update
        public string Update(int Id, int ShomareHesabCodeDaramadId, string Title, string DescMinut, bool SodoorBadAzVarizNaghdi, bool SodoorBadAzTaghsit, bool Tanzimkonande, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblLetterMinutUpdate(Id, ShomareHesabCodeDaramadId, Title, DescMinut, UserId, Desc, SodoorBadAzVarizNaghdi, SodoorBadAzTaghsit, Tanzimkonande);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblLetterMinutDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckDelete
        public bool CheckDelete(int id)
        {
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var letters = p.spr_tblLetterSignersSelect("fldLetterMinutId", id.ToString(), 0).FirstOrDefault();
                if (letters != null)
                    q = true;
            }
            return q;
        }
        #endregion
    }
}