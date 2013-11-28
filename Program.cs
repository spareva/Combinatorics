using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static int[] coins = { 10, 20, 50, 100 };
    static int k = 3;
    static List<int[]> results = new List<int[]>();
    static int[] curCoins = new int[k];

    static void Combinations(int curIndex)
    {
        if (curIndex >= k)
        {
            //Console.WriteLine(curCoins[0] + " " + curCoins[1] + " " + curCoins[2]);
            //Console.WriteLine();
            results.Add(new int[] {curCoins[0], curCoins[1], curCoins[2]});            
            return;
        }
        for (int i = 0; i < coins.Length; i++)
        {
            curCoins[curIndex] = coins[i];
            Combinations(curIndex + 1);
        }
    }

    static void Print(List<int[]> results)
    {
        foreach (var arr in results)
        {
            foreach (var coin in arr)
            {
                if (coin.ToString().Length == 2)
                {
                    Console.Write(coin + "  ");
                }
                else
                {
                    Console.Write(coin + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Combinations(0);
        Print(results);
    }
}
