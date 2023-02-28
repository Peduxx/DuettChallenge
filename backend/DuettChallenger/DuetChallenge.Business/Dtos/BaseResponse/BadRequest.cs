using FluentValidation.Results;

namespace DuettChallenge.Business.Dtos.BaseResponse
{
    public class BadRequest : Response
    {
        public BadRequest(string message, IEnumerable<ValidationFailure> errorsList)
        {
            Message = message;
            ErrorsList = errorsList;
        }

        public IEnumerable<ValidationFailure> ErrorsList { get; set; }
    }
}
