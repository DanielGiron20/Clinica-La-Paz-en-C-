namespace ProyectoClinica
{
    partial class cobrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cobrar));
            label1 = new Label();
            label2 = new Label();
            pac = new TextBox();
            id_p = new TextBox();
            label3 = new Label();
            total = new TextBox();
            label4 = new Label();
            monto = new TextBox();
            label5 = new Label();
            Cambio = new TextBox();
            label6 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            descripciones = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(304, 9);
            label1.Name = "label1";
            label1.Size = new Size(288, 45);
            label1.TabIndex = 0;
            label1.Text = "Servicios Medicos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(63, 109);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 1;
            label2.Text = "Paciente:";
            // 
            // pac
            // 
            pac.Location = new Point(63, 146);
            pac.Name = "pac";
            pac.ReadOnly = true;
            pac.Size = new Size(214, 31);
            pac.TabIndex = 2;
            // 
            // id_p
            // 
            id_p.Location = new Point(63, 236);
            id_p.Name = "id_p";
            id_p.ReadOnly = true;
            id_p.Size = new Size(80, 31);
            id_p.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(63, 199);
            label3.Name = "label3";
            label3.Size = new Size(36, 25);
            label3.TabIndex = 3;
            label3.Text = "ID:";
            // 
            // total
            // 
            total.Location = new Point(63, 332);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(214, 31);
            total.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(63, 295);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 5;
            label4.Text = "Total:";
            // 
            // monto
            // 
            monto.Location = new Point(63, 423);
            monto.Name = "monto";
            monto.Size = new Size(214, 31);
            monto.TabIndex = 8;
            monto.TextChanged += monto_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(63, 386);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 7;
            label5.Text = "Monto:";
            // 
            // Cambio
            // 
            Cambio.Location = new Point(63, 523);
            Cambio.Name = "Cambio";
            Cambio.ReadOnly = true;
            Cambio.Size = new Size(214, 31);
            Cambio.TabIndex = 10;
            Cambio.TextChanged += Cambio_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(63, 486);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 9;
            label6.Text = "Cambio:";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources._69637031;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(99, 580);
            button1.Name = "button1";
            button1.Size = new Size(124, 86);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(335, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(510, 537);
            dataGridView1.TabIndex = 12;
            // 
            // descripciones
            // 
            descripciones.AutoSize = true;
            descripciones.Location = new Point(232, 77);
            descripciones.Name = "descripciones";
            descripciones.Size = new Size(59, 25);
            descripciones.TabIndex = 13;
            descripciones.Text = "label7";
            // 
            // cobrar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(870, 691);
            Controls.Add(descripciones);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(Cambio);
            Controls.Add(label6);
            Controls.Add(monto);
            Controls.Add(label5);
            Controls.Add(total);
            Controls.Add(label4);
            Controls.Add(id_p);
            Controls.Add(label3);
            Controls.Add(pac);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "cobrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox pac;
        private TextBox id_p;
        private Label label3;
        private TextBox total;
        private Label label4;
        private TextBox monto;
        private Label label5;
        private TextBox Cambio;
        private Label label6;
        private Button button1;
        private DataGridView dataGridView1;
        private Label descripciones;
    }
}