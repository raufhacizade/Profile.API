using FluentValidation;
using Profile.API.ViewModels;

namespace Profile.API.Validators.User
{
  public class UserCreateModelValidator : AbstractValidator<UserCreateModel>
  {
    public UserCreateModelValidator()
    {
      RuleFor(model => model.FirstName)
        .NotEmpty()
        .MinimumLength(2)
        .MaximumLength(50);
      RuleFor(model => model.LastName)
        .NotEmpty()
        .MinimumLength(2)
        .MaximumLength(50);
      RuleFor(model => model.Email)
        .NotEmpty()
        .EmailAddress();
    }
  }
}
