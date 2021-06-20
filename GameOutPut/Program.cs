using System;
using System.Collections.Generic;
using Domain;
using Domain.BasketBall;

namespace GameOutPut
{
    public class Program
    {
    
        
        static void Main(string[] args)
        {
            MVP r = new MVP();
            List<PlayerBasketData> winnerplayer = r.CalcMVP();
            Console.Write("BasketBall most Valuable Player =>  ");
            foreach (var item in winnerplayer)
            {
                Console.WriteLine(item.Name+"; "+item.Nickname+"; "+item.Number+"; "
                    +item.Team + "; " +item.Position + "; " +item.Scoredpoint + "; " +item.Rebound + "; " +item.Assist);
            }



        }

    }
}
