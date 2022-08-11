
namespace ProjetoLogin.Apresentação
{
    partial class CadastreSe
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
            this.lblLoginCadastro = new System.Windows.Forms.Label();
            this.lblSenhaCadastro = new System.Windows.Forms.Label();
            this.lblConfirmarsenha = new System.Windows.Forms.Label();
            this.txtLoginCadastro = new System.Windows.Forms.TextBox();
            this.txtSenhaCadastro = new System.Windows.Forms.TextBox();
            this.txtConfirmarsenha = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginCadastro
            // 
            this.lblLoginCadastro.AutoSize = true;
            this.lblLoginCadastro.Location = new System.Drawing.Point(50, 55);
            this.lblLoginCadastro.Name = "lblLoginCadastro";
            this.lblLoginCadastro.Size = new System.Drawing.Size(37, 15);
            this.lblLoginCadastro.TabIndex = 0;
            this.lblLoginCadastro.Text = "Login";
            // 
            // lblSenhaCadastro
            // 
            this.lblSenhaCadastro.AutoSize = true;
            this.lblSenhaCadastro.Location = new System.Drawing.Point(50, 126);
            this.lblSenhaCadastro.Name = "lblSenhaCadastro";
            this.lblSenhaCadastro.Size = new System.Drawing.Size(39, 15);
            this.lblSenhaCadastro.TabIndex = 1;
            this.lblSenhaCadastro.Text = "Senha";
            // 
            // lblConfirmarsenha
            // 
            this.lblConfirmarsenha.AutoSize = true;
            this.lblConfirmarsenha.Location = new System.Drawing.Point(50, 207);
            this.lblConfirmarsenha.Name = "lblConfirmarsenha";
            this.lblConfirmarsenha.Size = new System.Drawing.Size(95, 15);
            this.lblConfirmarsenha.TabIndex = 2;
            this.lblConfirmarsenha.Text = "Confirmar senha";
            // 
            // txtLoginCadastro
            // 
            this.txtLoginCadastro.Location = new System.Drawing.Point(50, 86);
            this.txtLoginCadastro.Name = "txtLoginCadastro";
            this.txtLoginCadastro.Size = new System.Drawing.Size(220, 23);
            this.txtLoginCadastro.TabIndex = 3;
            // 
            // txtSenhaCadastro
            // 
            this.txtSenhaCadastro.Location = new System.Drawing.Point(50, 158);
            this.txtSenhaCadastro.Name = "txtSenhaCadastro";
            this.txtSenhaCadastro.PasswordChar = '*';
            this.txtSenhaCadastro.Size = new System.Drawing.Size(220, 23);
            this.txtSenhaCadastro.TabIndex = 4;
            // 
            // txtConfirmarsenha
            // 
            this.txtConfirmarsenha.Location = new System.Drawing.Point(50, 244);
            this.txtConfirmarsenha.Name = "txtConfirmarsenha";
            this.txtConfirmarsenha.PasswordChar = '*';
            this.txtConfirmarsenha.Size = new System.Drawing.Size(220, 23);
            this.txtConfirmarsenha.TabIndex = 5;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(106, 313);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(176, 59);
            this.btCadastrar.TabIndex = 6;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // CadastreSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 417);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.txtConfirmarsenha);
            this.Controls.Add(this.txtSenhaCadastro);
            this.Controls.Add(this.txtLoginCadastro);
            this.Controls.Add(this.lblConfirmarsenha);
            this.Controls.Add(this.lblSenhaCadastro);
            this.Controls.Add(this.lblLoginCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastreSe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastreSe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginCadastro;
        private System.Windows.Forms.Label lblSenhaCadastro;
        private System.Windows.Forms.Label lblConfirmarsenha;
        private System.Windows.Forms.TextBox txtLoginCadastro;
        private System.Windows.Forms.TextBox txtSenhaCadastro;
        private System.Windows.Forms.TextBox txtConfirmarsenha;
        private System.Windows.Forms.Button btCadastrar;
    }
}