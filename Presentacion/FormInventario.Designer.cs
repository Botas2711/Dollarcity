
namespace Presentacion
{
    partial class FormInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventario));
            this.gbInventario = new System.Windows.Forms.GroupBox();
            this.cbSucursal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgInventario = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.bgDetalleBoleta = new System.Windows.Forms.GroupBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.dgProductoInventario = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventario)).BeginInit();
            this.bgDetalleBoleta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductoInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInventario
            // 
            this.gbInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            this.gbInventario.Controls.Add(this.cbSucursal);
            this.gbInventario.Controls.Add(this.label1);
            this.gbInventario.Controls.Add(this.dgInventario);
            this.gbInventario.Controls.Add(this.btnEliminar);
            this.gbInventario.Controls.Add(this.btnRegistrar);
            this.gbInventario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInventario.Location = new System.Drawing.Point(12, 12);
            this.gbInventario.Name = "gbInventario";
            this.gbInventario.Size = new System.Drawing.Size(803, 245);
            this.gbInventario.TabIndex = 2;
            this.gbInventario.TabStop = false;
            this.gbInventario.Text = "Inventario";
            // 
            // cbSucursal
            // 
            this.cbSucursal.Font = new System.Drawing.Font("Poppins", 9F);
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.Location = new System.Drawing.Point(81, 46);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(182, 30);
            this.cbSucursal.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F);
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 41;
            this.label1.Text = "Sucursal";
            // 
            // dgInventario
            // 
            this.dgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInventario.Location = new System.Drawing.Point(283, 29);
            this.dgInventario.Name = "dgInventario";
            this.dgInventario.Size = new System.Drawing.Size(492, 197);
            this.dgInventario.TabIndex = 33;
            this.dgInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInventario_CellClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnEliminar.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnEliminar.Location = new System.Drawing.Point(81, 137);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(182, 33);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnRegistrar.Location = new System.Drawing.Point(81, 93);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(182, 38);
            this.btnRegistrar.TabIndex = 28;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // bgDetalleBoleta
            // 
            this.bgDetalleBoleta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bgDetalleBoleta.Controls.Add(this.lblStock);
            this.bgDetalleBoleta.Controls.Add(this.label3);
            this.bgDetalleBoleta.Controls.Add(this.btnAgregarProducto);
            this.bgDetalleBoleta.Controls.Add(this.dgProductoInventario);
            this.bgDetalleBoleta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgDetalleBoleta.Location = new System.Drawing.Point(12, 273);
            this.bgDetalleBoleta.Name = "bgDetalleBoleta";
            this.bgDetalleBoleta.Size = new System.Drawing.Size(803, 233);
            this.bgDetalleBoleta.TabIndex = 34;
            this.bgDetalleBoleta.TabStop = false;
            this.bgDetalleBoleta.Text = "Producto Inventario";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(678, 77);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(18, 23);
            this.lblStock.TabIndex = 39;
            this.lblStock.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(569, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Stock total:";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.White;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.Green;
            this.btnAgregarProducto.Location = new System.Drawing.Point(573, 41);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(168, 33);
            this.btnAgregarProducto.TabIndex = 33;
            this.btnAgregarProducto.Text = "Gestionar Productos";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // dgProductoInventario
            // 
            this.dgProductoInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductoInventario.Location = new System.Drawing.Point(17, 26);
            this.dgProductoInventario.Name = "dgProductoInventario";
            this.dgProductoInventario.Size = new System.Drawing.Size(521, 192);
            this.dgProductoInventario.TabIndex = 34;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(701, 512);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 27);
            this.btnSalir.TabIndex = 35;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 546);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.bgDetalleBoleta);
            this.Controls.Add(this.gbInventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInventario";
            this.Text = "Inventario";
            this.gbInventario.ResumeLayout(false);
            this.gbInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventario)).EndInit();
            this.bgDetalleBoleta.ResumeLayout(false);
            this.bgDetalleBoleta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductoInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInventario;
        private System.Windows.Forms.DataGridView dgInventario;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox bgDetalleBoleta;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.DataGridView dgProductoInventario;
        private System.Windows.Forms.ComboBox cbSucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
    }
}