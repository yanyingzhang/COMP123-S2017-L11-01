using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Yanying Zhang
 * Date: July 25, 2017
 * Description: This is a demo for lesson 11
 * Version: 0.1 -- create the project
 */
namespace COMP123_S2017_L11_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine("Shuffled Deck    Number of Cards:" + deck.Count);
            Console.WriteLine("===================================");
            Console.WriteLine(deck.ToString());
        }
    }
}
