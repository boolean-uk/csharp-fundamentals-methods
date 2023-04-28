using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_methods.Main
{
    public class Extension
    {
        /* 
  Extension: 1.  We're going to improve our cake baking capabilities!
 //TODO: Create a public method named timerStatus that accepts one parameter:
 - the number of minutes left on the timer
 The method must return "The cake is ready!" if the remaining minutes is 0,
 "The cake is still baking!" if there are any remaining minutes left,
 and "The timer finished ages ago!" if the remaining minutes is a negative number
 */

        public string timerStatus(int minutes)
        {
            if (minutes == 0)
            {
                return "The cake is ready!";
            }
            else if (minutes >= 1)
            {
                return "The cake is still baking!";
            }
            return "The timer finished ages ago!";
        }



        //TODO: Extension: 2. Create a method named estimatePrepTime that accepts two parameters:
        /*  - an array of ingredients, e.g. ["sugar", "milk", "flour", "eggs"]
            - the prep time per ingredient in minutes
            The method must return the total prep time required based on the number of ingredients
            provided and the prep time per ingredient.
            If a prep time of 0 is provided, the method should assume each ingredient takes 2 minutes to prepare.
         */

        public int estimatePrepTime(string[] ingredients, int minutes)
        {
            if (minutes == 0)
            {
                minutes = 2;
                return (minutes * ingredients.Length);
            }
            return (minutes * ingredients.Length);
        }




        //TODO: 3.  Create a method named calculateGramsOfSugar that accepts two parameters:
        /*  - an array of ingredients that will always contain 3 ingredients
            - the number of layers the cake has
            The cake will need 100g of sugar per layer, if that ingredient is present in the provided list of ingredients.
            The method should return the number of grams of sugar needed to make the cake.
         */

        public int calculateGramsOfSugar(string[] ingredients, int layers)
        {
            if (ingredients.Contains("sugar"))
            {
                return (layers * 100);
            }
            else { return 0; }
        }



    }
}
