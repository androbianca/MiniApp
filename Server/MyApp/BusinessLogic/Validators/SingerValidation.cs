using Entities;
using FluentValidation;
using Models;
using System.Text.RegularExpressions;

namespace BusinessLogic.Validators
{
    public class SingerValidation : AbstractValidator<SingerDto> 
    {
        public SingerValidation()
        {
            RuleFor(singer => singer.Name).NotNull().Must(HasAlphanumericLetters);
            RuleFor(singer => singer.MusicType).NotNull().Must(HasOnlyLetters);
        }

        private static bool HasAlphanumericLetters(string Id)
        {
            var regexp = new Regex("^[a-zA-Z0-9]*$");
            return !string.IsNullOrEmpty(Id) && regexp.IsMatch(Id);
        }

        private static bool HasOnlyLetters(string Id)
        {
            var regexp = new Regex("^[a-zA-Z0-9]*$");
            return !string.IsNullOrEmpty(Id) && regexp.IsMatch(Id);
        }
    }
}
