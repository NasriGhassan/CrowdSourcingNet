using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class point
    {
        public point()
        {
            this.users = new List<user>();
        }

        public int id { get; set; }
        public string achievement { get; set; }
        public string content { get; set; }
        public string icone { get; set; }
        public int points { get; set; }
        public virtual ICollection<user> users { get; set; }
    }
}
