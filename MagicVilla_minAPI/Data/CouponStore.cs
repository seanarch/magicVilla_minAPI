﻿using System;
using MagicVilla_minAPI.Models;

namespace MagicVilla_minAPI.Data
{
	public static class CouponStore
	{
		public static List<Coupon> couponList = new List<Coupon>
		{
			new Coupon{Id=1, Name="10OFF", Percent=10, IsActive=true},
			new Coupon{Id=1, Name="20OFF", Percent=20, IsActive=false}
		};
	}
}

