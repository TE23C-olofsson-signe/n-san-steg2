
// gör en lista med fem leksaker: 
using System.Text;

List<string> toys = ["Harry Potter lego", "Star Wars lego", "Lego Friends", "Teknik lego", "Barbie docka"];

// // // skriv in listan från förra uppgiften i en for loop: 

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(toys[i]);

}

// // // skapa en lista med 5 klasskamraters namn i: 
List<string> names = ["Matthias", "Dac", "Wing", "Eden", "Jasmine"];

List<int> betyg = [5, 9, 8, 1, 7];


Console.WriteLine();


for (int i = 0; i < 5; i++)
{
    Console.WriteLine(names[i] + " ger " + toys[i] + " betyget " + betyg[i]);

}

Console.WriteLine();

List<string> cities = [];

Console.WriteLine("Mata in namn på städer. Avsluta med exit.");
bool done = false;
while (!done)
{
    string city = Console.ReadLine();
    if (city == "exit")
    {
       done= true;  
    }
    else
    {
        cities.Add(city); 
    }
}

foreach (string item in cities)
{
    Console.WriteLine(item);
}
Console.ReadLine();
