using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldCup2018.Models
{
    public class Player
    {
        private ICollection<Team> _teams;

        public Player()
        {
            _teams = new List<Team>();
        }

        public int PlayerId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Position { get; set; }

        public virtual ICollection<Team> Teams
        {
            get { return _teams; }
            set { _teams = value; }
        }
    }
}