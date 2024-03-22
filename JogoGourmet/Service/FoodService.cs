using JogoGourmet.Data.Repository.Interface;
using JogoGourmet.Models;
using JogoGourmet.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmet.Service
{
    public class FoodService : IFoodService
    {
        private readonly IFoodRepository _foodRepository;
        public FoodService(IFoodRepository foodRepository) 
        {
            _foodRepository = foodRepository;
        }

        public List<TypeFood> GetAllTypeFoods()
        {
            return _foodRepository.GetTypeAllFoods();
        }

        public void AddFood(Food food, TypeFood typeFood)
        {
            _foodRepository.AddFood(food, typeFood);
        }
    }
}
