using DuettChallenge.Business.Entities;

namespace DuettChallenge.Business.Ports
{
    public interface IFruitRepository
    {
        void Save(Fruit fruit);
        IEnumerable<Fruit> GetAll();
    }
}
