namespace DuettChallenge.Business.Dtos.BaseResponse
{
    public class Success : Response
    {
        public Success(string message, FruitDto? fruit)
        {
            Message = message;
            Fruit = fruit;
        }

        public FruitDto? Fruit { get; set; }
    }
}
