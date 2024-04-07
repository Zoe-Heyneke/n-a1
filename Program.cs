internal class Program
{
    public class Ingredients
    {
        public string name;
        public double quantity;
        public string unitsOfMeasurements;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome! Please enter the following details for a single recipe");
        Console.WriteLine("Enter the number of ingredients that are in this recipe:");
        int numIng= Convert.ToInt32(Console.ReadLine());
        Ingredients[] ingredients = new Ingredients[numIng]; 
        Console.WriteLine("The number of ingredients you chose are: " + numIng);

        for (int i = 0; i < numIng; i++)
        {
            Console.WriteLine("Enter the name of the ingredient:");
            string nameIng = Console.ReadLine();
            Console.WriteLine("Enter the quantity of the ingredient (amount):");
            int quantityIng = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the unit of measurement of the ingredient (cup, tablespoon etc.)");
            string unitMeas = Console.ReadLine();

            //array created
            ingredients[i] = new Ingredients
            {
                name = nameIng,
                quantity = quantityIng,
                unitsOfMeasurements = unitMeas,
            };
        }

        Console.WriteLine("Enter the number of steps that the recipe requires:");
            int numSteps = Convert.ToInt32(Console.ReadLine());

        string[] steps = new string[numSteps];
        for (int i = 0; i < numSteps;i++)
        {
            Console.WriteLine("Step " + (i + 1) + " : ");
            steps[i] = Console.ReadLine();
        }

        double[] origQuantities = new double[numIng];
        for (int i = 0; i  < numIng; i++)
        {
            origQuantities[i] = ingredients[i].quantity;
        }

        bool continueMenu = true;

        while(continueMenu)
        {
            Console.WriteLine("Display recipe (d)");
            Console.WriteLine("Scale (s)");
            Console.WriteLine("Reset (r)");
            Console.WriteLine("Clear (c)");
            Console.WriteLine("Exit (e)");

            string menu = Console.ReadLine();

            switch(menu)
            {
                case "d":
                    //error?
                    Console.WriteLine("Display of recipe:");
                    Console.WriteLine("Recipe Ingredients");
                    foreach(var ingredient in ingredients)
                    {
                        Console.WriteLine($"{ingredient.name}: {ingredient.quantity} {ingredient.unitsOfMeasuremets}");
                    }
                    Console.WriteLine("Recipe steps");
                    for (int i = 0; i < numSteps; i++)
                        {
                        Console.WriteLine($"Step {i + 1}: {steps[i]}");
                    }
                    break;
                case "s":
                    //
                    Console.WriteLine("Choose a scaling ctore");
                    Console.WriteLine("0.5 (half)");
                    Console.WriteLine("2 (double)");
                    Console.WriteLine("3 (triple)");
                    Console.WriteLine("Go back (back)");

                    string scalingFactor = Console.ReadLine();

                    switch(scalingFactor)
                    {
                        case "half":
                            //
                            foreach(var ingredient in ingredients)
                            {
                                ingredient.quantity = ingredient.quantity * 0.5;
                            }
                            break;
                        case "double":
                            //
                            foreach (var ingredient in ingredients)
                            {
                                ingredient.quantity = ingredient.quantity * 2;
                            }
                            break;
                        case "triple":
                            //
                            foreach (var ingredient in ingredients)
                            {
                                ingredient.quantity = ingredient.quantity * 3;
                            }
                            break;
                        case "back":
                            //
                            continueMenu = true;
                            break;
                    }
                  
                    break;
                case "r":
                    //
                    for (int i = 0; i < numIng; i++)
                    {
                        ingredients[i].quantity = origQuantities[i];
                    }
                    Console.WriteLine("Reset of recipe successful");
                    break;
                case "c":
                    //
                    for(int i = 0; i < numIng; i++)
                    {
                        ingredients[i].quantity = 0;
                    }

                    for(int i = 0; i < numSteps; i++)
                    {
                        steps[i] = "";
                    }
                    Console.WriteLine("Data cleared...enter new recipe");
                    break;
                case "e":
                    //
                    break;
            }
        }

    }

}