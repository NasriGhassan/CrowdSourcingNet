using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class user
    {
        public user()
        {
            this.chats = new List<chat>();
            this.chats1 = new List<chat>();
            this.comments = new List<comment>();
            this.histories = new List<history>();
            this.ideas = new List<idea>();
            this.rates = new List<rate>();
            this.reports = new List<report>();
            this.points = new List<point>();
        }

        public string DTYPE { get; set; }
        public int id { get; set; }
        public Nullable<System.DateTime> birthday { get; set; }
        public string email { get; set; }
        public bool gender { get; set; }
        public string login { get; set; }
        public string nickname { get; set; }
        public string nom { get; set; }
        public string password { get; set; }
        public string photo { get; set; }
        public string prenom { get; set; }
        public Nullable<bool> banned { get; set; }
        public Nullable<int> coffee_points { get; set; }
        public Nullable<int> exp { get; set; }
        public Nullable<int> level { get; set; }
        public Nullable<System.DateTime> registration { get; set; }
        public virtual ICollection<chat> chats { get; set; }
        public virtual ICollection<chat> chats1 { get; set; }
        public virtual ICollection<comment> comments { get; set; }
        public virtual ICollection<history> histories { get; set; }
        public virtual ICollection<idea> ideas { get; set; }
        public virtual ICollection<rate> rates { get; set; }
        public virtual ICollection<report> reports { get; set; }
        public virtual ICollection<point> points { get; set; }
    }
}
