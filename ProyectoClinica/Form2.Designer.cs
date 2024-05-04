namespace ProyectoClinica
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
            fecha = new Label();
            label12 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            id_f = new Label();
            doctor_f = new Label();
            label6 = new Label();
            lolo = new Label();
            label9 = new Label();
            pago = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // fecha
            // 
            fecha.AutoSize = true;
            fecha.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            fecha.Location = new Point(239, 108);
            fecha.Name = "fecha";
            fecha.Size = new Size(33, 19);
            fecha.TabIndex = 18;
            fecha.Text = "opp";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(186, 108);
            label12.Name = "label12";
            label12.Size = new Size(47, 19);
            label12.TabIndex = 17;
            label12.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(256, 89);
            label4.Name = "label4";
            label4.Size = new Size(120, 19);
            label4.TabIndex = 16;
            label4.Text = "No. Voucher 0019";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(245, 38);
            label3.Name = "label3";
            label3.Size = new Size(143, 15);
            label3.TabIndex = 15;
            label3.Text = "seguro medico asistencial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(214, 53);
            label2.Name = "label2";
            label2.Size = new Size(211, 15);
            label2.TabIndex = 14;
            label2.Text = "Barrio rio de piedras 7 calle 4ta avenida";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 13;
            label1.Text = "Centro Medico La Paz";
            // 
            // id_f
            // 
            id_f.AutoSize = true;
            id_f.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            id_f.Location = new Point(416, 141);
            id_f.Name = "id_f";
            id_f.Size = new Size(61, 21);
            id_f.TabIndex = 24;
            id_f.Text = "label14";
            // 
            // doctor_f
            // 
            doctor_f.AutoSize = true;
            doctor_f.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            doctor_f.Location = new Point(178, 141);
            doctor_f.Name = "doctor_f";
            doctor_f.Size = new Size(61, 21);
            doctor_f.TabIndex = 23;
            doctor_f.Text = "label13";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(382, 141);
            label6.Name = "label6";
            label6.Size = new Size(28, 21);
            label6.TabIndex = 20;
            label6.Text = "ID:";
            // 
            // lolo
            // 
            lolo.AutoSize = true;
            lolo.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lolo.Location = new Point(102, 141);
            lolo.Name = "lolo";
            lolo.Size = new Size(60, 21);
            lolo.TabIndex = 19;
            lolo.Text = "Doctor:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(103, 221);
            label9.Name = "label9";
            label9.Size = new Size(79, 21);
            label9.TabIndex = 26;
            label9.Text = "Pago total";
            // 
            // pago
            // 
            pago.AutoSize = true;
            pago.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            pago.Location = new Point(186, 221);
            pago.Name = "pago";
            pago.Size = new Size(61, 21);
            pago.TabIndex = 27;
            pago.Text = "label15";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(245, 221);
            label5.Name = "label5";
            label5.Size = new Size(34, 21);
            label5.TabIndex = 28;
            label5.Text = "Lps";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 276);
            Controls.Add(label5);
            Controls.Add(pago);
            Controls.Add(label9);
            Controls.Add(id_f);
            Controls.Add(doctor_f);
            Controls.Add(label6);
            Controls.Add(lolo);
            Controls.Add(fecha);
            Controls.Add(label12);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fecha;
        private Label label12;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label id_f;
        private Label doctor_f;
        private Label label6;
        private Label lolo;
        private Label label9;
        private Label pago;
        private Label label5;
    }
}