namespace ProyectoClinica
{
    partial class agregar_cargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregar_cargo));
            label1 = new Label();
            idp_c = new TextBox();
            label3 = new Label();
            idd_c = new TextBox();
            label4 = new Label();
            label5 = new Label();
            descripcion_c = new TextBox();
            label6 = new Label();
            label7 = new Label();
            costo_c = new TextBox();
            tipocargo = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            name = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(322, 27);
            label1.Name = "label1";
            label1.Size = new Size(220, 32);
            label1.TabIndex = 0;
            label1.Text = "Adicion de cargos";
            label1.Click += label1_Click;
            // 
            // idp_c
            // 
            idp_c.Location = new Point(161, 154);
            idp_c.Name = "idp_c";
            idp_c.ReadOnly = true;
            idp_c.Size = new Size(72, 31);
            idp_c.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(42, 154);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 3;
            label3.Text = "ID paciente";
            // 
            // idd_c
            // 
            idd_c.Location = new Point(161, 205);
            idd_c.Name = "idd_c";
            idd_c.ReadOnly = true;
            idd_c.Size = new Size(72, 31);
            idd_c.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(55, 205);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 5;
            label4.Text = "ID doctor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(270, 109);
            label5.Name = "label5";
            label5.Size = new Size(187, 25);
            label5.TabIndex = 7;
            label5.Text = "Descripcion del cargo:";
            // 
            // descripcion_c
            // 
            descripcion_c.Location = new Point(270, 150);
            descripcion_c.Multiline = true;
            descripcion_c.Name = "descripcion_c";
            descripcion_c.Size = new Size(542, 104);
            descripcion_c.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(54, 326);
            label6.Name = "label6";
            label6.Size = new Size(101, 25);
            label6.TabIndex = 9;
            label6.Text = "Tipo cargo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(465, 329);
            label7.Name = "label7";
            label7.Size = new Size(63, 25);
            label7.TabIndex = 10;
            label7.Text = "Costo:";
            // 
            // costo_c
            // 
            costo_c.Location = new Point(543, 323);
            costo_c.Name = "costo_c";
            costo_c.Size = new Size(211, 31);
            costo_c.TabIndex = 11;
            // 
            // tipocargo
            // 
            tipocargo.FormattingEnabled = true;
            tipocargo.Items.AddRange(new object[] { "Consulta Medica", "Gastos Alimenticios", "Medicamento ", "Cirugia", "Examen de laboratorio", "Visita del doctor" });
            tipocargo.Location = new Point(161, 323);
            tipocargo.Name = "tipocargo";
            tipocargo.Size = new Size(250, 33);
            tipocargo.TabIndex = 12;
            tipocargo.SelectedIndexChanged += tipocargo_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources._6963703;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(348, 398);
            button1.Name = "button1";
            button1.Size = new Size(141, 80);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(54, 408);
            label2.Name = "label2";
            label2.Size = new Size(246, 25);
            label2.TabIndex = 14;
            label2.Text = "Cargo a nombre del paciente:";
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = Color.Transparent;
            name.Location = new Point(55, 442);
            name.Name = "name";
            name.Size = new Size(178, 25);
            name.TabIndex = 15;
            name.Text = "Nombre del paciente";
            // 
            // agregar_cargo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(850, 503);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(tipocargo);
            Controls.Add(costo_c);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(descripcion_c);
            Controls.Add(label5);
            Controls.Add(idd_c);
            Controls.Add(label4);
            Controls.Add(idp_c);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "agregar_cargo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox idp_c;
        private Label label3;
        private TextBox idd_c;
        private Label label4;
        private Label label5;
        private TextBox descripcion_c;
        private Label label6;
        private Label label7;
        private TextBox costo_c;
        private ComboBox tipocargo;
        private Button button1;
        private Label label2;
        private Label name;
    }
}