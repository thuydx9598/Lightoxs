//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lightoxs.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class BaiViet
    {
        public int MaBV { get; set; }
        public Nullable<int> MaDMA { get; set; }
        public string TenBV { get; set; }
        public System.DateTime NgayDang { get; set; }
        public string MoTa { get; set; }
        public string NoiDung { get; set; }
        public string LinkFB { get; set; }
        public Nullable<int> TrangThai { get; set; }
        public Nullable<System.DateTime> NgayDienRa { get; set; }
    
        public virtual DanhMucBaiViet DanhMucBaiViet { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}