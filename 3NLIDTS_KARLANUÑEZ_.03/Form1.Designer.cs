namespace _3NLIDTS_KARLANUÑEZ_._03
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
            this.BttnFC = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnFarenheit = new System.Windows.Forms.Button();
            this.lblConversor = new System.Windows.Forms.Label();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblFahrenhite = new System.Windows.Forms.Label();
            this.tbCelsius = new System.Windows.Forms.TextBox();
            this.tbFahrenheit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BttnFC
            // 
            this.BttnFC.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnFC.ForeColor = System.Drawing.Color.Navy;
            this.BttnFC.Location = new System.Drawing.Point(128, 200);
            this.BttnFC.Name = "BttnFC";
            this.BttnFC.Size = new System.Drawing.Size(140, 79);
            this.BttnFC.TabIndex = 0;
            this.BttnFC.Text = "Convertir C a F";
            this.BttnFC.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Crimson;
            this.btnLimpiar.Location = new System.Drawing.Point(354, 200);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(140, 79);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnFarenheit
            // 
            this.btnFarenheit.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFarenheit.ForeColor = System.Drawing.Color.Navy;
            this.btnFarenheit.Location = new System.Drawing.Point(580, 200);
            this.btnFarenheit.Name = "btnFarenheit";
            this.btnFarenheit.Size = new System.Drawing.Size(140, 79);
            this.btnFarenheit.TabIndex = 2;
            this.btnFarenheit.Text = "Convertir F a C";
            this.btnFarenheit.UseVisualStyleBackColor = true;
            // 
            // lblConversor
            // 
            this.lblConversor.AutoSize = true;
            this.lblConversor.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversor.ForeColor = System.Drawing.Color.Purple;
            this.lblConversor.Location = new System.Drawing.Point(280, 18);
            this.lblConversor.Name = "lblConversor";
            this.lblConversor.Size = new System.Drawing.Size(320, 28);
            this.lblConversor.TabIndex = 3;
            this.lblConversor.Text = "Conversor de Temperatura.";
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsius.Location = new System.Drawing.Point(193, 76);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(164, 24);
            this.lblCelsius.TabIndex = 4;
            this.lblCelsius.Text = "Grados Celsius";
            // 
            // lblFahrenhite
            // 
            this.lblFahrenhite.AutoSize = true;
            this.lblFahrenhite.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenhite.Location = new System.Drawing.Point(500, 76);
            this.lblFahrenhite.Name = "lblFahrenhite";
            this.lblFahrenhite.Size = new System.Drawing.Size(198, 24);
            this.lblFahrenhite.TabIndex = 5;
            this.lblFahrenhite.Text = "Grados Fahrenhite";
            // 
            // tbCelsius
            // 
            this.tbCelsius.Location = new System.Drawing.Point(197, 103);
            this.tbCelsius.Name = "tbCelsius";
            this.tbCelsius.Size = new System.Drawing.Size(160, 20);
            this.tbCelsius.TabIndex = 6;
            // 
            // tbFahrenheit
            // 
            this.tbFahrenheit.Location = new System.Drawing.Point(504, 103);
            this.tbFahrenheit.Name = "tbFahrenheit";
            this.tbFahrenheit.Size = new System.Drawing.Size(194, 20);
            this.tbFahrenheit.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbFahrenheit);
            this.Controls.Add(this.tbCelsius);
            this.Controls.Add(this.lblFahrenhite);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.lblConversor);
            this.Controls.Add(this.btnFarenheit);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.BttnFC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BttnFC;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnFarenheit;
        private System.Windows.Forms.Label lblConversor;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblFahrenhite;
        private System.Windows.Forms.TextBox tbCelsius;
        private System.Windows.Forms.TextBox tbFahrenheit;
    }
}

