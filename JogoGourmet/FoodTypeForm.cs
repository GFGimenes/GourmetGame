using JogoGourmet.Models;
using JogoGourmet.Service.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoGourmet
{
    public partial class FoodTypeForm : Form
    {
        private readonly IFoodService foodService;
        public List<TypeFood> foodTypes;
        private int currentFoodTypeIndex = 0;

        public FoodTypeForm()
        {
            foodService = Program.ServiceProvider.GetRequiredService<IFoodService>();
            InitializeComponent();
            searchFoodTypes();
            UpdateFoodType();
        }

        private void UpdateFoodType()
        {
            lblFoodType.Text = foodTypes[currentFoodTypeIndex].Name + "?";
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
           var currentfoodType = foodTypes[currentFoodTypeIndex];

            var insertFoodNameForm = new FoodNameForm(currentfoodType);

            insertFoodNameForm.ShowDialog();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if((foodTypes.Count - 1) > currentFoodTypeIndex) 
            {
                currentFoodTypeIndex++;
                UpdateFoodType();
                return;
            }
            
            if((foodTypes.Count - 1) <= currentFoodTypeIndex)
            {
                this.Close();

                var insertFoodNameForm = new InsertFoodTypeForm();

                insertFoodNameForm.ShowDialog();
            }

        }

        private void searchFoodTypes()
        {
            foodTypes = foodService.GetAllTypeFoods();
        }
    }
}
