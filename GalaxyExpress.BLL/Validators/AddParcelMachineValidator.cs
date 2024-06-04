using FluentValidation;
using GalaxyExpress.BLL.DTOs.ParcelMachineDTOs;
namespace GalaxyExpress.BLL.Validators;

public class AddParcelMachineValidator : AbstractValidator<AddParcelMachineDTO>
{
    public AddParcelMachineValidator()
    {
        RuleFor(x => x.ParcelMachineNumber)
            .NotEmpty().WithMessage("ParcelMachineNumber can not be empty!");

        // TODO: Add a regular expression.
        RuleFor(x => x.GlobalAddress)
            .NotNull().WithMessage("GlobalAddress can not be nullable!")
            .NotEmpty().WithMessage("GlobalAddress can not be empty!");

        // TODO: Add a regular expression.
        RuleFor(x => x.LocalAddress)
            .NotNull().WithMessage("LocalAddress can not be nullable!")
            .NotEmpty().WithMessage("LocalAddress can not be empty!");

        RuleFor(x => x.X)
            .NotEmpty().WithMessage("X-coordinate can not be empty!");

        RuleFor(x => x.Y)
            .NotEmpty().WithMessage("Y-coordinate can not be empty!");
    }
}