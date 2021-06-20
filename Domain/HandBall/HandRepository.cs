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

        

        List<PlayerHandData> data = new List<PlayerHandData>();
        public IList<PlayerHandData> ReturnHandData()
        {
            data.Add(new PlayerHandData { Id = "1", Name = "player1", Nickname = "P1", Team = "A", Position = HandballPositions.G.ToString(), Number = "20", IntialRatingPoints = HandBallRatingPoints.G_Initialratingpoints, Goalsmade = 3, GoalReceived = 0});
            data.Add(new PlayerHandData { Id = "2", Name = "player2", Nickname = "P2", Team = "A", Position = HandballPositions.F.ToString(), Number = "30", IntialRatingPoints = HandBallRatingPoints.F_Initialratingpoints, Goalsmade = 0, GoalReceived = 2 });
            data.Add(new PlayerHandData { Id = "3", Name = "player3", Nickname = "P3", Team = "B", Position = HandballPositions.G.ToString(), Number = "2", IntialRatingPoints = HandBallRatingPoints.G_Initialratingpoints, Goalsmade = 0, GoalReceived = 2 });
            data.Add(new PlayerHandData { Id = "4", Name = "player4", Nickname = "P4", Team = "B", Position = HandballPositions.F.ToString(), Number = "3", IntialRatingPoints = HandBallRatingPoints.F_Initialratingpoints, Goalsmade = 5, GoalReceived = 0 });
            return data;
        }
      

        //calculate MVP depending on teams points 
        public int CalcMVP(List<HandBallTeams> list)
        {
            return 0;
        }


        //calculate teams points 
        public List<HandBallTeams> CalcHandPints()
        {
            List<int> Team1Points=new List<int>();
            List<int> Team2Points=new List<int>();
            //IList<PlayerBasketData> data = ReturnBasketData();
            foreach (var item in ReturnHandData())
            {
                //calaculate points for all players depending on team name
                switch (item.Team)
                {
                    case "A":
                        //adding point of player to team point list 
                        Team1Points.Add(CalcHandPlayerPoints(item.Position,item.IntialRatingPoints,item.Goalsmade,item.GoalReceived));
                        break;
                    case "B":
                        Team2Points.Add(CalcHandPlayerPoints(item.Position, item.IntialRatingPoints, item.Goalsmade, item.GoalReceived));
                        break;
                }
            }
            //list of all teams points
            List<HandBallTeams> TeamsPoints = new List<HandBallTeams>();
            TeamsPoints.Add(new HandBallTeams { Name = "A", TotalPoints = Team1Points.Sum() });
            TeamsPoints.Add(new HandBallTeams { Name = "B", TotalPoints = Team2Points.Sum() });
            CalcMVP(TeamsPoints);//send data to calculate mvp team
            return TeamsPoints;
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
