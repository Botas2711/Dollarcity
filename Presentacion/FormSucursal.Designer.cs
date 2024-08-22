
namespace Presentacion
{
    partial class FormSucursal
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDistrito = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.btnEliminarLogico = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgSucursales = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgSucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(35, 91);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(181, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // tbDistrito
            // 
            this.tbDistrito.Location = new System.Drawing.Point(35, 139);
            this.tbDistrito.Name = "tbDistrito";
            this.tbDistrito.Size = new System.Drawing.Size(181, 20);
            this.tbDistrito.TabIndex = 3;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnModificar.Location = new System.Drawing.Point(35, 219);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(181, 29);
            this.btnModificar.TabIndex = 25;
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
            this.btnEliminarFisico.Location = new System.Drawing.Point(393, 278);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(120, 34);
            this.btnEliminarFisico.TabIndex = 24;
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
            this.btnEliminarLogico.Location = new System.Drawing.Point(259, 278);
            this.btnEliminarLogico.Name = "btnEliminarLogico";
            this.btnEliminarLogico.Size = new System.Drawing.Size(128, 34);
            this.btnEliminarLogico.TabIndex = 23;
            this.btnEliminarLogico.Text = "Eliminar Logico";
            this.btnEliminarLogico.UseVisualStyleBackColor = false;
            this.btnEliminarLogico.Click += new System.EventHandler(this.btnEliminarLogico_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(35, 178);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(181, 35);
            this.btnRegistrar.TabIndex = 22;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgSucursales
            // 
            this.dgSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSucursales.Location = new System.Drawing.Point(259, 66);
            this.dgSucursales.Name = "dgSucursales";
            this.dgSucursales.Size = new System.Drawing.Size(423, 192);
            this.dgSucursales.TabIndex = 27;
            this.dgSucursales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSucursales_CellClick);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSalir.Location = new System.Drawing.Point(579, 278);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 34);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OliveDrab;
            this.label6.Location = new System.Drawing.Point(30, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 30);
            this.label6.TabIndex = 46;
            this.label6.Text = "Registro de sucursal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 45;
            this.label3.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 47;
            this.label1.Text = "Distrito";
            // 
            // FormSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(711, 340);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgSucursales);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnEliminarLogico);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbDistrito);
            this.Controls.Add(this.tbNombre);
            this.Name = "FormSucursal";
            this.Text = "Sucursal";
            ((System.ComponentModel.ISupportInitialize)(this.dgSucursales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDistrito;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Button btnEliminarLogico;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgSucursales;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}