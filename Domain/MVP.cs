using System.Collections.Generic;
using System.Linq;
using Domain.BasketBall;
using Domain.HandBall;

namespace Domain
{
    public class MVP
    {

        #region basketball
        BasketballRepository Brepo = new BasketballRepository();
        List<PlayerBasketData> Basketballdata = new List<PlayerBasketData>();
        public List<PlayerBasketData> ReturnBasketData()//source data
        {
            Basketballdata.Add(new PlayerBasketData { Id = "1", Name = "player1", Nickname = "P1", Team = "A", Position = BasketballPositions.C.ToString(), Number = "10", Scoredpoint = 7, Assist = 5, Rebound = 2 });
            Basketballdata.Add(new PlayerBasketData { Id = "2", Name = "player2", Nickname = "P2", Team = "A", Position = BasketballPositions.G.ToString(), Number = "20", Scoredpoint = 9, Assist = 3, Rebound = 0 });
            Basketballdata.Add(new PlayerBasketData { Id = "3", Name = "player3", Nickname = "P3", Team = "A", Position = BasketballPositions.F.ToString(), Number = "30", Scoredpoint = 10, Assist = 10, Rebound = 2 });
            Basketballdata.Add(new PlayerBasketData { Id = "4", Name = "player4", Nickname = "P4", Team = "B", Position = BasketballPositions.C.ToString(), Number = "1", Scoredpoint = 22, Assist = 6, Rebound = 2 });
            Basketballdata.Add(new PlayerBasketData { Id = "5", Name = "player5", Nickname = "P5", Team = "B", Position = BasketballPositions.G.ToString(), Number = "2", Scoredpoint = 1, Assist = 0, Rebound = 2 });
            Basketballdata.Add(new PlayerBasketData { Id = "6", Name = "player6", Nickname = "P6", Team = "B", Position = BasketballPositions.F.ToString(), Number = "3", Scoredpoint = 1, Assist = 0, Rebound = 0 });
            return Basketballdata;
        }


