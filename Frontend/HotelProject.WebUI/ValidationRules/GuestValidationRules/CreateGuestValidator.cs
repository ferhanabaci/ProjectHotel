using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class CreateGuestValidator : AbstractValidator<CreateGuestDto>
    {
        public CreateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("isim alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soy isim alanı boş geçilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage("City alanı boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("İsim alanı en az 3 karakter olmalı");
            RuleFor(x => x.Surname).MinimumLength(3).WithMessage("Soyisim alanı en az 3 karakter olmalı");
        }
    }
}
