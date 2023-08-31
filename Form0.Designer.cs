namespace WinFormsApp1
{
    partial class TiketsSistem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnFuncionarios = new Button();
            btnConsTikets = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("BankGothic Md BT", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(123, 75);
            label1.Name = "label1";
            label1.Size = new Size(308, 39);
            label1.TabIndex = 0;
            label1.Text = "Tikets Sistem";
            // 
            // btnFuncionarios
            // 
            btnFuncionarios.FlatStyle = FlatStyle.Flat;
            btnFuncionarios.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFuncionarios.Location = new Point(84, 195);
            btnFuncionarios.Name = "btnFuncionarios";
            btnFuncionarios.Size = new Size(160, 85);
            btnFuncionarios.TabIndex = 1;
            btnFuncionarios.Text = "Funcionários";
            btnFuncionarios.UseVisualStyleBackColor = true;
            btnFuncionarios.Click += btnFuncionarios_Click;
            // 
            // btnConsTikets
            // 
            btnConsTikets.FlatStyle = FlatStyle.Flat;
            btnConsTikets.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsTikets.Location = new Point(329, 195);
            btnConsTikets.Name = "btnConsTikets";
            btnConsTikets.Size = new Size(160, 85);
            btnConsTikets.TabIndex = 2;
            btnConsTikets.Text = "Consultar Tikets";
            btnConsTikets.UseVisualStyleBackColor = true;
            btnConsTikets.Click += button1_Click;
            // 
            // TiketsSistem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 409);
            Controls.Add(btnConsTikets);
            Controls.Add(btnFuncionarios);
            Controls.Add(label1);
            Name = "TiketsSistem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tikets Sistem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnFuncionarios;
        private Button btnConsTikets;
    }
}