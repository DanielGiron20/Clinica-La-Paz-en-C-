namespace ProyectoClinica
{
    partial class FormPacientes
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button2 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1719, 817);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1239, 823);
            button1.Name = "button1";
            button1.Size = new Size(249, 106);
            button1.TabIndex = 1;
            button1.Text = "Eliminar paciente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(12, 823);
            button3.Name = "button3";
            button3.Size = new Size(256, 106);
            button3.TabIndex = 3;
            button3.Text = "Cobrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(268, 823);
            button4.Name = "button4";
            button4.Size = new Size(256, 106);
            button4.TabIndex = 4;
            button4.Text = "Agregar cargo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(524, 823);
            button5.Name = "button5";
            button5.Size = new Size(228, 106);
            button5.TabIndex = 5;
            button5.Text = "Hospitalizar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(757, 823);
            button2.Name = "button2";
            button2.Size = new Size(236, 106);
            button2.TabIndex = 6;
            button2.Text = "Ingresar Paciente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(999, 823);
            button6.Name = "button6";
            button6.Size = new Size(234, 106);
            button6.TabIndex = 7;
            button6.Text = "Modificar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // FormPacientes
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1775, 975);
            ControlBox = false;
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 4, 6, 4);
            Name = "FormPacientes";
            Text = "Pacientes";
            Load += FormPacientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button2;
        private Button button6;
    }
}