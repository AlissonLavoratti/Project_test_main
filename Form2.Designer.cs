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
            dgvFuncTikets = new DataGridView();
            textBox1 = new TextBox();
            btnBuscar = new Button();
            button1 = new Button();
            funcTiket_id = new DataGridViewTextBoxColumn();
            funcTiket_nome = new DataGridViewTextBoxColumn();
            funcTiket_quantidade = new DataGridViewTextBoxColumn();
            funcTiket_situacao = new DataGridViewTextBoxColumn();
            funcTiket_dataEntrega = new DataGridViewTextBoxColumn();
            funcTiket_codTiket = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvFuncTikets).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 46);
            label1.Name = "label1";
            label1.Size = new Size(171, 18);
            label1.TabIndex = 0;
            label1.Text = "Pesquisar Funcionário:";
            // 
            // dgvFuncTikets
            // 
            dgvFuncTikets.AllowUserToAddRows = false;
            dgvFuncTikets.AllowUserToDeleteRows = false;
            dgvFuncTikets.BackgroundColor = SystemColors.ControlLight;
            dgvFuncTikets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncTikets.Columns.AddRange(new DataGridViewColumn[] { funcTiket_id, funcTiket_nome, funcTiket_quantidade, funcTiket_situacao, funcTiket_dataEntrega, funcTiket_codTiket });
            dgvFuncTikets.Location = new Point(49, 103);
            dgvFuncTikets.Name = "dgvFuncTikets";
            dgvFuncTikets.ReadOnly = true;
            dgvFuncTikets.RowTemplate.Height = 25;
            dgvFuncTikets.Size = new Size(914, 435);
            dgvFuncTikets.TabIndex = 4;
            dgvFuncTikets.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(584, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.GradientActiveCaption;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(871, 43);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(92, 25);
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
            button1.Location = new Point(882, 564);
            button1.Name = "button1";
            button1.Size = new Size(81, 25);
            button1.TabIndex = 8;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // funcTiket_id
            // 
            funcTiket_id.DataPropertyName = "funcionario_tikets_id";
            funcTiket_id.HeaderText = "id";
            funcTiket_id.Name = "funcTiket_id";
            funcTiket_id.ReadOnly = true;
            funcTiket_id.Width = 60;
            // 
            // funcTiket_nome
            // 
            funcTiket_nome.DataPropertyName = "funcionario_tikets_nome";
            funcTiket_nome.HeaderText = "Nome";
            funcTiket_nome.Name = "funcTiket_nome";
            funcTiket_nome.ReadOnly = true;
            funcTiket_nome.Width = 400;
            // 
            // funcTiket_quantidade
            // 
            funcTiket_quantidade.DataPropertyName = "funcionario_tikets_quantidade";
            funcTiket_quantidade.HeaderText = "Quantidade";
            funcTiket_quantidade.Name = "funcTiket_quantidade";
            funcTiket_quantidade.ReadOnly = true;
            funcTiket_quantidade.Width = 90;
            // 
            // funcTiket_situacao
            // 
            funcTiket_situacao.DataPropertyName = "funcionario_tikets_situacao";
            funcTiket_situacao.HeaderText = "Situação";
            funcTiket_situacao.Name = "funcTiket_situacao";
            funcTiket_situacao.ReadOnly = true;
            funcTiket_situacao.Width = 60;
            // 
            // funcTiket_dataEntrega
            // 
            funcTiket_dataEntrega.DataPropertyName = "funcionario_tikets_data_entrega";
            funcTiket_dataEntrega.HeaderText = "Data de Entrega";
            funcTiket_dataEntrega.Name = "funcTiket_dataEntrega";
            funcTiket_dataEntrega.ReadOnly = true;
            funcTiket_dataEntrega.Width = 120;
            // 
            // funcTiket_codTiket
            // 
            funcTiket_codTiket.DataPropertyName = "id_funcionario_tiket";
            funcTiket_codTiket.HeaderText = "Código Tiket";
            funcTiket_codTiket.Name = "funcTiket_codTiket";
            funcTiket_codTiket.ReadOnly = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 620);
            Controls.Add(button1);
            Controls.Add(btnBuscar);
            Controls.Add(textBox1);
            Controls.Add(dgvFuncTikets);
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
        private DataGridView dgvFuncTikets;
        private TextBox textBox1;
        private Button btnBuscar;
        private Button button1;
        private DataGridViewTextBoxColumn funcTiket_id;
        private DataGridViewTextBoxColumn funcTiket_nome;
        private DataGridViewTextBoxColumn funcTiket_quantidade;
        private DataGridViewTextBoxColumn funcTiket_situacao;
        private DataGridViewTextBoxColumn funcTiket_dataEntrega;
        private DataGridViewTextBoxColumn funcTiket_codTiket;
    }
}