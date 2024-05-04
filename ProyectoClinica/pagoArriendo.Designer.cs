namespace ProyectoClinica
{
    partial class pagoArriendo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pagoArriendo));
            label1 = new Label();
            label2 = new Label();
            nombre_d = new TextBox();
            id_c = new TextBox();
            label3 = new Label();
            costo_c = new TextBox();
            label4 = new Label();
            meses = new TextBox();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            total = new TextBox();
            label7 = new Label();
            monto = new TextBox();
            label8 = new Label();
            cambio = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(246, 34);
            label1.Name = "label1";
            label1.Size = new Size(224, 32);
            label1.TabIndex = 0;
            label1.Text = "Cobro de arriendo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 108);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 1;
            label2.Text = "Doctor";
            // 
            // nombre_d
            // 
            nombre_d.Location = new Point(117, 105);
            nombre_d.Name = "nombre_d";
            nombre_d.ReadOnly = true;
            nombre_d.Size = new Size(255, 31);
            nombre_d.TabIndex = 2;
            // 
            // id_c
            // 
            id_c.Location = new Point(563, 108);
            id_c.Name = "id_c";
            id_c.ReadOnly = true;
            id_c.Size = new Size(95, 31);
            id_c.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(399, 108);
            label3.Name = "label3";
            label3.Size = new Size(158, 25);
            label3.TabIndex = 3;
            label3.Text = "ID de consultorio";
            // 
            // costo_c
            // 
            costo_c.Location = new Point(227, 162);
            costo_c.Name = "costo_c";
            costo_c.ReadOnly = true;
            costo_c.Size = new Size(154, 31);
            costo_c.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(34, 168);
            label4.Name = "label4";
            label4.Size = new Size(187, 25);
            label4.TabIndex = 5;
            label4.Text = "Costo de consultorio";
            // 
            // meses
            // 
            meses.Location = new Point(563, 162);
            meses.Name = "meses";
            meses.Size = new Size(95, 31);
            meses.TabIndex = 8;
            meses.TextChanged += meses_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(421, 165);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 7;
            label5.Text = "Meses a pagar";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources._69637031;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(462, 267);
            button1.Name = "button1";
            button1.Size = new Size(122, 102);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(502, 372);
            label6.Name = "label6";
            label6.Size = new Size(44, 19);
            label6.TabIndex = 10;
            label6.Text = "pagar";
            // 
            // total
            // 
            total.Location = new Point(163, 253);
            total.Name = "total";
            total.Size = new Size(154, 31);
            total.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(34, 253);
            label7.Name = "label7";
            label7.Size = new Size(123, 25);
            label7.TabIndex = 11;
            label7.Text = "Total a pagar";
            // 
            // monto
            // 
            monto.Location = new Point(163, 306);
            monto.Name = "monto";
            monto.Size = new Size(154, 31);
            monto.TabIndex = 14;
            monto.TextChanged += monto_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(34, 306);
            label8.Name = "label8";
            label8.Size = new Size(69, 25);
            label8.TabIndex = 13;
            label8.Text = "Monto";
            // 
            // cambio
            // 
            cambio.Location = new Point(163, 353);
            cambio.Name = "cambio";
            cambio.Size = new Size(154, 31);
            cambio.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(34, 353);
            label9.Name = "label9";
            label9.Size = new Size(76, 25);
            label9.TabIndex = 15;
            label9.Text = "Cambio";
            // 
            // pagoArriendo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(707, 423);
            Controls.Add(cambio);
            Controls.Add(label9);
            Controls.Add(monto);
            Controls.Add(label8);
            Controls.Add(total);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(meses);
            Controls.Add(label5);
            Controls.Add(costo_c);
            Controls.Add(label4);
            Controls.Add(id_c);
            Controls.Add(label3);
            Controls.Add(nombre_d);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "pagoArriendo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += pagoArriendo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nombre_d;
        private TextBox id_c;
        private Label label3;
        private TextBox costo_c;
        private Label label4;
        private TextBox meses;
        private Label label5;
        private Button button1;
        private Label label6;
        private TextBox total;
        private Label label7;
        private TextBox monto;
        private Label label8;
        private TextBox cambio;
        private Label label9;
    }
}