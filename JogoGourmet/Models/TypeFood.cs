using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmet.Models
{
    public class TypeFood
    {
        public int TypeFoodId { get; set; }
        public string Name { get; set; }
        public List<Food> Foods { get; set; }
    }
}
