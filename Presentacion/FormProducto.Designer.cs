namespace Presentacion
{
    partial class FormProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCantidadTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrecioProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.btnEliminarLogico = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 8.7F);
            this.label1.Location = new System.Drawing.Point(23, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(27, 89);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(271, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(27, 137);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(271, 20);
            this.tbDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 8.7F);
            this.label2.Location = new System.Drawing.Point(23, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // tbCantidadTotal
            // 
            this.tbCantidadTotal.Location = new System.Drawing.Point(127, 171);
            this.tbCantidadTotal.Name = "tbCantidadTotal";
            this.tbCantidadTotal.Size = new System.Drawing.Size(171, 20);
            this.tbCantidadTotal.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 8.7F);
            this.label3.Location = new System.Drawing.Point(23, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad Total";
            // 
            // tbPrecioProducto
            // 
            this.tbPrecioProducto.Location = new System.Drawing.Point(127, 203);
            this.tbPrecioProducto.Name = "tbPrecioProducto";
            this.tbPrecioProducto.Size = new System.Drawing.Size(171, 20);
            this.tbPrecioProducto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 8.7F);
            this.label4.Location = new System.Drawing.Point(23, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 8.7F);
            this.label5.Location = new System.Drawing.Point(23, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(127, 239);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(171, 21);
            this.cbCategoria.TabIndex = 9;
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Location = new System.Drawing.Point(325, 48);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.Size = new System.Drawing.Size(507, 270);
            this.dgProductos.TabIndex = 10;
            this.dgProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellClick);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnModificar.Location = new System.Drawing.Point(189, 338);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(109, 26);
            this.btnModificar.TabIndex = 43;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.BackColor = System.Drawing.Color.White;
            this.btnEliminarFisico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFisico.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold);
            this.btnEliminarFisico.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEliminarFisico.Location = new System.Drawing.Point(325, 338);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(123, 26);
            this.btnEliminarFisico.TabIndex = 42;
            this.btnEliminarFisico.Text = "Eliminar Fisico";
            this.btnEliminarFisico.UseVisualStyleBackColor = false;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // btnEliminarLogico
            // 
            this.btnEliminarLogico.BackColor = System.Drawing.Color.White;
            this.btnEliminarLogico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarLogico.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold);
            this.btnEliminarLogico.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEliminarLogico.Location = new System.Drawing.Point(454, 338);
            this.btnEliminarLogico.Name = "btnEliminarLogico";
            this.btnEliminarLogico.Size = new System.Drawing.Size(125, 26);
            this.btnEliminarLogico.TabIndex = 41;
            this.btnEliminarLogico.Text = "Eliminar Logico";
            this.btnEliminarLogico.UseVisualStyleBackColor = false;
            this.btnEliminarLogico.Click += new System.EventHandler(this.btnEliminarLogico_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(27, 338);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(156, 26);
            this.btnRegistrar.TabIndex = 40;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OliveDrab;
            this.label6.Location = new System.Drawing.Point(22, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 30);
            this.label6.TabIndex = 45;
            this.label6.Text = "Registro de producto";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSalir.Location = new System.Drawing.Point(739, 338);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 26);
            this.btnSalir.TabIndex = 46;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(853, 388);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnEliminarLogico);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPrecioProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCantidadTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProducto";
            this.Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCantidadTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrecioProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Button btnEliminarLogico;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalir;
    }
}