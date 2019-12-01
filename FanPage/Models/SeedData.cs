using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanPage.Models
{
    public class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.EnsureCreated();
            if(!context.Stories.Any())
            {
                Story story = new Story();
                story.Writer = "Junebug";
                story.Title = "I am Junebug";
                story.Description = "Junebug's life";
                story.StoryText = "I am Junebug and I like to sleep on chairs and take the entire couch. I also love to eat your left over yogurt!";
                context.Add(story);


                story = new Story();
                story.Writer = "Junebug";
                story.Title = "My box";
                story.Description = "Why can't I sleep in the box?";
                story.StoryText = "Everynight the humans I adopted put me outside so I have to go back to my real home. But I just want to sleep in my box.";
                context.Add(story);

                story = new Story();
                story.Writer = "Will";
                story.Title = "What happened to my yogurt?";
                story.Description = "Mystery of missing yogurt";
                story.StoryText = "I was eating yogurt and got up from the table for one minute when I came back it was gone...";
                context.Add(story);

                context.SaveChanges();
            }
        }
    }
}
