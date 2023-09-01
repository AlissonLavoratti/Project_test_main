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
            txtCpf = new MaskedTextBox();
            btnPesquisar = new Button();
            label1 = new Label();
            label2 = new Label();
            lblId = new Label();
            btnLimpar = new Button();
            btnAtualizar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            nome.Location = new Point(67, 100);
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
            cpf.Location = new Point(67, 150);
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
            matricula.Location = new Point(67, 197);
            matricula.Name = "matricula";
            matricula.Size = new Size(77, 18);
            matricula.TabIndex = 3;
            matricula.Text = "Matricula:";
            // 
            // txtNome
            // 
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Location = new Point(171, 99);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(349, 23);
            txtNome.TabIndex = 1;
            // 
            // txtMatricula
            // 
            txtMatricula.Cursor = Cursors.IBeam;
            txtMatricula.Location = new Point(171, 191);
            txtMatricula.MaxLength = 5;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(80, 23);
            txtMatricula.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(172, 258);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(100, 35);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtCpf
            // 
            txtCpf.Cursor = Cursors.IBeam;
            txtCpf.Location = new Point(172, 144);
            txtCpf.Mask = "000,000,000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(90, 23);
            txtCpf.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = SystemColors.GradientInactiveCaption;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisar.Location = new Point(420, 136);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(100, 35);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 57);
            label1.Name = "label1";
            label1.Size = new Size(99, 16);
            label1.TabIndex = 6;
            label1.Text = "Funcionário Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 57);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 7;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(170, 59);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 15);
            lblId.TabIndex = 8;
            // 
            // btnLimpar
            // 
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.Location = new Point(420, 258);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(100, 35);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtualizar.Location = new Point(295, 258);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(100, 35);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(172, 331);
            button1.Name = "button1";
            button1.Size = new Size(349, 56);
            button1.TabIndex = 8;
            button1.Text = "Cadastrar Tiket";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 433);
            Controls.Add(button1);
            Controls.Add(btnAtualizar);
            Controls.Add(btnLimpar);
            Controls.Add(lblId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPesquisar);
            Controls.Add(txtCpf);
            Controls.Add(btnCadastrar);
            Controls.Add(txtMatricula);
            Controls.Add(txtNome);
            Controls.Add(matricula);
            Controls.Add(cpf);
            Controls.Add(nome);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tikets Sistem";
            Load += Form1_Load;
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
        private MaskedTextBox txtCpf;
        private Button btnPesquisar;
        private Label label1;
        private Label label2;
        private Label lblId;
        private Button btnLimpar;
        private Button btnAtualizar;
        private Button button1;
    }
}