using FluentValidation;
using GalaxyExpress.BLL.DTOs.ParcelMachineDTOs;
namespace GalaxyExpress.BLL.Validators;

public class AddParcelMachineValidator : AbstractValidator<AddParcelMachineDTO>
{
    public AddParcelMachineValidator()
    {
        RuleFor(x => x.ParcelMachineNumber)
            .NotEmpty().WithMessage("Номер поштомату не може бути пустим!");

        // TODO: Add a regular expression.
        RuleFor(x => x.GlobalAddress)
            .NotNull().WithMessage("Глобальна адреса не може бути типу \"nullable\"!")
            .NotEmpty().WithMessage("Глобальна адреса не може бути пустим значенням!");

        // TODO: Add a regular expression.
        RuleFor(x => x.LocalAddress)
            .NotNull().WithMessage("Локальна адреса не може бути типу \"nullable\"!")
            .NotEmpty().WithMessage("Локальна адреса не може бути пустим значенням!");

        RuleFor(x => x.X)
            .NotEmpty().WithMessage("X-координта не може бути пустою!");

        RuleFor(x => x.Y)
            .NotEmpty().WithMessage("Y-координата не може бути пустою!");
    }
}