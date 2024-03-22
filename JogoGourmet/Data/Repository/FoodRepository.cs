using JogoGourmet.Data.Repository.Interface;
using JogoGourmet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmet.Data.Repository
{
    public class FoodRepository : IFoodRepository
    {
        private readonly FoodsDbContext _context;

        public FoodRepository(FoodsDbContext context)
        {
            _context = context;
        }

        public List<TypeFood> GetTypeAllFoods()
        {
            var typeFoods = _context.TypeFood.ToList();
            foreach (var tipo in typeFoods)
            {
                _context.Entry(tipo)
                    .Collection(t => t.Foods)
                    .Load();
            }
            return typeFoods;
        }

        public void AddFood(Food food, TypeFood typeFood)
        {
            var existingTypeFood = _context.TypeFood.FirstOrDefault(tf => tf.Name == typeFood.Name);

            if (existingTypeFood == null)
            {

                _context.TypeFood.Add(typeFood);

                food.TypeFood = typeFood;
            }
            else
            {
                food.TypeFood = existingTypeFood;
            }

            _context.Food.Add(food);
            _context.SaveChanges();
        }
    }
}
