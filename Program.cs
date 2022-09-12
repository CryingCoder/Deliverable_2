public class Deliverable2
{

    public static void Main(string[] args)
    {
        int WaterTotal = 0;
        int CoffeeTotal = 0;

        Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, parties of 6 or lower!");
        int People = int.Parse(Console.ReadLine());
        if (People > 6)
        {
            Console.WriteLine("Oh sorry, can only seat parties up to 6. Have a nice day.");
        }else {
            Console.WriteLine("A table for " + People);
            Console.WriteLine("Please follow me and take a seat. Let's get everyone started with some drinks. We've got water or coffee");

            for (int i = 1; i <= People; i++)
            {
                Console.WriteLine("Alright, person number " + i + " water or coffee?");
                string Drink = Console.ReadLine();
                if (Drink == "Coffee" || Drink == "COFFEE" || Drink == "coffee")
                {
                    CoffeeTotal++;
                    Console.WriteLine("Coffee, Okay!");
                }
                else if (Drink == "Water" || Drink == "WATER" || Drink == "water")
                {
                    WaterTotal++;
                    Console.WriteLine("Water, great choice!");
                }
                else
                {
                    Console.WriteLine("We don't have that. No drink for you!");
                }
            }
        }
        Console.WriteLine("Okay, so that's " + CoffeeTotal + " Coffee(s) and " + WaterTotal + " Water(s). I'll be right back. Feel free to grab your food!");

        decimal BuffetTotal = People * 9.99m;
        decimal drinkCoffeeTotal = CoffeeTotal * 2.00m;
        decimal CostTotal = BuffetTotal + drinkCoffeeTotal;

        Console.WriteLine("Heres your bill! Total Price: $" + CostTotal);
    }
}
   