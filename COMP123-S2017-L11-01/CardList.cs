using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Yanying Zhang
 * Date: July 27, 2017
 * Description: This is the abstract superclass CardList
 * Version: 0.1 -- create the CardList abstract supercalss
 */
namespace COMP123_S2017_L11_01
{
    public abstract class CardList : List<Card>
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTITES

        // CONSTRUCTORS

        /// <summary>
        /// This is the initialize methods
        /// </summary>
        public CardList()
        {
            this._initialize();
        }
        // PRIVATE METHODS
        protected abstract void _initialize();
        // PUBLIC METHODS
    }
}