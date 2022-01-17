using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NextFlixAPI.Entities{

    [Table("movie")]
    public class Movie{

        [Key]
        public int Id {get; set;}
        public Guid Identity {get; set;}

        [Column(TypeName = "varchar(50)")]
        public string Name {get; set;}
        
        [Column(TypeName = "varchar(255)")]
        public string BannerPath {get; set;}

        [Column(TypeName = "varchar(50)")]
        public string Genres {get; set;}
    }
}