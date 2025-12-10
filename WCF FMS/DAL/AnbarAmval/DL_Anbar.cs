using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Model;
using WCF_FMS.TOL.AnbarAmval;

namespace WCF_FMS.DAL.AnbarAmval
{
    public class DL_Anbar
    {
        #region Detail
        public OBJ_Anbar Detail(int id)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                var k = p.spr_tblAnbarSelect("fldId", id.ToString(), 1)
                    .Select(q => new OBJ_Anbar
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldAddress=q.fldAddress,
                        fldName=q.fldName,
                        fldPhone = q.fldPhone,
                    }).FirstOrDefault();
                return k;
            }
        }
        #endregion
        #region Select
        public List<OBJ_Anbar> Select(string FieldName, string FilterValue, int h)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                var test = p.spr_tblAnbarSelect(FieldName, FilterValue, h)
                    .Select(q => new OBJ_Anbar()
                    {
                        fldId = q.fldId,
                        fldDate = q.fldDate,
                        fldDesc = q.fldDesc,
                        fldUserId = q.fldUserId,
                        fldIP = q.fldIP,
                        fldAddress = q.fldAddress,
                        fldName = q.fldName,
                        fldPhone = q.fldPhone,
                    }).ToList();
                return test;
            }
        }
        #endregion
        #region Insert
        public string Insert(string Name,string Address,string Phone,string AnbarTreeId,int UserId,string IP, string Desc)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                p.spr_tblAnbarInsert(Name, Address, Phone, Desc, AnbarTreeId, IP, UserId);
                return "ذخیره با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Update
        public string Update(int Id, string Name, string Address, string Phone,string AnbarTreeId, int UserId, string IP, string Desc)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                p.spr_tblAnbarUpdate(Id, Name, Address, Phone, Desc, AnbarTreeId, IP, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region Delete
        public string Delete(int id, int userId)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                p.spr_tblAnbarDelete(id, userId);
                return "حذف با موفقیت انجام شد.";
            }
        }
        #endregion

        #region UpdatePID_Anbar
        public string UpdatePID_Anbar(int Child, int Parent,int UserId)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                p.spr_UpdatePID_Anbar(Child, Parent, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region UpdatePID_Anbar_Tree
        public string UpdatePID_Anbar_Tree(int Anbar_TreeId, int Parent, int UserId)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                p.spr_UpdatePID_Anbar_Tree(Anbar_TreeId, Parent, UserId);
                return "ویرایش با موفقیت انجام شد.";
            }
        }
        #endregion
        #region CheckRepeatedRow
        public bool CheckRepeatedRow(string Name)
        {
            var q = false;
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                q = p.spr_tblAnbarSelect("fldName", Name, 0).Any();

            }
            return q;
        }
        #endregion
        #region CheckExistsAnbar
        public int CheckExistsAnbar(int Id, string AnbarTreeId)
        {
            using (AnbarAmvalEntities p = new AnbarAmvalEntities())
            {
                var fldCheck = p.spr_CheckExistsAnbar(Id, AnbarTreeId).FirstOrDefault().fldCheck;
                return fldCheck;
            }
        }
        #endregion
        
    }
}