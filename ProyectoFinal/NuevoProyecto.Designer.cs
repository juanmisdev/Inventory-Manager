namespace ProyectoFinal
{
    partial class NuevoProyecto
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
            lblCantidad = new Label();
            btnAumentarCantidad = new Button();
            button1 = new Button();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            button2 = new Button();
            btnExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 7);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(582, 537);
            dataGridView1.TabIndex = 0;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidad.Location = new Point(1036, 46);
            lblCantidad.Margin = new Padding(2, 0, 2, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(24, 30);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "1";
            lblCantidad.Click += lblCantidad_Click;
            // 
            // btnAumentarCantidad
            // 
            btnAumentarCantidad.FlatStyle = FlatStyle.Flat;
            btnAumentarCantidad.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnAumentarCantidad.Image = Properties.Resources.flecha_arriba;
            btnAumentarCantidad.Location = new Point(970, 33);
            btnAumentarCantidad.Margin = new Padding(2, 2, 2, 2);
            btnAumentarCantidad.Name = "btnAumentarCantidad";
            btnAumentarCantidad.Size = new Size(39, 29);
            btnAumentarCantidad.TabIndex = 2;
            btnAumentarCantidad.UseVisualStyleBackColor = true;
            btnAumentarCantidad.Click += button1_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources.flecha_abajo;
            button1.Location = new Point(970, 66);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(39, 31);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(900, 58);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 4;
            label1.Text = "Cantidad:";
            label1.Click += label1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(690, 187);
            dataGridView2.Margin = new Padding(2, 2, 2, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(583, 357);
            dataGridView2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(919, 134);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 6;
            label2.Text = "Inventario del proyecto:";
            // 
            // button2
            // 
            button2.Location = new Point(8, 567);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(145, 32);
            button2.TabIndex = 7;
            button2.Text = "Agregar producto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(699, 567);
            btnExcel.Margin = new Padding(2, 2, 2, 2);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(137, 32);
            btnExcel.TabIndex = 8;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // NuevoProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 613);
            Controls.Add(btnExcel);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnAumentarCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "NuevoProyecto";
            Text = "Form1";
            Load += NuevoProyecto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblCantidad;
        private Button btnAumentarCantidad;
        private Button button1;
        private Label label1;
        private DataGridView dataGridView2;
        private Label label2;
        private Button button2;
        private Button btnExcel;
    }
}