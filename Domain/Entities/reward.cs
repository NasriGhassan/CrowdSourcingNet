using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class reward
    {
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string itemName { get; set; }
        public int points { get; set; }
    }
}
