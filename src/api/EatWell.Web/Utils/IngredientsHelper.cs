using System.Collections.Generic;
using System.Linq;

namespace EatWell.API.Utils
{
    public static class IngredientsHelper
    {
        public static List<string> IngredientsToList(string ingredients)
        {
            return ingredients.Split(',').ToList();
        }

        public static string IngredientsToString(List<string> ingredients)
        {
            return string.Join(',', ingredients);
        }
    }
}