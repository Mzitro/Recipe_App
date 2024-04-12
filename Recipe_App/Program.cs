using System;

namespace RecipeApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter recipe details");
            Console.Write("Recipe Name: ");
            string name = Console.ReadLine();
            Console.Write("Number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            Console.Write("Number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());
            Recipes recipe = new Recipes(name, numIngredients, numSteps);

            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine("Enter details for ingredient " + (i + 1) + ":");
                Console.Write("Name: ");
                string ingredientName = Console.ReadLine();
                Console.Write("Quantity: ");
                double quantity = double.Parse(Console.ReadLine());
                Console.Write("Unit of measurement: ");
                string unit = Console.ReadLine();
                recipe.AddIngredient(i, ingredientName, quantity, unit);
            }

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine("Enter details for step " + (i + 1) + ":");
                Console.Write("Description: ");
                string stepDescription = Console.ReadLine();
                recipe.AddStep(i, stepDescription);
            }

            Console.WriteLine("Recipe Details");
            recipe.PrintRecipe();
        }
    }
}
