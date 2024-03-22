using JogoGourmet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmet.Service.Interface
{
    public interface IFoodService
    {
        List<TypeFood> GetAllTypeFoods();

        void AddFood(Food food, TypeFood typeFood);
    }
}
