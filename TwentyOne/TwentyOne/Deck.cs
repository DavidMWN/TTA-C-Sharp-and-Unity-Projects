using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }

            //List<char> Suits = new List<char> { '\u2660', '\u2665', '\u2666', '\u2663' }; // clubs, hearts, diamonds, spades
            //List<string> Faces = new List<string>
            //{
            //    "2 ", "3 ", "4 ", "5 ", "6 ", "7 ", "8 ", "9 ", "10", "J ", "Q ", "K ", "A "
            //};

            //foreach (string face in Faces)
            //{
            //    foreach (char suit in Suits)
            //    {
            //        Card card = new Card();
            //        card.Suit = suit;
            //        card.Face = face;
            //        Cards.Add(card);
            //    }
            //}
        }

        public List<Card> Cards { get; set; }

        public void shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    //Picks a random card in the deck
                    TempList.Add(Cards[randomIndex]);
                    //Adds that card to the temp (shuffled) deck
                    Cards.RemoveAt(randomIndex);
                    //Removes that card from the original deck
                }

                Cards = TempList;
            }
        }       
    }
}
