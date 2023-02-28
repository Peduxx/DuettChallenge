using DuettChallenge.Business.Entities;
using DuettChallenge.Business.Ports;

namespace DuettChallenge.Data.DuettChallenger.Data.Repository
{
    public class FruitsRepository : IFruitRepository
    {
        private readonly DuettChallengeDbContext _duettChallengeDbContext;
        public FruitsRepository(DuettChallengeDbContext duettChallengeDbContext)
        {
            _duettChallengeDbContext = duettChallengeDbContext;
        }

        public void Save(Fruit fruit)
        {
            _duettChallengeDbContext.Fruits.Add(fruit);
            _duettChallengeDbContext.SaveChangesAsync();
        }

        public IEnumerable<Fruit> GetAll()
        {
            return _duettChallengeDbContext.Fruits.AsEnumerable();
        }
    }
}
