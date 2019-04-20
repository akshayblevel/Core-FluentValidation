using FluentValidation;

namespace Akshayblevel.FluentValidation.ApiModels.Validators
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage("Id is mandatory field");

            RuleFor(c => c.Name).NotEmpty().Length(0, 10).WithMessage("Name is mandatory with max legnth 10");

            RuleFor(c => c.Email).EmailAddress().WithMessage("Invalid Email");
        }
    }
}
