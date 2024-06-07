using FluentValidation;
using GalaxyExpress.BLL.DTOs.UserDTOs;

namespace GalaxyExpress.BLL.Validators;

public class ChangePasswordValidator : AbstractValidator<ChangePasswordDTO>
{
    public ChangePasswordValidator()
    {
        RuleFor(x => x.UserId)
            .NotEmpty().WithMessage("UserId не може мати пусте значення!");

        RuleFor(x => x.OldPassword)
            .MinimumLength(8).WithMessage("Старий пароль повинен містити хоча б 8 символів!")
            .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,30}$")
            .WithMessage("Старий пароль повинен містити хоча б одну цифру, один спеціальний символ, латинські сиволи верхнього та нижнього реєстру!");

        RuleFor(x => x.NewPassword)
            .MinimumLength(8).WithMessage("Новий пароль повинен містити хоча б 8 символів!")
            .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,30}$")
            .WithMessage("Новий пароль повинен містити хоча б одну цифру, один спеціальний символ, латинські сиволи верхнього та нижнього реєстру!")
            .Equal(x => x.ConfirmNewPassword).WithMessage("New Password та Confirm New Password не є ідентичні!");
    }
}