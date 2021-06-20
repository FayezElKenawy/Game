using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.BasketBall;
using Domain.HandBall;

namespace Domain
{
    public class MVP
    {

        #region basketball
        BasketballRepository repo = new BasketballRepository();
        List<PlayerBasketData> data = new List<PlayerBasketData>();
        public List<PlayerBasketData> ReturnBasketData()
        {
            data.Add(new PlayerBasketData { Id = "1", Name = "player1", Nickname = "P1", Team = "A", Position = BasketballPositions.C.ToString(), Number = "10", Scoredpoint = 7, Assist = 5, Rebound = 2 });
            data.Add(new PlayerBasketData { Id = "2", Name = "player2", Nickname = "P2", Team = "A", Position = BasketballPositions.G.ToString(), Number = "20", Scoredpoint = 9, Assist = 3, Rebound = 0 });
            data.Add(new PlayerBasketData { Id = "3", Name = "player3", Nickname = "P3", Team = "A", Position = BasketballPositions.F.ToString(), Number = "30", Scoredpoint = 10, Assist = 10, Rebound = 2 });
            data.Add(new PlayerBasketData { Id = "4", Name = "player4", Nickname = "P4", Team = "B", Position = BasketballPositions.C.ToString(), Number = "1", Scoredpoint = 11, Assist = 1, Rebound = 2 });
            data.Add(new PlayerBasketData { Id = "5", Name = "player5", Nickname = "P5", Team = "B", Position = BasketballPositions.G.ToString(), Number = "2", Scoredpoint = 8, Assist = 0, Rebound = 2 });
            data.Add(new PlayerBasketData { Id = "6", Name = "player6", Nickname = "P6", Team = "B", Position = BasketballPositions.F.ToString(), Number = "3", Scoredpoint = 5, Assist = 5, Rebound = 0 });
            return data;
        }


        //calculate MVP depending on teams points 
        public List<PlayerBasketData> CalcMVP()
        {
            List<PlayerBasketData> playersData = ReturnBasketData();//data from source
            List<PlayerPoints> playerspoints = repo.CalcPints(playersData);//return total points of players
            List<PlayerPoints> winnerPlayer = Winner(playerspoints);//the winner team

            
            return TheMVP(winnerPlayer);
        }
        public List<PlayerPoints> Winner(List<PlayerPoints> data)//return the name of the winner team depending on total points
        {
            int A_sum = 0;
            int B_sum = 0;
            List<PlayerPoints> A_TeamPoints = new List<PlayerPoints>(); ;
            List<PlayerPoints> B_TeamPoints=new List<PlayerPoints>();
            foreach (var item in data)
            {
                switch (item.Team)
                {
                    case "A":
                        A_sum += item.Points;
                        A_TeamPoints.Add(new PlayerPoints { Name = item.Name, Points =item.Points , Team = item.Team });
                        break;
                    case "B":
                        B_sum += item.Points;
                        B_TeamPoints.Add(new PlayerPoints { Name = item.Name, Points = item.Points, Team = item.Team });
                        break;
                    default:
                        break;
                }
            }
            if (A_sum > B_sum)
            {
                return A_TeamPoints;
            }
            return B_TeamPoints;
        }
        public List<PlayerBasketData> TheMVP(List<PlayerPoints> data)
        {
            List<PlayerBasketData> player = new List<PlayerBasketData>();
            int max = int.MinValue;
            foreach (var item in data)
            {
                if (item.Points > max)
                {
                    max = item.Points;
                }
            }
           var winner= data.Single(c => c.Points == max).Name;
            foreach (var item in ReturnBasketData())
            {
                if (item.Name==winner)
                {
                    player.Add(new PlayerBasketData
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Team = item.Team,
                        Number = item.Number,
                        Nickname = item.Nickname,
                        Assist = item.Assist,
                        Position = item.Position,
                        Rebound = item.Rebound,
                        Scoredpoint = item.Scoredpoint
                    });
                    break;
                }
            }
            return player;
        }
        #endregion
    }
}
