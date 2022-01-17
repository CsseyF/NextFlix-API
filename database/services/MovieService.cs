using NextFlixAPI.Database.Repositories;
using NextFlixAPI.Entities;

namespace NextFlixAPI.Database.Services{
    public interface IMovieService{
        Task<IEnumerable<Movie>> GetList();
        Task<Movie> GetById(int id);
        Task<Movie> GetByName(string name);
        Task<IEnumerable<Movie>> GetAllWithName(string name);
        Task<IEnumerable<Movie>> GetByGenre(string genre);
    }

    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<IEnumerable<Movie>> GetList(){
           return _movieRepository.GetList(); 
        }

        public async Task<Movie> GetById(int id){
            if(id == 0){
                throw new Exception("The id cannot be 0");
            }
            return _movieRepository.GetById(id);
        }

        public async Task<Movie> GetByName(string name){
            if(String.IsNullOrEmpty(name)){
                throw  new Exception("The name cannot be empty");
            }
            return _movieRepository.GetByName(name);
        }
        
        public async Task<IEnumerable<Movie>> GetAllWithName(string name){
            if(String.IsNullOrEmpty(name)){
                throw  new Exception("The name cannot be empty");
            }
            return _movieRepository.GetAllWithName(name);
        }

        public async Task<IEnumerable<Movie>> GetByGenre(string genre){
              if(String.IsNullOrEmpty(genre)){
                throw  new Exception("The genre cannot be empty");
            }
            return _movieRepository.GetByGenre(genre);
        }
    }

}