internal class Program
{
    public class Ingredients
    {
        string name;
        double quantity;
        string unitsOfMeasurements;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome! Please enter the following details for a single recipe");
        Console.WriteLine("Enter the number of ingredients that are in this recipe:");
        int numIng= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The number of ingredients you chose are: " + numIng);

        for (int i = 0; i < numIng; i++) 
        {
            Console.WriteLine("Enter the name of the ingredient:");
            string nameIng = Console.ReadLine();
            Console.WriteLine("Enter the quantity of the ingredient (amount):");
            int quantityIng = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the unit of measurement of the ingredient (cup, tablespoon etc.)");
            string unitMea = Console.ReadLine();
        }
    }

}