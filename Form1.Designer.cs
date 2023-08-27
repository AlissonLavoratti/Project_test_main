namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nome = new Label();
            cpf = new Label();
            matricula = new Label();
            txtNome = new TextBox();
            txtMatricula = new TextBox();
            btnCadastrar = new Button();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            nome.Location = new Point(173, 138);
            nome.Name = "nome";
            nome.Size = new Size(53, 18);
            nome.TabIndex = 1;
            nome.Text = "Nome:";
            nome.Click += nome_Click;
            // 
            // cpf
            // 
            cpf.AutoSize = true;
            cpf.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cpf.Location = new Point(173, 188);
            cpf.Name = "cpf";
            cpf.Size = new Size(42, 18);
            cpf.TabIndex = 2;
            cpf.Text = "CPF:";
            cpf.Click += label1_Click_1;
            // 
            // matricula
            // 
            matricula.AutoSize = true;
            matricula.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            matricula.Location = new Point(173, 235);
            matricula.Name = "matricula";
            matricula.Size = new Size(77, 18);
            matricula.TabIndex = 3;
            matricula.Text = "Matricula:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(256, 138);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(329, 23);
            txtNome.TabIndex = 1;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(256, 230);
            txtMatricula.MaxLength = 5;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(329, 23);
            txtMatricula.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(384, 328);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(90, 35);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(257, 183);
            maskedTextBox1.Mask = "000,000,000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(328, 23);
            maskedTextBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maskedTextBox1);
            Controls.Add(btnCadastrar);
            Controls.Add(txtMatricula);
            Controls.Add(txtNome);
            Controls.Add(matricula);
            Controls.Add(cpf);
            Controls.Add(nome);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Company";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label nome;
        private Label cpf;
        private Label matricula;
        private TextBox txtNome;
        private TextBox txtMatricula;
        private Button btnCadastrar;
        private MaskedTextBox maskedTextBox1;
    }
}