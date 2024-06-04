using FluentValidation;
using GalaxyExpress.BLL.DTOs.PostBranchDTOs;
namespace GalaxyExpress.BLL.Validators;

public class AddPostBranchValidator : AbstractValidator<AddPostBranchDTO>
{
    public AddPostBranchValidator()
    {
        RuleFor(x => x.BranchNumber)
            .NotEmpty().WithMessage("BranchNumber can not be empty!");

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