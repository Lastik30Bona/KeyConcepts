double tomatoesPrice = double.Parse(Console.ReadLine());
double tomatoesQuantity = double.Parse(Console.ReadLine());
double cucumberPrice = double.Parse(Console.ReadLine());
double cucumberQuantity = double.Parse(Console.ReadLine());

double tomatoesTotal = tomatoesPrice * tomatoesQuantity;
double cucumberTotal = cucumberPrice * cucumberQuantity;    
double totalCost = tomatoesTotal + cucumberTotal;

//Console.WriteLine($"{tomatoesPrice:F2} * {tomatoesQuantity:F2} = {tomatoesTotal:F2}");
//Console.WriteLine($"{cucumberPrice:F2} * {cucumberQuantity:F2} = {cucumberTotal:F2}");
Console.WriteLine($"{totalCost:F2}");