using System;
using System.Linq;

namespace CardGame
{
    public static class Program
    {
        private static void Main()
        {
            var pack = new PackOfCardsCreator().Create();
            pack.Shuffle();

            Console.WriteLine("The first card is {0}", pack.Select(c => (c.Suit, c.Value)).First());

        }
    }
}
