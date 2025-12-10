using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Archive;
using WCF_FMS.TOL.Archive;

namespace WCF_FMS.BLL.Archive
{
    public class BL_ParticularProperties
    {
        DL_ParticularProperties ParticularProperties = new DL_ParticularProperties();

        #region Detail
        public OBJ_ParticularProperties Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ParticularProperties.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_ParticularProperties> Select(string FieldName, string FilterValue, int h)
        {
            return ParticularProperties.Select(FieldName, FilterValue, h);
        }
        #endregion
        #region Insert
        public string Insert(int ArchiveTreeId, int PropertiesId, int userId, string Desc, out ClsError error)
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
            else if (ArchiveTreeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ساختار درختی ضروری است";
            }
            else if (PropertiesId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد خصوصیات ضروری است";
            }
            else if (ParticularProperties.CheckRepeatedRow(ArchiveTreeId, PropertiesId, 0))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ParticularProperties.Insert(ArchiveTreeId, PropertiesId, userId, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, int ArchiveTreeId, int PropertiesId, int userId, string Desc, out ClsError error)
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
            else if (ArchiveTreeId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ساختار درختی ضروری است";
            }
            else if (PropertiesId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد خصوصیات ضروری است";
            }
            else if (ParticularProperties.CheckRepeatedRow(ArchiveTreeId, PropertiesId, Id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "اطلاعات وارد شده تکراری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ParticularProperties.Update(Id, ArchiveTreeId, PropertiesId, userId, Desc);

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
            else if (ParticularProperties.CheckDelete(id))
            {
                error.ErrorType = true;
                error.ErrorMsg = "آیتم در جای دیگر استفاده شده است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ParticularProperties.Delete(id, userId);
        }
        #endregion
    }
}