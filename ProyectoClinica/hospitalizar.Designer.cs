namespace ProyectoClinica
{
    partial class hospitalizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hospitalizar));
            label1 = new Label();
            id_h = new TextBox();
            nombre_h = new TextBox();
            label2 = new Label();
            label3 = new Label();
            doctor_h = new TextBox();
            label4 = new Label();
            motivo = new TextBox();
            label5 = new Label();
            habitacion = new TextBox();
            button1 = new Button();
            id_paciente_h = new TextBox();
            id_doctor_h = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 37);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 0;
            label1.Text = "ID hospitalizacion:";
            // 
            // id_h
            // 
            id_h.Location = new Point(196, 34);
            id_h.Name = "id_h";
            id_h.ReadOnly = true;
            id_h.Size = new Size(84, 31);
            id_h.TabIndex = 1;
            // 
            // nombre_h
            // 
            nombre_h.Location = new Point(196, 71);
            nombre_h.Name = "nombre_h";
            nombre_h.ReadOnly = true;
            nombre_h.Size = new Size(235, 31);
            nombre_h.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 77);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 118);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 4;
            label3.Text = "Doctor:";
            // 
            // doctor_h
            // 
            doctor_h.Location = new Point(196, 112);
            doctor_h.Name = "doctor_h";
            doctor_h.ReadOnly = true;
            doctor_h.Size = new Size(235, 31);
            doctor_h.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 269);
            label4.Name = "label4";
            label4.Size = new Size(237, 25);
            label4.TabIndex = 6;
            label4.Text = "Motivo de hospitalizacion:";
            // 
            // motivo
            // 
            motivo.Location = new Point(27, 311);
            motivo.Multiline = true;
            motivo.Name = "motivo";
            motivo.Size = new Size(415, 126);
            motivo.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(19, 157);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 8;
            label5.Text = "Habitacion:";
            // 
            // habitacion
            // 
            habitacion.Location = new Point(196, 157);
            habitacion.Name = "habitacion";
            habitacion.Size = new Size(84, 31);
            habitacion.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.magnifying_glass_sign_search_icon_free_png;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(308, 157);
            button1.Name = "button1";
            button1.Size = new Size(67, 42);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // id_paciente_h
            // 
            id_paciente_h.Location = new Point(600, 65);
            id_paciente_h.Name = "id_paciente_h";
            id_paciente_h.Size = new Size(84, 31);
            id_paciente_h.TabIndex = 11;
            // 
            // id_doctor_h
            // 
            id_doctor_h.Location = new Point(600, 112);
            id_doctor_h.Name = "id_doctor_h";
            id_doctor_h.Size = new Size(84, 31);
            id_doctor_h.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(137, 461);
            button2.Name = "button2";
            button2.Size = new Size(170, 56);
            button2.TabIndex = 14;
            button2.Text = "Hospitalizar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // hospitalizar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(483, 546);
            Controls.Add(button2);
            Controls.Add(id_doctor_h);
            Controls.Add(id_paciente_h);
            Controls.Add(button1);
            Controls.Add(habitacion);
            Controls.Add(label5);
            Controls.Add(motivo);
            Controls.Add(label4);
            Controls.Add(doctor_h);
            Controls.Add(label3);
            Controls.Add(nombre_h);
            Controls.Add(label2);
            Controls.Add(id_h);
            Controls.Add(label1);
            Name = "hospitalizar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            Load += hospitalizar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox id_h;
        private TextBox nombre_h;
        private Label label2;
        private Label label3;
        private TextBox doctor_h;
        private Label label4;
        private TextBox motivo;
        private Label label5;
        private TextBox habitacion;
        private Button button1;
        private TextBox id_paciente_h;
        private TextBox id_doctor_h;
        private Button button2;
    }
}