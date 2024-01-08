namespace Domain.Models;
 public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public int CategoryId { get; set; }
   
}