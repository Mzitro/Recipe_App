using System;

namespace RecipeApp
{
    internal class Recipes
    {
        private string? name;
        private int numIngredients;
        private int numSteps;

        public Recipes(string? name, int numIngredients, int numSteps)
        {
            this.name = name;
            this.numIngredients = numIngredients;
            this.numSteps = numSteps;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter recipe details");
            Console.Write("Recipe Name: ");
            string name = Console.ReadLine();
            Console.Write("Number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            Console.Write("Number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());
            Recipes recipe = new(name, numIngredients, numSteps);

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

        private void PrintRecipe()
        {
            throw new NotImplementedException();
        }

        private void AddStep(int i, string? stepDescription)
        {
            throw new NotImplementedException();
        }

        private void AddIngredient(int i, string? ingredientName, double quantity, string? unit)
        {
            throw new NotImplementedException();
        }
    }
}