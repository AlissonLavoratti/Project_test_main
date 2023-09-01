namespace WinFormsApp1
{
    partial class Form2
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
            txtCpf = new MaskedTextBox();
            dgvFuncTikets = new DataGridView();
            textBox1 = new TextBox();
            btnBuscar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFuncTikets).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 46);
            label1.Name = "label1";
            label1.Size = new Size(171, 18);
            label1.TabIndex = 0;
            label1.Text = "Pesquisar Funcionário:";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(537, 39);
            txtCpf.Mask = "000,000,000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(90, 23);
            txtCpf.TabIndex = 3;
            // 
            // dgvFuncTikets
            // 
            dgvFuncTikets.AllowUserToAddRows = false;
            dgvFuncTikets.AllowUserToDeleteRows = false;
            dgvFuncTikets.BackgroundColor = SystemColors.ControlLight;
            dgvFuncTikets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncTikets.Location = new Point(53, 103);
            dgvFuncTikets.Name = "dgvFuncTikets";
            dgvFuncTikets.ReadOnly = true;
            dgvFuncTikets.RowTemplate.Height = 25;
            dgvFuncTikets.Size = new Size(673, 333);
            dgvFuncTikets.TabIndex = 4;
            dgvFuncTikets.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.GradientActiveCaption;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(645, 39);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(81, 25);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(645, 465);
            button1.Name = "button1";
            button1.Size = new Size(81, 25);
            button1.TabIndex = 8;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 517);
            Controls.Add(button1);
            Controls.Add(btnBuscar);
            Controls.Add(textBox1);
            Controls.Add(dgvFuncTikets);
            Controls.Add(txtCpf);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tikets Sistem";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFuncTikets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox txtCpf;
        private DataGridView dgvFuncTikets;
        private TextBox textBox1;
        private Button btnBuscar;
        private Button button1;
    }
}