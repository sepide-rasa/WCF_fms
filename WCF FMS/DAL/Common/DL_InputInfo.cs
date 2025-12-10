using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.TOL.Common;
using WCF_FMS.DAL.Model;

namespace WCF_FMS.DAL.Common
{
    public class DL_InputInfo
    {
        #region Select
        public List<OBJ_InputInfo> Select(string FieldName, string FilterValue,bool LoginType, int h)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                var k = p.spr_tblInputInfoSelect(FieldName, FilterValue, LoginType, h)
                    .Select(q => new OBJ_InputInfo()
                    {
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldId = q.fldId,
                        fldUserID = q.fldUserID,
                        fldDateTime = q.fldDateTime,
                        fldIP = q.fldIP,
                        fldLoginType = q.fldLoginType,
                        fldLoginTypeName = q.fldLoginTypeName,
                        fldMACAddress = q.fldMACAddress,
                        fldTime = q.fldTime,
                        Name_Family = q.Name_Family
                    }).ToList();
                return k;
            }
        }
        #endregion
        #region Insert
        public string Insert(System.DateTime fldDateTime, string fldIP, string fldMACAddress, bool fldLoginType, int UserId, string Desc)
        {
            using (RasaFMSCommonDBEntities p = new RasaFMSCommonDBEntities())
            {
                p.spr_tblInputInfoInsert(fldDateTime, fldIP, fldMACAddress, fldLoginType, UserId, Desc);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
    }
}