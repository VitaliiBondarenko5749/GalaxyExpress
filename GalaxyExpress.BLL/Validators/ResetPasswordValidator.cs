using FluentValidation;
using GalaxyExpress.BLL.DTOs.UserDTOs;

namespace GalaxyExpress.BLL.Validators;

public class ResetPasswordValidator : AbstractValidator<ResetPasswordDTO>
{
    public ResetPasswordValidator()
    {
        RuleFor(x => x.UserId).NotEmpty()
            .WithMessage("AccountId не може мати пусте значення!");

        RuleFor(x => x.Token).NotEmpty()
            .WithMessage("Token не може мати пусте значення!");

        RuleFor(x => x.Password)
            .MinimumLength(8).WithMessage("Пароль повинен містити хоча б 8 символів!")
            .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,30}$")
            .WithMessage("Пароль повинен містити хоча б одну цифру, один спеціальний символ, латинські сиволи верхнього та нижнього реєстру!")
            .Equal(x => x.ConfirmPassword).WithMessage("Password та Confirm Password не є ідентичні!");
    }
}