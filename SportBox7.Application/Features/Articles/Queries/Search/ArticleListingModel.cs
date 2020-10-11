namespace SportBox7.Application.Features.Articles.Queries.Search
{
    public class ArticleListingModel
    {
        public ArticleListingModel(
            int id, 
            string title,
            string body,
            string imageUrl,
            string category)
        {
            this.Id = id;
            this.Title = title;
            this.Body = body;
            this.ImageUrl = imageUrl;
            this.Category = category;
        }

        public int Id { get; }

        public string Title { get; }

        public string Body { get; }

        public string ImageUrl { get; }

        public string Category { get; }


    }
}
