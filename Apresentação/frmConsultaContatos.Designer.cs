﻿
namespace agenda001
{
    partial class frmConsultaContatos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btExecutar = new System.Windows.Forms.Button();
            this.dgDados = new System.Windows.Forms.DataGridView();
            this.btLocalizaTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eventos";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(28, 49);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(412, 23);
            this.txtValor.TabIndex = 1;
            // 
            // btExecutar
            // 
            this.btExecutar.Location = new System.Drawing.Point(455, 49);
            this.btExecutar.Name = "btExecutar";
            this.btExecutar.Size = new System.Drawing.Size(143, 23);
            this.btExecutar.TabIndex = 2;
            this.btExecutar.Text = "Localizar eventos";
            this.btExecutar.UseVisualStyleBackColor = true;
            this.btExecutar.Click += new System.EventHandler(this.btExecutar_Click);
            // 
            // dgDados
            // 
            this.dgDados.AllowUserToAddRows = false;
            this.dgDados.AllowUserToDeleteRows = false;
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.Location = new System.Drawing.Point(28, 77);
            this.dgDados.Name = "dgDados";
            this.dgDados.ReadOnly = true;
            this.dgDados.RowTemplate.Height = 25;
            this.dgDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDados.Size = new System.Drawing.Size(724, 454);
            this.dgDados.TabIndex = 3;
            this.dgDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDados_CellDoubleClick);
            // 
            // btLocalizaTodos
            // 
            this.btLocalizaTodos.Location = new System.Drawing.Point(604, 48);
            this.btLocalizaTodos.Name = "btLocalizaTodos";
            this.btLocalizaTodos.Size = new System.Drawing.Size(143, 23);
            this.btLocalizaTodos.TabIndex = 4;
            this.btLocalizaTodos.Text = "Localizar todos eventos";
            this.btLocalizaTodos.UseVisualStyleBackColor = true;
            this.btLocalizaTodos.Click += new System.EventHandler(this.btLocalizaTodos_Click);
            // 
            // frmConsultaContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btLocalizaTodos);
            this.Controls.Add(this.dgDados);
            this.Controls.Add(this.btExecutar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConsultaContatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Eventos";
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btExecutar;
        private System.Windows.Forms.DataGridView dgDados;
        private System.Windows.Forms.Button btLocalizaTodos;
    }
}