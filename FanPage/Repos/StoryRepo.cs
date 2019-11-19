using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanPage.Models
{
    public class StoryRepo:IStoryRepo
    {
        private  List<Story> stories = new List<Story>();
        public   List<Story> Stories { get { return stories; } }
        
        public void AddStory(Story story)
        {
            stories.Add(story);
        }
      
        public Story GetStoryByTitle(string title)
        {
            Story story = stories.Find(s => s.Title == title);
            return story;
        }
    }
}
