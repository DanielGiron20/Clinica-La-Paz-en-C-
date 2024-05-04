namespace ProyectoClinica
{
    partial class pagarDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pagarDoctor));
            label1 = new Label();
            label2 = new Label();
            nombre_d = new TextBox();
            id_d = new TextBox();
            label3 = new Label();
            estado_d = new TextBox();
            label4 = new Label();
            salario_d = new TextBox();
            label5 = new Label();
            precioC = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            total = new TextBox();
            label7 = new Label();
            button1 = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(349, 9);
            label1.Name = "label1";
            label1.Size = new Size(255, 38);
            label1.TabIndex = 0;
            label1.Text = "Pago por servicios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(51, 106);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 1;
            label2.Text = "Doctor:";
            // 
            // nombre_d
            // 
            nombre_d.Location = new Point(138, 106);
            nombre_d.Name = "nombre_d";
            nombre_d.ReadOnly = true;
            nombre_d.Size = new Size(225, 31);
            nombre_d.TabIndex = 2;
            // 
            // id_d
            // 
            id_d.Location = new Point(438, 106);
            id_d.Name = "id_d";
            id_d.ReadOnly = true;
            id_d.Size = new Size(67, 31);
            id_d.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(394, 106);
            label3.Name = "label3";
            label3.Size = new Size(31, 25);
            label3.TabIndex = 3;
            label3.Text = "ID";
            // 
            // estado_d
            // 
            estado_d.Location = new Point(687, 103);
            estado_d.Name = "estado_d";
            estado_d.ReadOnly = true;
            estado_d.Size = new Size(225, 31);
            estado_d.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(543, 106);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 5;
            label4.Text = "Estado laboral:";
            // 
            // salario_d
            // 
            salario_d.Location = new Point(138, 162);
            salario_d.Name = "salario_d";
            salario_d.ReadOnly = true;
            salario_d.Size = new Size(225, 31);
            salario_d.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(51, 162);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 7;
            label5.Text = "Salario";
            // 
            // precioC
            // 
            precioC.Location = new Point(569, 162);
            precioC.Name = "precioC";
            precioC.ReadOnly = true;
            precioC.Size = new Size(225, 31);
            precioC.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(387, 165);
            label6.Name = "label6";
            label6.Size = new Size(176, 25);
            label6.TabIndex = 9;
            label6.Text = "Precio por consulta";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 228);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(898, 248);
            dataGridView1.TabIndex = 11;
            // 
            // total
            // 
            total.Location = new Point(164, 509);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(225, 31);
            total.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(35, 509);
            label7.Name = "label7";
            label7.Size = new Size(123, 25);
            label7.TabIndex = 12;
            label7.Text = "Total a pagar";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(493, 492);
            button1.Name = "button1";
            button1.Size = new Size(287, 59);
            button1.TabIndex = 14;
            button1.Text = "Emitir pago ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(121, 36);
            label8.Name = "label8";
            label8.Size = new Size(59, 25);
            label8.TabIndex = 15;
            label8.Text = "label8";
            // 
            // pagarDoctor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(953, 581);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(total);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(precioC);
            Controls.Add(label6);
            Controls.Add(salario_d);
            Controls.Add(label5);
            Controls.Add(estado_d);
            Controls.Add(label4);
            Controls.Add(id_d);
            Controls.Add(label3);
            Controls.Add(nombre_d);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "pagarDoctor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += pagarDoctor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nombre_d;
        private TextBox id_d;
        private Label label3;
        private TextBox estado_d;
        private Label label4;
        private TextBox salario_d;
        private Label label5;
        private TextBox precioC;
        private Label label6;
        private DataGridView dataGridView1;
        private TextBox total;
        private Label label7;
        private Button button1;
        private Label label8;
    }
}