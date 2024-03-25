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
    }

}