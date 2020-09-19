using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AituMeal.Models
{
    public class Meal
    {
        public int MealId { get; set; }
        public string MealName { get; set; }
        public int MealPrice { get; set; }
        public int MealWeight { get; set; }
        public string MealType { get; set; }
        public DateTime MealDate { get; set; }
    }
}
