using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsMultiAnswer { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }

        public Question()
        {
            this.Answers = new HashSet<Answer>();
        }
    }
}
