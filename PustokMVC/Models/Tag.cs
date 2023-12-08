namespace PustokMVC.Models
{
    public class Tag
    {
        public int Id {  get; set; }
        public string Title { get; set; }
        public List<BlogsTags>? BlogsTags { get; set; }

    }
}
