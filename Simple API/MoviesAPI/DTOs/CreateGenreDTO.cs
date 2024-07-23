namespace MoviesAPI.DTOs
{
    public class CreateGenreDTO
    {
        [MaxLength(100)]
        public string Name { get; set;} 
    }
}
