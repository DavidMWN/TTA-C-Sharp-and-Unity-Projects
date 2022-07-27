using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public struct Card
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        public override string ToString()
        {
            char faceSymbol = '0';

            switch (this.Suit)
            {
                case Suit.Clubs:
                    faceSymbol = '\u2660';
                    break;
                case Suit.Hearts:
                    faceSymbol = '\u2665';
                    break;
                case Suit.Diamonds:
                    faceSymbol = '\u2666';
                    break;
                case Suit.Spades:
                    faceSymbol = '\u2663';
                    break;
            }

            return string.Format(Face + " " + Char.ToString(faceSymbol));
        }
    }

    public enum Suit
    {
        Clubs,
        Hearts,
        Diamonds,
        Spades
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
