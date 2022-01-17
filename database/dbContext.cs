using NextFlixAPI.Entities;
using Microsoft.EntityFrameworkCore;


namespace NextFlixAPI.Database{
    public class BaseContext : DbContext{
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {            
        }



        //Create Tables
        public DbSet<Movie> Movie {get; set;}
        
    }
}