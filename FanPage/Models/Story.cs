using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanPage.Models
{
    public class Story
    {
        private List<int> ratings = new List<int>();
        private List<Comment> comments = new List<Comment>();

        public int StoryID { get; set; }
        public string StoryText { get; set; }
        //public User Writer { get; set; }
        public string Writer { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<int> Rating { get { return ratings; } }
        public List<Comment> Comments { get { return comments; } }

        


       
    }
}
