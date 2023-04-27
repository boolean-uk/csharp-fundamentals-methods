using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_methods.Main
{
    public class Extension
    {
        /*  1.
        We're going to improve our cake baking capabilities!
        Create a public method named timerStatus that accepts one parameter:
        - the number of minutes left on the timer
        The method must return "The cake is ready!" if the remaining minutes is 0,
        "The cake is still baking!" if there are any remaining minutes left,
        and "The timer finished ages ago!" if the remaining minutes is a negative number
     */
        public string timerStatus(int v)
        {
            if (v == 0)
            {
                return "The cake is ready!";
            } else if (v > 0)
            {
                return "The cake is still baking!";
            } else
            {
                return "The timer finished ages ago!";
            }
            throw new NotImplementedException();
        }



        /*  2.
            Create a method named estimatePrepTime that accepts two parameters:
            - an array of ingredients, e.g. ["sugar", "milk", "flour", "eggs"]
            - the prep time per ingredient in minutes
            The method must return the total prep time required based on the number of ingredients
            provided and the prep time per ingredient.
            If a prep time of 0 is provided, the method should assume each ingredient takes 2 minutes to prepare.
         */

        public double estimatePrepTime(string[] strings, int v)
        {
            if (v == 0)
            {
                return strings.Length * 2;
            } else
            {
                return strings.Length * v;
            }
            throw new NotImplementedException();
        }




        /*  3.
            Create a method named calculateGramsOfSugar that accepts two parameters:
            - an array of ingredients that will always contain 3 ingredients
            - the number of layers the cake has
            The cake will need 100g of sugar per layer, if that ingredient is present in the provided list of ingredients.
            The method should return the number of grams of sugar needed to make the cake.
         */

        public double calculateGramsOfSugar(string[] strings, int v)
        {
            if (strings.Contains("sugar"))
            {
                return v * 100;
            } else
            {
                return 0;
            }
            throw new NotImplementedException();
        }




    }
}
