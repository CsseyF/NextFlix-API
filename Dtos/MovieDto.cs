namespace NextFlixAPI.Dto{
    public class MovieDto{
        public Guid Id {get; init;}
        public string Name {get; init;}
        public string BannerPath {get; init;}

        public string Genres {get; init;}
    }
}