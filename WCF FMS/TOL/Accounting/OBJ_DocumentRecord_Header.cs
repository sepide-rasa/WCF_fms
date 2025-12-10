using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_FMS.TOL.Accounting
{
    public class OBJ_DocumentRecord_Header
    {
        public int fldId { get; set; }
        public int fldDocumentNum { get; set; }
        public int? fldAtfNum { get; set; }
        public string fldArchiveNum { get; set; }
        public string fldDescriptionDocu { get; set; }
        public int fldOrganId { get; set; }
        public string fldTarikhDocument { get; set; }
        public string fldDesc { get; set; }
        public System.DateTime fldDate { get; set; }
        public string fldIP { get; set; }
        public int fldUserId { get; set; }
        public byte fldAccept { get; set; }
        public byte fldType { get; set; }
        public string fldTypeName { get; set; }
        public Nullable<int> ShomareRoozane { get; set; }
        public Nullable<int> fldShomareFaree { get; set; }
        public short fldYear { get; set; }
        public Nullable<int> fldFiscalYearId { get; set; }
        public Nullable<int> fldTypeSanad { get; set; }
        public string fldTypeSanadName { get; set; }
        public string fldNameModule { get; set; }
        public Nullable<int> fldModuleErsalId { get; set; }
        public bool fldIsArchive { get; set; }
        public Nullable<int> fldDocumentNum_Pid { get; set; }
        public int fldPId { get; set; }
        public string fldTypeSanadName_Pid { get; set; }
        public Nullable<int> fldMainDocNum { get; set; }
        public int fldFlag { get; set; }
        public byte fldIsMap { get; set; }
        public Nullable<byte> fldEdit { get; set; }
        public Nullable<int> fldCaseTypeId { get; set; }
    }
}