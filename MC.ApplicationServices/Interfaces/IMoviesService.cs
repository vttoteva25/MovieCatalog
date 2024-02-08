using MC.ApplicationServices.Messaging.Requests;
using MC.ApplicationServices.Messaging.Responses;

namespace MC.ApplicationServices.Interfaces
{
    /// <summary>
    /// Movie service.
    /// </summary>
    public interface IMoviesService
    {
        /// <summary>
        /// Get movie by title.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<GetByTitleResponse> GetByTitleAsync(GetByTitleRequest request);

        /// <summary>
        /// Add movie in the database.
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        Task AddMovieAsync(MovieModel movie);
    }
}
