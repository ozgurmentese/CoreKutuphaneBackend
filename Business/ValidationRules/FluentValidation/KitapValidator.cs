using Entities.Concrete;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class KitapValidator : AbstractValidator<Kitap>
    {
        public KitapValidator()
        {
            RuleFor(k => k.Ad).NotEmpty();
            RuleFor(k => k.SayfaSayisi).NotEmpty();
            RuleFor(k => k.TurId).NotEmpty();
            RuleFor(k => k.YazarId).NotEmpty();
            RuleFor(k => k.Isbnno).NotEmpty();
        }
    }
}
