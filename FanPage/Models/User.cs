using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanPage.Models
{
    public class User
    {
        private List<Story> stories = new List<Story>();
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Story> Stories { get { return stories; } }
    }
}
