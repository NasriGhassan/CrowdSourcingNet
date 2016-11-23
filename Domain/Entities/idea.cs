using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class idea
    {
        public idea()
        {
            this.comments = new List<comment>();
            this.reports = new List<report>();
            this.rates = new List<rate>();
        }

        public int id { get; set; }
        public string content { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string subject { get; set; }
        public bool visibility { get; set; }
        public Nullable<int> category_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public virtual category category { get; set; }
        public virtual ICollection<comment> comments { get; set; }
        public virtual ICollection<report> reports { get; set; }
        public virtual ICollection<rate> rates { get; set; }
        public virtual user user { get; set; }
    }
}
