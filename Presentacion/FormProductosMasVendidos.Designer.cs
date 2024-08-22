
namespace Presentacion
{
    partial class FormProductosMasVendidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductosMasVendidos));
            this.btnListar = new System.Windows.Forms.Button();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.cbSucursal = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Olive;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.btnListar.ForeColor = System.Drawing.Color.White;
            this.btnListar.Location = new System.Drawing.Point(481, 62);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(151, 27);
            this.btnListar.TabIndex = 45;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Location = new System.Drawing.Point(88, 95);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.Size = new System.Drawing.Size(544, 289);
            this.dgProductos.TabIndex = 44;
            // 
            // cbSucursal
            // 
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.Location = new System.Drawing.Point(165, 62);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(200, 21);
            this.cbSucursal.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 425);
            this.panel1.TabIndex = 55;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(84, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 58;
            this.label3.Text = "sucursal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(83, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 26);
            this.label4.TabIndex = 57;
            this.label4.Text = "Productos mas vendidos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormProductosMasVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 425);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.cbSucursal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProductosMasVendidos";
            this.Text = "ProductosMasVendidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.ComboBox cbSucursal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}