        //calculate MVP depending on teams points 
        public List<PlayerBasketData> CalcBasketMVP()//returning The MVP Info
        {
            List<PlayerBasketData> playersData = ReturnBasketData();//data from source
            List<PlayerPoints> playerspoints = Brepo.CalcPints(playersData);//return total points of players
            string winnerTeam = WinnerTeam(playerspoints);//the winner team
            string TheMVPNAme = TheMVP(playerspoints, winnerTeam);
            List<PlayerBasketData> TheMVPInfo = MVPInfo(TheMVPNAme);
            return TheMVPInfo;
        }
        public string WinnerTeam(List<PlayerPoints> data)//return the name of the winner team depending on total points
        {
            int A_sum = 0;
            int B_sum = 0;
            //List<PlayerPoints> A_TeamPoints = new List<PlayerPoints>(); ;
            //List<PlayerPoints> B_TeamPoints=new List<PlayerPoints>();
            foreach (var item in data)
            {
                switch (item.Team)
                {
                    case "A":
                        A_sum += item.Points;
                        //A_TeamPoints.Add(new PlayerPoints { Name = item.Name, Points =item.Points , Team = item.Team });
                        break;
                    case "B":
                        B_sum += item.Points;
                        //B_TeamPoints.Add(new PlayerPoints { Name = item.Name, Points = item.Points, Team = item.Team });
                        break;
                    default:
                        break;
                }
            }
            if (A_sum>B_sum)
            {
                return "A";
            }
            return "B";
        }
        public List<PlayerBasketData> MVPInfo(string winnerName)
        {
            List<PlayerBasketData> player = new List<PlayerBasketData>();
            foreach (var item in ReturnBasketData())
            {
                if (item.Name == winnerName)
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

        #region Handball
        List<PlayerHandData> Handballdata = new List<PlayerHandData>();
        HandRepository Hrepo = new HandRepository();
        public List<PlayerHandData> ReturnHandData()
        {
            Handballdata.Add(new PlayerHandData { Id = "1", Name = "player1", Nickname = "P1", Team = "A", Position = HandballPositions.G.ToString(), Number = "20", IntialRatingPoints = HandBallRatingPoints.G_Initialratingpoints, Goalsmade = 20, GoalReceived = 0 });
            Handballdata.Add(new PlayerHandData { Id = "2", Name = "player2", Nickname = "P2", Team = "A", Position = HandballPositions.F.ToString(), Number = "30", IntialRatingPoints = HandBallRatingPoints.F_Initialratingpoints, Goalsmade = 0, GoalReceived = 2 });
            Handballdata.Add(new PlayerHandData { Id = "3", Name = "player3", Nickname = "P3", Team = "B", Position = HandballPositions.G.ToString(), Number = "2", IntialRatingPoints = HandBallRatingPoints.G_Initialratingpoints, Goalsmade = 15, GoalReceived = 0 });
            Handballdata.Add(new PlayerHandData { Id = "4", Name = "player4", Nickname = "P4", Team = "B", Position = HandballPositions.F.ToString(), Number = "3", IntialRatingPoints = HandBallRatingPoints.F_Initialratingpoints, Goalsmade = 5, GoalReceived = 0 });
            return Handballdata;
        }


        //calculate MVP depending on teams points 
        public int CalcMVP(List<HandBallTeams> list)
        {
            return 0;
        }


        //calculate MVP depending on teams points 
        public List<PlayerHandData> CalcHandMVP()//returning The MVP Info
        {
            List<PlayerHandData> playersData = ReturnHandData();//data from source
            List<PlayerPoints> playerspoints = Hrepo.CalcHandPints(playersData);//return total points of players
            string winnerTeam = HandballWinnerTeam(playerspoints);//the winner team
            string TheMVPNAme = TheMVP(playerspoints, winnerTeam);
            List<PlayerHandData> TheMVPInfo = HandballMVPInfo(TheMVPNAme);
            return TheMVPInfo;
        }
        public string HandballWinnerTeam(List<PlayerPoints> data)//return the name of the winner team depending on total points
        {
            int A_sum = 0;
            int B_sum = 0;
            //List<PlayerPoints> A_TeamPoints = new List<PlayerPoints>(); ;
            //List<PlayerPoints> B_TeamPoints=new List<PlayerPoints>();
            foreach (var item in data)
            {
                switch (item.Team)
                {
                    case "A":
                        A_sum += item.Points;
                        //A_TeamPoints.Add(new PlayerPoints { Name = item.Name, Points =item.Points , Team = item.Team });
                        break;
                    case "B":
                        B_sum += item.Points;
                        //B_TeamPoints.Add(new PlayerPoints { Name = item.Name, Points = item.Points, Team = item.Team });
                        break;
                    default:
                        break;
                }
            }
            if (A_sum > B_sum)
            {
                return "A";
            }
            return "B";
        }
        public List<PlayerHandData> HandballMVPInfo(string winnerName)
        {
            List<PlayerHandData> player = new List<PlayerHandData>();
            foreach (var item in ReturnHandData())
            {
                if (item.Name == winnerName)
                {
                    player.Add(new PlayerHandData
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Team = item.Team,
                        Number = item.Number,
                        Nickname = item.Nickname,
                        IntialRatingPoints = item.IntialRatingPoints,
                        Position = item.Position,
                        GoalReceived = item.GoalReceived,
                        Goalsmade = item.Goalsmade
                    });
                    break;
                }
            }
            return player;
        }
        #endregion
        #region public
        public string TheMVP(List<PlayerPoints> data, string winnerTeam)//getting the MVP name
        {


            int max = int.MinValue;
            foreach (var item in data)//getting the max points value
            {
                if (item.Points > max)
                {
                    max = item.Points;
                }
            }
            var winner = data.Single(c => c.Points == max).Name;

            return winner;
        }
    }
    #endregion
}
