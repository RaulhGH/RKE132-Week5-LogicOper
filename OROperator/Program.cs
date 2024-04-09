// Math >=90 OR || Chem>=90

// m ja c || m ja b || c ja b

using System;
using System.Net;
int math, biol, chem;
Console.WriteLine("Sisesta Matemaatika tulemus:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sisesta Bioloogia tulemus:");
biol = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sisesta Keemia tulemus:");
chem = Int32.Parse(Console.ReadLine());

if ((math >= 90 && biol >= 90)||(math >= 90&& biol>=90)|| (chem>=90&&biol>=90))
{
    Console.WriteLine("said sisse");
}
else
{
    Console.WriteLine("Proovi uuesti");

}