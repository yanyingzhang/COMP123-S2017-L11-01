using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Yanying Zhang
 * Date: July 25, 2017
 * Description: This is the Deck class
 * It inherits from the List generic and uses Card as the base
 * Version: 0.2 -- implemented the Iclonoeable interface
 */
namespace COMP123_S2017_L11_01
{
    public class Deck : List<Card>
    {
        // PRIVATE INSTANCE VARIABLES
        private Random _random;
        private Face _face;

        // PRIVATE PROPERTITES
        private Random Random
        {
            get
            {
                return this._random;
            }
        }

        // CONSTRUCTORS
        /// <summary>
        /// This is the initialize methods
        /// </summary>
        public Deck()
        {
            this._initialize();
        }
        // PRIVATE METHODS

        private void _initialize()
        {
            //initialize the presude random nunber generator
            this._random = new Random();

            //this builts the Desk, fulls it with cards;

            for(int suit = (int)(Suit.Clubs); suit<= (int)Suit.Spades; suit++)
            {
                for(int face = (int)(Face.Ace); face<= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }
        }

        // PUBLIC METHODS



        public override string ToString()
        {
            string outputString = "";
            foreach(Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }
            return outputString;
        }

        /// <summary>
        /// This method shuffles the deck by using random indices 
        /// </summary>
        public void Shuffle()
        {
            int firstCard;
            int secondCard;
            Card tempCard;

            for (int card = 0; card < this.Count; card++)
            {
                firstCard = this.Random.Next(0,52);
                secondCard = this.Random.Next(0, 52);

                tempCard = (Card)this[secondCard].Clone();
                Card.Overwrite(this[secondCard], this[firstCard]);
                Face.Overwrite(this[secondCard], this[firstCard]);

                this[secondCard].Face = this[firstCard].Face;
                this[secondCard].Suit = this[firstCard].Suit;
                this[firstCard].Face = tempCard.Face;
                this[firstCard].Suit = tempCard.Suit;
            }
        }




    }
}