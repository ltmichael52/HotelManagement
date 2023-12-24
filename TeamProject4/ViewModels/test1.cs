﻿using System.ComponentModel.DataAnnotations;
using Team_Project_4.Models;

namespace Team_Project_4.ViewModels
{
    public class test1
    {
        [DataType(DataType.Date)]
        public DateTime Ngaylaphd { get; set; }

        [Required(ErrorMessage = "Vui Lòng Nhập CCCD Khách Hàng")]
        public string CCCD { get; set; }

    }
}
