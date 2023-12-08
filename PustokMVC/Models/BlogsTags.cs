namespace PustokMVC.Models
{
    public class BlogsTags
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public int PostId { get; set;}
        public Blog? Blog { get; set; }
        public Tag? Tag { get; set; }
    }
}
