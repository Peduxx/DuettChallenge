using DuettChallenge.Business.Dtos;
using DuettChallenge.Business.Dtos.BaseResponse;
using DuettChallenge.Business.Entities;
using DuettChallenge.Business.Ports;
using DuettChallenge.Business.Services.Interfaces;
using DuettChallenge.Business.Validations;
using FluentValidation.Results;

namespace DuettChallenge.Business.Services
{
    public class FruitsService : IFruitsService
    {
        private readonly IFruitRepository _fruitRepository;
        private readonly FruitValidator _fruitValidator = new();

        public FruitsService(IFruitRepository fruitRepository)
        {
            _fruitRepository = fruitRepository;
        }

        public Response Create(FruitDto fruitDto)
        {
            try
            {
                ValidationResult results = _fruitValidator.Validate(fruitDto);

                var failures = results.Errors.AsEnumerable();

                if (!results.IsValid)
                {
                    return new BadRequest("Erro ao tentar criar um novo item!", failures);
                }

                var fruit = Fruit.Map(fruitDto);

                _fruitRepository.Save(fruit);

                return new Success("Item criado com sucesso.", fruitDto);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Fruit> GetAll()
        {
            try
            {
                var allFruits = _fruitRepository.GetAll();

                return allFruits;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
