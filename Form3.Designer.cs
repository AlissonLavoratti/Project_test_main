namespace WinFormsApp1
{
    partial class Form3
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
            quantTiket = new Label();
            textBox1 = new TextBox();
            btnSalvarTiket = new Button();
            btnCancelarTiket = new Button();
            nomeFunc = new Label();
            Nome_Func = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 48);
            label1.Name = "label1";
            label1.Size = new Size(134, 19);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Tikets";
            // 
            // quantTiket
            // 
            quantTiket.AutoSize = true;
            quantTiket.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            quantTiket.Location = new Point(73, 165);
            quantTiket.Name = "quantTiket";
            quantTiket.Size = new Size(97, 19);
            quantTiket.TabIndex = 1;
            quantTiket.Text = "Quantidade";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(189, 161);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 23);
            textBox1.TabIndex = 2;
            // 
            // btnSalvarTiket
            // 
            btnSalvarTiket.FlatStyle = FlatStyle.Flat;
            btnSalvarTiket.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvarTiket.Location = new Point(389, 367);
            btnSalvarTiket.Name = "btnSalvarTiket";
            btnSalvarTiket.Size = new Size(84, 36);
            btnSalvarTiket.TabIndex = 3;
            btnSalvarTiket.Text = "Salvar";
            btnSalvarTiket.UseVisualStyleBackColor = true;
            // 
            // btnCancelarTiket
            // 
            btnCancelarTiket.FlatStyle = FlatStyle.Flat;
            btnCancelarTiket.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarTiket.Location = new Point(511, 367);
            btnCancelarTiket.Name = "btnCancelarTiket";
            btnCancelarTiket.Size = new Size(84, 36);
            btnCancelarTiket.TabIndex = 4;
            btnCancelarTiket.Text = "Cancelar";
            btnCancelarTiket.UseVisualStyleBackColor = true;
            btnCancelarTiket.Click += btnCancelarTiket_Click;
            // 
            // nomeFunc
            // 
            nomeFunc.AutoSize = true;
            nomeFunc.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nomeFunc.Location = new Point(73, 118);
            nomeFunc.Name = "nomeFunc";
            nomeFunc.Size = new Size(54, 19);
            nomeFunc.TabIndex = 5;
            nomeFunc.Text = "Nome";
            // 
            // Nome_Func
            // 
            Nome_Func.AutoSize = true;
            Nome_Func.Location = new Point(188, 122);
            Nome_Func.Name = "Nome_Func";
            Nome_Func.Size = new Size(0, 15);
            Nome_Func.TabIndex = 6;
            Nome_Func.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 438);
            Controls.Add(Nome_Func);
            Controls.Add(nomeFunc);
            Controls.Add(btnCancelarTiket);
            Controls.Add(btnSalvarTiket);
            Controls.Add(textBox1);
            Controls.Add(quantTiket);
            Controls.Add(label1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tikets Sistem";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label quantTiket;
        private TextBox textBox1;
        private Button btnSalvarTiket;
        private Button btnCancelarTiket;
        private Label nomeFunc;
        private Label Nome_Func;
    }
}