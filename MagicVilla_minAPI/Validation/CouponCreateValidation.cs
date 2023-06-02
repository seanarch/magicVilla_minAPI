using System;
using FluentValidation;
using MagicVilla_minAPI.Models.DTO;

namespace MagicVilla_minAPI.Validation
{
	public class CouponCreateValidation : AbstractValidator<CouponCreateDTO>
	{
		public CouponCreateValidation()
		{
			RuleFor(model => model.Name).NotEmpty();
			RuleFor(model => model.Percent).InclusiveBetween(1, 100);
		}
	}
}

