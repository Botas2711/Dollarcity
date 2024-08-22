namespace Presentacion
{
    partial class FormDetalleBoleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalleBoleta));
            this.dgDetalleBoleta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleBoleta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgDetalleBoleta
            // 
            this.dgDetalleBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleBoleta.Location = new System.Drawing.Point(336, 23);
            this.dgDetalleBoleta.Name = "dgDetalleBoleta";
            this.dgDetalleBoleta.Size = new System.Drawing.Size(489, 259);
            this.dgDetalleBoleta.TabIndex = 0;
            this.dgDetalleBoleta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetalleBoleta_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F);
            this.label1.Location = new System.Drawing.Point(81, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // cbProducto
            // 
            this.cbProducto.Font = new System.Drawing.Font("Poppins", 9F);
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(155, 48);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(152, 30);
            this.cbProducto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F);
            this.label2.Location = new System.Drawing.Point(81, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Poppins", 9F);
            this.tbCantidad.Location = new System.Drawing.Point(155, 95);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(150, 25);
            this.tbCantidad.TabIndex = 4;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnModificar.ForeColor = System.Drawing.Color.Olive;
            this.btnModificar.Location = new System.Drawing.Point(155, 244);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 26);
            this.btnModificar.TabIndex = 34;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnEliminar.ForeColor = System.Drawing.Color.Olive;
            this.btnEliminar.Location = new System.Drawing.Point(155, 198);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 26);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Olive;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(155, 152);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(152, 35);
            this.btnRegistrar.TabIndex = 32;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(332, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(388, 299);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(17, 19);
            this.lblTotal.TabIndex = 37;
            this.lblTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(442, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 346);
            this.panel1.TabIndex = 55;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(6, 137);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 52);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // FormDetalleBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 340);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgDetalleBoleta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDetalleBoleta";
            this.Text = "Detalle Boleta";
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleBoleta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDetalleBoleta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
    }
}