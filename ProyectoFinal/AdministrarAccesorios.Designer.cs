namespace ProyectoFinal
{
    partial class AdministrarAccesorios
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
            panel1 = new Panel();
            txtStock = new TextBox();
            label4 = new Label();
            btnInsert = new Button();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEditar = new Button();
            btnBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(676, 282);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtStock);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnInsert);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(682, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 310);
            panel1.TabIndex = 2;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(168, 107);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(244, 23);
            txtStock.TabIndex = 7;
            txtStock.TextChanged += txtStock_TextChanged;
            txtStock.KeyPress += txtStock_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 110);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 6;
            label4.Text = "Stock:";
            label4.Click += label4_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(120, 150);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(244, 46);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "Agregar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += button2_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(168, 78);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(244, 23);
            txtPrecio.TabIndex = 5;
            txtPrecio.TextChanged += textBox3_TextChanged;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(168, 49);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(244, 23);
            txtDescripcion.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(168, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(244, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 81);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 52);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripcion:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 23);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(12, 288);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(92, 289);
            btnBorrar.Margin = new Padding(2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(78, 20);
            btnBorrar.TabIndex = 8;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // AdministrarAccesorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 334);
            Controls.Add(btnBorrar);
            Controls.Add(btnEditar);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "AdministrarAccesorios";
            Text = "Form2";
            Load += ProductoAccesorio_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Button btnInsert;
        private Label label4;
        private TextBox txtStock;
        private Button btnEditar;
        private Button btnBorrar;
    }
}