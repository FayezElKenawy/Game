using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.BasketBall;

namespace Domain
{
    public class BasketRepository 
    {

        

        List<PlayerBasketData> data = new List<PlayerBasketData>();
        public IList<PlayerBasketData> ReturnBasketData()
        {
            data.Add(new PlayerBasketData { Id = "1", Name = "player1", Nickname = "P1", Team = "A", Position = BasketballPositions.C.ToString(), Number = "10", Scoredpoint = 7, Assist = 5, Rebound = 2 });
            data.Add(new PlayerBasketData { Id = "2", Name = "player2", Nickname = "P2", Team = "A", Position = BasketballPositions.G.ToString(), Number = "20", Scoredpoint = 9, Assist = 3, Rebound = 0});
            data.Add(new PlayerBasketData { Id = "3", Name = "player3", Nickname = "P3", Team = "A", Position = BasketballPositions.F.ToString(), Number = "30", Scoredpoint = 10, Assist = 0, Rebound = 2 });
            data.Add(new PlayerBasketData { Id = "4", Name = "player4", Nickname = "P4", Team = "B", Position = BasketballPositions.C.ToString(), Number = "1", Scoredpoint = 11, Assist = 1, Rebound = 2 });
            data.Add(new PlayerBasketData { Id = "5", Name = "player5", Nickname = "P5", Team = "B", Position = BasketballPositions.G.ToString(), Number = "2", Scoredpoint = 8, Assist = 0, Rebound = 2 });
            data.Add(new PlayerBasketData { Id = "6", Name = "player6", Nickname = "P6", Team = "B", Position = BasketballPositions.F.ToString(), Number = "3", Scoredpoint = 5, Assist = 5, Rebound = 0 });
            return data;
        }
      

        //calculate MVP depending on teams points 
        public int CalcMVP(List<Teams> list)
        {
            return 0;
        }


        //calculate teams points 
        public List<Teams> CalcPints()
        {
            List<int> Team1Points=new List<int>();
            List<int> Team2Points=new List<int>();
            //IList<PlayerBasketData> data = ReturnBasketData();
            foreach (var item in ReturnBasketData())
            {
                //calaculate points for all players depending on team name
                switch (item.Team)
                {
                    case "A":
                        //adding point of player to team point list 
                        Team1Points.Add(CalcPlayerPoints(item.Position,item.Scoredpoint,item.Assist,item.Rebound));
                        break;
                    case "B":
                        Team2Points.Add(CalcPlayerPoints(item.Position, item.Scoredpoint, item.Assist, item.Rebound));
                        break;
                }
            }
            //list of all teams points
            List<Teams> TeamsPoints = new List<Teams>();
            TeamsPoints.Add(new Teams { Name = "A", TotalPoints = Team1Points.Sum() });
            TeamsPoints.Add(new Teams { Name = "B", TotalPoints = Team2Points.Sum() });
            CalcMVP(TeamsPoints);//send data to calculate mvp team
            return TeamsPoints;
        }

        //claculate points for player depending on position
        public int CalcPlayerPoints(string position,int point,int assist,int rebound)
        {
            int playerpoint = 0;

            switch (position)
            {
                case "G":
                    playerpoint=  point * ratingpoints.G_Scoredpoint + assist * ratingpoints.G_Assist + rebound * ratingpoints.G_Rebound;
                    break;
                case "C":
                    playerpoint = point * ratingpoints.C_Scoredpoint + assist * ratingpoints.C_Assist + rebound * ratingpoints.C_Rebound;
                    break;
                case "F":
                    playerpoint = point * ratingpoints.F_Scoredpoint + assist * ratingpoints.F_Assist + rebound * ratingpoints.F_Rebound;
                    break;
                default:
                    break;
                   
            }
            return playerpoint;
        }
    }
}
