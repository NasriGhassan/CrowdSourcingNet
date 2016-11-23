using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class rate
    {
        public string DTYPE { get; set; }
        public int id { get; set; }
        public bool visibility { get; set; }
        public Nullable<bool> review { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<int> comment_id { get; set; }
        public Nullable<int> idea_id { get; set; }
        public virtual comment comment { get; set; }
        public virtual idea idea { get; set; }
        public virtual user user { get; set; }
    }
}
