using MC.ApplicationServices.Messaging.Requests;
using MC.ApplicationServices.Messaging.Responses;

namespace MC.ApplicationServices.Interfaces
{
    public interface IMoviesService
    {
        Task<GetByTitleResponse> GetByTitleAsync(GetByTitleRequest request);
    }
}
