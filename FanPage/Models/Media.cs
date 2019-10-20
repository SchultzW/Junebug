using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FanPage.Models
{
    public class Media
    {
        private static List<Media> physicalMedias = new List<Media>();
        public static List<Media>PhysicalMedias { get { return physicalMedias; } }

        private static List<Media> onlineMedias = new List<Media>();
        public static List<Media> OnlineMedias { get { return onlineMedias; } }

        public string Title { get; set; }
        
        public string Auth { get; set; }
        
        public string Type { get; set; }

        public string Url { get; set; }

        public string ImagePath { get; set; }

        public string Description { get; set; }
    }
}
