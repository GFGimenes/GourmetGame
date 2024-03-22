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
    public partial class InsertFoodTypeForm : Form
    {
        public string NewFoodName { get; private set; }

        private readonly IFoodService foodService;

        public InsertFoodTypeForm()
        {
            foodService = Program.ServiceProvider.GetRequiredService<IFoodService>();
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string newFoodType = txtNewFoodType.Text;
            if (!string.IsNullOrWhiteSpace(newFoodType))
            {
                this.Hide();

                var typeFood = new TypeFood { Name = newFoodType };

                this.Close();

                var insertFoodNameForm = new InsertFoodNameForm(typeFood);

                insertFoodNameForm.ShowDialog();


            }
            else
            {
                MessageBox.Show("Por favor, digite um tipo de comida válido.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            this.Close();

            var initialForm = new InitialForm();
            initialForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
