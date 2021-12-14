using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_last2.Model
{
    public class EmployeePublication
    {
        public int idEmployeePublicArticl { get; set; }
        public int IdEmlployee { get; set; }
        public int IdPublication { get; set; }
    }
}

//[IdEmployeePublicArticl] INT IDENTITY(1, 1) NOT NULL,

//   [IdEmlployee]            INT NOT NULL,

//   [IdPublication]          INT NOT NULL,