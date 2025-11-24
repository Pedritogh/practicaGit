namespace ejercicioTelegrama
{
    partial class Form1
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
            this.lbltexto = new System.Windows.Forms.Label();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.lblcoste = new System.Windows.Forms.Label();
            this.btnCalcularPrecio = new System.Windows.Forms.Button();
            this.chkUrgente = new System.Windows.Forms.CheckBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbltexto
            // 
            this.lbltexto.AutoSize = true;
            this.lbltexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltexto.Location = new System.Drawing.Point(118, 101);
            this.lbltexto.Name = "lbltexto";
            this.lbltexto.Size = new System.Drawing.Size(90, 32);
            this.lbltexto.TabIndex = 0;
            this.lbltexto.Text = "Texto";
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelegrama.Location = new System.Drawing.Point(124, 136);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(483, 139);
            this.txtTelegrama.TabIndex = 1;
            // 
            // lblcoste
            // 
            this.lblcoste.AutoSize = true;
            this.lblcoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoste.Location = new System.Drawing.Point(128, 355);
            this.lblcoste.Name = "lblcoste";
            this.lblcoste.Size = new System.Drawing.Size(102, 32);
            this.lblcoste.TabIndex = 2;
            this.lblcoste.Text = "Coste:";
            this.lblcoste.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCalcularPrecio
            // 
            this.btnCalcularPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularPrecio.Location = new System.Drawing.Point(414, 313);
            this.btnCalcularPrecio.Name = "btnCalcularPrecio";
            this.btnCalcularPrecio.Size = new System.Drawing.Size(192, 74);
            this.btnCalcularPrecio.TabIndex = 3;
            this.btnCalcularPrecio.Text = "Calcular";
            this.btnCalcularPrecio.UseVisualStyleBackColor = true;
            this.btnCalcularPrecio.Click += new System.EventHandler(this.btnCalcularPrecio_Click);
            // 
            // chkUrgente
            // 
            this.chkUrgente.AutoSize = true;
            this.chkUrgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUrgente.Location = new System.Drawing.Point(128, 305);
            this.chkUrgente.Name = "chkUrgente";
            this.chkUrgente.Size = new System.Drawing.Size(110, 24);
            this.chkUrgente.TabIndex = 4;
            this.chkUrgente.Text = "Urgente?";
            this.chkUrgente.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(236, 361);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(123, 26);
            this.txtPrecio.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.chkUrgente);
            this.Controls.Add(this.btnCalcularPrecio);
            this.Controls.Add(this.lblcoste);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.lbltexto);
            this.Name = "Form1";
            this.Text = "ejercicioTelegrama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltexto;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Label lblcoste;
        private System.Windows.Forms.Button btnCalcularPrecio;
        private System.Windows.Forms.CheckBox chkUrgente;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}

