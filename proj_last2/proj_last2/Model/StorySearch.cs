using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_last2.Model
{
    public class StorySearch
    {
        public int IdSearch { get; set; }
        public int IdWorker { get; set; }
        public DateTime DateTime { get; set; }
        public string Filters { get; set; }
    }
}
