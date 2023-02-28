using DuettChallenge.Business.Dtos;
using FluentValidation;

namespace DuettChallenge.Business.Validations
{
    public class FruitValidator : AbstractValidator<FruitDto>
    {
        public FruitValidator()
        {
            RuleFor(fruitDto => fruitDto.Description).NotEmpty().WithMessage("Description is required.");
        }
    }
}