using FluentValidation;
using GalaxyExpress.BLL.DTOs.EmailDTOs;

namespace GalaxyExpress.BLL.Validators;

public class AddEmailValidator : AbstractValidator<AddEmailDTO>
{
    public AddEmailValidator()
    {
        RuleFor(x => x.UserId)
            .NotEmpty().WithMessage("UserId не може мати пусте значення!");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email не може пути пустим!")
            .EmailAddress().WithMessage("Введене значення не є Email!")
            .Matches(@"^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$").WithMessage("Email має недоступні символи!");
    }
}