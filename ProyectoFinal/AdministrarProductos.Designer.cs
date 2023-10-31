namespace ProyectoFinal
{
    partial class AdministrarProductos
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
            txtStock = new TextBox();
            label4 = new Label();
            btnInsert = new Button();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            btnBorrar = new Button();
            btnEditar = new Button();
            button1 = new Button();
            btnAgregarAccesorios = new Button();
            button2 = new Button();
            label5 = new Label();
            btnDisminuirCantidad = new Button();
            btnAumentarCantidad = new Button();
            lblCantidad = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // txtStock
            // 
            txtStock.Location = new Point(1036, 151);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(244, 23);
            txtStock.TabIndex = 16;
            txtStock.KeyPress += txtStock_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(966, 154);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 15;
            label4.Text = "Stock:";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(988, 194);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(244, 46);
            btnInsert.TabIndex = 11;
            btnInsert.Text = "Agregar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click_1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(1036, 122);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(244, 23);
            txtPrecio.TabIndex = 14;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(1036, 93);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(244, 23);
            txtDescripcion.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(1036, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(244, 23);
            txtNombre.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(962, 125);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 10;
            label3.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(951, 96);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 9;
            label2.Text = "Descripcion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(951, 67);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(704, 602);
            dataGridView1.TabIndex = 17;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(722, 297);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(682, 317);
            dataGridView2.TabIndex = 18;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(156, 645);
            btnBorrar.Margin = new Padding(2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(113, 50);
            btnBorrar.TabIndex = 20;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(24, 645);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(127, 50);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(404, 645);
            button1.Name = "button1";
            button1.Size = new Size(139, 50);
            button1.TabIndex = 21;
            button1.Text = "Ver todos los accesorios";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAgregarAccesorios
            // 
            btnAgregarAccesorios.Location = new Point(1133, 642);
            btnAgregarAccesorios.Name = "btnAgregarAccesorios";
            btnAgregarAccesorios.Size = new Size(161, 50);
            btnAgregarAccesorios.TabIndex = 22;
            btnAgregarAccesorios.Text = "Agregar accesorios";
            btnAgregarAccesorios.UseVisualStyleBackColor = true;
            btnAgregarAccesorios.Click += btnAgregarAccesorios_Click;
            // 
            // button2
            // 
            button2.Location = new Point(274, 645);
            button2.Name = "button2";
            button2.Size = new Size(124, 50);
            button2.TabIndex = 23;
            button2.Text = "Ver accesorios del producto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(871, 660);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 27;
            label5.Text = "Cantidad de accesorios:";
            // 
            // btnDisminuirCantidad
            // 
            btnDisminuirCantidad.FlatStyle = FlatStyle.Flat;
            btnDisminuirCantidad.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnDisminuirCantidad.Image = Properties.Resources.flecha_abajo;
            btnDisminuirCantidad.Location = new Point(1007, 668);
            btnDisminuirCantidad.Margin = new Padding(2);
            btnDisminuirCantidad.Name = "btnDisminuirCantidad";
            btnDisminuirCantidad.Size = new Size(39, 31);
            btnDisminuirCantidad.TabIndex = 26;
            btnDisminuirCantidad.UseVisualStyleBackColor = true;
            btnDisminuirCantidad.Click += btnDisminuirCantidad_Click;
            // 
            // btnAumentarCantidad
            // 
            btnAumentarCantidad.FlatStyle = FlatStyle.Flat;
            btnAumentarCantidad.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnAumentarCantidad.Image = Properties.Resources.flecha_arriba;
            btnAumentarCantidad.Location = new Point(1007, 635);
            btnAumentarCantidad.Margin = new Padding(2);
            btnAumentarCantidad.Name = "btnAumentarCantidad";
            btnAumentarCantidad.Size = new Size(39, 29);
            btnAumentarCantidad.TabIndex = 25;
            btnAumentarCantidad.UseVisualStyleBackColor = true;
            btnAumentarCantidad.Click += btnAumentarCantidad_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidad.Location = new Point(1073, 648);
            lblCantidad.Margin = new Padding(2, 0, 2, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(24, 30);
            lblCantidad.TabIndex = 24;
            lblCantidad.Text = "1";
            // 
            // AdministrarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1409, 722);
            Controls.Add(label5);
            Controls.Add(btnDisminuirCantidad);
            Controls.Add(btnAumentarCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(button2);
            Controls.Add(btnAgregarAccesorios);
            Controls.Add(button1);
            Controls.Add(btnBorrar);
            Controls.Add(btnEditar);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(txtStock);
            Controls.Add(label4);
            Controls.Add(btnInsert);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "AdministrarProductos";
            Text = "AdministrarProductos";
            Load += AdministrarProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStock;
        private Label label4;
        private Button btnInsert;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button btnBorrar;
        private Button btnEditar;
        private Button button1;
        private Button btnAgregarAccesorios;
        private Button button2;
        private Label label5;
        private Button btnDisminuirCantidad;
        private Button btnAumentarCantidad;
        private Label lblCantidad;
    }
}