using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Yanying Zhang
 * Date: July 25, 2017
 * Description: This is the Deck class
 * It inherits from the List generic and uses Card as the base
 * Version: 0.5 -- Added the deal1 method
 */
namespace COMP123_S2017_L11_01
{
    public class Deck : CardList
    {
        // PRIVATE INSTANCE VARIABLES
        private Random _random;

        // PRIVATE PROPERTITES
        private Random Random
        {
            get
            {
                return this._random;
            }
        }

        // PUBLIC PROPERTITES

        // CONSTRUCTORS

        // PRIVATE METHODS

        protected override void _initialize()
        {
            //initialize the presude-random nuMber generator
            this._random = new Random();

            //this builts the Desk, fills it with cards;
            for(int suit = (int)Suit.Clubs; suit<= (int)Suit.Spades; suit++)
            {
                for(int face = (int)Face.Ace; face<= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }
        }

        // PUBLIC METHODS
        public override string ToString()
        {
            string outputString = "";

            outputString += "Deck contains   Number of Cards:" + this.Count + "\n";
            outputString += "===================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }
            return outputString;
        }

        /// <summary>
        /// This method shuffles the deck by using random indices to select two cards at a time
        /// </summary>
        public void Shuffle()
        {
            int firstCard;
            int secondCard;
            Card tempCard;

            for (int card = 0; card < this.Count; card++)
            {
                firstCard = this.Random.Next(0,this.Count);
                secondCard = this.Random.Next(0, this.Count);

                tempCard = (Card)this[secondCard].Clone();

                Card.OverWrite(this[secondCard], this[firstCard]);
                Card.OverWrite(this[secondCard], this[firstCard]);

                //this[secondcard].face = this[firstcard].face;
                //this[secondcard].suit = this[firstcard].suit;
                //this[firstcard].face = tempcard.face;
                //this[firstcard].suit = tempcard.suit;
            }
        }

        /// <summary>
        /// this method returns the top card of the deck
        /// </summary>
        /// <returns></returns>
        public Card Deal1()
        {
            Card topCard = this[0];
            this.RemoveAt(0); // this removes the top card from the deck
            return topCard;
        }
    }
}