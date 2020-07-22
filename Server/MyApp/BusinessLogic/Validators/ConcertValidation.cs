using Entities;
using FluentValidation;
using Models;
using System.Text.RegularExpressions;

namespace BusinessLogic.Validators
{
    public class ConcertValidation : AbstractValidator<ConcertDto> 
    {
        public ConcertValidation()
        {
            RuleFor(concert => concert.Name)
                .NotNull().WithMessage("Please ensure that you have entered your name");
            RuleFor(concert => concert.Price)
                .NotNull().WithMessage("Please ensure that you have entered your name");

        }

        private static bool HasOnlyNumbers(string Id)
        {
            var regexp = new Regex("^[0-9]*$");
            return !string.IsNullOrEmpty(Id) && regexp.IsMatch(Id);
        }
    }
}
