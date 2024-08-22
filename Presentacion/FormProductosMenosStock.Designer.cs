
namespace Presentacion
{
    partial class FormProductosMenosStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductosMenosStock));
            this.cbSucursal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSucursal
            // 
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.Location = new System.Drawing.Point(147, 74);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(200, 21);
            this.cbSucursal.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.label2.Location = new System.Drawing.Point(75, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Sucursal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(73, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 26);
            this.label1.TabIndex = 38;
            this.label1.Text = "Productos con Stock Bajo";
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Location = new System.Drawing.Point(78, 118);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.Size = new System.Drawing.Size(512, 283);
            this.dgProductos.TabIndex = 39;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Olive;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.btnListar.ForeColor = System.Drawing.Color.White;
            this.btnListar.Location = new System.Drawing.Point(439, 70);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(151, 31);
            this.btnListar.TabIndex = 40;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 431);
            this.panel1.TabIndex = 54;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(3, 193);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 52);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormProductosMenosStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 429);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSucursal);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProductosMenosStock";
            this.Text = "Productos con menos Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
    }
}