﻿namespace _5AIA
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnScalaberni = new System.Windows.Forms.Button();
            this.btnGabrieleStefani = new System.Windows.Forms.Button();
            this.btnMattiaRanfagni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnScalaberni
            // 
            this.btnScalaberni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnScalaberni.Location = new System.Drawing.Point(12, 231);
            this.btnScalaberni.Name = "btnScalaberni";
            this.btnScalaberni.Size = new System.Drawing.Size(154, 23);
            this.btnScalaberni.TabIndex = 0;
            this.btnScalaberni.Text = "Scalaberni Giulia";
            this.btnScalaberni.UseVisualStyleBackColor = true;
            this.btnScalaberni.Click += new System.EventHandler(this.btnScalaberni_Click);
            // 
            // btnGabrieleStefani
            // 
            this.btnGabrieleStefani.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGabrieleStefani.Location = new System.Drawing.Point(12, 12);
            this.btnGabrieleStefani.Name = "btnGabrieleStefani";
            this.btnGabrieleStefani.Size = new System.Drawing.Size(106, 23);
            this.btnGabrieleStefani.TabIndex = 0;
            this.btnGabrieleStefani.Text = "Gabriele Stefani";
            this.btnGabrieleStefani.UseVisualStyleBackColor = true;
            this.btnGabrieleStefani.Click += new System.EventHandler(this.btnGabrieleStefani_Click);
            // 
            // btnMattiaRanfagni
            // 
            this.btnMattiaRanfagni.Location = new System.Drawing.Point(124, 12);
            this.btnMattiaRanfagni.Name = "btnMattiaRanfagni";
            this.btnMattiaRanfagni.Size = new System.Drawing.Size(109, 23);
            this.btnMattiaRanfagni.TabIndex = 1;
            this.btnMattiaRanfagni.Text = "Mattia Ranfagni";
            this.btnMattiaRanfagni.UseVisualStyleBackColor = true;
            this.btnMattiaRanfagni.Click += new System.EventHandler(this.btnMattiaRanfagni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMattiaRanfagni);
            this.Controls.Add(this.btnScalaberni);
            this.Controls.Add(this.btnGabrieleStefani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Button btnScalaberni;
        private System.Windows.Forms.Button btnGabrieleStefani;
        private System.Windows.Forms.Button btnMattiaRanfagni;
    }
}

