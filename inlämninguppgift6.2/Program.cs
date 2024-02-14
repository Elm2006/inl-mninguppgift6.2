using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv in ett tal");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Skriv in ett tal");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(Störst(a,b)+" är det största talet");
    }
    static int Störst(int x, int y)
    {
        if(x>=y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }
}