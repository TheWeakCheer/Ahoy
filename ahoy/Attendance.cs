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
    
    public partial class Attendance
    {
        public int AttendanceID { get; set; }
        public int AttendanceEmployeeID { get; set; }
        public int ShiftRuleID { get; set; }
        public int StoreID { get; set; }
        public System.DateTime attendanceStartDateTime { get; set; }
        public Nullable<System.DateTime> attendanceEndDateTime { get; set; }
        public Nullable<System.DateTime> overTimeStartDateTime { get; set; }
        public Nullable<System.DateTime> overTimeEndDateTime { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual ShiftRule ShiftRule { get; set; }
        public virtual Store Store { get; set; }
    }
}
