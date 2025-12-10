using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using WCF_FMS.DAL.Accounting;
using WCF_FMS.TOL.Accounting;

namespace WCF_FMS.BLL.Accounting
{
    public class BL_DocumentRecord_Header
    {
        DL_DocumentRecord_Header DocumentRecord_Header = new DL_DocumentRecord_Header();
        #region Detail
        public OBJ_DocumentRecord_Header Detail(int id, int OrganId, short Year, int Madule, out ClsError error)
        {
            error = new ClsError();
            if (id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است";
            }
            if (error.ErrorType == true)
                return null;
            return DocumentRecord_Header.Detail(id, OrganId, Year, Madule);
        }
        #endregion
        #region Select
        public List<OBJ_DocumentRecord_Header> Select(string FieldName, string FilterValue, string value2, string value3, int OrganId, short Year, int Madule,byte OrderType, int h)
        {
            return DocumentRecord_Header.Select(FieldName, FilterValue, value2, value3,OrganId, Year, Madule,OrderType, h);
        }
        #endregion
        #region SelectMortabet
        public List<OBJ_DocumentRecord_Header> SelectMortabet(int HeaderId, int MaduleSaveId)
        {
            return DocumentRecord_Header.SelectMortabet(HeaderId, MaduleSaveId);
        }
        #endregion
        #region Insert
        public int Insert(int DocumentNum, string ArchiveNum, string DescriptionDocu, int OrganId, string TarikhDocument, byte Accept, byte Type, int UserId, string IP, string Desc, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            
            else if (Type == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع سند ضروری است";
            }
            
            else if (TarikhDocument == "" || TarikhDocument == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ سند ضروری است";
            }
            else if (!r.IsMatch(TarikhDocument))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            if (Type == 2)
            {
                if (ArchiveNum == null)
                    ArchiveNum = "";
                if (DescriptionDocu == null)
                    DescriptionDocu = "";
            }
            else
            {
                if (DocumentNum == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "شماره سند ضروری است";
                }
                else if (ArchiveNum == "" || ArchiveNum == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "شماره بایگانی ضروری است";
                }

                else if (DescriptionDocu == "" || DescriptionDocu == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "شرح سند ضروری است";
                }
            }
            if (error.ErrorType == true)
                return 0;

            return DocumentRecord_Header.Insert(DocumentNum, ArchiveNum, DescriptionDocu, OrganId, TarikhDocument, Accept,Type, UserId, IP, Desc);

        }
        #endregion
        #region Update
        public string Update(int Id, string ArchiveNum, string DescriptionDocu, int OrganId, string TarikhDocument, byte Accept, byte Type, int UserId, string IP, string Desc, out ClsError error)
        {
            error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Id == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد جهت ویرایش ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (Type == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع سند ضروری است";
            }
           
            else if (TarikhDocument == "" || TarikhDocument == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ سند ضروری است";
            }
            else if (!r.IsMatch(TarikhDocument))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            if (Type == 2)
            {
                if (ArchiveNum == null)
                    ArchiveNum = "";
                if (DescriptionDocu == null)
                    DescriptionDocu = "";
            }
            else 
            {
                
                if (ArchiveNum == "" || ArchiveNum == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "شماره بایگانی ضروری است";
                }

                else if (DescriptionDocu == "" || DescriptionDocu == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "شرح سند ضروری است";
                }
            }
            if (error.ErrorType == true)
                return "خطا";

            return DocumentRecord_Header.Update(Id, ArchiveNum, DescriptionDocu, OrganId, TarikhDocument, Accept,Type, UserId, IP, Desc);

        }
        #endregion
        #region InsertDocumentFishDaramad
        public string InsertDocumentFishDaramad(int FiscalYearId, int FishId, int OrganId, int ModuleSaveId, int ModuleErsalId, int UserId, string IP, string Desc, out ClsError error)
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
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (FiscalYearId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال مالی ضروری است";
            }
            else if (FishId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد فیش ضروری است";
            }
            else if (ModuleSaveId == 0 || ModuleErsalId==0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ماژول ضروری است";
            }
            
            if (error.ErrorType == true)
                return "خطا";

            return DocumentRecord_Header.InsertDocumentFishDaramad(FiscalYearId, FishId, OrganId,ModuleSaveId, ModuleErsalId,UserId,IP, Desc);

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

