using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class history
    {
        public int id { get; set; }
        public string content { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> user_id { get; set; }
        public virtual user user { get; set; }
    }
}
