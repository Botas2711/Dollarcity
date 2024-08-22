
namespace Presentacion
{
    partial class FormProductoInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductoInventario));
            this.lblStock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgProductoInventario = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductoInventario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold);
            this.lblStock.Location = new System.Drawing.Point(379, 313);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(17, 19);
            this.lblStock.TabIndex = 48;
            this.lblStock.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(290, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Stock Total:";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnModificar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnModificar.Location = new System.Drawing.Point(148, 253);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 30);
            this.btnModificar.TabIndex = 45;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnEliminar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEliminar.Location = new System.Drawing.Point(148, 207);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 30);
            this.btnEliminar.TabIndex = 44;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Olive;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Poppins", 9F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(148, 161);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(125, 35);
            this.btnRegistrar.TabIndex = 43;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(152, 119);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(121, 20);
            this.tbStock.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F);
            this.label2.Location = new System.Drawing.Point(82, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 41;
            this.label2.Text = "Stock";
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(152, 69);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(121, 21);
            this.cbProducto.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F);
            this.label1.Location = new System.Drawing.Point(82, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "Producto";
            // 
            // dgProductoInventario
            // 
            this.dgProductoInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductoInventario.Location = new System.Drawing.Point(293, 68);
            this.dgProductoInventario.Name = "dgProductoInventario";
            this.dgProductoInventario.Size = new System.Drawing.Size(489, 232);
            this.dgProductoInventario.TabIndex = 38;
            this.dgProductoInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductoInventario_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 357);
            this.panel1.TabIndex = 55;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(3, 144);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 52);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(81, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 26);
            this.label4.TabIndex = 56;
            this.label4.Text = "Agregar productos al inventario";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormProductoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 354);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgProductoInventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProductoInventario";
            this.Text = "Producto Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgProductoInventario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgProductoInventario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label4;
    }
}