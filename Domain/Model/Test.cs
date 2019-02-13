using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsPublic { get; set; }

        public virtual ICollection<Question> Questions { get; set; }

        public Test()
        {
            this.Questions = new HashSet<Question>();
        }
    }
}
