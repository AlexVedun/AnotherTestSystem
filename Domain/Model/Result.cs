using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Result
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
        public Test Test { get; set; }
        public bool IsPass { get; set; }
        public int RightAnswers { get; set; }
    }
}
