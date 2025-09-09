using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Stone_Evan
{
    internal class Card
    {

        public string Number { get; } //creates the string Number

        public string Suit { get; } //creates the string Suit

        //creates the new object Card with numParam = Number, and suitParam = Suit
        public Card(string numParam, string suitParam)
        {
            Number = numParam;
            Suit = suitParam;
        }

    }
}
