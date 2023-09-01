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
            labelId = new Label();
            Id_Func = new Label();
            label2 = new Label();
            button1 = new Button();
            numTiket = new Label();
            numTiketVer = new TextBox();
            label3 = new Label();
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
            quantTiket.Location = new Point(68, 234);
            quantTiket.Name = "quantTiket";
            quantTiket.Size = new Size(97, 19);
            quantTiket.TabIndex = 1;
            quantTiket.Text = "Quantidade";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(203, 230);
            textBox1.MaxLength = 2;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // btnSalvarTiket
            // 
            btnSalvarTiket.BackColor = SystemColors.GradientInactiveCaption;
            btnSalvarTiket.Cursor = Cursors.AppStarting;
            btnSalvarTiket.FlatStyle = FlatStyle.Flat;
            btnSalvarTiket.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvarTiket.Location = new Point(302, 367);
            btnSalvarTiket.Name = "btnSalvarTiket";
            btnSalvarTiket.Size = new Size(84, 36);
            btnSalvarTiket.TabIndex = 3;
            btnSalvarTiket.Text = "Salvar";
            btnSalvarTiket.UseVisualStyleBackColor = false;
            btnSalvarTiket.Click += btnSalvarTiket_Click;
            // 
            // btnCancelarTiket
            // 
            btnCancelarTiket.BackColor = SystemColors.GradientInactiveCaption;
            btnCancelarTiket.Cursor = Cursors.AppStarting;
            btnCancelarTiket.FlatStyle = FlatStyle.Flat;
            btnCancelarTiket.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarTiket.Location = new Point(511, 367);
            btnCancelarTiket.Name = "btnCancelarTiket";
            btnCancelarTiket.Size = new Size(84, 36);
            btnCancelarTiket.TabIndex = 4;
            btnCancelarTiket.Text = "Cancelar";
            btnCancelarTiket.UseVisualStyleBackColor = false;
            btnCancelarTiket.Click += btnCancelarTiket_Click;
            // 
            // nomeFunc
            // 
            nomeFunc.AutoSize = true;
            nomeFunc.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nomeFunc.Location = new Point(68, 143);
            nomeFunc.Name = "nomeFunc";
            nomeFunc.Size = new Size(54, 19);
            nomeFunc.TabIndex = 5;
            nomeFunc.Text = "Nome";
            // 
            // Nome_Func
            // 
            Nome_Func.AutoSize = true;
            Nome_Func.Location = new Point(203, 146);
            Nome_Func.Name = "Nome_Func";
            Nome_Func.Size = new Size(0, 15);
            Nome_Func.TabIndex = 6;
            Nome_Func.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelId.Location = new Point(68, 98);
            labelId.Name = "labelId";
            labelId.Size = new Size(119, 19);
            labelId.TabIndex = 7;
            labelId.Text = "Id Funcionario";
            labelId.TextAlign = ContentAlignment.MiddleLeft;
            labelId.Click += labelId_Click;
            // 
            // Id_Func
            // 
            Id_Func.AutoSize = true;
            Id_Func.Location = new Point(203, 101);
            Id_Func.Name = "Id_Func";
            Id_Func.Size = new Size(0, 15);
            Id_Func.TabIndex = 8;
            Id_Func.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(313, 234);
            label2.Name = "label2";
            label2.Size = new Size(39, 19);
            label2.TabIndex = 9;
            label2.Text = "und";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Cursor = Cursors.AppStarting;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(409, 367);
            button1.Name = "button1";
            button1.Size = new Size(84, 36);
            button1.TabIndex = 10;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnSalvarTiket_Click;
            // 
            // numTiket
            // 
            numTiket.AutoSize = true;
            numTiket.Location = new Point(203, 48);
            numTiket.Name = "numTiket";
            numTiket.Size = new Size(0, 15);
            numTiket.TabIndex = 11;
            numTiket.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numTiketVer
            // 
            numTiketVer.Location = new Point(203, 187);
            numTiketVer.MaxLength = 5;
            numTiketVer.Name = "numTiketVer";
            numTiketVer.Size = new Size(100, 23);
            numTiketVer.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(68, 191);
            label3.Name = "label3";
            label3.Size = new Size(111, 19);
            label3.TabIndex = 13;
            label3.Text = "Número Tiket";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 438);
            Controls.Add(label3);
            Controls.Add(numTiketVer);
            Controls.Add(numTiket);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(Id_Func);
            Controls.Add(labelId);
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
        private Label labelId;
        private Label Id_Func;
        private Label label2;
        private Button button1;
        private Label numTiket;
        private TextBox numTiketVer;
        private Label label3;
    }
}