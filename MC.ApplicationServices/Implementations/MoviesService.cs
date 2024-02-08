using MC.ApplicationServices.Interfaces;
using MC.ApplicationServices.Messaging.Requests;
using MC.ApplicationServices.Messaging.Responses;
using MC.Data.Data;
using MC.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MC.ApplicationServices.Implementations
{
    public class MoviesService : IMoviesService
    {
        public MoviesDbContext _context;

        /// <summary>
        /// Movies service constructor.
        /// </summary>
        public MoviesService(MoviesDbContext context) 
        {
            _context = context;
        }

        /// <inheritdoc />      
        public async Task<GetByTitleResponse> GetByTitleAsync(GetByTitleRequest request)
        {
            GetByTitleResponse response = new GetByTitleResponse();
            var movie = await _context.Movies.SingleOrDefaultAsync(x=> x.Title == request.Title);
            response.Movie = new MovieModel() 
            {
                Title = movie?.Title,
                Description = movie?.Description,
                ReleaseDate = movie?.ReleaseDate,
            };
            return response;
        }

        /// <inheritdoc />   
        public async Task AddMovieAsync(MovieModel movie)
        {
            var id = _context.Movies.Count() + 1;
            await _context.Movies.AddAsync(new Movie() {
                Title = movie.Title,
                Description = movie?.Description,
                ReleaseDate = movie?.ReleaseDate,
            });

            await _context.SaveChangesAsync();
        }
    }
}
