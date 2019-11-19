using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanPage.Models;
using System.Web;
using System.IO;
using FanPage.Repos;

namespace FanPage.Controllers
{
    public class HomeController : Controller
    {
        Story story;
        User user = new User();
        Story sView;
        IStoryRepo sRepo;
        ICommentRepo cRepo;


        public HomeController(IStoryRepo r)
        {
            sRepo = r;
            
            if (sRepo.Stories.Count == 0)
            {
                story = new Story();
                {
                    story.Writer = "Junebug";
                    story.Title = "I am Junebug";
                    story.Description = "Junebug's life";
                    story.StoryText = "I am Junebug and I like to sleep on chairs and take the entire couch. I also love to eat your left over yogurt!";
                    sRepo.AddStory(story);
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
            //StoryController();
            List<Story> stories = sRepo.Stories;
            stories.Sort((s1, s2) => (s1.Title.CompareTo(s2.Title)));
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
            return View(sRepo.Stories);
        }
      
        [HttpPost]
        public RedirectToActionResult WriteStory(string writer, string storyText, string description, string title)
                                                  
        {         
            
            story = new Story();
            story.Writer = writer;
            story.StoryText = storyText;
            story.Title = title;
            story.Description = description;
            //story.Comments.Add(comment);
            //story.Rating.Add(review);
            
            sRepo.AddStory(story);
            return RedirectToAction("Stories");
        }
        
        [HttpPost]
        public RedirectToActionResult Story(Story s)
        {
            return RedirectToAction("StoryPage",s);
        }
        //tyring this
        public IActionResult StoryPage(string title)
        {
            Story s = sRepo.GetStoryByTitle(title);

            return View("StoryPage",s);
        }
        [HttpPost]
        public RedirectToActionResult StoryPage(string title,string user, string commentText, int rating)
        {
            Story s = sRepo.GetStoryByTitle(title);
            Comment c = new Comment();
            c.CommentText = commentText;
            c.User = user;
            s.Comments.Add(c);
            s.Rating.Add(rating);
            return RedirectToAction("Stories");
        }
        /// <summary>
        /// test page
        /// </summary>
        /// <returns></returns>
       

            
    }
}
