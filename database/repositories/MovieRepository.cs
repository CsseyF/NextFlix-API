using NextFlixAPI.Entities;

namespace NextFlixAPI.Database.Repositories
{
    public interface IMovieRepository {
        IEnumerable<Movie> GetList();
        Movie GetById(int id);
        Movie GetByName(string name);
        IEnumerable<Movie> GetAllWithName(string name);
        IEnumerable<Movie> GetByGenre(string genre);
    }
    public class MovieRepository: IMovieRepository {
        private readonly BaseContext _context;
        public MovieRepository(BaseContext context)
        {
            _context = context;
        }


        public IEnumerable<Movie> GetList(){
            return _context.Movie;
        }
        public Movie GetById(int id){
            return _context.Movie.FirstOrDefault(item => item.Id == id);
        }
        public Movie GetByName(string name){
            return _context.Movie.FirstOrDefault(item => item.Name.Contains(name));
        }

        public IEnumerable<Movie> GetAllWithName(string name){
           return _context.Movie.Where(item => item.Name.Contains(name));
        }
        public IEnumerable<Movie> GetByGenre(string genre){
            return _context.Movie.Where(item => item.Genres.Equals(genre));
        }


        public Movie Insert(Movie movie){
            _context.Movie.Add(movie);
            return movie;
        }
        
    }
}