using System;

namespace DSA
{
    public class EntryPoint
    {
        
    Dictionary<char, Dictionary<string, int>> CARDS_DICT = new Dictionary<char, Dictionary<string, int>>()
    {
        {'J', new Dictionary<string, int>(){{"points", 3}, {"order", 8}}},
        {'9', new Dictionary<string, int>(){{"points", 2}, {"order", 7}}},
        {'1', new Dictionary<string, int>(){{"points", 1}, {"order", 6}}},
        {'T', new Dictionary<string, int>(){{"points", 1}, {"order", 5}}},
        {'K', new Dictionary<string, int>(){{"points", 0}, {"order", 4}}},
        {'Q', new Dictionary<string, int>(){{"points", 0}, {"order", 3}}},
        {'8', new Dictionary<string, int>(){{"points", 0}, {"order", 2}}},
        {'7', new Dictionary<string, int>(){{"points", 0}, {"order", 1}}},
    };

    Dictionary<string, int> getCardInfo(string card)
    {
        return CARDS_DICT[getRank(card)];
    }

    private char getRank(string card)
    {
        return card[0];
    }

    private char getSuit(string card)
    {
        return card[1];
    }
    bool isHigh(string highestCard, string compareCard, char trumpSuit='X')
    {
        bool isHighestCardTrump = getSuit(highestCard) == trumpSuit;
        bool isCompareCardTrump = getSuit(compareCard) == trumpSuit;

        if (trumpSuit != 'X' && isHighestCardTrump && !isCompareCardTrump)
        {
            System.Console.WriteLine("HERE");
            return true;
        }
        if (trumpSuit != 'X' && !isHighestCardTrump && isCompareCardTrump)
        {
            return false;
        }

        // if both have similar suit, we could just check the points with order
        if (getSuit(highestCard) == getSuit(compareCard))
        {
            var high = getCardInfo(highestCard);
            var compare = getCardInfo(compareCard);

            return high["points"] >= compare["points"] && high["order"] > compare["order"];
        }

        return false;
    }


        public static void Main()
        {
            // Console.WriteLine("Hello World !!");
            // Recursion.countToN(100);
            // System.Console.WriteLine(Recursion.sumUpToN(5));
            // System.Console.WriteLine(Recursion.Fibonacci(10));
            // Recursion.printArrayElements(new int[]{1, 2, 3, 4, 5});
            // System.Console.WriteLine(Recursion.countDigits(123456));
            // System.Console.WriteLine(Recursion.sumOfDigits(271));
            // System.Console.WriteLine(Recursion.GCD(10, 50));
            // System.Console.WriteLine(Recursion.getLargestElement(new int[]{1, 2, 3, 4, 5, -7, 30, -55, 33, 4}));
            // System.Console.WriteLine(Recursion.reverseString("PRABAS"));
            // System.Console.WriteLine(Recursion.factorial(5));
            // System.Console.WriteLine(Recursion.binaryToDecimal(66));
            // System.Console.WriteLine(Recursion.isPrime(72));
            // System.Console.WriteLine(Recursion.LCM(12, 18));
            // EntryPoint p= new EntryPoint();
            // System.Console.WriteLine(p.isHigh("JS", "TS"));

            Recursion.printNum(0, 100, "even");
            



            System.Console.WriteLine("\n");
        }
    }
}