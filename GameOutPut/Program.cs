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
            BasketRepository r = new BasketRepository();
            List<Teams> list = r.CalcPints();
            foreach (var item in list)
            {
                Console.WriteLine("Team Name : "+item.Name);
                Console.WriteLine("Team Points : " + item.TotalPoints);
            }
            
           

        }

    }
}
