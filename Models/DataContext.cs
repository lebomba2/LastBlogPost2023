using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
  public DataContext(DbContextOptions<DataContext> options) : base(options) { }

  public DbSet<Blog> Blogs { get; set; }
  public DbSet<Post> Posts { get; set; }
  public void AddBlog(Blog blog)
  {
    this.Add(blog);
    this.SaveChanges();
  }
  
  // this allows you to delete blogs it accepta a blog object as agrument and removes the blog form the database and page 
  public void DeleteBlog(Blog blog)
  {
    this.Remove(blog);
    this.SaveChanges();
  }
  // this allow you to make a post 
  public void AddPost(Post post)
  {
    this.Add(post);
    this.SaveChanges();
  }
   // this method will delete a post 
  public void DeletePost(Post post)
  {
    this.Remove(post);
    this.SaveChanges();
  }
}