            return DocumentRecord_Header.Delete(id, userId);
        }
        #endregion
        #region LastNum_AtfDocumentRecord
        public List<OBJ_DocumentRecord_Header> LastNum_AtfDocumentRecord(short Year, int OrganId, int ModuleDocId)
        {
            return DocumentRecord_Header.LastNum_AtfDocumentRecord(Year, OrganId, ModuleDocId);
        }
        #endregion

        #region InsertDocument
        public int InsertDocument( string ArchiveNum, string DescriptionDocu, int OrganId, string TarikhDocument, byte Accept, byte Type,
            System.Data.DataTable detail, int? ModuleSaveId, int? ModuleErsalId, Nullable<int> fldShomareFaree, int fldFiscalYearId, int fldTypeSanad,int? fldPid,byte? fldEdit, int UserId, 
            string IP, string Desc, out ClsError error)
        {
            error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (fldFiscalYearId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سال مالی ضروری است";
            }
            else if (Type == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع سند ضروری است";
            }

            else if (TarikhDocument == "" || TarikhDocument == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ سند ضروری است";
            }
            else if (!r.IsMatch(TarikhDocument))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (ModuleSaveId == null && ModuleErsalId == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام ماژول ضروری است";
            }

            else if (DescriptionDocu == "" || DescriptionDocu == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شرح سند ضروری است";
            }
            if (Type == 2)
            {
                if (ArchiveNum == null)
                    ArchiveNum = "";
                if (DescriptionDocu == null)
                    DescriptionDocu = "";
            }
           
            for (int i = 0; i < detail.Rows.Count; i++)
            {
                if (Convert.ToInt32(detail.Rows[i]["fldCodingId"]) == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد Coding ضروری است";
                }
                else if (detail.Rows[i]["fldDescription"].ToString() == "" || detail.Rows[i]["fldDescription"].ToString() == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "شرح سند ضروری است";
                }
                else if (detail.Rows[i]["fldDescription"].ToString().Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر شرح سند وارد شده کمتر از حد مجاز میباشد.";
                }
            }
            if (error.ErrorType == true)
                return 0;

            return DocumentRecord_Header.InsertDocument( ArchiveNum, DescriptionDocu, OrganId, TarikhDocument, Accept, Type,detail, ModuleSaveId,ModuleErsalId,fldShomareFaree,fldFiscalYearId,fldTypeSanad,fldPid,fldEdit, UserId, IP, Desc);

        }
        #endregion
        #region UpdateDocument
        public string UpdateDocument(int fldHeaderId, int DocumentNum, string ArchiveNum, string DescriptionDocu, int OrganId, string TarikhDocument, byte Accept, byte Type, System.Data.DataTable detail, int? ModuleSaveId, int? ModuleErsalId, Nullable<int> fldShomareFaree, int fldTypeSanad, int UserId, string IP, string Desc, out ClsError error)
        {
            error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            error.ErrorType = false;
            if (Desc == null)
                Desc = "";
            if (fldHeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است.";
            }
            else if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (Type == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع سند ضروری است";
            }

            else if (TarikhDocument == "" || TarikhDocument == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ سند ضروری است";
            }
            else if (!r.IsMatch(TarikhDocument))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            else if (ModuleSaveId == null && ModuleErsalId == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نام ماژول ضروری است";
            }

            else if (DescriptionDocu == "" || DescriptionDocu == null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شرح سند ضروری است";
            }
            if (Type == 2)
            {
                if (ArchiveNum == null)
                    ArchiveNum = "";
                if (DescriptionDocu == null)
                    DescriptionDocu = "";
            }
            else
            {
                if (DocumentNum == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "شماره سند ضروری است";
                }
                
            }
            for (int i = 0; i < detail.Rows.Count; i++)
            {
                if (Convert.ToInt32(detail.Rows[i]["fldCodingId"]) == 0)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "کد Coding ضروری است";
                }
                else if (detail.Rows[i]["fldDescription"].ToString() == "" || detail.Rows[i]["fldDescription"].ToString() == null)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "شرح سند ضروری است";
                }
                else if (detail.Rows[i]["fldDescription"].ToString().Length < 2)
                {
                    error.ErrorType = true;
                    error.ErrorMsg = "تعداد کاراکتر شرح سند وارد شده کمتر از حد مجاز میباشد.";
                }  
            }
            
            if (error.ErrorType == true)
                return "خطا";

            return DocumentRecord_Header.UpdateDocument(fldHeaderId, DocumentNum, ArchiveNum, DescriptionDocu, OrganId, TarikhDocument, Accept, Type, detail, ModuleSaveId, ModuleErsalId, fldShomareFaree, fldTypeSanad, UserId, IP, Desc);

        }
        #endregion

        #region UpdateMoratabSaziTarikhSanad
        public string UpdateMoratabSaziTarikhSanad(int OrganId, short Year, int moduleId, int userId, out ClsError error)
        {
            error = new ClsError();
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            error.ErrorType = false;
            if (userId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (Year == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "سال ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (moduleId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ماژول ضروری است";
            }

           
            if (error.ErrorType == true)
                return "خطا";

            return DocumentRecord_Header.UpdateMoratabSaziTarikhSanad(OrganId,Year,moduleId,userId);

        }
        #endregion

        #region CheckRemain
        public List<OBJ_CheckRemain> CheckRemain(int Coding_DetailsId, int id, long Bedehkar, long Bestankar, int OrganId, short Year, int MaduleSaveId)
        {
            return DocumentRecord_Header.CheckRemain(Coding_DetailsId, id, Bedehkar, Bestankar, OrganId, Year, MaduleSaveId);
        }
        #endregion
        #region UpdateGhati
        public string UpdateGhati(int fldHeaderId, int UserId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (fldHeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است.";
            }
            else if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }

            if (error.ErrorType == true)
                return "خطا";

            return DocumentRecord_Header.UpdateGhati(fldHeaderId, UserId);

        }
        #endregion
        #region DisableGhati
        public string DisableGhati(int fldHeaderId, int UserId, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (fldHeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است.";
            }
            else if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }

            if (error.ErrorType == true)
                return "خطا";

            return DocumentRecord_Header.DisableGhati(fldHeaderId, UserId);

        }
        #endregion
        #region CheckDocStatus
        public bool CheckDocStatus(int DocHeaderId,out int Id, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (DocHeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سند ضروری است.";
            }
            return DocumentRecord_Header.CheckDocStatus(DocHeaderId,out Id);
        }
        #endregion
        #region Document_CopyInsert
        public string Document_CopyInsert(int DocHeaderId, int OrganId, byte ModuleErsalId,byte ModuleSaveId, byte Type,string TarikhDocument, int UserId, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            Regex r = new Regex(@"\d{4}/\d{2}/\d{2}");
            if (DocHeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است.";
            }
            else if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            else if (OrganId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد سازمان ضروری است";
            }
            else if (Type == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "نوع ثبت ضروری است";
            }
            else if (ModuleErsalId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ماژول مرجع سند ضروری است";
            }
            else if (ModuleSaveId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تایپ ماژول سند ضروری است";
            }
            else if (TarikhDocument == "" || TarikhDocument==null)
            {
                error.ErrorType = true;
                error.ErrorMsg = "تاریخ سند ضروری است";
            }
            else if (!r.IsMatch(TarikhDocument))
            {
                error.ErrorType = true;
                error.ErrorMsg = "فرمت تاریخ را به درستی وارد کنید";
            }
            if (error.ErrorType == true)
                return "خطا";

            return DocumentRecord_Header.Document_CopyInsert(DocHeaderId, OrganId, ModuleErsalId, ModuleSaveId, Type, TarikhDocument, UserId, IP);
        }
        #endregion
        #region UpdateArchive_FareiNum
        public string UpdateArchive_FareiNum(int fldHeaderId,string ArchiveNum,int FareiNum, int UserId,string Ip, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (fldHeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است.";
            }
            else if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
            if (error.ErrorType == true)
                return "خطا";

            return DocumentRecord_Header.UpdateArchive_FareiNum(fldHeaderId,ArchiveNum,FareiNum, UserId,Ip);
        }
        #endregion
        #region CopyDocumentWithHeaderId
        public string CopyDocumentWithHeaderId(int DocHeaderId,int UserId, string IP, out ClsError error)
        {
            error = new ClsError();
            error.ErrorType = false;
            if (DocHeaderId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "کد ضروری است.";
            }
            else if (UserId == 0)
            {
                error.ErrorType = true;
                error.ErrorMsg = "شناسه کاربر ضروری است";
            }
           
            if (error.ErrorType == true)
                return "خطا";

            return DocumentRecord_Header.CopyDocumentWithHeaderId(DocHeaderId, UserId, IP);
        }
        #endregion
    }
}