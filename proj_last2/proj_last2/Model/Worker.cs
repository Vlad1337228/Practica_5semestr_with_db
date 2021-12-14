using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_last2.Model
{
    public class Worker
    {
        public int id { get; set; }
        public string surName { get; set; }
        public string name { get; set; }
        public string patronimyc { get; set; }
        public string password { get; set; }
        public string login { get; set; }
    }
}
//CREATE TABLE[dbo].[Worker] (

//   [IdWorker]   INT IDENTITY(1, 1) NOT NULL,

//[Surname]    NVARCHAR (20) NOT NULL,

//[Name]       NVARCHAR (20) NOT NULL,

//[Patronymic] NVARCHAR (20) NULL,
//    [Password]   NVARCHAR (50) NOT NULL,
//    [Login]      NVARCHAR (50) NOT NULL,
//    PRIMARY KEY CLUSTERED ([IdWorker] ASC)
//);