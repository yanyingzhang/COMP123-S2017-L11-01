using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Yanying Zhang
 * Date: July 25, 2017
 * Description: This is the Card class
 * Version: 0.2 -- Implemented the IClonable interface
 *                  Added the OverWrite method
 */
namespace COMP123_S2017_L11_01
{
    public class Card : ICloneable
    {
        // PRIVATE INSTANCE VARIABLES
        private Face _face;
        private Suit _suit;
        
        // PUBLIC PROPERTITES
        public Face Face {
            get
            {
                return this._face;
            }
            set
            {
                this._face = value;
            }
        }

        public Suit Suit
        {
            get
            {
                return this._suit;
            }
            set
            {
                this._suit = value;
            }
        }

        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructors
        /// It takes two arguments - face(face), suit(Suit)
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        public Card(Face face, Suit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
        // PRIVATE METHODS
        // PUBLIC METHODS

            /// <summary>
            /// This method overrides the built-in Clone method
            /// </summary>
            /// <returns></returns>
        public object Clone()
        {
            return new Card(this.Face, this.Suit);
        }

        public static void OverWrite(Card first, Card second)
        {
            first.Face = second.Face;
            first.Suit = second.Suit;
        }
    }
}