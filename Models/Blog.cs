using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// this consturcts a blog where the name is required
public class Blog
{
  public int BlogId { get; set; }
  [Required]
  public string Name { get; set; }

  public ICollection<Post> Posts { get; set; }
}
