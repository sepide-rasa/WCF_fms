using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.AnbarAmval;

namespace WCF_FMS.DAL.AnbarAmval
{
    public class DL_AnbarTree
    {
        #region Detail
        public OBJ_AnbarTree Detail(int id)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                var k = p.spr_tblAnbarTreeSelect("fldId", id.ToString(),"", 1)
                    .Select(q => new OBJ_AnbarTree
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
                        fldAnbar_treeId = q.fldAnbar_treeId
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_AnbarTree> Select(string FieldName, string FilterValue, string FilterValue2, int h)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                var test = p.spr_tblAnbarTreeSelect(FieldName, FilterValue, FilterValue2, h)
                    .Select(q => new OBJ_AnbarTree()
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
                        fldAnbar_treeId = q.fldAnbar_treeId
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
                System.Data.Entity.Core.Objects.ObjectParameter Id = new System.Data.Entity.Core.Objects.ObjectParameter("fldID", typeof(int));
                p.spr_tblAnbarTreeInsert(PID, Name, Desc, IP, UserId, GroupId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Name, int GroupId, int UserId, string IP, string Desc)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                p.spr_tblAnbarTreeUpdate(Id, Name, Desc, IP, UserId,GroupId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                p.spr_tblAnbarTreeDelete(id, userId);
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
                    q = p.spr_tblAnbarTreeSelect("fldName", Name, "", 0).Any();

                }
                else
                {
                    var query = p.spr_tblAnbarTreeSelect("fldName", Name, "", 0).FirstOrDefault();
                    if (query != null && query.fldId != Id)
                    {
                        q = true;
                    }
                }
            }
            return q;
        }
        #endregion

        #region Anbar_TarifNashode
        public List<OBJ_Anbar_TarifNashode> Anbar_TarifNashode(int GorupId)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                var k = p.spr_Anbar_TarifNashode(GorupId)
                    .Select(q => new OBJ_Anbar_TarifNashode()
                    {
                        AnbarId = q.AnbarId,
                        fldName = q.fldName,
                    }).ToList();
                return k;
            }
        }
        #endregion
    }
}