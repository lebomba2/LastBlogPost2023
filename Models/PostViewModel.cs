public class PostViewModel
{//this is the post veiw it gets the current blog and a list of post in the that blog 
  public Blog blog { get; set; }
  public IEnumerable<Post> Posts { get; set; }
}