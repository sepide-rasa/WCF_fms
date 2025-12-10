using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.AnbarAmval;

namespace WCF_FMS.DAL.AnbarAmval
{
    public class DL_KalaTree
    {
        #region Detail
        public OBJ_KalaTree Detail(int id)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                var k = p.spr_tblKalaTreeSelect("fldId", id.ToString(),"", 1)
                    .Select(q => new OBJ_KalaTree
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldName = q.fldName,
                        fldNodeType = q.fldNodeType,
                        fldPID = q.fldPID,
                        fldGroupId = q.fldGroupId,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_KalaTree> Select(string FieldName, string FilterValue,string FilterValue2, int h)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                var test = p.spr_tblKalaTreeSelect(FieldName, FilterValue,FilterValue2, h)
                    .Select(q => new OBJ_KalaTree()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldName = q.fldName,
                        fldPID = q.fldPID,
                        fldNodeType = q.fldNodeType,
                        fldGroupId = q.fldGroupId,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(int? PID, string Name,int GroupId, int UserId, string IP, string Desc)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                p.spr_tblKalaTreeInsert(PID, Name, Desc, IP, UserId, GroupId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Name, int GroupId, int UserId, string IP, string Desc)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                p.spr_tblKalaTreeUpdate(Id, Name, Desc, IP, UserId, GroupId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                p.spr_tblKalaTreeDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string Name, int Id)
        {
            bool q = false;
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                if (Id == 0)
                {
                    q = p.spr_tblKalaTreeSelect("root_fldName", Name,"", 0).Any();

                }
                else
                {
                    var query = p.spr_tblKalaTreeSelect("root_fldName", Name,"", 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion
        #region kala_TarifNashode
        public List<OBJ_kala_TarifNashode> kala_TarifNashode(int GorupId)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                var test = p.spr_kala_TarifNashode(GorupId)
                    .Select(q => new OBJ_kala_TarifNashode()
                    {
                        kalaId = q.kalaId,
                        fldName = q.fldName,
                    }).ToList();
                return test;
            }
        }
        #endregion
    }
}