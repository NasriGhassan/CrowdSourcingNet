using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class report
    {
        public string DTYPE { get; set; }
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string status { get; set; }
        public Nullable<int> idea_id { get; set; }
        public Nullable<int> comment_id { get; set; }
        public Nullable<int> customer_id { get; set; }
        public virtual comment comment { get; set; }
        public virtual idea idea { get; set; }
        public virtual user user { get; set; }
    }
}
