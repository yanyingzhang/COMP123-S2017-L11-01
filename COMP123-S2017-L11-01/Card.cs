using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Yanying Zhang
 * Date: July 25, 2017
 * Description: This is the face enum
 * Version: 0.1 -- added Card class
 */
namespace COMP123_S2017_L11_01
{
    public class Card
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
        // CONSTRUCTORS
        /// <summary>
        /// This is the main constructors
        /// It take two arguments - face(face), suit(Suit)
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        public Card(Face face, Suit suit)
        {
            this._face = Face;
            this._suit = suit;
        }
        // PRIVATE METHODS
        // PUBLIC METHODS
    }
}