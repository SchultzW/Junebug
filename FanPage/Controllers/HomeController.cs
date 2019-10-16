using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanPage.Models;

namespace FanPage.Controllers
{
    public class HomeController : Controller
    {
        Story story;
        User user = new User();


        public void StoryController()
        {
            
            if (StoryRepo.Stories.Count == 0)
            {
                story = new Story();
                {
                    story.Writer = "Junebug";
                    story.StoryText = "I am Junebug and I like to sleep on chairs and take the entire couch. I also love to eat your left over yogurt!";
                    StoryRepo.AddStory(story);
                }
            }
        }
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult History()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Stories()
        {
            List<Story> stories = StoryRepo.Stories;
            return View(stories);
        }
        [HttpGet]
        public ViewResult WriteStory()
        {
            return View();
        }
   
        /// method for getting stories that a user submitted
       
         /*
        [HttpPost]
        public ViewResult WriteStory(string writer,string storyText)
        {
            story = new Story();
            story.Writer = writer;
            story.StoryText = storyText;
            StoryRepo.AddStory(story);
            return View("Stories");
        }
        */
        public ViewResult ListStory()
        {
            return View(StoryRepo.Stories);
        }
        [HttpPost]
        public RedirectToActionResult WriteStory(string writer, string storyText)
        {
            story = new Story();
            story.Writer = writer;
            story.StoryText = storyText;
            StoryRepo.AddStory(story);
            return RedirectToAction("Stories");
        }
    }
}
