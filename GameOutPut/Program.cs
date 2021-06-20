using System;
using Domain;

namespace GameOutPut
{
    public class Program
    {
        private readonly Ireopsitory<PlayerBasketData> repo;
        public Program(Ireopsitory<PlayerBasketData>repo)
        {
           
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            Program p = new Program();
            p.printBasketData();
        }
        public void printBasketData()
        {
            int data=repo.CalcPints();
            Console.WriteLine("basketBall  " + data);
        }
    }
}
