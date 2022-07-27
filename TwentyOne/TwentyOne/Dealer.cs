using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            //Adds the first card in the deck to the player's hand

            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);

            using (StreamWriter file = new StreamWriter(@"C:\Users\\DavidN\Desktop\Basic_C#_Programs\TwentyOne\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }

            Deck.Cards.RemoveAt(0);
            //Removes the dealt card from the deck
        }
    }
}
