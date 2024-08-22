
namespace Presentacion
{
    partial class FormInicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicioSesion));
            this.tbContrasenia = new System.Windows.Forms.TextBox();
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbContrasenia
            // 
            this.tbContrasenia.Location = new System.Drawing.Point(241, 183);
            this.tbContrasenia.Name = "tbContrasenia";
            this.tbContrasenia.Size = new System.Drawing.Size(179, 20);
            this.tbContrasenia.TabIndex = 9;
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.Location = new System.Drawing.Point(241, 135);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(179, 20);
            this.tbNombreUsuario.TabIndex = 8;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIniciarSesion.BackgroundImage")));
            this.btnIniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Sans Serif Collection", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesion.Location = new System.Drawing.Point(241, 219);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(179, 33);
            this.btnIniciarSesion.TabIndex = 26;
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sans Serif Collection", 4.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(238, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sans Serif Collection", 4.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(238, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nombre de usuario";
            // 
            // FormInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(658, 368);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbContrasenia);
            this.Controls.Add(this.tbNombreUsuario);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInicioSesion";
            this.Text = "Inicio de Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbContrasenia;
        private System.Windows.Forms.TextBox tbNombreUsuario;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

