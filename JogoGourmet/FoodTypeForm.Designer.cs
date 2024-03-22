namespace JogoGourmet
{
    partial class FoodTypeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnNo = new Button();
            btnYes = new Button();
            lblFoodType = new Label();
            askFood = new Label();
            SuspendLayout();

            lblFoodType.AutoSize = true;
            lblFoodType.Location = new Point(189, 59);
            lblFoodType.Margin = new Padding(4, 0, 4, 0);
            lblFoodType.Name = "lblFoodType";
            lblFoodType.Size = new Size(58, 15);
            lblFoodType.TabIndex = 2;
            lblFoodType.Text = "FoodType";

            askFood.AutoSize = true;
            askFood.Location = new Point(124, 59);
            askFood.Name = "askFood";
            askFood.Size = new Size(69, 15);
            askFood.TabIndex = 3;
            askFood.Text = "Seu prato é ";

            btnNo.Location = new Point(190, 113);
            btnNo.Margin = new Padding(4, 3, 4, 3);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(88, 27);
            btnNo.TabIndex = 0;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;

            btnYes.Location = new Point(94, 113);
            btnYes.Margin = new Padding(4, 3, 4, 3);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(88, 27);
            btnYes.TabIndex = 1;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 175);
            Controls.Add(askFood);
            Controls.Add(lblFoodType);
            Controls.Add(btnYes);
            Controls.Add(btnNo);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FoodTypeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2Tipo";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label lblFoodType;
        private Label askFood;
    }

}