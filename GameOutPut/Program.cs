using System;
using System.Collections.Generic;
using Domain;
using Domain.BasketBall;
using Domain.HandBall;

namespace GameOutPut
{
    public class Program
    {
    
        
        static void Main(string[] args)
        {
            MVP r = new MVP();

            //printing basket info
            List<PlayerBasketData> basketwinnerplayer = r.CalcBasketMVP();
            Console.Write("BasketBall most Valuable Player =>  ");
            foreach (var item in basketwinnerplayer)
            {
                Console.WriteLine(item.Name+"; "+item.Nickname+"; "+item.Number+"; "
                    +item.Team + "; " +item.Position + "; " +item.Scoredpoint + "; " +item.Rebound + "; " +item.Assist);
            }

            Console.WriteLine("************************************************");
            //printing hand info
            List<PlayerHandData> Handwinnerplayer = r.CalcHandMVP();
            Console.Write("Handball most Valuable Player =>  ");
            foreach (var item in Handwinnerplayer)
            {
                Console.WriteLine(item.Name + "; " + item.Nickname + "; " + item.Number + "; "
                    + item.Team + "; " + item.Position + "; " + item.Goalsmade + "; " + item.GoalReceived);
            }


        }

    }
}
