namespace Ejercicio419
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumM = new System.Windows.Forms.TextBox();
            this.txtNumN = new System.Windows.Forms.TextBox();
            this.btnIterativa = new System.Windows.Forms.Button();
            this.btnRecursiva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor M";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor N";
            // 
            // txtNumM
            // 
            this.txtNumM.Location = new System.Drawing.Point(108, 61);
            this.txtNumM.Name = "txtNumM";
            this.txtNumM.Size = new System.Drawing.Size(87, 20);
            this.txtNumM.TabIndex = 3;
            // 
            // txtNumN
            // 
            this.txtNumN.Location = new System.Drawing.Point(108, 128);
            this.txtNumN.Name = "txtNumN";
            this.txtNumN.Size = new System.Drawing.Size(87, 20);
            this.txtNumN.TabIndex = 4;
            // 
            // btnIterativa
            // 
            this.btnIterativa.Location = new System.Drawing.Point(279, 52);
            this.btnIterativa.Name = "btnIterativa";
            this.btnIterativa.Size = new System.Drawing.Size(123, 37);
            this.btnIterativa.TabIndex = 5;
            this.btnIterativa.Text = "Version Iterativa";
            this.btnIterativa.UseVisualStyleBackColor = true;
            this.btnIterativa.Click += new System.EventHandler(this.btnIterativa_Click);
            // 
            // btnRecursiva
            // 
            this.btnRecursiva.Location = new System.Drawing.Point(279, 119);
            this.btnRecursiva.Name = "btnRecursiva";
            this.btnRecursiva.Size = new System.Drawing.Size(123, 37);
            this.btnRecursiva.TabIndex = 6;
            this.btnRecursiva.Text = "Version Recursiva";
            this.btnRecursiva.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 339);
            this.Controls.Add(this.btnRecursiva);
            this.Controls.Add(this.btnIterativa);
            this.Controls.Add(this.txtNumN);
            this.Controls.Add(this.txtNumM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejercicio 419";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumM;
        private System.Windows.Forms.TextBox txtNumN;
        private System.Windows.Forms.Button btnIterativa;
        private System.Windows.Forms.Button btnRecursiva;
    }
}

