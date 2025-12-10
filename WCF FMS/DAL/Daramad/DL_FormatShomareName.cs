using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Daramad;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Daramad
{
    public class DL_FormatShomareName
    {
        #region Detail
        public OBJ_FormatShomareName Detail(int Id)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblFormatShomareNameSelect("fldId", Id.ToString(), 1)
                    .Select(q => new OBJ_FormatShomareName()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldFormatShomareName = q.fldFormatShomareName,
                        fldShomareShoro = q.fldShomareShoro,
                        fldYear = q.fldYear,
                        fldType = q.fldType,
                        typeName = q.typeName,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_FormatShomareName> Select(string FieldName, string FilterValue, int h)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                var k = p.spr_tblFormatShomareNameSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_FormatShomareName()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserId = q.fldUserId,
                        fldType = q.fldType,
                        typeName = q.typeName,
                        fldFormatShomareName = q.fldFormatShomareName,
                        fldShomareShoro = q.fldShomareShoro,
                        fldYear = q.fldYear,
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(short Year, string FormatShomareName, int ShomareShoro,bool Type, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblFormatShomareNameInsert(Year, FormatShomareName, ShomareShoro, UserId, Type, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, short Year, string FormatShomareName, int ShomareShoro, bool Type, int UserId, string Desc)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblFormatShomareNameUpdate(Id, Year, FormatShomareName, ShomareShoro, UserId, Type, Desc);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int Id, int UserId)
        {
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                p.spr_tblFormatShomareNameDelete(Id, UserId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(short Year, bool Type, int Id)
        {
            bool q = false;
            using (RasaNewFMSEntities p = new RasaNewFMSEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblFormatShomareNameSelect("fldYear", Year.ToString(), 0).Where(l => l.fldType == Type).Any();

                }
                else
                {
                    var query = p.spr_tblFormatShomareNameSelect("fldYear", Year.ToString(), 0).Where(l => l.fldType == Type).FirstOrDefault();
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