using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Daramad;
using WCF_FMS.TOL.Daramad;

namespace WCF_FMS.BLL.Daramad
{
    public class BL_ElamAvarez
    {
        DL_ElamAvarez ElamAvarez = new DL_ElamAvarez();

        #region Detail
        public OBJ_ElamAvarez Detail(int id, string Value1, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ElamAvarez.Detail(id, Value1);
        }
        #endregion
        #region Select
        public List<OBJ_ElamAvarez> Select(string FieldName, string FilterValue, string Value1, int h)
        {
            return ElamAvarez.Select(FieldName, FilterValue,Value1, h);
        }
        #endregion
        #region Insert
        public int Insert(int AshkhasID, bool Type, int OrganId, bool? IsExternal, int? DaramadGroupId, string CodeSystemMabda, int userId, string Desc, out ClsError error)
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
            else if (AshkhasID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اشخاص ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (DaramadGroupId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد گروه درآمدی ضروری است";
            }
            if (error.ErrorType == true)
                return 0;

            return ElamAvarez.Insert(AshkhasID, Type, OrganId, IsExternal, DaramadGroupId, CodeSystemMabda, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int AshkhasID, bool Type, int OrganId, int? DaramadGroupId, string CodeSystemMabda, int userId, string Desc, out ClsError error)
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
            else if (AshkhasID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اشخاص ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (DaramadGroupId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد گروه درآمدی ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ElamAvarez.Update(Id, AshkhasID, Type, OrganId, DaramadGroupId, CodeSystemMabda, userId, Desc);

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
            else if (ElamAvarez.CheckDelete(id,1))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ElamAvarez.Delete(id, userId);
        }
        #endregion
        #region DeleteWithElamAvarezId
        public string DeleteWithElamAvarezId(int ElamAvarezId,int UserId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (ElamAvarezId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (ElamAvarez.CheckDelete(ElamAvarezId, 2))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ElamAvarez.DeleteWithElamAvarezId(ElamAvarezId, UserId);
        }
        #endregion
        #region CheckLastIdForElamAvarez
        public List<OBJ_ElamAvarez> CheckLastIdForElamAvarez(string FieldName, int ElamAvarezId)
        {
            return ElamAvarez.CheckLastIdForElamAvarez(FieldName, ElamAvarezId);
        }
        #endregion
        #region DeleteKoliElamAvarez
        public string DeleteKoliElamAvarez(int ElamAvarezId, int userId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (ElamAvarezId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد اعلام عوارض ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ElamAvarez.DeleteKoliElamAvarez(ElamAvarezId, userId);
        }
        #endregion
        #region Ashkhas_ElamAvarez
        public List<OBJ_Ashkhas_ElamAvarez> Ashkhas_ElamAvarez(string FieldName, string FilterValue, int h, int AshkhasId)
        {
            return ElamAvarez.Ashkhas_ElamAvarez(FieldName, FilterValue, h, AshkhasId);
        }
        #endregion
    }
}