using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldCup2018.Models
{
    public class Team
    {
        private ICollection<Player> _players;

        public Team()
        {
            _players = new List<Player>();
        }

        public int TeamId { get; set; }

        public string Name { get; set; }

        public int Manager { get; set; }


        public virtual ICollection<Player> Players
        {
            get { return _players; }
            set { _players = value; }
        }
    }
}