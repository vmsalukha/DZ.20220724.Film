using System.Collections.Generic;

namespace DZ._20220724.Film.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Produser { get; set; }
        public string Style { get; set; }
        public string ShortDescription { get; set; }
        public List<string> SessionList { get; set; }

    }
}
