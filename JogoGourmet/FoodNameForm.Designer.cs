namespace JogoGourmet
{
    partial class FoodNameForm
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
            askFood = new Label();
            lblFoodName = new Label();
            SuspendLayout();
            
            askFood.AutoSize = true;
            askFood.Location = new Point(133, 69);
            askFood.Name = "askFood";
            askFood.Size = new Size(69, 15);
            askFood.TabIndex = 5;
            askFood.Text = "Seu prato é ";
            
            lblFoodName.AutoSize = true;
            lblFoodName.Location = new Point(198, 69);
            lblFoodName.Margin = new Padding(4, 0, 4, 0);
            lblFoodName.Name = "lblFoodType";
            lblFoodName.Size = new Size(58, 15);
            lblFoodName.TabIndex = 4;
            lblFoodName.Text = "FoodName";

            btnNo.Location = new Point(223, 111);
            btnNo.Margin = new Padding(4, 3, 4, 3);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(88, 27);
            btnNo.TabIndex = 0;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;

            btnYes.Location = new Point(94, 111);
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
            Controls.Add(lblFoodName);
            Controls.Add(btnYes);
            Controls.Add(btnNo);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FoodNameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2Tipo";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private Label askFood;
        private Label lblFoodName;
    }
}