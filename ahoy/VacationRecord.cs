//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ahoy
{
    using System;
    using System.Collections.Generic;
    
    public partial class VacationRecord
    {
        public int VacationRecordID { get; set; }
        public int VacationTypeID { get; set; }
        public int DepartmentalID { get; set; }
        public int ApplicantEmployeeID { get; set; }
        public System.DateTime vacationStartDateTime { get; set; }
        public Nullable<System.DateTime> vacationEndDateTime { get; set; }
        public string vacationReason { get; set; }
        public string attachedFilesName { get; set; }
        public int ApplyStatusID { get; set; }
        public Nullable<System.DateTime> ApplyChanged { get; set; }
    
        public virtual ApplyStatus ApplyStatus { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual VacationType VacationType { get; set; }
    }
}
