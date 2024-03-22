using JogoGourmet.Models;
using JogoGourmet.Service.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace JogoGourmet
{
    public partial class InitialForm : Form
    {
        private readonly IFoodService _foodService;

        public InitialForm()
        {
            InitializeComponent();
            _foodService = Program.ServiceProvider.GetRequiredService<IFoodService>();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            firstInserts();

            FoodTypeForm form2Tipo = new FoodTypeForm();
            this.Hide();
            form2Tipo.ShowDialog();
            this.Close();
        }

        private void firstInserts()
        {
            var verifyFoods = _foodService.GetAllTypeFoods();

            var food = new Food { Name = "Lasanha" };

            if (verifyFoods.Count == 0) 
            {
                var firstTypeFood = new TypeFood
                {
                    Name = "Massa",
                    Foods = new List<Food>
                            { food }
                };

                _foodService.AddFood(food, firstTypeFood);
            }
        }
    }
}
