using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books_API.Data.ViewModels
{
    public class BookVM
    {
        public string Title { get; set; }
        public string Describtion { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Ganre { get; set; }
        public string Author { get; set; }
        public string CoverUrl { get; set; }

    }
}
