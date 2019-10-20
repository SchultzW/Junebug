using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanPage.Models
{
    public class CommentRepo
    {
        private static List<Comment> comments = new List<Comment>();
        public static List<Comment> Comments { get { return comments ; } }

        public static void AddStory(Comment comment)
        {
            comments.Add(comment);
        }
    }
}
