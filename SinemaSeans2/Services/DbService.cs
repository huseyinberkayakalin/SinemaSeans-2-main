using SinemaSeans2.Data;
using SinemaSeans2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaSeans2.Services
{
    internal class DbService
    {
        AppDbContext _dbContext = new AppDbContext();

        public List<Movie> GetMovies()
        {
            return _dbContext.Movies.ToList();
        }
        public List<Session> GetSessionsByMovie(int movieId)
        {
            return _dbContext.Sessions.Where(s => s.movieId == movieId).ToList();
        }
        public int GetMovieIdByName(string movieName)
        {
            var movie = _dbContext.Movies.FirstOrDefault(m => m.movieName == movieName);
            return movie != null ? movie.id : -1;
        }

        public List<string> GetSeatNumbersBySessionId(int sessionId)
        {
            var seatNumbers = _dbContext.Reservations
                                    .Where(r => r.sessionId == sessionId)
                                    .Select(r => r.seatNo)
                                    .ToList();
            return seatNumbers;
        }

    }
}
