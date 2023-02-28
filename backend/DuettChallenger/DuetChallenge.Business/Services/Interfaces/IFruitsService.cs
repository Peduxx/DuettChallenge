using DuettChallenge.Business.Dtos;
using DuettChallenge.Business.Dtos.BaseResponse;
using DuettChallenge.Business.Entities;

namespace DuettChallenge.Business.Services.Interfaces
{
    public interface IFruitsService
    {
        Response Create(FruitDto fruitDto);
        IEnumerable<Fruit> GetAll();
    }
}
