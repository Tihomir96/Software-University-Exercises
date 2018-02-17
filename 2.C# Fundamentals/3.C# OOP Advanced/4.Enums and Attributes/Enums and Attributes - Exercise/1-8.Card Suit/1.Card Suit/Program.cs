using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace _1.Card_Suit
{
    public class Program
    {
        public static void Main()
        {
            var player1 = Console.ReadLine();
            var player2 = Console.ReadLine();
            var player1Cards = new SortedSet<Card>();
            var player2Cards = new SortedSet<Card>();
            Card card = new Card();
            while (player1Cards.Count!=5)
            {
                var input = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
                try
                {
                    var cardSuit = (CardSuits) Enum.Parse(typeof(CardSuits), input[2]);
                    var cardRank = (CardRanks) Enum.Parse(typeof(CardRanks), input[0]);
                    
                    card = new Card(cardRank,cardSuit);
                    if (!player1Cards.Contains(card))
                    {
                        player1Cards.Add(card);
                    }
                    else
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("No such card exists.");
                }
                
            }
            
            while (player2Cards.Count != 5)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                try
                {
                    var cardSuit = (CardSuits)Enum.Parse(typeof(CardSuits), input[2]);
                    var cardRank = (CardRanks)Enum.Parse(typeof(CardRanks), input[0]);

                    card = new Card(cardRank, cardSuit);
                    if (!(player1Cards.Contains(card)) && !player2Cards.Contains(card))
                    {
                        player2Cards.Add(card);
                    }
                    else
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("No such card exists.");                    
                }
                
            }

            var player1BestCard = player1Cards.LastOrDefault();
            var player2BestCard = player2Cards.LastOrDefault();
            if (player1BestCard.CompareTo(player2BestCard) > 0)
            {
                Console.WriteLine($"{player1} wins with {player1BestCard.ToString()}");
            }
            
        }
    }
}
