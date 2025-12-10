using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_PatternFish_DaramadGroup
    {
        DL_PatternFish_DaramadGroup PatternFish_DaramadGroup = new DL_PatternFish_DaramadGroup();

        #region Detail
        public OBJ_PatternFish_DaramadGroup Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return PatternFish_DaramadGroup.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_PatternFish_DaramadGroup> Select(string FieldName, string FilterValue, int h)
        {
            return PatternFish_DaramadGroup.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int PatternFishId, int DaramadGroupId, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (PatternFishId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد الگو فیش ضروری است";
            }
            else if (DaramadGroupId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد گروه درآمد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PatternFish_DaramadGroup.Insert(PatternFishId, DaramadGroupId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int PatternFishId, int DaramadGroupId, int userId, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;


            if (Desc == null)
                Desc = "";
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (PatternFishId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد الگو فیش ضروری است";
            }
            else if (DaramadGroupId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد گروه درآمد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PatternFish_DaramadGroup.Update(Id, PatternFishId, DaramadGroupId, userId, Desc);

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
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return PatternFish_DaramadGroup.Delete(id, userId);
        }
        #endregion
    }
}