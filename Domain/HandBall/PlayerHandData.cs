using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.HandBall
{
    public class PlayerHandData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Number { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }
        public int Goalsmade { get; set; }
        public int GoalReceived { get; set; }
        public int IntialRatingPoints { get; set; }

    }
}
