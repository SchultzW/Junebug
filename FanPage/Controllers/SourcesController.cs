using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FanPage.Models;

namespace FanPage.Controllers
{
   
    public class SourcesController : Controller
    {
        Media m = new Media();
        Media m1 = new Media();
        Media m2 = new Media();
        List<Media> pMedia = new List<Media>();

        Media o = new Media();
        Media o1 = new Media();
        Media o2 = new Media();
        List<Media> oMedia = new List<Media>();
        
        [HttpGet]
        public ViewResult Sources()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Media()
        {
            if(pMedia.Count==0)
            {
                fillList();
                pMedia.Sort((m1, m2) => (m1.Title.CompareTo(m2.Title)));
            }
            
            return View(pMedia);
        }
        [HttpGet]
        public ViewResult Online()
        {
            if (oMedia.Count == 0)
            {
                fillOnline();
                oMedia.Sort((m1, m2) => (m1.Title.CompareTo(m2.Title)));
            }
            return View(oMedia);
        }

        public void fillList()
        {
            m.Title = "Dune";
            m.Auth = "Junebug";
            m.Type = "Book";
            m.ImagePath = "C:/Users/wills/OneDrive/Desktop/School/Fall 2019/ASP.NET/Lab 1/FanPage/FanPage/wwwroot/images/dune.jpg";
            m.Description = "A mythic and emotionally charged hero's journey, Dune tells the story of Paul Atreides, a brilliant and gifted young man born into a great destiny beyond his understanding, who must travel to the most dangerous planet in the universe to ensure the future of his family and his people.";

            m1.Title = "A Brief History of Time";
            m1.Auth = "Junebug";
            m1.Type = "Book";
            m1.ImagePath = "~/images/time.jpg";
            m1.Description = "A Brief History of Time: From the Big Bang to Black Holes is a popular-science book on cosmology by physicist Junebug. It was first published in 1988. Junebug wrote the book for non-specialist readers with no prior knowledge of scientific theories";

            m2.Title = "Pet Sematary";
            m2.Auth = "Junebug";
            m2.Type = "Book";
            m2.ImagePath = "~/images/StephenKingPetSematary.jpg";
            m2.Description = "Doctor Louis Creed moves his family to Maine, where he meets a friendly local named Jud Crandall. After the Creeds' cat is accidentally killed, Crandall advises Louis to bury it in the ground near the old pet cemetery. The cat returns to life, its personality changed for the worse. When Louis' son, Gage, dies tragically, Louis decides to bury the boy's body in the same ground despite the warnings of Crandall and Louis' visions of a deceased patient.";


            pMedia.Add(m);
            pMedia.Add(m1);
            pMedia.Add(m2);

        }
        public void fillOnline()
        {
            o.Title = "Cats of Instagram";
            o.Description = "A cute collection of Junebugs fellow felines doing all sorts of cute things!";
            o.Url = "https://www.instagram.com/cats_of_instagram/?hl=en";

            o1.Title = "5 Pawsitively Fascinating Facts About Black Cats";
            o1.Description = "Althogh the pun is regrettable, it is important to know why black cats are better than normal cats.";
            o1.Url = "https://www.thesprucepets.com/facts-about-black-cats-554102";

            o2.Title = "Cat Videos";
            o2.Description = "The title says it all! spice up your day with some adorable cat videos.";
            o2.Url = "https://www.youtube.com/results?search_query=cat+videos";

            oMedia.Add(o);
            oMedia.Add(o1);
            oMedia.Add(o2);
        }



    }
}