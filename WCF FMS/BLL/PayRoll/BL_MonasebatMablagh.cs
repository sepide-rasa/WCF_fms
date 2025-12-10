using System.Text.RegularExpressions;
using System.Web;
using System.Collections.Generic;
using WCF_FMS.DAL.PayRoll;
using WCF_FMS.TOL.PayRoll;
namespace WCF_FMS.BLL.PayRoll
{
    public class BL_MonasebatMablagh
    {
        DL_MonasebatMablagh MonasebatMablagh = new DL_MonasebatMablagh();

        #region Detail
        public OBJ_MonasebatMablagh Detail(int id, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return MonasebatMablagh.Detail(id);
        }
        #endregion
        #region Select
        public List<OBJ_MonasebatMablagh> Select(string FieldName, string FilterValue, string FilterValue2, string FilterValue3, int h)
        {
            return MonasebatMablagh.Select(FieldName, FilterValue,FilterValue2,FilterValue3, h);
        }
        #endregion
        #region Insert
        public string Insert(int HeaderId,byte MonasebatId,int Mablagh,byte TypeNesbatId, int UserId, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است.";
            }
            else if (HeaderId==0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد هدر ضروری است.";
            }
            else if (MonasebatId==0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد مناسبت ضروری است.";
            }
            else if (TypeNesbatId==0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع نسبت ضروری است.";
            }
            else if (Mablagh==0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مبلغ ضروری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MonasebatMablagh.Insert(HeaderId,MonasebatId,Mablagh,TypeNesbatId,UserId, IP);
        }
        #endregion
        #region Update
        public string Update(int Id, int HeaderId, byte MonasebatId, int Mablagh, byte TypeNesbatId, int UserId, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است.";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است.";
            }
            else if (HeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد هدر ضروری است.";
            }
            else if (MonasebatId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد مناسبت ضروری است.";
            }
            else if (TypeNesbatId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع نسبت ضروری است.";
            }
            else if (Mablagh == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "مبلغ ضروری است.";
            }
            if (error.ErrorType == true)
                return "خطا";

            return MonasebatMablagh.Update(Id,HeaderId, MonasebatId, Mablagh, TypeNesbatId, UserId, IP);
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
            //else if (MonasebatMablagh.CheckDelete(id))
            //{
            //    error.ErrorType = true;
            //    error.ErrorMsg = "آیتم مورد نظر در جای دیگر استفاده شده است";
            //}
            if (error.ErrorType == true)
                return "خطا";

            return MonasebatMablagh.Delete(id, userId);
        }
        #endregion
    }
}