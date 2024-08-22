
namespace Presentacion
{
    partial class FormReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporte));
            this.btnSalir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnVerVentasdeVendedor = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnVerProductosMenosStock = new System.Windows.Forms.Button();
            this.pnlRep3 = new System.Windows.Forms.Panel();
            this.btnVerCategoriasMasVendidas = new System.Windows.Forms.Button();
            this.pnlRep2 = new System.Windows.Forms.Panel();
            this.btnVerProductosMasVendidos = new System.Windows.Forms.Button();
            this.pnlRep1 = new System.Windows.Forms.Panel();
            this.btnVerSucursalesConMasVentas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlRep3.SuspendLayout();
            this.pnlRep2.SuspendLayout();
            this.pnlRep1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(3, 172);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 52);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Poppins", 8F);
            this.label7.Location = new System.Drawing.Point(73, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Productos con stock bajo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Poppins", 8F);
            this.label8.Location = new System.Drawing.Point(504, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "Categorías más vendidas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Poppins", 8F);
            this.label9.Location = new System.Drawing.Point(298, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Productos más vendidos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Poppins", 8F);
            this.label10.Location = new System.Drawing.Point(73, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "Sucursales con más ventas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Poppins", 8F);
            this.label11.Location = new System.Drawing.Point(299, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 19);
            this.label11.TabIndex = 28;
            this.label11.Text = "Ver ventas por vendedor";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btnVerVentasdeVendedor);
            this.panel5.Font = new System.Drawing.Font("Poppins", 8F);
            this.panel5.Location = new System.Drawing.Point(298, 218);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(144, 139);
            this.panel5.TabIndex = 32;
            // 
            // btnVerVentasdeVendedor
            // 
            this.btnVerVentasdeVendedor.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVerVentasdeVendedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerVentasdeVendedor.BackgroundImage")));
            this.btnVerVentasdeVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerVentasdeVendedor.FlatAppearance.BorderSize = 0;
            this.btnVerVentasdeVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerVentasdeVendedor.Location = new System.Drawing.Point(3, 3);
            this.btnVerVentasdeVendedor.Name = "btnVerVentasdeVendedor";
            this.btnVerVentasdeVendedor.Size = new System.Drawing.Size(129, 125);
            this.btnVerVentasdeVendedor.TabIndex = 0;
            this.btnVerVentasdeVendedor.UseVisualStyleBackColor = false;
            this.btnVerVentasdeVendedor.Click += new System.EventHandler(this.btnVerVentasdeVendedor_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnVerProductosMenosStock);
            this.panel4.Font = new System.Drawing.Font("Poppins", 8F);
            this.panel4.Location = new System.Drawing.Point(77, 218);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(144, 139);
            this.panel4.TabIndex = 31;
            // 
            // btnVerProductosMenosStock
            // 
            this.btnVerProductosMenosStock.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVerProductosMenosStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerProductosMenosStock.BackgroundImage")));
            this.btnVerProductosMenosStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerProductosMenosStock.FlatAppearance.BorderSize = 0;
            this.btnVerProductosMenosStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerProductosMenosStock.Location = new System.Drawing.Point(8, 7);
            this.btnVerProductosMenosStock.Name = "btnVerProductosMenosStock";
            this.btnVerProductosMenosStock.Size = new System.Drawing.Size(124, 121);
            this.btnVerProductosMenosStock.TabIndex = 0;
            this.btnVerProductosMenosStock.UseVisualStyleBackColor = false;
            this.btnVerProductosMenosStock.Click += new System.EventHandler(this.btnVerProductosMenosStock_Click);
            // 
            // pnlRep3
            // 
            this.pnlRep3.BackColor = System.Drawing.Color.White;
            this.pnlRep3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRep3.Controls.Add(this.btnVerCategoriasMasVendidas);
            this.pnlRep3.Location = new System.Drawing.Point(508, 30);
            this.pnlRep3.Name = "pnlRep3";
            this.pnlRep3.Size = new System.Drawing.Size(144, 139);
            this.pnlRep3.TabIndex = 30;
            // 
            // btnVerCategoriasMasVendidas
            // 
            this.btnVerCategoriasMasVendidas.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVerCategoriasMasVendidas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerCategoriasMasVendidas.BackgroundImage")));
            this.btnVerCategoriasMasVendidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerCategoriasMasVendidas.FlatAppearance.BorderSize = 0;
            this.btnVerCategoriasMasVendidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCategoriasMasVendidas.Location = new System.Drawing.Point(4, 5);
            this.btnVerCategoriasMasVendidas.Name = "btnVerCategoriasMasVendidas";
            this.btnVerCategoriasMasVendidas.Size = new System.Drawing.Size(128, 121);
            this.btnVerCategoriasMasVendidas.TabIndex = 0;
            this.btnVerCategoriasMasVendidas.UseVisualStyleBackColor = false;
            this.btnVerCategoriasMasVendidas.Click += new System.EventHandler(this.btnVerCategoriasMasVendidas_Click);
            // 
            // pnlRep2
            // 
            this.pnlRep2.BackColor = System.Drawing.Color.White;
            this.pnlRep2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRep2.Controls.Add(this.btnVerProductosMasVendidos);
            this.pnlRep2.Location = new System.Drawing.Point(298, 30);
            this.pnlRep2.Name = "pnlRep2";
            this.pnlRep2.Size = new System.Drawing.Size(144, 139);
            this.pnlRep2.TabIndex = 29;
            // 
            // btnVerProductosMasVendidos
            // 
            this.btnVerProductosMasVendidos.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVerProductosMasVendidos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerProductosMasVendidos.BackgroundImage")));
            this.btnVerProductosMasVendidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerProductosMasVendidos.FlatAppearance.BorderSize = 0;
            this.btnVerProductosMasVendidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerProductosMasVendidos.Location = new System.Drawing.Point(8, 7);
            this.btnVerProductosMasVendidos.Name = "btnVerProductosMasVendidos";
            this.btnVerProductosMasVendidos.Size = new System.Drawing.Size(124, 121);
            this.btnVerProductosMasVendidos.TabIndex = 0;
            this.btnVerProductosMasVendidos.UseVisualStyleBackColor = false;
            this.btnVerProductosMasVendidos.Click += new System.EventHandler(this.btnVerProductosMasVendidos_Click);
            // 
            // pnlRep1
            // 
            this.pnlRep1.BackColor = System.Drawing.Color.White;
            this.pnlRep1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRep1.Controls.Add(this.btnVerSucursalesConMasVentas);
            this.pnlRep1.Location = new System.Drawing.Point(77, 30);
            this.pnlRep1.Name = "pnlRep1";
            this.pnlRep1.Size = new System.Drawing.Size(144, 139);
            this.pnlRep1.TabIndex = 23;
            // 
            // btnVerSucursalesConMasVentas
            // 
            this.btnVerSucursalesConMasVentas.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVerSucursalesConMasVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerSucursalesConMasVentas.BackgroundImage")));
            this.btnVerSucursalesConMasVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerSucursalesConMasVentas.FlatAppearance.BorderSize = 0;
            this.btnVerSucursalesConMasVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerSucursalesConMasVentas.Location = new System.Drawing.Point(3, 5);
            this.btnVerSucursalesConMasVentas.Name = "btnVerSucursalesConMasVentas";
            this.btnVerSucursalesConMasVentas.Size = new System.Drawing.Size(134, 123);
            this.btnVerSucursalesConMasVentas.TabIndex = 0;
            this.btnVerSucursalesConMasVentas.UseVisualStyleBackColor = false;
            this.btnVerSucursalesConMasVentas.Click += new System.EventHandler(this.btnVerSucursalesConMasVentas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 400);
            this.panel1.TabIndex = 33;
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(683, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlRep3);
            this.Controls.Add(this.pnlRep2);
            this.Controls.Add(this.pnlRep1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReporte";
            this.Text = "Reportes";
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlRep3.ResumeLayout(false);
            this.pnlRep2.ResumeLayout(false);
            this.pnlRep1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnVerVentasdeVendedor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnVerProductosMenosStock;
        private System.Windows.Forms.Panel pnlRep3;
        private System.Windows.Forms.Button btnVerCategoriasMasVendidas;
        private System.Windows.Forms.Panel pnlRep2;
        private System.Windows.Forms.Button btnVerProductosMasVendidos;
        private System.Windows.Forms.Panel pnlRep1;
        private System.Windows.Forms.Button btnVerSucursalesConMasVentas;
        private System.Windows.Forms.Panel panel1;
    }
}