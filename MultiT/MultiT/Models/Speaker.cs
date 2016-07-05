using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiT.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageURL { get; set; }
        public string WebSite { get; set; }
        public string Bio { get; set; }
        public bool AllowHTML { get; set; }
        public int PictureId { get; set; }

        public List<Session> Sessions { get; set; }


    }
}