using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.HandBall;

namespace Domain.HandBall
{
    public class HandRepository 
    {

        


        //calculate teams points 
        public List<PlayerPoints> CalcHandPints(List<PlayerHandData> data)
        {
            List<PlayerPoints> Team1Points=new List<PlayerPoints>();
            //List<int> Team2Points=new List<int>();
            //IList<PlayerBasketData> data = ReturnBasketData();
            foreach (var item in data)
            {
                //calaculate points for all players depending on team name
                //switch (item.Team)
                //{
                //    case "A":
                        //adding point of player to team point list 
                        Team1Points.Add(new PlayerPoints {Name=item.Name, Points= CalcHandPlayerPoints(item.Position, item.IntialRatingPoints, item.Goalsmade, item.GoalReceived),Team=item.Team});
                    //    break;
                    //case "B":
                        //Team2Points.Add(CalcHandPlayerPoints(item.Position, item.IntialRatingPoints, item.Goalsmade, item.GoalReceived));
                //        break;
                //}
            }
            //list of all teams points
            //List<HandBallTeams> TeamsPoints = new List<HandBallTeams>();
            //TeamsPoints.Add(new HandBallTeams { Name = "A", TotalPoints = Team1Points.Sum() });
            //TeamsPoints.Add(new HandBallTeams { Name = "B", TotalPoints = Team2Points.Sum() });
            return Team1Points;
        }

        //claculate points for player depending on position
        public int CalcHandPlayerPoints(string position,int intialPoint,int goalMade,int goalReceved)
        {
            int playerpoint = 0;

            switch (position)
            {
                case "G":
                    playerpoint= intialPoint + goalMade * HandBallRatingPoints.G_Goalmade + goalReceved * HandBallRatingPoints.G_Goalreceived;
                    break;
                case "F":
                    playerpoint = intialPoint + goalMade * HandBallRatingPoints.F_Goalmade + goalReceved * HandBallRatingPoints.F_Goalreceived;
                    break;
                default:
                    break;
                   
            }
            return playerpoint;
        }
    }
}
