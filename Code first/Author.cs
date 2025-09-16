using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFD2.models
{
     public class Author
    {
        public int Id { get; set; }   
        public string Name { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime JoinDate { get; set; }

        public ICollection<News> NewsList { get; set; }

    }
}
