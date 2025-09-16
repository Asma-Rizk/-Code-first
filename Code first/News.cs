using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFD2.models
{
    public class News
    {
        public int Id { get; set; }   
        public string Title { get; set; }
        public string Bref { get; set; }
        public string Desc { get; set; }
        public string Time { get; set; }
        public DateTime Date { get; set; }

        // Foreign Keys
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int Cat_Id { get; set; }
        public Catalog Catalog { get; set; }

    }
}
