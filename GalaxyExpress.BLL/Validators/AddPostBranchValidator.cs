using FluentValidation;
using GalaxyExpress.BLL.DTOs.PostBranchDTOs;
namespace GalaxyExpress.BLL.Validators;

public class AddPostBranchValidator : AbstractValidator<AddPostBranchDTO>
{
    public AddPostBranchValidator()
    {
        RuleFor(x => x.BranchNumber)
            .NotEmpty().WithMessage("Номер відділення не може пути пустим!");

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