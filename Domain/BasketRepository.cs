using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Domain
{
    public class BasketRepository : Ireopsitory<PlayerBasketData>
    {



        List<PlayerBasketData> data = new List<PlayerBasketData>();
        public IEnumerable<PlayerBasketData> ReturnBasketData()
        {
            data.Add(new PlayerBasketData { Id = "1", Name = "player1", Nickname = "P1", Team = "A", Position = BasketballPositions.C.ToString(), Number = "10", Scoredpoint = 10, Assist = 5, Rebound = 2 });
            data.Add(new PlayerBasketData { Id = "2", Name = "player2", Nickname = "P2", Team = "A", Position = BasketballPositions.G.ToString(), Number = "20", Scoredpoint = 10, Assist = 5, Rebound = 2 });
            data.Add(new PlayerBasketData { Id = "3", Name = "player3", Nickname = "P3", Team = "A", Position = BasketballPositions.F.ToString(), Number = "30", Scoredpoint = 10, Assist = 5, Rebound = 2 });
            data.Add(new PlayerBasketData { Id = "4", Name = "player4", Nickname = "P4", Team = "B", Position = BasketballPositions.C.ToString(), Number = "1", Scoredpoint = 10, Assist = 5, Rebound = 2 });
            data.Add(new PlayerBasketData { Id = "5", Name = "player5", Nickname = "P5", Team = "B", Position = BasketballPositions.G.ToString(), Number = "2", Scoredpoint = 10, Assist = 5, Rebound = 2 });
            data.Add(new PlayerBasketData { Id = "6", Name = "player6", Nickname = "P6", Team = "B", Position = BasketballPositions.F.ToString(), Number = "3", Scoredpoint = 10, Assist = 5, Rebound = 2 });
            return data;
        }
        public int CalcMVP()
        {
            IEnumerable<PlayerBasketData> BasketData = ReturnBasketData();
            foreach (var item in BasketData)
            {
                switch (item.Team)
                {
                    case "A":

                        break;
                }
            }
            return 0;
        }

        public int CalcPints()
        {
            throw new NotImplementedException();
        }
    }
}
