double bathroomWidth = double.Parse(Console.ReadLine());
double bathroomHeight = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileHeight = double.Parse(Console.ReadLine());

double bathroomArea = bathroomWidth * bathroomHeight;

//bathroomArea = bathroomArea + 0.10 * bathroomArea;
bathroomArea = bathroomArea * 1.1;

double tileArea = tileWidth * tileHeight;

double tileNeeded = bathroomArea / tileArea;

Console.WriteLine(Math.Round(tileNeeded));



