using Berek;
using System;
using System.Linq;
using System.Threading.Channels;

List<Dolgozok> dolgozo = new List<Dolgozok>();
using StreamReader sr = new StreamReader(@"..\..\..\src\berek2020.txt");

_ = sr.ReadLine();


while (!sr.EndOfStream) dolgozo.Add(new(sr.ReadLine()));


//kezdés 9:55 vége 10:36!!

//3 
Console.WriteLine($"1.feladat: {dolgozo.Count} db");

//4
var berek2020 = dolgozo.Average(x => x.Fizetes);
Console.WriteLine($"2. feladat: {berek2020:0000.0}forint");

//5
Console.WriteLine("Adjon meg egy részleg nevet:");
string reszlegtarolas = Console.ReadLine();

//6 
var reszlegek = dolgozo
    .Where(x => x.Reszleg.Equals(reszlegtarolas))
    .OrderByDescending(x => x.Fizetes)
    .FirstOrDefault(); 

Console.WriteLine(reszlegek != null
    ? $"6. feladat: {reszlegek.ToString()}"
    : "6. feladat: A megadott részleg nem létezik a cégnél!");

//7
var statisztika = dolgozo.GroupBy(x => x.Reszleg);
foreach (var csoport in statisztika)
{
    Console.WriteLine($"Részleg: {csoport.Key}, Dolgozók száma: {csoport.Count()}");
}

//kezdés 9:55 vége 10:36!!