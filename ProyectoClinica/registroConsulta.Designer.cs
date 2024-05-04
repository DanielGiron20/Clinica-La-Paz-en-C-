namespace ProyectoClinica
{
    partial class registroConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registroConsulta));
            label1 = new Label();
            label2 = new Label();
            nombre = new TextBox();
            id_d = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(401, 24);
            label1.Name = "label1";
            label1.Size = new Size(234, 30);
            label1.TabIndex = 0;
            label1.Text = "Registro de consultas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(74, 89);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 1;
            label2.Text = "Doctor";
            // 
            // nombre
            // 
            nombre.Location = new Point(170, 86);
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Size = new Size(256, 31);
            nombre.TabIndex = 3;
            // 
            // id_d
            // 
            id_d.Location = new Point(524, 86);
            id_d.Name = "id_d";
            id_d.ReadOnly = true;
            id_d.Size = new Size(58, 31);
            id_d.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(488, 89);
            label3.Name = "label3";
            label3.Size = new Size(31, 25);
            label3.TabIndex = 4;
            label3.Text = "ID";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 197);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(887, 477);
            dataGridView1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(39, 155);
            label4.Name = "label4";
            label4.Size = new Size(423, 25);
            label4.TabIndex = 7;
            label4.Text = "Pacientes atendidos por el medico seleccionado:";
            // 
            // registroConsulta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(969, 686);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(id_d);
            Controls.Add(label3);
            Controls.Add(nombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "registroConsulta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            Load += registroConsulta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nombre;
        private TextBox id_d;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label4;
    }
}