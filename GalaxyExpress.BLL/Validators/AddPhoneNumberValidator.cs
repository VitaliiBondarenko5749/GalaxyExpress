using FluentValidation;
using GalaxyExpress.BLL.DTOs.PhoneNumberDTOs;

namespace GalaxyExpress.BLL.Validators;

public class AddPhoneNumberValidator : AbstractValidator<AddPhoneNumberDTO>
{
    public AddPhoneNumberValidator()
    {
        RuleFor(x => x.UserId)
            .NotEmpty().WithMessage("UserId не може мати пусте значення!");

        RuleFor(x => x.PhoneNumber)
            .NotEmpty().WithMessage("Номер телефону не може бути пустим!")
            .NotNull().WithMessage("Номер телефону не може бути типу \"nullable\"!")
            .Matches("\\+380\\d{9}").WithMessage("Введений номер телефону не є українським!");
    }
}