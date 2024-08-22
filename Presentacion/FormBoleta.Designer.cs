namespace Presentacion
{
    partial class FormBoleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoleta));
            this.gbBoleta = new System.Windows.Forms.GroupBox();
            this.dgBoleta = new System.Windows.Forms.DataGridView();
            this.cbSucursal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.bgDetalleBoleta = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.dgDetalleBoleta = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbBoleta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBoleta)).BeginInit();
            this.bgDetalleBoleta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleBoleta)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBoleta
            // 
            this.gbBoleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            this.gbBoleta.Controls.Add(this.dgBoleta);
            this.gbBoleta.Controls.Add(this.cbSucursal);
            this.gbBoleta.Controls.Add(this.label2);
            this.gbBoleta.Controls.Add(this.btnModificar);
            this.gbBoleta.Controls.Add(this.btnEliminar);
            this.gbBoleta.Controls.Add(this.btnRegistrar);
            this.gbBoleta.Controls.Add(this.dpFechaEmision);
            this.gbBoleta.Controls.Add(this.label1);
            this.gbBoleta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBoleta.Location = new System.Drawing.Point(12, 12);
            this.gbBoleta.Name = "gbBoleta";
            this.gbBoleta.Size = new System.Drawing.Size(868, 230);
            this.gbBoleta.TabIndex = 0;
            this.gbBoleta.TabStop = false;
            this.gbBoleta.Text = "Boleta";
            // 
            // dgBoleta
            // 
            this.dgBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBoleta.Location = new System.Drawing.Point(354, 21);
            this.dgBoleta.Name = "dgBoleta";
            this.dgBoleta.Size = new System.Drawing.Size(491, 192);
            this.dgBoleta.TabIndex = 36;
            this.dgBoleta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBoleta_CellClick);
            // 
            // cbSucursal
            // 
            this.cbSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.Location = new System.Drawing.Point(130, 58);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(207, 23);
            this.cbSucursal.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Sucursal";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnModificar.Location = new System.Drawing.Point(189, 178);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(148, 26);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEliminar.Location = new System.Drawing.Point(189, 146);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(148, 26);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRegistrar.Location = new System.Drawing.Point(189, 114);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(148, 26);
            this.btnRegistrar.TabIndex = 28;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dpFechaEmision
            // 
            this.dpFechaEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaEmision.Location = new System.Drawing.Point(130, 25);
            this.dpFechaEmision.Name = "dpFechaEmision";
            this.dpFechaEmision.Size = new System.Drawing.Size(207, 21);
            this.dpFechaEmision.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Emision";
            // 
            // bgDetalleBoleta
            // 
            this.bgDetalleBoleta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bgDetalleBoleta.Controls.Add(this.lblTotal);
            this.bgDetalleBoleta.Controls.Add(this.label3);
            this.bgDetalleBoleta.Controls.Add(this.btnAgregarProducto);
            this.bgDetalleBoleta.Controls.Add(this.dgDetalleBoleta);
            this.bgDetalleBoleta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgDetalleBoleta.Location = new System.Drawing.Point(12, 257);
            this.bgDetalleBoleta.Name = "bgDetalleBoleta";
            this.bgDetalleBoleta.Size = new System.Drawing.Size(868, 233);
            this.bgDetalleBoleta.TabIndex = 1;
            this.bgDetalleBoleta.TabStop = false;
            this.bgDetalleBoleta.Text = "Detalle Boleta";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(617, 75);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(14, 16);
            this.lblTotal.TabIndex = 39;
            this.lblTotal.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Total:";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAgregarProducto.Location = new System.Drawing.Point(556, 22);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(156, 31);
            this.btnAgregarProducto.TabIndex = 33;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // dgDetalleBoleta
            // 
            this.dgDetalleBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleBoleta.Location = new System.Drawing.Point(18, 22);
            this.dgDetalleBoleta.Name = "dgDetalleBoleta";
            this.dgDetalleBoleta.Size = new System.Drawing.Size(506, 192);
            this.dgDetalleBoleta.TabIndex = 34;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSalir.Location = new System.Drawing.Point(787, 496);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 26);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 534);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.bgDetalleBoleta);
            this.Controls.Add(this.gbBoleta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBoleta";
            this.Text = "Boleta";
            this.gbBoleta.ResumeLayout(false);
            this.gbBoleta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBoleta)).EndInit();
            this.bgDetalleBoleta.ResumeLayout(false);
            this.bgDetalleBoleta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleBoleta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBoleta;
        private System.Windows.Forms.GroupBox bgDetalleBoleta;
        private System.Windows.Forms.DateTimePicker dpFechaEmision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.DataGridView dgDetalleBoleta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgBoleta;
    }
}