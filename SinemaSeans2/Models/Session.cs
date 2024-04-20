using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaSeans2.Models
{
    public class Session
    {
        public int id { get; set; }
        public string date { get; set; }
        public string time { get; set; }

        public int movieId { get; set; }
        public int theaterId { get; set; }
    }
}
