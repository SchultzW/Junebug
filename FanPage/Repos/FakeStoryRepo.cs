using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FanPage.Models;

namespace FanPage.Models
{
    public class FakeStoryRepo:IStoryRepo
    {
        private List<Story> stories = new List<Story>();
        public List<Story> Stories { get { return stories; } }

        public void AddStory(Story story)
        {
            stories.Add(story);
        }

        public Story GetStoryByTitle(string title)
        {
            Story story = stories.Find(s => s.Title == title);
            return story;
        }
       public void AddTestData()
        {
            Story story = new Story();
            story.Writer = "Junebug";
            story.Title = "I am Junebug";
            story.Description = "Junebug's life";
            story.StoryText = "I am Junebug and I like to sleep on chairs and take the entire couch. I also love to eat your left over yogurt!";
            stories.Add(story);

         
            story = new Story();
            story.Writer = "Junebug";
            story.Title = "My box";
            story.Description = "Why can't I sleep in the box?";
            story.StoryText = "Everynight the humans I adopted put me outside so I have to go back to my real home. But I just want to sleep in my box.";

            story = new Story();
            story.Writer = "Will";
            story.Title = "What happened to my yogurt?";
            story.Description = "Mystery of missing yogurt";
            story.StoryText = "I was eating yogurt and got up from the table for one minute when I came back it was gone...";

        }
    }
}
