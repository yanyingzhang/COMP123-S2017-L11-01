﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Yanying Zhang
 * Date: July 27, 2017
 * Description: This is the Hand class which inherited from CardList
 * Version: 0.3 -- Added HighestCards method
 */
namespace COMP123_S2017_L11_01
{
    public class Hand : CardList
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTITES
        
        // CONSTRUCTORS

        // PRIVATTE METHODS
        protected override void _initialize()
        {
            // this method is empty
        }

        // PUBLIC METHODS
        public override string ToString()
        {
            string outputString = "";

            outputString += "Hand contains   Number of Cards:" + this.Count + "\n";
            outputString += "************************************\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }
            return outputString;
        }

        public void HighestCards(Hand hand)
        {
            var cards =
                from card in hand
                orderby card.Face descending
                select card;

            var cardsFace =
                from card in hand
                orderby card.Face descending
                select card.Face;


        }
        
    }
}