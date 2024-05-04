namespace ProyectoClinica
{
    partial class agendar_cirugia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agendar_cirugia));
            label1 = new Label();
            label2 = new Label();
            id_pac = new TextBox();
            id_q = new TextBox();
            label3 = new Label();
            label4 = new Label();
            fecha = new DateTimePicker();
            label5 = new Label();
            det = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            nombre = new TextBox();
            label6 = new Label();
            id = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(340, 32);
            label1.Name = "label1";
            label1.Size = new Size(230, 38);
            label1.TabIndex = 0;
            label1.Text = "Agendar Cirugia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(56, 239);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 1;
            label2.Text = "Id Paciente";
            // 
            // id_pac
            // 
            id_pac.Location = new Point(169, 236);
            id_pac.Name = "id_pac";
            id_pac.Size = new Size(166, 31);
            id_pac.TabIndex = 2;
            // 
            // id_q
            // 
            id_q.Location = new Point(169, 286);
            id_q.Name = "id_q";
            id_q.Size = new Size(166, 31);
            id_q.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(53, 286);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 3;
            label3.Text = "Quirofano";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(437, 552);
            label4.Name = "label4";
            label4.Size = new Size(189, 25);
            label4.TabIndex = 5;
            label4.Text = "Fecha de realizacion:";
            // 
            // fecha
            // 
            fecha.Location = new Point(429, 592);
            fecha.Name = "fecha";
            fecha.Size = new Size(194, 31);
            fecha.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(359, 141);
            label5.Name = "label5";
            label5.Size = new Size(270, 25);
            label5.TabIndex = 7;
            label5.Text = "Descripcion de la intervencion";
            label5.Click += label5_Click;
            // 
            // det
            // 
            det.Location = new Point(359, 180);
            det.Multiline = true;
            det.Name = "det";
            det.Size = new Size(498, 138);
            det.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 324);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(820, 206);
            dataGridView1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.agenda_transparent_7;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(283, 551);
            button1.Name = "button1";
            button1.Size = new Size(112, 82);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // nombre
            // 
            nombre.Location = new Point(169, 180);
            nombre.Name = "nombre";
            nombre.Size = new Size(166, 31);
            nombre.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(56, 186);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 11;
            label6.Text = "Paciente";
            // 
            // id
            // 
            id.Location = new Point(49, 53);
            id.Name = "id";
            id.Size = new Size(33, 31);
            id.TabIndex = 13;
            id.Visible = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(902, 645);
            Controls.Add(id);
            Controls.Add(nombre);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(det);
            Controls.Add(label5);
            Controls.Add(fecha);
            Controls.Add(label4);
            Controls.Add(id_q);
            Controls.Add(label3);
            Controls.Add(id_pac);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox id_pac;
        private TextBox id_q;
        private Label label3;
        private Label label4;
        private DateTimePicker fecha;
        private Label label5;
        private TextBox det;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox nombre;
        private Label label6;
        private TextBox id;
    }
}