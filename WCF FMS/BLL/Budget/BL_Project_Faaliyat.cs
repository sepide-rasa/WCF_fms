//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using WCF_FMS.DAL.Budget;
//using WCF_FMS.TOL.Budget;

//namespace WCF_FMS.BLL.Budget
//{
//    public class BL_Project_Faaliyat
//    {
//        DL_Project_Faaliyat Project_Faaliyat = new DL_Project_Faaliyat();

//        #region Detail
//        public OBJ_Project_Faaliyat Detail(int id, int OrganId, out ClsError error)
//        {
//            error = new ClsError();
//            if (id == 0)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "کد ضروری است";
//            }
//            if (error.ErrorType == true)
//                return null;
//            return Project_Faaliyat.Detail(id, OrganId);
//        }
//        #endregion
//        #region Select
//        public List<OBJ_Project_Faaliyat> Select(string FieldName, string FilterValue, string FilterValue2, int OrganId,short Year, int h)
//        {
//            return Project_Faaliyat.Select(FieldName, FilterValue, FilterValue2, OrganId, Year, h);
//        }
//        #endregion
//        #region Insert
//        public string Insert(int Tarh_KhedmatId, string Code, string Title, byte Type, int EtebarId, int MasrafId, int ChartOrganId, short Year, int OrganId, int userId, string Desc, out ClsError error)
//        {
//            error = new ClsError();
//            error.ErrorType = false;
//            if (Desc == null)
//                Desc = "";
//            if (userId == 0)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "کد کاربر ضروری است";
//            }
//            else if (Code == "" || Code == null)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "کد پروژه-فعالیت ضروری است";
//            }
//            else if (Tarh_KhedmatId == 0)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "کد طرح-خدمت ضروری است";
//            }
//            else if (Year == 0)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "سال ضروری است";
//            }
//            else if (Type == 0)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "نوع ضروری است";
//            }
//            else if (EtebarId == 0)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "کد نوع عتبار ضروری است";
//            }
//            else if (MasrafId == 0)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "کد نوع مصرف ضروری است";
//            }
//            else if (ChartOrganId == 0)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "کد چارت سازمانی ضروری است";
//            }
//            if (Title == "" || Title == null)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "عنوان ضروری است";
//            }
//            else if (Title.Length < 2)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
//            }
//            else if (Title.Length > 200)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
//            }
//            if (error.ErrorType == true)
//                return "خطا";

//            return Project_Faaliyat.Insert(Tarh_KhedmatId,Code, Title,Type,EtebarId,MasrafId,ChartOrganId,Year, OrganId, userId, Desc);

//        }
//        #endregion
//        #region Update
//        public string Update(int Id, int Tarh_KhedmatId, string Code, string Title, byte Type, int EtebarId, int MasrafId, int ChartOrganId, short Year, int OrganId, int userId, string Desc, out ClsError error)
//        {
//            error = new ClsError();
//            error.ErrorType = false;


//            if (Desc == null)
//                Desc = "";
//            if (userId == 0)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "شناسه کاربر ضروری است";
//            }
//            if (Id == 0)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "کد ضروری است";
//            }
//            else if (Year == 0)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "سال ضروری است";
//            }
//            else if (Code == "" || Code == null)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "کد پروژه-فعالیت ضروری است";
//            }
//            else if (Tarh_KhedmatId == 0)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "کد طرح-خدمت ضروری است";
//            }
//            else if (Type == 0)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "نوع ضروری است";
//            }
//            else if (EtebarId == 0)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "کد نوع عتبار ضروری است";
//            }
//            else if (MasrafId == 0)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "کد نوع مصرف ضروری است";
//            }
//            else if (ChartOrganId == 0)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "کد چارت سازمانی ضروری است";
//            }
//            if (Title == "" || Title == null)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "عنوان ضروری است";
//            }
//            else if (Title.Length < 2)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "تعداد کاراکتر عنوان وارد شده کمتر از حد مجاز میباشد.";
//            }
//            else if (Title.Length > 200)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "تعداد کاراکتر عنوان وارده شده بیشتر از حد مجاز می باشد.";
//            }
//            if (error.ErrorType == true)
//                return "خطا";

//            return Project_Faaliyat.Update(Id, Tarh_KhedmatId, Code, Title, Type, EtebarId, MasrafId, ChartOrganId,Year, OrganId, userId, Desc);

//        }
//        #endregion
//        #region Delete
//        public string Delete(int id, int userId, out ClsError error)
//        {
//            error = new ClsError();
//            error.ErrorType = false;
//            if (userId == 0)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "کد کاربر ضروری است";
//            }
//            else if (id == 0)
//            {
//                error.ErrorType = true;
//                error.ErrorMsg = "کد ضروری است";
//            }
//            if (error.ErrorType == true)
//                return "خطا";

//            return Project_Faaliyat.Delete(id, userId);
//        }
//        #endregion
//    }
//}