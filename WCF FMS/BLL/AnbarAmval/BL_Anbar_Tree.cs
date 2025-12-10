using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.AnbarAmval;
using WCF_FMS.TOL.AnbarAmval;

namespace WCF_FMS.BLL.AnbarAmval
{
    public class BL_Anbar_Tree
    {
        DL_Anbar_Tree Anbar_Tree = new DL_Anbar_Tree();

        #region Detail
        public OBJ_Anbar_Tree Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return Anbar_Tree.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_Anbar_Tree> Select(string FieldName, string FilterValue, int h)
        {
            return Anbar_Tree.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int AnbarId, int AnbarTreeId, int UserId, string IP, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (AnbarId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد انبار ضروری است";
            }
            else if (AnbarTreeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ساختار درختی ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Anbar_Tree.Insert(AnbarId,AnbarTreeId, UserId, IP, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int AnbarId, int AnbarTreeId, int UserId, string IP, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (AnbarId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد انبار ضروری است";
            }
            else if (AnbarTreeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ساختار درختی ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Anbar_Tree.Update(Id, AnbarId, AnbarTreeId, UserId, IP, Desc);

        }
        #endregion
        #region Delete
        public string Delete(int id, int userId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return Anbar_Tree.Delete(id, userId);
        }
        #endregion
    }
}