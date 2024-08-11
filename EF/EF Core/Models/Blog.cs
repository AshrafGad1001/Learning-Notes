namespace EF_Core.Models
{
    public class Blog
    {
        public int Id { get; set; }

        public string Url { get; set; } = string.Empty;
        public int Ratings { get; set; }    

        public List<Post> Posts { get; set; }   

    }
}
