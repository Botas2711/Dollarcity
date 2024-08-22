
namespace Presentacion
{
    partial class FormVentasVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentasVendedor));
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.btnListarVentas = new System.Windows.Forms.Button();
            this.dgVentas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVentas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.Location = new System.Drawing.Point(291, 65);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(221, 20);
            this.tbNombreUsuario.TabIndex = 2;
            // 
            // btnListarVentas
            // 
            this.btnListarVentas.BackColor = System.Drawing.Color.Olive;
            this.btnListarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarVentas.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.btnListarVentas.ForeColor = System.Drawing.Color.White;
            this.btnListarVentas.Location = new System.Drawing.Point(538, 62);
            this.btnListarVentas.Name = "btnListarVentas";
            this.btnListarVentas.Size = new System.Drawing.Size(138, 27);
            this.btnListarVentas.TabIndex = 3;
            this.btnListarVentas.Text = "Listar Ventas";
            this.btnListarVentas.UseVisualStyleBackColor = false;
            this.btnListarVentas.Click += new System.EventHandler(this.btnListarVentas_Click);
            // 
            // dgVentas
            // 
            this.dgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVentas.Location = new System.Drawing.Point(86, 104);
            this.dgVentas.Name = "dgVentas";
            this.dgVentas.Size = new System.Drawing.Size(590, 269);
            this.dgVentas.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 410);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(81, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 22);
            this.label3.TabIndex = 56;
            this.label3.Text = "Nombre de usuario del vendedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(80, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 26);
            this.label4.TabIndex = 55;
            this.label4.Text = "Listar ventas de vendedor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormVentasVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 403);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgVentas);
            this.Controls.Add(this.btnListarVentas);
            this.Controls.Add(this.tbNombreUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVentasVendedor";
            this.Text = "Ventas por Vendedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgVentas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNombreUsuario;
        private System.Windows.Forms.Button btnListarVentas;
        private System.Windows.Forms.DataGridView dgVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}