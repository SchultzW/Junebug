using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanPage.Models
{
    public class StoryRepo:IStoryRepo
    {
        private ApplicationDbContext context;

        //static private  List<Story> stories = new List<Story>();
        public   List<Story> Stories { get { return context.Stories.Include("Comments").ToList(); } }
        
        public StoryRepo(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }
        public void AddStory(Story story)
        {
            context.Stories.Add(story);
            context.SaveChanges();
        }
      
        public Story GetStoryByTitle(string title)
        {
            Story story = context.Stories.First(s => s.Title == title);
            return story;
        }
        public void AddComment(Story s,Comment c)
        {
            s.Comments.Add(c);
            context.Stories.Update(s);
            context.SaveChanges();
        }

        public void AddTestData()
        {
            
        }

        public void AddRating(int r, Story s)
        {
            s.Rating.Add(r);
            context.Stories.Update(s);
            context.SaveChanges();
        }

        /*
         * public  class BookRepository : IBookRepository {
           private AppDbContext context;

           public  List<Book> Books { get {
               return context.Books.Include("Authors").Include("Reviews").ToList(); }
           }

           public BookRepository(AppDbContext appDbContext) {
               context = appDbContext;
           }

           public  void AddBook(Book book) {
               context.Books.Add(book);
               context.SaveChanges();
           }
         */
    }
}
