using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_last2.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string AcademicTitle { get; set; }
        public string AcadenicDegree { get; set; }
        public DateTime BirthDay { get; set; }

        public string WriterEmployee()
        {
            return $"{Id} , {FIO} , {AcademicTitle} , {AcadenicDegree} , {BirthDay.ToString()}";
        }
    }
}
