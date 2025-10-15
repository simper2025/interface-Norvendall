// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using Fractional;

var list = new List<RationalNumber>
{
    new RationalNumber(1,7),
    new RationalNumber(4,10),
    new RationalNumber(15,25),
    new RationalNumber(17,23),
    new RationalNumber(12,15),
};

RationalNumber threefifths = new RationalNumber(3, 5);
list.Add(threefifths);
int index = list.IndexOf(threefifths);
Console.WriteLine($"Found ${threefifths} at index {index}; size: {list.Count}");

list.Sort();
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i].ToString());
}
