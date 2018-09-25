using System;
using System.Collections.Generic;
using System.Text;

namespace BetHelper.Models
{
    public class Article
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Body { get; set; }

        public ICollection<ArticleTag> ArticleTags { get; set; }

        //public List<Comment> Comment { get; set; }

        public int LikeCount { get; set; }

        public int ViewCount { get; set; }
    }
}
