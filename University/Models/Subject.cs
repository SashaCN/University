using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
    public struct Subject
    {
        public string Name { get; set; }
        public double ExamMark { get; set; }

        public Subject (string name)
        {  
            Name = name; 
            ExamMark = 0;
        } 
    }
}
