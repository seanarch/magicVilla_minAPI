﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MagicVilla_minAPI.Models.DTO
{
	public class CouponCreateDTO
	{
         
        public string Name { get; set; }
        public int Percent { get; set; }
        public bool IsActive { get; set; }
    }
}

