//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNPMNC_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BANGCHAMCONG
    {
        public int MABCC { get; set; }
        public Nullable<int> MANV { get; set; }
        public Nullable<int> THANG { get; set; }
        public Nullable<System.DateTime> NGAYLAMVIEC { get; set; }
        public Nullable<System.DateTime> NGAYPHEP { get; set; }
        public Nullable<System.DateTime> TANGCA { get; set; }
        public Nullable<System.DateTime> NGAYKHPHEP { get; set; }
    
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
