﻿
namespace agenda001
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btContato = new System.Windows.Forms.Button();
            this.btCalculadora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btContato
            // 
            this.btContato.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btContato.Location = new System.Drawing.Point(60, 48);
            this.btContato.Name = "btContato";
            this.btContato.Size = new System.Drawing.Size(277, 178);
            this.btContato.TabIndex = 0;
            this.btContato.Text = "Agenda";
            this.btContato.UseVisualStyleBackColor = true;
            this.btContato.Click += new System.EventHandler(this.btContato_Click);
            // 
            // btCalculadora
            // 
            this.btCalculadora.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCalculadora.Location = new System.Drawing.Point(432, 48);
            this.btCalculadora.Name = "btCalculadora";
            this.btCalculadora.Size = new System.Drawing.Size(277, 178);
            this.btCalculadora.TabIndex = 1;
            this.btCalculadora.Text = "Calculadora";
            this.btCalculadora.UseVisualStyleBackColor = true;
            this.btCalculadora.Click += new System.EventHandler(this.btCalculadora_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btCalculadora);
            this.Controls.Add(this.btContato);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btContato;
        private System.Windows.Forms.Button btCalculadora;
    }
}

