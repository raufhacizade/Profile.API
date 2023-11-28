using FluentValidation;
using Profile.API.ViewModels;

namespace Profile.API.Validators.User
{
  public class UserUpdateModelValidator : AbstractValidator<UserModel>
  {
    public UserUpdateModelValidator()
    {
      RuleFor(model => model.Id)
        .NotEmpty()
        .GreaterThanOrEqualTo(1);
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
