using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.BasketBall
{
    public class BasketballRepository 
    {





        //calculate teams points 
        public List<PlayerPoints> CalcPints(List<PlayerBasketData> Playersdata)
        {
            List<PlayerPoints> Team1Points=new List<PlayerPoints>();
            //List<PlayerPoints> Team2Points=new List<PlayerPoints>();
            //IList<PlayerBasketData> data = ReturnBasketData();
            foreach (var item in Playersdata)
            {
                //calaculate points for all players depending on team name
                //switch (item.Team)
                //{
                //    case "A":
                        //adding point of player to team point list 
                        Team1Points.Add(new PlayerPoints { Name=item.Name,Points= CalcPlayerPoints(item.Position, item.Scoredpoint, item.Assist, item.Rebound),Team=item.Team });
                    //    break;
                    //case "B":
              //        break;
                //}
            }
            //list of all teams points
            //List<BasketballTeams> TeamsPoints = new List<BasketballTeams>();
            //TeamsPoints.Add(new BasketballTeams { Name = "A", TotalPoints = Team1Points.Sum() });
            //TeamsPoints.Add(new BasketballTeams { Name = "B", TotalPoints = Team2Points.Sum() });
            
            return Team1Points;
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
        //claculate winner Team
        public string Winner(List<BasketballTeams> teams)
        {
            IEnumerable<BasketballTeams> d = teams;
            string winner = "";
            int max = int.MinValue;
            foreach (var item in teams)
            {
                if (item.TotalPoints>max)
                {
                    max = item.TotalPoints;
                }
            }
            winner =d.Single(c=>c.TotalPoints==max).Name ;
            return winner;
        }
    }
}
