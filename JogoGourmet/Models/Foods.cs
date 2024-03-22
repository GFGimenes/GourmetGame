using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmet.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        public string Name { get; set; }
        public int TypeFoodId { get; set; } 
        public TypeFood TypeFood { get; set; } 
    }
}
