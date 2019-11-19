using FanPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanPage.Repos
{
    interface ICommentRepo
    {
       
        List<Comment> Comments { get; }

        void AddStory(Comment comment);
        
           
        
    }
}
