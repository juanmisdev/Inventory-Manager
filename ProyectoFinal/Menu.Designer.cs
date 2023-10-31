namespace ProyectoFinal
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            btnAdministrarProductos = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(852, 82);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(366, 107);
            button1.TabIndex = 0;
            button1.Text = "Administrar accesorios";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAdministrarProductos
            // 
            btnAdministrarProductos.Location = new Point(852, 242);
            btnAdministrarProductos.Name = "btnAdministrarProductos";
            btnAdministrarProductos.Size = new Size(366, 109);
            btnAdministrarProductos.TabIndex = 1;
            btnAdministrarProductos.Text = "Administrar Productos";
            btnAdministrarProductos.UseVisualStyleBackColor = true;
            btnAdministrarProductos.Click += button2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(24, 109);
            button2.Name = "button2";
            button2.Size = new Size(257, 191);
            button2.TabIndex = 2;
            button2.Text = "Nuevo Proyecto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 501);
            Controls.Add(button2);
            Controls.Add(btnAdministrarProductos);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Menu";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnAdministrarProductos;
        private Button button2;
    }
}