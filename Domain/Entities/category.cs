using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class category
    {
        public category()
        {
            this.ideas = new List<idea>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<idea> ideas { get; set; }
    }
}
