using FluentValidation;
using HotelProject.WebUI.Dtos.AboutDto;

namespace HotelProject.WebUI.ValidationRules.AdminAboutValidationRules
{
    public class AdminAboutUpdateValidator : AbstractValidator<UpdateAboutDto>
    {
        public AdminAboutUpdateValidator()
        {
            RuleFor(x => x.Title1).NotEmpty().WithMessage("Title1 alanı boş geçilemez");
            RuleFor(x => x.Title2).NotEmpty().WithMessage("Title2alanı boş geçilemez");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Content alanı boş geçilemez");
            RuleFor(x => x.RoomCount).MinimumLength(3).WithMessage("RoomCount alanı boş geçilemez");
            RuleFor(x => x.StaffCount).MinimumLength(3).WithMessage("StaffCount alanı boş geçilemez");

        }
    }
}
