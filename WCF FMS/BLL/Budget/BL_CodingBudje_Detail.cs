using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Budget;
using WCF_FMS.TOL.Budget;

namespace WCF_FMS.BLL.Budget
{
    public class BL_CodingBudje_Detail
    {
        DL_CodingBudje_Detail CodingBudje_Detail = new DL_CodingBudje_Detail();

        #region Detail
        public OBJ_CodingBudje_Detail Detail(int id,  out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return CodingBudje_Detail.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_CodingBudje_Detail> Select(string FieldName, string FilterValue, string FilterValue2,string FilterValue3, int h)
        {
            return CodingBudje_Detail.Select(FieldName, FilterValue, FilterValue2, FilterValue3,  h);
        }
        #endregion
        #region Insert
        public string Insert(int? PID, int HeaderId, string Title, string Code, byte? fldKhedmat_Tarh, byte? fldEtebarTypeId, byte? fldTypeMasrafId, int fldCodeingLevelId, int userId, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
       
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
          
            else if (HeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کدینگ بودجه ضروری است";
            }
            if (Title == "" || Title == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Title.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (Code == "" || Code == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (Code.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر کد وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (fldKhedmat_Tarh == 2)
            {
                if (fldEtebarTypeId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد نوع اعتبار ضروری است";
                }
                else if (fldTypeMasrafId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد نوع مصرف ضروری است";
                }
               
            }
            
            if (error.ErrorType == true)
                return "خطا";

            return CodingBudje_Detail.Insert(PID, HeaderId, Title, Code, fldKhedmat_Tarh, fldEtebarTypeId, fldTypeMasrafId,fldCodeingLevelId, userId,IP);

        }
        #endregion
        #region Update
        public string Update(int Id, int HeaderId, string Title, string Code, byte? fldKhedmat_Tarh, byte? fldEtebarTypeId, byte? fldTypeMasrafId, int fldCodeingLevelId, int userId, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;

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
          
            else if (HeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کدینگ بودجه ضروری است";
            }
            if (Title == "" || Title == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "عنوان ضروری است";
            }
            else if (Title.Length < 2)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
            }
            else if (Title.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (Code == "" || Code == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            else if (Code.Length > 100)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تعداد کاراکتر کد وارده شده بیشتر از حد مجاز می باشد.";
            }
            if (fldKhedmat_Tarh == 2)
            {
                if (fldEtebarTypeId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد نوع اعتبار ضروری است";
                }
                else if (fldTypeMasrafId == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد نوع مصرف ضروری است";
                }
              
            }
            if (error.ErrorType == true)
                return "خطا";

            return CodingBudje_Detail.Update(Id, HeaderId, Title, Code, fldKhedmat_Tarh, fldEtebarTypeId, fldTypeMasrafId, fldCodeingLevelId, userId, IP);

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

            return CodingBudje_Detail.Delete(id, userId);
        }
        #endregion

        #region CopyFromTemplateCodingToCodingBudje
        public string CopyFromTemplateCodingToCodingBudje(int HeaderId, int OrganId, int userId, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
        
            else if (HeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کدینگ بودجه ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CodingBudje_Detail.CopyFromTemplateCodingToCodingBudje(HeaderId, OrganId, userId, IP);

        }
        #endregion
        #region CheckValidCode_CodingDetailBudje
        public List<OBJ_CheckValidCodeBudje> CheckValidCode_CodingDetailBudje(int HeaderId,string Code, string PCode, int fldId)
        {
            return CodingBudje_Detail.CheckValidCode_CodingDetailBudje(HeaderId,Code, PCode, fldId);
        }
        #endregion
        #region GetDefaultCodeBudje_Coding
        public List<OBJ_DefaultCode> GetDefaultCodeBudje_Coding(int HeaderId, string PCode)
        {
            return CodingBudje_Detail.GetDefaultCodeBudje_Coding(HeaderId, PCode);
        }
        #endregion
        #region CopyCodingDetail
        public string CopyCodingDetail(int HeaderId,  int userId, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }

            else if (HeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کدینگ بودجه ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return CodingBudje_Detail.CopyCodingDetail(HeaderId, userId, IP);

        }
        #endregion
    }
}