﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebMVC_PT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Full_Contract
    {
        public int ID { get; set; }
        
        [Display(Name = "Mã hợp đồng")]
        public string Full_Contract_Code { get; set; }
        [Required(ErrorMessage = "Mời nhập họ và tên")]
        [Display(Name = "Họ và tên")]
        public string Customer_Name { get; set; }
        [Required(ErrorMessage = "Mời nhập năm sinh")]
        [Display(Name = "Năm sinh")]
        public Nullable<int> Year_Of_Birth { get; set; }
        [Display(Name = "CCCD")]
        public string SSN { get; set; }
        [Display(Name = "Địa chỉ")]
        public string Customer_Address { get; set; }
        [Display(Name = "Số điện thoại")]
        public string Mobile { get; set; }
        [Display(Name = "Mã bất động sản")]
        public int Property_ID { get; set; }
        [Display(Name = "Ngày lập hợp đồng")]
        public Nullable<System.DateTime> Date_Of_Contract { get; set; }
        [Display(Name = "Giá trị hợp đồng")]
        public Nullable<decimal> Price { get; set; }
        [Display(Name = "Số tiền đã cọc")]
        public Nullable<decimal> Deposit { get; set; }
        [Display(Name = "Số tiền còn lại")]
        public Nullable<decimal> Remain { get; set; }
        [Display(Name = "Trạng thái")]
        public bool Status { get; set; }
    }
}
