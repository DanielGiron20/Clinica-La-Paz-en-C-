namespace ProyectoClinica
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
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            doctor_c = new Label();
            consultorio = new Label();
            costo = new Label();
            can_meses = new Label();
            total = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(231, 37);
            label1.Name = "label1";
            label1.Size = new Size(364, 28);
            label1.TabIndex = 0;
            label1.Text = "Comprobante de pago de consultorio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 113);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 1;
            label2.Text = "Doctor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 113);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 3;
            label4.Text = "Consultorio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(637, 113);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 4;
            label5.Text = "Costo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(93, 167);
            label6.Name = "label6";
            label6.Size = new Size(167, 25);
            label6.TabIndex = 5;
            label6.Text = "Cantidad de meses:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(98, 234);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 6;
            label7.Text = "Total:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(493, 228);
            label8.Name = "label8";
            label8.Size = new Size(186, 30);
            label8.TabIndex = 7;
            label8.Text = "CA N C E L A D O";
            // 
            // doctor_c
            // 
            doctor_c.AutoSize = true;
            doctor_c.Location = new Point(183, 113);
            doctor_c.Name = "doctor_c";
            doctor_c.Size = new Size(59, 25);
            doctor_c.TabIndex = 8;
            doctor_c.Text = "label9";
            // 
            // consultorio
            // 
            consultorio.AutoSize = true;
            consultorio.Location = new Point(512, 113);
            consultorio.Name = "consultorio";
            consultorio.Size = new Size(69, 25);
            consultorio.TabIndex = 9;
            consultorio.Text = "label10";
            // 
            // costo
            // 
            costo.AutoSize = true;
            costo.Location = new Point(706, 113);
            costo.Name = "costo";
            costo.Size = new Size(69, 25);
            costo.TabIndex = 11;
            costo.Text = "label12";
            // 
            // can_meses
            // 
            can_meses.AutoSize = true;
            can_meses.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            can_meses.Location = new Point(266, 172);
            can_meses.Name = "can_meses";
            can_meses.Size = new Size(62, 20);
            can_meses.TabIndex = 12;
            can_meses.Text = "label13";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            total.Location = new Point(157, 238);
            total.Name = "total";
            total.Size = new Size(62, 20);
            total.TabIndex = 13;
            total.Text = "label14";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 317);
            Controls.Add(total);
            Controls.Add(can_meses);
            Controls.Add(costo);
            Controls.Add(consultorio);
            Controls.Add(doctor_c);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label doctor_c;
        private Label consultorio;
        private Label costo;
        private Label can_meses;
        private Label total;
    }
}