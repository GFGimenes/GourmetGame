using JogoGourmet.Data.Repository.Interface;
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
    public partial class FoodNameForm : Form
    {
        private TypeFood typeFoods;
        private int currentFoodNameIndex;
        private readonly IFoodService _foodService;

        public FoodNameForm(TypeFood typeFood)
        {
            _foodService = Program.ServiceProvider.GetRequiredService<IFoodService>();
            InitializeComponent();
            currentFoodNameIndex = 0;
            typeFoods = typeFood;
            askFoodName();
        }

        private void askFoodName()
        {
            lblFoodName.Text = typeFoods.Foods[currentFoodNameIndex].Name + "?";
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acertei de novo!");

            this.Close();

            var initialForm = new InitialForm();
            initialForm.ShowDialog();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if ((typeFoods.Foods.Count -1) > currentFoodNameIndex)
            {
                currentFoodNameIndex++;
                askFoodName();
                return;
            }

            if ((typeFoods.Foods.Count - 1) <= currentFoodNameIndex)
            {
                this.Close();

                var insertFoodNameForm = new InsertFoodTypeForm();

                insertFoodNameForm.ShowDialog();
            }
        }
    }
}
