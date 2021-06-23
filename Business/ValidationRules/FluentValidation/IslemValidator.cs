using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class IslemValidator : AbstractValidator<Islem>
    {
        public IslemValidator()
        {
            RuleFor(k => k.KitapId).NotEmpty();
            RuleFor(k => k.OgrenciNumarasi).NotEmpty();
            RuleFor(k => k.AlinanTarih).NotEmpty();
        }
    }
}
