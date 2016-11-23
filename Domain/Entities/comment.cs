using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class comment
    {
        public comment()
        {
            this.rates = new List<rate>();
            this.reports = new List<report>();
        }

        public int id { get; set; }
        public string content { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public bool visibility { get; set; }
        public Nullable<int> idea_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public virtual ICollection<rate> rates { get; set; }
        public virtual ICollection<report> reports { get; set; }
        public virtual idea idea { get; set; }
        public virtual user user { get; set; }
    }
}
