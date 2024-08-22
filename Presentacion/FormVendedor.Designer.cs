
namespace Presentacion
{
    partial class FormVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendedor));
            this.dgVendedores = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.btnEliminarLogico = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbContrasenia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVendedores
            // 
            this.dgVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendedores.Location = new System.Drawing.Point(274, 61);
            this.dgVendedores.Name = "dgVendedores";
            this.dgVendedores.Size = new System.Drawing.Size(483, 276);
            this.dgVendedores.TabIndex = 37;
            this.dgVendedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVendedores_CellClick);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSalir.Location = new System.Drawing.Point(676, 353);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 39);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnModificar.Location = new System.Drawing.Point(276, 353);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 39);
            this.btnModificar.TabIndex = 35;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.BackColor = System.Drawing.Color.White;
            this.btnEliminarFisico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFisico.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFisico.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEliminarFisico.Location = new System.Drawing.Point(390, 353);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(137, 39);
            this.btnEliminarFisico.TabIndex = 34;
            this.btnEliminarFisico.Text = "Eliminar Fisico";
            this.btnEliminarFisico.UseVisualStyleBackColor = false;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // btnEliminarLogico
            // 
            this.btnEliminarLogico.BackColor = System.Drawing.Color.White;
            this.btnEliminarLogico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarLogico.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarLogico.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEliminarLogico.Location = new System.Drawing.Point(533, 353);
            this.btnEliminarLogico.Name = "btnEliminarLogico";
            this.btnEliminarLogico.Size = new System.Drawing.Size(137, 39);
            this.btnEliminarLogico.TabIndex = 33;
            this.btnEliminarLogico.Text = "Eliminar Logico";
            this.btnEliminarLogico.UseVisualStyleBackColor = false;
            this.btnEliminarLogico.Click += new System.EventHandler(this.btnEliminarLogico_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnRegistrar.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(31, 351);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(202, 41);
            this.btnRegistrar.TabIndex = 32;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tbApellido
            // 
            this.tbApellido.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellido.Location = new System.Drawing.Point(31, 143);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(202, 25);
            this.tbApellido.TabIndex = 31;
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.Window;
            this.tbNombre.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(31, 90);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(202, 25);
            this.tbNombre.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nombre";
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreUsuario.Location = new System.Drawing.Point(31, 196);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(202, 25);
            this.tbNombreUsuario.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 38;
            this.label3.Text = "Nombre Usuario";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreo.Location = new System.Drawing.Point(31, 249);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(202, 25);
            this.tbCorreo.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 40;
            this.label4.Text = "Correo";
            // 
            // tbContrasenia
            // 
            this.tbContrasenia.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContrasenia.Location = new System.Drawing.Point(31, 302);
            this.tbContrasenia.Name = "tbContrasenia";
            this.tbContrasenia.Size = new System.Drawing.Size(202, 25);
            this.tbContrasenia.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 42;
            this.label5.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OliveDrab;
            this.label6.Location = new System.Drawing.Point(28, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 30);
            this.label6.TabIndex = 44;
            this.label6.Text = "Registro de vendedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 9F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(270, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 22);
            this.label7.TabIndex = 45;
            this.label7.Text = "Panel de vendedores";
            // 
            // FormVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(789, 423);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbContrasenia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNombreUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgVendedores);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnEliminarLogico);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVendedor";
            this.Text = "FormVendedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgVendedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVendedores;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Button btnEliminarLogico;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombreUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbContrasenia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}