namespace PizzaDemo.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public DateOnly BlogDate { get; set; }
        public string? BlogTitle { get; set; }
        public string? BlogDescription { get; set; }
        public string BlogUrl {  get; set; }
        public string? BlogAuthor {  get; set; }
        public int CommentCount {  get; set; }
    }
}
