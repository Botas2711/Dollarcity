
namespace Presentacion
{
    partial class FormCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoria));
            this.dgCategorias = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.btnEliminarLogico = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCategorias
            // 
            this.dgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategorias.Location = new System.Drawing.Point(328, 22);
            this.dgCategorias.Name = "dgCategorias";
            this.dgCategorias.Size = new System.Drawing.Size(399, 177);
            this.dgCategorias.TabIndex = 41;
            this.dgCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategorias_CellClick);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnModificar.Location = new System.Drawing.Point(156, 181);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 31);
            this.btnModificar.TabIndex = 39;
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
            this.btnEliminarFisico.Location = new System.Drawing.Point(156, 129);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(123, 31);
            this.btnEliminarFisico.TabIndex = 38;
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
            this.btnEliminarLogico.Location = new System.Drawing.Point(25, 181);
            this.btnEliminarLogico.Name = "btnEliminarLogico";
            this.btnEliminarLogico.Size = new System.Drawing.Size(116, 31);
            this.btnEliminarLogico.TabIndex = 37;
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
            this.btnRegistrar.Location = new System.Drawing.Point(27, 129);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(114, 31);
            this.btnRegistrar.TabIndex = 36;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(101, 66);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(178, 27);
            this.tbNombre.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OliveDrab;
            this.label6.Location = new System.Drawing.Point(19, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 30);
            this.label6.TabIndex = 46;
            this.label6.Text = "Registro de categoria";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSalir.Location = new System.Drawing.Point(634, 205);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 26);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(746, 243);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgCategorias);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnEliminarLogico);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCategoria";
            this.Text = "Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCategorias;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Button btnEliminarLogico;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalir;
    }
}