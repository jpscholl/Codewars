using System;

namespace Solution
{
    public partial class Kata
    {
        public static string DefineSuit(string card)
        {
            if (card.Contains("♣")) return "clubs";
            if (card.Contains("♠")) return "spades";
            if (card.Contains("♦")) return "diamonds";
            if (card.Contains("♥")) return "hearts";

            return null;
        }
    }
}
