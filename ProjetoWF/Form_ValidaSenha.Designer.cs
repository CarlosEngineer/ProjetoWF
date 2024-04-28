namespace ProjetoWF
{
    partial class Form_ValidaSenha
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
            this.Txt_Msg = new System.Windows.Forms.TextBox();
            this.Btn_Checar = new System.Windows.Forms.Button();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Btn_VerSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_Msg
            // 
            this.Txt_Msg.Location = new System.Drawing.Point(12, 49);
            this.Txt_Msg.Name = "Txt_Msg";
            this.Txt_Msg.PasswordChar = '*';
            this.Txt_Msg.Size = new System.Drawing.Size(209, 20);
            this.Txt_Msg.TabIndex = 0;
            this.Txt_Msg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Txt_Msg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Msg_KeyDown);
            this.Txt_Msg.ParentChanged += new System.EventHandler(this.Txt_Msg_ParentChanged);
            // 
            // Btn_Checar
            // 
            this.Btn_Checar.Location = new System.Drawing.Point(239, 40);
            this.Btn_Checar.Name = "Btn_Checar";
            this.Btn_Checar.Size = new System.Drawing.Size(113, 37);
            this.Btn_Checar.TabIndex = 1;
            this.Btn_Checar.Text = "Limpar";
            this.Btn_Checar.UseVisualStyleBackColor = true;
            this.Btn_Checar.Click += new System.EventHandler(this.Btn_Checar_Click);
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Senha.Location = new System.Drawing.Point(17, 112);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(139, 30);
            this.Lbl_Senha.TabIndex = 2;
            this.Lbl_Senha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Senha.Click += new System.EventHandler(this.Lbl_Senha_Click);
            // 
            // Btn_VerSenha
            // 
            this.Btn_VerSenha.Location = new System.Drawing.Point(239, 83);
            this.Btn_VerSenha.Name = "Btn_VerSenha";
            this.Btn_VerSenha.Size = new System.Drawing.Size(113, 37);
            this.Btn_VerSenha.TabIndex = 3;
            this.Btn_VerSenha.Text = "Ver Senha";
            this.Btn_VerSenha.UseVisualStyleBackColor = true;
            this.Btn_VerSenha.Click += new System.EventHandler(this.Btn_VerSenha_Click);
            // 
            // Form_ValidaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 169);
            this.Controls.Add(this.Btn_VerSenha);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Btn_Checar);
            this.Controls.Add(this.Txt_Msg);
            this.Name = "Form_ValidaSenha";
            this.Text = "Form_ValidaSenha";
            this.Load += new System.EventHandler(this.Form_ValidaSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Msg;
        private System.Windows.Forms.Button Btn_Checar;
        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.Button Btn_VerSenha;
    }
}