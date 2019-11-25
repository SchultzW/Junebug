using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanPage.Models
{
    public interface IStoryRepo
    {
         
        List<Story> Stories { get; }

       void AddStory(Story story);


       Story GetStoryByTitle(string title);

        void AddTestData();



    }
}
