using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Yanying Zhang
 * Date: July 25, 2017
 * Description: This is a demo for lesson 11
 * Version: 0.2 -- Tested the new Deck class
 */
namespace COMP123_S2017_L11_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Hand hand = new Hand();

            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine("Shuffled Deck    Number of Cards:" + deck.Count);
            Console.WriteLine("===================================");
            Console.WriteLine(deck.ToString());

            hand.Add(deck.Deal1());
            Console.WriteLine(hand.ToString());
            Console.WriteLine();
            Console.WriteLine(deck.ToString());

            // hand = deck.Dual5(); // moves the top 5 cards from the deck
            Console.WriteLine(deck.Deal5());
            Console.WriteLine();
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            
        }
    }
}
