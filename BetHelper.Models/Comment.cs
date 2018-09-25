using System;

namespace BetHelper.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public Guid OwnerId { get; set; }

        public string Body { get; set; }

        public int LikeCount { get; set; }
    }
}