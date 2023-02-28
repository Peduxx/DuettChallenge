using DuettChallenge.Business.Dtos;
using DuettChallenge.Business.Entities.Base;

namespace DuettChallenge.Business.Entities
{
    public class Fruit : BaseEntity
    {
        public string Description { get; set; }
        public int ValueA { get; set; }
        public int ValueB { get; set; }


        public static Fruit Map(FruitDto fruitDto)
        {
            return new Fruit()
            {
                Description = fruitDto.Description,
                ValueA = fruitDto.ValueA,
                ValueB = fruitDto.ValueB,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
        }
    }
}
