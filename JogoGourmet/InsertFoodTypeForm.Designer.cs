namespace JogoGourmet
{
    partial class InsertFoodTypeForm
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
            label1 = new Label();
            txtNewFoodType = new TextBox();
            btnCancel = new Button();
            btnOk = new Button();
            SuspendLayout();

            label1.AutoSize = true;
            label1.Location = new Point(75, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 15);
            label1.TabIndex = 7;
            label1.Text = "Qual Tipo do Prato que você pensou?";

            txtNewFoodType.Location = new Point(75, 51);
            txtNewFoodType.Margin = new Padding(4, 3, 4, 3);
            txtNewFoodType.Name = "txtNewFoodType";
            txtNewFoodType.Size = new Size(204, 23);
            txtNewFoodType.TabIndex = 6;

            btnCancel.Location = new Point(191, 93);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 27);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;

            btnOk.Location = new Point(75, 93);
            btnOk.Margin = new Padding(4, 3, 4, 3);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(88, 27);
            btnOk.TabIndex = 4;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 152);
            Controls.Add(label1);
            Controls.Add(txtNewFoodType);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Margin = new Padding(4, 3, 4, 3);
            Name = "InsertFoodTypeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private TextBox txtNewFoodType;
        private Button btnCancel;
        private Button btnOk;
    }
}