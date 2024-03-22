using JogoGourmet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmet.Data.Repository.Interface
{
    public interface IFoodRepository
    {
        List<TypeFood> GetTypeAllFoods();

        void AddFood(Food food, TypeFood typeFood);
    }
}
