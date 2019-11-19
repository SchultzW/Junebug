using FanPage.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanPage.Models
{
    public class CommentRepo:ICommentRepo
    {
        private List<Comment> comments = new List<Comment>();
        public List<Comment> Comments { get { return comments ; } }

        public void AddStory(Comment comment)
        {
            comments.Add(comment);
        }
    }
}
