using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanPage.Models
{
    public static class StoryRepo
    {
        private static List<Story> stories = new List<Story>();
        public static List<Story> Stories { get { return stories; } }
        
        public static void AddStory(Story story)
        {
            stories.Add(story);
        }
      
        public static Story GetStoryByTitle(string title)
        {
            Story story = stories.Find(s => s.Title == title);
            return story;
        }
    }
}
