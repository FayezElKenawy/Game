using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PlayerBasketData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Number { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }
        public int Scoredpoint { get; set; }
        public int Rebound { get; set; }
        public int Assist { get; set; }

    }
}
