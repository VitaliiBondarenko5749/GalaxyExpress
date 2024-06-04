using FluentValidation;
using GalaxyExpress.BLL.DTOs.UserDTOs;

namespace GalaxyExpress.BLL.Validators;

public class RegisterUserValidator : AbstractValidator<RegisterUserDTO>
{
    public RegisterUserValidator()
    {
        RuleFor(x => x.PhoneNumber)
            .NotEmpty().WithMessage("Номер телефону не може бути пустим!")
            .NotNull().WithMessage("Номер телефону не може бути типу \"nullable\"!")
            .Matches("\\+380\\d{9}")
            .WithMessage("Введений номер телефону не є українським!");

        RuleFor(x => x.Password)
            .MinimumLength(8).WithMessage("Пароль повинен містити хоча б 8 символів!")
            .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,30}$")
            .WithMessage("Пароль повинен містити хоча б одну цифру, один спеціальний символ, латинські сиволи верхнього та нижнього реєстру!")
            .Equal(x => x.ConfirmPassword).WithMessage("Password та Confirm Password не є ідентичні!");

        RuleFor(x => x.Login)
            .NotNull().WithMessage("Логін не може бути типу \"nullable\"!")
            .NotEmpty().WithMessage("Логін не може бути пустим!");

        RuleFor(x => x.FirstName)
            .NotNull().WithMessage("Ім'я не може бути типу \"nullable\"!")
            .NotEmpty().WithMessage("Ім'я не може бути пусте!");

        RuleFor(x => x.LastName)
            .NotNull().WithMessage("Прізвище не може бути типу \"nullable\"!")
            .NotEmpty().WithMessage("Прізвище не може бути пусте!");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email не може пути пустим!")
            .EmailAddress().WithMessage("Введене значення не є Email!")
            .Matches(@"^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$").WithMessage("Email має недоступні символи!");
    }
}