namespace ProyectoClinica
{
    partial class FormDoctores
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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            cmdEditar = new Button();
            cmdIngresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1536, 836);
            dataGridView1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(249, 842);
            button3.Name = "button3";
            button3.Size = new Size(241, 106);
            button3.TabIndex = 3;
            button3.Text = "Pagar al doctor";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(496, 842);
            button4.Name = "button4";
            button4.Size = new Size(241, 106);
            button4.TabIndex = 4;
            button4.Text = "Cobrar al doctor";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(743, 842);
            button5.Name = "button5";
            button5.Size = new Size(235, 106);
            button5.TabIndex = 5;
            button5.Text = "Registro de consultas";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(2, 842);
            button6.Name = "button6";
            button6.Size = new Size(241, 106);
            button6.TabIndex = 1;
            button6.Text = "Salvar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // cmdEditar
            // 
            cmdEditar.Location = new Point(984, 842);
            cmdEditar.Name = "cmdEditar";
            cmdEditar.Size = new Size(214, 106);
            cmdEditar.TabIndex = 6;
            cmdEditar.Text = "Editar doctor";
            cmdEditar.UseVisualStyleBackColor = true;
            cmdEditar.Click += button1_Click;
            // 
            // cmdIngresar
            // 
            cmdIngresar.Location = new Point(1204, 842);
            cmdIngresar.Name = "cmdIngresar";
            cmdIngresar.Size = new Size(214, 106);
            cmdIngresar.TabIndex = 7;
            cmdIngresar.Text = "Ingresar doctor";
            cmdIngresar.UseVisualStyleBackColor = true;
            cmdIngresar.Click += cmdIngresar_Click;
            // 
            // FormDoctores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1536, 960);
            ControlBox = false;
            Controls.Add(cmdIngresar);
            Controls.Add(cmdEditar);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(dataGridView1);
            Margin = new Padding(4);
            Name = "FormDoctores";
            Text = "Doctores";
            Load += FormDoctores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button cmdEditar;
        private Button cmdIngresar;
    }
}