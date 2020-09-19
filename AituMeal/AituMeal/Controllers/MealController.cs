using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AituMeal.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace AituMeal.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class MealController : ControllerBase
    {
        private List<Meal> _meal = new List<Meal>()
        {
            new Meal(){MealId=1,MealName="оливье",MealPrice=150, MealWeight=100, MealType = "Салат", MealDate=new DateTime(2020,07,16)  },
            new Meal(){MealId=1,MealName="капустный",MealPrice=80, MealWeight=100, MealType = "Салат", MealDate=new DateTime(2020,07,16)  },
            new Meal(){MealId=1,MealName="итальянский",MealPrice=150, MealWeight=100, MealType = "Салат", MealDate=new DateTime(2020,07,16)  },
            new Meal(){MealId=1,MealName="из свеклы с сыром",MealPrice=120, MealWeight=100, MealType = "Салат", MealDate=new DateTime(2020,08,16)  },
            new Meal(){MealId=1,MealName="из цветочной капусты",MealPrice=120, MealWeight=100, MealType = "Салат", MealDate=new DateTime(2020,08,16)  },
            new Meal(){MealId=1,MealName="греческий",MealPrice=150, MealWeight=100, MealType = "Салат", MealDate=new DateTime(2020,08,16)  },
            new Meal(){MealId=1,MealName="морковный",MealPrice=80, MealWeight=100, MealType = "Салат", MealDate=new DateTime(2020,08,16)  },
            new Meal(){MealId=1,MealName="из фунчезы с овощями",MealPrice=120, MealWeight=100, MealType = "Салат", MealDate=new DateTime(2020,09,16)  },
            new Meal(){MealId=1,MealName="нежность",MealPrice=150, MealWeight=100, MealType = "Салат", MealDate=new DateTime(2020,09,16)  },
            new Meal(){MealId=1,MealName="Витаминный",MealPrice=120, MealWeight=100, MealType = "Салат", MealDate=new DateTime(2020,10,16)  },
            new Meal(){MealId=1,MealName="Малибу",MealPrice=150, MealWeight=100, MealType = "Салат", MealDate=new DateTime(2020,10,16)  },
        };
    
        [HttpGet]
        public List<Meal> GetAllMeal()
        {
            return _meal.OrderBy(x => x.MealId).ToList();
        }
        [HttpGet("get/byname/{name}")]
        public List<Meal> GetAllLessonsByName(string name)
        {
            return _meal.Where(c => c.MealName.Equals(name)).OrderBy(x => x.MealId).ToList();
        }
        [HttpGet("get/bytype/{mealtype}")]
        public List<Meal> GetAllLessonsByTeacher(string mealtype)
        {
            return _meal.Where(c => c.MealType.Equals(mealtype)).OrderBy(x => x.MealId).ToList();
        }
        






    }
}
