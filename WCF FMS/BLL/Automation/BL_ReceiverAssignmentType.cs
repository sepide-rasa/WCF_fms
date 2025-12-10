using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_FMS.DAL.Automation;
using WCF_FMS.TOL.Automation;

namespace WCF_FMS.BLL.Automation
{
    public class BL_ReceiverAssignmentType
    {
        DL_ReceiverAssignmentType ReceiverAssignmentType = new DL_ReceiverAssignmentType();

        #region Detail
        public OBJ_ReceiverAssignmentType Detail(int id, int OrganId, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return ReceiverAssignmentType.Detail(id, OrganId);
        }
        #endregion
        #region Select
        public List<OBJ_ReceiverAssignmentType> Select(string FieldName, string FilterValue, int OrganId, int h)
        {
            return ReceiverAssignmentType.Select(FieldName, FilterValue, OrganId, h);
        }
        #endregion
        #region Insert
        public string Insert(int fldAssignmentID, int fldReceiverComisionID, int fldAssignmentStatusID, int fldAssignmentTypeID, int fldBoxID, string fldLetterReadDate, bool fldShowTypeT_F, int OrganID, int UserId, string Desc, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد کاربر ضروری است";
            }
            else if (fldAssignmentID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ارجاع ضروری است";
            }
            else if (fldReceiverComisionID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد گیرنده ارجاع ضروری است";
            }
            else if (fldAssignmentStatusID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد وضعیت ارجاع ضروری است";
            }
            else if (fldAssignmentTypeID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع ارجاع ضروری است";
            }
            else if (fldBoxID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد مدیریت پوشه ها ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ReceiverAssignmentType.Insert(fldAssignmentID, fldReceiverComisionID, fldAssignmentStatusID, fldAssignmentTypeID, fldBoxID, fldLetterReadDate, fldShowTypeT_F, OrganID, UserId, Desc, IP);

        }
        #endregion
        #region Update
        public string Update(int Id, int fldAssignmentID, int fldReceiverComisionID, int fldAssignmentStatusID, int fldAssignmentTypeID, int fldBoxID, string fldLetterReadDate, bool fldShowTypeT_F, int OrganID, int UserId, string Desc, string IP, out ClsError error)
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
            else if (fldAssignmentID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ارجاع ضروری است";
            }
            else if (fldReceiverComisionID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد گیرنده ارجاع ضروری است";
            }
            else if (fldAssignmentStatusID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد وضعیت ارجاع ضروری است";
            }
            else if (fldAssignmentTypeID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد نوع ارجاع ضروری است";
            }
            else if (fldBoxID == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد مدیریت پوشه ها ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return ReceiverAssignmentType.Update(Id, fldAssignmentID, fldReceiverComisionID, fldAssignmentStatusID, fldAssignmentTypeID, fldBoxID, fldLetterReadDate, fldShowTypeT_F, OrganID, UserId, Desc, IP);

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

            return ReceiverAssignmentType.Delete(id, userId);
        }
        #endregion
    }
}