using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Posts.Any()) return;

            var activities = new List<Post>
            {
                new Post
                {
                    Title = "Blog post 1",
                    MetaTitle = "Blog post 1",
                    Slug = "blog-post-1",
                    Summary = "Blog post 1 summary",
                    Content = "Blog post 1 content",
                    IsPublished = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    PublishedAt = DateTime.UtcNow
                },
                new Post
                {
                    Title = "Blog post 2",
                    MetaTitle = "Blog post 2",
                    Slug = "blog-post-2",
                    Summary = "Blog post 2 summary",
                    Content = "Blog post 2 content",
                    IsPublished = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    PublishedAt = DateTime.UtcNow
                },
                new Post
                {
                    Title = "Blog post 3",
                    MetaTitle = "Blog post 3",
                    Slug = "blog-post-3",
                    Summary = "Blog post 3 summary",
                    Content = "Blog post 3 content",
                    IsPublished = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    PublishedAt = DateTime.UtcNow
                },
                new Post
                {
                    Title = "Blog post 4",
                    MetaTitle = "Blog post 4",
                    Slug = "blog-post-4",
                    Summary = "Blog post 4 summary",
                    Content = "Blog post 4 content",
                    IsPublished = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    PublishedAt = DateTime.UtcNow
                },
                new Post
                {
                    Title = "Blog post 5",
                    MetaTitle = "Blog post 5",
                    Slug = "blog-post-5",
                    Summary = "Blog post 5 summary",
                    Content = "Blog post 5 content",
                    IsPublished = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    PublishedAt = DateTime.UtcNow
                },
                new Post
                {
                    Title = "Blog post 6",
                    MetaTitle = "Blog post 6",
                    Slug = "blog-post-6",
                    Summary = "Blog post 6 summary",
                    Content = "Blog post 6 content",
                    IsPublished = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    PublishedAt = DateTime.UtcNow
                },
                new Post
                {
                    Title = "Blog post 7",
                    MetaTitle = "Blog post 7",
                    Slug = "blog-post-7",
                    Summary = "Blog post 7 summary",
                    Content = "Blog post 7 content",
                    IsPublished = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    PublishedAt = DateTime.UtcNow
                }
            };

            await context.Posts.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}
