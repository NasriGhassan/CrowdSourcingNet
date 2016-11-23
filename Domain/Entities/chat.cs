using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class chat
    {
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string message { get; set; }
        public Nullable<int> SourceUser_Id { get; set; }
        public Nullable<int> TargetUser_Id { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }
}
