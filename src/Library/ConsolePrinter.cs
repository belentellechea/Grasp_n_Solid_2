using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.GetSteps())
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}

/*
Para la creación de la clase ConsolePrinter nos basamos en el principio SRP, ya que 
anteriormente, esta responsabilidad era adjudicada a la clase Recipe, la cual ya se 
encargaba de generar una lista con todos los pasos. 
*/







/*
        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
}
*/


