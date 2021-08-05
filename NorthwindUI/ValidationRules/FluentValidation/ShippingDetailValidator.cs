using FluentValidation;
using NorthwindUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindUI.ValidationRules.FluentValidation
{
    public class ShippingDetailValidator:AbstractValidator<ShippingDetail>
    {
        public ShippingDetailValidator()
        {
            RuleFor(r => r.FirstName).NotEmpty().WithMessage("This field can not be empty!");
            RuleFor(r => r.LastName).NotEmpty().WithMessage("This field can not be empty!");
            RuleFor(r => r.Age).NotEmpty().WithMessage("This field can not be empty!");
            RuleFor(r => r.Age).ExclusiveBetween(18, 25).WithMessage("Age should between 18-25.");
            RuleFor(r => r.Adres).NotEmpty().WithMessage("This field can not be empty!");


        }
    }
}
