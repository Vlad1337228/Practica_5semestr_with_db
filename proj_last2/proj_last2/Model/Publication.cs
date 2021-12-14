using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_last2.Model
{
    public class Publication
    {
        public int Id { get; set; }
        public string Autors { get; set; }
        public string Article_title { get; set; }
        public string Subject_area { get; set; }
        public string Autors_keywords { get; set; }
        public string Type_db { get; set; }
        public int year { get; set; }

        public string WriterEmployee()
        {
            return $"{Id}, {Autors}, {Article_title}, {Subject_area}, {Autors_keywords}, {Type_db}, {year.ToString()}";
        }
    }
}
