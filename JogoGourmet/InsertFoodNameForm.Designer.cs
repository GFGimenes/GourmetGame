namespace JogoGourmet
{
    partial class InsertFoodNameForm
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
            btnOk = new Button();
            btnCancel = new Button();
            txtNewFoodName = new TextBox();
            label1 = new Label();
            SuspendLayout();

            txtNewFoodName.Location = new Point(75, 51);
            txtNewFoodName.Margin = new Padding(4, 3, 4, 3);
            txtNewFoodName.Name = "txtNewFoodName";
            txtNewFoodName.Size = new Size(204, 23);
            txtNewFoodName.TabIndex = 6;

            label1.AutoSize = true;
            label1.Location = new Point(75, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 15);
            label1.TabIndex = 7;
            label1.Text = "Qual Nome do Prato que você pensou?";

            btnOk.Location = new Point(75, 93);
            btnOk.Margin = new Padding(4, 3, 4, 3);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(88, 27);
            btnOk.TabIndex = 4;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;

            btnCancel.Location = new Point(191, 93);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 27);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 152);
            Controls.Add(label1);
            Controls.Add(txtNewFoodName);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Margin = new Padding(4, 3, 4, 3);
            Name = "InsertFoodNameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtNewFoodName;
        private System.Windows.Forms.Label label1;
    }
}