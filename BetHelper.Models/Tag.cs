using System;
using System.Collections.Generic;
using System.Text;

namespace BetHelper.Models
{
    public class Tag
    {
        public int Id { get; set; }

        public string Value { get; set; }

        public ICollection<ArticleTag> ArticleTags { get; set; }
    }
}

