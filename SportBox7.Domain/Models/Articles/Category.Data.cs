using SportBox7.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportBox7.Domain.Models.Articles
{
    public class CategoryData : IInitialData
    {
        public Type EntityType => typeof(Category);

        public IEnumerable<object> GetData()
        {
            return new List<Category>()
            {
                new Category("Футбол", "FootBall"),
                new Category("Волейбол", "Volleyball")
            };
        }
    }
}
