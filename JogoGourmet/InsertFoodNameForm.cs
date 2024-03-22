using JogoGourmet.Models;
using JogoGourmet.Service;
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
    public partial class InsertFoodNameForm : Form
    {
        private readonly IFoodService foodService;
        private readonly TypeFood _typeFood;

        public InsertFoodNameForm(TypeFood typeFood)
        {
            foodService = Program.ServiceProvider.GetRequiredService<IFoodService>();
            InitializeComponent();
            _typeFood = typeFood;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string newFoodName = txtNewFoodName.Text;

            if (!string.IsNullOrWhiteSpace(newFoodName))
            {
                var food = new Food
                {
                    Name = newFoodName,
                    TypeFood = _typeFood
                };

                foodService.AddFood(food, _typeFood);

                DialogResult = DialogResult.OK;
                
                MessageBox.Show("Prato inserido");
                
                this.Close();

                var initialForm = new InitialForm();
                initialForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, digite um nome de prato válido.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            this.Close();

            var initialForm = new InitialForm();

            initialForm.ShowDialog();
        }
    }
}
