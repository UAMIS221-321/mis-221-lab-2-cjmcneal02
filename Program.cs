
class SandwichLab
{
    static void Main(string[] args)
    {
 // Constants       
const double SANDWICH_COST = 4.75;
const double TOPPING_COST = 0.55;
const double DISCOUNT = 0.1;


//Ask user for # of sandwiches
Console.WriteLine("Enter # of Sanwiches: ");
int numOfSandwiches = int.Parse(Console.ReadLine());
//Ask user for # of toppings
Console.WriteLine("Enter # of toppings: ");
int numOfToppings = int.Parse(Console.ReadLine());
//Ask user to tip
Console.WriteLine("Enter tip amount (as a decimal): ");
double tipPercent = double.Parse(Console.ReadLine());
//Calculate Costs

double totalSandwichCost = 0;
totalSandwichCost = SANDWICH_COST * numOfSandwiches;

double totalToppingCost = 0;
totalToppingCost = TOPPING_COST * numOfToppings;

double baseCost = 0;
baseCost = totalSandwichCost + totalToppingCost;

double discountedAmount = baseCost * DISCOUNT;
double discountedCost = baseCost - discountedAmount;
double tipAmount = discountedCost * tipPercent;

double totalOrderCost = 0;
totalOrderCost = baseCost * discountedCost + tipAmount;

Console.WriteLine(("Your total cost is: "    )+ totalOrderCost);

    }
}
