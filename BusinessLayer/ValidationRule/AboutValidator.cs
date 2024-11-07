﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRule
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmı boş geçilemez.");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen görsel seçiniz.");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen en az 50 karakterlik açıklama giriniz.");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Maksimum 1500 karakterlik açıklama girebilirsiniz.");
        }
    }
}
