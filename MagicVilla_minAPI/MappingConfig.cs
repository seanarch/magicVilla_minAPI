using System;
using AutoMapper;
using MagicVilla_minAPI.Models;
using MagicVilla_minAPI.Models.DTO;

namespace MagicVilla_minAPI
{
	public class MappingConfig : Profile
	{
		 public MappingConfig()
		{
			CreateMap<Coupon, CouponCreateDTO>().ReverseMap();
            CreateMap<Coupon, CouponDTO>().ReverseMap();
        }
	}
}

