using FluentValidation;
using GalaxyExpress.BLL.DTOs.UserDTOs;

namespace GalaxyExpress.BLL.Validators;

public class UpdateUserValidator : AbstractValidator<UpdateUserDTO>
{
    public UpdateUserValidator()
    {
        RuleFor(x => x.UserId)
            .NotEmpty().WithMessage("UserId не може мати пусте значення!");

        RuleFor(x => x.Login)
            .NotNull().WithMessage("Логін не може бути типу \"nullable\"!")
            .NotEmpty().WithMessage("Логін не може бути пустим!");

        RuleFor(x => x.FirstName)
            .NotNull().WithMessage("Ім'я не може бути типу \"nullable\"!")
            .NotEmpty().WithMessage("Ім'я не може бути пусте!");

        RuleFor(x => x.LastName)
            .NotNull().WithMessage("Прізвище не може бути типу \"nullable\"!")
            .NotEmpty().WithMessage("Прізвище не може бути пусте!");

        RuleFor(x => x.Gender)
            .NotEmpty().WithMessage("Gender не може мати пусте значення!");
    }
}