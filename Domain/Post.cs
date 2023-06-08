namespace Domain
{
    public class Post
    {
        public Guid Id { get; set; }

        public Guid AuthorId { get; set; }

        public Guid ParentId { get; set; }

        public string Title { get; set; }

        public string MetaTitle { get; set; }

        public string Slug { get; set; }

        public string Summary { get; set; }

        public bool IsPublished { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime PublishedAt { get; set; }

        public string Content { get; set; }
    }
}
