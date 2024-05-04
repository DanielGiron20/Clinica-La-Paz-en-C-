namespace ProyectoClinica
{
    partial class altaMedica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(altaMedica));
            label1 = new Label();
            label2 = new Label();
            pac = new TextBox();
            doc = new TextBox();
            label3 = new Label();
            dias = new TextBox();
            label4 = new Label();
            label5 = new Label();
            costodia = new TextBox();
            total_h = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            total = new TextBox();
            label7 = new Label();
            monto = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            cambio = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            id_p = new TextBox();
            idH = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(464, 24);
            label1.Name = "label1";
            label1.Size = new Size(199, 45);
            label1.TabIndex = 0;
            label1.Text = "Alta Medica";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 126);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 1;
            label2.Text = "Paciente";
            // 
            // pac
            // 
            pac.Location = new Point(127, 123);
            pac.Name = "pac";
            pac.ReadOnly = true;
            pac.Size = new Size(200, 31);
            pac.TabIndex = 2;
            // 
            // doc
            // 
            doc.Location = new Point(499, 120);
            doc.Name = "doc";
            doc.ReadOnly = true;
            doc.Size = new Size(200, 31);
            doc.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(348, 123);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 3;
            label3.Text = "Doctor a cargo";
            // 
            // dias
            // 
            dias.Location = new Point(891, 120);
            dias.Name = "dias";
            dias.Size = new Size(200, 31);
            dias.TabIndex = 6;
            dias.TextChanged += dias_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(718, 126);
            label4.Name = "label4";
            label4.Size = new Size(167, 25);
            label4.TabIndex = 5;
            label4.Text = "Dias hospitalizado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(348, 182);
            label5.Name = "label5";
            label5.Size = new Size(235, 25);
            label5.TabIndex = 7;
            label5.Text = "Costo por dia hospitaliado";
            // 
            // costodia
            // 
            costodia.Location = new Point(589, 176);
            costodia.Name = "costodia";
            costodia.ReadOnly = true;
            costodia.Size = new Size(200, 31);
            costodia.TabIndex = 8;
            // 
            // total_h
            // 
            total_h.Location = new Point(589, 229);
            total_h.Name = "total_h";
            total_h.Size = new Size(200, 31);
            total_h.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(397, 235);
            label6.Name = "label6";
            label6.Size = new Size(183, 25);
            label6.TabIndex = 10;
            label6.Text = "Total por habitacion";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 308);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1043, 332);
            dataGridView1.TabIndex = 11;
            // 
            // total
            // 
            total.Location = new Point(328, 670);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(200, 31);
            total.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(198, 673);
            label7.Name = "label7";
            label7.Size = new Size(123, 25);
            label7.TabIndex = 12;
            label7.Text = "Total a Pagar";
            // 
            // monto
            // 
            monto.Location = new Point(328, 719);
            monto.Name = "monto";
            monto.Size = new Size(200, 31);
            monto.TabIndex = 15;
            monto.TextChanged += monto_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 718);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(233, 728);
            label9.Name = "label9";
            label9.Size = new Size(69, 25);
            label9.TabIndex = 16;
            label9.Text = "Monto";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(227, 773);
            label10.Name = "label10";
            label10.Size = new Size(76, 25);
            label10.TabIndex = 18;
            label10.Text = "Cambio";
            // 
            // cambio
            // 
            cambio.Location = new Point(328, 773);
            cambio.Name = "cambio";
            cambio.ReadOnly = true;
            cambio.Size = new Size(200, 31);
            cambio.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(600, 673);
            button1.Name = "button1";
            button1.Size = new Size(206, 68);
            button1.TabIndex = 19;
            button1.Text = "Dar de alta";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(600, 751);
            button2.Name = "button2";
            button2.Size = new Size(206, 68);
            button2.TabIndex = 20;
            button2.Text = "Pagar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = Properties.Resources._736663fe6f9e03fcb39ace9020c42b4c_icono_de_calculadora_estacionaria;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(986, 249);
            button4.Name = "button4";
            button4.Size = new Size(78, 49);
            button4.TabIndex = 22;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // id_p
            // 
            id_p.Location = new Point(33, 24);
            id_p.Name = "id_p";
            id_p.Size = new Size(71, 31);
            id_p.TabIndex = 23;
            // 
            // idH
            // 
            idH.Location = new Point(127, 24);
            idH.Name = "idH";
            idH.Size = new Size(71, 31);
            idH.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(98, 89);
            label11.Name = "label11";
            label11.Size = new Size(69, 25);
            label11.TabIndex = 25;
            label11.Text = "label11";
            // 
            // altaMedica
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1107, 833);
            Controls.Add(label11);
            Controls.Add(idH);
            Controls.Add(id_p);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(cambio);
            Controls.Add(label9);
            Controls.Add(monto);
            Controls.Add(label8);
            Controls.Add(total);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(total_h);
            Controls.Add(costodia);
            Controls.Add(label5);
            Controls.Add(dias);
            Controls.Add(label4);
            Controls.Add(doc);
            Controls.Add(label3);
            Controls.Add(pac);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "altaMedica";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox pac;
        private TextBox doc;
        private Label label3;
        private TextBox dias;
        private Label label4;
        private Label label5;
        private TextBox costodia;
        private TextBox total_h;
        private Label label6;
        private DataGridView dataGridView1;
        private TextBox total;
        private Label label7;
        private TextBox monto;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox cambio;
        private Button button1;
        private Button button2;
        private Button button4;
        private TextBox id_p;
        private TextBox idH;
        private Label label11;
    }
}