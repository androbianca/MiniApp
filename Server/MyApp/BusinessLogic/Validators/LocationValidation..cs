using Entities;
using FluentValidation;
using Models;
using System.Text.RegularExpressions;

namespace BusinessLogic.Validators
{
    public class LocationValidation : AbstractValidator<LocationDto> 
    {
        public LocationValidation()
        {
            RuleFor(location => location.Name).NotNull().Must(HasAlphanumericLetters);
            RuleFor(location => location.Country).NotNull().Must(HasOnlyLetters);
            RuleFor(location => location.Country).NotNull().Must(HasOnlyLetters);
            RuleFor(location => location.Street).NotNull().Must(HasOnlyLetters);
        }

        private static bool HasAlphanumericLetters(string Id)
        {
            var regexp = new Regex("^[a-zA-Z0-9]*$");
            return !string.IsNullOrEmpty(Id) && regexp.IsMatch(Id);
        }

        private static bool HasOnlyLetters(string Id)
        {
            var regexp = new Regex("^[0-9]*$");
            return !string.IsNullOrEmpty(Id) && regexp.IsMatch(Id);
        }
    }
}
