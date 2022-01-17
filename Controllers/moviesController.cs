using System.Net;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using NextFlixAPI.Database.Services;
using NextFlixAPI.Entities;

namespace NextFlixAPI.Controllers{

    [ApiController]
    [Route("movies")]
    public class MoviesController : ControllerBase{
        private readonly IMovieService _movieService;
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        
        /// <summary>
        /// Returns a Movie by it id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type=typeof(Movie))]
        public ActionResult Get(int id){
           return Ok(_movieService.GetById(id));
        }
        
    }

}